Public Class colorresult

    Dim returnmode As Boolean = False
    Dim kolor As Color

    Private Sub colorresult_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If Not returnmode Then
            Form1.printscreen.Dispose()
            Form1.img.Dispose()
        End If
    End Sub

    Private Sub colorresult_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        kolor = Form1.savedcolor
        gen()
    End Sub

    Private Sub btnpaleta_Click(sender As Object, e As EventArgs) Handles btnpaleta.Click, pnlview.Click
        colordialog.Color = kolor
        colordialog.ShowDialog()
        kolor = colordialog.Color
        gen()
    End Sub

    Private Sub btnponownie_Click(sender As Object, e As EventArgs) Handles btnponownie.Click
        returnmode = True
        Form1.uruchom(True)
        Close()
    End Sub

    Private Function tohex(ByVal nr As Byte) As String
        Dim s As String = Hex(nr).ToLower()
        If s.Length = 1 Then s = "0" & s
        Return s
    End Function

    Private Sub gen()
        pnlview.BackColor = kolor
        lbl1.Text = "#" & tohex(kolor.R) & tohex(kolor.G) & tohex(kolor.B)
        lbl2.Text = "(" & kolor.R & ", " & kolor.G & ", " & kolor.B & ")"
        lbl3.Text = "rgb(" & kolor.R & ", " & kolor.G & ", " & kolor.B & ")"
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        Clipboard.SetText(lbl1.Text)
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        Clipboard.SetText(lbl2.Text)
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        Clipboard.SetText(lbl3.Text)
    End Sub
End Class