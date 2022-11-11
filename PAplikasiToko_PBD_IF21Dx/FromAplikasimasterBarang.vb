Imports System.Data
Imports System.Data.SqlClient
Imports System.Runtime.InteropServices

Public Class FromAplikasimasterBarang
    Dim table As OleDb.OleDbDataAdapter
    Dim data As DataSet
    Dim record As New BindingSource

    Sub KosongkanData()
        txb_kode_barang.Text = ""
        txb_nama_barang.Text = ""
        txb_diskon.Text = ""
        txb_harga_jual.Text = ""
        txb_jumlah_barang.Text = ""
        txb_rusak.Text = ""
        txb_sisa_barang.Text = ""
    End Sub

    Sub tampil()
        tbl_brg.DataSource = Nothing
        tbl_brg.Rows.Clear()
        Try
            Call Koneksi()
            Da = New SqlDataAdapter("select * from barang order by kd_brg asc", Conn)
            Dt = New DataTable
            Da.Fill(Dt)
            For Each row In Dt.Rows
                tbl_brg.Rows.Add(row(0), row(1), row(2), row(3), row(4), row(5), row(6))
            Next
            Dt.Rows.Clear()
        Catch ex As Exception
            MsgBox(ex)
        End Try
        Call KosongkanData()
        txb_kode_barang.MaxLength = 13
        txb_nama_barang.MaxLength = 20
        bt_edit.Enabled = False
    End Sub


    Private Sub bt_tambah_Click(sender As Object, e As EventArgs) Handles bt_tambah.Click
        If txb_kode_barang.Text = "" Then
            MsgBox("Kode Barang Kosong")
        Else
            Call Koneksi()
            Da = New SqlDataAdapter("select kd_brg from barang where kd_brg='" & txb_kode_barang.Text & "'", Conn)
            Dt = New DataTable
            Da.Fill(Dt)
            If Dt.Rows.Count > 0 Then
                MsgBox("Kode Barang sudah terisi !!!")
                Return
            End If

            Call Koneksi()
            Dim InputData As String = "insert into barang values ('" & txb_kode_barang.Text & "','" & txb_nama_barang.Text & "','" & txb_diskon.Text & "','" & txb_harga_jual.Text & "','" & txb_jumlah_barang.Text & "','" & txb_rusak.Text & "','" & txb_sisa_barang.Text & "')"
            Cmd = New SqlCommand(InputData, Conn)
            Cmd.ExecuteNonQuery()
            On Error Resume Next
            MsgBox("Data Berhasil Disimpan")
            Call tampil()
        End If
    End Sub

    Private Sub FromAplikasimasterBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call tampil()
    End Sub


    Private Sub tbl_brg_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles tbl_brg.CellContentDoubleClick
        MsgBox("Kode Barang Terdekripsi?")
        Call KosongkanData()
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim selectedRow = tbl_brg.Rows(e.ColumnIndex)
            Dim d As String
            txb_kode_barang.Text = selectedRow.Cells(0).Value.ToString
            txb_nama_barang.Text = selectedRow.Cells(1).Value.ToString
            txb_diskon.Text = selectedRow.Cells(2).Value.ToString
            txb_harga_jual.Text = selectedRow.Cells(3).Value.ToString
            txb_jumlah_barang.Text = selectedRow.Cells(4).Value.ToString
            txb_rusak.Text = selectedRow.Cells(5).Value.ToString
            txb_sisa_barang.Text = selectedRow.Cells(6).Value.ToString
            d = selectedRow.Cells(2).Value.ToString
            Dim x As String = ""
            Dim cKalimat As String = ""
            For i = 1 To Len(d)
                x = Mid(d, i, 1)
                x = Chr(Asc(x) - 3)
                cKalimat = cKalimat + x
            Next
            cKalimat = cKalimat + x
            txb_sisa_barang.Text = cKalimat
            txb_harga_jual.Text = selectedRow.Cells(3).Value.ToString
            bt_tambah.Enabled = False
            bt_edit.Enabled = True
        End If
    End Sub

    Private Sub bt_edit_Click(sender As Object, e As EventArgs) Handles bt_edit.Click
        If txb_kode_barang.Text = "" Then
            MsgBox("Kode Barang Kosong")
        Else
            Call Koneksi()
            Dim EditData As String = "Update barang Set nm_barang='" & txb_nama_barang.Text & "',diskon='" & txb_diskon.Text & "',hrg_jual='" & txb_harga_jual.Text & "',jumlah='" & txb_jumlah_barang.Text & "',rusak='" & txb_rusak.Text & "',sisa='" & txb_sisa_barang.Text & "' WHERE kd_brg='" & txb_kode_barang.Text & "'"
            Cmd = New SqlCommand(EditData, Conn)
            Cmd.ExecuteNonQuery()
            On Error Resume Next
            MsgBox("Data Berhasil di Ubah")
            Call tampil()
            bt_tambah.Enabled = True
            bt_edit.Enabled = False
        End If
    End Sub

    Private Sub bt_hapus_Click(sender As Object, e As EventArgs) Handles bt_hapus.Click
        If txb_kode_barang.Text = "" Then
            MsgBox("Kode Barang Kosong")
        Else
            Call Koneksi()
            Dim HapusData As String = "Delete barang where kd_brg='" & txb_kode_barang.Text & "'"
            Cmd = New SqlCommand(HapusData, Conn)
            Cmd.ExecuteNonQuery()
            On Error Resume Next
            MsgBox("Data Berhasil di Hapus")
            Call tampil()
        End If
    End Sub



    Private Sub txb_kode_barang_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txb_kode_barang.KeyPress
        If e.KeyChar = Chr(13) Then
            Call Koneksi()
            Cmd = New SqlCommand("Select * from barang where kd_brg = '" & txb_kode_barang.Text & "'", Conn)
            Rd = Cmd.ExecuteReader
            Rd.Read()
            If Rd.HasRows Then
                txb_nama_barang.Text = Rd.Item(1)
                txb_diskon.Text = Rd.Item("diskon")
                txb_harga_jual.Text = Rd.Item("hrg_jual")
                txb_jumlah_barang.Text = Rd.Item("jumlah")
                txb_rusak.Text = Rd.Item("rusak")
                txb_sisa_barang.Text = Rd.Item("sisa")
            End If
            MsgBox("data tidak ditemukan")
            bt_tambah.Enabled = False
            bt_edit.Enabled = True
        End If
    End Sub

    Private Sub bt_keluar_Click(sender As Object, e As EventArgs) Handles bt_keluar.Click
        Me.Close()
    End Sub

    Private Sub btn_bersih_Click(sender As Object, e As EventArgs) Handles btn_bersih.Click
        Call KosongkanData()
    End Sub

End Class
