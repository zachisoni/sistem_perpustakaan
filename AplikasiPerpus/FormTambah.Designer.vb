<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTambah
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
        Me.BookPic = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtNama = New System.Windows.Forms.TextBox()
        Me.RchDeskripsi = New System.Windows.Forms.RichTextBox()
        Me.TxtPenerbit = New System.Windows.Forms.TextBox()
        Me.TxtRak = New System.Windows.Forms.TextBox()
        Me.TxtTahun = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.DateMasuk = New System.Windows.Forms.DateTimePicker()
        Me.TxtStock = New System.Windows.Forms.TextBox()
        Me.RdIndo = New System.Windows.Forms.RadioButton()
        Me.RdInggris = New System.Windows.Forms.RadioButton()
        Me.ChkSains = New System.Windows.Forms.CheckBox()
        Me.ChkSosial = New System.Windows.Forms.CheckBox()
        Me.ChkBudaya = New System.Windows.Forms.CheckBox()
        Me.ChkTekno = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtnTambah = New System.Windows.Forms.Button()
        Me.BtnGambar = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.CbKoleksi = New System.Windows.Forms.ComboBox()
        CType(Me.BookPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'BookPic
        '
        Me.BookPic.Location = New System.Drawing.Point(15, 78)
        Me.BookPic.Name = "BookPic"
        Me.BookPic.Size = New System.Drawing.Size(150, 150)
        Me.BookPic.TabIndex = 0
        Me.BookPic.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(238, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(149, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Tambah Koleksi"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(220, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nama Koleksi"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(220, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 15)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Jenis Koleksi"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(220, 155)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 15)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Deskripsi"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(220, 288)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 15)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Penerbit"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(220, 328)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 15)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Tahun Terbit"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(220, 411)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(126, 15)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Tanggal Masuk Koleksi"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(220, 445)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(36, 15)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Stock"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(220, 483)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 15)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Bahasa"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(220, 574)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(51, 15)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Kategori"
        '
        'TxtNama
        '
        Me.TxtNama.Location = New System.Drawing.Point(355, 78)
        Me.TxtNama.Name = "TxtNama"
        Me.TxtNama.Size = New System.Drawing.Size(190, 23)
        Me.TxtNama.TabIndex = 11
        '
        'RchDeskripsi
        '
        Me.RchDeskripsi.Location = New System.Drawing.Point(358, 152)
        Me.RchDeskripsi.Name = "RchDeskripsi"
        Me.RchDeskripsi.Size = New System.Drawing.Size(187, 107)
        Me.RchDeskripsi.TabIndex = 13
        Me.RchDeskripsi.Text = ""
        '
        'TxtPenerbit
        '
        Me.TxtPenerbit.Location = New System.Drawing.Point(358, 288)
        Me.TxtPenerbit.Name = "TxtPenerbit"
        Me.TxtPenerbit.Size = New System.Drawing.Size(187, 23)
        Me.TxtPenerbit.TabIndex = 14
        '
        'TxtRak
        '
        Me.TxtRak.Location = New System.Drawing.Point(358, 365)
        Me.TxtRak.Name = "TxtRak"
        Me.TxtRak.Size = New System.Drawing.Size(187, 23)
        Me.TxtRak.TabIndex = 16
        '
        'TxtTahun
        '
        Me.TxtTahun.Location = New System.Drawing.Point(358, 328)
        Me.TxtTahun.Name = "TxtTahun"
        Me.TxtTahun.Size = New System.Drawing.Size(187, 23)
        Me.TxtTahun.TabIndex = 15
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(220, 365)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(62, 15)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "Lokasi Rak"
        '
        'DateMasuk
        '
        Me.DateMasuk.Location = New System.Drawing.Point(358, 411)
        Me.DateMasuk.Name = "DateMasuk"
        Me.DateMasuk.Size = New System.Drawing.Size(187, 23)
        Me.DateMasuk.TabIndex = 18
        '
        'TxtStock
        '
        Me.TxtStock.Location = New System.Drawing.Point(358, 445)
        Me.TxtStock.Name = "TxtStock"
        Me.TxtStock.Size = New System.Drawing.Size(187, 23)
        Me.TxtStock.TabIndex = 19
        '
        'RdIndo
        '
        Me.RdIndo.AutoSize = True
        Me.RdIndo.Location = New System.Drawing.Point(17, 22)
        Me.RdIndo.Name = "RdIndo"
        Me.RdIndo.Size = New System.Drawing.Size(116, 19)
        Me.RdIndo.TabIndex = 20
        Me.RdIndo.TabStop = True
        Me.RdIndo.Text = "Bahasa Indonesia"
        Me.RdIndo.UseVisualStyleBackColor = True
        '
        'RdInggris
        '
        Me.RdInggris.AutoSize = True
        Me.RdInggris.Location = New System.Drawing.Point(17, 47)
        Me.RdInggris.Name = "RdInggris"
        Me.RdInggris.Size = New System.Drawing.Size(101, 19)
        Me.RdInggris.TabIndex = 21
        Me.RdInggris.TabStop = True
        Me.RdInggris.Text = "Bahasa Inggris"
        Me.RdInggris.UseVisualStyleBackColor = True
        '
        'ChkSains
        '
        Me.ChkSains.AutoSize = True
        Me.ChkSains.Location = New System.Drawing.Point(7, 22)
        Me.ChkSains.Name = "ChkSains"
        Me.ChkSains.Size = New System.Drawing.Size(53, 19)
        Me.ChkSains.TabIndex = 22
        Me.ChkSains.Text = "Sains"
        Me.ChkSains.UseVisualStyleBackColor = True
        '
        'ChkSosial
        '
        Me.ChkSosial.AutoSize = True
        Me.ChkSosial.Location = New System.Drawing.Point(7, 47)
        Me.ChkSosial.Name = "ChkSosial"
        Me.ChkSosial.Size = New System.Drawing.Size(56, 19)
        Me.ChkSosial.TabIndex = 23
        Me.ChkSosial.Text = "Sosial"
        Me.ChkSosial.UseVisualStyleBackColor = True
        '
        'ChkBudaya
        '
        Me.ChkBudaya.AutoSize = True
        Me.ChkBudaya.Location = New System.Drawing.Point(94, 47)
        Me.ChkBudaya.Name = "ChkBudaya"
        Me.ChkBudaya.Size = New System.Drawing.Size(65, 19)
        Me.ChkBudaya.TabIndex = 25
        Me.ChkBudaya.Text = "Budaya"
        Me.ChkBudaya.UseVisualStyleBackColor = True
        '
        'ChkTekno
        '
        Me.ChkTekno.AutoSize = True
        Me.ChkTekno.Location = New System.Drawing.Point(94, 22)
        Me.ChkTekno.Name = "ChkTekno"
        Me.ChkTekno.Size = New System.Drawing.Size(77, 19)
        Me.ChkTekno.TabIndex = 24
        Me.ChkTekno.Text = "Teknologi"
        Me.ChkTekno.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RdIndo)
        Me.GroupBox1.Controls.Add(Me.RdInggris)
        Me.GroupBox1.Location = New System.Drawing.Point(358, 483)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(177, 75)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ChkTekno)
        Me.GroupBox2.Controls.Add(Me.ChkSains)
        Me.GroupBox2.Controls.Add(Me.ChkBudaya)
        Me.GroupBox2.Controls.Add(Me.ChkSosial)
        Me.GroupBox2.Location = New System.Drawing.Point(358, 574)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(177, 75)
        Me.GroupBox2.TabIndex = 27
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'BtnTambah
        '
        Me.BtnTambah.Location = New System.Drawing.Point(202, 661)
        Me.BtnTambah.Name = "BtnTambah"
        Me.BtnTambah.Size = New System.Drawing.Size(144, 23)
        Me.BtnTambah.TabIndex = 28
        Me.BtnTambah.Text = "Tambah Koleksi"
        Me.BtnTambah.UseVisualStyleBackColor = True
        '
        'BtnGambar
        '
        Me.BtnGambar.Location = New System.Drawing.Point(15, 236)
        Me.BtnGambar.Name = "BtnGambar"
        Me.BtnGambar.Size = New System.Drawing.Size(150, 23)
        Me.BtnGambar.TabIndex = 29
        Me.BtnGambar.Text = "Tambah Gambar"
        Me.BtnGambar.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'CbKoleksi
        '
        Me.CbKoleksi.FormattingEnabled = True
        Me.CbKoleksi.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.CbKoleksi.Items.AddRange(New Object() {"Buku", "Ensiklpedia", "Koran", "Majalah", "Publikasi Penelitian"})
        Me.CbKoleksi.Location = New System.Drawing.Point(355, 115)
        Me.CbKoleksi.Name = "CbKoleksi"
        Me.CbKoleksi.Size = New System.Drawing.Size(190, 23)
        Me.CbKoleksi.TabIndex = 30
        '
        'FormTambah
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(586, 691)
        Me.Controls.Add(Me.CbKoleksi)
        Me.Controls.Add(Me.BtnGambar)
        Me.Controls.Add(Me.BtnTambah)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TxtStock)
        Me.Controls.Add(Me.DateMasuk)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TxtRak)
        Me.Controls.Add(Me.TxtTahun)
        Me.Controls.Add(Me.TxtPenerbit)
        Me.Controls.Add(Me.RchDeskripsi)
        Me.Controls.Add(Me.TxtNama)
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
        Me.Name = "FormTambah"
        Me.Text = "FormTambah"
        CType(Me.BookPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BookPic As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents TxtNama As TextBox
    Friend WithEvents RchDeskripsi As RichTextBox
    Friend WithEvents TxtPenerbit As TextBox
    Friend WithEvents TxtRak As TextBox
    Friend WithEvents TxtTahun As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents DateMasuk As DateTimePicker
    Friend WithEvents TxtStock As TextBox
    Friend WithEvents RdIndo As RadioButton
    Friend WithEvents RdInggris As RadioButton
    Friend WithEvents ChkSains As CheckBox
    Friend WithEvents ChkSosial As CheckBox
    Friend WithEvents ChkBudaya As CheckBox
    Friend WithEvents ChkTekno As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BtnTambah As Button
    Friend WithEvents BtnGambar As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents CbKoleksi As ComboBox
End Class
