Public Class license

    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer

    Private Sub licenseMouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        drag = True
        mousex = System.Windows.Forms.Cursor.Position.X - Me.Left
        mousey = System.Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub

    Private Sub licenseMouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If drag Then
            Me.Top = System.Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = System.Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub licenseMouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        drag = False
    End Sub


    Private Sub close_btn_Click(sender As Object, e As EventArgs) Handles close_btn.Click
        GC.Collect()
        Me.Close()
    End Sub

    Private Sub submit_Click(sender As Object, e As EventArgs) Handles submit.Click
        If verifyLicense((keyInput.Text)) = True Then
            MsgBox("success")
            writeReg(keyInput.Text)
            If isLicensed() = True Then
                MessageBox.Show("Product successfully Activated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                scanDirectorty.Show()
                Me.Close()
                GC.Collect()
            End If
        End If
    End Sub
End Class