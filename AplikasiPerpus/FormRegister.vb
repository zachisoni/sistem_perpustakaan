Public Class FormRegister
    Private Sub BtnDaftar_Click(sender As Object, e As EventArgs) Handles BtnDaftar.Click
        Dim dobleUsername = ""
        For Each user In FormLogin.getuserClass.getUsrList
            If TxtUsername.Text = user(0) Then
                dobleUsername = user(0)
            End If
        Next
        If TxtUsername.Text <> "" And TxtPassword.Text <> "" And dobleUsername = "" Then
            'Dim encryptedPass = FormLogin.getuserClass.EncryptData(TxtPassword.Text)
            FormLogin.getuserClass.addUser(TxtUsername.Text, TxtPassword.Text)
            Me.Close()
        ElseIf dobleUsername <> "" Then
            MessageBox.Show("Nama Pengguna sudah dipakai")
        Else
            MessageBox.Show("Harap isi Username dan password")
        End If
    End Sub
End Class