Public Class screenresult

    Dim paleta() As Color = {Color.FromArgb(0, 0, 0), Color.FromArgb(237, 28, 36), Color.FromArgb(255, 127, 39), Color.FromArgb(253, 240, 0), Color.FromArgb(34, 177, 76), Color.FromArgb(0, 162, 232), Color.FromArgb(244, 0, 255), Color.FromArgb(255, 255, 255)}
    Dim refpaleta() As ToolStripButton
    Dim selcolor As Byte = 0
    Dim selnarz As Byte = 0
    Dim grlinii As Byte = 3
    Dim rozczcionki As Byte = 7

    Dim init As Boolean = False
    Dim returnmode As Boolean = False
    Dim forcerefresh As Boolean = False

    Dim returnimg As Bitmap = Nothing
    Dim currentimg As Bitmap
    Dim tempimg As Bitmap

    Dim offsetview As Point
    Dim gfx As Graphics
    Dim cgfx As Graphics
    Dim MOVEmode As Boolean = False
    Dim DRAGmode As Boolean = False
    Dim MOVEcords As Point
    Dim DRAGcords1 As Point
    Dim DRAGcords2 As Point

    Dim dashanimate As Byte = 0
    Dim FONTcords As Point = New Point(0, 0)
    Dim sfcenter As StringFormat = New StringFormat()

    Private Sub screenresult_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        savedialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)
        sfcenter.Alignment = StringAlignment.Center
        sfcenter.LineAlignment = StringAlignment.Center
        refpaleta = {k1, k2, k3, k4, k5, k6, k7, k8}
        For i As Byte = 0 To 7 Step 1
            Dim pimg As Bitmap = New Bitmap(20, 20)
            Using g As Graphics = Graphics.FromImage(pimg)
                g.Clear(paleta(i))
            End Using
            refpaleta(i).Image = pimg
            AddHandler refpaleta(i).Click, AddressOf kolorclick
        Next
        Dim ff As Text.InstalledFontCollection = New Text.InstalledFontCollection
        Dim ind As Integer = 0
        For Each i In ff.Families
            lstfont.Items.Add(i.Name)
            If i.Name = "Segoe UI" Then ind = lstfont.Items.Count - 1
        Next
        lstfont.SelectedIndex = ind
        Select Case Form1.dane.deftool
            Case 0
                zmiennarzedzie(0, btnrysowanie)
            Case 1
                zmiennarzedzie(1, btnprostokat)
            Case 2
                zmiennarzedzie(2, btnokrag)
            Case 3
                zmiennarzedzie(3, btnfont)
        End Select
        Select Case Form1.dane.defcolor
            Case 0
                kolorclick(k1, New EventArgs())
            Case 1
                kolorclick(k2, New EventArgs())
            Case 2
                kolorclick(k3, New EventArgs())
            Case 3
                kolorclick(k4, New EventArgs())
            Case 4
                kolorclick(k5, New EventArgs())
            Case 5
                kolorclick(k6, New EventArgs())
            Case 6
                kolorclick(k7, New EventArgs())
            Case 7
                kolorclick(k8, New EventArgs())
        End Select
        'load printscreen
        loadprintscreen()
        tempimg = New Bitmap(ekran.Size.Width, ekran.Size.Height)
        gfx = Graphics.FromImage(tempimg)
        forcerefresh = True
    End Sub

    Private Sub loadprintscreen()
        If Form1.confirmedcords.Equals(New Rectangle(0, 0, 0, 0)) Then
            currentimg = New Bitmap(Form1.printscreen)
        Else
            currentimg = New Bitmap(Form1.confirmedcords.Width, Form1.confirmedcords.Height)
            Using g As Graphics = Graphics.FromImage(currentimg)
                g.DrawImage(Form1.printscreen, New Rectangle(0, 0, currentimg.Width, currentimg.Height), Form1.confirmedcords, GraphicsUnit.Pixel)
            End Using
        End If
        cgfx = Graphics.FromImage(currentimg)
        offsetview = New Point((ekran.Size.Width - currentimg.Size.Width) / 2, (ekran.Size.Height - currentimg.Size.Height) / 2)
    End Sub

    Private Sub undolastaction()
        If returnimg IsNot Nothing Then
            Using g As Graphics = Graphics.FromImage(currentimg)
                g.DrawImage(returnimg, New Rectangle(0, 0, currentimg.Width, currentimg.Height))
            End Using
            cgfx = Graphics.FromImage(currentimg)
            returnimg.Dispose()
            btnback.Enabled = False
        End If
    End Sub

    Private Sub savereturn()
        returnimg = New Bitmap(currentimg)
        btnback.Enabled = True
        btnreset.Enabled = True
    End Sub

    Private Sub kolorclick(sender As Object, e As EventArgs)
        For Each i As ToolStripButton In refpaleta
            i.Checked = False
        Next
        sender.Checked = True
        selcolor = sender.Name.Substring(1, 1) - 1
        forcerefresh = True
    End Sub

    Private Sub btnwypel_Click(sender As Object, e As EventArgs) Handles btnwypel.Click
        sender.Checked = Not sender.Checked
    End Sub

    Private Sub btn1do1_Click(sender As Object, e As EventArgs) Handles btn1do1.Click
        sender.Checked = Not sender.Checked
    End Sub

    Private Sub btnrysowanie_Click(sender As Object, e As EventArgs) Handles btnrysowanie.Click
        zmiennarzedzie(0, sender)
    End Sub

    Private Sub btnprostokat_Click(sender As Object, e As EventArgs) Handles btnprostokat.Click
        zmiennarzedzie(1, sender)
    End Sub

    Private Sub btnokrag_Click(sender As Object, e As EventArgs) Handles btnokrag.Click
        zmiennarzedzie(2, sender)
    End Sub

    Private Sub btnfont_Click(sender As Object, e As EventArgs) Handles btnfont.Click
        zmiennarzedzie(3, sender)
    End Sub

    Private Sub zmiennarzedzie(ByVal nr As Byte, ByVal ob As ToolStripButton)
        savetext()
        init = True
        btnrysowanie.Checked = False
        btnprostokat.Checked = False
        btnokrag.Checked = False
        btnfont.Checked = False
        ob.Checked = True
        selnarz = nr
        If selnarz = 3 Then
            lblgrubosc.Text = "Rozmiar czcionki:"
            lstgr.Items.Clear()
            lstgr.Items.AddRange({8, 10, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72})
            lstgr.SelectedIndex = rozczcionki
            sepfont.Visible = True
            lstfont.Visible = True
            lststyle.Visible = True
            lststyle.SelectedIndex = 0
            txtbox.Visible = True
            txtbox.Text = ""
            txtbox.Focus()
            FONTcords = New Point((ekran.Size.Width - currentimg.Size.Width) / 2 + currentimg.Size.Width / 2, (ekran.Size.Height - currentimg.Size.Height) / 2 + currentimg.Size.Height / 2)
        Else
            lblgrubosc.Text = "Grubość linii:"
            lstgr.Items.Clear()
            lstgr.Items.AddRange({1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16})
            lstgr.SelectedIndex = grlinii
            sepfont.Visible = False
            lstfont.Visible = False
            lststyle.Visible = False
            txtbox.Visible = False
            txtbox.Text = ""
        End If
        init = False
    End Sub

    Private Sub lstgr_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstgr.SelectedIndexChanged
        If init Then Exit Sub
        If selnarz = 3 Then rozczcionki = lstgr.SelectedIndex Else grlinii = lstgr.SelectedIndex
    End Sub

    Private Sub screenresult_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If Not returnmode Then
            Form1.printscreen.Dispose()
            Form1.img.Dispose()
        End If
        If returnimg IsNot Nothing Then returnimg.Dispose()
        currentimg.Dispose()
        tempimg.Dispose()
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Close()
    End Sub

    Private Sub btncut_Click(sender As Object, e As EventArgs) Handles btncut.Click
        returnmode = True
        Form1.uruchom(True)
        Close()
    End Sub

    Private Function getrectangle(ByVal p1 As Point, p2 As Point, ByVal offset As Point) As Rectangle
        Dim w As Rectangle = New Rectangle(Math.Min(p1.X, p2.X), Math.Min(p1.Y, p2.Y), 0, 0)
        w.Width = Math.Max(p1.X, p2.X) - w.X
        w.Height = Math.Max(p1.Y, p2.Y) - w.Y
        If btn1do1.Checked Then
            w.Width = Math.Min(w.Width, w.Height)
            w.Height = w.Width
            If p2.X < p1.X Then w.X += p1.X - p2.X - w.Width
            If p2.Y < p1.Y Then w.Y += p1.Y - p2.Y - w.Height
        End If
        w.X += offset.X
        w.Y += offset.Y
        Return w
    End Function

    Private Sub akt_Tick(sender As Object, e As EventArgs) Handles akt.Tick
        Static ostpoz As Point = Cursor.Position
        If Not ostpoz.Equals(Cursor.Position) Or forcerefresh Or Not txtbox.Text = "" Then
            ostpoz = Cursor.Position
            forcerefresh = False
            If currentimg IsNot Nothing And tempimg IsNot Nothing Then
                gfx.Clear(Color.Gray)

                gfx.DrawImage(currentimg, New Rectangle(offsetview.X, offsetview.Y, currentimg.Width, currentimg.Height))

                If DRAGmode Then
                    Select Case selnarz
                        Case 1
                            If btnwypel.Checked Then
                                gfx.FillRectangle(New SolidBrush(paleta(selcolor)), getrectangle(DRAGcords1, DRAGcords2, New Point(0, 0)))
                            Else
                                gfx.DrawRectangle(New Pen(paleta(selcolor), lstgr.Text), getrectangle(DRAGcords1, DRAGcords2, New Point(0, 0)))
                            End If
                        Case 2
                            If btnwypel.Checked Then
                                gfx.FillEllipse(New SolidBrush(paleta(selcolor)), getrectangle(DRAGcords1, DRAGcords2, New Point(0, 0)))
                            Else
                                gfx.DrawEllipse(New Pen(paleta(selcolor), lstgr.Text), getrectangle(DRAGcords1, DRAGcords2, New Point(0, 0)))
                            End If
                    End Select
                End If

                If Not txtbox.Text = "" Then
                    Dim f As Font
                    Try
                        f = New Font(lstfont.Text, CInt(lstgr.Text), getfontstyle())
                    Catch ex As Exception
                        f = New Font("Segoe UI", CInt(lstgr.Text))
                    End Try
                    Dim r As PointF = gfx.MeasureString(txtbox.Text, f)
                    Dim rect As Rectangle = New Rectangle(FONTcords.X, FONTcords.Y, r.X + 50, r.Y + 20)
                    rect.X -= rect.Width / 2
                    rect.Y -= rect.Height / 2
                    Dim fontpen As Pen = New Pen(paleta(selcolor), 3)
                    If dashanimate > 15 Then fontpen.DashPattern = {3, 1} Else fontpen.DashPattern = {1, 1, 2}
                    gfx.DrawRectangle(fontpen, rect)
                    gfx.DrawString(txtbox.Text, f, New SolidBrush(paleta(selcolor)), rect, sfcenter)
                    dashanimate += 1
                    If dashanimate > 30 Then dashanimate = 0
                End If

                ekran.Image = tempimg
            End If
        End If
    End Sub

    Private Function getfontstyle() As FontStyle
        If lststyle.SelectedIndex = 0 Then Return FontStyle.Regular
        If lststyle.SelectedIndex = 1 Then Return FontStyle.Italic
        If lststyle.SelectedIndex = 2 Then Return FontStyle.Bold
        If lststyle.SelectedIndex = 3 Then Return FontStyle.Underline
        If lststyle.SelectedIndex = 4 Then Return FontStyle.Strikeout
        Return FontStyle.Regular
    End Function

    Private Sub ekran_MouseDown(sender As Object, e As MouseEventArgs) Handles ekran.MouseDown
        If e.Button = MouseButtons.Left And New Rectangle(offsetview.X, offsetview.Y, currentimg.Size.Width, currentimg.Size.Height).Contains(e.X, e.Y) Then
            DRAGmode = True
            Select Case selnarz
                Case 0
                    savereturn()
                    DRAGcords1 = e.Location
                Case 1
                    savereturn()
                    DRAGcords1 = e.Location
                    DRAGcords1 = e.Location
                Case 2
                    savereturn()
                    DRAGcords1 = e.Location
                    DRAGcords1 = e.Location
                Case 3
                    FONTcords = New Point(e.Location.X, e.Location.Y)
                    forcerefresh = True
            End Select
        End If
        If e.Button = MouseButtons.Right Then
            MOVEcords = e.Location
            MOVEmode = True
            ekran.Cursor = Cursors.NoMove2D
        End If
    End Sub

    Private Sub ekran_MouseMove(sender As Object, e As MouseEventArgs) Handles ekran.MouseMove
        If DRAGmode Then
            Select Case selnarz
                Case 0
                    cgfx.DrawLine(New Pen(paleta(selcolor), lstgr.Text), New Point(DRAGcords1.X - offsetview.X, DRAGcords1.Y - offsetview.Y), New Point(e.X - offsetview.X, e.Y - offsetview.Y))
                    cgfx.FillEllipse(New SolidBrush(paleta(selcolor)), New Rectangle(New Point(e.X - offsetview.X - (lstgr.Text / 2), e.Y - offsetview.Y - (lstgr.Text / 2)), New Size(lstgr.Text, lstgr.Text)))
                    DRAGcords1 = e.Location
                Case 1
                    DRAGcords2 = e.Location
                Case 2
                    DRAGcords2 = e.Location
                Case 3
                    FONTcords = New Point(e.Location.X, e.Location.Y)
            End Select
        End If
        If MOVEmode Then
            offsetview.X -= MOVEcords.X - e.X
            offsetview.Y -= MOVEcords.Y - e.Y
            MOVEcords = e.Location
        End If
    End Sub

    Private Sub ekran_MouseUp(sender As Object, e As MouseEventArgs) Handles ekran.MouseUp
        If e.Button = MouseButtons.Left And DRAGmode Then
            DRAGmode = False
            Select Case selnarz
                Case 1
                    If btnwypel.Checked Then
                        cgfx.FillRectangle(New SolidBrush(paleta(selcolor)), getrectangle(DRAGcords1, DRAGcords2, New Point(-offsetview.X, -offsetview.Y)))
                    Else
                        cgfx.DrawRectangle(New Pen(paleta(selcolor), lstgr.Text), getrectangle(DRAGcords1, DRAGcords2, New Point(-offsetview.X, -offsetview.Y)))
                    End If
                Case 2
                    If btnwypel.Checked Then
                        cgfx.FillEllipse(New SolidBrush(paleta(selcolor)), getrectangle(DRAGcords1, DRAGcords2, New Point(-offsetview.X, -offsetview.Y)))
                    Else
                        cgfx.DrawEllipse(New Pen(paleta(selcolor), lstgr.Text), getrectangle(DRAGcords1, DRAGcords2, New Point(-offsetview.X, -offsetview.Y)))
                    End If
                Case 3

            End Select
            forcerefresh = True
        End If
        If e.Button = MouseButtons.Right And MOVEmode Then
            MOVEmode = False
            ekran.Cursor = Cursors.Default
        End If
        If e.Button = MouseButtons.Left And selnarz = 3 And Not New Rectangle(offsetview.X, offsetview.Y, currentimg.Size.Width, currentimg.Size.Height).Contains(e.X, e.Y) Then
            If Not txtbox.Text = "" Then zmiennarzedzie(3, btnfont)
        End If
    End Sub

    Private Sub screenresult_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
        If Not WindowState = FormWindowState.Minimized Then
            tempimg = New Bitmap(ekran.Size.Width, ekran.Size.Height)
            gfx = Graphics.FromImage(tempimg)
        End If
    End Sub

    Private Sub btnresetview_Click(sender As Object, e As EventArgs) Handles btnresetview.Click
        offsetview = New Point((ekran.Size.Width - currentimg.Size.Width) / 2, (ekran.Size.Height - currentimg.Size.Height) / 2)
        forcerefresh = True
    End Sub

    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        undolastaction()
        forcerefresh = True
    End Sub

    Private Sub btnreset_Click(sender As Object, e As EventArgs) Handles btnreset.Click
        loadprintscreen()
        btnback.Enabled = False
        btnreset.Enabled = False
        If returnimg IsNot Nothing Then returnimg.Dispose()
        forcerefresh = True
    End Sub

    Private Sub txtbox_TextChanged(sender As Object, e As EventArgs) Handles txtbox.TextChanged, lstgr.SelectedIndexChanged, lstfont.SelectedIndexChanged, lststyle.SelectedIndexChanged
        forcerefresh = True
    End Sub

    Private Sub savetext()
        If txtbox.Text = "" Then Exit Sub
        savereturn()
        Dim f As Font
        Try
            f = New Font(lstfont.Text, CInt(lstgr.Text), getfontstyle())
        Catch ex As Exception
            f = New Font("Segoe UI", CInt(lstgr.Text))
        End Try
        Dim r As PointF = gfx.MeasureString(txtbox.Text, f)
        Dim rect As Rectangle = New Rectangle(FONTcords.X, FONTcords.Y, r.X + 50, r.Y + 20)
        rect.X -= rect.Width / 2 + offsetview.X
        rect.Y -= rect.Height / 2 + offsetview.Y
        cgfx.DrawString(txtbox.Text, f, New SolidBrush(paleta(selcolor)), rect, sfcenter)
    End Sub

    Private Sub btncp_Click(sender As Object, e As EventArgs) Handles btncp.Click
        save(True, False)
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        save(False, True)
    End Sub

    Private Sub btncpsave_Click(sender As Object, e As EventArgs) Handles btncpsave.Click
        save(True, True)
    End Sub

    Private Sub save(ByVal cb As Boolean, ByVal file As Boolean)
        Dim endprog As Boolean = True
        Dim p As String = ""
        savetext()
        If cb Then Clipboard.SetImage(currentimg)
        If file Then
            If Form1.dane.savemode AndAlso IO.Directory.Exists(Form1.dane.savepath) Then
                p = Form1.dane.savepath & "\" & Now.Day & "-" & Now.Month & "-" & Now.Year & " " & Now.Hour & "-" & Now.Minute & "-" & Now.Second & "." & getroz(Form1.dane.roz)
                Try
                    If IO.File.Exists(p) Then IO.File.Delete(p)
                Catch ex As Exception

                End Try
            End If
            If p = "" Then
                savedialog.FileName = ""
                savedialog.FilterIndex = Form1.dane.roz + 1
                savedialog.ShowDialog()
                p = savedialog.FileName
            End If
            If p = "" Then
                endprog = False
            Else
                currentimg.Save(p, getimgformat(Form1.dane.roz))
            End If
        End If
        If endprog Then
            If file And Form1.dane.opendir Then Process.Start(IO.Path.GetDirectoryName(p))
            Close()
        End If
    End Sub

    Private Function getroz(ByVal id As Byte) As String
        Select Case id
            Case 0
                Return "png"
            Case 1
                Return "jpg"
            Case 2
                Return "bmp"
            Case Else
                Return "png"
        End Select
    End Function

    Private Function getimgformat(ByVal id As Byte) As Imaging.ImageFormat
        Select Case id
            Case 0
                Return Imaging.ImageFormat.Png
            Case 1
                Return Imaging.ImageFormat.Jpeg
            Case 2
                Return Imaging.ImageFormat.Bmp
            Case Else
                Return Imaging.ImageFormat.Png
        End Select
    End Function
End Class