Imports System.IO
Imports Excel = Microsoft.Office.Interop.Excel
Public Class resultEdit
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer

    Private Sub resultEdit_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown, dataTable.MouseDown
        drag = True
        mousex = System.Windows.Forms.Cursor.Position.X - Me.Left
        mousey = System.Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub

    Private Sub resultEdit_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove, dataTable.MouseMove
        If drag Then
            Me.Top = System.Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = System.Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub resultEdit_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp, dataTable.MouseUp
        drag = False
    End Sub

    Private Sub close_btn_Click(sender As Object, e As EventArgs) Handles close_btn.Click
        GC.Collect()
        Me.Close()
    End Sub

    Private Sub minimize_Click(sender As Object, e As EventArgs) Handles minimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub dataTable_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dataTable.CellEndEdit
        If globalVariables.handelTable = True Then
            On Error Resume Next
            dataTable.Sort(dataTable.Columns("totalMarks"), System.ComponentModel.ListSortDirection.Descending)
            On Error Resume Next
        End If
        meritPosGen()
    End Sub

    Public Sub meritPosGen()
        For i = 0 To (dataTable.Rows.Count - 1)
            dataTable.Rows(i).Cells(0).Value = (i + 1)
        Next
        GC.Collect()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        dataTable.Columns("image").Visible = False

        Dim xlexcel As Microsoft.Office.Interop.Excel.Application
        Dim xlWorkBook As Microsoft.Office.Interop.Excel.Workbook
        Dim xlWorkSheet As Microsoft.Office.Interop.Excel.Worksheet
        Dim misValue As Object = System.Reflection.Missing.Value
        xlexcel = New Excel.Application()
        xlexcel.Visible = True
        xlWorkBook = xlexcel.Workbooks.Add(misValue)
        xlWorkSheet = DirectCast(xlWorkBook.Worksheets.Item(1), Excel.Worksheet)

        My.Computer.Clipboard.SetText(globalVariables.examName)
        Dim CR1 As Excel.Range = DirectCast(xlWorkSheet.Cells(1, 1), Excel.Range)
        CR1.[Select]()
        xlWorkSheet.PasteSpecial(CR1, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
        True)

        copyAlltoClipboard()
        xlWorkSheet.Range("A:A").NumberFormat = "@"
        Dim CR As Excel.Range = DirectCast(xlWorkSheet.Cells(3, 1), Excel.Range)
        CR.[Select]()
        xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
        True)

        dataTable.Columns("image").Visible = True
        dataTable.ClearSelection()
        GC.Collect()
    End Sub

    Private Sub copyAlltoClipboard()
        dataTable.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        dataTable.MultiSelect = True
        dataTable.SelectAll()

        Dim dataObj As DataObject = dataTable.GetClipboardContent()
        If dataObj IsNot Nothing Then
            Clipboard.SetDataObject(dataObj)
        End If
    End Sub

    Private Sub print_Click(sender As Object, e As EventArgs) Handles print.Click
        writeHtml()
        Process.Start("result.html")
    End Sub

    Public Sub writeHtml()
        Dim htmlWriter As StreamWriter
        htmlWriter = New StreamWriter("result.html")

        htmlWriter.WriteLine(globalVariables.htmlInit)
        htmlWriter.WriteLine("<h3>" & globalVariables.examName & "</h3>")
        htmlWriter.WriteLine("<div style=" & Chr(34) & "overflow-x: auto;" & Chr(34) & "> <table>
                                                                                      <tr>
                                                                                      <th>Merit Position</th>
                                                                                      <th>Roll Number</th>
                                                                                      <th>Correct Answer</th>
                                                                                      <th>Wrong Answer</th>
                                                                                      <th>Total Marks</th>
                                                                                    </tr>")

        For i = 0 To (dataTable.Rows.Count - 2)
            htmlWriter.WriteLine("<tr>")
            For j = 0 To 4 Step 1
                htmlWriter.WriteLine("<td>" & (dataTable.Rows(i).Cells(j).Value).ToString & "</td>")
            Next
            htmlWriter.WriteLine("</tr>")
        Next

        htmlWriter.WriteLine("</table>
                                </div>
                             <p> Powered By: Pothiq </p>
                                </body>
                                </html>")
        htmlWriter.Close()
        GC.Collect()
        htmlWriter.Dispose()
    End Sub

    Private Sub dataTable_SelectionChanged(sender As Object, e As EventArgs) Handles dataTable.SelectionChanged
        If dataTable.SelectedCells.Count > 0 Then
            previewImage.Close()
            Dim selectedrowindex As Integer = dataTable.SelectedCells(0).RowIndex
            Dim selectedcolumnindex As Integer = dataTable.SelectedCells(0).ColumnIndex
            If selectedcolumnindex = 5 Then
                previewImage.previewBox.ImageLocation = (dataTable.Rows(selectedrowindex).Cells(5).Value).ToString
                previewImage.Show()
            End If
        End If
        GC.Collect()
    End Sub
End Class