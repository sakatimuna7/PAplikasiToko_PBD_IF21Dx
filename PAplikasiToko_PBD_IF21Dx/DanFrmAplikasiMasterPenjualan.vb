Imports System.Data
Imports System.Data.SqlClient
Imports System.Runtime.InteropServices
Public Class DanFrmAplikasiMasterPenjualan

    '============== deklarasi
    Dim table As OleDb.OleDbDataAdapter
    Dim data As DataSet
    Dim record As New BindingSource

    '============= function dan sub
    'sub untuk mengkosongkan texbox membuat tansaksi baru
    Sub transBaru()
        dan_bt_tambah.Enabled = True
        dan_bt_edit.Enabled = False
        dan_txb_kdtrans.Enabled = True
        dan_txb_kdtrans.Text = ""
        dan_dtp_tgl_trans.Value = Date.Today
        dan_txb_kdbarang.Text = ""
        dan_txb_nmbarang.Text = ""
        dan_txb_hrgjual.Text = ""
        dan_txb_jmlbli.Text = ""
        dan_txb_totharga.Text = ""
        dan_txb_kdpeg.Text = ""
        dan_txb_nmpeg.Text = ""
        dan_txb_total.Text = ""
        dan_txb_pembayaran.Text = ""
        dan_txb_kembalian.Text = ""

        dan_tbl_jual.DataSource = Nothing
        dan_tbl_jual.Rows.Clear()
    End Sub
    'sub untuk mengkosongkan texbox barang
    Sub kosongkanDataBarang()
        dan_txb_kdbarang.Text = ""
        dan_txb_nmbarang.Text = ""
        dan_txb_hrgjual.Text = ""
        dan_txb_jmlbli.Text = ""
        dan_txb_totharga.Text = ""
    End Sub
    'fungsi untuk mengecek kode transaksi
    Function dan_cek_kdtrans()
        Try
            'cek apakah kode pegawai valid
            If dan_cek_kd_peg(dan_txb_kdpeg.Text) Then
                MsgBox("Kode Pegawai tidak Valid !!!", MsgBoxStyle.Critical, "Error !!!")
                dan_txb_kdpeg.Focus()
                Return True
            ElseIf dan_txb_kdtrans.Text.Length <= 0 Then
                MsgBox("Kode Transaksi tidak Valid !!!", MsgBoxStyle.Critical, "Error !!!")
                dan_txb_kdtrans.Focus()
                Return True
            End If
            'cek jika kode sudah pernah terisi atau belum
            Call Koneksi()
            Da = New SqlDataAdapter("select dan_kd_trans from " & dan_penjualan & " where dan_kd_trans='" & dan_txb_kdtrans.Text & "'", Conn)
            Dt = New DataTable
            Da.Fill(Dt)
            If Dt.Rows.Count > 0 Then
                'jika kode ada maka akan menambahkan isi di kode transaksi saat ini
                Return False
            Else
                'jika kode tidak ada maka akan membuat baru kode transaksi saat ini
                Call Koneksi()
                Dim InputData As String = "insert into " & dan_penjualan & " values ('" & dan_txb_kdtrans.Text & "',convert(date,'" & dan_dtp_tgl_trans.Value.Date & "',103),'0','" & dan_txb_kdpeg.Text & "')"
                Cmd = New SqlCommand(InputData, Conn)
                Cmd.ExecuteNonQuery()
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Error !!!")
            Return True
        End Try
    End Function

    'fungsi untuk menampilkan data di tabel
    Function tampil()
        Dim kunci = dan_txb_kdtrans.Text
        dan_tbl_jual.DataSource = Nothing
        dan_tbl_jual.Rows.Clear()
        Try
            Call Koneksi()
            If kunci = "" Then
                Da = New SqlDataAdapter("select * from " & dan_view_penjualan & " order by dan_kd_trans asc", Conn)
            End If
            Da = New SqlDataAdapter("select * from " & dan_view_penjualan & " where dan_kd_trans='" & kunci & "'  order by dan_kd_brg asc", Conn)
            Dt = New DataTable
            Da.Fill(Dt)
            If Dt.Rows.Count > 0 Then
                For Each row In Dt.Rows
                    dan_tbl_jual.Rows.Add(row(0), row(1), dan_f_to_mony(row(2)), row(3), dan_f_to_mony(row(4)), row(5), row(6))
                Next
                Dt.Rows.Clear()
                Call dan_htg_totbyr()
            End If      
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, "Error !!!")
        End Try
        dan_bt_edit.Enabled = False
        Return False
    End Function

    'sub untuk menghitung harga total
    Sub dan_htg_tothrg()
        If dan_txb_hrgjual.Text <> "" And dan_txb_jmlbli.Text <> "" Then
            dan_txb_totharga.Text = dan_f_to_mony((Double.Parse(dan_m_to_float(dan_txb_hrgjual.Text)) * Double.Parse(dan_txb_jmlbli.Text)).ToString)
        End If
    End Sub
    'sub untuk menghitung total bayar
    Sub dan_htg_totbyr()
        If dan_tbl_jual.RowCount >= 0 And dan_txb_kdtrans.Text <> "" Then
            Call Koneksi()
            Da = New SqlDataAdapter("select sum(dan_total_harga) from " & dan_view_penjualan & " where dan_kd_trans='" & dan_txb_kdtrans.Text & "' ", Conn)
            Dt = New DataTable
            Da.Fill(Dt)
            If Dt.Rows.Count > 0 Then
                dan_txb_total.Text = dan_f_to_mony(Dt.Rows(0).Item(0))
            End If
            Dt.Rows.Clear()
        End If
    End Sub

    '============ load pertama
    Private Sub DanFrmAplikasiMasterPenjualan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dan_txb_kdtrans.MaxLength = 10
        dan_txb_kdbarang.MaxLength = 10
        dan_txb_kdpeg.MaxLength = 10
        ' buat filer texbox
        dan_txb_kdtrans.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        dan_txb_kdbarang.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        dan_txb_kdpeg.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        dan_txb_nmbarang.ReadOnly = True
        dan_txb_hrgjual.ReadOnly = True
        dan_txb_totharga.ReadOnly = True
        dan_txb_nmpeg.ReadOnly = True
        dan_txb_total.ReadOnly = True
        dan_txb_kembalian.ReadOnly = True
        dan_txb_kembalian.ForeColor = Color.Black
        dan_txb_kembalian.BackColor = dan_txb_kembalian.BackColor

        'merubah format date time piker
        dan_dtp_tgl_trans.Format = DateTimePickerFormat.Custom
        dan_dtp_tgl_trans.CustomFormat = "dd/MM/yyyy"
        'autocomplate kode barang
        dan_txb_kdbarang.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        dan_txb_kdbarang.AutoCompleteSource = AutoCompleteSource.CustomSource
        dan_txb_kdbarang.AutoCompleteCustomSource = dan_add_kb_Items(dan_txb_kdbarang.Text)
        'autocomplate kode pegawai
        dan_txb_kdpeg.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        dan_txb_kdpeg.AutoCompleteSource = AutoCompleteSource.CustomSource
        dan_txb_kdpeg.AutoCompleteCustomSource = dan_add_kdpeg_Items(dan_txb_kdpeg.Text)
        Call tampil()
    End Sub
    '========= jika table di klik atau dipilih

    Private Sub dan_tbl_jual_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dan_tbl_jual.CellClick
        Call kosongkanDataBarang()
        Try
            If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
                Dim selectedRow = dan_tbl_jual.Rows(e.RowIndex)
                dan_txb_kdbarang.Text = selectedRow.Cells(0).Value.ToString
                dan_txb_nmbarang.Text = selectedRow.Cells(1).Value.ToString
                dan_txb_hrgjual.Text = selectedRow.Cells(2).Value.ToString
                dan_txb_jmlbli.Text = selectedRow.Cells(3).Value.ToString
                dan_txb_totharga.Text = selectedRow.Cells(4).Value.ToString
                dan_txb_kdpeg.Text = selectedRow.Cells(5).Value.ToString
                dan_txb_nmpeg.Text = selectedRow.Cells(6).Value.ToString
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
    Private Sub dan_bt_tambah_Click(sender As Object, e As EventArgs) Handles dan_bt_tambah.Click
        Try
            If dan_txb_kdtrans.Text.Length <= 0 And dan_txb_kdbarang.Text = "" And dan_txb_jmlbli.Text = "" And dan_txb_kdpeg.Text = "" Then
                MsgBox("Pastikan Semua Kolom Terisi", MsgBoxStyle.Exclamation, "Perhatian !!!")
            Else
                'cek jika kode transaksi sudah pernah terisi atau belum jika belum maka buatkan baru

                If dan_cek_kdtrans() Then
                    Return
                End If
                'cek jika kode barang terdaftar/ tidak
                If dan_cek_kb(dan_txb_kdbarang.Text) Then
                    MsgBox("Kode Barang tidak terdaftar !!!", MsgBoxStyle.Critical, "Error !!!")
                    dan_txb_kdbarang.Focus()
                    Return
                End If
                'eksekusi program
                Call Koneksi()
                Dim InputData As String = "insert into " & dan_jual & " values ('" & dan_txb_kdtrans.Text & "','" & dan_txb_kdbarang.Text & "','" & dan_txb_jmlbli.Text & "')"
                Cmd = New SqlCommand(InputData, Conn)
                Cmd.ExecuteNonQuery()
                MsgBox("Barang Berhasil Ditambahkan", MsgBoxStyle.Information, "Pesan !!!")
                Call tampil()
                Call kosongkanDataBarang()
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Error !!!")
        End Try
    End Sub

    Private Sub dan_bt_edit_Click(sender As Object, e As EventArgs) Handles dan_bt_edit.Click
        Try
            If dan_txb_kdtrans.Text = "" And dan_txb_kdtrans.Text = "" And dan_txb_kdbarang.Text = "" And dan_txb_jmlbli.Text = "" Then
                MsgBox("Pastikan Semua Kolom Terisi Denga Benar", MsgBoxStyle.Exclamation, "Perhatian !!!")
            Else
                vMessage = MsgBox("Apakah anda yakin ingin mengubah data " & dan_txb_kdtrans.Text & " barang " & dan_txb_kdbarang.Text & " ini ?", vbExclamation + vbYesNo, "perhatian")
                If vMessage = vbNo Then Exit Sub
                Call Koneksi()
                Dim EditData As String = "Update " & dan_jual & " Set dan_kd_brg='" & dan_txb_kdbarang.Text & "',dan_jml='" & dan_txb_jmlbli.Text & "' WHERE dan_kd_trans='" & dan_txb_kdtrans.Text & "' and dan_kd_brg='" & dan_txb_kdbarang.Text & "' "
                Cmd = New SqlCommand(EditData, Conn)
                Cmd.ExecuteNonQuery()
                MsgBox("Barang Berhasil di Ubah", MsgBoxStyle.Information, "Pesan !!!")
                Call tampil()
                Call kosongkanDataBarang()
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
                vMessage = MsgBox("Apakah anda yakin ingin menghapus data " & dan_txb_kdbarang.Text & " ini ?", vbExclamation + vbYesNo, "perhatian")
                If vMessage = vbNo Then Exit Sub
                Call Koneksi()
                Dim HapusData As String = "DELETE FROM " & dan_jual & " WHERE dan_kd_trans='" & dan_txb_kdtrans.Text & "' and dan_kd_brg='" & dan_txb_kdbarang.Text & "' "
                Cmd = New SqlCommand(HapusData, Conn)
                Cmd.ExecuteNonQuery()
                MsgBox("Data Berhasil di Hapus", MsgBoxStyle.Information)
                Call tampil()
                Call kosongkanDataBarang()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, "Error !!!")
        End Try
    End Sub

    Private Sub dan_bt_batal_Click(sender As Object, e As EventArgs) Handles dan_bt_batal.Click
        Call kosongkanDataBarang()
    End Sub

    Private Sub dan_bt_newtrans_Click(sender As Object, e As EventArgs) Handles dan_bt_newtrans.Click
        kosongkanDataBarang()
        transBaru()
        tampil()
        dan_generate_kdtrans()
    End Sub

    Private Sub dan_bt_total_Click(sender As Object, e As EventArgs) Handles dan_bt_total.Click
        Call dan_htg_totbyr()
    End Sub

    Private Sub dan_bt_keluar_Click(sender As Object, e As EventArgs) Handles dan_bt_keluar.Click
        vMessage = MsgBox("Apakah anda yakin ingin Keluar ?", vbExclamation + vbYesNo, "Perhatian !!!")
        If vMessage = vbNo Then Exit Sub
        Me.Close()
    End Sub

    '======== fungsi filter dan event texbox

    'fungsi membuat kode transaksi
    Private Sub dan_generate_kdtrans()
        Try
            Call Koneksi()
            Da = New SqlDataAdapter("select CONVERT(int,REPLACE(dan_kd_trans, 'TJ', '')) As kode from " & dan_penjualan & " order by kode desc", Conn)
            Dt = New DataTable
            Da.Fill(Dt)
            Dim kode As String
            kode = "TJ" & (Dt.Rows(0).Item(0) + 1)
            dan_txb_kdtrans.Text = kode
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Error !!!")
        End Try
    End Sub

    Private Sub dan_txb_kdtrans_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dan_txb_kdtrans.KeyPress
        If e.KeyChar = Chr(13) Then
            'cek jika kode sudah pernah terisi atau belum
            Call Koneksi()
            Da = New SqlDataAdapter("select dan_kd_trans from " & dan_penjualan & " where dan_kd_trans='" & dan_txb_kdtrans.Text & "'", Conn)
            Dt = New DataTable
            Da.Fill(Dt)
            If Dt.Rows.Count > 0 Then
                vMessage = MsgBox("Apakah anda yakin ingin Memakai kode transaksi ini" & dan_txb_kdtrans.Text & " ?", vbExclamation + vbYesNo, "Kode Transaksi Sudah Pernah Dibuat !!!")
                If vMessage = vbNo Then
                    dan_txb_kdtrans.Text = ""
                    dan_txb_kdtrans.Focus()
                    Return
                End If
                tampil()
            ElseIf dan_txb_kdtrans.Text = "" Then
                MsgBox("Kode Barang tidak boleh Kosong !!!", MsgBoxStyle.Exclamation, "Perhatian !!!")
                dan_txb_kdtrans.Focus()
                Return
            End If
            'jika kode aman
            dan_dtp_tgl_trans.Focus()
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

    Private Sub dan_dtp_tgl_trans_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dan_dtp_tgl_trans.KeyPress
        If e.KeyChar = Chr(13) Then
            dan_txb_kdbarang.Focus()
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
    End Sub

    Private Sub dan_txb_kdbarang_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dan_txb_kdbarang.KeyPress       
        ' membatasi karakter yang di input
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyz1234567890"
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub dan_txb_kdbarang_TextChanged(sender As Object, e As EventArgs) Handles dan_txb_kdbarang.TextChanged
        Call Koneksi()
        Da = New SqlDataAdapter("select dan_nm_barang, dan_hrg_jual from " & dan_barang & " where dan_kd_brg='" & dan_txb_kdbarang.Text & "'", Conn)
        Dt = New DataTable
        Da.Fill(Dt)
        If Dt.Rows.Count > 0 Then
            dan_txb_nmbarang.Text = Dt.Rows(0).Item(0)
            dan_txb_hrgjual.Text = dan_f_to_mony(Dt.Rows(0).Item(1))
        Else
            dan_txb_nmbarang.Text = ""
            dan_txb_hrgjual.Text = ""
            dan_txb_totharga.Text = ""
        End If
        Call dan_htg_tothrg()
    End Sub

    Private Sub dan_txb_kdbarang_KeyDown(sender As Object, e As KeyEventArgs) Handles dan_txb_kdbarang.KeyDown
        If e.KeyCode = Keys.Enter Then
            dan_txb_jmlbli.Focus()
            Return
        End If
    End Sub

    Private Sub dan_txb_jmlbli_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dan_txb_jmlbli.KeyPress
        If e.KeyChar = Chr(13) Then
            dan_txb_kdpeg.Focus()
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
    Private Sub dan_txb_jmlbli_TextChanged(sender As Object, e As EventArgs) Handles dan_txb_jmlbli.TextChanged
        Call dan_htg_tothrg()
    End Sub

    Private Sub dan_txb_kdpeg_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dan_txb_kdpeg.KeyPress
        ' membatasi karakter yang di input
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyz1234567890"
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub dan_txb_kdpeg_KeyDown(sender As Object, e As KeyEventArgs) Handles dan_txb_kdpeg.KeyDown
        If e.KeyCode = Keys.Enter Then
            dan_bt_tambah.Focus()
            Return
        End If
    End Sub

    Private Sub dan_txb_kdpeg_TextChanged(sender As Object, e As EventArgs) Handles dan_txb_kdpeg.TextChanged
        Call Koneksi()
        Da = New SqlDataAdapter("select dan_nm_peg from " & dan_pegawai & " where dan_kd_peg='" & dan_txb_kdpeg.Text & "'", Conn)
        Dt = New DataTable
        Da.Fill(Dt)
        If Dt.Rows.Count > 0 Then
            dan_txb_nmpeg.Text = Dt.Rows(0).Item(0)
        Else
            dan_txb_nmpeg.Text = ""
        End If
    End Sub

    Private Sub dan_txb_pembayaran_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dan_txb_pembayaran.KeyPress
        Dim db As Double
        If e.KeyChar = Chr(13) Then
            dan_bt_simpan.Focus()
            If Double.TryParse(dan_m_to_float(dan_txb_total.Text), db) And dan_txb_pembayaran.Text <> "" Then
                dan_txb_kembalian.Text = dan_f_to_mony(Double.Parse(dan_m_to_float(dan_txb_pembayaran.Text)) - Double.Parse(dan_m_to_float(dan_txb_total.Text))).ToString
            End If
            If dan_m_to_float(dan_txb_pembayaran.Text) < dan_m_to_float(dan_txb_total.Text) Then
                MsgBox("Uang Pembayaran Kurang !!!", MsgBoxStyle.Exclamation, "Perhatian !!!")
                dan_txb_pembayaran.Focus()
                dan_txb_pembayaran.Text = dan_f_to_mony(dan_txb_pembayaran.Text)
                dan_txb_kembalian.ForeColor = Color.Red
                Return
            End If
            dan_txb_pembayaran.Text = dan_f_to_mony(dan_txb_pembayaran.Text)
            dan_txb_kembalian.ForeColor = Color.Black
            Return
        End If
        ' membatasi karakter yang di input
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "1234567890."
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub dan_bt_simpan_Click(sender As Object, e As EventArgs) Handles dan_bt_simpan.Click
        Try
            If dan_m_to_float(dan_txb_pembayaran.Text) < dan_m_to_float(dan_txb_total.Text) Then
                MsgBox("Uang Pembayaran Kurang !!!", MsgBoxStyle.Exclamation, "Perhatian !!!")
                dan_txb_kembalian.ForeColor = Color.Red
                Return
            End If
            If dan_cek_kdtrans() Then
                Return
            End If
            dan_txb_kembalian.ForeColor = Color.Black
            Call Koneksi()
            Dim EditData As String = "Update " & dan_penjualan & " Set dan_tgl=convert(date,'" & dan_dtp_tgl_trans.Value.Date & "',103), dan_bayar='" & dan_m_to_float(dan_txb_pembayaran.Text) & "', dan_kd_peg='" & dan_txb_kdpeg.Text & "' WHERE dan_kd_trans='" & dan_txb_kdtrans.Text & "'"
            Cmd = New SqlCommand(EditData, Conn)
            Cmd.ExecuteNonQuery()
            'cetak nota
            Call cetakNota()
            MsgBox("Pesanan Berhasil Disimpan !!!", MsgBoxStyle.Information, "Pesan !!!")
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Error !!!")
        End Try
    End Sub
    'sub untuk mencetak nota
    Sub cetakNota()
        vMessage = MsgBox("Apakah ingin cetak nota " & dan_txb_kdtrans.Text & " ini ?", vbExclamation + vbYesNo, "perhatian")
        If vMessage = vbYes Then
            Try
                MsgBox("Berhasil Mencetak Nota !!!", MsgBoxStyle.Information, "Pesan !!!")
                AxCrystalReportPenjualan.SelectionFormula = "totext({dan_penjualan.dan_kd_trans})='" & dan_txb_kdtrans.Text & "'"
                AxCrystalReportPenjualan.ReportFileName = "notaJual2.rpt"
                AxCrystalReportPenjualan.WindowState = Crystal.WindowStateConstants.crptMaximized
                AxCrystalReportPenjualan.RetrieveDataFiles()
                AxCrystalReportPenjualan.Action = 1
            Catch ex As Exception
                MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Error CrystalReport !!!")
            End Try       
            Return
        End If
        MsgBox("Nota Tidak Dicetak !!!", MsgBoxStyle.Information, "Pesan !!!")
    End Sub

    Private Sub dan_bt_cetak_Click(sender As Object, e As EventArgs) Handles dan_bt_cetak.Click
        Try
            If dan_cek_kdtrans() Then
                Return
            End If
            If dan_m_to_float(dan_txb_pembayaran.Text) < dan_m_to_float(dan_txb_total.Text) Then
                MsgBox("Uang Pembayaran Kurang !!!", MsgBoxStyle.Exclamation, "Perhatian !!!")
                dan_txb_pembayaran.Focus()
                Return
            End If
            Call Koneksi()
            Dim EditData As String = "Update " & dan_penjualan & " Set dan_tgl=convert(date,'" & dan_dtp_tgl_trans.Value.Date & "',103), dan_bayar='" & dan_m_to_float(dan_txb_pembayaran.Text) & "', dan_kd_peg='" & dan_txb_kdpeg.Text & "' WHERE dan_kd_trans='" & dan_txb_kdtrans.Text & "'"
            Cmd = New SqlCommand(EditData, Conn)
            Cmd.ExecuteNonQuery()
            Call cetakNota()
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Error !!!")
        End Try
    End Sub
End Class