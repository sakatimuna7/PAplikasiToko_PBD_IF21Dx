Imports System.Data
Imports System.Data.SqlClient
Imports System.Runtime.InteropServices

Public Class DanFromAplikasimasterBarang
    Dim table As OleDb.OleDbDataAdapter
    Dim data As DataSet
    Dim record As New BindingSource

    'kode pertamakali di load
    Private Sub FromAplikasimasterBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call tampil("")
        ' buat batasan char
        txb_kode_barang.MaxLength = 10
        txb_nama_barang.MaxLength = 20
        ' buat filer texbox
        txb_kode_barang.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        txb_cari.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
    End Sub

    'sub untuk mengkosongkan texbox
    Sub KosongkanData()
        txb_kode_barang.Enabled = True
        bt_tambah.Enabled = True
        bt_edit.Enabled = False
        txb_kode_barang.Text = ""
        txb_nama_barang.Text = ""
        txb_diskon.Text = ""
        txb_harga_jual.Text = ""
        txb_jumlah_barang.Text = ""
        txb_rusak.Text = ""
        txb_sisa_barang.Text = ""
        txb_cari.Text = ""
    End Sub

    'fungsi untuk menampilkan data di tabel
    Function tampil(kunci As String)
        tbl_brg.DataSource = Nothing
        tbl_brg.Rows.Clear()
        Try
            Call Koneksi()
            If kunci = "" Then
                Da = New SqlDataAdapter("select * from " & dan_barang & " order by dan_kd_brg asc", Conn)
            End If
            Da = New SqlDataAdapter("select * from " & dan_barang & " where dan_kd_brg LIKE '%" & kunci & "%' order by dan_kd_brg asc", Conn)
            Dt = New DataTable
            Da.Fill(Dt)
            If Dt.Rows.Count > 0 Then
                For Each row In Dt.Rows
                    tbl_brg.Rows.Add(row(0), row(1), row(2), dan_f_to_mony(row(3)), row(4), row(5), row(6))
                Next
                Dt.Rows.Clear()
            End If
            bt_edit.Enabled = False
            Return False
        Catch ex As Exception
            MsgBox(ex.ToString)
            Return False
        End Try
    End Function

    Private Sub bt_tambah_Click(sender As Object, e As EventArgs) Handles bt_tambah.Click
        Try
            If txb_kode_barang.Text = "" Then
                MsgBox("Kode Barang Kosong", MsgBoxStyle.Exclamation, "Perhatian !!!")
            Else
                'cek jika kode sudah pernag terisi atau belum
                Call Koneksi()
                Da = New SqlDataAdapter("select dan_kd_brg from " & dan_barang & " where dan_kd_brg='" & txb_kode_barang.Text & "'", Conn)
                Dt = New DataTable
                Da.Fill(Dt)
                If Dt.Rows.Count > 0 Then
                    MsgBox("Kode Barang sudah terisi !!!", MsgBoxStyle.Exclamation, "Perhatian !!!")
                    Return
                End If
                'eksekusi program
                Call Koneksi()
                Dim InputData As String = "insert into " & dan_barang & " values ('" & txb_kode_barang.Text & "','" & txb_nama_barang.Text & "','" & txb_diskon.Text & "','" & dan_m_to_float(txb_harga_jual.Text) & "','" & txb_jumlah_barang.Text & "','" & txb_rusak.Text & "','" & txb_sisa_barang.Text & "')"
                Cmd = New SqlCommand(InputData, Conn)
                Cmd.ExecuteNonQuery()
                MsgBox("Data Berhasil Disimpan", MsgBoxStyle.Information, "Pesan !!!")
                Call tampil("")
                Call KosongkanData()
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Error !!!")
        End Try
    End Sub

    Private Sub bt_edit_Click(sender As Object, e As EventArgs) Handles bt_edit.Click
        Try
            If txb_kode_barang.Text = "" Then
                MsgBox("Kode Barang Kosong", MsgBoxStyle.Exclamation, "Perhatian !!!")
            Else
                vMessage = MsgBox("Apakah anda yakin ingin mengubah data " & txb_kode_barang.Text & " ini ?", vbExclamation + vbYesNo, "perhatian")
                If vMessage = vbNo Then Exit Sub
                Call Koneksi()
                Dim EditData As String = "Update " & dan_barang & " Set dan_nm_barang='" & txb_nama_barang.Text & "',dan_diskon='" & txb_diskon.Text & "',dan_hrg_jual='" & dan_m_to_float(txb_harga_jual.Text) & "',dan_jumlah='" & txb_jumlah_barang.Text & "',dan_rusak='" & txb_rusak.Text & "',dan_sisa='" & txb_sisa_barang.Text & "' WHERE dan_kd_brg='" & txb_kode_barang.Text & "'"
                Cmd = New SqlCommand(EditData, Conn)
                Cmd.ExecuteNonQuery()
                MsgBox("Data Berhasil di Ubah", MsgBoxStyle.Information, "Pesan !!!")
                Call tampil("")
                Call KosongkanData()
                bt_tambah.Enabled = True
                bt_edit.Enabled = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Error !!!")
        End Try
    End Sub

    Private Sub bt_hapus_Click(sender As Object, e As EventArgs) Handles bt_hapus.Click
        Try
            If txb_kode_barang.Text = "" Then
                MsgBox("Kode Barang Kosong", MsgBoxStyle.Exclamation, "Perhatian !!!")
            Else
                vMessage = MsgBox("Apakah anda yakin ingin menghapus data " & txb_kode_barang.Text & " ini ?", vbExclamation + vbYesNo, "perhatian")
                If vMessage = vbNo Then Exit Sub
                Call Koneksi()
                Dim HapusData As String = "Delete " & dan_barang & " where dan_kd_brg='" & txb_kode_barang.Text & "'"
                Cmd = New SqlCommand(HapusData, Conn)
                Cmd.ExecuteNonQuery()
                MsgBox("Data Berhasil di Hapus")
                Call tampil("")
                Call KosongkanData()
            End If
        Catch ex As Exception
            MsgBox("Barang ini Tidak Bisa Dihapus Dikarenakan Telah Terjual", MsgBoxStyle.Critical, "Error !!!")
        End Try      
    End Sub

    Private Sub bt_keluar_Click(sender As Object, e As EventArgs) Handles bt_keluar.Click
        Me.Close()
    End Sub

    Private Sub btn_bersih_Click(sender As Object, e As EventArgs) Handles btn_bersih.Click
        Call KosongkanData()
    End Sub

    '=========================== cari kode barang 
    Private Sub txb_cari_TextChanged(sender As Object, e As EventArgs) Handles txb_cari.TextChanged
        Call tampil(txb_cari.Text)
        Try
            If txb_cari.TextLength = 0 Then
                KosongkanData()
                Return
            End If
            Dim selectedRow = tbl_brg.Rows(0)
            txb_kode_barang.Text = selectedRow.Cells(0).Value.ToString
            txb_nama_barang.Text = selectedRow.Cells(1).Value.ToString
            txb_diskon.Text = selectedRow.Cells(2).Value.ToString
            txb_harga_jual.Text = dan_f_to_mony(selectedRow.Cells(3).Value.ToString)
            txb_jumlah_barang.Text = selectedRow.Cells(4).Value.ToString
            txb_rusak.Text = selectedRow.Cells(5).Value.ToString
            txb_sisa_barang.Text = selectedRow.Cells(6).Value.ToString
            bt_edit.Enabled = True
            bt_tambah.Enabled = False
            txb_kode_barang.Enabled = False
        Catch ex As Exception
            MsgBox("Kode tidak ditemukan !!!", MsgBoxStyle.Exclamation, "Perhatian !!!")
        End Try
    End Sub

    Private Sub txb_cari_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txb_cari.KeyPress
        If e.KeyChar = Chr(13) Then
            txb_nama_barang.Focus()
        End If
        ' membatasi karakter yang di input
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyz1234567890"
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub tbl_brg_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles tbl_brg.CellClick
        Call KosongkanData()
        Try
            If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
                Dim selectedRow = tbl_brg.Rows(e.RowIndex)
                txb_kode_barang.Text = selectedRow.Cells(0).Value.ToString
                txb_nama_barang.Text = selectedRow.Cells(1).Value.ToString
                txb_diskon.Text = selectedRow.Cells(2).Value.ToString
                txb_harga_jual.Text = dan_f_to_mony(selectedRow.Cells(3).Value.ToString)
                txb_jumlah_barang.Text = selectedRow.Cells(4).Value.ToString
                txb_rusak.Text = selectedRow.Cells(5).Value.ToString
                txb_sisa_barang.Text = selectedRow.Cells(6).Value.ToString
                bt_tambah.Enabled = False
                bt_edit.Enabled = True
                txb_kode_barang.Enabled = False
            End If
            MsgBox("Kode Barang Terpilih !", MsgBoxStyle.Information, "Pesan !!!")
        Catch ex As Exception
            MsgBox("Data yang dipilih kosong !!!", MsgBoxStyle.Exclamation, "Perhatian !!!")
        End Try
    End Sub

    '============= jika enter ditekan maka next texbox

    Private Sub txb_kode_barang_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txb_kode_barang.KeyPress
        If e.KeyChar = Chr(13) Then
            'cek jika kode sudah pernag terisi atau belum
            Call Koneksi()
            Da = New SqlDataAdapter("select dan_kd_brg from " & dan_barang & " where dan_kd_brg='" & txb_kode_barang.Text & "'", Conn)
            Dt = New DataTable
            Da.Fill(Dt)
            If Dt.Rows.Count > 0 Then
                MsgBox("Kode Barang sudah terisi !!!", MsgBoxStyle.Exclamation, "Perhatian !!!")
                txb_kode_barang.Focus()
                Return
            End If
            'jika kode lebih dari 10 karakter
            'jika kode aman
            txb_nama_barang.Focus()
        End If
        ' membatasi karakter yang di input
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyz1234567890"
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txb_nama_barang_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txb_nama_barang.KeyPress
        If e.KeyChar = Chr(13) Then
            txb_diskon.Focus()
        End If
    End Sub

    Private Sub txb_diskon_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txb_diskon.KeyPress
        If e.KeyChar = Chr(13) Then
            txb_harga_jual.Focus()
        End If
        ' membatasi karakter yang di input
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "1234567890"
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub


    Private Sub txb_harga_jual_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txb_harga_jual.KeyPress
        If e.KeyChar = Chr(13) Then
            txb_jumlah_barang.Focus()
        End If
        ' membatasi karakter yang di input
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "1234567890"
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txb_jumlah_barang_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txb_jumlah_barang.KeyPress
        If e.KeyChar = Chr(13) Then
            txb_rusak.Focus()
        End If
        ' membatasi karakter yang di input
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "1234567890"
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txb_rusak_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txb_rusak.KeyPress
        Try
            If e.KeyChar = Chr(13) Then
                txb_sisa_barang.Focus()
                Dim intgr As Integer
                'pengecekan
                If Integer.TryParse(txb_jumlah_barang.Text, intgr) = False Then
                    txb_jumlah_barang.Text = "0"
                End If
                If Integer.TryParse(txb_rusak.Text, intgr) = False Then
                    txb_rusak.Text = "0"
                End If
                'membuat sisa barang otomatis
                Dim jum, brg, rusak As Integer
                brg = Convert.ToInt32(txb_jumlah_barang.Text)
                rusak = Convert.ToInt32(txb_rusak.Text)
                jum = brg - rusak
                txb_sisa_barang.Text = jum.ToString
            End If
            ' membatasi karakter yang di input
            If Not (Asc(e.KeyChar) = 8) Then
                Dim allowedChars As String = "1234567890"
                If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                    e.KeyChar = ChrW(0)
                    e.Handled = True
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Error !!!")
        End Try
    End Sub

    Private Sub txb_sisa_barang_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txb_sisa_barang.KeyPress
        If e.KeyChar = Chr(13) Then
            If bt_edit.Enabled = True Then
                bt_edit.Focus()
            ElseIf bt_tambah.Enabled = True Then
                bt_tambah.Focus()
            End If
        End If
    End Sub

End Class