<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormReview
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BtnOk = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BookPic = New System.Windows.Forms.PictureBox()
        Me.LblNama = New System.Windows.Forms.Label()
        Me.LblJenis = New System.Windows.Forms.Label()
        Me.LblPenerbit = New System.Windows.Forms.Label()
        Me.LblTahun = New System.Windows.Forms.Label()
        Me.LblTglMasuk = New System.Windows.Forms.Label()
        Me.LblRak = New System.Windows.Forms.Label()
        Me.LblBahasa = New System.Windows.Forms.Label()
        Me.LblStok = New System.Windows.Forms.Label()
        Me.ListBoxKategori = New System.Windows.Forms.ListBox()
        Me.LblDeskripsi = New System.Windows.Forms.RichTextBox()
        CType(Me.BookPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnOk
        '
        Me.BtnOk.Location = New System.Drawing.Point(202, 547)
        Me.BtnOk.Name = "BtnOk"
        Me.BtnOk.Size = New System.Drawing.Size(117, 23)
        Me.BtnOk.TabIndex = 51
        Me.BtnOk.Text = "OK"
        Me.BtnOk.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(211, 285)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(62, 15)
        Me.Label11.TabIndex = 47
        Me.Label11.Text = "Lokasi Rak"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(211, 443)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(51, 15)
        Me.Label10.TabIndex = 41
        Me.Label10.Text = "Kategori"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(211, 404)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 15)
        Me.Label9.TabIndex = 40
        Me.Label9.Text = "Bahasa"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(211, 364)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(36, 15)
        Me.Label8.TabIndex = 39
        Me.Label8.Text = "Stock"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(211, 325)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(126, 15)
        Me.Label7.TabIndex = 38
        Me.Label7.Text = "Tanggal Masuk Koleksi"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(211, 248)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 15)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "Tahun Terbit"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(211, 208)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 15)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "Penerbit"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(211, 150)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 15)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Deskripsi"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(211, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 15)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Jenis Koleksi"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(211, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 15)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Nama Koleksi"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(193, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 25)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Info Koleksi"
        '
        'BookPic
        '
        Me.BookPic.Location = New System.Drawing.Point(24, 73)
        Me.BookPic.Name = "BookPic"
        Me.BookPic.Size = New System.Drawing.Size(150, 150)
        Me.BookPic.TabIndex = 31
        Me.BookPic.TabStop = False
        '
        'LblNama
        '
        Me.LblNama.AutoSize = True
        Me.LblNama.Location = New System.Drawing.Point(388, 73)
        Me.LblNama.Name = "LblNama"
        Me.LblNama.Size = New System.Drawing.Size(43, 15)
        Me.LblNama.TabIndex = 53
        Me.LblNama.Text = "$nama"
        '
        'LblJenis
        '
        Me.LblJenis.AutoSize = True
        Me.LblJenis.Location = New System.Drawing.Point(388, 110)
        Me.LblJenis.Name = "LblJenis"
        Me.LblJenis.Size = New System.Drawing.Size(37, 15)
        Me.LblJenis.TabIndex = 54
        Me.LblJenis.Text = "$jenis"
        '
        'LblPenerbit
        '
        Me.LblPenerbit.AutoSize = True
        Me.LblPenerbit.Location = New System.Drawing.Point(388, 208)
        Me.LblPenerbit.Name = "LblPenerbit"
        Me.LblPenerbit.Size = New System.Drawing.Size(57, 15)
        Me.LblPenerbit.TabIndex = 56
        Me.LblPenerbit.Text = "$penerbit"
        '
        'LblTahun
        '
        Me.LblTahun.AutoSize = True
        Me.LblTahun.Location = New System.Drawing.Point(388, 248)
        Me.LblTahun.Name = "LblTahun"
        Me.LblTahun.Size = New System.Drawing.Size(44, 15)
        Me.LblTahun.TabIndex = 57
        Me.LblTahun.Text = "$tahun"
        '
        'LblTglMasuk
        '
        Me.LblTglMasuk.AutoSize = True
        Me.LblTglMasuk.Location = New System.Drawing.Point(388, 325)
        Me.LblTglMasuk.Name = "LblTglMasuk"
        Me.LblTglMasuk.Size = New System.Drawing.Size(88, 15)
        Me.LblTglMasuk.TabIndex = 59
        Me.LblTglMasuk.Text = "$tanggalMasuk"
        '
        'LblRak
        '
        Me.LblRak.AutoSize = True
        Me.LblRak.Location = New System.Drawing.Point(388, 285)
        Me.LblRak.Name = "LblRak"
        Me.LblRak.Size = New System.Drawing.Size(29, 15)
        Me.LblRak.TabIndex = 58
        Me.LblRak.Text = "$rak"
        '
        'LblBahasa
        '
        Me.LblBahasa.AutoSize = True
        Me.LblBahasa.Location = New System.Drawing.Point(388, 404)
        Me.LblBahasa.Name = "LblBahasa"
        Me.LblBahasa.Size = New System.Drawing.Size(50, 15)
        Me.LblBahasa.TabIndex = 61
        Me.LblBahasa.Text = "$bahasa"
        '
        'LblStok
        '
        Me.LblStok.AutoSize = True
        Me.LblStok.Location = New System.Drawing.Point(388, 364)
        Me.LblStok.Name = "LblStok"
        Me.LblStok.Size = New System.Drawing.Size(35, 15)
        Me.LblStok.TabIndex = 60
        Me.LblStok.Text = "$stok"
        '
        'ListBoxKategori
        '
        Me.ListBoxKategori.FormattingEnabled = True
        Me.ListBoxKategori.ItemHeight = 15
        Me.ListBoxKategori.Location = New System.Drawing.Point(356, 443)
        Me.ListBoxKategori.Name = "ListBoxKategori"
        Me.ListBoxKategori.Size = New System.Drawing.Size(164, 94)
        Me.ListBoxKategori.TabIndex = 62
        '
        'LblDeskripsi
        '
        Me.LblDeskripsi.Enabled = False
        Me.LblDeskripsi.Location = New System.Drawing.Point(388, 147)
        Me.LblDeskripsi.Name = "LblDeskripsi"
        Me.LblDeskripsi.Size = New System.Drawing.Size(148, 58)
        Me.LblDeskripsi.TabIndex = 63
        Me.LblDeskripsi.Text = ""
        '
        'FormReview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(548, 582)
        Me.Controls.Add(Me.LblDeskripsi)
        Me.Controls.Add(Me.ListBoxKategori)
        Me.Controls.Add(Me.LblBahasa)
        Me.Controls.Add(Me.LblStok)
        Me.Controls.Add(Me.LblTglMasuk)
        Me.Controls.Add(Me.LblRak)
        Me.Controls.Add(Me.LblTahun)
        Me.Controls.Add(Me.LblPenerbit)
        Me.Controls.Add(Me.LblJenis)
        Me.Controls.Add(Me.LblNama)
        Me.Controls.Add(Me.BtnOk)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BookPic)
        Me.Name = "FormReview"
        Me.Text = "FormReview"
        CType(Me.BookPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnOk As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BookPic As PictureBox
    Friend WithEvents LblNama As Label
    Friend WithEvents LblJenis As Label
    Friend WithEvents LblPenerbit As Label
    Friend WithEvents LblTahun As Label
    Friend WithEvents LblTglMasuk As Label
    Friend WithEvents LblRak As Label
    Friend WithEvents LblBahasa As Label
    Friend WithEvents LblStok As Label
    Friend WithEvents ListBoxKategori As ListBox
    Friend WithEvents LblDeskripsi As RichTextBox
End Class
