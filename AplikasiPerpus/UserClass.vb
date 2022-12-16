Imports System.Security.Cryptography
Imports MySql.Data.MySqlClient

Public Class UserClass

    Private userList As New ArrayList
    Private TripleDes As New TripleDESCng
    Private username As String

    Public Shared dbConn As New MySqlConnection
    Public Shared sqlCommand As New MySqlCommand
    Public Shared sqlRead As MySqlDataReader
    Private sqlQuery As String

    Private server As String = "localhost"
    Private username_db As String = "root"
    Private password_db As String = ""
    Private database As String = "perpustakaan"


    Public Sub New()
        'userList.Add({"admin", EncryptData("123456")})
        'userList.Add({"bassamtiano", EncryptData("1234")})
    End Sub

    Public WriteOnly Property SetUsername() As String
        Set(value As String)
            username = value
        End Set
    End Property

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

    Public Function EncryptMD5(ByVal password As String)
        Dim x = MD5.Create()
        Dim bs As Byte() = System.Text.Encoding.UTF8.GetBytes(password)
        bs = x.ComputeHash(bs)
        Dim s As New System.Text.StringBuilder()
        For Each b As Byte In bs
            s.Append(b.ToString("x2").ToLower())
        Next
        Return s.ToString()
    End Function

    Public Function AddUsesDatabase(username_regist As String, password_regist As String)
        Try
            Dim today = Date.Now()

            dbConn.ConnectionString = "server =" + server + ";user id=" + username_db _
                                      + ";password =" + password_db + ";database =" + database

            dbConn.Open()

            sqlCommand.Connection = dbConn
            sqlQuery = "INSERT INTO users(username, password, registered_at) VALUE('" _
                        & username_regist & "', '" _
                        & EncryptMD5(password_regist) & "', '" _
                        & today.ToString("yyyy/MM/dd") & "');"

            Debug.WriteLine(sqlQuery)

            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader

            sqlRead.Close()
            dbConn.Close()

        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()

        End Try

    End Function

    Public Function CheckAuthDatabase(username_login As String, password_login As String) As List(Of String)
        Try
            Dim result As New List(Of String)

            dbConn.ConnectionString = "server =" + server + "; user id=" + username_db _
                                      + ";password=" + password_db + ";database=" + database
            dbConn.Open()
            sqlCommand.Connection = dbConn

            Dim queryAuth = "SELECT id_user, username FROM users
                             WHERE username='" & username_login & "'
                             AND password='" & EncryptMD5(password_login) & "';"

            sqlCommand.CommandText = queryAuth
            Debug.WriteLine(queryAuth)
            sqlRead = sqlCommand.ExecuteReader

            If sqlRead.HasRows Then
                While sqlRead.Read
                    result.Add(sqlRead.GetString(0).ToString())
                    result.Add(sqlRead.GetString(1).ToString())
                End While
            End If

            sqlRead.Close()
            dbConn.Close()
            Return result

        Catch ex As Exception
            Debug.WriteLine(ex.Message)
        Finally
            dbConn.Dispose()
        End Try
    End Function

End Class

