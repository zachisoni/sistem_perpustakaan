Imports System.Text
Imports MySql.Data.MySqlClient

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

    Private server As String = "localhost"
    Private username As String = "root"
    Private password As String = ""
    Private database As String = "perpustakaan"

    Private sqlQuery As String

    Public Shared dbConn As New MySqlConnection
    Public Shared sqlCommand As New MySqlCommand
    Public Shared sqlRead As MySqlDataReader

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

    Public Function GetDataKoleksiDatabase() As DataTable
        Dim result As New DataTable

        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
                                  + "password=" + password + ";" + "database =" + database
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT id_koleksi AS 'ID',
                                  nama_koleksi AS 'Nama Koleksi',
                                  jenis_koleksi as 'Jenis Koleksi',
                                  penerbit as 'Penerbit', 
                                  tahun_terbit as 'Tahun Terbit',
                                  tanggal_masuk_koleksi as 'Tanggal Masuk',
                                  lokasi as 'Lokasi Rak',
                                  stock as 'Stock',
                                  bahasa as 'Bahasa'
                                  FROM koleksi;"
        sqlRead = sqlCommand.ExecuteReader

        result.Load(sqlRead)
        sqlRead.Close()
        dbConn.Close()
        Return result

    End Function

    Public Function AddDataKoleksiDatabase(dir_gambar As String,
                                           nama_koleksi As String,
                                           jenis_koleksi As String,
                                           penerbit_koleksi As String,
                                           deskripsi_koleksi As String,
                                           tahun_terbit As String,
                                           lokasi_rak As String,
                                           tanggal_masuk_koleksi As Date,
                                           stock_koleksi As Integer,
                                           bahasa_koleksi As String,
                                           ketegori_koleksi As String)
        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
                                  + "password=" + password + ";" + "database =" + database
        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "INSERT INTO koleksi(nama_koleksi, dir_gambar, 
                        deskripsi, penerbit, jenis_koleksi, 
                        tahun_terbit, lokasi, tanggal_masuk_koleksi,
                        stock, bahasa, kategori) VALUE('" _
            & nama_koleksi & "', '" _
            & dir_gambar & "', '" _
            & deskripsi_koleksi & "', '" _
            & penerbit_koleksi & "', '" _
            & jenis_koleksi & "', '" _
            & tahun_terbit & "', '" _
            & lokasi_rak & "', '" _
            & tanggal_masuk_koleksi.ToString("yyyy/MM/dd") & "', " _
            & stock_koleksi & ", '" _
            & bahasa_koleksi & "', '" _
            & ketegori_koleksi & "');"

            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader
            dbConn.Close()

            sqlRead.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try
    End Function

    Public Function GetDataKoleksiByID(ID As Integer) As List(Of String)
        Dim result As New List(Of String)
        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
                                  + "password=" + password + ";" + "database =" + database

        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT nama_koleksi, dir_gambar,
                                  deskripsi, penerbit, jenis_koleksi,
                                  tahun_terbit, lokasi,
                                  tanggal_masuk_koleksi,
                                  stock, bahasa, kategori
                                  FROM koleksi 
                                  WHERE id_koleksi=" & ID & ";"

        sqlRead = sqlCommand.ExecuteReader

        While sqlRead.Read
            Dim i = 0
            While i < 11
                result.Add(sqlRead.GetString(i).ToString())
                i += 1
            End While
        End While

        sqlRead.Close()
        dbConn.Close()
        Return result

    End Function

    Public Function UpdateDataKoleksiByIDDatabase(ID As Integer,
                                                  dir_gambar As String,
                                                  nama_koleksi As String,
                                                  jenis_koleksi As String,
                                                  penerbit_koleksi As String,
                                                  deskripsi_koleksi As String,
                                                  tahun_terbit As String,
                                                  lokasi_rak As String,
                                                  tanggal_masuk As Date,
                                                  stock_koleksi As Integer,
                                                  bahasa_koleksi As String,
                                                  kategori_koleksi As String)

        dbConn.ConnectionString = "server =" + server + ";user id=" + username + ";password=" _
                                  + password + ";database =" + database
        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "UPDATE koleksi SET " &
                      "nama_koleksi='" & nama_koleksi & "', " &
                      "dir_gambar='" & dir_gambar & "'," &
                      "deskripsi='" & deskripsi_koleksi & "', " &
                      "penerbit='" & penerbit_koleksi & "', " &
                      "jenis_koleksi='" & jenis_koleksi & "', " &
                      "tahun_terbit='" & tahun_terbit & "', " &
                      "lokasi='" & lokasi_rak & "', " &
                      "tanggal_masuk='" & tanggal_masuk.ToString("yyyy/MM/dd") & "', " &
                      "stcok=" & stock_koleksi & "," &
                      "bahasa='" & bahasa_koleksi & "', " &
                      "kategori='" & kategori_koleksi & "' " &
                      "WHERE id_koleksi=" & ID & ";"
            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader
            dbConn.Close()
            sqlRead.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            Return ex.Message

        Finally
            dbConn.Dispose()

        End Try
    End Function


    Public Function DeleteDataKoleksiByIDDatabase(ID As Integer)
        dbConn.ConnectionString = "server =" + server + ";user id =" + username _
                                  + ";password =" + password + ";database =" + database
        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "DELETE FROM koleksi WHERE id_koleksi='" & ID & "';"

            Debug.WriteLine(sqlQuery)
            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader
            dbConn.Close()

            sqlRead.Close()
            dbConn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try
    End Function

End Class
