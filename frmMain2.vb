Public Class frmMain2

    Private Sub frmMain2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CnStr = "server=118.69.81.103;uid=user_ras;pwd=VietHealthy@170172#;database=RAS12"
        Conn.ConnectionString = CnStr
        Conn.Open()

        mnStartApp_Click(sender, e)
        mnRequest_Click(sender, e)
    End Sub

    Private Sub mnStartApp_Click(sender As Object, e As EventArgs) Handles mnStartApp.Click
        Dim mReturn As New DataTable
        Dim i, j As Integer
        Dim mArrStr() As String

        mReturn = GetDataTable("select AppName,STRING_AGG(AppPath,';') AppPaths from LTH_AppList where status='OK' group by AppName order by AppName", Conn)
        For i = 0 To mReturn.Rows.Count - 1
            If Process.GetProcessesByName(mReturn.Rows(i)("AppName")).Count = 0 Then
                mArrStr = CStr(mReturn.Rows(i)("AppPaths")).Split(";")
                For j = 0 To mArrStr.Count - 1
                    Process.Start(mArrStr(j))
                Next
            End If
        Next
    End Sub

    Private Sub mnAppList_Click(sender As Object, e As EventArgs) Handles mnAppList.Click
        Dim mAppList As New frmAppList

        mAppList.MdiParent = Me
        mAppList.Show()
    End Sub

    Private Sub mnRequest_Click(sender As Object, e As EventArgs) Handles mnRequest.Click
        Dim mRequest As New frmRequest


        mRequest.MdiParent = Me
        mRequest.Show()
    End Sub

    Private Sub TestToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TestToolStripMenuItem.Click
        'Application.OpenForms


    End Sub
End Class