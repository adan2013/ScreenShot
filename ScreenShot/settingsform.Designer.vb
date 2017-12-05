<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class settingsform
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(settingsform))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnskrot = New System.Windows.Forms.Button()
        Me.lblskrot = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnautostart = New System.Windows.Forms.Button()
        Me.lblautostart = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.listext = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnpath = New System.Windows.Forms.Button()
        Me.lblpath = New System.Windows.Forms.Label()
        Me.radiodofolderu = New System.Windows.Forms.RadioButton()
        Me.radiopytaj = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.folderdialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.btnend = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.chkboxcolorpicker = New System.Windows.Forms.CheckBox()
        Me.lstdefcolor = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lstdefnarz = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkboxopendir = New System.Windows.Forms.CheckBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblver = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnskrot)
        Me.GroupBox1.Controls.Add(Me.lblskrot)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(223, 80)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Skrót klawiszowy"
        '
        'btnskrot
        '
        Me.btnskrot.Location = New System.Drawing.Point(142, 51)
        Me.btnskrot.Name = "btnskrot"
        Me.btnskrot.Size = New System.Drawing.Size(75, 23)
        Me.btnskrot.TabIndex = 1
        Me.btnskrot.Text = "Zmień"
        Me.btnskrot.UseVisualStyleBackColor = True
        '
        'lblskrot
        '
        Me.lblskrot.AutoSize = True
        Me.lblskrot.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblskrot.Location = New System.Drawing.Point(6, 22)
        Me.lblskrot.Margin = New System.Windows.Forms.Padding(3, 5, 3, 0)
        Me.lblskrot.Name = "lblskrot"
        Me.lblskrot.Size = New System.Drawing.Size(88, 20)
        Me.lblskrot.TabIndex = 0
        Me.lblskrot.Text = "brak skrótu"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnautostart)
        Me.GroupBox2.Controls.Add(Me.lblautostart)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 98)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(223, 80)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Autostart aplikacji"
        '
        'btnautostart
        '
        Me.btnautostart.Location = New System.Drawing.Point(142, 51)
        Me.btnautostart.Name = "btnautostart"
        Me.btnautostart.Size = New System.Drawing.Size(75, 23)
        Me.btnautostart.TabIndex = 1
        Me.btnautostart.Text = "Włącz"
        Me.btnautostart.UseVisualStyleBackColor = True
        '
        'lblautostart
        '
        Me.lblautostart.AutoSize = True
        Me.lblautostart.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblautostart.Location = New System.Drawing.Point(6, 22)
        Me.lblautostart.Margin = New System.Windows.Forms.Padding(3, 5, 3, 0)
        Me.lblautostart.Name = "lblautostart"
        Me.lblautostart.Size = New System.Drawing.Size(85, 20)
        Me.lblautostart.TabIndex = 0
        Me.lblautostart.Text = "Wyłączony"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.listext)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.btnpath)
        Me.GroupBox3.Controls.Add(Me.lblpath)
        Me.GroupBox3.Controls.Add(Me.radiodofolderu)
        Me.GroupBox3.Controls.Add(Me.radiopytaj)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(241, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(265, 166)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Zapis zrzutów"
        '
        'listext
        '
        Me.listext.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.listext.FormattingEnabled = True
        Me.listext.Items.AddRange(New Object() {".png", ".jpg", ".bmp"})
        Me.listext.Location = New System.Drawing.Point(9, 121)
        Me.listext.Name = "listext"
        Me.listext.Size = New System.Drawing.Size(97, 23)
        Me.listext.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 101)
        Me.Label4.Margin = New System.Windows.Forms.Padding(3, 5, 3, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(235, 17)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Domyślne rozszerzenie pliku zrzutu:"
        '
        'btnpath
        '
        Me.btnpath.Enabled = False
        Me.btnpath.Location = New System.Drawing.Point(6, 70)
        Me.btnpath.Name = "btnpath"
        Me.btnpath.Size = New System.Drawing.Size(100, 23)
        Me.btnpath.TabIndex = 2
        Me.btnpath.Text = "Zmień folder"
        Me.btnpath.UseVisualStyleBackColor = True
        '
        'lblpath
        '
        Me.lblpath.AutoSize = True
        Me.lblpath.Enabled = False
        Me.lblpath.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblpath.Location = New System.Drawing.Point(112, 74)
        Me.lblpath.Margin = New System.Windows.Forms.Padding(3, 5, 3, 0)
        Me.lblpath.Name = "lblpath"
        Me.lblpath.Size = New System.Drawing.Size(60, 17)
        Me.lblpath.TabIndex = 3
        Me.lblpath.Text = "Desktop"
        '
        'radiodofolderu
        '
        Me.radiodofolderu.AutoSize = True
        Me.radiodofolderu.Location = New System.Drawing.Point(6, 45)
        Me.radiodofolderu.Name = "radiodofolderu"
        Me.radiodofolderu.Size = New System.Drawing.Size(119, 19)
        Me.radiodofolderu.TabIndex = 4
        Me.radiodofolderu.Text = "Zapisz do folderu"
        Me.radiodofolderu.UseVisualStyleBackColor = True
        '
        'radiopytaj
        '
        Me.radiopytaj.AutoSize = True
        Me.radiopytaj.Checked = True
        Me.radiopytaj.Location = New System.Drawing.Point(6, 20)
        Me.radiopytaj.Name = "radiopytaj"
        Me.radiopytaj.Size = New System.Drawing.Size(135, 19)
        Me.radiopytaj.TabIndex = 3
        Me.radiopytaj.TabStop = True
        Me.radiopytaj.Text = "Pytaj przed zapisem"
        Me.radiopytaj.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label5.Location = New System.Drawing.Point(565, 187)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(272, 34)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "ScreenShot" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Program jest częścią aplikacji WINEASIER"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnend
        '
        Me.btnend.Location = New System.Drawing.Point(702, 250)
        Me.btnend.Name = "btnend"
        Me.btnend.Size = New System.Drawing.Size(170, 30)
        Me.btnend.TabIndex = 2
        Me.btnend.Text = "Zakończ działanie programu"
        Me.btnend.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.chkboxcolorpicker)
        Me.GroupBox4.Controls.Add(Me.lstdefcolor)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.lstdefnarz)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.chkboxopendir)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(12, 184)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(494, 96)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Opcje aplikacji"
        '
        'chkboxcolorpicker
        '
        Me.chkboxcolorpicker.AutoSize = True
        Me.chkboxcolorpicker.Location = New System.Drawing.Point(219, 20)
        Me.chkboxcolorpicker.Name = "chkboxcolorpicker"
        Me.chkboxcolorpicker.Size = New System.Drawing.Size(269, 19)
        Me.chkboxcolorpicker.TabIndex = 10
        Me.chkboxcolorpicker.Text = "Domyślnie uruchom tryb próbkowania koloru"
        Me.chkboxcolorpicker.UseVisualStyleBackColor = True
        '
        'lstdefcolor
        '
        Me.lstdefcolor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.lstdefcolor.FormattingEnabled = True
        Me.lstdefcolor.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8"})
        Me.lstdefcolor.Location = New System.Drawing.Point(179, 67)
        Me.lstdefcolor.Name = "lstdefcolor"
        Me.lstdefcolor.Size = New System.Drawing.Size(90, 23)
        Me.lstdefcolor.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label2.Location = New System.Drawing.Point(176, 47)
        Me.Label2.Margin = New System.Windows.Forms.Padding(3, 5, 3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 17)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Domyślny kolor:"
        '
        'lstdefnarz
        '
        Me.lstdefnarz.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.lstdefnarz.FormattingEnabled = True
        Me.lstdefnarz.Items.AddRange(New Object() {"rysowanie", "prostokąty", "koło/okrąg", "tekst"})
        Me.lstdefnarz.Location = New System.Drawing.Point(10, 67)
        Me.lstdefnarz.Name = "lstdefnarz"
        Me.lstdefnarz.Size = New System.Drawing.Size(150, 23)
        Me.lstdefnarz.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 47)
        Me.Label1.Margin = New System.Windows.Forms.Padding(3, 5, 3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 17)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Domyślne narzędzie:"
        '
        'chkboxopendir
        '
        Me.chkboxopendir.AutoSize = True
        Me.chkboxopendir.Location = New System.Drawing.Point(10, 20)
        Me.chkboxopendir.Name = "chkboxopendir"
        Me.chkboxopendir.Size = New System.Drawing.Size(203, 19)
        Me.chkboxopendir.TabIndex = 5
        Me.chkboxopendir.Text = "Otwórz folder po zapisie do pliku"
        Me.chkboxopendir.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.ScreenShot.My.Resources.Resources.adan2013_128
        Me.PictureBox2.Location = New System.Drawing.Point(568, 42)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(130, 130)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ScreenShot.My.Resources.Resources.logonapis
        Me.PictureBox1.Location = New System.Drawing.Point(704, 42)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(132, 130)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'lblver
        '
        Me.lblver.AutoSize = True
        Me.lblver.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblver.Location = New System.Drawing.Point(527, 254)
        Me.lblver.Name = "lblver"
        Me.lblver.Size = New System.Drawing.Size(57, 20)
        Me.lblver.TabIndex = 5
        Me.lblver.Text = "Label3"
        '
        'settingsform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 292)
        Me.Controls.Add(Me.lblver)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.btnend)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "settingsform"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ScreenShot"
        Me.TopMost = True
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnskrot As Button
    Friend WithEvents lblskrot As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnautostart As Button
    Friend WithEvents lblautostart As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents radiodofolderu As RadioButton
    Friend WithEvents radiopytaj As RadioButton
    Friend WithEvents btnpath As Button
    Friend WithEvents lblpath As Label
    Friend WithEvents listext As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents folderdialog As FolderBrowserDialog
    Friend WithEvents btnend As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents chkboxopendir As CheckBox
    Friend WithEvents lstdefcolor As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lstdefnarz As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents chkboxcolorpicker As CheckBox
    Friend WithEvents lblver As Label
End Class
