Public Class FormReview

    Sub New(book As String())

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        If book(4) <> "" And book(8) <> "" Then
            LblNama.Text = book(1)
            LblJenis.Text = book(2)
            LblPenerbit.Text = book(3)
            LblTahun.Text = book(4)
            LblDeskripsi.Text = book(5)
            LblRak.Text = book(6)
            LblTglMasuk.Text = book(7)
            LblStok.Text = book(8)
            LblBahasa.Text = book(9)

            Dim kategori_list = Perpustakaan.dataBuku.ConvertStringToKoleksi(book(10))

            For Each category In kategori_list
                ListBoxKategori.Items.Add(category)
            Next
            If book(0) IsNot "" Then
                BookPic.Load(book(0))
                BookPic.SizeMode = PictureBoxSizeMode.Zoom
            End If

        End If

    End Sub

    Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles BtnOk.Click
        Me.Close()
    End Sub
End Class