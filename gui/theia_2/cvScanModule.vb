Imports System
Imports System.text
Imports System.IO
Imports System.ComponentModel
Imports System.Security.Cryptography


Module cvScanModule
    Public Function cvScan(fileDir As String) As String
        Dim cpp_exe_directory As String = "native"
        Dim sOut As String = ""
        Dim randomKey As String = randomGen()

        Directory.SetCurrentDirectory(cpp_exe_directory)

        Try
            If writeRandomReg(randomKey) <> True Then
                MessageBox.Show("Error: Registry is corrupted!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return Nothing
            End If

            'Dim cpp_terminal As New ProcessStartInfo(cpp_exe_directory & "\theia_scanner.exe", "4 " & fileDir & " " & randomKey)
            Dim cpp_terminal As New ProcessStartInfo(cpp_exe_directory & "\theia_scanner.exe", "5 " & fileDir & " " & randomKey & " " & sense.ToString)

            cpp_terminal.UseShellExecute = False
            cpp_terminal.CreateNoWindow = True
            cpp_terminal.RedirectStandardOutput = True
            cpp_terminal.RedirectStandardError = True

            ' Make the process and set its start information.
            Dim proc As New Process()
            proc.StartInfo = cpp_terminal

            ' Start the process.
            proc.Start()


            ' Attach to stdout and stderr.
            Dim std_out As StreamReader = proc.StandardOutput() ' will not continue until process stops
            Dim std_err As StreamReader = proc.StandardError()

            ' Retrive the results.
            sOut = std_out.ReadToEnd()
            Dim sErr As String = std_err.ReadToEnd()

            Directory.SetCurrentDirectory("../")
            'Debug.Print(sOut)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return sOut
    End Function

    Public Function randomGen() As String
        Dim s As String = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789~!@#$%^&*()_+-={}[]|\:;<>?/"
        Dim r As New Random
        Dim sb As New StringBuilder
        For i As Integer = 1 To 16
            Dim idx As Integer = r.Next(0, 89)
            sb.Append(s.Substring(idx, 1))
        Next
        Return sb.ToString()
    End Function

    Public Function GenerateSHA256String(ByVal inputString As String) As String
        Dim sha256 As SHA256 = SHA256Managed.Create()
        Dim bytes As Byte() = Encoding.UTF8.GetBytes(inputString)
        Dim hash As Byte() = sha256.ComputeHash(bytes)
        Return GetStringFromHash(hash)
    End Function

    Public Function GetStringFromHash(ByVal hash As Byte()) As String
        Dim result As StringBuilder = New StringBuilder()
        For i As Integer = 0 To hash.Length - 1
            result.Append(hash(i).ToString("X2"))
        Next
        Return result.ToString()
    End Function

    Public Function writeRandomReg(ByVal randomKey As String) As Boolean

        Dim keyBuilder As StringBuilder = New StringBuilder("heil fuhrer")
        keyBuilder.Append(randomKey)
        keyBuilder.Append("fuhrer is great")

        Dim builtKey As String = keyBuilder.ToString
        Dim key As String = GenerateSHA256String(builtKey).ToUpper

        Try
            My.Computer.Registry.CurrentUser.CreateSubKey("HKEY_CURRENT_USER\Software\TheiaTemp")
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\TheiaTemp", "HeilHitler", (key.ToUpper))
            'MsgBox("Product successfully Activated!")
            Return True
        Catch f As Exception
            MsgBox("Activation Failed due to Registry Error.")
            Return False
        End Try
    End Function

End Module
