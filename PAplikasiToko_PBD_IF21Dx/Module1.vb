Imports System.Data.SqlClient
Module Module1
    Public Conn As SqlConnection
    Public Da As SqlDataAdapter
    Public Rd As SqlDataReader
    Public Cmd As SqlCommand
    Public Ds As DataSet
    Public Dt As DataTable
    Public MyDb, namaServer, database As String
    Public vMessage As String

    Public Sub Koneksi()
        namaServer = "DESKTOP-DF5KEJ6"
        database = "db_toko_if21dx"
        MyDb = "data source=" & namaServer & ";initial catalog=" & database & ";integrated security =true"
        Conn = New SqlConnection(MyDb)
        Try
            If Conn.State = ConnectionState.Closed Then
                Conn.Open()
            End If
        Catch ex As Exception
            MsgBox("Data base gagal koneksi karena " & ex.Message)
        End Try
    End Sub
End Module