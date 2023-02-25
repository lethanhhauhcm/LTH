Imports System.IO
Public Class frmMain
    'Private FEditList As frmEditList
#Region "CustomMethod"
    Private Sub LoadCboFromDir(xCbo As ComboBox)
        Dim mSource, mItems() As String
        Dim i As Integer

        xCbo.SelectedIndex = -1
        xCbo.Items.Clear()
        If Not GetLocation("Source:", mSource) Then Exit Sub
        If Not Directory.Exists(mSource & Split(xCbo.Name, "cbo")(1) & "\" & cboSourceType.Text) Then Exit Sub

        mItems = Directory.GetDirectories(mSource & Split(xCbo.Name, "cbo")(1) & "\" & cboSourceType.Text, "*", SearchOption.TopDirectoryOnly)
        If mItems.Length = 0 Then Exit Sub

        For i = 0 To mItems.Length - 1
            mItems(i) = mItems(i).Substring(mItems(i).LastIndexOf("\") + 1)
        Next
        Array.Sort(mItems)
        Array.Reverse(mItems)
        xCbo.Items.AddRange(mItems)
        xCbo.SelectedIndex = 0
    End Sub

    Private Function CheckTrxCode() As String
        Dim mTrxCode As String

        mTrxCode = InputBox("Enter TrxCode:")
        If mTrxCode = "" Then Return ""
        If ScalarToInt(IIf(cboCity.Text = "HAN", "Ras12HAN..", "") & "AopQueue", "RecID", "TrxCode='" & mTrxCode & "' and status='OK'") = 0 Then
            MsgBox("TrxCode " & mTrxCode & " unavailable!")
            Return ""
        End If

        Return mTrxCode
    End Function
#End Region

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StartApps()

        CnStr = "server=118.69.81.103;uid=user_ras;pwd=VietHealthy@170172#;database=RAS12"
        Conn.ConnectionString = CnStr
        Conn.Open()

        SelectPage(tcFunc, tpMain)

        'If tcFunc.TabPages(0).Name = "tpMain" Then
        LoadCboFromFile(cboSourceType)
        LoadCboFromFile(cboCity)
        'End If
    End Sub

    Private Function StartApps() As Boolean
        Dim mStr, mArrStr(), mApp, mAppStart(), mAppDetail() As String
        Dim i, j As Integer

        If Not File.Exists(Application.StartupPath & "\AppList.txt") Then Return False

        mStr = My.Computer.FileSystem.ReadAllText(Application.StartupPath & "\AppList.txt").Trim
        mArrStr = Split(mStr, vbLf)
        For i = 0 To mArrStr.Length - 1
            If mArrStr(i).ToLower.Contains("https://") Then
                mApp = "firefox"
            Else
                mAppDetail = Split(mArrStr(i), "\")
                mApp = mAppDetail(mAppDetail.Length - 1)
            End If
            mAppStart = Split(mArrStr(i), ";")

            If Process.GetProcessesByName(mApp).Count = 0 Then
                For j = 0 To mAppStart.Length - 1
                    Process.Start(mAppStart(j))
                Next
            End If
        Next

        Return True
    End Function

    Private Sub btnPull_Click(sender As Object, e As EventArgs) Handles btnPull.Click
        Dim mRoot, mFromDir, mToDir, mBKDir, mSource As String

        If MsgBox("Pull source will replace old source, continue?", vbYesNo) = vbNo Then Exit Sub
        If Not (GetLocation("Source:", mSource) And GetLocation("Root:", mRoot)) Then Exit Sub

        mFromDir = mRoot & "prg\" & cboSourceType.Text
        If Not Directory.Exists(mFromDir) Then
            MsgBox(mFromDir & " not exists!")
            Exit Sub
        End If

        mToDir = mSource & "Source\" & cboSourceType.Text
        mBKDir = mSource & "Backup\" & cboSourceType.Text & "\" & Format(Now, "yyyyMMddHHmmss")
        PullFiles(mFromDir, mToDir, mBKDir)

        LoadCboFromDir(cboBackup)
    End Sub

    Private Function GetLocation(xKey As String, ByRef xResult As String) As Boolean
        Dim mLocation As String

        If Not File.Exists(Application.StartupPath & "\Locations.txt") Then
            MsgBox("Locations file not exists!")
            Return False
        End If

        mLocation = My.Computer.FileSystem.ReadAllText(Application.StartupPath & "\Locations.txt").Trim
        If Not mLocation.Contains(xKey) Then
            MsgBox("Locations file data not correct!")
            Return False
        End If

        xResult = Split(mLocation, xKey)(1)
        xResult = Split(xResult, vbLf)(0)

        Return True
    End Function

    Private Sub PullFiles(xFromDir As String, xToDir As String, Optional xBKDir As String = "")
        Dim mFromFile, mToFile As String
        Dim i As Integer

        pb01.Value = pb01.Minimum
        pb01.Maximum = Directory.GetFiles(xFromDir, "*.*", SearchOption.AllDirectories).Length
        pb01.Step = 1
        For i = 0 To Directory.GetFiles(xFromDir, "*.*", SearchOption.AllDirectories).Length - 1
            pb01.PerformStep()
            mFromFile = Directory.GetFiles(xFromDir, "*.*", SearchOption.AllDirectories)(i)
            mToFile = mFromFile.Replace(xFromDir, xToDir)
            If Not File.Exists(mToFile) Then
                FileCopy(mFromFile, mToFile)
            Else
                If hashFile(mFromFile) <> hashFile(mToFile) And
                   (xBKDir = "" Or (xBKDir <> "" And File.GetLastWriteTime(mFromFile) > File.GetLastWriteTime(mToFile))) Then
                    If xBKDir <> "" Then FileCopy(mToFile, mToFile.Replace(xToDir, xBKDir))

                    FileCopy(mFromFile, mToFile)
                End If
            End If
        Next
        MsgBox("Pull file complete!")
    End Sub

    Private Function hashFile(ByVal filepath As String) As String
        Dim hash() As Byte

        Using reader As New System.IO.FileStream(filepath, IO.FileMode.Open, IO.FileAccess.Read)
            Using md5 As New System.Security.Cryptography.MD5CryptoServiceProvider
                hash = md5.ComputeHash(reader)
                Return System.Text.Encoding.Unicode.GetString(hash)
            End Using
        End Using
    End Function

    Private Sub FileCopy(xFromFile As String, xToFile As String)
        Dim mToDir As String

        mToDir = New FileInfo(xToFile).Directory.FullName
        If Not Directory.Exists(mToDir) Then Directory.CreateDirectory(mToDir)
        File.Copy(xFromFile, xToFile, True)
    End Sub

    Private Sub btnPush_Click(sender As Object, e As EventArgs) Handles btnPush.Click
        Dim mOfd As New OpenFileDialog
        Dim i As Integer
        Dim mSource, mFromFile, mToFile As String

        If Not GetLocation("Source:", mSource) Then Exit Sub
        mOfd.Multiselect = True
        mOfd.InitialDirectory = mSource & "Source\" & cboSourceType.Text
        If mOfd.ShowDialog() <> DialogResult.OK Then Exit Sub

        For i = 0 To mOfd.FileNames.Length - 1
            mFromFile = mOfd.FileNames(i)
            mToFile = txtPushLocation.Text & "\" & mFromFile.Substring(mFromFile.LastIndexOf("\") + 1)
            FileCopy(mFromFile, mToFile)
        Next
        MsgBox("Push complete!")
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBackEditAppList.Click
        SelectPage(tcFunc, tpMain)
    End Sub

    Private Sub btnSaveAppList_Click(sender As Object, e As EventArgs) Handles btnSaveList.Click
        My.Computer.FileSystem.WriteAllText(Application.StartupPath & "\" & tpEditList.Text & ".txt", rtbAppList.Text, False)
        SelectPage(tcFunc, tpMain)
    End Sub

    Private Sub btnFixAOPNullList_Click(sender As Object, e As EventArgs) Handles btnFixAOPNullList.Click
        Dim mTrxCode, mAOPListID, mQuerry, mSQL As String
        Dim mRecID As Integer
        Dim mReturn As New DataTable

        mTrxCode = CheckTrxCode()
        If mTrxCode <> "" Then
            'mSQL = "select vd.AOPListID,aop.RecID,aop.Querry " &
            '   "from " & IIf(cboCity.Text = "HAN", "Ras12HAN..", "") & "AopQueue aop " &
            '     "left join " & IIf(cboCity.Text = "HAN", "Ras12HAN..", "") & "UNC_Payments up on aop.TrxCode=up.RefNo " &
            '     "left join " & IIf(cboCity.Text = "HAN", "Ras12HAN..", "") & "Vendor vd on up.PayeeAccountID=vd.RecID " &
            '   "where aop.Status='OK' and aop.TrxCode='" & mTrxCode & "' and aop.Querry like '%(''''%'"
            'mReturn = GetDataTable(mSQL, Conn)
            'If mReturn.Rows.Count > 0 Then
            '    mAOPListID = mReturn.Rows(0)("AOPListID")
            '    mQuerry = mReturn.Rows(0)("Querry")
            '    mRecID = mReturn.Rows(0)("RecID")

            '    mQuerry = Replace(mQuerry, "('',", "('" & mAOPListID & "',")
            '    mQuerry = Replace(mQuerry, "'", "''")

            '    mSQL = "update " & IIf(cboCity.Text = "HAN", "Ras12HAN..", "") & "AopQueue set Querry='" & mQuerry & "' where recid=" & mRecID & ""
            '    ExecuteNonQuerry(mSQL, Conn)

            '    MsgBox("TrxCode " & mTrxCode & " has been Fixed!")
            'End If
            mSQL = "select vd.AOPListID,aop.RecID,aop.Querry " &
                   "from " & IIf(cboCity.Text = "HAN", "Ras12HAN..", "") & "AopQueue aop " &
                     "left join " & IIf(cboCity.Text = "HAN", "Ras12HAN..", "") & "UNC_Payments up on aop.TrxCode=up.RefNo " &
                     "left join " & IIf(cboCity.Text = "HAN", "Ras12HAN..", "") & "Vendor vd on up.PayeeAccountID=vd.RecID " &
                   "where aop.Status='OK' and aop.TrxCode='" & mTrxCode & "' and aop.Querry like '%(VendorRefListID%' and aop.Querry like '%(''''%'"
            mReturn = GetDataTable(mSQL, Conn)
            If mReturn.Rows.Count > 0 Then
                mAOPListID = mReturn.Rows(0)("AOPListID")
                mQuerry = mReturn.Rows(0)("Querry")
                mRecID = mReturn.Rows(0)("RecID")

                mQuerry = Replace(mQuerry, "('',", "('" & mAOPListID & "',")
                mQuerry = Replace(mQuerry, "'", "''")

                mSQL = "update " & IIf(cboCity.Text = "HAN", "Ras12HAN..", "") & "AopQueue set Querry='" & mQuerry & "' where recid=" & mRecID & ""
                ExecuteNonQuerry(mSQL, Conn)
            Else
                mSQL = "select misc.VAL AOPListID,aop.RecID,aop.Querry " &
                       "from " & IIf(cboCity.Text = "HAN", "Ras12HAN..", "") & "AopQueue aop " &
                            "left join " & IIf(cboCity.Text = "HAN", "Ras12HAN..", "") & "UNC_Payments up on aop.TrxCode=up.RefNo " &
                            "left join " & IIf(cboCity.Text = "HAN", "Ras12HAN..", "") & "MISC on misc.CAT='AopBankAccountId2' and misc.Status='OK' " &
                                "and misc.intVal=up.PayerAccountId " &
                       "where aop.Status='OK' and aop.TrxCode='" & mTrxCode & "' and aop.Querry like '%JournalDebitLineAccountRefListID%' " &
                            "and aop.Querry Like '%''''%'"
                mReturn = GetDataTable(mSQL, Conn)
                If mReturn.Rows.Count > 0 Then
                    mAOPListID = mReturn.Rows(0)("AOPListID")
                    mQuerry = mReturn.Rows(0)("Querry")
                    mRecID = mReturn.Rows(0)("RecID")

                    mQuerry = Replace(mQuerry, ",'',", ",'" & mTrxCode & "',", 1, 1)
                    mQuerry = Replace(mQuerry, ",'',", ",'" & mAOPListID & "',", 1, 1)
                    mQuerry = Replace(mQuerry, "'", "''")

                    mSQL = "update " & IIf(cboCity.Text = "HAN", "Ras12HAN..", "") & "AopQueue set Querry='" & mQuerry & "' where recid=" & mRecID & ""
                    ExecuteNonQuerry(mSQL, Conn)
                End If
            End If

            MsgBox("TrxCode " & mTrxCode & " has been Fixed!")
        End If
    End Sub

    Private Sub btnStartApps_Click(sender As Object, e As EventArgs) Handles btnStartApps.Click
        If Not StartApps() Then
            MsgBox("AppList file not exists!")
        Else
            MsgBox("Start apps complete!")
        End If
    End Sub

    Private Sub llbEditAppList_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llbEditSourceType.LinkClicked, llbEditLocations.LinkClicked, llbEditCity.LinkClicked, llbEditAppList.LinkClicked, llbEditGO_TktListingRange.LinkClicked
        'FEditList = New frmEditList
        'FEditList.Text = Split(sender.name, "llbEdit")(1)
        'If Not File.Exists(Application.StartupPath & "\" & FEditList.Text & ".txt") Then
        '    MsgBox(FEditList.Text & " file not exists!")
        '    Exit Sub
        'End If

        'FEditList.rtbAppList.Text = My.Computer.FileSystem.ReadAllText(Application.StartupPath & "\" & tpEditList.Text & ".txt")
        'FEditList.ShowDialog()
        SelectPage(tcFunc, tpEditList)
    End Sub

    Private Sub btnAopSgnLog_Click(sender As Object, e As EventArgs)
        Dim mAOP, mFile As String

        If Not GetLocation("AOP:", mAOP) Then Exit Sub
        mFile = mAOP & Format(Now, "yyMMdd") & "ImportAOP.txt"
        If IO.File.Exists(mFile) = True Then Process.Start(mFile)
    End Sub

    Private Sub btnPassAop_Click(sender As Object, e As EventArgs) Handles btnBypassAop.Click
        Dim mTrxCode As String

        mTrxCode = CheckTrxCode()
        If mTrxCode <> "" Then
            ExecuteNonQuerry("update " & IIf(cboCity.Text = "HAN", "Ras12HAN..", "") & "AopQueue set status='XX' where TrxCode='" & mTrxCode & "' and status='OK'", Conn)
            MsgBox("TrxCode " & mTrxCode & " has been ByPass!")
        End If
    End Sub

    Private Sub LoadCboFromFile(xCbo As ComboBox)
        Dim mItems As String

        xCbo.Items.Clear()
        If Not File.Exists(Application.StartupPath & "\" & Split(xCbo.Name, "cbo")(1) & ".txt") Then Exit Sub

        mItems = My.Computer.FileSystem.ReadAllText(Application.StartupPath & "\" & Split(xCbo.Name, "cbo")(1) & ".txt")
        xCbo.Items.AddRange(Split(mItems, vbLf))
        xCbo.SelectedIndex = 0
    End Sub

    Private Sub btnInsertGO_TktListing_Click(sender As Object, e As EventArgs) Handles btnInsertGO_TktListing.Click
        Dim i, j, mSeq As Integer
        Dim mStr, mArrStr(), mSqlQuerry As String
        Dim mCustomer, mGO_TktListing As New DataTable
        Dim mLstStr As New List(Of String)

        If MsgBox("Realy want insert TktListing?", vbYesNo) = vbNo Then Exit Sub

        mStr = My.Computer.FileSystem.ReadAllText(Application.StartupPath & "\InsertGO_TktListingRange.txt")
        mArrStr = Split(mStr, vbLf)
        If mArrStr.Length < 2 Then
            MsgBox("Dont know range!")
            Exit Sub
        End If

        mStr = "select RecID from CustomerList where Status='OK' and City='SGN' order by RecID"
        mCustomer = GetDataTable(mStr, Conn)
        mStr = "select DataCode,Description,NameInReport,DataGroup,SqlQuerry,FstUser from CWT..GO_TktListing where recID between " & mArrStr(0) & " and " & mArrStr(1) & " " &
               "order by RecID"
        mGO_TktListing = GetDataTable(mStr, Conn)
        For i = 0 To mCustomer.Rows.Count - 1
            mSeq = ScalarToInt("CWT..GO_TktListing", "ISNULL(MAX(seq),0) MSeq", "Status='OK' and DomInt='MISC' and CustID=" & mCustomer.Rows(i)("RecID"))

            For j = 0 To mGO_TktListing.Rows.Count - 1
                mSqlQuerry = mGO_TktListing.Rows(j)("SqlQuerry")
                mSqlQuerry = Replace(mSqlQuerry, "'", "''")
                mSeq = mSeq + 1
                mLstStr.Add("insert into CWT..GO_TktListing(CustID,DomInt,Seq,DataCode,Description," &
                                                      "NameInReport,DataGroup,SqlQuerry,FstUser) " &
                            "values(" & mCustomer.Rows(i)("RecID") & ",'ALL'," & mSeq & ",'" & mGO_TktListing.Rows(j)("DataCode") & "'," &
                                        "N'" & mGO_TktListing.Rows(j)("Description") & "'," &
                                    "N'" & mGO_TktListing.Rows(j)("NameInReport") & "','" & mGO_TktListing.Rows(j)("DataGroup") & "','" & mSqlQuerry & "','NMK')")

                mLstStr.Add("insert into CWT..GO_TktListing(CustID,DomInt,Seq,DataCode,Description," &
                                                      "NameInReport,DataGroup,SqlQuerry,FstUser) " &
                            "values(" & mCustomer.Rows(i)("RecID") & ",'DOM'," & mSeq & ",'" & mGO_TktListing.Rows(j)("DataCode") & "'," &
                                        "N'" & mGO_TktListing.Rows(j)("Description") & "'," &
                                    "N'" & mGO_TktListing.Rows(j)("NameInReport") & "','" & mGO_TktListing.Rows(j)("DataGroup") & "','" & mSqlQuerry & "','NMK')")

                mLstStr.Add("insert into CWT..GO_TktListing(CustID,DomInt,Seq,DataCode,Description," &
                                                      "NameInReport,DataGroup,SqlQuerry,FstUser) " &
                            "values(" & mCustomer.Rows(i)("RecID") & ",'INT'," & mSeq & ",'" & mGO_TktListing.Rows(j)("DataCode") & "'," &
                                        "N'" & mGO_TktListing.Rows(j)("Description") & "'," &
                                    "N'" & mGO_TktListing.Rows(j)("NameInReport") & "','" & mGO_TktListing.Rows(j)("DataGroup") & "','" & mSqlQuerry & "','NMK')")
            Next
        Next
        If mLstStr.Count > 0 Then UpdateListOfQuerries(mLstStr, Conn)

        MsgBox("Insert complete")
    End Sub

    Private Sub cboSourceType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSourceType.SelectedIndexChanged
        Dim mShare As String

        If Not GetLocation("Share:", mShare) Then Exit Sub

        txtPushLocation.Text = mShare & cboSourceType.Text & "\" & Format(Now, "yyyyMMdd")
        LoadCboFromDir(cboBackup)
    End Sub

    Private Sub llbCalcRemainingPoint_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llbCalcRemainingPoint.LinkClicked
        Dim mSQL As String
        Dim mReturn, mReturn2 As New DataTable
        Dim i, j, mOrderRemaining, mPoint_DRemaining As Integer

        mSQL = "select odd.UserID,odg.LstUpdate,odd.RemainingPoint from OrderDetail odd left join OrderGift odg on odd.OrderID=odg.RecID " &
               "where odd.RemainingPoint>0 And odg.Status='OK' order by odd.UserID,odg.LstUpdate"
        mReturn = GetDataTable(mSQL, Conn)
        For i = 0 To mReturn.Rows.Count - 1
            mOrderRemaining = mReturn.Rows(i)("RemainingPoint")
            mSQL = String.Format("select BookDate,RemainingPoint,RecID from Point_D where UserID={0} and Status='OK' order by BookDate", mReturn.Rows(i)("UserID"))
            mReturn2 = GetDataTable(mSQL, Conn)
            For j = 0 To mReturn2.Rows.Count - 1
                mPoint_DRemaining = mReturn2.Rows(j)("RemainingPoint")
                If mOrderRemaining >= mPoint_DRemaining Then
                    mOrderRemaining = mOrderRemaining - mPoint_DRemaining
                    mPoint_DRemaining = 0
                Else
                    mPoint_DRemaining = mOrderRemaining - mPoint_DRemaining
                    mOrderRemaining = 0
                End If

                mSQL = String.Format("update Point_D set RemainingPoint={0} where RecID={1}", mPoint_DRemaining, mReturn2.Rows(j)("RecID"))

            Next
        Next
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim i As Integer
        tcFunc.TabPages.Clear()

        tcFunc.TabPages.Add(tpEditList)
    End Sub

    Private Sub btnRestore_Click(sender As Object, e As EventArgs) Handles btnRestore.Click
        Dim mSource As String

        If MsgBox("Restore source will replace old source, continue?", vbYesNo) = vbNo Then Exit Sub

        Dim mFromDir, mToDir As String

        If Not GetLocation("Source:", mSource) Then Exit Sub
        mFromDir = mSource & "Backup\" & cboSourceType.Text & "\" & cboBackup.Text
        If Not Directory.Exists(mFromDir) Then
            MsgBox(mFromDir & " not exists!")
            Exit Sub
        End If

        mToDir = mSource & "Source\" & cboSourceType.Text
        PullFiles(mFromDir, mToDir)
    End Sub

    Private Sub cboSourceType_Validated(sender As Object, e As EventArgs) Handles cboSourceType.Validated, cboBackup.Validated
        'If Not cboValidated(sender, e) Then Exit Sub
    End Sub

    Private Sub btnSort_Click(sender As Object, e As EventArgs) Handles btnSort.Click
        rtbAppList.Text = SortString(rtbAppList.Text)
    End Sub
End Class
