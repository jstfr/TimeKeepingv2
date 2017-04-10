<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTimeShift
    Inherits MetroFramework.Forms.MetroForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTimeShift))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnlInfo = New MetroFramework.Controls.MetroPanel()
        Me.picTime = New System.Windows.Forms.PictureBox()
        Me.txtHalfDay = New MetroFramework.Controls.MetroTextBox()
        Me.lblGPUndertime = New MetroFramework.Controls.MetroLabel()
        Me.txtGPLate = New MetroFramework.Controls.MetroTextBox()
        Me.lblGPLate = New MetroFramework.Controls.MetroLabel()
        Me.txtGPUndertime = New MetroFramework.Controls.MetroTextBox()
        Me.txtNDStart = New MetroFramework.Controls.MetroTextBox()
        Me.txtNDEnd = New MetroFramework.Controls.MetroTextBox()
        Me.txtWrkHrs = New MetroFramework.Controls.MetroTextBox()
        Me.lblHalfDay = New MetroFramework.Controls.MetroLabel()
        Me.lblNDEnd = New MetroFramework.Controls.MetroLabel()
        Me.lblNDStart = New MetroFramework.Controls.MetroLabel()
        Me.txtTimein = New MetroFramework.Controls.MetroTextBox()
        Me.lblNightDiff = New MetroFramework.Controls.MetroLabel()
        Me.lblhrs = New MetroFramework.Controls.MetroLabel()
        Me.lblWrkHrs = New MetroFramework.Controls.MetroLabel()
        Me.txtLunchout = New MetroFramework.Controls.MetroTextBox()
        Me.txtTimeout = New MetroFramework.Controls.MetroTextBox()
        Me.chkNightShift = New MetroFramework.Controls.MetroCheckBox()
        Me.txtLunchin = New MetroFramework.Controls.MetroTextBox()
        Me.lblCode = New MetroFramework.Controls.MetroLabel()
        Me.chkFlexySched = New MetroFramework.Controls.MetroCheckBox()
        Me.lblLunchin = New MetroFramework.Controls.MetroLabel()
        Me.lblDesc = New MetroFramework.Controls.MetroLabel()
        Me.chkFlexyTime = New MetroFramework.Controls.MetroCheckBox()
        Me.txtCode = New MetroFramework.Controls.MetroTextBox()
        Me.txtDesc = New MetroFramework.Controls.MetroTextBox()
        Me.lblTimein = New MetroFramework.Controls.MetroLabel()
        Me.lblTimeout = New MetroFramework.Controls.MetroLabel()
        Me.lblLunchout = New MetroFramework.Controls.MetroLabel()
        Me.btnDelete = New System.Windows.Forms.PictureBox()
        Me.pnlTable = New MetroFramework.Controls.MetroPanel()
        Me.dgvTimeSched = New MetroFramework.Controls.MetroGrid()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnSave = New System.Windows.Forms.PictureBox()
        Me.btnAdd = New System.Windows.Forms.PictureBox()
        Me.btnCancel = New System.Windows.Forms.PictureBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.pnlInfo.SuspendLayout()
        CType(Me.picTime, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnDelete, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTable.SuspendLayout()
        CType(Me.dgvTimeSched, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSave, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAdd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCancel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlInfo
        '
        Me.pnlInfo.Controls.Add(Me.picTime)
        Me.pnlInfo.Controls.Add(Me.txtHalfDay)
        Me.pnlInfo.Controls.Add(Me.lblGPUndertime)
        Me.pnlInfo.Controls.Add(Me.txtGPLate)
        Me.pnlInfo.Controls.Add(Me.lblGPLate)
        Me.pnlInfo.Controls.Add(Me.txtGPUndertime)
        Me.pnlInfo.Controls.Add(Me.txtNDStart)
        Me.pnlInfo.Controls.Add(Me.txtNDEnd)
        Me.pnlInfo.Controls.Add(Me.txtWrkHrs)
        Me.pnlInfo.Controls.Add(Me.lblHalfDay)
        Me.pnlInfo.Controls.Add(Me.lblNDEnd)
        Me.pnlInfo.Controls.Add(Me.lblNDStart)
        Me.pnlInfo.Controls.Add(Me.txtTimein)
        Me.pnlInfo.Controls.Add(Me.lblNightDiff)
        Me.pnlInfo.Controls.Add(Me.lblhrs)
        Me.pnlInfo.Controls.Add(Me.lblWrkHrs)
        Me.pnlInfo.Controls.Add(Me.txtLunchout)
        Me.pnlInfo.Controls.Add(Me.txtTimeout)
        Me.pnlInfo.Controls.Add(Me.chkNightShift)
        Me.pnlInfo.Controls.Add(Me.txtLunchin)
        Me.pnlInfo.Controls.Add(Me.lblCode)
        Me.pnlInfo.Controls.Add(Me.chkFlexySched)
        Me.pnlInfo.Controls.Add(Me.lblLunchin)
        Me.pnlInfo.Controls.Add(Me.lblDesc)
        Me.pnlInfo.Controls.Add(Me.chkFlexyTime)
        Me.pnlInfo.Controls.Add(Me.txtCode)
        Me.pnlInfo.Controls.Add(Me.txtDesc)
        Me.pnlInfo.Controls.Add(Me.lblTimein)
        Me.pnlInfo.Controls.Add(Me.lblTimeout)
        Me.pnlInfo.Controls.Add(Me.lblLunchout)
        Me.pnlInfo.HorizontalScrollbarBarColor = True
        Me.pnlInfo.HorizontalScrollbarHighlightOnWheel = False
        Me.pnlInfo.HorizontalScrollbarSize = 10
        Me.pnlInfo.Location = New System.Drawing.Point(23, 84)
        Me.pnlInfo.Name = "pnlInfo"
        Me.pnlInfo.Size = New System.Drawing.Size(600, 397)
        Me.pnlInfo.TabIndex = 92
        Me.pnlInfo.VerticalScrollbarBarColor = True
        Me.pnlInfo.VerticalScrollbarHighlightOnWheel = False
        Me.pnlInfo.VerticalScrollbarSize = 10
        '
        'picTime
        '
        Me.picTime.Image = CType(resources.GetObject("picTime.Image"), System.Drawing.Image)
        Me.picTime.Location = New System.Drawing.Point(484, 16)
        Me.picTime.Name = "picTime"
        Me.picTime.Size = New System.Drawing.Size(107, 99)
        Me.picTime.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picTime.TabIndex = 121
        Me.picTime.TabStop = False
        '
        'txtHalfDay
        '
        '
        '
        '
        Me.txtHalfDay.CustomButton.Image = Nothing
        Me.txtHalfDay.CustomButton.Location = New System.Drawing.Point(134, 1)
        Me.txtHalfDay.CustomButton.Name = ""
        Me.txtHalfDay.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtHalfDay.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtHalfDay.CustomButton.TabIndex = 1
        Me.txtHalfDay.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtHalfDay.CustomButton.UseSelectable = True
        Me.txtHalfDay.CustomButton.Visible = False
        Me.txtHalfDay.Lines = New String(-1) {}
        Me.txtHalfDay.Location = New System.Drawing.Point(435, 139)
        Me.txtHalfDay.MaxLength = 32767
        Me.txtHalfDay.Name = "txtHalfDay"
        Me.txtHalfDay.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtHalfDay.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtHalfDay.SelectedText = ""
        Me.txtHalfDay.SelectionLength = 0
        Me.txtHalfDay.SelectionStart = 0
        Me.txtHalfDay.ShortcutsEnabled = True
        Me.txtHalfDay.Size = New System.Drawing.Size(156, 23)
        Me.txtHalfDay.TabIndex = 120
        Me.txtHalfDay.UseSelectable = True
        Me.txtHalfDay.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtHalfDay.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'lblGPUndertime
        '
        Me.lblGPUndertime.AutoSize = True
        Me.lblGPUndertime.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.lblGPUndertime.Location = New System.Drawing.Point(338, 307)
        Me.lblGPUndertime.Name = "lblGPUndertime"
        Me.lblGPUndertime.Size = New System.Drawing.Size(158, 19)
        Me.lblGPUndertime.TabIndex = 105
        Me.lblGPUndertime.Text = "Undertime Grace Period:"
        '
        'txtGPLate
        '
        '
        '
        '
        Me.txtGPLate.CustomButton.Image = Nothing
        Me.txtGPLate.CustomButton.Location = New System.Drawing.Point(66, 1)
        Me.txtGPLate.CustomButton.Name = ""
        Me.txtGPLate.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtGPLate.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtGPLate.CustomButton.TabIndex = 1
        Me.txtGPLate.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtGPLate.CustomButton.UseSelectable = True
        Me.txtGPLate.CustomButton.Visible = False
        Me.txtGPLate.Lines = New String(-1) {}
        Me.txtGPLate.Location = New System.Drawing.Point(502, 276)
        Me.txtGPLate.MaxLength = 32767
        Me.txtGPLate.Name = "txtGPLate"
        Me.txtGPLate.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtGPLate.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtGPLate.SelectedText = ""
        Me.txtGPLate.SelectionLength = 0
        Me.txtGPLate.SelectionStart = 0
        Me.txtGPLate.ShortcutsEnabled = True
        Me.txtGPLate.Size = New System.Drawing.Size(88, 23)
        Me.txtGPLate.TabIndex = 119
        Me.txtGPLate.UseSelectable = True
        Me.txtGPLate.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtGPLate.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'lblGPLate
        '
        Me.lblGPLate.AutoSize = True
        Me.lblGPLate.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.lblGPLate.Location = New System.Drawing.Point(377, 280)
        Me.lblGPLate.Name = "lblGPLate"
        Me.lblGPLate.Size = New System.Drawing.Size(119, 19)
        Me.lblGPLate.TabIndex = 102
        Me.lblGPLate.Text = "Late Grace Period:"
        '
        'txtGPUndertime
        '
        '
        '
        '
        Me.txtGPUndertime.CustomButton.Image = Nothing
        Me.txtGPUndertime.CustomButton.Location = New System.Drawing.Point(66, 1)
        Me.txtGPUndertime.CustomButton.Name = ""
        Me.txtGPUndertime.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtGPUndertime.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtGPUndertime.CustomButton.TabIndex = 1
        Me.txtGPUndertime.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtGPUndertime.CustomButton.UseSelectable = True
        Me.txtGPUndertime.CustomButton.Visible = False
        Me.txtGPUndertime.Lines = New String(-1) {}
        Me.txtGPUndertime.Location = New System.Drawing.Point(503, 307)
        Me.txtGPUndertime.MaxLength = 32767
        Me.txtGPUndertime.Name = "txtGPUndertime"
        Me.txtGPUndertime.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtGPUndertime.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtGPUndertime.SelectedText = ""
        Me.txtGPUndertime.SelectionLength = 0
        Me.txtGPUndertime.SelectionStart = 0
        Me.txtGPUndertime.ShortcutsEnabled = True
        Me.txtGPUndertime.Size = New System.Drawing.Size(88, 23)
        Me.txtGPUndertime.TabIndex = 118
        Me.txtGPUndertime.UseSelectable = True
        Me.txtGPUndertime.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtGPUndertime.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtNDStart
        '
        '
        '
        '
        Me.txtNDStart.CustomButton.Image = Nothing
        Me.txtNDStart.CustomButton.Location = New System.Drawing.Point(133, 1)
        Me.txtNDStart.CustomButton.Name = ""
        Me.txtNDStart.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtNDStart.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtNDStart.CustomButton.TabIndex = 1
        Me.txtNDStart.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtNDStart.CustomButton.UseSelectable = True
        Me.txtNDStart.CustomButton.Visible = False
        Me.txtNDStart.Lines = New String(-1) {}
        Me.txtNDStart.Location = New System.Drawing.Point(177, 276)
        Me.txtNDStart.MaxLength = 32767
        Me.txtNDStart.Name = "txtNDStart"
        Me.txtNDStart.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNDStart.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNDStart.SelectedText = ""
        Me.txtNDStart.SelectionLength = 0
        Me.txtNDStart.SelectionStart = 0
        Me.txtNDStart.ShortcutsEnabled = True
        Me.txtNDStart.Size = New System.Drawing.Size(155, 23)
        Me.txtNDStart.TabIndex = 117
        Me.txtNDStart.UseSelectable = True
        Me.txtNDStart.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtNDStart.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtNDEnd
        '
        '
        '
        '
        Me.txtNDEnd.CustomButton.Image = Nothing
        Me.txtNDEnd.CustomButton.Location = New System.Drawing.Point(133, 1)
        Me.txtNDEnd.CustomButton.Name = ""
        Me.txtNDEnd.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtNDEnd.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtNDEnd.CustomButton.TabIndex = 1
        Me.txtNDEnd.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtNDEnd.CustomButton.UseSelectable = True
        Me.txtNDEnd.CustomButton.Visible = False
        Me.txtNDEnd.Lines = New String(-1) {}
        Me.txtNDEnd.Location = New System.Drawing.Point(177, 307)
        Me.txtNDEnd.MaxLength = 32767
        Me.txtNDEnd.Name = "txtNDEnd"
        Me.txtNDEnd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNDEnd.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNDEnd.SelectedText = ""
        Me.txtNDEnd.SelectionLength = 0
        Me.txtNDEnd.SelectionStart = 0
        Me.txtNDEnd.ShortcutsEnabled = True
        Me.txtNDEnd.Size = New System.Drawing.Size(155, 23)
        Me.txtNDEnd.TabIndex = 116
        Me.txtNDEnd.UseSelectable = True
        Me.txtNDEnd.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtNDEnd.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtWrkHrs
        '
        '
        '
        '
        Me.txtWrkHrs.CustomButton.Image = Nothing
        Me.txtWrkHrs.CustomButton.Location = New System.Drawing.Point(27, 1)
        Me.txtWrkHrs.CustomButton.Name = ""
        Me.txtWrkHrs.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtWrkHrs.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtWrkHrs.CustomButton.TabIndex = 1
        Me.txtWrkHrs.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtWrkHrs.CustomButton.UseSelectable = True
        Me.txtWrkHrs.CustomButton.Visible = False
        Me.txtWrkHrs.Lines = New String(-1) {}
        Me.txtWrkHrs.Location = New System.Drawing.Point(253, 135)
        Me.txtWrkHrs.MaxLength = 32767
        Me.txtWrkHrs.Name = "txtWrkHrs"
        Me.txtWrkHrs.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtWrkHrs.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtWrkHrs.SelectedText = ""
        Me.txtWrkHrs.SelectionLength = 0
        Me.txtWrkHrs.SelectionStart = 0
        Me.txtWrkHrs.ShortcutsEnabled = True
        Me.txtWrkHrs.Size = New System.Drawing.Size(49, 23)
        Me.txtWrkHrs.TabIndex = 115
        Me.txtWrkHrs.UseSelectable = True
        Me.txtWrkHrs.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtWrkHrs.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'lblHalfDay
        '
        Me.lblHalfDay.AutoSize = True
        Me.lblHalfDay.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.lblHalfDay.Location = New System.Drawing.Point(366, 139)
        Me.lblHalfDay.Name = "lblHalfDay"
        Me.lblHalfDay.Size = New System.Drawing.Size(64, 19)
        Me.lblHalfDay.TabIndex = 94
        Me.lblHalfDay.Text = "Half Day:"
        '
        'lblNDEnd
        '
        Me.lblNDEnd.AutoSize = True
        Me.lblNDEnd.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.lblNDEnd.Location = New System.Drawing.Point(65, 311)
        Me.lblNDEnd.Name = "lblNDEnd"
        Me.lblNDEnd.Size = New System.Drawing.Size(92, 19)
        Me.lblNDEnd.TabIndex = 104
        Me.lblNDEnd.Text = "ND Time End:"
        '
        'lblNDStart
        '
        Me.lblNDStart.AutoSize = True
        Me.lblNDStart.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.lblNDStart.Location = New System.Drawing.Point(57, 280)
        Me.lblNDStart.Name = "lblNDStart"
        Me.lblNDStart.Size = New System.Drawing.Size(98, 19)
        Me.lblNDStart.TabIndex = 101
        Me.lblNDStart.Text = "ND Time Start:"
        '
        'txtTimein
        '
        '
        '
        '
        Me.txtTimein.CustomButton.Image = Nothing
        Me.txtTimein.CustomButton.Location = New System.Drawing.Point(133, 1)
        Me.txtTimein.CustomButton.Name = ""
        Me.txtTimein.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtTimein.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtTimein.CustomButton.TabIndex = 1
        Me.txtTimein.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtTimein.CustomButton.UseSelectable = True
        Me.txtTimein.CustomButton.Visible = False
        Me.txtTimein.Lines = New String(-1) {}
        Me.txtTimein.Location = New System.Drawing.Point(177, 172)
        Me.txtTimein.MaxLength = 32767
        Me.txtTimein.Name = "txtTimein"
        Me.txtTimein.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTimein.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtTimein.SelectedText = ""
        Me.txtTimein.SelectionLength = 0
        Me.txtTimein.SelectionStart = 0
        Me.txtTimein.ShortcutsEnabled = True
        Me.txtTimein.Size = New System.Drawing.Size(155, 23)
        Me.txtTimein.TabIndex = 114
        Me.txtTimein.UseSelectable = True
        Me.txtTimein.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtTimein.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'lblNightDiff
        '
        Me.lblNightDiff.AutoSize = True
        Me.lblNightDiff.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.lblNightDiff.Location = New System.Drawing.Point(25, 249)
        Me.lblNightDiff.Name = "lblNightDiff"
        Me.lblNightDiff.Size = New System.Drawing.Size(216, 19)
        Me.lblNightDiff.TabIndex = 99
        Me.lblNightDiff.Text = "Night Differential Computation"
        '
        'lblhrs
        '
        Me.lblhrs.AutoSize = True
        Me.lblhrs.Location = New System.Drawing.Point(308, 135)
        Me.lblhrs.Name = "lblhrs"
        Me.lblhrs.Size = New System.Drawing.Size(33, 19)
        Me.lblhrs.TabIndex = 100
        Me.lblhrs.Text = "HRS"
        '
        'lblWrkHrs
        '
        Me.lblWrkHrs.AutoSize = True
        Me.lblWrkHrs.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.lblWrkHrs.Location = New System.Drawing.Point(18, 135)
        Me.lblWrkHrs.Name = "lblWrkHrs"
        Me.lblWrkHrs.Size = New System.Drawing.Size(223, 19)
        Me.lblWrkHrs.TabIndex = 92
        Me.lblWrkHrs.Text = "Official Number of Work Hours:"
        '
        'txtLunchout
        '
        '
        '
        '
        Me.txtLunchout.CustomButton.Image = Nothing
        Me.txtLunchout.CustomButton.Location = New System.Drawing.Point(133, 1)
        Me.txtLunchout.CustomButton.Name = ""
        Me.txtLunchout.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtLunchout.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtLunchout.CustomButton.TabIndex = 1
        Me.txtLunchout.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtLunchout.CustomButton.UseSelectable = True
        Me.txtLunchout.CustomButton.Visible = False
        Me.txtLunchout.Lines = New String(-1) {}
        Me.txtLunchout.Location = New System.Drawing.Point(177, 203)
        Me.txtLunchout.MaxLength = 32767
        Me.txtLunchout.Name = "txtLunchout"
        Me.txtLunchout.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtLunchout.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtLunchout.SelectedText = ""
        Me.txtLunchout.SelectionLength = 0
        Me.txtLunchout.SelectionStart = 0
        Me.txtLunchout.ShortcutsEnabled = True
        Me.txtLunchout.Size = New System.Drawing.Size(155, 23)
        Me.txtLunchout.TabIndex = 113
        Me.txtLunchout.UseSelectable = True
        Me.txtLunchout.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtLunchout.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtTimeout
        '
        '
        '
        '
        Me.txtTimeout.CustomButton.Image = Nothing
        Me.txtTimeout.CustomButton.Location = New System.Drawing.Point(133, 1)
        Me.txtTimeout.CustomButton.Name = ""
        Me.txtTimeout.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtTimeout.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtTimeout.CustomButton.TabIndex = 1
        Me.txtTimeout.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtTimeout.CustomButton.UseSelectable = True
        Me.txtTimeout.CustomButton.Visible = False
        Me.txtTimeout.Lines = New String(-1) {}
        Me.txtTimeout.Location = New System.Drawing.Point(436, 172)
        Me.txtTimeout.MaxLength = 32767
        Me.txtTimeout.Name = "txtTimeout"
        Me.txtTimeout.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTimeout.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtTimeout.SelectedText = ""
        Me.txtTimeout.SelectionLength = 0
        Me.txtTimeout.SelectionStart = 0
        Me.txtTimeout.ShortcutsEnabled = True
        Me.txtTimeout.Size = New System.Drawing.Size(155, 23)
        Me.txtTimeout.TabIndex = 112
        Me.txtTimeout.UseSelectable = True
        Me.txtTimeout.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtTimeout.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'chkNightShift
        '
        Me.chkNightShift.AutoSize = True
        Me.chkNightShift.FontSize = MetroFramework.MetroCheckBoxSize.Medium
        Me.chkNightShift.Location = New System.Drawing.Point(381, 96)
        Me.chkNightShift.Name = "chkNightShift"
        Me.chkNightShift.Size = New System.Drawing.Size(90, 19)
        Me.chkNightShift.TabIndex = 110
        Me.chkNightShift.Text = "Night Shift"
        Me.chkNightShift.UseSelectable = True
        '
        'txtLunchin
        '
        '
        '
        '
        Me.txtLunchin.CustomButton.Image = Nothing
        Me.txtLunchin.CustomButton.Location = New System.Drawing.Point(134, 1)
        Me.txtLunchin.CustomButton.Name = ""
        Me.txtLunchin.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtLunchin.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtLunchin.CustomButton.TabIndex = 1
        Me.txtLunchin.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtLunchin.CustomButton.UseSelectable = True
        Me.txtLunchin.CustomButton.Visible = False
        Me.txtLunchin.Lines = New String(-1) {}
        Me.txtLunchin.Location = New System.Drawing.Point(435, 203)
        Me.txtLunchin.MaxLength = 32767
        Me.txtLunchin.Name = "txtLunchin"
        Me.txtLunchin.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtLunchin.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtLunchin.SelectedText = ""
        Me.txtLunchin.SelectionLength = 0
        Me.txtLunchin.SelectionStart = 0
        Me.txtLunchin.ShortcutsEnabled = True
        Me.txtLunchin.Size = New System.Drawing.Size(156, 23)
        Me.txtLunchin.TabIndex = 111
        Me.txtLunchin.UseSelectable = True
        Me.txtLunchin.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtLunchin.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'lblCode
        '
        Me.lblCode.AutoSize = True
        Me.lblCode.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.lblCode.Location = New System.Drawing.Point(66, 35)
        Me.lblCode.Name = "lblCode"
        Me.lblCode.Size = New System.Drawing.Size(44, 19)
        Me.lblCode.TabIndex = 103
        Me.lblCode.Text = "Code:"
        '
        'chkFlexySched
        '
        Me.chkFlexySched.AutoSize = True
        Me.chkFlexySched.FontSize = MetroFramework.MetroCheckBoxSize.Medium
        Me.chkFlexySched.Location = New System.Drawing.Point(246, 96)
        Me.chkFlexySched.Name = "chkFlexySched"
        Me.chkFlexySched.Size = New System.Drawing.Size(95, 19)
        Me.chkFlexySched.TabIndex = 109
        Me.chkFlexySched.Text = "Flexy Sched"
        Me.chkFlexySched.UseSelectable = True
        '
        'lblLunchin
        '
        Me.lblLunchin.AutoSize = True
        Me.lblLunchin.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.lblLunchin.Location = New System.Drawing.Point(366, 203)
        Me.lblLunchin.Name = "lblLunchin"
        Me.lblLunchin.Size = New System.Drawing.Size(64, 19)
        Me.lblLunchin.TabIndex = 98
        Me.lblLunchin.Text = "Lunch in:"
        '
        'lblDesc
        '
        Me.lblDesc.AutoSize = True
        Me.lblDesc.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.lblDesc.Location = New System.Drawing.Point(29, 71)
        Me.lblDesc.Name = "lblDesc"
        Me.lblDesc.Size = New System.Drawing.Size(81, 19)
        Me.lblDesc.TabIndex = 95
        Me.lblDesc.Text = "Description:"
        '
        'chkFlexyTime
        '
        Me.chkFlexyTime.AutoSize = True
        Me.chkFlexyTime.FontSize = MetroFramework.MetroCheckBoxSize.Medium
        Me.chkFlexyTime.Location = New System.Drawing.Point(116, 96)
        Me.chkFlexyTime.Name = "chkFlexyTime"
        Me.chkFlexyTime.Size = New System.Drawing.Size(88, 19)
        Me.chkFlexyTime.TabIndex = 108
        Me.chkFlexyTime.Text = "Flexy Time"
        Me.chkFlexyTime.UseSelectable = True
        '
        'txtCode
        '
        '
        '
        '
        Me.txtCode.CustomButton.Image = Nothing
        Me.txtCode.CustomButton.Location = New System.Drawing.Point(333, 1)
        Me.txtCode.CustomButton.Name = ""
        Me.txtCode.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtCode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtCode.CustomButton.TabIndex = 1
        Me.txtCode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtCode.CustomButton.UseSelectable = True
        Me.txtCode.CustomButton.Visible = False
        Me.txtCode.Lines = New String(-1) {}
        Me.txtCode.Location = New System.Drawing.Point(116, 35)
        Me.txtCode.MaxLength = 32767
        Me.txtCode.Name = "txtCode"
        Me.txtCode.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCode.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtCode.SelectedText = ""
        Me.txtCode.SelectionLength = 0
        Me.txtCode.SelectionStart = 0
        Me.txtCode.ShortcutsEnabled = True
        Me.txtCode.Size = New System.Drawing.Size(355, 23)
        Me.txtCode.TabIndex = 106
        Me.txtCode.UseSelectable = True
        Me.txtCode.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtCode.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtDesc
        '
        '
        '
        '
        Me.txtDesc.CustomButton.Image = Nothing
        Me.txtDesc.CustomButton.Location = New System.Drawing.Point(333, 1)
        Me.txtDesc.CustomButton.Name = ""
        Me.txtDesc.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtDesc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtDesc.CustomButton.TabIndex = 1
        Me.txtDesc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtDesc.CustomButton.UseSelectable = True
        Me.txtDesc.CustomButton.Visible = False
        Me.txtDesc.Lines = New String(-1) {}
        Me.txtDesc.Location = New System.Drawing.Point(116, 67)
        Me.txtDesc.MaxLength = 32767
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDesc.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtDesc.SelectedText = ""
        Me.txtDesc.SelectionLength = 0
        Me.txtDesc.SelectionStart = 0
        Me.txtDesc.ShortcutsEnabled = True
        Me.txtDesc.Size = New System.Drawing.Size(355, 23)
        Me.txtDesc.TabIndex = 107
        Me.txtDesc.UseSelectable = True
        Me.txtDesc.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtDesc.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'lblTimein
        '
        Me.lblTimein.AutoSize = True
        Me.lblTimein.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.lblTimein.Location = New System.Drawing.Point(110, 172)
        Me.lblTimein.Name = "lblTimein"
        Me.lblTimein.Size = New System.Drawing.Size(56, 19)
        Me.lblTimein.TabIndex = 96
        Me.lblTimein.Text = "Time in:"
        '
        'lblTimeout
        '
        Me.lblTimeout.AutoSize = True
        Me.lblTimeout.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.lblTimeout.Location = New System.Drawing.Point(364, 172)
        Me.lblTimeout.Name = "lblTimeout"
        Me.lblTimeout.Size = New System.Drawing.Size(66, 19)
        Me.lblTimeout.TabIndex = 93
        Me.lblTimeout.Text = "Time out:"
        '
        'lblLunchout
        '
        Me.lblLunchout.AutoSize = True
        Me.lblLunchout.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.lblLunchout.Location = New System.Drawing.Point(89, 203)
        Me.lblLunchout.Name = "lblLunchout"
        Me.lblLunchout.Size = New System.Drawing.Size(77, 19)
        Me.lblLunchout.TabIndex = 97
        Me.lblLunchout.Text = "Lunch Out:"
        '
        'btnDelete
        '
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Image)
        Me.btnDelete.Location = New System.Drawing.Point(495, 496)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(51, 46)
        Me.btnDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnDelete.TabIndex = 124
        Me.btnDelete.TabStop = False
        '
        'pnlTable
        '
        Me.pnlTable.Controls.Add(Me.dgvTimeSched)
        Me.pnlTable.HorizontalScrollbarBarColor = True
        Me.pnlTable.HorizontalScrollbarHighlightOnWheel = False
        Me.pnlTable.HorizontalScrollbarSize = 10
        Me.pnlTable.Location = New System.Drawing.Point(23, 84)
        Me.pnlTable.Name = "pnlTable"
        Me.pnlTable.Size = New System.Drawing.Size(600, 397)
        Me.pnlTable.TabIndex = 122
        Me.pnlTable.VerticalScrollbarBarColor = True
        Me.pnlTable.VerticalScrollbarHighlightOnWheel = False
        Me.pnlTable.VerticalScrollbarSize = 10
        '
        'dgvTimeSched
        '
        Me.dgvTimeSched.AllowUserToResizeRows = False
        Me.dgvTimeSched.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvTimeSched.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvTimeSched.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvTimeSched.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvTimeSched.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvTimeSched.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTimeSched.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvTimeSched.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvTimeSched.EnableHeadersVisualStyles = False
        Me.dgvTimeSched.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dgvTimeSched.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvTimeSched.Location = New System.Drawing.Point(18, 16)
        Me.dgvTimeSched.Name = "dgvTimeSched"
        Me.dgvTimeSched.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvTimeSched.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvTimeSched.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvTimeSched.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTimeSched.Size = New System.Drawing.Size(572, 366)
        Me.dgvTimeSched.Style = MetroFramework.MetroColorStyle.Brown
        Me.dgvTimeSched.TabIndex = 2
        '
        'Column1
        '
        Me.Column1.HeaderText = "Code"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Description"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Time in"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Time out"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Halfday"
        Me.Column5.Name = "Column5"
        '
        'btnSave
        '
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.Location = New System.Drawing.Point(428, 496)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(51, 46)
        Me.btnSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnSave.TabIndex = 123
        Me.btnSave.TabStop = False
        '
        'btnAdd
        '
        Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Image)
        Me.btnAdd.Location = New System.Drawing.Point(361, 496)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(51, 46)
        Me.btnAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnAdd.TabIndex = 125
        Me.btnAdd.TabStop = False
        '
        'btnCancel
        '
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.Location = New System.Drawing.Point(563, 496)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(51, 46)
        Me.btnCancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnCancel.TabIndex = 126
        Me.btnCancel.TabStop = False
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel1.Location = New System.Drawing.Point(8, 11)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(220, 25)
        Me.MetroLabel1.TabIndex = 123
        Me.MetroLabel1.Text = "TimeKeeping Shift Entry"
        '
        'frmTimeShift
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.ClientSize = New System.Drawing.Size(633, 555)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.pnlInfo)
        Me.Controls.Add(Me.pnlTable)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmTimeShift"
        Me.Style = MetroFramework.MetroColorStyle.Green
        Me.TopMost = True
        Me.pnlInfo.ResumeLayout(False)
        Me.pnlInfo.PerformLayout()
        CType(Me.picTime, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnDelete, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTable.ResumeLayout(False)
        CType(Me.dgvTimeSched, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSave, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAdd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCancel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnlInfo As MetroFramework.Controls.MetroPanel
    Friend WithEvents picTime As System.Windows.Forms.PictureBox
    Friend WithEvents txtHalfDay As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblGPUndertime As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtGPLate As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblGPLate As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtGPUndertime As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtNDStart As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtNDEnd As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtWrkHrs As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblHalfDay As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblNDEnd As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblNDStart As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtTimein As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblNightDiff As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblhrs As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblWrkHrs As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtLunchout As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtTimeout As MetroFramework.Controls.MetroTextBox
    Friend WithEvents chkNightShift As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents txtLunchin As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblCode As MetroFramework.Controls.MetroLabel
    Friend WithEvents chkFlexySched As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents lblLunchin As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblDesc As MetroFramework.Controls.MetroLabel
    Friend WithEvents chkFlexyTime As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents txtCode As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtDesc As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblTimein As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblTimeout As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblLunchout As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnSave As System.Windows.Forms.PictureBox
    Friend WithEvents btnDelete As System.Windows.Forms.PictureBox
    Friend WithEvents btnAdd As System.Windows.Forms.PictureBox
    Friend WithEvents pnlTable As MetroFramework.Controls.MetroPanel
    Friend WithEvents dgvTimeSched As MetroFramework.Controls.MetroGrid
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnCancel As System.Windows.Forms.PictureBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
End Class
