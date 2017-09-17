<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ReconForm1 = New SUICIDEINJECTOR.ReconForm()
        Me.ReconGroupBox2 = New SUICIDEINJECTOR.ReconGroupBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.ReconButton6 = New SUICIDEINJECTOR.ReconButton()
        Me.ReconButton5 = New SUICIDEINJECTOR.ReconButton()
        Me.ReconButton4 = New SUICIDEINJECTOR.ReconButton()
        Me.TxtBox1 = New SUICIDEINJECTOR.TxtBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ReconGroupBox1 = New SUICIDEINJECTOR.ReconGroupBox()
        Me.DLLs = New System.Windows.Forms.ListBox()
        Me.ReconButton3 = New SUICIDEINJECTOR.ReconButton()
        Me.ReconButton2 = New SUICIDEINJECTOR.ReconButton()
        Me.ReconButton1 = New SUICIDEINJECTOR.ReconButton()
        Me.ReconForm1.SuspendLayout()
        Me.ReconGroupBox2.SuspendLayout()
        Me.ReconGroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ReconForm1
        '
        Me.ReconForm1.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.ReconForm1.Controls.Add(Me.ReconGroupBox2)
        Me.ReconForm1.Controls.Add(Me.ReconButton6)
        Me.ReconForm1.Controls.Add(Me.ReconButton5)
        Me.ReconForm1.Controls.Add(Me.ReconButton4)
        Me.ReconForm1.Controls.Add(Me.TxtBox1)
        Me.ReconForm1.Controls.Add(Me.Label2)
        Me.ReconForm1.Controls.Add(Me.Label1)
        Me.ReconForm1.Controls.Add(Me.ReconGroupBox1)
        Me.ReconForm1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReconForm1.ForeColor = System.Drawing.Color.Firebrick
        Me.ReconForm1.Image = Nothing
        Me.ReconForm1.Location = New System.Drawing.Point(0, 0)
        Me.ReconForm1.MaximumSize = New System.Drawing.Size(417, 256)
        Me.ReconForm1.MinimumSize = New System.Drawing.Size(417, 256)
        Me.ReconForm1.MoveHeight = 30
        Me.ReconForm1.Name = "ReconForm1"
        Me.ReconForm1.Resizable = False
        Me.ReconForm1.ShowIcon = True
        Me.ReconForm1.Size = New System.Drawing.Size(417, 256)
        Me.ReconForm1.TabIndex = 0
        Me.ReconForm1.Text = "$UICIDEINJECTOR V2.0"
        Me.ReconForm1.TextAlignment = SUICIDEINJECTOR.ReconForm.TextAlign.Left
        Me.ReconForm1.TransparencyKey = System.Drawing.Color.Fuchsia
        '
        'ReconGroupBox2
        '
        Me.ReconGroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.ReconGroupBox2.Controls.Add(Me.CheckBox1)
        Me.ReconGroupBox2.Controls.Add(Me.RadioButton2)
        Me.ReconGroupBox2.Controls.Add(Me.RadioButton1)
        Me.ReconGroupBox2.Location = New System.Drawing.Point(12, 105)
        Me.ReconGroupBox2.Name = "ReconGroupBox2"
        Me.ReconGroupBox2.NoRounding = False
        Me.ReconGroupBox2.Size = New System.Drawing.Size(188, 110)
        Me.ReconGroupBox2.TabIndex = 10
        Me.ReconGroupBox2.Text = "Injection Methods"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(15, 80)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(165, 17)
        Me.CheckBox1.TabIndex = 11
        Me.CheckBox1.Text = "Close on Injection Completion"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(15, 56)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(72, 17)
        Me.RadioButton2.TabIndex = 10
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Automatic"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(15, 32)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(60, 17)
        Me.RadioButton1.TabIndex = 9
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Manual"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'ReconButton6
        '
        Me.ReconButton6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ReconButton6.ForeColor = System.Drawing.Color.Firebrick
        Me.ReconButton6.Image = Nothing
        Me.ReconButton6.Location = New System.Drawing.Point(174, 221)
        Me.ReconButton6.Name = "ReconButton6"
        Me.ReconButton6.NoRounding = False
        Me.ReconButton6.Size = New System.Drawing.Size(75, 23)
        Me.ReconButton6.TabIndex = 8
        Me.ReconButton6.Text = "How To Use"
        '
        'ReconButton5
        '
        Me.ReconButton5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ReconButton5.ForeColor = System.Drawing.Color.Firebrick
        Me.ReconButton5.Image = Nothing
        Me.ReconButton5.Location = New System.Drawing.Point(12, 221)
        Me.ReconButton5.Name = "ReconButton5"
        Me.ReconButton5.NoRounding = False
        Me.ReconButton5.Size = New System.Drawing.Size(75, 23)
        Me.ReconButton5.TabIndex = 7
        Me.ReconButton5.Text = "Exit"
        '
        'ReconButton4
        '
        Me.ReconButton4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ReconButton4.ForeColor = System.Drawing.Color.Firebrick
        Me.ReconButton4.Image = Nothing
        Me.ReconButton4.Location = New System.Drawing.Point(93, 221)
        Me.ReconButton4.Name = "ReconButton4"
        Me.ReconButton4.NoRounding = False
        Me.ReconButton4.Size = New System.Drawing.Size(75, 23)
        Me.ReconButton4.TabIndex = 6
        Me.ReconButton4.Text = "Inject"
        '
        'TxtBox1
        '
        Me.TxtBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.TxtBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.TxtBox1.ForeColor = System.Drawing.Color.White
        Me.TxtBox1.Location = New System.Drawing.Point(12, 79)
        Me.TxtBox1.Name = "TxtBox1"
        Me.TxtBox1.Size = New System.Drawing.Size(166, 20)
        Me.TxtBox1.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(166, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Proccess Name (WITHOUT .exe)"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Status: "
        '
        'ReconGroupBox1
        '
        Me.ReconGroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.ReconGroupBox1.Controls.Add(Me.DLLs)
        Me.ReconGroupBox1.Controls.Add(Me.ReconButton3)
        Me.ReconGroupBox1.Controls.Add(Me.ReconButton2)
        Me.ReconGroupBox1.Controls.Add(Me.ReconButton1)
        Me.ReconGroupBox1.Location = New System.Drawing.Point(267, 39)
        Me.ReconGroupBox1.Name = "ReconGroupBox1"
        Me.ReconGroupBox1.NoRounding = False
        Me.ReconGroupBox1.Size = New System.Drawing.Size(138, 205)
        Me.ReconGroupBox1.TabIndex = 2
        Me.ReconGroupBox1.Text = "DLL Options"
        '
        'DLLs
        '
        Me.DLLs.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.DLLs.FormattingEnabled = True
        Me.DLLs.Items.AddRange(New Object() {"DLLs"})
        Me.DLLs.Location = New System.Drawing.Point(13, 37)
        Me.DLLs.Name = "DLLs"
        Me.DLLs.Size = New System.Drawing.Size(112, 69)
        Me.DLLs.TabIndex = 4
        '
        'ReconButton3
        '
        Me.ReconButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ReconButton3.ForeColor = System.Drawing.Color.Firebrick
        Me.ReconButton3.Image = Nothing
        Me.ReconButton3.Location = New System.Drawing.Point(29, 110)
        Me.ReconButton3.Name = "ReconButton3"
        Me.ReconButton3.NoRounding = False
        Me.ReconButton3.Size = New System.Drawing.Size(75, 23)
        Me.ReconButton3.TabIndex = 3
        Me.ReconButton3.Text = "Clear List"
        '
        'ReconButton2
        '
        Me.ReconButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ReconButton2.ForeColor = System.Drawing.Color.Firebrick
        Me.ReconButton2.Image = Nothing
        Me.ReconButton2.Location = New System.Drawing.Point(29, 139)
        Me.ReconButton2.Name = "ReconButton2"
        Me.ReconButton2.NoRounding = False
        Me.ReconButton2.Size = New System.Drawing.Size(75, 23)
        Me.ReconButton2.TabIndex = 2
        Me.ReconButton2.Text = "Remove"
        '
        'ReconButton1
        '
        Me.ReconButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ReconButton1.ForeColor = System.Drawing.Color.Firebrick
        Me.ReconButton1.Image = Nothing
        Me.ReconButton1.Location = New System.Drawing.Point(29, 168)
        Me.ReconButton1.Name = "ReconButton1"
        Me.ReconButton1.NoRounding = False
        Me.ReconButton1.Size = New System.Drawing.Size(75, 23)
        Me.ReconButton1.TabIndex = 1
        Me.ReconButton1.Text = "Browse"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(417, 256)
        Me.Controls.Add(Me.ReconForm1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(417, 256)
        Me.MinimumSize = New System.Drawing.Size(417, 256)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.ReconForm1.ResumeLayout(False)
        Me.ReconForm1.PerformLayout()
        Me.ReconGroupBox2.ResumeLayout(False)
        Me.ReconGroupBox2.PerformLayout()
        Me.ReconGroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReconForm1 As ReconForm
    Friend WithEvents ReconButton6 As ReconButton
    Friend WithEvents ReconButton5 As ReconButton
    Friend WithEvents ReconButton4 As ReconButton
    Friend WithEvents TxtBox1 As TxtBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ReconGroupBox1 As ReconGroupBox
    Friend WithEvents ReconButton3 As ReconButton
    Friend WithEvents ReconButton2 As ReconButton
    Friend WithEvents ReconButton1 As ReconButton
    Friend WithEvents ReconGroupBox2 As ReconGroupBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents Timer1 As Timer
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents DLLs As ListBox
End Class
