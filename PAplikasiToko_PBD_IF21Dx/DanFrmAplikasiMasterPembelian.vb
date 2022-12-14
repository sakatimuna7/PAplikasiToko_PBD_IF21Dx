Imports System.Data
Imports System.Data.SqlClient
Imports System.Runtime.InteropServices
Public Class DanFrmAplikasiMasterPembelian

    '============== deklarasi
    Dim table As OleDb.OleDbDataAdapter
    Dim data As DataSet
    Dim record As New BindingSource
    Dim DataCollection As New AutoCompleteStringCollection()

    '============= function dan sub
    'sub untuk mengkosongkan texbox
    Sub KosongkanData()
        dan_txb_kdtrans.Enabled = True
        dan_bt_tambah.Enabled = True
        dan_bt_edit.Enabled = False
        dan_bt_hapus.Enabled = False
        dan_txb_cari.Text = ""
        dan_txb_kdtrans.Text = ""
        dan_dtp_trans.Value = Date.Today
        dan_txb_ks.Text = ""
        dan_txb_kb.Text = ""
        dan_txb_jumbel.Text = ""
        dan_txb_hrgbel.Text = ""
    End Sub

    'fungsi untuk menampilkan data di tabel
    Function tampil(kunci As String)
        dan_tbl_pembelian.DataSource = Nothing
        dan_tbl_pembelian.Rows.Clear()
        Try
            Call Koneksi()
            If kunci = "" Then
                Da = New SqlDataAdapter("select * from " & dan_pembelian & " order by dan_kd_beli asc", Conn)
            End If
            Da = New SqlDataAdapter("select * from " & dan_pembelian & " where dan_kd_beli LIKE '%" & kunci & "%' or dan_tgl_beli LIKE '%" & kunci & "%' order by dan_kd_beli asc", Conn)
            Dt = New DataTable
            Da.Fill(Dt)
            For Each row In Dt.Rows
                dan_tbl_pembelian.Rows.Add(row(0), row(1), row(2), row(3), row(4), dan_f_to_mony(row(5)))
            Next
            Dt.Rows.Clear()
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, "Error !!!")
        End Try
        dan_bt_edit.Enabled = False
        dan_bt_hapus.Enabled = False
        Return False
    End Function


    '============ load pertama
    Private Sub DanFromMasterPembelian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dan_txb_kdtrans.MaxLength = 10
        dan_txb_ks.MaxLength = 10
        dan_txb_kb.MaxLength = 10
        ' buat filer texbox
        dan_txb_kdtrans.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        dan_txb_cari.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        dan_txb_ks.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        dan_txb_kb.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        dan_tbl_pembelian.ReadOnly = True
        'merubah format date time piker
        dan_dtp_trans.Format = DateTimePickerFormat.Custom
        dan_dtp_trans.CustomFormat = "dd/MM/yyyy"
        'autocomplate kode supplier
        dan_txb_ks.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        dan_txb_ks.AutoCompleteSource = AutoCompleteSource.CustomSource
        DataCollection = dan_add_ks_Items(dan_txb_ks.Text)
        dan_txb_ks.AutoCompleteCustomSource = DataCollection
        'autocomplate kode barang
        dan_txb_kb.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        dan_txb_kb.AutoCompleteSource = AutoCompleteSource.CustomSource
        DataCollection = dan_add_kb_Items(dan_txb_kb.Text)
        dan_txb_kb.AutoCompleteCustomSource = dan_add_kb_Items(dan_txb_kb.Text)
        Call tampil("")
        Call KosongkanData()
    End Sub

    '=========================== pencarian 
    Private Sub dan_txb_cari_TextChanged(sender As Object, e As EventArgs) Handles dan_txb_cari.TextChanged
        Call tampil(dan_txb_cari.Text)
        Try
            If dan_txb_cari.TextLength = 0 Then
                KosongkanData()
                Return
            End If
            Dim selectedRow = dan_tbl_pembelian.Rows(0)
            dan_txb_kdtrans.Text = selectedRow.Cells(0).Value.ToString
            dan_dtp_trans.Value = selectedRow.Cells(1).Value.ToString
            dan_txb_ks.Text = selectedRow.Cells(2).Value.ToString
            dan_txb_kb.Text = selectedRow.Cells(3).Value.ToString
            dan_txb_jumbel.Text = selectedRow.Cells(4).Value.ToString
            dan_txb_hrgbel.Text = dan_f_to_mony(selectedRow.Cells(5).Value.ToString)
            dan_bt_edit.Enabled = True
            dan_bt_hapus.Enabled = True
            dan_bt_tambah.Enabled = False
            dan_txb_kdtrans.Enabled = False
        Catch ex As Exception
            MsgBox("Kode tidak ditemukan !!!", MsgBoxStyle.Exclamation, "Perhatian !!!")
        End Try
    End Sub
    Private Sub dan_txb_cari_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dan_txb_cari.KeyPress
        If e.KeyChar = Chr(13) Then
            dan_txb_kdtrans.Focus()
            Return
        End If
        ' membatasi karakter yang di input
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyz1234567890 "
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    '========= jika table di klik atau dipilih

    Private Sub dan_tbl_pembelian_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dan_tbl_pembelian.CellClick
        Call KosongkanData()
        Try
            If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
                Dim selectedRow = dan_tbl_pembelian.Rows(e.RowIndex)
                dan_txb_kdtrans.Text = selectedRow.Cells(0).Value.ToString
                dan_dtp_trans.Value = selectedRow.Cells(1).Value.ToString
                dan_txb_ks.Text = selectedRow.Cells(2).Value.ToString
                dan_txb_kb.Text = selectedRow.Cells(3).Value.ToString
                dan_txb_jumbel.Text = selectedRow.Cells(4).Value.ToString
                dan_txb_hrgbel.Text = dan_f_to_mony(selectedRow.Cells(5).Value.ToString)
                dan_bt_edit.Enabled = True
                dan_bt_hapus.Enabled = True
                dan_bt_tambah.Enabled = False
                dan_txb_kdtrans.Enabled = False
            End If
            MsgBox("Kode Barang Terpilih !", MsgBoxStyle.Information, "Pesan !!!")
        Catch ex As Exception
            MsgBox("Data yang dipilih kosong !!!", MsgBoxStyle.Exclamation, "Perhatian !!!")
        End Try
    End Sub

    '========= Button / tombol aksi
    Private Sub dan_bt_simpan_Click(sender As Object, e As EventArgs) Handles dan_bt_tambah.Click
        Try
            If dan_txb_kdtrans.Text = "" And dan_txb_ks.Text = "" And dan_txb_kb.Text = "" And dan_txb_jumbel.Text = "" And dan_txb_hrgbel.Text = "" Then
                MsgBox("Pastikan Semua Kolom Terisi", MsgBoxStyle.Exclamation, "Perhatian !!!")
            Else
                'cek jika kode sudah pernah terisi atau belum
                Call Koneksi()
                Da = New SqlDataAdapter("select dan_kd_beli from " & dan_pembelian & " where dan_kd_beli='" & dan_txb_kdtrans.Text & "'", Conn)
                Dt = New DataTable
                Da.Fill(Dt)
                If Dt.Rows.Count > 0 Then
                    MsgBox("Kode Barang tidak boleh sama !!!", MsgBoxStyle.Critical, "Error !!!")
                    Return
                End If
                'cek jika kode supplier terdaftar/ tidak
                If dan_cek_ks(dan_txb_ks.Text) Then
                    MsgBox("Kode Supplier tidak terdaftar !!!", MsgBoxStyle.Critical, "Error !!!")
                    dan_txb_ks.Focus()
                    Return
                End If
                'cek jika kode barang terdaftar/ tidak
                If dan_cek_kb(dan_txb_kb.Text) Then
                    MsgBox("Kode Barang tidak terdaftar !!!", MsgBoxStyle.Critical, "Error !!!")
                    dan_txb_kb.Focus()
                    Return
                End If
                'eksekusi program
                Call Koneksi()
                Dim InputData As String = "insert into " & dan_pembelian & " values ('" & dan_txb_kdtrans.Text & "',convert(date,'" & dan_dtp_trans.Value.Date & "',103),'" & dan_txb_ks.Text & "','" & dan_txb_kb.Text & "','" & dan_txb_jumbel.Text & "','" & dan_m_to_float(dan_txb_hrgbel.Text) & "')"
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

    Private Sub dan_bt_edit_Click(sender As Object, e As EventArgs) Handles dan_bt_edit.Click
        Try
            If dan_txb_kdtrans.Text = "" And dan_txb_ks.Text = "" And dan_txb_kb.Text = "" And dan_txb_jumbel.Text = "" And dan_txb_hrgbel.Text = "" Then
                MsgBox("Kode Pegawai Kosong", MsgBoxStyle.Exclamation, "Perhatian !!!")
            Else
                vMessage = MsgBox("Apakah anda yakin ingin mengubah data " & dan_txb_kdtrans.Text & " ini ?", vbExclamation + vbYesNo, "perhatian")
                If vMessage = vbNo Then Exit Sub
                Call Koneksi()
                Dim EditData As String = "Update " & dan_pembelian & " Set dan_kd_beli='" & dan_txb_kdtrans.Text & "',dan_tgl_beli=convert(date,'" & dan_dtp_trans.Value.Date & "',103),dan_kd_sup='" & dan_txb_ks.Text & "',dan_kd_brg='" & dan_txb_kb.Text & "',dan_jum_beli='" & dan_txb_jumbel.Text & "',dan_hrg_beli='" & dan_m_to_float(dan_txb_hrgbel.Text) & "' WHERE dan_kd_beli='" & dan_txb_kdtrans.Text & "'"
                Cmd = New SqlCommand(EditData, Conn)
                Cmd.ExecuteNonQuery()
                MsgBox("Data Berhasil di Ubah", MsgBoxStyle.Information, "Pesan !!!")
                Call tampil("")
                Call KosongkanData()
                dan_bt_tambah.Enabled = True
                dan_bt_edit.Enabled = False
                dan_bt_hapus.Enabled = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Error !!!")
        End Try
    End Sub

    Private Sub dan_bt_hapus_Click(sender As Object, e As EventArgs) Handles dan_bt_hapus.Click
        Try
            If dan_txb_kdtrans.Text = "" Then
                MsgBox("Kode Transaksi Kosong", MsgBoxStyle.Exclamation, "Perhatian !!!")
            Else
                vMessage = MsgBox("Apakah anda yakin ingin menghapus data " & dan_txb_kdtrans.Text & " ini ?", vbExclamation + vbYesNo, "perhatian")
                If vMessage = vbNo Then Exit Sub
                Call Koneksi()
                Dim HapusData As String = "Delete " & dan_pembelian & " where dan_kd_beli='" & dan_txb_kdtrans.Text & "'"
                Cmd = New SqlCommand(HapusData, Conn)
                Cmd.ExecuteNonQuery()
                MsgBox("Data Berhasil di Hapus", MsgBoxStyle.Information)
                Call tampil("")
                Call KosongkanData()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, "Error !!!")
        End Try
    End Sub

    Private Sub dan_bt_bersih_Click(sender As Object, e As EventArgs) Handles dan_bt_bersih.Click
        Call KosongkanData()
    End Sub

    Private Sub dan_bt_keluar_Click(sender As Object, e As EventArgs) Handles dan_bt_keluar.Click
        vMessage = MsgBox("Apakah anda yakin ingin Keluar ?", vbExclamation + vbYesNo, "Perhatian !!!")
        If vMessage = vbNo Then Exit Sub
        Me.Close()
    End Sub

    '======== fungsi filter dan event texbox

    Private Sub dan_txb_kdtrans_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dan_txb_kdtrans.KeyPress
        If e.KeyChar = Chr(13) Then
            'cek jika kode sudah pernah terisi atau belum
            Call Koneksi()
            Da = New SqlDataAdapter("select dan_kd_beli from " & dan_pembelian & " where dan_kd_beli='" & dan_txb_kdtrans.Text & "'", Conn)
            Dt = New DataTable
            Da.Fill(Dt)
            If Dt.Rows.Count > 0 Then
                MsgBox("Kode Barang tidak boleh sama !!!", MsgBoxStyle.Critical, "Error !!!")
                dan_txb_kdtrans.Focus()
                Return
            ElseIf dan_txb_kdtrans.Text = "" Then
                MsgBox("Kode Barang tidak boleh Kosong !!!", MsgBoxStyle.Exclamation, "Perhatian !!!")
                dan_txb_kdtrans.Focus()
                Return
            End If
            'jika kode aman
            dan_dtp_trans.Focus()
            Return
        End If
        ' membatasi karakter yang di input
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyz1234567890"
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
        'memberikan informasi ketika mencapai batas karakter
        If dan_txb_kdtrans.TextLength = 10 Then
            MsgBox("Maaf anda telah mencapai batas karakter !!!", MsgBoxStyle.Information, "Pesan !!!")
        End If
    End Sub

    Private Sub dan_dtp_trans_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dan_dtp_trans.KeyPress
        If e.KeyChar = Chr(13) Then
            dan_txb_ks.Focus()
            Return
        End If
    End Sub

    Private Sub dan_txb_ks_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dan_txb_ks.KeyPress
        If dan_txb_kdtrans.TextLength = 10 Then
            MsgBox("Maaf anda telah mencapai batas karakter !!!", MsgBoxStyle.Information, "Pesan !!!")
        End If
    End Sub

    Private Sub dan_txb_ks_KeyDown(sender As Object, e As KeyEventArgs) Handles dan_txb_ks.KeyDown
        If e.KeyCode = Keys.Enter Then
            dan_txb_kb.Focus()
        End If
    End Sub

    Private Sub dan_txb_kb_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dan_txb_kb.KeyPress
        'memberikan informasi ketika mencapai batas karakter
        If dan_txb_kdtrans.TextLength = 10 Then
            MsgBox("Maaf anda telah mencapai batas karakter !!!", MsgBoxStyle.Information, "Pesan !!!")
        End If
    End Sub

    Private Sub dan_txb_kb_KeyDown(sender As Object, e As KeyEventArgs) Handles dan_txb_kb.KeyDown
        If e.KeyCode = Keys.Enter Then
            dan_txb_jumbel.Focus()
        End If
    End Sub

    Private Sub dan_txb_jumbel_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dan_txb_jumbel.KeyPress
        If e.KeyChar = Chr(13) Then
            dan_txb_hrgbel.Focus()
            Return
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

    Private Sub dan_txb_hrgbel_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dan_txb_hrgbel.KeyPress
        If e.KeyChar = Chr(13) Then
            If dan_bt_edit.Enabled = True Then
                dan_bt_edit.Focus()
            ElseIf dan_bt_tambah.Enabled = True Then
                dan_bt_tambah.Focus()
            End If
            dan_txb_hrgbel.Text = dan_f_to_mony(dan_txb_hrgbel.Text)
            Return
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
End Class