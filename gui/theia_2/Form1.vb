Imports System.IO
Imports System.Net.Sockets
Imports System.Globalization

Public Class home
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer

    Private Sub scanSheet_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        drag = True
        mousex = System.Windows.Forms.Cursor.Position.X - Me.Left
        mousey = System.Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub

    Private Sub scanSheet_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If drag Then
            Me.Top = System.Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = System.Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub scanSheet_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        drag = False
    End Sub

    Private Sub close_btn_Click(sender As Object, e As EventArgs) Handles close_btn.Click
        End
    End Sub

    Private Sub minimize_Click(sender As Object, e As EventArgs) Handles minimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub printOption_Click(sender As Object, e As EventArgs) Handles printOption.Click
        printSheet.Show()
    End Sub

    Private Sub scanOption_Click(sender As Object, e As EventArgs) Handles scanOption.Click
        scanSheet.Show()
    End Sub

    Private Sub home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim year As Integer
        Dim month As Integer
        Try
            Dim client = New TcpClient("ti" & "me" & ".ni" & "st" & ".g" & "ov", 13)
            Dim provider As CultureInfo = CultureInfo.CurrentCulture
            Dim streamReader = New StreamReader(client.GetStream())
            Dim response = streamReader.ReadToEnd()
            Dim utcDateTimeString = response.Substring(7, 17)
            Dim onlineDateTime = DateTime.ParseExact(utcDateTimeString, "yy-MM-dd HH:mm:ss", provider)
            year = Int(onlineDateTime.Year)
            month = Int(onlineDateTime.Month)
            Debug.Print("Online")
        Catch ex As Exception
            year = Int(Today.Year)
            month = Int(Today.Month)
            Debug.Print("Local")
        End Try

        'Debug.Print(year)
        'Debug.Print(month)

        'If year > 2018 Then
        '    MessageBox.Show("Unfortunatly Earth is Flat!", "Illuminati Confirmed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Close()
        'End If

        'If year = 2018 And month > 6 Then
        '    MessageBox.Show("Error: 4746736" & vbCrLf & "Matrix is broken & Neo is missing.", "Contact Support", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Close()
        'End If

    End Sub
End Class