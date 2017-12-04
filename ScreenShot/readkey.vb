Public Class readkey

    Dim lbl As Label = New Label()
    Dim msg As Boolean = False

    Public ShiftMOD As Boolean = False
    Public CtrlMOD As Boolean = False
    Public AltMOD As Boolean = False
    Public regkey As String = ""

    Private Sub readkey_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With lbl
            .Location = New Point(0, 80)
            .Size = New Size(Size.Width - 10, 60)
            .TextAlign = ContentAlignment.MiddleCenter
            .Font = New Font("Segoe UI", 16)
            .Text = "Oczekiwanie..."
        End With
        Controls.Add(lbl)
    End Sub

    Public Sub odczyt(ByVal key As String)
        If msg Then Exit Sub
        If key = "Escape" Then
            DialogResult = DialogResult.Cancel
        Else
            ShiftMOD = Form1.KBshift
            CtrlMOD = Form1.KBctrl
            AltMOD = Form1.KBalt
            regkey = key
            Dim s As String = ""
            s &= IIf(Form1.KBctrl, "CTRL + ", "")
            s &= IIf(Form1.KBalt, "ALT + ", "")
            s &= IIf(Form1.KBshift, "SHIFT + ", "")
            s &= key
            msg = True
            lbl.Text = s
            btnnie.Visible = True
            btntak.Visible = True
            msg = False
        End If
    End Sub

    Private Sub btnnie_Click(sender As Object, e As EventArgs) Handles btnnie.Click
        btnnie.Visible = False
        btntak.Visible = False
        lbl.Text = "Oczekiwanie..."
    End Sub

    Private Sub btntak_Click(sender As Object, e As EventArgs) Handles btntak.Click
        DialogResult = DialogResult.OK
    End Sub
End Class