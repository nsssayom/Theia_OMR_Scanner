Imports System.Drawing.Printing
Public Class printSheet
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer

    Private Sub printSheet_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        drag = True
        mousex = System.Windows.Forms.Cursor.Position.X - Me.Left
        mousey = System.Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub

    Private Sub printSheet_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If drag Then
            Me.Top = System.Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = System.Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub printSheet_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        drag = False
    End Sub

    Private Sub printSheet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        showInstalledPrinters()

    End Sub

    Dim printers(PrinterSettings.InstalledPrinters.Count) As String

    Private Sub showInstalledPrinters()
        ' Add list of installed printers found to the combo box.
        ' The pkInstalledPrinters string will be used to provide the display string.
        Dim i As Integer
        Dim pkInstalledPrinters As String

        For i = 0 To (PrinterSettings.InstalledPrinters.Count - 1)
            pkInstalledPrinters = PrinterSettings.InstalledPrinters.Item(i)
            Debug.Print(pkInstalledPrinters)
            printerList.Items.Add(pkInstalledPrinters)
            printers(i) = pkInstalledPrinters
        Next

    End Sub

    Private Sub minimize_Click(sender As Object, e As EventArgs) Handles minimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub close_btn_Click(sender As Object, e As EventArgs) Handles close_btn.Click
        OMRSheet = Nothing
        GC.Collect()
        Me.Dispose()
    End Sub

    Private Sub print_Click(sender As Object, e As EventArgs) Handles print.Click
        Dim PrinterName As String = printers(printerList.SelectedIndex)
        If printerList.SelectedItem <> Nothing Then
            PrintPage(PrinterName)
        Else
            MessageBox.Show("Please select a Printer", "No Printer Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    'Dim OMRSheet As Image = Image.FromFile("OMR.bmp")
    Dim OMRSheet As Image = globalVariables.imageGenerator()

    Public Sub PrintPage(PrinterName As String)
        Dim pd As New PrintDocument
        AddHandler pd.PrintPage, AddressOf PrintPageH
        pd.PrinterSettings.PrinterName = PrinterName
        pd.PrinterSettings.Copies = Int(copyInput.Value)

        Try
            pd.Print()
        Catch ex As Exception
            MsgBox("Printing Problem" & Chr(13) & ex.Message, MsgBoxStyle.Exclamation)
        End Try
        pd.Dispose()
        GC.Collect()
    End Sub

    Private Sub PrintPageH(ByVal sender As Object, ByVal e As PrintPageEventArgs)
        e.Graphics.DrawImage(OMRSheet, 0, 0, Convert.ToSingle(OMRSheet.Width / 3), Convert.ToSingle(OMRSheet.Height / 3))
        OMRSheet = Nothing
        GC.Collect()
    End Sub

End Class

