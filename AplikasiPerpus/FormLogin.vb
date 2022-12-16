Public Class FormLogin
    Private userClass As UserClass

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        userClass = New UserClass()
    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Try
            Dim plainUsername = TxtUsername.Text
            Dim plainPassword = TxtPassword.Text

            Dim authstatus As Boolean = userClass.CheckAuth(plainUsername, plainPassword)

            If authstatus Then
                Perpustakaan.Show()
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