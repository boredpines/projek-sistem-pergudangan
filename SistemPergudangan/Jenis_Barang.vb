Imports System.Security.Cryptography.X509Certificates
Imports System.Text
Imports System.Threading
Imports MySql.Data.MySqlClient
Imports Mysqlx
Imports Mysqlx.XDevAPI.Common

Public Class Jenis_Barang
    Private IdJenis As Integer
    Private NamaJenis As String
    Private SatuanJenis As String

    Public Shared Functions
    Public Shared Selected As String


    Public Shared DbConn As New MySqlConnection
    Public Shared sqlCommand As New MySqlCommand
    Public Shared sqlRead As MySqlDataReader
    Private sqlQuery As String

    'Fungsi GS
    Public Property GSIdJenis() As Integer
        Get
            Return IdJenis
        End Get
        Set(ByVal value As Integer)
            IdJenis = value
        End Set
    End Property
    Public Property GSNamaJenis() As String
        Get
            Return NamaJenis
        End Get
        Set(ByVal value As String)
            NamaJenis = value
        End Set
    End Property

    Public Property GSSatuanJenis() As String
        Get
            Return SatuanJenis
        End Get
        Set(ByVal value As String)
            SatuanJenis = value
        End Set
    End Property

    'Fungsi Database
    Public Function AddJenisTable(IdJenis As Integer,
                                    NamaJenis As String,
                                    SatuanJenis As String
                                  )
        Try
            DbConn = New MySqlConnection("Data Source=localhost;user id=root;password=;database=SistemPergudangan;Convert Zero Datetime=True;Allow Zero Datetime=True")
            DbConn.Open()
            sqlQuery = "INSERT INTO jenisbarang(IdJenis, NamaJenis, SatuanJenis) VALUES ( '','" & NamaJenis & "','" & SatuanJenis & "')"
            Try
                sqlCommand = New MySqlCommand(sqlQuery, DbConn)
                sqlRead = sqlCommand.ExecuteReader()
                sqlRead.Close()
                MsgBox("Data inserted.")
            Catch ex As Exception
                MsgBox("Failed to insert data: " & ex.Message.ToString())
            End Try
        Catch ex As Exception
            sqlRead.Close()
        Catch ex As Exception
            MsgBox("Connection Error: " & ex.Message.ToString)
        End Try
    End Function

    Public Function GetDataJenisDatabase() As DataTable
        Dim result As New DataTable

        DbConn = New MySqlConnection("Data Source=localhost;user id=root;password=;database=SistemPergudangan;Convert Zero Datetime=True;Allow Zero Datetime=True")
        Try
            DbConn.Open()
            sqlQuery = "SELECT IdJenis AS 'IdJenis',
                                  NamaJenis AS 'NamaJenis',
                                  SatuanJenis AS 'SatuanJenis'
                                  FROM jenisbarang"
            Try
                sqlCommand = New MySqlCommand(sqlQuery, DbConn)
                sqlRead = sqlCommand.ExecuteReader
                result.Load(sqlRead)
                Return result
            Catch ex As Exception
                MsgBox("Problem loading data: " & ex.Message.ToString)
            End Try
            sqlRead.Close()
        Catch ex As Exception
            MsgBox("Connection Error: " & ex.Message.ToString)
        End Try

    End Function

    Public Function GetDataNama()
        Dim result As New List(Of String)

        DbConn = New MySqlConnection("Data Source=localhost;user id=root;password=;database=SistemPergudangan;Convert Zero Datetime=True;Allow Zero Datetime=True")
        Try
            DbConn.Open()
            sqlQuery = "SELECT IdJenis FROM jenisbarang"
            Try
                sqlCommand = New MySqlCommand(sqlQuery, DbConn)
                sqlRead = sqlCommand.ExecuteReader

                While sqlRead.Read
                    result.Add(sqlRead.GetString(0))
                End While

                Return result
            Catch ex As Exception
                MsgBox("Problem loading data: " & ex.Message.ToString)
            End Try
            sqlRead.Close()
        Catch ex As Exception
            MsgBox("Connection Error: " & ex.Message.ToString)
        End Try
    End Function

    Public Function GetDataTableById(ID As Integer) As List(Of String)
        Dim result As New List(Of String)

        DbConn = New MySqlConnection("Data Source=localhost;user id=root;password=;database=SistemPergudangan;Convert Zero Datetime=True;Allow Zero Datetime=True")
        Try
            DbConn.Open()
            sqlQuery = "SELECT * FROM jenisbarang WHERE IdJenis='" & ID & "'"
            Try
                sqlCommand = New MySqlCommand(sqlQuery, DbConn)
                sqlRead = sqlCommand.ExecuteReader

                While sqlRead.Read
                    result.Add(sqlRead.GetString(0).ToString())
                    result.Add(sqlRead.GetString(1).ToString())
                    result.Add(sqlRead.GetString(2).ToString())

                End While
                Return result
            Catch ex As Exception
                MsgBox("Problem loading data: " & ex.Message.ToString)
            End Try
            sqlRead.Close()
        Catch ex As Exception
            MsgBox("Connection Error: " & ex.Message.ToString)
        End Try
    End Function

    Public Function UpdateDataJenisByID(IdJenis As Integer,
                                        NamaJenis As String,
                                        SatuanJenis As String)

        DbConn = New MySqlConnection("Data Source=localhost;user id=root;password=;database=SistemPergudangan;Convert Zero Datetime=True;Allow Zero Datetime=True")
        Try
            DbConn.Open()
            sqlCommand.Connection = DbConn

            sqlQuery = "UPDATE jenisbarang SET " _
                        + "IdJenis='" & IdJenis & "'," _
                        + "NamaJenis='" & NamaJenis & "'," _
                        + "SatuanJenis='" & SatuanJenis & "' WHERE idJenis='" & IdJenis & "' "
            Try
                sqlCommand = New MySqlCommand(sqlQuery, DbConn)
                sqlRead = sqlCommand.ExecuteReader
                DbConn.Close()
                sqlRead.Close()
                MsgBox("Data updated.")
            Catch ex As Exception
                MsgBox("Failed to update data: " & ex.Message.ToString())
            Finally
                DbConn.Dispose()
            End Try
            sqlRead.Close()
        Catch ex As Exception
            MsgBox("Connection Error: " & ex.Message.ToString)
        End Try




    End Function
End Class


