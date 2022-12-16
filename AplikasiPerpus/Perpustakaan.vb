Public Class Perpustakaan

    Public Shared dataBuku As DataBuku
    Public Shared selecteTableKoleksi As Integer
    Dim selectedTableKoleksiNama As String

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        dataBuku = New DataBuku()
        UpdateDataTableArrayList()
        ReloadDataTableDatabase()
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
        Dim hapus_confirm = New ConfirmDelete(selectedTableKoleksiNama)
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
        'selecteTableKoleksi = DataGridKoleksi.CurrentRow.Index
        Dim index As Integer = DataGridKoleksi.CurrentRow.Index
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridKoleksi.Rows(index)

        selecteTableKoleksi = selectedRow.Cells(0).Value
        selectedTableKoleksiNama = selectedRow.Cells(1).Value
    End Sub

    Private Sub BtnDetail_Click(sender As Object, e As EventArgs) Handles BtnDetail.Click
        Dim review = New FormReview(dataBuku.GetDataKoleksiByID(selecteTableKoleksi))
        review.Show()
    End Sub

    Private Sub ReloadDataTableDatabase()
        DataGridKoleksi.DataSource = dataBuku.GetDataKoleksiDatabase()
        ListBoxKoleksi.DataSource = dataBuku.GetCollection

    End Sub

    Private Sub Perpustakaan_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ReloadDataTableDatabase()
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Dim selectedKoleksi As List(Of String) = dataBuku.GetDataKoleksiByID(selecteTableKoleksi)

        dataBuku.GSPicture = selectedKoleksi(1)
        dataBuku.GSName = selectedKoleksi(0)
        dataBuku.GSJenis = selectedKoleksi(4)
        dataBuku.GSDesc = selectedKoleksi(2)
        dataBuku.GSPublisher = selectedKoleksi(3)
        dataBuku.GSYear = selectedKoleksi(5)
        dataBuku.GSLocation = selectedKoleksi(6)
        dataBuku.GSArriveDate = selectedKoleksi(7)
        dataBuku.GSStock = selectedKoleksi(8)
        dataBuku.GSLanguage = selectedKoleksi(9)

        Dim data_katgori As List(Of String) = dataBuku.ConvertStringToKoleksi(selectedKoleksi(10))

        For Each info_kategori In data_katgori
            dataBuku.AddCategory(info_kategori)
        Next

        Dim updateForm = New FormTambah(True)
        updateForm.Show()
    End Sub
End Class
