Public Class ConfirmDelete

    Sub New(label As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        LblKoleksi.Text = label
    End Sub

    Private Sub BtnBatal_Click(sender As Object, e As EventArgs) Handles BtnBatal.Click
        Me.Close()
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        Perpustakaan.HapusKoleksi()
        Perpustakaan.UpdateDataTableArrayList()
        Me.Close()
    End Sub
End Class