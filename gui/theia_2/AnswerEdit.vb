Imports System.Text

Public Class AnswerEditor

    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer

    Private Sub AnswerEdit_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        drag = True
        mousex = System.Windows.Forms.Cursor.Position.X - Me.Left
        mousey = System.Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub

    Private Sub AnswerEdit_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If drag Then
            Me.Top = System.Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = System.Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub AnswerEdit_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        drag = False
    End Sub

    Private Sub AnswerEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        checkBoxGen(globalVariables.QsnCount)
    End Sub

    Public Function checkBoxGen(count As Integer)

        Dim i As Integer

        For i = 0 To (count - 1) Step 1
            Dim cbl As New CheckedListBox()
            Dim lbl As New Label()

            cbl.Items.Add("A", False)
            cbl.Items.Add("B", False)
            cbl.Items.Add("C", False)
            cbl.Items.Add("D", False)
            cbl.Items.Add("Blank", False)
            'cbl.Left = 40
            cbl.Top = 40 + ((i Mod 25) * 25)
            cbl.MultiColumn = True
            cbl.Height = 15
            cbl.Width = 230
            cbl.CheckOnClick = True
            cbl.ColumnWidth = 45
            cbl.BorderStyle = BorderStyle.None
            'cbl.BackColor = Color.FromArgb(66, 66, 66)
            cbl.ForeColor = Color.White
            cbl.Name = "cbl" & i.ToString

            lbl.Height = 15
            lbl.Width = 25
            'lbl.Left = 15
            lbl.Top = 40 + ((i Mod 25) * 25)
            lbl.Text = (i + 1).ToString & ") "
            lbl.ForeColor = Color.Aqua
            'lbl.BackColor = Color.FromArgb(66, 66, 66)

            If i Mod 2 = 0 Then
                cbl.BackColor = Color.FromArgb(66, 66, 66)
                lbl.BackColor = Color.FromArgb(66, 66, 66)
            Else
                cbl.BackColor = Color.FromArgb(33, 33, 33)
                lbl.BackColor = Color.FromArgb(33, 33, 33)
            End If


            If (i > 74) Then
                lbl.Left = 825
                cbl.Left = 865 - 15
                Me.Width = 1125
                ConfirmBtn.Left = 1030
                close_btn.Left = 1088
                minimize.Left = 1088 - 29
            ElseIf (i > 49) Then
                lbl.Left = 555
                cbl.Left = 590 - 10
                Me.Width = 850
                ConfirmBtn.Left = 755
                close_btn.Left = 813
                minimize.Left = 813 - 29
            ElseIf (i > 24) Then
                lbl.Left = 285
                cbl.Left = 315 - 5
                Me.Width = 575
                ConfirmBtn.Left = 480
                close_btn.Left = 538
                minimize.Left = 538 - 29
            ElseIf (i < 25) Then
                lbl.Left = 15
                cbl.Left = 40
            End If

            Me.Controls.Add(lbl)
            Me.Controls.Add(cbl)

            Dim subAnswer As String() = Split(globalVariables.Answers(i), ",")
            For Each ans In subAnswer
                'Debug.Print(ans & "/" & subAnswer.Count)

                If ans = "A" Then
                    cbl.SetItemCheckState(0, CheckState.Checked)
                ElseIf ans = "B" Then
                    cbl.SetItemCheckState(1, CheckState.Checked)
                ElseIf ans = "C" Then
                    cbl.SetItemCheckState(2, CheckState.Checked)
                ElseIf ans = "D" Then
                    cbl.SetItemCheckState(3, CheckState.Checked)
                ElseIf ans = "-" Then
                    cbl.SetItemCheckState(4, CheckState.Checked)
                End If
            Next

        Next

        GC.Collect()
        Return Nothing
    End Function

    Private Sub ConfirmBtn_Click(sender As Object, e As EventArgs) Handles ConfirmBtn.Click

        For i = 0 To (globalVariables.QsnCount - 1)
            Dim count As String = 0
            Dim clb As CheckedListBox = CType(Me.Controls.Find("cbl" & i, True).First, CheckedListBox)
            Dim ansBuilder As New StringBuilder
            For Each Item In clb.Items

                If clb.GetItemChecked(clb.Items.IndexOf(Item)) = True Then
                    'Debug.Print("_____" & clb.Items.IndexOf(Item))
                    count = count + 1
                    If count > 1 Then
                        ansBuilder.Append(",")
                    End If
                    If clb.Items.IndexOf(Item) = 0 Then
                        ansBuilder.Append("A")
                    ElseIf clb.Items.IndexOf(Item) = 1 Then
                        ansBuilder.Append("B")
                    ElseIf clb.Items.IndexOf(Item) = 2 Then
                        ansBuilder.Append("C")
                    ElseIf clb.Items.IndexOf(Item) = 3 Then
                        ansBuilder.Append("D")
                    ElseIf clb.Items.IndexOf(Item) = 4 Then
                        ansBuilder.Append("-")
                    End If
                End If
            Next
            globalVariables.finalAnswer(i) = ansBuilder.ToString
            Debug.Print("Confirmed Answer" & i + 1 & ") " & ansBuilder.ToString)
        Next
        scanDirectorty.Show()
        Me.Close()
        GC.Collect()
    End Sub

    Private Sub minimize_Click(sender As Object, e As EventArgs) Handles minimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub close_btn_Click(sender As Object, e As EventArgs) Handles close_btn.Click
        Me.Close()
        scanSheet.Show()
        GC.Collect()
        Me.Dispose()
    End Sub
End Class