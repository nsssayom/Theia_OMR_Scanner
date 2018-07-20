Imports System.Management
Imports System.Security.Cryptography
Imports System.Text
Imports System
Imports System.IO
Imports System.Net

Module globalVariables
    Public QsnCount As Integer = 50
    Public Answers(100) As String
    Public finalAnswer(100) As String
    Public examName As String
    Public handelTable As Boolean = False
    Public sense As Integer
    Public htmlInit As String =
    "<html>
    <head>
    <style>
    table {
            border-collapse: collapse;
            width: 100%;
          }

             th, td, h1{
             text-align: center;
                   padding: 8px;
          }

           h3, p{
	          text-align: center;
           }
           tr:nth-child(even){background-color: #f2f2f2}
           tr:hover {background-color: #BBDEFB;}
           }

           </style>
             </head>
                  <body onload ='window.print()'>
                    <h1> Southern University</h1>"
    'Public previewImageDir As String = ""

    Public Function isLicensed() As Boolean
        If My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Theia OMR System", "installInfo", Nothing) IsNot Nothing Then
            Return True
        Else
            Return False
        End If
    End Function


    Public Function verifyLicense(ByVal key As String) As Boolean
        If (key = "AKPzGzCP6nsXH5kAfCVhxPAs" Or key = "WFxsDYWfjj92o2qSM7pblQ4X" Or key = "rebo1FtDEkokyuACPo62mMzR") Then
            Return True
        Else
            MsgBox("Wrong Serial")
            Return False
        End If
    End Function

    Public Function writeReg(key As String) As Boolean
        Try
            My.Computer.Registry.CurrentUser.CreateSubKey("HKEY_CURRENT_USER\Software\Theia OMR System")
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Theia OMR System", "installInfo", (key.ToUpper))
            'MsgBox("Product successfully Activated!")
            Return True
        Catch f As Exception
            MsgBox("Activation Failed due to Registry Error.")
            Return False
        End Try
    End Function

    Public Function Decrypt(ByVal input As String, ByVal pass As String) As String
        Dim AES As New System.Security.Cryptography.RijndaelManaged
        Dim Hash_AES As New System.Security.Cryptography.MD5CryptoServiceProvider
        Dim decrypted As String = ""
        Try
            Dim hash(31) As Byte
            Dim temp As Byte() = Hash_AES.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(pass))
            Array.Copy(temp, 0, hash, 0, 16)
            Array.Copy(temp, 0, hash, 15, 16)
            AES.Key = hash
            AES.Mode = Security.Cryptography.CipherMode.ECB
            Dim DESDecrypter As System.Security.Cryptography.ICryptoTransform = AES.CreateDecryptor
            Dim Buffer As Byte() = Convert.FromBase64String(input)
            decrypted = System.Text.ASCIIEncoding.ASCII.GetString(DESDecrypter.TransformFinalBlock(Buffer, 0, Buffer.Length))
            Return decrypted
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function imageGenerator() As Image
        Dim encryptedString As String = File.ReadAllText("omr.bin")
        Dim encodedString As String = globalVariables.Decrypt(encryptedString, "Heil Hitler")
        Dim imageBytes As Byte() = Convert.FromBase64String(encodedString)
        Dim ms As MemoryStream = New MemoryStream(imageBytes, 0, imageBytes.Length)
        ms.Write(imageBytes, 0, imageBytes.Length)
        Dim img As Image = Image.FromStream(ms, True)

        encryptedString = String.Empty
        encodedString = String.Empty
        imageBytes = Nothing
        ms.SetLength(0)
        GC.Collect()
        Return img
    End Function

End Module
