Imports System.IO
Public Class frmMain
    Private FList As String
    Private FParentTab As TabPage
    Private Enum FAction
        Pull
        Restore
        Push
    End Enum

#Region "CustomMethod"
    Private Function hashFile(ByVal filepath As String) As String
        Using reader As New System.IO.FileStream(filepath, IO.FileMode.Open, IO.FileAccess.Read)
            Using md5 As New System.Security.Cryptography.MD5CryptoServiceProvider
                Dim hash() As Byte = md5.ComputeHash(reader)
                Return System.Text.Encoding.Unicode.GetString(hash)
            End Using
        End Using
    End Function

    Private Sub LoadlstBackup(xProject As String)
        Dim mBackup As String,
            mLst As New List(Of String),
            i As Integer

        lstBackup.Items.Clear()
        mBackup = "D:\7643\Backup\" & xProject
        If Directory.Exists(mBackup) Then
            For Each dirPath As String In Directory.GetDirectories(mBackup, "*", SearchOption.TopDirectoryOnly)
                mLst.Add(Split(dirPath, mBackup & "\")(1))
            Next
        End If
        mLst.Sort()

        For i = mLst.Count - 1 To 0 Step -1
            lstBackup.Items.Add(mLst.Item(i))
        Next
    End Sub

    Private Sub FileCopy(xSource As String, xTarget As String)
        Dim mPath As String

        mPath = New FileInfo(xTarget).Directory.FullName
        If Not Directory.Exists(mPath) Then Directory.CreateDirectory(mPath)
        File.Copy(xSource, xTarget, True)
    End Sub

    Private Sub MoveFile(xAction As FAction, xSource As String, xTarget As String, Optional xOther As String = "")
        Dim mDest, mTarget, mArrStr() As String

        pb01.Value = pb01.Minimum
        pb01.Maximum = Directory.GetFiles(xSource, "*.*", SearchOption.AllDirectories).Length
        pb01.Step = 1
        Me.TopMost = True
        mDest = IIf(xAction <> FAction.Push, xTarget, xOther)
        For Each newPath As String In Directory.GetFiles(xSource, "*.*", SearchOption.AllDirectories)
            pb01.PerformStep()

            If xAction = FAction.Push AndAlso Path.GetExtension(newPath) <> ".vb" And Path.GetExtension(newPath) <> ".resx" Then Continue For

            mArrStr = Split(newPath, "\")
            mTarget = IIf(xAction = FAction.Push, xTarget & "\" & mArrStr(mArrStr.Length - 1), newPath.Replace(xSource, xTarget))
            If File.Exists(newPath.Replace(xSource, mDest)) Then
                If hashFile(newPath) <> hashFile(newPath.Replace(xSource, mDest)) And File.GetLastWriteTime(newPath) > File.GetLastWriteTime(newPath.Replace(xSource, mDest)) Then
                    If xAction = FAction.Pull Then FileCopy(newPath.Replace(xSource, xTarget), newPath.Replace(xSource, xOther))

                    FileCopy(newPath, mTarget)
                End If
            Else
                FileCopy(newPath, mTarget)
            End If
        Next
        MsgBox(xAction.ToString & " complete!")
        Me.TopMost = False
    End Sub

    Private Sub LoadTp(xTp As TabPage)
        tcFunc.TabPages.Clear()
        tcFunc.TabPages.Add(xTp)
    End Sub

    Private Sub LoadEditList(xList As String, xParentTab As TabPage)
        FList = xList
        FParentTab = xParentTab

        rtbAppList.Text = My.Computer.FileSystem.ReadAllText(Application.StartupPath & "\" & xList & ".txt")
        LoadTp(tpEditList)
    End Sub

    Private Sub StartApps()
        Dim mAppList, mArrApp(), mAppCheck, mAppStart(), mAppDetail() As String
        Dim i, j As Integer

        mAppList = My.Computer.FileSystem.ReadAllText(Application.StartupPath & "\AppList.txt")
        mArrApp = Split(mAppList, vbLf)
        For i = 0 To mArrApp.Length - 1
            If mArrApp(i) = "" Then Continue For

            If mArrApp(i).ToLower.Contains("https") Then
                mAppCheck = "firefox"
            Else
                mAppDetail = Split(mArrApp(i), "\")
                mAppCheck = mAppDetail(mAppDetail.Length - 1)
            End If
            mAppStart = Split(mArrApp(i), ";")

            If Process.GetProcessesByName(mAppCheck).Count = 0 Then
                For j = 0 To mAppStart.Length - 1
                    Process.Start(mAppStart(j))
                Next
            End If
        Next
    End Sub

    Private Sub LoadCombox(xCbo As ComboBox, xSource As String)
        Dim mItems, mItem() As String

        xCbo.Items.Clear()
        mItems = My.Computer.FileSystem.ReadAllText(Application.StartupPath & "\" & xSource & ".txt")
        mItem = Split(mItems, vbLf)
        For i = 0 To mItem.Length - 1
            xCbo.Items.Add(mItem(i))
        Next
        xCbo.SelectedIndex = 0
    End Sub

    Private Sub LoadComboLocation(xCbo As ComboBox, xSource As String)
        Dim mBackup As String

        xCbo.Items.Clear()
        mBackup = "D:\7643\Backup\" & xSource
        If Directory.Exists(mBackup) Then
            For Each dirPath As String In Directory.GetDirectories(mBackup, "*", SearchOption.TopDirectoryOnly)
                xCbo.Items.Add(Split(dirPath, mBackup & "\")(1))
            Next
        End If

        If xCbo.Items.Count > 0 Then
            xCbo.SelectedIndex = 0
        Else
            xCbo.Text = ""
        End If
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

        'Connect
        If Conn.State = ConnectionState.Open Then
            Conn.Close()
        End If

        CnStr = "server=118.69.81.103;uid=user_ras;pwd=VietHealthy@170172#;database=RAS12"
        Conn.ConnectionString = CnStr
        Conn.Open()

        LoadTp(tpMain)
    End Sub

    Private Sub btnPull_Click(sender As Object, e As EventArgs) Handles btnPull.Click
        Dim mSource, mTarget, mBackup As String

        If MsgBox("Pull source will replace old source, continue?", vbYesNo) = vbNo Then Exit Sub

        mSource = "\\5-247\"
        mTarget = "D:\7643\Source\"
        mBackup = "D:\7643\Backup\"
        mSource &= cboSourceType.Text
        mTarget &= cboSourceType.Text
        mBackup &= cboSourceType.Text & "\" & Format(Now, "yyyyMMddHHmmss")
        MoveFile(FAction.Pull, mSource, mTarget, mBackup)
        LoadlstBackup(cboSourceType.Text)
    End Sub

    Private Sub btnRestore_Click(sender As Object, e As EventArgs)
        Dim mSource, mTarget As String

        If lstBackup.SelectedIndex = -1 Then
            MsgBox("Please select data to backup!")
            Exit Sub
        End If

        If MsgBox("Restore source will replace source, continue?", vbYesNo) = vbNo Then Exit Sub

        mSource = "D:\7643\Backup\"
        mTarget = "D:\7643\Source\"
        mSource &= cboSourceType.Text & "\" & lstBackup.SelectedItem
        mTarget &= cboSourceType.Text
        MoveFile(FAction.Restore, mSource, mTarget)
    End Sub

    Private Sub btnPush_Click(sender As Object, e As EventArgs) Handles btnPush.Click
        Dim mOfd As New OpenFileDialog
        Dim i As Integer
        Dim mSource, mTarget, mArrStr() As String

        mOfd.Multiselect = True
        If mOfd.ShowDialog() <> DialogResult.OK Then Exit Sub

        For i = 0 To mOfd.FileNames.Length - 1
            mSource = mOfd.FileNames(i)

            mTarget = "T:\LTH\"
            mTarget &= cboSourceType.Text & "\" & Format(Now, "yyyyMMdd")
            mArrStr = mSource.Split("\")
            mTarget &= "\" & mArrStr(mArrStr.Length - 1)
            FileCopy(mSource, mTarget)
        Next
        MsgBox("Push complete!")
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim mFile, mStr As String,
            i, j As Integer

        mFile = "D:\7643\Source\Lib\Stock.txt"
        For i = 0 To dgvStock.Rows.Count - 2
            mStr &= IIf(i = 0, "", vbLf)

            For j = 0 To dgvStock.Columns.GetColumnCount(DataGridViewElementStates.None) - 1
                mStr &= IIf(j = 0, "", vbTab) & dgvStock.Rows(i).Cells(j).Value.ToString
            Next
        Next
        My.Computer.FileSystem.WriteAllText(mFile, mStr, False)
    End Sub

    Private Sub dgvStock_DefaultValuesNeeded(sender As Object, e As DataGridViewRowEventArgs) Handles dgvStock.DefaultValuesNeeded
        Dim i As Integer

        e.Row.Cells(0).Value = ""
        For i = 1 To 4
            e.Row.Cells(i).Value = 0
        Next
        e.Row.Cells(5).Value = False
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBackEditAppList.Click
        LoadTp(FParentTab)
    End Sub

    Private Sub btnSaveAppList_Click(sender As Object, e As EventArgs) Handles btnSaveList.Click
        My.Computer.FileSystem.WriteAllText(Application.StartupPath & "\" & FList & ".txt", rtbAppList.Text, False)
        LoadTp(FParentTab)
    End Sub

    Private Sub btnEditSource_Click(sender As Object, e As EventArgs)
        LoadTp(tpEditSource)
    End Sub

    Private Sub btnBackEditSource_Click(sender As Object, e As EventArgs) Handles btnBackEditSource.Click
        LoadTp(tpMain)
    End Sub

    Private Sub llbEditSourceType_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llbEditSourceType.LinkClicked
        LoadEditList("SourceType", CType(sender.parent.parent, TabPage))
    End Sub

    Private Sub cboSourceType_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs)
        Dim mSourceTypes, mSourceType() As String
        Dim i As Integer
        Dim mFound As Boolean

        mFound = False
        mSourceTypes = My.Computer.FileSystem.ReadAllText(Application.StartupPath & "\SourceType.txt").ToLower
        mSourceType = Split(mSourceTypes, vbLf)
        For i = 0 To mSourceType.Length - 1
            If mSourceType(i) = sender.text.ToLower Then
                sender.selectedindex = i
                mFound = True
                Exit For
            End If
        Next

        If Not mFound Then
            MsgBox("SourceType not exist!")
            e.Cancel = True
        End If
    End Sub

    Private Sub btnFixAOPNullList_Click(sender As Object, e As EventArgs) Handles btnFixAOPNullList.Click
        Dim mTrxCode, mAOPListID, mQuerry, mSQL As String
        Dim mRecID As Integer
        Dim mReturn As New DataTable

        mTrxCode = CheckTrxCode()
        If mTrxCode <> "" Then
            mSQL = "select vd.AOPListID,aop.RecID,aop.Querry " &
               "from " & IIf(cboCity.Text = "HAN", "Ras12HAN..", "") & "AopQueue aop " &
                 "left join " & IIf(cboCity.Text = "HAN", "Ras12HAN..", "") & "UNC_Payments up on aop.TrxCode=up.RefNo " &
                 "left join " & IIf(cboCity.Text = "HAN", "Ras12HAN..", "") & "Vendor vd on up.PayeeAccountID=vd.RecID " &
               "where aop.Status='OK' and aop.TrxCode='" & mTrxCode & "' and aop.Querry like '%(''''%'"
            mReturn = GetDataTable(mSQL, Conn)
            If mReturn.Rows.Count > 0 Then
                mAOPListID = mReturn.Rows(0)("AOPListID")
                mQuerry = mReturn.Rows(0)("Querry")
                mRecID = mReturn.Rows(0)("RecID")

                mQuerry = Replace(mQuerry, "('',", "('" & mAOPListID & "',")
                mQuerry = Replace(mQuerry, "'", "''")

                mSQL = "update " & IIf(cboCity.Text = "HAN", "Ras12HAN..", "") & "AopQueue set Querry='" & mQuerry & "' where recid=" & mRecID & ""
                ExecuteNonQuerry(mSQL, Conn)

                MsgBox("TrxCode " & mTrxCode & " has been Fixed!")
            End If
        End If
    End Sub

    Private Sub cboSourceType_SelectedIndexChanged(sender As Object, e As EventArgs)
        LoadlstBackup(cboSourceType.Text)
    End Sub

    Private Sub btnStartApps_Click(sender As Object, e As EventArgs) Handles btnStartApps.Click
        StartApps()
    End Sub

    Private Sub llbEditAppList_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llbEditAppList.LinkClicked
        LoadEditList("AppList", CType(sender.parent.parent, TabPage))
    End Sub

    Private Sub btnAopSgnLog_Click(sender As Object, e As EventArgs) Handles btnAopSgnLog.Click
        Dim mFile As String

        mFile = "\\AOP_Travel\Debug\" & Format(Now, "yyMMdd") & "ImportAOP.txt"
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

    Private Sub llbEditCity_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llbEditCity.LinkClicked
        LoadEditList("City", CType(sender.parent.parent, TabPage))
    End Sub

    Private Sub tcFunc_ControlAdded(sender As Object, e As ControlEventArgs) Handles tcFunc.ControlAdded
        If tcFunc.TabPages(0).Name = "tpMain" Then
            LoadCombox(cboCity, "City")
            LoadCombox(cboSourceType, "SourceType")
            LoadCombo(cboTable, "select name value from SYSOBJECTS where xtype in ('U','V') order by name", Conn)
            LoadCombo(cboColumn, "select COLUMN_NAME value from INFORMATION_SCHEMA.COLUMNS where TABLE_NAME='" & cboTable.SelectedValue & "' " &
                                 "order by COLUMN_NAME", Conn)
        End If
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

    Private Sub llbEditGO_TktListingRange_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llbEditGO_TktListingRange.LinkClicked
        LoadEditList("InsertGO_TktListingRange", CType(sender.parent.parent, TabPage))
    End Sub

    Private Sub cboCity_Validated(sender As Object, e As EventArgs) Handles cboCity.Validated, cboSourceType.Validated
        sender.SelectedIndex = IIf(sender.FindString(sender.Text) = -1, 0, sender.FindString(sender.Text))
        sender.Text = sender.SelectedItem
    End Sub

    Private Sub cboSourceType_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cboSourceType.SelectedIndexChanged
        Dim mArrStr() As String

        mArrStr = cboSourceType.SelectedItem.split("\")
        txtPushLocation.Text = "T:\LTH\" & mArrStr(mArrStr.Length - 1) & "\" & Format(Now, "yyyyMMdd")
        LoadComboLocation(cboBackupList, mArrStr(mArrStr.Length - 1))
    End Sub

    Private Sub cboTable_Validated(sender As Object, e As EventArgs) Handles cboTable.Validated, cboColumn.Validated
        sender.SelectedIndex = IIf(sender.FindString(sender.Text) = -1, 0, sender.FindString(sender.Text))
        sender.Text = sender.selectedvalue
    End Sub

    Private Sub cboTable_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTable.SelectedIndexChanged
        LoadCombo(cboColumn, "select COLUMN_NAME value from INFORMATION_SCHEMA.COLUMNS where TABLE_NAME='" & cboTable.Text & "' " &
                             "order by COLUMN_NAME", Conn)
    End Sub
End Class
