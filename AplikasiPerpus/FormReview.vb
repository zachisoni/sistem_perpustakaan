Public Class FormReview

    Sub New(book As List(Of String))

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        LblNama.Text = book.Item(0)
        LblDeskripsi.Text = book.Item(2)
        LblPenerbit.Text = book.Item(3)
        LblJenis.Text = book.Item(4)
        LblTahun.Text = book.Item(5)
        LblRak.Text = book.Item(6)
        LblTglMasuk.Text = book.Item(7)
        LblStok.Text = book.Item(8)
        LblBahasa.Text = book.Item(9)

        Dim kategori_list = Perpustakaan.dataBuku.ConvertStringToKoleksi(book.Item(9))

        For Each category In kategori_list
            ListBoxKategori.Items.Add(category)
        Next
        If book(1) IsNot "" Then
            BookPic.Load(book.Item(1))
            BookPic.SizeMode = PictureBoxSizeMode.Zoom
        End If

    End Sub

    Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles BtnOk.Click
        Me.Close()
    End Sub
End Class