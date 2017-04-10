<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProcess
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
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroCheckBox1 = New MetroFramework.Controls.MetroCheckBox()
        Me.MetroCheckBox2 = New MetroFramework.Controls.MetroCheckBox()
        Me.MetroCheckBox3 = New MetroFramework.Controls.MetroCheckBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.MetroCheckBox4 = New MetroFramework.Controls.MetroCheckBox()
        Me.MetroProgressBar1 = New MetroFramework.Controls.MetroProgressBar()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton2 = New MetroFramework.Controls.MetroButton()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel1.Location = New System.Drawing.Point(8, 18)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(193, 25)
        Me.MetroLabel1.TabIndex = 0
        Me.MetroLabel1.Text = "TimeKeeping Process"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(50, 60)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(56, 19)
        Me.MetroLabel2.TabIndex = 1
        Me.MetroLabel2.Text = "Division:"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(23, 87)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(83, 19)
        Me.MetroLabel3.TabIndex = 2
        Me.MetroLabel3.Text = "Department:"
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(50, 114)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(54, 19)
        Me.MetroLabel4.TabIndex = 3
        Me.MetroLabel4.Text = "Section:"
        '
        'MetroCheckBox1
        '
        Me.MetroCheckBox1.AutoSize = True
        Me.MetroCheckBox1.Location = New System.Drawing.Point(475, 60)
        Me.MetroCheckBox1.Name = "MetroCheckBox1"
        Me.MetroCheckBox1.Size = New System.Drawing.Size(82, 15)
        Me.MetroCheckBox1.TabIndex = 7
        Me.MetroCheckBox1.Text = "All Division"
        Me.MetroCheckBox1.UseSelectable = True
        '
        'MetroCheckBox2
        '
        Me.MetroCheckBox2.AutoSize = True
        Me.MetroCheckBox2.Location = New System.Drawing.Point(475, 87)
        Me.MetroCheckBox2.Name = "MetroCheckBox2"
        Me.MetroCheckBox2.Size = New System.Drawing.Size(103, 15)
        Me.MetroCheckBox2.TabIndex = 8
        Me.MetroCheckBox2.Text = "All Department"
        Me.MetroCheckBox2.UseSelectable = True
        '
        'MetroCheckBox3
        '
        Me.MetroCheckBox3.AutoSize = True
        Me.MetroCheckBox3.Location = New System.Drawing.Point(475, 114)
        Me.MetroCheckBox3.Name = "MetroCheckBox3"
        Me.MetroCheckBox3.Size = New System.Drawing.Size(79, 15)
        Me.MetroCheckBox3.TabIndex = 9
        Me.MetroCheckBox3.Text = "All Section"
        Me.MetroCheckBox3.UseSelectable = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(23, 156)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(568, 231)
        Me.DataGridView1.TabIndex = 10
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(112, 60)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(360, 21)
        Me.ComboBox1.TabIndex = 11
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(112, 87)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(360, 21)
        Me.ComboBox2.TabIndex = 12
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(112, 114)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(360, 21)
        Me.ComboBox3.TabIndex = 13
        '
        'MetroCheckBox4
        '
        Me.MetroCheckBox4.AutoSize = True
        Me.MetroCheckBox4.Location = New System.Drawing.Point(475, 135)
        Me.MetroCheckBox4.Name = "MetroCheckBox4"
        Me.MetroCheckBox4.Size = New System.Drawing.Size(92, 15)
        Me.MetroCheckBox4.TabIndex = 14
        Me.MetroCheckBox4.Text = "All Employee"
        Me.MetroCheckBox4.UseSelectable = True
        '
        'MetroProgressBar1
        '
        Me.MetroProgressBar1.Location = New System.Drawing.Point(23, 393)
        Me.MetroProgressBar1.Name = "MetroProgressBar1"
        Me.MetroProgressBar1.Size = New System.Drawing.Size(568, 20)
        Me.MetroProgressBar1.TabIndex = 15
        '
        'MetroButton1
        '
        Me.MetroButton1.BackColor = System.Drawing.Color.Peru
        Me.MetroButton1.Location = New System.Drawing.Point(23, 422)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(121, 23)
        Me.MetroButton1.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroButton1.TabIndex = 16
        Me.MetroButton1.Text = "Process"
        Me.MetroButton1.UseMnemonic = False
        Me.MetroButton1.UseSelectable = True
        '
        'MetroButton2
        '
        Me.MetroButton2.Location = New System.Drawing.Point(470, 422)
        Me.MetroButton2.Name = "MetroButton2"
        Me.MetroButton2.Size = New System.Drawing.Size(121, 23)
        Me.MetroButton2.TabIndex = 17
        Me.MetroButton2.Text = "Cancel"
        Me.MetroButton2.UseSelectable = True
        '
        'frmProcess
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(614, 468)
        Me.Controls.Add(Me.MetroButton2)
        Me.Controls.Add(Me.MetroButton1)
        Me.Controls.Add(Me.MetroProgressBar1)
        Me.Controls.Add(Me.MetroCheckBox4)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.MetroCheckBox3)
        Me.Controls.Add(Me.MetroCheckBox2)
        Me.Controls.Add(Me.MetroCheckBox1)
        Me.Controls.Add(Me.MetroLabel4)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Name = "frmProcess"
        Me.Style = MetroFramework.MetroColorStyle.Green
        Me.TopMost = True
        Me.TransparencyKey = System.Drawing.Color.GhostWhite
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroCheckBox1 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents MetroCheckBox2 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents MetroCheckBox3 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents MetroCheckBox4 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents MetroProgressBar1 As MetroFramework.Controls.MetroProgressBar
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton2 As MetroFramework.Controls.MetroButton
End Class
