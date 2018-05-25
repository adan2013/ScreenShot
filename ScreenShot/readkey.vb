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

    Public Sub odczyt(ByVal key As Keys)
        If msg Then Exit Sub
        If key = Keys.Escape Then
            DialogResult = DialogResult.Cancel
        Else
            ShiftMOD = My.Computer.Keyboard.ShiftKeyDown
            CtrlMOD = My.Computer.Keyboard.CtrlKeyDown
            AltMOD = My.Computer.Keyboard.AltKeyDown
            regkey = key.ToString()
            Dim s As String = ""
            s &= IIf(My.Computer.Keyboard.CtrlKeyDown, "CTRL + ", "")
            s &= IIf(My.Computer.Keyboard.AltKeyDown, "ALT + ", "")
            s &= IIf(My.Computer.Keyboard.ShiftKeyDown, "SHIFT + ", "")
            s &= key.ToString()
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

    Private Sub readkey_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.ShiftKey, Keys.ControlKey, Keys.Alt, Keys.Menu, Keys.LWin, Keys.RWin, Keys.Capital, Keys.Scroll, Keys.NumLock

            Case Else
                odczyt(e.KeyCode)
        End Select
    End Sub
End Class