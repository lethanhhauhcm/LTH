<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRequest
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
        Me.tcRequest = New System.Windows.Forms.TabControl()
        Me.tpRequestList = New System.Windows.Forms.TabPage()
        Me.tpEdit = New System.Windows.Forms.TabPage()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.dgvRequestList = New System.Windows.Forms.DataGridView()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnUpdatePendDesc = New System.Windows.Forms.Button()
        Me.btnComplete = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.cboProject = New System.Windows.Forms.ComboBox()
        Me.lblProject = New System.Windows.Forms.Label()
        Me.lblRequestType = New System.Windows.Forms.Label()
        Me.cboRequestType = New System.Windows.Forms.ComboBox()
        Me.txtRequestFunction = New System.Windows.Forms.TextBox()
        Me.lblRequestFunc = New System.Windows.Forms.Label()
        Me.rtpRequestDesc = New System.Windows.Forms.RichTextBox()
        Me.lblRequestDesc = New System.Windows.Forms.Label()
        Me.llbEditProject = New System.Windows.Forms.LinkLabel()
        Me.txtRequestImg = New System.Windows.Forms.TextBox()
        Me.lblRequestImg = New System.Windows.Forms.Label()
        Me.llbBrowse = New System.Windows.Forms.LinkLabel()
        Me.lblPendingDesc = New System.Windows.Forms.Label()
        Me.rtbPendingDesc = New System.Windows.Forms.RichTextBox()
        Me.tcRequest.SuspendLayout()
        Me.tpRequestList.SuspendLayout()
        Me.tpEdit.SuspendLayout()
        CType(Me.dgvRequestList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tcRequest
        '
        Me.tcRequest.Controls.Add(Me.tpRequestList)
        Me.tcRequest.Controls.Add(Me.tpEdit)
        Me.tcRequest.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcRequest.Location = New System.Drawing.Point(0, 0)
        Me.tcRequest.Name = "tcRequest"
        Me.tcRequest.SelectedIndex = 0
        Me.tcRequest.Size = New System.Drawing.Size(553, 557)
        Me.tcRequest.TabIndex = 0
        '
        'tpRequestList
        '
        Me.tpRequestList.BackColor = System.Drawing.SystemColors.Control
        Me.tpRequestList.Controls.Add(Me.btnDelete)
        Me.tpRequestList.Controls.Add(Me.btnComplete)
        Me.tpRequestList.Controls.Add(Me.btnUpdatePendDesc)
        Me.tpRequestList.Controls.Add(Me.btnEdit)
        Me.tpRequestList.Controls.Add(Me.dgvRequestList)
        Me.tpRequestList.Controls.Add(Me.btnAdd)
        Me.tpRequestList.Location = New System.Drawing.Point(4, 22)
        Me.tpRequestList.Name = "tpRequestList"
        Me.tpRequestList.Padding = New System.Windows.Forms.Padding(3)
        Me.tpRequestList.Size = New System.Drawing.Size(545, 531)
        Me.tpRequestList.TabIndex = 0
        Me.tpRequestList.Text = "RequestList"
        '
        'tpEdit
        '
        Me.tpEdit.BackColor = System.Drawing.SystemColors.Control
        Me.tpEdit.Controls.Add(Me.lblPendingDesc)
        Me.tpEdit.Controls.Add(Me.rtbPendingDesc)
        Me.tpEdit.Controls.Add(Me.llbBrowse)
        Me.tpEdit.Controls.Add(Me.lblRequestImg)
        Me.tpEdit.Controls.Add(Me.txtRequestImg)
        Me.tpEdit.Controls.Add(Me.llbEditProject)
        Me.tpEdit.Controls.Add(Me.lblRequestDesc)
        Me.tpEdit.Controls.Add(Me.rtpRequestDesc)
        Me.tpEdit.Controls.Add(Me.lblRequestFunc)
        Me.tpEdit.Controls.Add(Me.txtRequestFunction)
        Me.tpEdit.Controls.Add(Me.lblRequestType)
        Me.tpEdit.Controls.Add(Me.cboRequestType)
        Me.tpEdit.Controls.Add(Me.lblProject)
        Me.tpEdit.Controls.Add(Me.cboProject)
        Me.tpEdit.Location = New System.Drawing.Point(4, 22)
        Me.tpEdit.Name = "tpEdit"
        Me.tpEdit.Padding = New System.Windows.Forms.Padding(3)
        Me.tpEdit.Size = New System.Drawing.Size(545, 531)
        Me.tpEdit.TabIndex = 1
        Me.tpEdit.Text = "Edit"
        '
        'btnAdd
        '
        Me.btnAdd.AutoSize = True
        Me.btnAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnAdd.Location = New System.Drawing.Point(6, 6)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(36, 23)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'dgvRequestList
        '
        Me.dgvRequestList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvRequestList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRequestList.Location = New System.Drawing.Point(6, 35)
        Me.dgvRequestList.Name = "dgvRequestList"
        Me.dgvRequestList.Size = New System.Drawing.Size(533, 461)
        Me.dgvRequestList.TabIndex = 1
        '
        'btnEdit
        '
        Me.btnEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnEdit.AutoSize = True
        Me.btnEdit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnEdit.Location = New System.Drawing.Point(6, 502)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(35, 23)
        Me.btnEdit.TabIndex = 2
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnUpdatePendDesc
        '
        Me.btnUpdatePendDesc.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnUpdatePendDesc.AutoSize = True
        Me.btnUpdatePendDesc.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnUpdatePendDesc.Location = New System.Drawing.Point(47, 502)
        Me.btnUpdatePendDesc.Name = "btnUpdatePendDesc"
        Me.btnUpdatePendDesc.Size = New System.Drawing.Size(102, 23)
        Me.btnUpdatePendDesc.TabIndex = 3
        Me.btnUpdatePendDesc.Text = "UpdatePendDesc"
        Me.btnUpdatePendDesc.UseVisualStyleBackColor = True
        '
        'btnComplete
        '
        Me.btnComplete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnComplete.AutoSize = True
        Me.btnComplete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnComplete.Location = New System.Drawing.Point(155, 502)
        Me.btnComplete.Name = "btnComplete"
        Me.btnComplete.Size = New System.Drawing.Size(61, 23)
        Me.btnComplete.TabIndex = 4
        Me.btnComplete.Text = "Complete"
        Me.btnComplete.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnDelete.AutoSize = True
        Me.btnDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnDelete.Location = New System.Drawing.Point(222, 502)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(48, 23)
        Me.btnDelete.TabIndex = 5
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'cboProject
        '
        Me.cboProject.FormattingEnabled = True
        Me.cboProject.Location = New System.Drawing.Point(90, 6)
        Me.cboProject.Name = "cboProject"
        Me.cboProject.Size = New System.Drawing.Size(200, 21)
        Me.cboProject.TabIndex = 0
        '
        'lblProject
        '
        Me.lblProject.AutoSize = True
        Me.lblProject.Location = New System.Drawing.Point(44, 9)
        Me.lblProject.Name = "lblProject"
        Me.lblProject.Size = New System.Drawing.Size(40, 13)
        Me.lblProject.TabIndex = 1
        Me.lblProject.Text = "Project"
        '
        'lblRequestType
        '
        Me.lblRequestType.AutoSize = True
        Me.lblRequestType.Location = New System.Drawing.Point(13, 36)
        Me.lblRequestType.Name = "lblRequestType"
        Me.lblRequestType.Size = New System.Drawing.Size(71, 13)
        Me.lblRequestType.TabIndex = 3
        Me.lblRequestType.Text = "RequestType"
        '
        'cboRequestType
        '
        Me.cboRequestType.FormattingEnabled = True
        Me.cboRequestType.Items.AddRange(New Object() {"Edit", "New"})
        Me.cboRequestType.Location = New System.Drawing.Point(90, 33)
        Me.cboRequestType.Name = "cboRequestType"
        Me.cboRequestType.Size = New System.Drawing.Size(50, 21)
        Me.cboRequestType.TabIndex = 2
        '
        'txtRequestFunction
        '
        Me.txtRequestFunction.Location = New System.Drawing.Point(90, 60)
        Me.txtRequestFunction.Name = "txtRequestFunction"
        Me.txtRequestFunction.Size = New System.Drawing.Size(400, 20)
        Me.txtRequestFunction.TabIndex = 4
        '
        'lblRequestFunc
        '
        Me.lblRequestFunc.AutoSize = True
        Me.lblRequestFunc.Location = New System.Drawing.Point(13, 63)
        Me.lblRequestFunc.Name = "lblRequestFunc"
        Me.lblRequestFunc.Size = New System.Drawing.Size(71, 13)
        Me.lblRequestFunc.TabIndex = 5
        Me.lblRequestFunc.Text = "RequestFunc"
        '
        'rtpRequestDesc
        '
        Me.rtpRequestDesc.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rtpRequestDesc.Location = New System.Drawing.Point(90, 86)
        Me.rtpRequestDesc.Name = "rtpRequestDesc"
        Me.rtpRequestDesc.Size = New System.Drawing.Size(400, 200)
        Me.rtpRequestDesc.TabIndex = 6
        Me.rtpRequestDesc.Text = ""
        '
        'lblRequestDesc
        '
        Me.lblRequestDesc.AutoSize = True
        Me.lblRequestDesc.Location = New System.Drawing.Point(13, 86)
        Me.lblRequestDesc.Name = "lblRequestDesc"
        Me.lblRequestDesc.Size = New System.Drawing.Size(72, 13)
        Me.lblRequestDesc.TabIndex = 7
        Me.lblRequestDesc.Text = "RequestDesc"
        '
        'llbEditProject
        '
        Me.llbEditProject.AutoSize = True
        Me.llbEditProject.Location = New System.Drawing.Point(296, 9)
        Me.llbEditProject.Name = "llbEditProject"
        Me.llbEditProject.Size = New System.Drawing.Size(58, 13)
        Me.llbEditProject.TabIndex = 1
        Me.llbEditProject.TabStop = True
        Me.llbEditProject.Text = "EditProject"
        '
        'txtRequestImg
        '
        Me.txtRequestImg.Location = New System.Drawing.Point(90, 292)
        Me.txtRequestImg.Name = "txtRequestImg"
        Me.txtRequestImg.Size = New System.Drawing.Size(400, 20)
        Me.txtRequestImg.TabIndex = 8
        '
        'lblRequestImg
        '
        Me.lblRequestImg.AutoSize = True
        Me.lblRequestImg.Location = New System.Drawing.Point(20, 295)
        Me.lblRequestImg.Name = "lblRequestImg"
        Me.lblRequestImg.Size = New System.Drawing.Size(64, 13)
        Me.lblRequestImg.TabIndex = 9
        Me.lblRequestImg.Text = "RequestImg"
        '
        'llbBrowse
        '
        Me.llbBrowse.AutoSize = True
        Me.llbBrowse.Location = New System.Drawing.Point(496, 295)
        Me.llbBrowse.Name = "llbBrowse"
        Me.llbBrowse.Size = New System.Drawing.Size(42, 13)
        Me.llbBrowse.TabIndex = 10
        Me.llbBrowse.TabStop = True
        Me.llbBrowse.Text = "Browse"
        '
        'lblPendingDesc
        '
        Me.lblPendingDesc.AutoSize = True
        Me.lblPendingDesc.Location = New System.Drawing.Point(13, 318)
        Me.lblPendingDesc.Name = "lblPendingDesc"
        Me.lblPendingDesc.Size = New System.Drawing.Size(71, 13)
        Me.lblPendingDesc.TabIndex = 12
        Me.lblPendingDesc.Text = "PendingDesc"
        '
        'rtbPendingDesc
        '
        Me.rtbPendingDesc.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rtbPendingDesc.Location = New System.Drawing.Point(90, 318)
        Me.rtbPendingDesc.Name = "rtbPendingDesc"
        Me.rtbPendingDesc.Size = New System.Drawing.Size(400, 200)
        Me.rtbPendingDesc.TabIndex = 11
        Me.rtbPendingDesc.Text = ""
        '
        'frmRequest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(553, 557)
        Me.Controls.Add(Me.tcRequest)
        Me.Name = "frmRequest"
        Me.Text = "Request"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.tcRequest.ResumeLayout(False)
        Me.tpRequestList.ResumeLayout(False)
        Me.tpRequestList.PerformLayout()
        Me.tpEdit.ResumeLayout(False)
        Me.tpEdit.PerformLayout()
        CType(Me.dgvRequestList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tcRequest As TabControl
    Friend WithEvents tpRequestList As TabPage
    Friend WithEvents dgvRequestList As DataGridView
    Friend WithEvents btnAdd As Button
    Friend WithEvents tpEdit As TabPage
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnComplete As Button
    Friend WithEvents btnUpdatePendDesc As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents lblPendingDesc As Label
    Friend WithEvents rtbPendingDesc As RichTextBox
    Friend WithEvents llbBrowse As LinkLabel
    Friend WithEvents lblRequestImg As Label
    Friend WithEvents txtRequestImg As TextBox
    Friend WithEvents llbEditProject As LinkLabel
    Friend WithEvents lblRequestDesc As Label
    Friend WithEvents rtpRequestDesc As RichTextBox
    Friend WithEvents lblRequestFunc As Label
    Friend WithEvents txtRequestFunction As TextBox
    Friend WithEvents lblRequestType As Label
    Friend WithEvents cboRequestType As ComboBox
    Friend WithEvents lblProject As Label
    Friend WithEvents cboProject As ComboBox
End Class
