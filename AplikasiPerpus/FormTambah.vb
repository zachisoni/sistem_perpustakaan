Public Class FormTambah

    

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        TxtTahun.Text = Date.Now.Year
        TxtStock.Text = 0
        Perpustakaan.dataBuku.GSPicture = ""
    End Sub

    Private Sub BtnGambar_Click(sender As Object, e As EventArgs) Handles BtnGambar.Click
        Try
            OpenFileDialog1.Title = "Foto Buku"
            OpenFileDialog1.Filter = "Image|*.bmp|Image JPG|*.jpg|Image JPEG|*.jpeg|Image PNG|*.png|Image GIF|*.gif|All Format|*.*"
            OpenFileDialog1.ShowDialog()

            BookPic.Load(OpenFileDialog1.FileName)
            Perpustakaan.dataBuku.GSPicture = OpenFileDialog1.FileName
            BookPic.SizeMode = PictureBoxSizeMode.Zoom

        Catch ex As Exception
            MessageBox.Show("Mohon Pilih Foto!")

        End Try

    End Sub

    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        Perpustakaan.dataBuku.GSName = TxtNama.Text
        Perpustakaan.dataBuku.GSJenis = CbKoleksi.SelectedItem()
        Perpustakaan.dataBuku.GSDesc = RchDeskripsi.Text
        Perpustakaan.dataBuku.GSPublisher = TxtPenerbit.Text
        Perpustakaan.dataBuku.GSYear = TxtTahun.Text
        Perpustakaan.dataBuku.GSStock = Integer.Parse(TxtStock.Text)
        Perpustakaan.dataBuku.GSLocation = TxtRak.Text
        Perpustakaan.dataBuku.GSArriveDate = DateMasuk.Value

        If RdInggris.Checked Then
            Perpustakaan.dataBuku.GSLanguage = "Inggris"
        ElseIf RdIndo.Checked Then
            Perpustakaan.dataBuku.GSLanguage = "Indonesia"
        End If

        Perpustakaan.dataBuku.resetCategory()
        If ChkSains.Checked Then
            Perpustakaan.dataBuku.GetCategory.Add("Sains")
        End If
        If ChkSosial.Checked Then
            Perpustakaan.dataBuku.GetCategory.Add("Sosial")
        End If
        If ChkTekno.Checked Then
            Perpustakaan.dataBuku.GetCategory.Add("Teknologi")
        End If
        If ChkBudaya.Checked Then
            Perpustakaan.dataBuku.GetCategory.Add("Budaya")
        End If

        'Perpustakaan.GetBookList.Add(Perpustakaan.dataBuku)

        Perpustakaan.dataBuku.AddCollection(Perpustakaan.dataBuku.GSName)

        Dim convertedKoleksi = Perpustakaan.dataBuku.ConverKoleksiToString(Perpustakaan.dataBuku.GetCategory)
        Perpustakaan.dataBuku.AddKoleksiDataTable(Perpustakaan.dataBuku.GSPicture,
                                                  Perpustakaan.dataBuku.GSName,
                                                  Perpustakaan.dataBuku.GSJenis,
                                                  Perpustakaan.dataBuku.GSPublisher,
                                                  Perpustakaan.dataBuku.GSYear,
                                                  Perpustakaan.dataBuku.GSDesc,
                                                  Perpustakaan.dataBuku.GSLocation,
                                                  Perpustakaan.dataBuku.GSArriveDate,
                                                  Perpustakaan.dataBuku.GSStock,
                                                  Perpustakaan.dataBuku.GSLanguage,
                                                  convertedKoleksi)
        Dim review = New FormReview(Perpustakaan.dataBuku.getKoleksiDataTable(Perpustakaan.DataGridKoleksi.RowCount))
        Perpustakaan.UpdateDataTableArrayList()
        review.Show()
        Me.Close()
    End Sub
End Class