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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.tcFunc = New System.Windows.Forms.TabControl()
        Me.tpMain = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cboColumn = New System.Windows.Forms.ComboBox()
        Me.lblColumn = New System.Windows.Forms.Label()
        Me.cboTable = New System.Windows.Forms.ComboBox()
        Me.lblTable = New System.Windows.Forms.Label()
        Me.llbEditGO_TktListingRange = New System.Windows.Forms.LinkLabel()
        Me.btnInsertGO_TktListing = New System.Windows.Forms.Button()
        Me.pnSource = New System.Windows.Forms.Panel()
        Me.btnRestore = New System.Windows.Forms.Button()
        Me.cboBackupList = New System.Windows.Forms.ComboBox()
        Me.lblBackupList = New System.Windows.Forms.Label()
        Me.txtPushLocation = New System.Windows.Forms.TextBox()
        Me.lblLocation = New System.Windows.Forms.Label()
        Me.llbEditSourceType = New System.Windows.Forms.LinkLabel()
        Me.cboSourceType = New System.Windows.Forms.ComboBox()
        Me.btnPush = New System.Windows.Forms.Button()
        Me.lblSourceType = New System.Windows.Forms.Label()
        Me.btnPull = New System.Windows.Forms.Button()
        Me.pnAOP = New System.Windows.Forms.Panel()
        Me.lblCity = New System.Windows.Forms.Label()
        Me.llbEditCity = New System.Windows.Forms.LinkLabel()
        Me.cboCity = New System.Windows.Forms.ComboBox()
        Me.btnBypassAop = New System.Windows.Forms.Button()
        Me.btnAopSgnLog = New System.Windows.Forms.Button()
        Me.btnFixAOPNullList = New System.Windows.Forms.Button()
        Me.pnStartApp = New System.Windows.Forms.Panel()
        Me.llbEditAppList = New System.Windows.Forms.LinkLabel()
        Me.btnStartApps = New System.Windows.Forms.Button()
        Me.pb01 = New System.Windows.Forms.ProgressBar()
        Me.tpEditList = New System.Windows.Forms.TabPage()
        Me.btnSaveList = New System.Windows.Forms.Button()
        Me.rtbAppList = New System.Windows.Forms.RichTextBox()
        Me.btnBackEditAppList = New System.Windows.Forms.Button()
        Me.tpEditSource = New System.Windows.Forms.TabPage()
        Me.btnBackEditSource = New System.Windows.Forms.Button()
        Me.lstBackup = New System.Windows.Forms.ListBox()
        Me.tpStock = New System.Windows.Forms.TabPage()
        Me.wb01 = New System.Windows.Forms.WebBrowser()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnLoadPrice = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.dgvStock = New System.Windows.Forms.DataGridView()
        Me.StockName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NewPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaxPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Buy = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Percent = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sell = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.tcFunc.SuspendLayout()
        Me.tpMain.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.pnSource.SuspendLayout()
        Me.pnAOP.SuspendLayout()
        Me.pnStartApp.SuspendLayout()
        Me.tpEditList.SuspendLayout()
        Me.tpEditSource.SuspendLayout()
        Me.tpStock.SuspendLayout()
        CType(Me.dgvStock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tcFunc
        '
        Me.tcFunc.Controls.Add(Me.tpMain)
        Me.tcFunc.Controls.Add(Me.tpEditList)
        Me.tcFunc.Controls.Add(Me.tpEditSource)
        Me.tcFunc.Controls.Add(Me.tpStock)
        Me.tcFunc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcFunc.Location = New System.Drawing.Point(0, 0)
        Me.tcFunc.Name = "tcFunc"
        Me.tcFunc.SelectedIndex = 0
        Me.tcFunc.Size = New System.Drawing.Size(614, 299)
        Me.tcFunc.TabIndex = 5
        '
        'tpMain
        '
        Me.tpMain.BackColor = System.Drawing.SystemColors.Control
        Me.tpMain.Controls.Add(Me.Panel1)
        Me.tpMain.Controls.Add(Me.pnSource)
        Me.tpMain.Controls.Add(Me.pnAOP)
        Me.tpMain.Controls.Add(Me.pnStartApp)
        Me.tpMain.Controls.Add(Me.pb01)
        Me.tpMain.Location = New System.Drawing.Point(4, 22)
        Me.tpMain.Name = "tpMain"
        Me.tpMain.Padding = New System.Windows.Forms.Padding(3)
        Me.tpMain.Size = New System.Drawing.Size(606, 273)
        Me.tpMain.TabIndex = 2
        Me.tpMain.Text = "Main"
        '
        'Panel1
        '
        Me.Panel1.AutoSize = True
        Me.Panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.cboColumn)
        Me.Panel1.Controls.Add(Me.lblColumn)
        Me.Panel1.Controls.Add(Me.cboTable)
        Me.Panel1.Controls.Add(Me.lblTable)
        Me.Panel1.Controls.Add(Me.llbEditGO_TktListingRange)
        Me.Panel1.Controls.Add(Me.btnInsertGO_TktListing)
        Me.Panel1.Location = New System.Drawing.Point(393, 35)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(133, 126)
        Me.Panel1.TabIndex = 30
        '
        'cboColumn
        '
        Me.cboColumn.FormattingEnabled = True
        Me.cboColumn.Location = New System.Drawing.Point(3, 100)
        Me.cboColumn.Name = "cboColumn"
        Me.cboColumn.Size = New System.Drawing.Size(125, 21)
        Me.cboColumn.TabIndex = 36
        '
        'lblColumn
        '
        Me.lblColumn.AutoSize = True
        Me.lblColumn.Location = New System.Drawing.Point(3, 84)
        Me.lblColumn.Name = "lblColumn"
        Me.lblColumn.Size = New System.Drawing.Size(42, 13)
        Me.lblColumn.TabIndex = 35
        Me.lblColumn.Text = "Column"
        '
        'cboTable
        '
        Me.cboTable.FormattingEnabled = True
        Me.cboTable.Location = New System.Drawing.Point(3, 60)
        Me.cboTable.Name = "cboTable"
        Me.cboTable.Size = New System.Drawing.Size(125, 21)
        Me.cboTable.TabIndex = 34
        '
        'lblTable
        '
        Me.lblTable.AutoSize = True
        Me.lblTable.Location = New System.Drawing.Point(3, 44)
        Me.lblTable.Name = "lblTable"
        Me.lblTable.Size = New System.Drawing.Size(34, 13)
        Me.lblTable.TabIndex = 31
        Me.lblTable.Text = "Table"
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
        'pnSource
        '
        Me.pnSource.AutoSize = True
        Me.pnSource.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.pnSource.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnSource.Controls.Add(Me.btnRestore)
        Me.pnSource.Controls.Add(Me.cboBackupList)
        Me.pnSource.Controls.Add(Me.lblBackupList)
        Me.pnSource.Controls.Add(Me.txtPushLocation)
        Me.pnSource.Controls.Add(Me.lblLocation)
        Me.pnSource.Controls.Add(Me.llbEditSourceType)
        Me.pnSource.Controls.Add(Me.cboSourceType)
        Me.pnSource.Controls.Add(Me.btnPush)
        Me.pnSource.Controls.Add(Me.lblSourceType)
        Me.pnSource.Controls.Add(Me.btnPull)
        Me.pnSource.Location = New System.Drawing.Point(179, 35)
        Me.pnSource.Name = "pnSource"
        Me.pnSource.Size = New System.Drawing.Size(208, 153)
        Me.pnSource.TabIndex = 29
        '
        'btnRestore
        '
        Me.btnRestore.AutoSize = True
        Me.btnRestore.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnRestore.Location = New System.Drawing.Point(119, 125)
        Me.btnRestore.Name = "btnRestore"
        Me.btnRestore.Size = New System.Drawing.Size(54, 23)
        Me.btnRestore.TabIndex = 38
        Me.btnRestore.Text = "Restore"
        Me.btnRestore.UseVisualStyleBackColor = True
        '
        'cboBackupList
        '
        Me.cboBackupList.FormattingEnabled = True
        Me.cboBackupList.Location = New System.Drawing.Point(3, 127)
        Me.cboBackupList.Name = "cboBackupList"
        Me.cboBackupList.Size = New System.Drawing.Size(110, 21)
        Me.cboBackupList.TabIndex = 37
        '
        'lblBackupList
        '
        Me.lblBackupList.AutoSize = True
        Me.lblBackupList.Location = New System.Drawing.Point(3, 111)
        Me.lblBackupList.Name = "lblBackupList"
        Me.lblBackupList.Size = New System.Drawing.Size(60, 13)
        Me.lblBackupList.TabIndex = 36
        Me.lblBackupList.Text = "BackupList"
        '
        'txtPushLocation
        '
        Me.txtPushLocation.Location = New System.Drawing.Point(3, 88)
        Me.txtPushLocation.Name = "txtPushLocation"
        Me.txtPushLocation.ReadOnly = True
        Me.txtPushLocation.Size = New System.Drawing.Size(200, 20)
        Me.txtPushLocation.TabIndex = 35
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
        Me.llbEditSourceType.TabIndex = 33
        Me.llbEditSourceType.TabStop = True
        Me.llbEditSourceType.Text = "EditSourceType"
        '
        'cboSourceType
        '
        Me.cboSourceType.FormattingEnabled = True
        Me.cboSourceType.Location = New System.Drawing.Point(3, 19)
        Me.cboSourceType.Name = "cboSourceType"
        Me.cboSourceType.Size = New System.Drawing.Size(200, 21)
        Me.cboSourceType.TabIndex = 32
        '
        'btnPush
        '
        Me.btnPush.AutoSize = True
        Me.btnPush.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnPush.Location = New System.Drawing.Point(132, 46)
        Me.btnPush.Name = "btnPush"
        Me.btnPush.Size = New System.Drawing.Size(41, 23)
        Me.btnPush.TabIndex = 31
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
        Me.btnPull.TabIndex = 29
        Me.btnPull.Text = "Pull"
        Me.btnPull.UseVisualStyleBackColor = True
        '
        'pnAOP
        '
        Me.pnAOP.AutoSize = True
        Me.pnAOP.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.pnAOP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnAOP.Controls.Add(Me.lblCity)
        Me.pnAOP.Controls.Add(Me.llbEditCity)
        Me.pnAOP.Controls.Add(Me.cboCity)
        Me.pnAOP.Controls.Add(Me.btnBypassAop)
        Me.pnAOP.Controls.Add(Me.btnAopSgnLog)
        Me.pnAOP.Controls.Add(Me.btnFixAOPNullList)
        Me.pnAOP.Location = New System.Drawing.Point(81, 35)
        Me.pnAOP.Name = "pnAOP"
        Me.pnAOP.Size = New System.Drawing.Size(94, 129)
        Me.pnAOP.TabIndex = 28
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
        'btnAopSgnLog
        '
        Me.btnAopSgnLog.AutoSize = True
        Me.btnAopSgnLog.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnAopSgnLog.Location = New System.Drawing.Point(3, 3)
        Me.btnAopSgnLog.Name = "btnAopSgnLog"
        Me.btnAopSgnLog.Size = New System.Drawing.Size(73, 23)
        Me.btnAopSgnLog.TabIndex = 20
        Me.btnAopSgnLog.Text = "AopSgnLog"
        Me.btnAopSgnLog.UseVisualStyleBackColor = True
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
        'pnStartApp
        '
        Me.pnStartApp.AutoSize = True
        Me.pnStartApp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnStartApp.Controls.Add(Me.llbEditAppList)
        Me.pnStartApp.Controls.Add(Me.btnStartApps)
        Me.pnStartApp.Location = New System.Drawing.Point(6, 35)
        Me.pnStartApp.Name = "pnStartApp"
        Me.pnStartApp.Size = New System.Drawing.Size(71, 45)
        Me.pnStartApp.TabIndex = 27
        '
        'llbEditAppList
        '
        Me.llbEditAppList.AutoSize = True
        Me.llbEditAppList.Location = New System.Drawing.Point(3, 29)
        Me.llbEditAppList.Name = "llbEditAppList"
        Me.llbEditAppList.Size = New System.Drawing.Size(60, 13)
        Me.llbEditAppList.TabIndex = 12
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
        Me.btnStartApps.TabIndex = 11
        Me.btnStartApps.Text = "StartApps"
        Me.btnStartApps.UseVisualStyleBackColor = True
        '
        'pb01
        '
        Me.pb01.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pb01.Location = New System.Drawing.Point(6, 6)
        Me.pb01.Name = "pb01"
        Me.pb01.Size = New System.Drawing.Size(594, 23)
        Me.pb01.TabIndex = 26
        '
        'tpEditList
        '
        Me.tpEditList.BackColor = System.Drawing.SystemColors.Control
        Me.tpEditList.Controls.Add(Me.btnSaveList)
        Me.tpEditList.Controls.Add(Me.rtbAppList)
        Me.tpEditList.Controls.Add(Me.btnBackEditAppList)
        Me.tpEditList.Location = New System.Drawing.Point(4, 22)
        Me.tpEditList.Name = "tpEditList"
        Me.tpEditList.Padding = New System.Windows.Forms.Padding(3)
        Me.tpEditList.Size = New System.Drawing.Size(606, 273)
        Me.tpEditList.TabIndex = 3
        Me.tpEditList.Text = "EditList"
        '
        'btnSaveList
        '
        Me.btnSaveList.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSaveList.Location = New System.Drawing.Point(8, 242)
        Me.btnSaveList.Name = "btnSaveList"
        Me.btnSaveList.Size = New System.Drawing.Size(75, 23)
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
        Me.rtbAppList.Size = New System.Drawing.Size(590, 201)
        Me.rtbAppList.TabIndex = 2
        Me.rtbAppList.Text = ""
        Me.rtbAppList.WordWrap = False
        '
        'btnBackEditAppList
        '
        Me.btnBackEditAppList.Location = New System.Drawing.Point(6, 6)
        Me.btnBackEditAppList.Name = "btnBackEditAppList"
        Me.btnBackEditAppList.Size = New System.Drawing.Size(75, 23)
        Me.btnBackEditAppList.TabIndex = 0
        Me.btnBackEditAppList.Text = "Back"
        Me.btnBackEditAppList.UseVisualStyleBackColor = True
        '
        'tpEditSource
        '
        Me.tpEditSource.BackColor = System.Drawing.SystemColors.Control
        Me.tpEditSource.Controls.Add(Me.btnBackEditSource)
        Me.tpEditSource.Controls.Add(Me.lstBackup)
        Me.tpEditSource.Location = New System.Drawing.Point(4, 22)
        Me.tpEditSource.Name = "tpEditSource"
        Me.tpEditSource.Padding = New System.Windows.Forms.Padding(3)
        Me.tpEditSource.Size = New System.Drawing.Size(606, 273)
        Me.tpEditSource.TabIndex = 0
        Me.tpEditSource.Text = "EditSource"
        '
        'btnBackEditSource
        '
        Me.btnBackEditSource.Location = New System.Drawing.Point(6, 6)
        Me.btnBackEditSource.Name = "btnBackEditSource"
        Me.btnBackEditSource.Size = New System.Drawing.Size(75, 23)
        Me.btnBackEditSource.TabIndex = 26
        Me.btnBackEditSource.Text = "Back"
        Me.btnBackEditSource.UseVisualStyleBackColor = True
        '
        'lstBackup
        '
        Me.lstBackup.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lstBackup.BackColor = System.Drawing.SystemColors.Control
        Me.lstBackup.FormattingEnabled = True
        Me.lstBackup.Location = New System.Drawing.Point(8, 35)
        Me.lstBackup.Name = "lstBackup"
        Me.lstBackup.ScrollAlwaysVisible = True
        Me.lstBackup.Size = New System.Drawing.Size(154, 199)
        Me.lstBackup.TabIndex = 20
        '
        'tpStock
        '
        Me.tpStock.BackColor = System.Drawing.SystemColors.Control
        Me.tpStock.Controls.Add(Me.wb01)
        Me.tpStock.Controls.Add(Me.btnSave)
        Me.tpStock.Controls.Add(Me.btnLoadPrice)
        Me.tpStock.Controls.Add(Me.btnAdd)
        Me.tpStock.Controls.Add(Me.dgvStock)
        Me.tpStock.Location = New System.Drawing.Point(4, 22)
        Me.tpStock.Name = "tpStock"
        Me.tpStock.Padding = New System.Windows.Forms.Padding(3)
        Me.tpStock.Size = New System.Drawing.Size(606, 273)
        Me.tpStock.TabIndex = 1
        Me.tpStock.Text = "Stock"
        '
        'wb01
        '
        Me.wb01.Location = New System.Drawing.Point(423, 93)
        Me.wb01.MinimumSize = New System.Drawing.Size(20, 20)
        Me.wb01.Name = "wb01"
        Me.wb01.Size = New System.Drawing.Size(75, 54)
        Me.wb01.TabIndex = 20
        Me.wb01.Visible = False
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(423, 64)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 19
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnLoadPrice
        '
        Me.btnLoadPrice.Location = New System.Drawing.Point(423, 35)
        Me.btnLoadPrice.Name = "btnLoadPrice"
        Me.btnLoadPrice.Size = New System.Drawing.Size(75, 23)
        Me.btnLoadPrice.TabIndex = 18
        Me.btnLoadPrice.Text = "Load Price"
        Me.btnLoadPrice.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(423, 6)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 17
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'dgvStock
        '
        Me.dgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvStock.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.StockName, Me.NewPrice, Me.MaxPrice, Me.Buy, Me.Percent, Me.Sell})
        Me.dgvStock.Location = New System.Drawing.Point(6, 6)
        Me.dgvStock.Name = "dgvStock"
        Me.dgvStock.Size = New System.Drawing.Size(411, 243)
        Me.dgvStock.TabIndex = 0
        '
        'StockName
        '
        Me.StockName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.StockName.HeaderText = "Name"
        Me.StockName.Name = "StockName"
        Me.StockName.Width = 60
        '
        'NewPrice
        '
        Me.NewPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = "0"
        Me.NewPrice.DefaultCellStyle = DataGridViewCellStyle1
        Me.NewPrice.HeaderText = "NewPrice"
        Me.NewPrice.Name = "NewPrice"
        Me.NewPrice.Width = 78
        '
        'MaxPrice
        '
        Me.MaxPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = "0"
        Me.MaxPrice.DefaultCellStyle = DataGridViewCellStyle2
        Me.MaxPrice.HeaderText = "MaxPrice"
        Me.MaxPrice.Name = "MaxPrice"
        Me.MaxPrice.Width = 76
        '
        'Buy
        '
        Me.Buy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = "0"
        Me.Buy.DefaultCellStyle = DataGridViewCellStyle3
        Me.Buy.HeaderText = "Buy"
        Me.Buy.Name = "Buy"
        Me.Buy.Width = 50
        '
        'Percent
        '
        Me.Percent.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N0"
        DataGridViewCellStyle4.NullValue = "0"
        Me.Percent.DefaultCellStyle = DataGridViewCellStyle4
        Me.Percent.HeaderText = "Percent"
        Me.Percent.Name = "Percent"
        Me.Percent.Width = 69
        '
        'Sell
        '
        Me.Sell.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Sell.FalseValue = ""
        Me.Sell.HeaderText = "Sell"
        Me.Sell.Name = "Sell"
        Me.Sell.TrueValue = "True"
        Me.Sell.Width = 30
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(614, 299)
        Me.Controls.Add(Me.tcFunc)
        Me.Name = "frmMain"
        Me.Text = "LTH"
        Me.tcFunc.ResumeLayout(False)
        Me.tpMain.ResumeLayout(False)
        Me.tpMain.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pnSource.ResumeLayout(False)
        Me.pnSource.PerformLayout()
        Me.pnAOP.ResumeLayout(False)
        Me.pnAOP.PerformLayout()
        Me.pnStartApp.ResumeLayout(False)
        Me.pnStartApp.PerformLayout()
        Me.tpEditList.ResumeLayout(False)
        Me.tpEditSource.ResumeLayout(False)
        Me.tpStock.ResumeLayout(False)
        CType(Me.dgvStock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tcFunc As TabControl
    Friend WithEvents tpEditSource As TabPage
    Friend WithEvents lstBackup As ListBox
    Friend WithEvents tpStock As TabPage
    Friend WithEvents dgvStock As DataGridView
    Friend WithEvents wb01 As WebBrowser
    Friend WithEvents btnSave As Button
    Friend WithEvents btnLoadPrice As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents StockName As DataGridViewTextBoxColumn
    Friend WithEvents NewPrice As DataGridViewTextBoxColumn
    Friend WithEvents MaxPrice As DataGridViewTextBoxColumn
    Friend WithEvents Buy As DataGridViewTextBoxColumn
    Friend WithEvents Percent As DataGridViewTextBoxColumn
    Friend WithEvents Sell As DataGridViewCheckBoxColumn
    Friend WithEvents tpEditList As TabPage
    Friend WithEvents btnBackEditAppList As Button
    Friend WithEvents rtbAppList As RichTextBox
    Friend WithEvents btnSaveList As Button
    Friend WithEvents btnBackEditSource As Button
    Friend WithEvents tpMain As TabPage
    Friend WithEvents pnAOP As Panel
    Friend WithEvents lblCity As Label
    Friend WithEvents llbEditCity As LinkLabel
    Friend WithEvents cboCity As ComboBox
    Friend WithEvents btnBypassAop As Button
    Friend WithEvents btnAopSgnLog As Button
    Friend WithEvents btnFixAOPNullList As Button
    Friend WithEvents pnStartApp As Panel
    Friend WithEvents llbEditAppList As LinkLabel
    Friend WithEvents btnStartApps As Button
    Friend WithEvents pb01 As ProgressBar
    Friend WithEvents pnSource As Panel
    Friend WithEvents llbEditSourceType As LinkLabel
    Friend WithEvents cboSourceType As ComboBox
    Friend WithEvents btnPush As Button
    Friend WithEvents lblSourceType As Label
    Friend WithEvents btnPull As Button
    Friend WithEvents txtPushLocation As TextBox
    Friend WithEvents lblLocation As Label
    Friend WithEvents cboBackupList As ComboBox
    Friend WithEvents lblBackupList As Label
    Friend WithEvents btnRestore As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents cboColumn As ComboBox
    Friend WithEvents lblColumn As Label
    Friend WithEvents cboTable As ComboBox
    Friend WithEvents lblTable As Label
    Friend WithEvents llbEditGO_TktListingRange As LinkLabel
    Friend WithEvents btnInsertGO_TktListing As Button
End Class
