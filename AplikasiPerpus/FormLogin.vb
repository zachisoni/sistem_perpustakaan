Public Class FormLogin
    Public Shared userClass As UserClass
    Public Shared perpustakaan As Perpustakaan

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        perpustakaan = New Perpustakaan()
        userClass = New UserClass()
    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Try
            Dim plainUsername = TxtUsername.Text
            Dim plainPassword = TxtPassword.Text

            Dim authstatus As Boolean = userClass.CheckAuth(plainUsername, plainPassword)

            Dim data_user As List(Of String) = userClass.CheckAuthDatabase(plainUsername, plainPassword)

            If data_user.Count > 0 Then
                userClass.SetUsername = data_user(1)
                perpustakaan.Show()
                Me.Hide()
            Else
                MessageBox.Show("Password dan Username tidak sesuai")
            End If
        Catch ex As Exception
            MsgBox(ex)
        End Try
    End Sub

    Public ReadOnly Property getuserClass As UserClass
        Get
            Return userClass
        End Get
    End Property

    Private Sub BtnRegister_Click(sender As Object, e As EventArgs) Handles BtnRegister.Click
        Dim registerForm = New FormRegister()
        FormRegister.Show()
    End Sub
End Class