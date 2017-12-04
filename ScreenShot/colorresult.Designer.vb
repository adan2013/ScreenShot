<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class colorresult
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(colorresult))
        Me.pnlview = New System.Windows.Forms.Panel()
        Me.btnpaleta = New System.Windows.Forms.Button()
        Me.btnponownie = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lbl3 = New System.Windows.Forms.Label()
        Me.btn3 = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.btn2 = New System.Windows.Forms.PictureBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.btn1 = New System.Windows.Forms.PictureBox()
        Me.colordialog = New System.Windows.Forms.ColorDialog()
        Me.Panel2.SuspendLayout()
        CType(Me.btn3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.btn2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.btn1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlview
        '
        Me.pnlview.BackColor = System.Drawing.Color.White
        Me.pnlview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlview.Location = New System.Drawing.Point(12, 12)
        Me.pnlview.Name = "pnlview"
        Me.pnlview.Size = New System.Drawing.Size(60, 60)
        Me.pnlview.TabIndex = 0
        '
        'btnpaleta
        '
        Me.btnpaleta.Location = New System.Drawing.Point(78, 46)
        Me.btnpaleta.Name = "btnpaleta"
        Me.btnpaleta.Size = New System.Drawing.Size(130, 26)
        Me.btnpaleta.TabIndex = 1
        Me.btnpaleta.Text = "Wybierz z palety"
        Me.btnpaleta.UseVisualStyleBackColor = True
        '
        'btnponownie
        '
        Me.btnponownie.Location = New System.Drawing.Point(214, 46)
        Me.btnponownie.Name = "btnponownie"
        Me.btnponownie.Size = New System.Drawing.Size(130, 26)
        Me.btnponownie.TabIndex = 2
        Me.btnponownie.Text = "Próbkuj ponownie"
        Me.btnponownie.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.lbl3)
        Me.Panel2.Controls.Add(Me.btn3)
        Me.Panel2.Location = New System.Drawing.Point(12, 210)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(360, 40)
        Me.Panel2.TabIndex = 3
        '
        'lbl3
        '
        Me.lbl3.AutoSize = True
        Me.lbl3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lbl3.Location = New System.Drawing.Point(3, 3)
        Me.lbl3.Margin = New System.Windows.Forms.Padding(3)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(119, 31)
        Me.lbl3.TabIndex = 4
        Me.lbl3.Text = "#000000"
        '
        'btn3
        '
        Me.btn3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.btn3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn3.Image = Global.ScreenShot.My.Resources.Resources.screenbtn6
        Me.btn3.Location = New System.Drawing.Point(319, -1)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(40, 40)
        Me.btn3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn3.TabIndex = 0
        Me.btn3.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.lbl2)
        Me.Panel3.Controls.Add(Me.btn2)
        Me.Panel3.Location = New System.Drawing.Point(12, 164)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(360, 40)
        Me.Panel3.TabIndex = 5
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lbl2.Location = New System.Drawing.Point(3, 3)
        Me.lbl2.Margin = New System.Windows.Forms.Padding(3)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(119, 31)
        Me.lbl2.TabIndex = 4
        Me.lbl2.Text = "#000000"
        '
        'btn2
        '
        Me.btn2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.btn2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn2.Image = Global.ScreenShot.My.Resources.Resources.screenbtn6
        Me.btn2.Location = New System.Drawing.Point(319, -1)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(40, 40)
        Me.btn2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn2.TabIndex = 0
        Me.btn2.TabStop = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.lbl1)
        Me.Panel4.Controls.Add(Me.btn1)
        Me.Panel4.Location = New System.Drawing.Point(12, 118)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(360, 40)
        Me.Panel4.TabIndex = 6
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lbl1.Location = New System.Drawing.Point(3, 3)
        Me.lbl1.Margin = New System.Windows.Forms.Padding(3)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(119, 31)
        Me.lbl1.TabIndex = 4
        Me.lbl1.Text = "#000000"
        '
        'btn1
        '
        Me.btn1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.btn1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn1.Image = Global.ScreenShot.My.Resources.Resources.screenbtn6
        Me.btn1.Location = New System.Drawing.Point(319, -1)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(40, 40)
        Me.btn1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn1.TabIndex = 0
        Me.btn1.TabStop = False
        '
        'colordialog
        '
        Me.colordialog.FullOpen = True
        Me.colordialog.SolidColorOnly = True
        '
        'colorresult
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 262)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btnponownie)
        Me.Controls.Add(Me.btnpaleta)
        Me.Controls.Add(Me.pnlview)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "colorresult"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ScreenShot"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.btn3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.btn2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.btn1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlview As Panel
    Friend WithEvents btnpaleta As Button
    Friend WithEvents btnponownie As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btn3 As PictureBox
    Friend WithEvents lbl3 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lbl2 As Label
    Friend WithEvents btn2 As PictureBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lbl1 As Label
    Friend WithEvents btn1 As PictureBox
    Friend WithEvents colordialog As ColorDialog
End Class
