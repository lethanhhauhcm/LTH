<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.msLTH = New System.Windows.Forms.MenuStrip()
        Me.mnStartup = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnStartApp = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnAppList = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnRequest = New System.Windows.Forms.ToolStripMenuItem()
        Me.TestToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.msLTH.SuspendLayout()
        Me.SuspendLayout()
        '
        'msLTH
        '
        Me.msLTH.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnStartup, Me.mnRequest, Me.TestToolStripMenuItem})
        Me.msLTH.Location = New System.Drawing.Point(0, 0)
        Me.msLTH.Name = "msLTH"
        Me.msLTH.Size = New System.Drawing.Size(800, 24)
        Me.msLTH.TabIndex = 3
        Me.msLTH.Text = "MenuStrip1"
        '
        'mnStartup
        '
        Me.mnStartup.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnStartApp, Me.mnAppList})
        Me.mnStartup.Name = "mnStartup"
        Me.mnStartup.Size = New System.Drawing.Size(57, 20)
        Me.mnStartup.Text = "Startup"
        '
        'mnStartApp
        '
        Me.mnStartApp.Name = "mnStartApp"
        Me.mnStartApp.Size = New System.Drawing.Size(180, 22)
        Me.mnStartApp.Text = "StartApp"
        '
        'mnAppList
        '
        Me.mnAppList.Name = "mnAppList"
        Me.mnAppList.Size = New System.Drawing.Size(180, 22)
        Me.mnAppList.Text = "AppList"
        '
        'mnRequest
        '
        Me.mnRequest.Name = "mnRequest"
        Me.mnRequest.Size = New System.Drawing.Size(61, 20)
        Me.mnRequest.Text = "Request"
        '
        'TestToolStripMenuItem
        '
        Me.TestToolStripMenuItem.Name = "TestToolStripMenuItem"
        Me.TestToolStripMenuItem.Size = New System.Drawing.Size(38, 20)
        Me.TestToolStripMenuItem.Text = "test"
        '
        'frmMain2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.msLTH)
        Me.IsMdiContainer = True
        Me.Name = "frmMain2"
        Me.Text = "LTH"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.msLTH.ResumeLayout(False)
        Me.msLTH.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents msLTH As MenuStrip
    Friend WithEvents mnStartup As ToolStripMenuItem
    Friend WithEvents mnStartApp As ToolStripMenuItem
    Friend WithEvents mnAppList As ToolStripMenuItem
    Friend WithEvents mnRequest As ToolStripMenuItem
    Friend WithEvents TestToolStripMenuItem As ToolStripMenuItem
End Class
