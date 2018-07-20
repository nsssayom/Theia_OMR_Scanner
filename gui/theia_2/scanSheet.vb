Imports System.IO
Public Class scanSheet

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


    Private Sub browse_Click(sender As Object, e As EventArgs) Handles browse.Click
        Dim fileBrowser As New OpenFileDialog
        Dim fileFilter As String = "Image Files(*.BMP;*.JPG;*.PNG)|*.BMP;*.JPG;*.PNG"
        fileBrowser.Filter = fileFilter
        fileBrowser.Title = "Select an Scanned Answer file"
        If fileBrowser.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            fileDir.Text = fileBrowser.FileName
            fileBrowser.Dispose()
            GC.Collect()
        End If
    End Sub

    Private Sub close_btn_Click(sender As Object, e As EventArgs) Handles close_btn.Click
        GC.Collect()
        Me.Dispose()
    End Sub

    Private Sub minimize_Click(sender As Object, e As EventArgs) Handles minimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub scanSheet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        readRecentLocationLog()
    End Sub

    Private Sub recentLocations_SelectedIndexChanged(sender As Object, e As EventArgs) Handles recentLocations.SelectedIndexChanged
        fileDir.Text = recentLocations.SelectedItem.ToString
    End Sub

    Public Sub readRecentLocationLog()
        Dim lineData As String
        Dim fileReader As StreamReader
        fileReader = New StreamReader("recentLocations.log")
        lineData = fileReader.ReadLine
        'recentLocations.Items.Add(lineData)
        Do While Not lineData Is Nothing
            recentLocations.Items.Add(lineData)
            lineData = fileReader.ReadLine
        Loop
        fileReader.Close()
        fileReader.Dispose()
        GC.Collect()
    End Sub

    Public Sub writeRecentLocationLog(entry As String)
        Dim lineData As String
        Dim fileReader As New StreamReader("recentLocations.log")

        Dim fileData As New List(Of String)
        Dim i As Integer
        Dim writeLine As String

        fileData.Add(entry)

        lineData = fileReader.ReadLine
        Do While Not lineData Is Nothing
            fileData.Add(lineData)
            lineData = fileReader.ReadLine
        Loop
        fileReader.Close()

        Dim writeData As List(Of String) = fileData.Distinct().ToList

        If writeData.Count > 20 Then
            writeData.RemoveRange(20, (writeData.Count - 20))
        End If

        Dim fileWriter As New StreamWriter("recentLocations.log")
        fileWriter.Write("")
        For i = 0 To (writeData.Count - 1)
            writeLine = writeData(i)
            fileWriter.WriteLine(writeLine)
        Next
        fileWriter.Close()

        recentLocations.Items.Clear()
        readRecentLocationLog()
        GC.Collect()

    End Sub

    Private Sub scanAnsConfirm_Click(sender As Object, e As EventArgs) Handles scanAnsConfirm.Click
        Dim fileLocation As String = fileDir.Text
        sense = senseBar.Value
        If fileLocation <> "" Then
            readAnswers(fileLocation)
            writeRecentLocationLog((fileDir.Text).ToString)
        Else
            MessageBox.Show("Please enter directory of a Answer File.", "No Answer File Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        Me.Dispose()
        GC.Collect()
    End Sub

    Private Sub fileDir_keyPress(sender As System.Object, e As System.EventArgs) Handles fileDir.KeyPress
        Dim tmp As System.Windows.Forms.KeyPressEventArgs = e
        If tmp.KeyChar = ChrW(Keys.Enter) Then
            scanAnsConfirm.PerformClick()
        End If
    End Sub

    Private Sub readAnswers(fileDir As String)
        globalVariables.QsnCount = QsnCountInput.Value
        Dim output As String = cvScanModule.cvScan(fileDir)
        Dim subOutput As String()
        subOutput = Split(output, "<>")
        Dim answer As String = subOutput(1)
        Debug.Print(answer)

        Dim ansPerQsn As String()
        ansPerQsn = Split(answer, "|")

        Dim i As Integer = 0
        For i = 0 To (QsnCount - 1)
            Debug.Print("Answer " & (i + 1) & ") " & ansPerQsn(i))
            globalVariables.Answers(i) = ansPerQsn(i)
        Next

        AnswerEditor.Show()
        GC.Collect()
    End Sub


End Class