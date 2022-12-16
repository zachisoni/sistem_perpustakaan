Imports System.Security.Cryptography

Public Class UserClass

    Private userList As New ArrayList
    Private TripleDes As New TripleDESCng

    Public Sub New()
        userList.Add({"admin", EncryptData("123456")})
        userList.Add({"bassamtiano", EncryptData("1234")})
    End Sub

    Public Function EncryptData(ByVal plaintext As String) As String
        Dim plaintextBytes() As Byte = System.Text.Encoding.Unicode.GetBytes(plaintext)

        Dim ms As New System.IO.MemoryStream

        Dim encStream As New CryptoStream(ms,
                                          TripleDes.CreateEncryptor(),
                                          System.Security.Cryptography.CryptoStreamMode.Write)

        encStream.Write(plaintextBytes, 0, plaintextBytes.Length)
        encStream.FlushFinalBlock()

        Return Convert.ToBase64String(ms.ToArray)

    End Function

    Public Function CheckAuth(username As String, ByVal plainPassword As String) As Boolean
        Dim realUsername As String = ""
        Dim realPass As String = ""

        For Each user In userList
            If (user(0)) = username Then
                realUsername = user(0)
                realPass = user(1)
            End If
        Next

        If String.Compare(username, realUsername) = 0 And String.Compare(EncryptData(plainPassword), realPass) = 0 Then
            Return True
        Else Return False
        End If
    End Function

    Public ReadOnly Property getUsrList() As ArrayList
        Get
            Return userList
        End Get
    End Property

    Public Sub addUser(username As String, pass As String)
        userList.Add({username, EncryptData(pass)})
    End Sub


End Class
