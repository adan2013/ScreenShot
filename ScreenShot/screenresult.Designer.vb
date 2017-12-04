<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class screenresult
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(screenresult))
        Me.ts1 = New System.Windows.Forms.ToolStrip()
        Me.btnrysowanie = New System.Windows.Forms.ToolStripButton()
        Me.btnprostokat = New System.Windows.Forms.ToolStripButton()
        Me.btnokrag = New System.Windows.Forms.ToolStripButton()
        Me.btnfont = New System.Windows.Forms.ToolStripButton()
        Me.btnback = New System.Windows.Forms.ToolStripButton()
        Me.btnreset = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btncp = New System.Windows.Forms.ToolStripButton()
        Me.btnsave = New System.Windows.Forms.ToolStripButton()
        Me.btncpsave = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnresetview = New System.Windows.Forms.ToolStripButton()
        Me.btncut = New System.Windows.Forms.ToolStripButton()
        Me.btncancel = New System.Windows.Forms.ToolStripButton()
        Me.ts2 = New System.Windows.Forms.ToolStrip()
        Me.k1 = New System.Windows.Forms.ToolStripButton()
        Me.k2 = New System.Windows.Forms.ToolStripButton()
        Me.k3 = New System.Windows.Forms.ToolStripButton()
        Me.k4 = New System.Windows.Forms.ToolStripButton()
        Me.k5 = New System.Windows.Forms.ToolStripButton()
        Me.k6 = New System.Windows.Forms.ToolStripButton()
        Me.k7 = New System.Windows.Forms.ToolStripButton()
        Me.k8 = New System.Windows.Forms.ToolStripButton()
        Me.btnwypel = New System.Windows.Forms.ToolStripButton()
        Me.btn1do1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.lblgrubosc = New System.Windows.Forms.ToolStripLabel()
        Me.lstgr = New System.Windows.Forms.ToolStripComboBox()
        Me.sepfont = New System.Windows.Forms.ToolStripSeparator()
        Me.lstfont = New System.Windows.Forms.ToolStripComboBox()
        Me.lststyle = New System.Windows.Forms.ToolStripComboBox()
        Me.txtbox = New System.Windows.Forms.ToolStripTextBox()
        Me.ekran = New System.Windows.Forms.PictureBox()
        Me.akt = New System.Windows.Forms.Timer(Me.components)
        Me.savedialog = New System.Windows.Forms.SaveFileDialog()
        Me.ts1.SuspendLayout()
        Me.ts2.SuspendLayout()
        CType(Me.ekran, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ts1
        '
        Me.ts1.BackColor = System.Drawing.Color.LightGray
        Me.ts1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ts1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnrysowanie, Me.btnprostokat, Me.btnokrag, Me.btnfont, Me.btnback, Me.btnreset, Me.ToolStripSeparator2, Me.btncp, Me.btnsave, Me.btncpsave, Me.ToolStripSeparator3, Me.btnresetview, Me.btncut, Me.btncancel})
        Me.ts1.Location = New System.Drawing.Point(0, 0)
        Me.ts1.Name = "ts1"
        Me.ts1.Padding = New System.Windows.Forms.Padding(5, 2, 2, 2)
        Me.ts1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ts1.Size = New System.Drawing.Size(1034, 76)
        Me.ts1.TabIndex = 1
        Me.ts1.Text = "ToolStrip1"
        '
        'btnrysowanie
        '
        Me.btnrysowanie.Checked = True
        Me.btnrysowanie.CheckState = System.Windows.Forms.CheckState.Checked
        Me.btnrysowanie.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnrysowanie.Image = Global.ScreenShot.My.Resources.Resources.screenbtn1
        Me.btnrysowanie.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnrysowanie.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnrysowanie.Margin = New System.Windows.Forms.Padding(0, 1, 2, 2)
        Me.btnrysowanie.Name = "btnrysowanie"
        Me.btnrysowanie.Padding = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.btnrysowanie.Size = New System.Drawing.Size(58, 69)
        Me.btnrysowanie.Text = "Rysowanie"
        '
        'btnprostokat
        '
        Me.btnprostokat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnprostokat.Image = Global.ScreenShot.My.Resources.Resources.screenbtn2
        Me.btnprostokat.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnprostokat.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnprostokat.Margin = New System.Windows.Forms.Padding(0, 1, 2, 2)
        Me.btnprostokat.Name = "btnprostokat"
        Me.btnprostokat.Padding = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.btnprostokat.Size = New System.Drawing.Size(58, 69)
        Me.btnprostokat.Text = "Prostokąt"
        '
        'btnokrag
        '
        Me.btnokrag.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnokrag.Image = Global.ScreenShot.My.Resources.Resources.screenbtn3
        Me.btnokrag.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnokrag.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnokrag.Margin = New System.Windows.Forms.Padding(0, 1, 2, 2)
        Me.btnokrag.Name = "btnokrag"
        Me.btnokrag.Padding = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.btnokrag.Size = New System.Drawing.Size(58, 69)
        Me.btnokrag.Text = "Okrąg/Koło"
        '
        'btnfont
        '
        Me.btnfont.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnfont.Image = Global.ScreenShot.My.Resources.Resources.icoapk
        Me.btnfont.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnfont.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnfont.Margin = New System.Windows.Forms.Padding(0, 1, 2, 2)
        Me.btnfont.Name = "btnfont"
        Me.btnfont.Padding = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.btnfont.Size = New System.Drawing.Size(72, 69)
        Me.btnfont.Text = "Tekst"
        '
        'btnback
        '
        Me.btnback.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnback.Enabled = False
        Me.btnback.Image = Global.ScreenShot.My.Resources.Resources.screenbtn5
        Me.btnback.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnback.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnback.Margin = New System.Windows.Forms.Padding(0, 1, 2, 2)
        Me.btnback.Name = "btnback"
        Me.btnback.Padding = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.btnback.Size = New System.Drawing.Size(58, 69)
        Me.btnback.Text = "Cofnij zmianę"
        '
        'btnreset
        '
        Me.btnreset.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnreset.Enabled = False
        Me.btnreset.Image = Global.ScreenShot.My.Resources.Resources.screenbtn5
        Me.btnreset.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnreset.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnreset.Margin = New System.Windows.Forms.Padding(0, 1, 2, 2)
        Me.btnreset.Name = "btnreset"
        Me.btnreset.Padding = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.btnreset.Size = New System.Drawing.Size(58, 69)
        Me.btnreset.Text = "Cofnij wszystkie zmiany"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 72)
        '
        'btncp
        '
        Me.btncp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btncp.Image = Global.ScreenShot.My.Resources.Resources.screenbtn6
        Me.btncp.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btncp.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btncp.Margin = New System.Windows.Forms.Padding(0, 1, 2, 2)
        Me.btncp.Name = "btncp"
        Me.btncp.Padding = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.btncp.Size = New System.Drawing.Size(58, 69)
        Me.btncp.Text = "Do schowka"
        '
        'btnsave
        '
        Me.btnsave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnsave.Image = Global.ScreenShot.My.Resources.Resources.screenbtn7
        Me.btnsave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnsave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnsave.Margin = New System.Windows.Forms.Padding(0, 1, 2, 2)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Padding = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.btnsave.Size = New System.Drawing.Size(58, 69)
        Me.btnsave.Text = "Do pliku"
        '
        'btncpsave
        '
        Me.btncpsave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btncpsave.Image = Global.ScreenShot.My.Resources.Resources.screenbtn8
        Me.btncpsave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btncpsave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btncpsave.Margin = New System.Windows.Forms.Padding(0, 1, 2, 2)
        Me.btncpsave.Name = "btncpsave"
        Me.btncpsave.Padding = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.btncpsave.Size = New System.Drawing.Size(58, 69)
        Me.btncpsave.Text = "Do pliku i schowka"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 72)
        '
        'btnresetview
        '
        Me.btnresetview.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnresetview.Image = Global.ScreenShot.My.Resources.Resources.icoapk
        Me.btnresetview.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnresetview.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnresetview.Margin = New System.Windows.Forms.Padding(0, 1, 2, 2)
        Me.btnresetview.Name = "btnresetview"
        Me.btnresetview.Padding = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.btnresetview.Size = New System.Drawing.Size(72, 69)
        Me.btnresetview.Text = "Resetuj widok"
        '
        'btncut
        '
        Me.btncut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btncut.Image = Global.ScreenShot.My.Resources.Resources.screenbtn4
        Me.btncut.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btncut.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btncut.Margin = New System.Windows.Forms.Padding(0, 1, 2, 2)
        Me.btncut.Name = "btncut"
        Me.btncut.Padding = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.btncut.Size = New System.Drawing.Size(58, 69)
        Me.btncut.Text = "Powtórz wycinanie"
        '
        'btncancel
        '
        Me.btncancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btncancel.Image = Global.ScreenShot.My.Resources.Resources.screenbtn9
        Me.btncancel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btncancel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btncancel.Margin = New System.Windows.Forms.Padding(0, 1, 2, 2)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Padding = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.btncancel.Size = New System.Drawing.Size(58, 69)
        Me.btncancel.Text = "Anuluj"
        '
        'ts2
        '
        Me.ts2.BackColor = System.Drawing.Color.LightGray
        Me.ts2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ts2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.k1, Me.k2, Me.k3, Me.k4, Me.k5, Me.k6, Me.k7, Me.k8, Me.btnwypel, Me.btn1do1, Me.ToolStripSeparator1, Me.lblgrubosc, Me.lstgr, Me.sepfont, Me.lstfont, Me.lststyle, Me.txtbox})
        Me.ts2.Location = New System.Drawing.Point(0, 76)
        Me.ts2.Name = "ts2"
        Me.ts2.Padding = New System.Windows.Forms.Padding(5, 2, 5, 2)
        Me.ts2.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ts2.Size = New System.Drawing.Size(1034, 31)
        Me.ts2.TabIndex = 0
        Me.ts2.Text = "ToolStrip2"
        '
        'k1
        '
        Me.k1.Checked = True
        Me.k1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.k1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.k1.Image = CType(resources.GetObject("k1.Image"), System.Drawing.Image)
        Me.k1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.k1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.k1.Name = "k1"
        Me.k1.Padding = New System.Windows.Forms.Padding(2)
        Me.k1.Size = New System.Drawing.Size(24, 24)
        Me.k1.Text = "kolor"
        '
        'k2
        '
        Me.k2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.k2.Image = CType(resources.GetObject("k2.Image"), System.Drawing.Image)
        Me.k2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.k2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.k2.Name = "k2"
        Me.k2.Padding = New System.Windows.Forms.Padding(2)
        Me.k2.Size = New System.Drawing.Size(24, 24)
        Me.k2.Text = "kolor"
        '
        'k3
        '
        Me.k3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.k3.Image = CType(resources.GetObject("k3.Image"), System.Drawing.Image)
        Me.k3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.k3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.k3.Name = "k3"
        Me.k3.Padding = New System.Windows.Forms.Padding(2)
        Me.k3.Size = New System.Drawing.Size(24, 24)
        Me.k3.Text = "kolor"
        '
        'k4
        '
        Me.k4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.k4.Image = CType(resources.GetObject("k4.Image"), System.Drawing.Image)
        Me.k4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.k4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.k4.Name = "k4"
        Me.k4.Padding = New System.Windows.Forms.Padding(2)
        Me.k4.Size = New System.Drawing.Size(24, 24)
        Me.k4.Text = "kolor"
        '
        'k5
        '
        Me.k5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.k5.Image = CType(resources.GetObject("k5.Image"), System.Drawing.Image)
        Me.k5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.k5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.k5.Name = "k5"
        Me.k5.Padding = New System.Windows.Forms.Padding(2)
        Me.k5.Size = New System.Drawing.Size(24, 24)
        Me.k5.Text = "kolor"
        '
        'k6
        '
        Me.k6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.k6.Image = CType(resources.GetObject("k6.Image"), System.Drawing.Image)
        Me.k6.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.k6.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.k6.Name = "k6"
        Me.k6.Padding = New System.Windows.Forms.Padding(2)
        Me.k6.Size = New System.Drawing.Size(24, 24)
        Me.k6.Text = "kolor"
        '
        'k7
        '
        Me.k7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.k7.Image = CType(resources.GetObject("k7.Image"), System.Drawing.Image)
        Me.k7.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.k7.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.k7.Name = "k7"
        Me.k7.Padding = New System.Windows.Forms.Padding(2)
        Me.k7.Size = New System.Drawing.Size(24, 24)
        Me.k7.Text = "kolor"
        '
        'k8
        '
        Me.k8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.k8.Image = CType(resources.GetObject("k8.Image"), System.Drawing.Image)
        Me.k8.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.k8.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.k8.Name = "k8"
        Me.k8.Padding = New System.Windows.Forms.Padding(2)
        Me.k8.Size = New System.Drawing.Size(24, 24)
        Me.k8.Text = "kolor"
        '
        'btnwypel
        '
        Me.btnwypel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnwypel.Image = CType(resources.GetObject("btnwypel.Image"), System.Drawing.Image)
        Me.btnwypel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnwypel.Name = "btnwypel"
        Me.btnwypel.Size = New System.Drawing.Size(74, 24)
        Me.btnwypel.Text = "Wypełniony"
        '
        'btn1do1
        '
        Me.btn1do1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btn1do1.Image = CType(resources.GetObject("btn1do1.Image"), System.Drawing.Image)
        Me.btn1do1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn1do1.Name = "btn1do1"
        Me.btn1do1.Size = New System.Drawing.Size(26, 24)
        Me.btn1do1.Text = "1:1"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'lblgrubosc
        '
        Me.lblgrubosc.Name = "lblgrubosc"
        Me.lblgrubosc.Size = New System.Drawing.Size(76, 24)
        Me.lblgrubosc.Text = "Grubość linii:"
        '
        'lstgr
        '
        Me.lstgr.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lstgr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.lstgr.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16"})
        Me.lstgr.Name = "lstgr"
        Me.lstgr.Size = New System.Drawing.Size(75, 27)
        '
        'sepfont
        '
        Me.sepfont.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.sepfont.Name = "sepfont"
        Me.sepfont.Size = New System.Drawing.Size(6, 27)
        Me.sepfont.Visible = False
        '
        'lstfont
        '
        Me.lstfont.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lstfont.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.lstfont.Margin = New System.Windows.Forms.Padding(1, 0, 5, 0)
        Me.lstfont.Name = "lstfont"
        Me.lstfont.Size = New System.Drawing.Size(130, 27)
        Me.lstfont.Visible = False
        '
        'lststyle
        '
        Me.lststyle.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lststyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.lststyle.Items.AddRange(New Object() {"Normalny", "Kursywa", "Pogrubiony", "Podkreślony", "Przekreślony"})
        Me.lststyle.Margin = New System.Windows.Forms.Padding(1, 0, 5, 0)
        Me.lststyle.Name = "lststyle"
        Me.lststyle.Size = New System.Drawing.Size(100, 27)
        Me.lststyle.Visible = False
        '
        'txtbox
        '
        Me.txtbox.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtbox.MaxLength = 40
        Me.txtbox.Name = "txtbox"
        Me.txtbox.Size = New System.Drawing.Size(200, 27)
        Me.txtbox.Visible = False
        '
        'ekran
        '
        Me.ekran.BackColor = System.Drawing.Color.Gray
        Me.ekran.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ekran.Location = New System.Drawing.Point(0, 107)
        Me.ekran.Name = "ekran"
        Me.ekran.Size = New System.Drawing.Size(1034, 355)
        Me.ekran.TabIndex = 2
        Me.ekran.TabStop = False
        '
        'akt
        '
        Me.akt.Enabled = True
        Me.akt.Interval = 30
        '
        'savedialog
        '
        Me.savedialog.Filter = "Plik PNG (*.png)|*.png|Plik JPG (*.jpg)|*.jpg|Plik BMP (*.bmp)|*.bmp"
        Me.savedialog.FilterIndex = 0
        '
        'screenresult
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1034, 462)
        Me.Controls.Add(Me.ekran)
        Me.Controls.Add(Me.ts2)
        Me.Controls.Add(Me.ts1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(1050, 500)
        Me.Name = "screenresult"
        Me.Text = "ScreenShot"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ts1.ResumeLayout(False)
        Me.ts1.PerformLayout()
        Me.ts2.ResumeLayout(False)
        Me.ts2.PerformLayout()
        CType(Me.ekran, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ts1 As ToolStrip
    Friend WithEvents btnrysowanie As ToolStripButton
    Friend WithEvents btnprostokat As ToolStripButton
    Friend WithEvents btnokrag As ToolStripButton
    Friend WithEvents btnback As ToolStripButton
    Friend WithEvents btnfont As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents btncp As ToolStripButton
    Friend WithEvents btnsave As ToolStripButton
    Friend WithEvents btncpsave As ToolStripButton
    Friend WithEvents btncut As ToolStripButton
    Friend WithEvents btncancel As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ts2 As ToolStrip
    Friend WithEvents k1 As ToolStripButton
    Friend WithEvents k2 As ToolStripButton
    Friend WithEvents k3 As ToolStripButton
    Friend WithEvents k4 As ToolStripButton
    Friend WithEvents k5 As ToolStripButton
    Friend WithEvents k6 As ToolStripButton
    Friend WithEvents k7 As ToolStripButton
    Friend WithEvents k8 As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents lblgrubosc As ToolStripLabel
    Friend WithEvents lstgr As ToolStripComboBox
    Friend WithEvents sepfont As ToolStripSeparator
    Friend WithEvents lststyle As ToolStripComboBox
    Friend WithEvents txtbox As ToolStripTextBox
    Friend WithEvents lstfont As ToolStripComboBox
    Friend WithEvents btnwypel As ToolStripButton
    Friend WithEvents ekran As PictureBox
    Friend WithEvents btnreset As ToolStripButton
    Friend WithEvents akt As Timer
    Friend WithEvents btnresetview As ToolStripButton
    Friend WithEvents btn1do1 As ToolStripButton
    Friend WithEvents savedialog As SaveFileDialog
End Class
