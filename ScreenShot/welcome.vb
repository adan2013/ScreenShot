Public Class welcome

    Private Sub btnok_Click(sender As Object, e As EventArgs) Handles btnok.Click
        DialogResult = DialogResult.OK
    End Sub

    Private Sub btnpdf_Click(sender As Object, e As EventArgs) Handles btnpdf.Click
        Try
            Process.Start(Application.StartupPath & "\instrukcja.pdf")
        Catch ex As Exception
            MsgBox("Wystąpił problem z otwarciem instrukcji PDF!" & vbNewLine & "Plik być może został usunięty z komputera", MsgBoxStyle.Exclamation, "ScreenShot")
        End Try
    End Sub
End Class