Imports System.Text

Public Class DataBuku
    Private bookName As String
    Private jenis As String
    Private bookDesc As String
    Private publisher As String
    Private year As String
    Private bookLocation As String
    Private arriveDate As Date
    Private stock As Integer
    Private language As String
    Private category As New List(Of String)
    Private listCollection As New List(Of String)
    Private picture As String = ""
    Private koleksiDataTable As New ArrayList()

    Public Property GSName() As String
        Get
            Return bookName
        End Get

        Set(value As String)
            bookName = value
        End Set
    End Property

    Public Property GSDesc() As String
        Get
            Return bookDesc
        End Get
        Set(value As String)
            bookDesc = value
        End Set
    End Property

    Public Property GSPublisher() As String
        Get
            Return publisher
        End Get
        Set(value As String)
            publisher = value
        End Set
    End Property

    Public Property GSYear() As String
        Get
            Return year
        End Get
        Set(value As String)
            year = value
        End Set
    End Property

    Public Property GSArriveDate() As Date
        Get
            Return arriveDate
        End Get
        Set(value As Date)
            arriveDate = value
        End Set
    End Property

    Public Property GSStock() As Integer
        Get
            Return stock
        End Get
        Set(value As Integer)
            stock = value
        End Set
    End Property

    Public Property GSLocation() As String
        Get
            Return bookLocation
        End Get
        Set(value As String)
            bookLocation = value
        End Set
    End Property

    Public Property GSLanguage() As String
        Get
            Return language
        End Get
        Set(value As String)
            language = value
        End Set
    End Property

    Public Function AddCategory(value As String)
        category.Add(value)
        Return ""
    End Function

    Public ReadOnly Property GetCategory() As List(Of String)
        Get
            Return category
        End Get
    End Property

    Public Function resetCategory()
        category.Clear()
        Return ""
    End Function

    Public Function AddCollection(value As String)
        listCollection.Add(value)
        Return ""
    End Function

    Public ReadOnly Property GetCollection() As List(Of String)
        Get
            Return listCollection
        End Get
    End Property

    Public Function resetCollection()
        listCollection.Clear()
        Return ""
    End Function

    Public Property GSPicture() As String
        Get
            Return picture
        End Get
        Set(value As String)
            picture = value
        End Set
    End Property

    Public Property GSJenis() As String
        Get
            Return jenis
        End Get
        Set(value As String)
            jenis = value
        End Set
    End Property

    Public Function AddKoleksiDataTable(gambar As String,
                                        nama_koleksi As String,
                                        jenis_koleksi As String,
                                        penerbit As String,
                                        tahun_terbit As String,
                                        deskripsi As String,
                                        lokasi_rak As String,
                                        tanggal_masuk As String,
                                        stok As String,
                                        bahasa As String,
                                        kategori As String)
        koleksiDataTable.Add({gambar,
                             nama_koleksi,
                             jenis_koleksi,
                             penerbit,
                             tahun_terbit,
                             deskripsi,
                             lokasi_rak,
                             tanggal_masuk,
                             stok,
                             bahasa,
                             kategori})
    End Function

    Public Function RemoveKoleksiDataTable(index As Integer)
        koleksiDataTable.RemoveAt(index)
    End Function

    Public ReadOnly Property getKoleksiDataTable() As ArrayList
        Get
            Return koleksiDataTable
        End Get
    End Property

    Public Function ConverKoleksiToString(listVal As List(Of String))
        Dim builder As StringBuilder = New StringBuilder()
        For Each val As String In listVal
            builder.Append(val).Append("|")
        Next

        Dim res = builder.ToString()
        Return res
    End Function

    Public Function ConvertStringToKoleksi(value As String)
        Dim arr() As String = value.Split("|")

        Dim listVal As List(Of String) = arr.ToList()
        Return listVal
    End Function

End Class
