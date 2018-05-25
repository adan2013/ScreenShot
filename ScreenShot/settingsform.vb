Imports System.Threading
Imports IWshRuntimeLibrary
Public Class settingsform

    Dim init As Boolean = True

    Private Sub settingsform_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

    End Sub

    Private Sub settingsform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Form1.dane.key = "" Then
            lblskrot.Text = "brak skrótu"
        Else
            lblskrot.Text = ""
            If Form1.dane.ShiftMOD Then lblskrot.Text = "Shift+"
            If Form1.dane.CtrlMOD Then lblskrot.Text &= "Ctrl+"
            If Form1.dane.AltMOD Then lblskrot.Text &= "Alt+"
            lblskrot.Text &= Form1.dane.key
        End If
        aktautostart()
        If Form1.dane.savemode Then
            radiodofolderu.Checked = True
            btnpath.Enabled = True
            lblpath.Enabled = True
        End If
        If Form1.dane.savepath = "" Then lblpath.Text = "" Else lblpath.Text = New IO.DirectoryInfo(Form1.dane.savepath).Name
        Dim cut As Boolean = False
        Do Until lblpath.Size.Width < 135
            lblpath.Text = lblpath.Text.Substring(0, lblpath.Text.Length - 1)
            cut = True
        Loop
        If cut Then lblpath.Text &= "..."
        listext.SelectedIndex = Form1.dane.roz
        lstdefnarz.SelectedIndex = Form1.dane.deftool
        lstdefcolor.SelectedIndex = Form1.dane.defcolor
        chkboxcolorpicker.Checked = Form1.dane.defcolorpicker
        chkboxopendir.Checked = Form1.dane.opendir
        lblver.Text = "Wersja: " & Form1.version
        init = False
    End Sub

    Private Sub aktautostart()
        If My.Computer.Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True).GetValue(Application.ProductName) IsNot Nothing Then
            'If IO.File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Startup) & "\ScreenShot.lnk") Then
            lblautostart.Text = "Włączony"
            btnautostart.Text = "Wyłącz"
        Else
            lblautostart.Text = "Wyłączony"
            btnautostart.Text = "Włącz"
        End If
    End Sub

    Private Sub btnautostart_Click(sender As Object, e As EventArgs) Handles btnautostart.Click
        'If IO.File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Startup) & "\ScreenShot.lnk") Then
        If My.Computer.Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True).GetValue(Application.ProductName) IsNot Nothing Then
            'usuń autostart
            Try
                My.Computer.Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True).DeleteValue(Application.ProductName)
                'IO.File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.Startup) & "\ScreenShot.lnk")
            Catch ex As Exception
                MsgBox("Błąd usuwania pliku autostartu!", MsgBoxStyle.Critical, "ScreenShot")
            End Try
        Else
            'dodaj autostart
            Try
                My.Computer.Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True).SetValue(Application.ProductName, Application.ExecutablePath)
                'Dim WshShell As New WshShell
                'Dim shortCut As IWshShortcut = CType(WshShell.CreateShortcut(Environment.GetFolderPath(Environment.SpecialFolder.Startup) & "\ScreenShot.lnk"), IWshShortcut)
                'With shortCut
                '    .TargetPath = Application.ExecutablePath
                '    .WorkingDirectory = Application.StartupPath
                '    .IconLocation = Application.ExecutablePath & ", 0"
                '    .Save()
                'End With
            Catch ex As Exception
                MsgBox("Błąd dodawania pliku autostartu!", MsgBoxStyle.Critical, "ScreenShot")
            End Try
        End If
        Thread.Sleep(800)
        aktautostart()
    End Sub

    Private Sub radiopytaj_CheckedChanged(sender As Object, e As EventArgs) Handles radiopytaj.CheckedChanged
        If init Then Exit Sub
        btnpath.Enabled = False
        lblpath.Enabled = False
        Form1.dane.savemode = False
    End Sub

    Private Sub radiodofolderu_CheckedChanged(sender As Object, e As EventArgs) Handles radiodofolderu.CheckedChanged
        If init Then Exit Sub
        btnpath.Enabled = True
        lblpath.Enabled = True
        Form1.dane.savemode = True
    End Sub

    Private Sub btnpath_Click(sender As Object, e As EventArgs) Handles btnpath.Click
        folderdialog.SelectedPath = Form1.dane.savepath
        folderdialog.ShowDialog()
        Form1.dane.savepath = folderdialog.SelectedPath
        If Form1.dane.savepath = "" Then lblpath.Text = "" Else lblpath.Text = New IO.DirectoryInfo(Form1.dane.savepath).Name
        Dim cut As Boolean = False
        Do Until lblpath.Size.Width < 135
            lblpath.Text = lblpath.Text.Substring(0, lblpath.Text.Length - 1)
            cut = True
        Loop
        If cut Then lblpath.Text &= "..."
    End Sub

    Private Sub btnend_Click(sender As Object, e As EventArgs) Handles btnend.Click
        If MsgBox("Zakończyć działanie programu?" & vbNewLine & "Program przestanie działać w tle i nie będzie można go wywołać skrótem klawiszowym", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "ScreenShot") = MsgBoxResult.Yes Then
            Form1.kb.endworking()
            Form1.Close()
        End If
    End Sub

    Private Sub btnskrot_Click(sender As Object, e As EventArgs) Handles btnskrot.Click
        readkey.ShowDialog()
        If readkey.DialogResult = DialogResult.OK Then
            Form1.dane.ShiftMOD = readkey.ShiftMOD
            Form1.dane.CtrlMOD = readkey.CtrlMOD
            Form1.dane.AltMOD = readkey.AltMOD
            Form1.dane.key = readkey.regkey
        End If
        readkey.Close()
        If Form1.dane.key = "" Then
            lblskrot.Text = "brak skrótu"
        Else
            lblskrot.Text = ""
            If Form1.dane.ShiftMOD Then lblskrot.Text = "Shift+"
            If Form1.dane.CtrlMOD Then lblskrot.Text &= "Ctrl+"
            If Form1.dane.AltMOD Then lblskrot.Text &= "Alt+"
            lblskrot.Text &= Form1.dane.key
        End If
        Form1.kb.deletehotkey("capture")
        Dim modif As HOTKEY.KeyModifier
        If Form1.dane.ShiftMOD Then modif += HOTKEY.KeyModifier.Shift
        If Form1.dane.CtrlMOD Then modif += HOTKEY.KeyModifier.Control
        If Form1.dane.AltMOD Then modif += HOTKEY.KeyModifier.Alt
        Try
            If Not Form1.kb.addhotkey("capture", Form1.dane.GetKey(Form1.dane.key), modif) Then
                MsgBox("Wystąpił problem podczas uruchamiania skrótu klawiszowego! Spróbuj go zmienić w ustawieniach...", MsgBoxStyle.Exclamation, "ScreenShot")
            End If
        Catch ex As Exception
            MsgBox("Wystąpił problem podczas uruchamiania skrótu klawiszowego! Spróbuj go zmienić w ustawieniach...", MsgBoxStyle.Exclamation, "ScreenShot")
        End Try
    End Sub

    Private Sub listext_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listext.SelectedIndexChanged
        If init Then Exit Sub
        Form1.dane.roz = listext.SelectedIndex
    End Sub

    Private Sub chkboxopendir_CheckedChanged(sender As Object, e As EventArgs) Handles chkboxopendir.CheckedChanged
        If init Then Exit Sub
        Form1.dane.opendir = chkboxopendir.Checked
    End Sub

    Private Sub lstdefnarz_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstdefnarz.SelectedIndexChanged
        If init Then Exit Sub
        Form1.dane.deftool = lstdefnarz.SelectedIndex
    End Sub

    Private Sub lstdefcolor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstdefcolor.SelectedIndexChanged
        If init Then Exit Sub
        Form1.dane.defcolor = lstdefcolor.SelectedIndex
    End Sub

    Private Sub chkboxcolorpicker_CheckedChanged(sender As Object, e As EventArgs) Handles chkboxcolorpicker.CheckedChanged
        If init Then Exit Sub
        Form1.dane.defcolorpicker = chkboxcolorpicker.Checked
    End Sub

    Private Sub btnpdf_Click(sender As Object, e As EventArgs) Handles btnpdf.Click
        Try
            Process.Start(Application.StartupPath & "\instrukcja.pdf")
        Catch ex As Exception
            MsgBox("Wystąpił problem z otwarciem instrukcji PDF!" & vbNewLine & "Plik być może został usunięty z komputera", MsgBoxStyle.Exclamation, "ScreenShot")
        End Try
    End Sub
End Class