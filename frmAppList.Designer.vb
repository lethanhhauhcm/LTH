<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAppList
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
        Me.lblAppName = New System.Windows.Forms.Label()
        Me.txtAppName = New System.Windows.Forms.TextBox()
        Me.txtAppPath = New System.Windows.Forms.TextBox()
        Me.lblAppPath = New System.Windows.Forms.Label()
        Me.dgvStartApp = New System.Windows.Forms.DataGridView()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.llbBrowse = New System.Windows.Forms.LinkLabel()
        Me.tcAppList = New System.Windows.Forms.TabControl()
        Me.tpAppList = New System.Windows.Forms.TabPage()
        Me.btnCopy = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.tpEdit = New System.Windows.Forms.TabPage()
        Me.btnBack = New System.Windows.Forms.Button()
        CType(Me.dgvStartApp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tcAppList.SuspendLayout()
        Me.tpAppList.SuspendLayout()
        Me.tpEdit.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblAppName
        '
        Me.lblAppName.AutoSize = True
        Me.lblAppName.Location = New System.Drawing.Point(7, 68)
        Me.lblAppName.Name = "lblAppName"
        Me.lblAppName.Size = New System.Drawing.Size(54, 13)
        Me.lblAppName.TabIndex = 0
        Me.lblAppName.Text = "AppName"
        '
        'txtAppName
        '
        Me.txtAppName.Location = New System.Drawing.Point(67, 65)
        Me.txtAppName.Name = "txtAppName"
        Me.txtAppName.Size = New System.Drawing.Size(300, 20)
        Me.txtAppName.TabIndex = 4
        '
        'txtAppPath
        '
        Me.txtAppPath.Location = New System.Drawing.Point(67, 39)
        Me.txtAppPath.Name = "txtAppPath"
        Me.txtAppPath.Size = New System.Drawing.Size(555, 20)
        Me.txtAppPath.TabIndex = 2
        '
        'lblAppPath
        '
        Me.lblAppPath.AutoSize = True
        Me.lblAppPath.Location = New System.Drawing.Point(13, 42)
        Me.lblAppPath.Name = "lblAppPath"
        Me.lblAppPath.Size = New System.Drawing.Size(48, 13)
        Me.lblAppPath.TabIndex = 2
        Me.lblAppPath.Text = "AppPath"
        '
        'dgvStartApp
        '
        Me.dgvStartApp.AllowUserToAddRows = False
        Me.dgvStartApp.AllowUserToDeleteRows = False
        Me.dgvStartApp.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvStartApp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvStartApp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvStartApp.Location = New System.Drawing.Point(6, 35)
        Me.dgvStartApp.Name = "dgvStartApp"
        Me.dgvStartApp.ReadOnly = True
        Me.dgvStartApp.Size = New System.Drawing.Size(658, 150)
        Me.dgvStartApp.TabIndex = 2
        '
        'btnSave
        '
        Me.btnSave.AutoSize = True
        Me.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnSave.Location = New System.Drawing.Point(7, 91)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(42, 23)
        Me.btnSave.TabIndex = 5
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnDelete.AutoSize = True
        Me.btnDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnDelete.Location = New System.Drawing.Point(94, 191)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(48, 23)
        Me.btnDelete.TabIndex = 5
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'llbBrowse
        '
        Me.llbBrowse.AutoSize = True
        Me.llbBrowse.Location = New System.Drawing.Point(628, 42)
        Me.llbBrowse.Name = "llbBrowse"
        Me.llbBrowse.Size = New System.Drawing.Size(42, 13)
        Me.llbBrowse.TabIndex = 3
        Me.llbBrowse.TabStop = True
        Me.llbBrowse.Text = "Browse"
        '
        'tcAppList
        '
        Me.tcAppList.Controls.Add(Me.tpAppList)
        Me.tcAppList.Controls.Add(Me.tpEdit)
        Me.tcAppList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcAppList.Location = New System.Drawing.Point(0, 0)
        Me.tcAppList.Name = "tcAppList"
        Me.tcAppList.SelectedIndex = 0
        Me.tcAppList.Size = New System.Drawing.Size(684, 247)
        Me.tcAppList.TabIndex = 0
        '
        'tpAppList
        '
        Me.tpAppList.BackColor = System.Drawing.SystemColors.Control
        Me.tpAppList.Controls.Add(Me.btnCopy)
        Me.tpAppList.Controls.Add(Me.btnEdit)
        Me.tpAppList.Controls.Add(Me.btnAdd)
        Me.tpAppList.Controls.Add(Me.dgvStartApp)
        Me.tpAppList.Controls.Add(Me.btnDelete)
        Me.tpAppList.Location = New System.Drawing.Point(4, 22)
        Me.tpAppList.Name = "tpAppList"
        Me.tpAppList.Padding = New System.Windows.Forms.Padding(3)
        Me.tpAppList.Size = New System.Drawing.Size(676, 221)
        Me.tpAppList.TabIndex = 0
        Me.tpAppList.Text = "AppList"
        '
        'btnCopy
        '
        Me.btnCopy.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCopy.AutoSize = True
        Me.btnCopy.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnCopy.Location = New System.Drawing.Point(47, 191)
        Me.btnCopy.Name = "btnCopy"
        Me.btnCopy.Size = New System.Drawing.Size(41, 23)
        Me.btnCopy.TabIndex = 4
        Me.btnCopy.Text = "Copy"
        Me.btnCopy.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnEdit.AutoSize = True
        Me.btnEdit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnEdit.Location = New System.Drawing.Point(6, 191)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(35, 23)
        Me.btnEdit.TabIndex = 3
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.AutoSize = True
        Me.btnAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnAdd.Location = New System.Drawing.Point(6, 6)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(36, 23)
        Me.btnAdd.TabIndex = 1
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'tpEdit
        '
        Me.tpEdit.BackColor = System.Drawing.SystemColors.Control
        Me.tpEdit.Controls.Add(Me.btnBack)
        Me.tpEdit.Controls.Add(Me.llbBrowse)
        Me.tpEdit.Controls.Add(Me.txtAppPath)
        Me.tpEdit.Controls.Add(Me.btnSave)
        Me.tpEdit.Controls.Add(Me.lblAppName)
        Me.tpEdit.Controls.Add(Me.txtAppName)
        Me.tpEdit.Controls.Add(Me.lblAppPath)
        Me.tpEdit.Location = New System.Drawing.Point(4, 22)
        Me.tpEdit.Name = "tpEdit"
        Me.tpEdit.Padding = New System.Windows.Forms.Padding(3)
        Me.tpEdit.Size = New System.Drawing.Size(676, 221)
        Me.tpEdit.TabIndex = 1
        Me.tpEdit.Text = "Edit"
        '
        'btnBack
        '
        Me.btnBack.AutoSize = True
        Me.btnBack.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnBack.Location = New System.Drawing.Point(6, 6)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(42, 23)
        Me.btnBack.TabIndex = 1
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'frmAppList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 247)
        Me.Controls.Add(Me.tcAppList)
        Me.Name = "frmAppList"
        Me.Text = "AppList"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgvStartApp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tcAppList.ResumeLayout(False)
        Me.tpAppList.ResumeLayout(False)
        Me.tpAppList.PerformLayout()
        Me.tpEdit.ResumeLayout(False)
        Me.tpEdit.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblAppName As Label
    Friend WithEvents txtAppName As TextBox
    Friend WithEvents txtAppPath As TextBox
    Friend WithEvents lblAppPath As Label
    Friend WithEvents dgvStartApp As DataGridView
    Friend WithEvents btnSave As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents llbBrowse As LinkLabel
    Friend WithEvents tcAppList As TabControl
    Friend WithEvents tpAppList As TabPage
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents tpEdit As TabPage
    Friend WithEvents btnBack As Button
    Friend WithEvents btnCopy As Button
End Class
