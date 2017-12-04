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
        Me.hidetmr = New System.Windows.Forms.Timer(Me.components)
        Me.notifyicon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.akt = New System.Windows.Forms.Timer(Me.components)
        Me.ekran = New System.Windows.Forms.PictureBox()
        CType(Me.ekran, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'hidetmr
        '
        Me.hidetmr.Enabled = True
        Me.hidetmr.Interval = 1
        '
        'notifyicon
        '
        Me.notifyicon.Icon = CType(resources.GetObject("notifyicon.Icon"), System.Drawing.Icon)
        Me.notifyicon.Text = "ScreenShot"
        Me.notifyicon.Visible = True
        '
        'akt
        '
        Me.akt.Enabled = True
        Me.akt.Interval = 30
        '
        'ekran
        '
        Me.ekran.Cursor = System.Windows.Forms.Cursors.Cross
        Me.ekran.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ekran.Location = New System.Drawing.Point(0, 0)
        Me.ekran.Name = "ekran"
        Me.ekran.Size = New System.Drawing.Size(50, 50)
        Me.ekran.TabIndex = 0
        Me.ekran.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(50, 50)
        Me.Controls.Add(Me.ekran)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(-80, -80)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "ScreenShot"
        Me.TopMost = True
        CType(Me.ekran, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents hidetmr As Timer
    Friend WithEvents notifyicon As NotifyIcon
    Friend WithEvents ekran As PictureBox
    Friend WithEvents akt As Timer
End Class
