Public Class FormTambah

    Dim updating As Boolean = False

    Sub New(Optional isUpdate As Boolean = False)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        TxtTahun.Text = Date.Now.Year
        TxtStock.Text = 0
        Perpustakaan.dataBuku.GSPicture = ""

        DateMasuk.Format = DateTimePickerFormat.Custom
        DateMasuk.CustomFormat = "yyyy/MM/dd"

        If isUpdate Then
            LblTitle.Text = "Update Koleksi"
            BtnTambah.Text = "Update Koleksi"

            BookPic.Load(Perpustakaan.dataBuku.GSPicture)
            BookPic.SizeMode = PictureBoxSizeMode.Zoom
            TxtNama.Text = Perpustakaan.dataBuku.GSName
            CbKoleksi.SelectedItem() = Perpustakaan.dataBuku.GSJenis
            RchDeskripsi.Text = Perpustakaan.dataBuku.GSDesc
            TxtPenerbit.Text = Perpustakaan.dataBuku.GSPublisher
            TxtTahun.Text = Perpustakaan.dataBuku.GSYear
            TxtRak.Text = Perpustakaan.dataBuku.GSLocation
            DateMasuk.Value = Perpustakaan.dataBuku.GSArriveDate
            TxtStock.Text = Perpustakaan.dataBuku.GSStock

            If String.Compare(Perpustakaan.dataBuku.GSLanguage, "Indonesia") = 0 Then
                RdIndo.Checked = True
            ElseIf String.Compare(Perpustakaan.dataBuku.GSLanguage, "Inggris") = 0 Then
                RdInggris.Checked = True
            End If

            For Each kategoriItem In Perpustakaan.dataBuku.GetCategory
                If String.Compare(kategoriItem, "Sains") = 0 Then
                    ChkSains.Checked = True
                End If
                If String.Compare(kategoriItem, "Sosial") = 0 Then
                    ChkSosial.Checked = True
                End If
                If String.Compare(kategoriItem, "Teknologi") = 0 Then
                    ChkTekno.Checked = True
                End If
                If String.Compare(kategoriItem, "Budaya") = 0 Then
                    ChkBudaya.Checked = True
                End If
            Next
            Perpustakaan.dataBuku.resetCategory()

            updating = True

        End If

    End Sub

    Private Sub BtnGambar_Click(sender As Object, e As EventArgs) Handles BtnGambar.Click
        Try
            OpenFileDialog1.Title = "Foto Buku"
            OpenFileDialog1.Filter = "Image|*.bmp|Image JPG|*.jpg|Image JPEG|*.jpeg|Image PNG|*.png|Image GIF|*.gif|All Format|*.*"
            OpenFileDialog1.ShowDialog()

            BookPic.Load(OpenFileDialog1.FileName)
            BookPic.SizeMode = PictureBoxSizeMode.Zoom

            Perpustakaan.dataBuku.GSPicture = OpenFileDialog1.FileName.ToString()
            Perpustakaan.dataBuku.GSPicture = Perpustakaan.dataBuku.GSPicture.Replace("\", "/")


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
        Perpustakaan.dataBuku.GSArriveDate = DateMasuk.Value.ToString("yyyy/MM/dd")

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
        Dim review
        If updating Then
            Perpustakaan.dataBuku.UpdateDataKoleksiByIDDatabase(Perpustakaan.selecteTableKoleksi,
                                                                Perpustakaan.dataBuku.GSPicture,
                                                                Perpustakaan.dataBuku.GSName,
                                                                Perpustakaan.dataBuku.GSJenis,
                                                                Perpustakaan.dataBuku.GSPublisher,
                                                                Perpustakaan.dataBuku.GSDesc,
                                                                Perpustakaan.dataBuku.GSYear,
                                                                Perpustakaan.dataBuku.GSLocation,
                                                                Perpustakaan.dataBuku.GSArriveDate,
                                                                Perpustakaan.dataBuku.GSStock,
                                                                Perpustakaan.dataBuku.GSLanguage,
                                                                convertedKoleksi)
            review = New FormReview(Perpustakaan.dataBuku.GetDataKoleksiByID(Perpustakaan.selecteTableKoleksi))
        Else
            Perpustakaan.dataBuku.AddDataKoleksiDatabase(Perpustakaan.dataBuku.GSPicture,
                                                  Perpustakaan.dataBuku.GSName,
                                                  Perpustakaan.dataBuku.GSJenis,
                                                  Perpustakaan.dataBuku.GSPublisher,
                                                  Perpustakaan.dataBuku.GSDesc,
                                                  Perpustakaan.dataBuku.GSYear,
                                                  Perpustakaan.dataBuku.GSLocation,
                                                  Perpustakaan.dataBuku.GSArriveDate,
                                                  Perpustakaan.dataBuku.GSStock,
                                                  Perpustakaan.dataBuku.GSLanguage,
                                                  convertedKoleksi)
            review = New FormReview(Perpustakaan.dataBuku.GetDataKoleksiByID(Perpustakaan.DataGridKoleksi.RowCount))

        End If
        'Perpustakaan.UpdateDataTableArrayList()
        review.Show()
        Me.Close()
    End Sub
End Class