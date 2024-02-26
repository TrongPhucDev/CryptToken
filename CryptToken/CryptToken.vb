Imports System.IO
Imports System.Text
Imports Org.BouncyCastle.Crypto
Imports Org.BouncyCastle.Crypto.Encodings
Imports Org.BouncyCastle.Crypto.Engines
Imports Org.BouncyCastle.Crypto.Parameters
Imports Org.BouncyCastle.OpenSsl
Public Class CryptToken
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub EncryptBtn_Click(sender As Object, e As EventArgs) Handles EncryptBtn.Click
        Dim publicString As String = RichTextPublicKey.Text.ToString()
        Dim input As String = InputValue.Text.ToString()
        Dim result = EncryptPublicKey(input, publicString)
        OutputValue.Text = result
    End Sub

    Private Sub DecryptBtn_Click(sender As Object, e As EventArgs) Handles DecryptBtn.Click
        Dim privateString As String = RichTextPrivateKey.Text.ToString()
        Dim input As String = InputValue.Text.ToString()
        Dim result = DecryptPrivateKey(input, privateString)
        OutputValue.Text = result
    End Sub

    Public Shared Function EncryptPublicKey(ByVal value As String, ByVal publicKey As String) As String
        Dim bytesToEncrypt = Encoding.UTF8.GetBytes(value)
        Dim encryptEngine = New Pkcs1Encoding(New RsaEngine())
        Try
            Using txtreader = New StringReader(publicKey)
                Dim keyParameter = CType(New PemReader(txtreader).ReadObject(), AsymmetricKeyParameter)
                encryptEngine.Init(True, keyParameter)
            End Using
        Catch ex As Exception
            Throw ex
        End Try


        Dim encrypted = Convert.ToBase64String(encryptEngine.ProcessBlock(bytesToEncrypt, 0, bytesToEncrypt.Length))
        Return encrypted
    End Function

    Public Shared Function DecryptPrivateKey(ByVal value As String, ByVal privateKey As String) As String
        Try
            Dim bytesToDecrypt = Convert.FromBase64String(value)
            Dim keyPair As AsymmetricCipherKeyPair
            Dim decryptEngine = New Pkcs1Encoding(New RsaEngine())

            Using txtreader = New StringReader(privateKey)
                keyPair = CType(New PemReader(txtreader).ReadObject(), AsymmetricCipherKeyPair)
                decryptEngine.Init(False, keyPair.[Private])
            End Using

            Dim decrypted = Encoding.UTF8.GetString(decryptEngine.ProcessBlock(bytesToDecrypt, 0, bytesToDecrypt.Length))
            Return decrypted
        Catch ex As Exception

        End Try
    End Function

    Private Sub CryptToken_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ClearBtn_Click(sender As Object, e As EventArgs) Handles ClearBtn.Click
        InputValue.Text = ""
        OutputValue.Text = ""
        RichTextPublicKey.Text = ""
        RichTextPrivateKey.Text = ""
    End Sub
End Class
