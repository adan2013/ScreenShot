Imports System.Runtime.Serialization.Formatters.Binary
Public Class Form1

    Public Const version As String = "v1.0"

    Dim WithEvents kb As KeyboardHook = New KeyboardHook()
    Public KBctrl As Boolean = False
    Public KBalt As Boolean = False
    Public KBshift As Boolean = False
    Public dane As MAGAZYN = New MAGAZYN()

    Public colorpickermode As Boolean = False
    Public savedcolor As Color
    Public printscreen As Bitmap
    Public img As Bitmap
    Dim gfx As Graphics
    Dim forcerefresh As Boolean = False
    Dim dragmode As Boolean = False
    Public confirmedcords As Rectangle = New Rectangle(0, 0, 0, 0)
    Dim cutcords1 As Point
    Dim cutcords2 As Point

    Dim sfcenter As StringFormat = New StringFormat()
    Dim sbinfo As SolidBrush = New SolidBrush(Color.FromArgb(180, 180, 180, 180))
    Dim fontinfo As Font = New Font("Segoe UI", 14)
    Dim fontview As Font = New Font("Segoe UI", 9)
    Dim cordsinfo As Rectangle
    Dim cordsview As Rectangle

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If IO.File.Exists(Application.StartupPath & "\settings") Then
            dane = deserializuj(Application.StartupPath & "\settings")
        End If
        sfcenter.Alignment = StringAlignment.Center
        sfcenter.LineAlignment = StringAlignment.Center
    End Sub

    Public Sub serializuj(ByRef obiekt As Object, ByVal path As String)
        Try
            If IO.File.Exists(path) Then IO.File.Delete(path)
            Dim fs As IO.FileStream = IO.File.Create(path)
            Dim bf As BinaryFormatter = New BinaryFormatter
            bf.Serialize(fs, obiekt)
            fs.Close()
        Catch ex As Exception
            MsgBox("Wystąpił błąd podczas zapisu danych!", MsgBoxStyle.Critical, "ScreenShot")
        End Try
    End Sub

    Public Function deserializuj(ByVal path As String) As Object
        If IO.File.Exists(path) Then
            Try
                Dim fs As IO.FileStream = IO.File.OpenRead(path)
                Dim bf As BinaryFormatter = New BinaryFormatter
                Dim wynik As Object = bf.Deserialize(fs)
                fs.Close()
                Return wynik
            Catch ex As Exception
                MsgBox("Wystąpił błąd podczas odczytu danych!", MsgBoxStyle.Critical, "ScreenShot")
            End Try
        Else
            MsgBox("Nie znaleziono pliku!", MsgBoxStyle.Critical, "ScreenShot")
        End If
        Return Nothing
    End Function

    Private Sub hide_Tick(sender As Object, e As EventArgs) Handles hidetmr.Tick
        hidetmr.Enabled = False
        Hide()
    End Sub

    Private Sub kb_KeyDown(Key As Keys) Handles kb.KeyDown
        Select Case Key
            Case Keys.LShiftKey, Keys.RShiftKey
                KBshift = True
            Case Keys.LControlKey, Keys.RControlKey
                KBctrl = True
            Case Keys.LMenu, Keys.RMenu
                KBalt = True
        End Select
    End Sub

    Private Sub kb_KeyUp(Key As Keys) Handles kb.KeyUp
        Select Case Key
            Case Keys.LShiftKey, Keys.RShiftKey
                KBshift = False
            Case Keys.LControlKey, Keys.RControlKey
                KBctrl = False
            Case Keys.LMenu, Keys.RMenu
                KBalt = False
            Case Else
                If readkey.Visible Then
                    readkey.odczyt(Key.ToString())
                Else
                    If Not Visible And Not colorresult.Visible And Not screenresult.Visible And Not settingsform.Visible Then
                        If dane.CtrlMOD = KBctrl And dane.AltMOD = KBalt And dane.ShiftMOD = KBshift And dane.key = Key.ToString() Then uruchom(False)
                    End If
                End If
        End Select
    End Sub

    Public Sub uruchom(ByVal renew As Boolean)
        If Not renew Then
            printscreen = New Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height)
            Using g As Graphics = Graphics.FromImage(printscreen)
                g.CopyFromScreen(New Point(0, 0), New Point(0, 0), printscreen.Size)
            End Using
            Size = printscreen.Size
            Location = New Point(0, 0)
            img = New Bitmap(Size.Width, Size.Height)
            gfx = Graphics.FromImage(img)
            colorpickermode = dane.defcolorpicker
        End If
        forcerefresh = True
        ekran.Image = img
        Show()
    End Sub

    Private Sub notifyicon_Click(sender As Object, e As EventArgs) Handles notifyicon.Click
        If Not Visible And Not colorresult.Visible And Not screenresult.Visible Then
            If Not settingsform.Visible Then settingsform.Show()
        Else
            MsgBox("Zamknij wszystkie okna aplikacji przed otwarciem ustawień!", MsgBoxStyle.Information, "ScreenShot")
        End If
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If IO.File.Exists(Application.StartupPath & "\settings") Then
            IO.File.Delete(Application.StartupPath & "\settings")
        End If
        serializuj(dane, Application.StartupPath & "\settings")
    End Sub

    Private Sub ekran_MouseDown(sender As Object, e As MouseEventArgs) Handles ekran.MouseDown
        If e.Button = MouseButtons.Left And Not colorpickermode Then
            cutcords1 = Cursor.Position
            cutcords2 = cutcords1
            confirmedcords = New Rectangle(0, 0, 0, 0)
            dragmode = True
            forcerefresh = True
        End If
    End Sub

    Private Sub ekran_MouseMove(sender As Object, e As MouseEventArgs) Handles ekran.MouseMove
        If dragmode Then
            cutcords2 = Cursor.Position
            confirmedcords = New Rectangle(Math.Min(cutcords1.X, cutcords2.X), Math.Min(cutcords1.Y, cutcords2.Y), 0, 0)
            confirmedcords.Width = Math.Max(cutcords1.X, cutcords2.X) - confirmedcords.X
            confirmedcords.Height = Math.Max(cutcords1.Y, cutcords2.Y) - confirmedcords.Y
        End If
    End Sub

    Private Sub ekran_MouseUp(sender As Object, e As MouseEventArgs) Handles ekran.MouseUp
        If e.Button = MouseButtons.Left And Not colorpickermode Then
            dragmode = False
            If confirmedcords.Width < 10 Or confirmedcords.Height < 10 Then
                confirmedcords = New Rectangle(0, 0, 0, 0)
                forcerefresh = True
            Else
                zakonczzrzut(False)
                screenresult.Show()
            End If
        End If
        If e.Button = MouseButtons.Left And colorpickermode Then
            zakonczzrzut(False)
            colorresult.Show()
        End If
        If e.Button = MouseButtons.Right And Not dragmode Then
            colorpickermode = Not colorpickermode
            forcerefresh = True
        End If
    End Sub

    Private Sub akt_Tick(sender As Object, e As EventArgs) Handles akt.Tick
        Static ostpoz As Point = Cursor.Position
        If Not ostpoz.Equals(Cursor.Position) Or forcerefresh Then
            ostpoz = Cursor.Position
            forcerefresh = False
            If printscreen IsNot Nothing And img IsNot Nothing And Visible Then
                gfx.Clear(Color.Black)
                gfx.DrawImage(printscreen, New Rectangle(0, 0, printscreen.Size.Width, printscreen.Size.Height))

                If Not colorpickermode Then gfx.FillRectangle(New SolidBrush(Color.FromArgb(180, 60, 60, 60)), New Rectangle(0, 0, img.Size.Width, img.Size.Height))

                If dragmode Then
                    gfx.DrawImage(printscreen, confirmedcords, confirmedcords, GraphicsUnit.Pixel)
                    gfx.DrawRectangle(New Pen(Brushes.Blue, 4), confirmedcords)
                    cordsview = calculateviewcords(ostpoz, 6, 6, 100, 20)
                    gfx.FillRectangle(sbinfo, cordsview)
                    gfx.DrawString("w:" & confirmedcords.Width & " h:" & confirmedcords.Height, fontview, Brushes.White, cordsview, sfcenter)
                Else
                    If ostpoz.Y < Screen.PrimaryScreen.Bounds.Height - 150 Then
                        cordsinfo = New Rectangle(Screen.PrimaryScreen.Bounds.Width / 2 - 300, Screen.PrimaryScreen.Bounds.Height - 100, 600, 50)
                    Else
                        cordsinfo = New Rectangle(Screen.PrimaryScreen.Bounds.Width / 2 - 300, 50, 600, 50)
                    End If
                    gfx.FillRectangle(sbinfo, cordsinfo)
                    gfx.DrawString(IIf(colorpickermode, "Wybierz kolor do spróbkowania", "Zaznacz obszar do wykonania zrzutu ekranu") & vbNewLine & IIf(colorpickermode, "PPM - tryb przycinania zrzutu | Esc - anulowanie próbkowania", "PPM - tryb próbnika kolorów | Esc - anulowanie zrzutu"), fontinfo, Brushes.White, cordsinfo, sfcenter)

                    If colorpickermode Then
                        savedcolor = printscreen.GetPixel(ostpoz.X, ostpoz.Y)
                        cordsview = calculateviewcords(ostpoz, 6, 6, 40, 40)
                        gfx.FillRectangle(New SolidBrush(savedcolor), cordsview)
                        gfx.DrawRectangle(New Pen(Brushes.Black, 2), cordsview)
                    Else
                        cordsview = calculateviewcords(ostpoz, 6, 6, 100, 20)
                        gfx.FillRectangle(sbinfo, cordsview)
                        gfx.DrawString("x:" & ostpoz.X & " y:" & ostpoz.Y, fontview, Brushes.White, cordsview, sfcenter)
                    End If
                End If

                ekran.Image = img
            End If
        End If
    End Sub

    Private Function calculateviewcords(ByVal cursorpoint As Point, ByVal offsetx As Integer, ByVal offsety As Integer, ByVal sizew As Integer, ByVal sizeh As Integer) As Rectangle
        Dim gw As Integer = Screen.PrimaryScreen.Bounds.Width - 150
        Dim gh As Integer = Screen.PrimaryScreen.Bounds.Height - 60
        If gw > cursorpoint.X And gh > cursorpoint.Y Then Return New Rectangle(cursorpoint.X + offsetx, cursorpoint.Y + offsety, sizew, sizeh) 'normal
        If gw < cursorpoint.X And gh < cursorpoint.Y Then Return New Rectangle(cursorpoint.X - offsetx - sizew, cursorpoint.Y - offsety - sizeh, sizew, sizeh) 'double mirror
        If gw < cursorpoint.X And gh > cursorpoint.Y Then Return New Rectangle(cursorpoint.X - offsetx - sizew, cursorpoint.Y + offsety, sizew, sizeh) 'width mirror
        If gw > cursorpoint.X And gh < cursorpoint.Y Then Return New Rectangle(cursorpoint.X + offsetx, cursorpoint.Y - offsety - sizeh, sizew, sizeh) 'height mirror
        Return New Rectangle(cursorpoint.X + offsetx, cursorpoint.Y + offsety, sizew, sizeh) 'normal
    End Function

    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        Select Case e.KeyCode
            Case Keys.Escape
                zakonczzrzut(True)
        End Select
    End Sub

    Public Sub zakonczzrzut(ByVal clearimg As Boolean)
        Hide()
        If clearimg Then
            printscreen.Dispose()
            img.Dispose()
        End If
    End Sub
End Class
