Public Class Perpustakaan

    Public Shared dataBuku As DataBuku
    Dim selecteTableKoleksi As Integer

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        dataBuku = New DataBuku()
        UpdateDataTableArrayList()
    End Sub

    Sub HapusKoleksi()
        'booklist.RemoveAt(indeks)
        dataBuku.RemoveKoleksiDataTable(selecteTableKoleksi)
    End Sub

    'Public ReadOnly Property GetBookList() As List(Of DataBuku)
    '    Get
    '        Return booklist
    '    End Get
    'End Property

    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        Dim formTambah = New FormTambah()
        formTambah.Show()
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        Dim hapus_confirm = New ConfirmDelete(dataBuku.getKoleksiDataTable(selecteTableKoleksi)(1))
        hapus_confirm.Show()
    End Sub

    Public Sub UpdateDataTableArrayList()
        DataGridKoleksi.Rows.Clear()
        For Each rowKoleksi In dataBuku.getKoleksiDataTable()
            Dim dataTable As String() = {rowKoleksi(1),
                                         rowKoleksi(2),
                                         rowKoleksi(3),
                                         rowKoleksi(4),
                                         rowKoleksi(5),
                                         rowKoleksi(6),
                                         rowKoleksi(7),
                                         rowKoleksi(8),
                                         rowKoleksi(9)}

            DataGridKoleksi.Rows.Add(dataTable)
        Next

    End Sub

    Private Sub DataGridKoleksi_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridKoleksi.CellClick
        selecteTableKoleksi = DataGridKoleksi.CurrentRow.Index
    End Sub

    Private Sub BtnDetail_Click(sender As Object, e As EventArgs) Handles BtnDetail.Click
        Dim review = New FormReview(dataBuku.getKoleksiDataTable(selecteTableKoleksi))
        review.Show()
    End Sub
End Class
