Imports System.ComponentModel
Imports System.IO
Public Class scanDirectorty

    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer

    Private Sub scanDirectory_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        drag = True
        mousex = System.Windows.Forms.Cursor.Position.X - Me.Left
        mousey = System.Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub

    Private Sub scanDirectory_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If drag Then
            Me.Top = System.Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = System.Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub scanDirectory_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        drag = False
    End Sub


    Private Sub close_btn_Click(sender As Object, e As EventArgs) Handles close_btn.Click
        GC.Collect()
        Me.Close()
    End Sub

    Private Sub minimize_Click(sender As Object, e As EventArgs) Handles minimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub browse_btn_Click(sender As Object, e As EventArgs) Handles browse_btn.Click
        Dim folderBrowser As New FolderBrowserDialog()
        If folderBrowser.ShowDialog() = DialogResult.OK Then
            folderLoc.Text = folderBrowser.SelectedPath
            folderBrowser.Dispose()
            GC.Collect()
        End If
    End Sub

    Public folder_path As String = String.Empty

    'Private Sub scanAnsConfirm_Click(sender As Object, e As EventArgs) Handles scanAnsConfirm.Click
    '    animLoad.Visible = True
    '    If isLicensed() = True Then
    '        handelTable = False

    '        If examNameInput.Text = Nothing Then
    '            Dim result = MessageBox.Show("Are you sure that you want to continue without a Exam Name?", "No Exam Name Entered", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
    '            If result = DialogResult.No Then
    '                Return
    '            End If
    '        End If

    '        If folderLoc.Text <> Nothing Then
    '            globalVariables.examName = (examNameInput.Text).ToString
    '            Dim folder_path As String = (folderLoc.Text).ToString
    '            Dim folder_info As DirectoryInfo = New DirectoryInfo(folder_path)

    '            For Each OMR_Sheet In folder_info.GetFiles("*.bmp")

    '                Dim correctAnsCount As Integer = 0
    '                Dim wrongAnsCount As Integer = 0

    '                Dim OMR_Sheet_Directory As String = OMR_Sheet.FullName
    '                Debug.Print("Now Scanning: " & OMR_Sheet_Directory)

    '                Dim nativeReturn As String = ""
    '                nativeReturn = cvScanModule.cvScan(OMR_Sheet_Directory)
    '                Dim subNativeReturn As String()
    '                subNativeReturn = Split(nativeReturn, "<>")
    '                Dim OMRroll As String = ""
    '                If subNativeReturn(0) <> Nothing Then
    '                    OMRroll = subNativeReturn(0)
    '                Else
    '                    OMRroll = "Blank Roll"
    '                End If
    '                Dim OMRResString As String = ""
    '                OMRResString = subNativeReturn(1)
    '                Dim OMRMarks As Double = 0

    '                OMRMarks = calcMarks(OMRResString, correctAnsCount, wrongAnsCount)
    '                Debug.Print("#" & OMRroll & "|" & OMRMarks & "|" & correctAnsCount & "|" & wrongAnsCount)
    '                resultEdit.dataTable.Columns("totalMarks").ValueType = GetType(System.Double)
    '                resultEdit.dataTable.Rows.Add("", OMRroll, correctAnsCount, wrongAnsCount, OMRMarks, OMR_Sheet_Directory)
    '                resultEdit.dataTable.Sort(resultEdit.dataTable.Columns("totalMarks"), System.ComponentModel.ListSortDirection.Descending)
    '                resultEdit.meritPosGen()
    '                GC.Collect()
    '            Next
    '            animLoad.Visible = False
    '            resultEdit.Show()
    '            handelTable = True
    '        Else
    '            MessageBox.Show("Please enter a directory containing the Scanned OMR Sheets.", "No Directory Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '        End If
    '        GC.Collect()
    '    Else
    '        Me.Hide()
    '        license.Show()
    '    End If
    'End Sub


    Private Sub scanAnsConfirm_Click(sender As Object, e As EventArgs) Handles scanAnsConfirm.Click
        animLoad.Visible = True
        If isLicensed() = True Then
            handelTable = False

            If examNameInput.Text = Nothing Then
                Dim result = MessageBox.Show("Are you sure that you want to continue without a Exam Name?", "No Exam Name Entered", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                If result = DialogResult.No Then
                    Return
                End If
            End If

            If folderLoc.Text <> Nothing Then
                globalVariables.examName = (examNameInput.Text).ToString
                Dim folder_path As String = (folderLoc.Text).ToString
                Dim folder_info As DirectoryInfo = New DirectoryInfo(folder_path)

                Dim nativeWorker As New System.Threading.Thread(AddressOf Worker)
                nativeWorker.Start()
            Else
                MessageBox.Show("Please enter a directory containing the Scanned OMR Sheets.", "No Directory Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
            GC.Collect()
        Else
            Me.Hide()
            license.Show()
        End If
    End Sub


    Private Sub Worker()
        ' this runs in a different thread without blocking the GUI:
        Dim folder_path As String = (folderLoc.Text).ToString
        Dim folder_info As DirectoryInfo = New DirectoryInfo(folder_path)
        For Each OMR_Sheet In folder_info.GetFiles("*.bmp")

            Dim correctAnsCount As Integer = 0
            Dim wrongAnsCount As Integer = 0

            Dim OMR_Sheet_Directory As String = OMR_Sheet.FullName
            Debug.Print("Now Scanning: " & OMR_Sheet_Directory)

            Dim nativeReturn As String = ""
            nativeReturn = cvScanModule.cvScan(OMR_Sheet_Directory)
            Dim subNativeReturn As String()
            subNativeReturn = Split(nativeReturn, "<>")
            Dim OMRroll As String = ""
            If subNativeReturn(0) <> Nothing Then
                OMRroll = subNativeReturn(0)
            Else
                OMRroll = "Blank Roll"
            End If
            Dim OMRResString As String = ""
            OMRResString = subNativeReturn(1)
            Dim OMRMarks As Double = 0

            OMRMarks = calcMarks(OMRResString, correctAnsCount, wrongAnsCount)
            Debug.Print("#" & OMRroll & "|" & OMRMarks & "|" & correctAnsCount & "|" & wrongAnsCount)

            ' when you need to update the GUI:
            Me.Invoke(Sub()
                          ' ... do it in here ...
                          resultEdit.dataTable.Columns("totalMarks").ValueType = GetType(System.Double)
                          resultEdit.dataTable.Rows.Add("", OMRroll, correctAnsCount, wrongAnsCount, OMRMarks, OMR_Sheet_Directory)
                          resultEdit.dataTable.Sort(resultEdit.dataTable.Columns("totalMarks"), System.ComponentModel.ListSortDirection.Descending)
                          resultEdit.meritPosGen()
                          GC.Collect()
                      End Sub)
        Next

        Me.Invoke(Sub()
                      animLoad.Visible = False
                      resultEdit.Show()
                      handelTable = True
                  End Sub)
    End Sub

    Public Function calcMarks(resString As String, ByRef correctAnsCount As Integer, ByRef WrongAnsCount As Integer) As Double
        correctAnsCount = 0
        WrongAnsCount = 0

        Dim totalMarks As Double = 0
        Dim OMRans As String()
        OMRans = Split(resString, "|")

        For i = 0 To (globalVariables.QsnCount - 1)
            If globalVariables.finalAnswer(i) = OMRans(i) Then
                correctAnsCount = correctAnsCount + 1
            Else
                WrongAnsCount = WrongAnsCount + 1
            End If
        Next

        totalMarks = ((correctAnsCount * RightMarksInput.Value) - (WrongAnsCount * WrongMarksInput.Value))
        GC.Collect()
        Return totalMarks
    End Function

End Class