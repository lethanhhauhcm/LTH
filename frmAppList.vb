Public Class frmAppList
    Private FStartApp As String
    Private Sub txtAppPath_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtAppPath.Validating
        If txtAppPath.Text = "" Then
            txtAppName.Text = ""
            Exit Sub
        End If

        If txtAppPath.Text.ToLower.Contains("https") Then Exit Sub

        If Not IO.File.Exists(txtAppPath.Text) Then
            MsgBox("Path not exists!")
            e.Cancel = True
            Exit Sub
        End If

        txtAppName.Text = IO.Path.GetFileNameWithoutExtension(txtAppPath.Text)
    End Sub

    Private Sub llbBrowse_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llbBrowse.LinkClicked
        Dim mOfd As New OpenFileDialog

        If txtAppPath.Text <> "" Then mOfd.InitialDirectory = IO.Path.GetDirectoryName(txtAppPath.Text)
        If mOfd.ShowDialog <> DialogResult.OK Then Exit Sub

        txtAppPath.Text = mOfd.FileName
        txtAppPath_Validating(sender, New System.ComponentModel.CancelEventArgs)
    End Sub

    Private Function CheckText(xTxt As TextBox) As Boolean
        If xTxt.Text = "" Then
            MsgBox(String.Format("Please input {0} first!", {Split(xTxt.Name, "txt").Last}))
            Return False
        End If

        Return True
    End Function

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim mSQL As String

        If Not CheckText(txtAppPath) OrElse Not CheckText(txtAppName) Then Exit Sub
        If tpEdit.Text.ToLower = "add" Then
            If ScalarToString("LTH_AppList", "AppPath", String.Format("Status='OK' and AppPath='{0}'", {txtAppPath.Text})) <> "" Then
                MsgBox(String.Format("{0} is exists!", {txtAppPath.Text}))
                Exit Sub
            End If
        Else
            If txtAppPath.Text = dgvStartApp.CurrentRow.Cells("AppPath").Value And txtAppName.Text = dgvStartApp.CurrentRow.Cells("AppName").Value Then
                MsgBox("Have not modi data!")
                Exit Sub
            End If
            If MsgBox("Are you sure want to save?", vbYesNo) = vbNo Then Exit Sub
        End If

        BeginTrans()
        If tpEdit.Text.ToLower = "add" Then
            mSQL = String.Format("insert into LTH_AppList(AppName,AppPath) values('{0}','{1}')", {txtAppName.Text, txtAppPath.Text})
        Else
            mSQL = String.Format("update LTH_AppList set AppName='{0}',LstUpdate='{1}' where Status='OK' and AppPath='{2}'",
                                 {txtAppName.Text, Format(Now, "yyyyMMdd hh:mm:ss"), txtAppPath.Text})
        End If
        If Not ExecuteSQL(mSQL) Then Exit Sub
        CommitTrans()

        SelectPage(tpAppList)
        LoadDataGridView(dgvStartApp, FStartApp, Conn)
    End Sub

    Private Sub SelectPage(xtp As TabPage)
        tcAppList.TabPages.Clear()
        tcAppList.TabPages.Add(xtp)
    End Sub

    Private Sub frmEditStartApp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SelectPage(tpAppList)
        FStartApp = "select RecID,AppName,AppPath,FstUpdate,LstUpdate from LTH_AppList where Status='OK' order by AppName,AppPath"
        LoadDataGridView(dgvStartApp, FStartApp, Conn)
        dgvStartApp.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        tpEdit.Text = "Add"
        SelectPage(tpEdit)
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        SelectPage(tpAppList)
    End Sub

    Private Sub dgvStartApp_DataSourceChanged(sender As Object, e As EventArgs) Handles dgvStartApp.DataSourceChanged
        btnEdit.Enabled = dgvStartApp.Rows.Count > 0
        btnCopy.Enabled = dgvStartApp.Rows.Count > 0
        btnDelete.Enabled = dgvStartApp.Rows.Count > 0
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        tpEdit.Text = "Edit"
        SelectPage(tpEdit)
        DefaultValue(tpEdit, dgvStartApp)
        txtAppPath.ReadOnly = True
        llbBrowse.Enabled = False
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim mSQL As String

        If MsgBox("Are you sure delete this row data?", vbYesNo) = vbNo Then Exit Sub

        BeginTrans()
        mSQL = String.Format("update LTH_AppList set Status='XX' where Status='OK' and AppPath='{0}'", {dgvStartApp.CurrentRow.Cells("AppPath").Value})
        If Not ExecuteSQL(mSQL) Then Exit Sub
        CommitTrans()

        LoadDataGridView(dgvStartApp, FStartApp, Conn)
    End Sub

    Private Sub btnCopy_Click(sender As Object, e As EventArgs) Handles btnCopy.Click
        tpEdit.Text = "Add"
        SelectPage(tpEdit)
        DefaultValue(tpEdit, dgvStartApp)
    End Sub

    Private Sub tcEditStartApp_ControlAdded(sender As Object, e As ControlEventArgs) Handles tcAppList.ControlAdded
        If tcAppList.TabPages(0).Name.ToLower = "tpedit" Then
            DefaultControl(tpEdit)
            txtAppPath.ReadOnly = False
            llbBrowse.Enabled = True
        End If
    End Sub
End Class