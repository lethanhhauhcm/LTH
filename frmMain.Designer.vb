<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.tpEditList = New System.Windows.Forms.TabPage()
        Me.btnSort = New System.Windows.Forms.Button()
        Me.btnSaveList = New System.Windows.Forms.Button()
        Me.rtbAppList = New System.Windows.Forms.RichTextBox()
        Me.btnBackEditAppList = New System.Windows.Forms.Button()
        Me.tpMain = New System.Windows.Forms.TabPage()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.pnSource = New System.Windows.Forms.Panel()
        Me.llbEditLocations = New System.Windows.Forms.LinkLabel()
        Me.btnRestore = New System.Windows.Forms.Button()
        Me.cboBackup = New System.Windows.Forms.ComboBox()
        Me.lblBackup = New System.Windows.Forms.Label()
        Me.txtPushLocation = New System.Windows.Forms.TextBox()
        Me.lblLocation = New System.Windows.Forms.Label()
        Me.llbEditSourceType = New System.Windows.Forms.LinkLabel()
        Me.cboSourceType = New System.Windows.Forms.ComboBox()
        Me.btnPush = New System.Windows.Forms.Button()
        Me.lblSourceType = New System.Windows.Forms.Label()
        Me.btnPull = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.llbCalcRemainingPoint = New System.Windows.Forms.LinkLabel()
        Me.llbEditGO_TktListingRange = New System.Windows.Forms.LinkLabel()
        Me.btnInsertGO_TktListing = New System.Windows.Forms.Button()
        Me.pnStartApp = New System.Windows.Forms.Panel()
        Me.llbEditAppList = New System.Windows.Forms.LinkLabel()
        Me.btnStartApps = New System.Windows.Forms.Button()
        Me.pb01 = New System.Windows.Forms.ProgressBar()
        Me.pnAOP = New System.Windows.Forms.Panel()
        Me.btnAopSgnLog = New System.Windows.Forms.Button()
        Me.lblCity = New System.Windows.Forms.Label()
        Me.llbEditCity = New System.Windows.Forms.LinkLabel()
        Me.cboCity = New System.Windows.Forms.ComboBox()
        Me.btnBypassAop = New System.Windows.Forms.Button()
        Me.btnFixAOPNullList = New System.Windows.Forms.Button()
        Me.tcFunc = New System.Windows.Forms.TabControl()
        Me.tpEditList.SuspendLayout()
        Me.tpMain.SuspendLayout()
        Me.pnSource.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.pnStartApp.SuspendLayout()
        Me.pnAOP.SuspendLayout()
        Me.tcFunc.SuspendLayout()
        Me.SuspendLayout()
        '
        'tpEditList
        '
        Me.tpEditList.BackColor = System.Drawing.SystemColors.Control
        Me.tpEditList.Controls.Add(Me.btnSort)
        Me.tpEditList.Controls.Add(Me.btnSaveList)
        Me.tpEditList.Controls.Add(Me.rtbAppList)
        Me.tpEditList.Controls.Add(Me.btnBackEditAppList)
        Me.tpEditList.Location = New System.Drawing.Point(23, 4)
        Me.tpEditList.Name = "tpEditList"
        Me.tpEditList.Padding = New System.Windows.Forms.Padding(3)
        Me.tpEditList.Size = New System.Drawing.Size(587, 291)
        Me.tpEditList.TabIndex = 3
        Me.tpEditList.Text = "EditList"
        '
        'btnSort
        '
        Me.btnSort.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSort.AutoSize = True
        Me.btnSort.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnSort.Location = New System.Drawing.Point(8, 260)
        Me.btnSort.Name = "btnSort"
        Me.btnSort.Size = New System.Drawing.Size(36, 23)
        Me.btnSort.TabIndex = 4
        Me.btnSort.Text = "Sort"
        Me.btnSort.UseVisualStyleBackColor = True
        '
        'btnSaveList
        '
        Me.btnSaveList.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSaveList.AutoSize = True
        Me.btnSaveList.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnSaveList.Location = New System.Drawing.Point(50, 260)
        Me.btnSaveList.Name = "btnSaveList"
        Me.btnSaveList.Size = New System.Drawing.Size(58, 23)
        Me.btnSaveList.TabIndex = 3
        Me.btnSaveList.Text = "SaveList"
        Me.btnSaveList.UseVisualStyleBackColor = True
        '
        'rtbAppList
        '
        Me.rtbAppList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rtbAppList.Location = New System.Drawing.Point(8, 35)
        Me.rtbAppList.Name = "rtbAppList"
        Me.rtbAppList.Size = New System.Drawing.Size(571, 219)
        Me.rtbAppList.TabIndex = 2
        Me.rtbAppList.Text = ""
        Me.rtbAppList.WordWrap = False
        '
        'btnBackEditAppList
        '
        Me.btnBackEditAppList.AutoSize = True
        Me.btnBackEditAppList.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnBackEditAppList.Location = New System.Drawing.Point(6, 6)
        Me.btnBackEditAppList.Name = "btnBackEditAppList"
        Me.btnBackEditAppList.Size = New System.Drawing.Size(42, 23)
        Me.btnBackEditAppList.TabIndex = 0
        Me.btnBackEditAppList.Text = "Back"
        Me.btnBackEditAppList.UseVisualStyleBackColor = True
        '
        'tpMain
        '
        Me.tpMain.BackColor = System.Drawing.SystemColors.Control
        Me.tpMain.Controls.Add(Me.LinkLabel1)
        Me.tpMain.Controls.Add(Me.pnSource)
        Me.tpMain.Controls.Add(Me.Panel1)
        Me.tpMain.Controls.Add(Me.pnStartApp)
        Me.tpMain.Controls.Add(Me.pb01)
        Me.tpMain.Controls.Add(Me.pnAOP)
        Me.tpMain.Location = New System.Drawing.Point(23, 4)
        Me.tpMain.Name = "tpMain"
        Me.tpMain.Padding = New System.Windows.Forms.Padding(3)
        Me.tpMain.Size = New System.Drawing.Size(587, 291)
        Me.tpMain.TabIndex = 2
        Me.tpMain.Text = "Main"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(441, 162)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(59, 13)
        Me.LinkLabel1.TabIndex = 31
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "LinkLabel1"
        '
        'pnSource
        '
        Me.pnSource.AutoSize = True
        Me.pnSource.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.pnSource.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnSource.Controls.Add(Me.llbEditLocations)
        Me.pnSource.Controls.Add(Me.btnRestore)
        Me.pnSource.Controls.Add(Me.cboBackup)
        Me.pnSource.Controls.Add(Me.lblBackup)
        Me.pnSource.Controls.Add(Me.txtPushLocation)
        Me.pnSource.Controls.Add(Me.lblLocation)
        Me.pnSource.Controls.Add(Me.llbEditSourceType)
        Me.pnSource.Controls.Add(Me.cboSourceType)
        Me.pnSource.Controls.Add(Me.btnPush)
        Me.pnSource.Controls.Add(Me.lblSourceType)
        Me.pnSource.Controls.Add(Me.btnPull)
        Me.pnSource.Location = New System.Drawing.Point(93, 35)
        Me.pnSource.Name = "pnSource"
        Me.pnSource.Size = New System.Drawing.Size(208, 153)
        Me.pnSource.TabIndex = 1
        '
        'llbEditLocations
        '
        Me.llbEditLocations.AutoSize = True
        Me.llbEditLocations.Location = New System.Drawing.Point(3, 56)
        Me.llbEditLocations.Name = "llbEditLocations"
        Me.llbEditLocations.Size = New System.Drawing.Size(71, 13)
        Me.llbEditLocations.TabIndex = 2
        Me.llbEditLocations.TabStop = True
        Me.llbEditLocations.Text = "EditLocations"
        '
        'btnRestore
        '
        Me.btnRestore.AutoSize = True
        Me.btnRestore.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnRestore.Location = New System.Drawing.Point(119, 125)
        Me.btnRestore.Name = "btnRestore"
        Me.btnRestore.Size = New System.Drawing.Size(54, 23)
        Me.btnRestore.TabIndex = 7
        Me.btnRestore.Text = "Restore"
        Me.btnRestore.UseVisualStyleBackColor = True
        '
        'cboBackup
        '
        Me.cboBackup.FormattingEnabled = True
        Me.cboBackup.Location = New System.Drawing.Point(3, 127)
        Me.cboBackup.Name = "cboBackup"
        Me.cboBackup.Size = New System.Drawing.Size(110, 21)
        Me.cboBackup.TabIndex = 6
        '
        'lblBackup
        '
        Me.lblBackup.AutoSize = True
        Me.lblBackup.Location = New System.Drawing.Point(3, 111)
        Me.lblBackup.Name = "lblBackup"
        Me.lblBackup.Size = New System.Drawing.Size(44, 13)
        Me.lblBackup.TabIndex = 36
        Me.lblBackup.Text = "Backup"
        '
        'txtPushLocation
        '
        Me.txtPushLocation.Location = New System.Drawing.Point(3, 88)
        Me.txtPushLocation.Name = "txtPushLocation"
        Me.txtPushLocation.ReadOnly = True
        Me.txtPushLocation.Size = New System.Drawing.Size(200, 20)
        Me.txtPushLocation.TabIndex = 5
        '
        'lblLocation
        '
        Me.lblLocation.AutoSize = True
        Me.lblLocation.Location = New System.Drawing.Point(3, 72)
        Me.lblLocation.Name = "lblLocation"
        Me.lblLocation.Size = New System.Drawing.Size(75, 13)
        Me.lblLocation.TabIndex = 34
        Me.lblLocation.Text = "Push Location"
        '
        'llbEditSourceType
        '
        Me.llbEditSourceType.AutoSize = True
        Me.llbEditSourceType.Location = New System.Drawing.Point(3, 43)
        Me.llbEditSourceType.Name = "llbEditSourceType"
        Me.llbEditSourceType.Size = New System.Drawing.Size(83, 13)
        Me.llbEditSourceType.TabIndex = 1
        Me.llbEditSourceType.TabStop = True
        Me.llbEditSourceType.Text = "EditSourceType"
        '
        'cboSourceType
        '
        Me.cboSourceType.FormattingEnabled = True
        Me.cboSourceType.Location = New System.Drawing.Point(3, 19)
        Me.cboSourceType.Name = "cboSourceType"
        Me.cboSourceType.Size = New System.Drawing.Size(200, 21)
        Me.cboSourceType.TabIndex = 0
        '
        'btnPush
        '
        Me.btnPush.AutoSize = True
        Me.btnPush.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnPush.Location = New System.Drawing.Point(132, 46)
        Me.btnPush.Name = "btnPush"
        Me.btnPush.Size = New System.Drawing.Size(41, 23)
        Me.btnPush.TabIndex = 4
        Me.btnPush.Text = "Push"
        Me.btnPush.UseVisualStyleBackColor = True
        '
        'lblSourceType
        '
        Me.lblSourceType.AutoSize = True
        Me.lblSourceType.Location = New System.Drawing.Point(3, 3)
        Me.lblSourceType.Name = "lblSourceType"
        Me.lblSourceType.Size = New System.Drawing.Size(65, 13)
        Me.lblSourceType.TabIndex = 30
        Me.lblSourceType.Text = "SourceType"
        '
        'btnPull
        '
        Me.btnPull.AutoSize = True
        Me.btnPull.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnPull.Location = New System.Drawing.Point(92, 46)
        Me.btnPull.Name = "btnPull"
        Me.btnPull.Size = New System.Drawing.Size(34, 23)
        Me.btnPull.TabIndex = 3
        Me.btnPull.Text = "Pull"
        Me.btnPull.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.AutoSize = True
        Me.Panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.llbCalcRemainingPoint)
        Me.Panel1.Controls.Add(Me.llbEditGO_TktListingRange)
        Me.Panel1.Controls.Add(Me.btnInsertGO_TktListing)
        Me.Panel1.Location = New System.Drawing.Point(407, 35)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(133, 61)
        Me.Panel1.TabIndex = 3
        Me.Panel1.Visible = False
        '
        'llbCalcRemainingPoint
        '
        Me.llbCalcRemainingPoint.AutoSize = True
        Me.llbCalcRemainingPoint.Location = New System.Drawing.Point(3, 46)
        Me.llbCalcRemainingPoint.Name = "llbCalcRemainingPoint"
        Me.llbCalcRemainingPoint.Size = New System.Drawing.Size(102, 13)
        Me.llbCalcRemainingPoint.TabIndex = 20
        Me.llbCalcRemainingPoint.TabStop = True
        Me.llbCalcRemainingPoint.Text = "CalcRemainingPoint"
        '
        'llbEditGO_TktListingRange
        '
        Me.llbEditGO_TktListingRange.AutoSize = True
        Me.llbEditGO_TktListingRange.Location = New System.Drawing.Point(3, 29)
        Me.llbEditGO_TktListingRange.Name = "llbEditGO_TktListingRange"
        Me.llbEditGO_TktListingRange.Size = New System.Drawing.Size(125, 13)
        Me.llbEditGO_TktListingRange.TabIndex = 19
        Me.llbEditGO_TktListingRange.TabStop = True
        Me.llbEditGO_TktListingRange.Text = "EditGO_TktListingRange"
        '
        'btnInsertGO_TktListing
        '
        Me.btnInsertGO_TktListing.AutoSize = True
        Me.btnInsertGO_TktListing.Location = New System.Drawing.Point(3, 3)
        Me.btnInsertGO_TktListing.Name = "btnInsertGO_TktListing"
        Me.btnInsertGO_TktListing.Size = New System.Drawing.Size(111, 23)
        Me.btnInsertGO_TktListing.TabIndex = 18
        Me.btnInsertGO_TktListing.Text = "InsertGO_TktListing"
        Me.btnInsertGO_TktListing.UseVisualStyleBackColor = True
        '
        'pnStartApp
        '
        Me.pnStartApp.AutoSize = True
        Me.pnStartApp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnStartApp.Controls.Add(Me.llbEditAppList)
        Me.pnStartApp.Controls.Add(Me.btnStartApps)
        Me.pnStartApp.Location = New System.Drawing.Point(6, 35)
        Me.pnStartApp.Name = "pnStartApp"
        Me.pnStartApp.Size = New System.Drawing.Size(81, 49)
        Me.pnStartApp.TabIndex = 0
        '
        'llbEditAppList
        '
        Me.llbEditAppList.AutoSize = True
        Me.llbEditAppList.Location = New System.Drawing.Point(3, 29)
        Me.llbEditAppList.Name = "llbEditAppList"
        Me.llbEditAppList.Size = New System.Drawing.Size(60, 13)
        Me.llbEditAppList.TabIndex = 1
        Me.llbEditAppList.TabStop = True
        Me.llbEditAppList.Text = "EditAppList"
        '
        'btnStartApps
        '
        Me.btnStartApps.AutoSize = True
        Me.btnStartApps.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnStartApps.Location = New System.Drawing.Point(3, 3)
        Me.btnStartApps.Name = "btnStartApps"
        Me.btnStartApps.Size = New System.Drawing.Size(63, 23)
        Me.btnStartApps.TabIndex = 0
        Me.btnStartApps.Text = "StartApps"
        Me.btnStartApps.UseVisualStyleBackColor = True
        '
        'pb01
        '
        Me.pb01.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pb01.Location = New System.Drawing.Point(6, 6)
        Me.pb01.Name = "pb01"
        Me.pb01.Size = New System.Drawing.Size(575, 23)
        Me.pb01.TabIndex = 26
        '
        'pnAOP
        '
        Me.pnAOP.AutoSize = True
        Me.pnAOP.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.pnAOP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnAOP.Controls.Add(Me.btnAopSgnLog)
        Me.pnAOP.Controls.Add(Me.lblCity)
        Me.pnAOP.Controls.Add(Me.llbEditCity)
        Me.pnAOP.Controls.Add(Me.cboCity)
        Me.pnAOP.Controls.Add(Me.btnBypassAop)
        Me.pnAOP.Controls.Add(Me.btnFixAOPNullList)
        Me.pnAOP.Location = New System.Drawing.Point(307, 35)
        Me.pnAOP.Name = "pnAOP"
        Me.pnAOP.Size = New System.Drawing.Size(94, 129)
        Me.pnAOP.TabIndex = 2
        '
        'btnAopSgnLog
        '
        Me.btnAopSgnLog.AutoSize = True
        Me.btnAopSgnLog.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnAopSgnLog.Location = New System.Drawing.Point(3, 3)
        Me.btnAopSgnLog.Name = "btnAopSgnLog"
        Me.btnAopSgnLog.Size = New System.Drawing.Size(73, 23)
        Me.btnAopSgnLog.TabIndex = 25
        Me.btnAopSgnLog.Text = "AopSgnLog"
        Me.btnAopSgnLog.UseVisualStyleBackColor = True
        '
        'lblCity
        '
        Me.lblCity.AutoSize = True
        Me.lblCity.Location = New System.Drawing.Point(3, 35)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(24, 13)
        Me.lblCity.TabIndex = 24
        Me.lblCity.Text = "City"
        '
        'llbEditCity
        '
        Me.llbEditCity.AutoSize = True
        Me.llbEditCity.Location = New System.Drawing.Point(3, 56)
        Me.llbEditCity.Name = "llbEditCity"
        Me.llbEditCity.Size = New System.Drawing.Size(42, 13)
        Me.llbEditCity.TabIndex = 23
        Me.llbEditCity.TabStop = True
        Me.llbEditCity.Text = "EditCity"
        '
        'cboCity
        '
        Me.cboCity.FormattingEnabled = True
        Me.cboCity.Location = New System.Drawing.Point(30, 32)
        Me.cboCity.Name = "cboCity"
        Me.cboCity.Size = New System.Drawing.Size(45, 21)
        Me.cboCity.TabIndex = 22
        '
        'btnBypassAop
        '
        Me.btnBypassAop.AutoSize = True
        Me.btnBypassAop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnBypassAop.Location = New System.Drawing.Point(3, 72)
        Me.btnBypassAop.Name = "btnBypassAop"
        Me.btnBypassAop.Size = New System.Drawing.Size(70, 23)
        Me.btnBypassAop.TabIndex = 21
        Me.btnBypassAop.Text = "BypassAop"
        Me.btnBypassAop.UseVisualStyleBackColor = True
        '
        'btnFixAOPNullList
        '
        Me.btnFixAOPNullList.AutoSize = True
        Me.btnFixAOPNullList.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnFixAOPNullList.Location = New System.Drawing.Point(3, 101)
        Me.btnFixAOPNullList.Name = "btnFixAOPNullList"
        Me.btnFixAOPNullList.Size = New System.Drawing.Size(86, 23)
        Me.btnFixAOPNullList.TabIndex = 19
        Me.btnFixAOPNullList.Text = "FixAOPNullList"
        Me.btnFixAOPNullList.UseVisualStyleBackColor = True
        '
        'tcFunc
        '
        Me.tcFunc.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.tcFunc.Controls.Add(Me.tpMain)
        Me.tcFunc.Controls.Add(Me.tpEditList)
        Me.tcFunc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcFunc.Location = New System.Drawing.Point(0, 0)
        Me.tcFunc.Multiline = True
        Me.tcFunc.Name = "tcFunc"
        Me.tcFunc.SelectedIndex = 0
        Me.tcFunc.Size = New System.Drawing.Size(614, 299)
        Me.tcFunc.TabIndex = 5
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(614, 299)
        Me.Controls.Add(Me.tcFunc)
        Me.Name = "frmMain"
        Me.Text = "LTH"
        Me.tpEditList.ResumeLayout(False)
        Me.tpEditList.PerformLayout()
        Me.tpMain.ResumeLayout(False)
        Me.tpMain.PerformLayout()
        Me.pnSource.ResumeLayout(False)
        Me.pnSource.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pnStartApp.ResumeLayout(False)
        Me.pnStartApp.PerformLayout()
        Me.pnAOP.ResumeLayout(False)
        Me.pnAOP.PerformLayout()
        Me.tcFunc.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tpEditList As TabPage
    Friend WithEvents tpMain As TabPage
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents pnSource As Panel
    Friend WithEvents llbEditLocations As LinkLabel
    Friend WithEvents btnRestore As Button
    Friend WithEvents cboBackup As ComboBox
    Friend WithEvents lblBackup As Label
    Friend WithEvents txtPushLocation As TextBox
    Friend WithEvents lblLocation As Label
    Friend WithEvents llbEditSourceType As LinkLabel
    Friend WithEvents cboSourceType As ComboBox
    Friend WithEvents btnPush As Button
    Friend WithEvents lblSourceType As Label
    Friend WithEvents btnPull As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents llbCalcRemainingPoint As LinkLabel
    Friend WithEvents llbEditGO_TktListingRange As LinkLabel
    Friend WithEvents btnInsertGO_TktListing As Button
    Friend WithEvents pnStartApp As Panel
    Friend WithEvents llbEditAppList As LinkLabel
    Friend WithEvents btnStartApps As Button
    Friend WithEvents pb01 As ProgressBar
    Friend WithEvents pnAOP As Panel
    Friend WithEvents btnAopSgnLog As Button
    Friend WithEvents lblCity As Label
    Friend WithEvents llbEditCity As LinkLabel
    Friend WithEvents cboCity As ComboBox
    Friend WithEvents btnBypassAop As Button
    Friend WithEvents btnFixAOPNullList As Button
    Friend WithEvents btnSort As Button
    Friend WithEvents btnSaveList As Button
    Friend WithEvents rtbAppList As RichTextBox
    Friend WithEvents btnBackEditAppList As Button
    Friend WithEvents tcFunc As TabControl
End Class
