﻿Imports System.Data.Common
Imports System.IO
Imports System.Runtime.Intrinsics.Arm
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient
Public Class MainMenu
    Public Shared datagudang As FungsiBarang
    Public Shared listKoleksi As New List(Of String)
    Public Shared koleksiterpilih As String
    Dim selecteddatatable
    Public Shared selectedTableBarang As Integer
    Public Shared selectedTableBarangNama As String

    Public Shared dbconn As New MySqlConnection
    Public Shared sqlcommand As New MySqlCommand
    Public Shared sqlread As MySqlDataReader
    Private sqlquery As String

    Private server As String = "localhost"
    Private username As String = "root"
    Private password As String = ""
    Private database As String = "gudang"


    Public Sub updateDataTableArrayList()
        DataGridBarang.Rows.Clear()
        For Each rowKoleksi In datagudang.getBarangDataTable()
            Dim dataTable As String() = {rowKoleksi(1),
                                         rowKoleksi(2),
                                         rowKoleksi(3),
                                         rowKoleksi(4)
            }
            DataGridBarang.Rows.Add(dataTable)
        Next
    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        datagudang = New FungsiBarang()

        ReloadDataTableDatabase()
    End Sub

    Private Sub MainMenu_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ReloadDataTableDatabase()
    End Sub

    Private Sub DataGridBarang_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridBarang.CellClick
        'selecteddatatable = DataGridBarang.CurrentRow.Index
        Dim index As Integer = e.RowIndex
        Dim SelectedRow As DataGridViewRow
        SelectedRow = DataGridBarang.Rows(index)

        selectedTableBarang = SelectedRow.Cells(0).Value
        selectedTableBarangNama = SelectedRow.Cells(3).Value
    End Sub

    Private Sub ReloadDataTableDatabase()
        DataGridBarang.DataSource = datagudang.GetDataBarangDatabase()
    End Sub

    Private Sub BtnSelect_Click_1(sender As Object, e As EventArgs) Handles BtnSelect.Click
        Try
            Dim selectedBarang As List(Of String) = datagudang.GetDataKoleksiByIDDatabase(selectedTableBarang)

            datagudang.GSIDBarang = selectedBarang(1)
            datagudang.GSIDJenis = selectedBarang(2)
            datagudang.GSNama = selectedBarang(3)
            datagudang.GSStock = selectedBarang(4)

            Dim InfoBarang = New InfoBarang()
            InfoBarang.Show()
        Catch ex As Exception
            MessageBox.Show("...")

        End Try
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Dim formTambahBarang = New TambahBarang
        formTambahBarang.Show()
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Try
            Dim selectedBarang As List(Of String) = datagudang.GetDataKoleksiByIDDatabase(selectedTableBarang)

            datagudang.GSIDBarang = selectedBarang(1)
            datagudang.GSIDJenis = selectedBarang(2)
            datagudang.GSNama = selectedBarang(3)
            datagudang.GSStock = selectedBarang(4)

            Dim UpdateBarang = New UpdateBarang()
            UpdateBarang.Show()
        Catch ex As Exception
            MessageBox.Show("Data berhasil di update")

        End Try
    End Sub

    Private Sub BtnRemove_Click(sender As Object, e As EventArgs) Handles BtnRemove.Click

        Try
            Dim selectedBarang As List(Of String) = datagudang.GetDataKoleksiByIDDatabase(selectedTableBarang)

            datagudang.GSIDBarang = selectedBarang(1)
            datagudang.GSIDJenis = selectedBarang(2)
            datagudang.GSNama = selectedBarang(3)
            datagudang.GSStock = selectedBarang(4)

            Dim Hapus = New HapusBarang()
            Hapus.Show()

        Catch ex As Exception
            MessageBox.Show("..")

        End Try
    End Sub

    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampildata()
    End Sub

    Public Sub tampildata()

        dbconn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
       + "password=" + password + ";" + "database=" + database

        Try
            dbconn.Open()
            sqlcommand.Connection = dbconn
            sqlquery = "SELECT Nama from barang order by ID"

            sqlcommand = New MySqlCommand(sqlquery, dbconn)
            sqlread = sqlcommand.ExecuteReader

            While sqlread.Read
                ComboBox1.Items.Add(sqlread("Nama"))
            End While
            sqlread.Close()
            dbconn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            dbconn.Dispose()
        End Try
    End Sub

End Class
