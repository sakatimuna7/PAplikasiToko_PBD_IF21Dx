Imports System.Data
Imports System.Data.SqlClient
Imports System.Runtime.InteropServices
Public Class DanFrmAplikasiMasterPegawai

    '============== deklarasi
    Dim table As OleDb.OleDbDataAdapter
    Dim data As DataSet
    Dim record As New BindingSource

    '============= function dan sub
    'sub untuk mengkosongkan texbox
    Sub KosongkanData()
        dan_txb_kp.Enabled = True
        dan_bt_tambah.Enabled = True
        dan_bt_edit.Enabled = False
        dan_bt_hapus.Enabled = False
        dan_txb_cari.Text = ""
        dan_txb_kp.Text = ""
        dan_txb_npeg.Text = ""
        dan_txb_tl.Text = ""
        dan_txb_telp.Text = ""
        dan_rtxb_alamat.Text = ""
        dan_dtp_ttgl.Value = Date.Today
        dan_cbx_pen.SelectedIndex = 0
        dan_cbx_jab.SelectedIndex = 0
    End Sub

    'fungsi untuk menampilkan data di tabel
    Function tampil(kunci As String)
        dan_tbl_pegawai.DataSource = Nothing
        dan_tbl_pegawai.Rows.Clear()
        Try
            Call Koneksi()
            If kunci = "" Then
                Da = New SqlDataAdapter("select * from " & dan_pegawai & " order by dan_kd_peg asc", Conn)
            End If
            Da = New SqlDataAdapter("select * from " & dan_pegawai & " where dan_kd_peg LIKE '%" & kunci & "%' or dan_nm_peg LIKE '%" & kunci & "%' order by dan_kd_peg asc", Conn)
            Dt = New DataTable
            Da.Fill(Dt)
            For Each row In Dt.Rows
                dan_tbl_pegawai.Rows.Add(row(0), row(1), row(2), row(3), row(4), row(5), row(6), row(7))
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
    Private Sub DanFrmAplikasiMasterPegawai__Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dan_txb_kp.MaxLength = 10
        dan_txb_npeg.MaxLength = 30
        dan_txb_tl.MaxLength = 20
        dan_txb_telp.MaxLength = 15
        dan_rtxb_alamat.MaxLength = 30
        ' buat filer texbox
        dan_txb_kp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        dan_txb_cari.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        dan_txb_npeg.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        dan_tbl_pegawai.ReadOnly = True
        'merubah format date time piker
        dan_dtp_ttgl.Format = DateTimePickerFormat.Custom
        dan_dtp_ttgl.CustomFormat = "dd/MM/yyyy"
        ' combo box pendidikan
        dan_cbx_pen.Items.Add("Pilih Pendidikan")
        dan_cbx_pen.Items.Add("SD")
        dan_cbx_pen.Items.Add("SMP")
        dan_cbx_pen.Items.Add("SMA")
        dan_cbx_pen.Items.Add("D3")
        dan_cbx_pen.Items.Add("S1")
        dan_cbx_pen.Items.Add("S2")
        dan_cbx_pen.Items.Add("S3")
        dan_cbx_pen.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        dan_cbx_pen.AutoCompleteSource = AutoCompleteSource.ListItems
        ' combo box jabatan
        dan_cbx_jab.Items.Add("Pilih Jabatan")
        dan_cbx_jab.Items.Add("Kasir")
        dan_cbx_jab.Items.Add("Kepala Toko")
        dan_cbx_jab.Items.Add("Programer")
        dan_cbx_jab.Items.Add("Administrator")
        dan_cbx_jab.Items.Add("Manager")
        dan_cbx_jab.Items.Add("Direktur")
        dan_cbx_jab.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        dan_cbx_jab.AutoCompleteSource = AutoCompleteSource.ListItems
        'pangil tampil
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
            Dim selectedRow = dan_tbl_pegawai.Rows(0)
            dan_txb_kp.Text = selectedRow.Cells(0).Value.ToString
            dan_txb_npeg.Text = selectedRow.Cells(1).Value.ToString
            dan_txb_tl.Text = selectedRow.Cells(2).Value.ToString
            dan_dtp_ttgl.Value = selectedRow.Cells(3).Value.ToString
            dan_cbx_pen.Text = selectedRow.Cells(4).Value.ToString
            dan_cbx_jab.Text = selectedRow.Cells(5).Value.ToString
            dan_txb_telp.Text = selectedRow.Cells(6).Value.ToString
            dan_rtxb_alamat.Text = selectedRow.Cells(7).Value.ToString
            dan_bt_edit.Enabled = True
            dan_bt_hapus.Enabled = True
            dan_bt_tambah.Enabled = False
            dan_txb_kp.Enabled = False
        Catch ex As Exception
            MsgBox("Kode tidak ditemukan !!!", MsgBoxStyle.Exclamation, "Perhatian !!!")
        End Try
    End Sub
    Private Sub dan_txb_cari_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dan_txb_cari.KeyPress
        If e.KeyChar = Chr(13) Then
            dan_txb_npeg.Focus()
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

    Private Sub dan_tbl_pegawai_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dan_tbl_pegawai.CellClick
        Call KosongkanData()
        Try
            If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
                Dim selectedRow = dan_tbl_pegawai.Rows(e.RowIndex)
                dan_txb_kp.Text = selectedRow.Cells(0).Value.ToString
                dan_txb_npeg.Text = selectedRow.Cells(1).Value.ToString
                dan_txb_tl.Text = selectedRow.Cells(2).Value.ToString
                dan_dtp_ttgl.Value = selectedRow.Cells(3).Value.ToString
                dan_cbx_pen.Text = selectedRow.Cells(4).Value.ToString
                dan_cbx_jab.Text = selectedRow.Cells(5).Value.ToString
                dan_txb_telp.Text = selectedRow.Cells(6).Value.ToString
                dan_rtxb_alamat.Text = selectedRow.Cells(7).Value.ToString
                dan_bt_edit.Enabled = True
                dan_bt_hapus.Enabled = True
                dan_bt_tambah.Enabled = False
                dan_txb_kp.Enabled = False
            End If
            MsgBox("Kode Barang Terpilih !", MsgBoxStyle.Information, "Pesan !!!")
        Catch ex As Exception
            MsgBox("Data yang dipilih kosong !!!", MsgBoxStyle.Exclamation, "Perhatian !!!")
        End Try
    End Sub

    '========= Button / tombol aksi

    Private Sub dan_bt_simpan_Click(sender As Object, e As EventArgs) Handles dan_bt_tambah.Click
        Try
            If dan_txb_kp.Text = "" Then
                MsgBox("Kode Pegawai Kosong", MsgBoxStyle.Exclamation, "Perhatian !!!")
            Else
                'cek jika kode sudah pernag terisi atau belum
                Call Koneksi()
                Da = New SqlDataAdapter("select dan_kd_peg from " & dan_pegawai & " where dan_kd_peg='" & dan_txb_kp.Text & "'", Conn)
                Dt = New DataTable
                Da.Fill(Dt)
                If Dt.Rows.Count > 0 Then
                    MsgBox("Kode Barang tidak boleh sama !!!", MsgBoxStyle.Critical, "Error !!!")
                    Return
                End If
                'eksekusi program
                Call Koneksi()
                Dim InputData As String = "insert into " & dan_pegawai & " values ('" & dan_txb_kp.Text & "','" & dan_txb_npeg.Text & "','" & dan_txb_tl.Text & "',convert(date,'" & dan_dtp_ttgl.Value.Date & "',103),'" & dan_cbx_pen.SelectedItem & "','" & dan_cbx_jab.SelectedItem & "','" & dan_txb_telp.Text & "','" & dan_rtxb_alamat.Text & "')"
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
            If dan_txb_kp.Text = "" Then
                MsgBox("Kode Pegawai Kosong", MsgBoxStyle.Exclamation, "Perhatian !!!")
            Else
                vMessage = MsgBox("Apakah anda yakin ingin mengubah data " & dan_txb_kp.Text & " ini ?", vbExclamation + vbYesNo, "perhatian")
                If vMessage = vbNo Then Exit Sub
                Call Koneksi()
                Dim EditData As String = "Update " & dan_pegawai & " Set dan_nm_peg='" & dan_txb_npeg.Text & "',dan_temp_lhr='" & dan_txb_tl.Text & "',dan_tgl_lhr=convert(date,'" & dan_dtp_ttgl.Value.Date & "',103),dan_pend='" & dan_cbx_pen.SelectedItem & "',dan_jab='" & dan_cbx_jab.SelectedItem & "',dan_no_telp='" & dan_txb_telp.Text & "',dan_alamat='" & dan_rtxb_alamat.Text & "' WHERE dan_kd_peg='" & dan_txb_kp.Text & "'"
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
            If dan_txb_kp.Text = "" Then
                MsgBox("Kode Pegawai Kosong", MsgBoxStyle.Exclamation, "Perhatian !!!")
            Else
                vMessage = MsgBox("Apakah anda yakin ingin menghapus data " & dan_txb_kp.Text & " ini ?", vbExclamation + vbYesNo, "perhatian")
                If vMessage = vbNo Then Exit Sub
                Call Koneksi()
                Dim HapusData As String = "Delete " & dan_pegawai & " where dan_kd_peg='" & dan_txb_kp.Text & "'"
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
        vMessage = MsgBox("Apakah anda yakin ingin Keluar ?", vbExclamation + vbYesNo, "perhatian")
        If vMessage = vbNo Then Exit Sub
        Me.Close()
    End Sub

    '======== fungsi filter dan event texbox

    Private Sub dan_txb_kp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dan_txb_kp.KeyPress
        If e.KeyChar = Chr(13) Then
            'cek jika kode sudah pernah terisi atau belum
            Call Koneksi()
            Da = New SqlDataAdapter("select dan_kd_peg from " & dan_pegawai & " where dan_kd_peg='" & dan_txb_kp.Text & "'", Conn)
            Dt = New DataTable
            Da.Fill(Dt)
            If Dt.Rows.Count > 0 Then
                MsgBox("Kode Barang tidak boleh sama !!!", MsgBoxStyle.Critical, "Error !!!")
                dan_txb_kp.Focus()
                Return
            End If
            'jika kode aman
            dan_txb_npeg.Focus()
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
        If dan_txb_kp.TextLength = 10 Then
            MsgBox("Maaf anda telah mencapai batas karakter !!!", MsgBoxStyle.Information, "Pesan !!!")
        End If
    End Sub

    Private Sub dan_txb_npeg_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dan_txb_npeg.KeyPress
        If e.KeyChar = Chr(13) Then
            dan_txb_tl.Focus()
            Return
        End If
        'memberikan informasi ketika mencapai batas karakter
        If dan_txb_npeg.TextLength = 30 Then
            MsgBox("Maaf anda telah mencapai batas karakter !!!", MsgBoxStyle.Information, "Pesan !!!")
        End If
    End Sub

    Private Sub dan_txb_tl_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dan_txb_tl.KeyPress
        If e.KeyChar = Chr(13) Then
            dan_dtp_ttgl.Focus()
            Return
        End If
        'memberikan informasi ketika mencapai batas karakter
        If dan_txb_tl.TextLength = 20 Then
            MsgBox("Maaf anda telah mencapai batas karakter !!!", MsgBoxStyle.Information, "Pesan !!!")
        End If
    End Sub

    Private Sub dan_dtp_ttgl_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dan_dtp_ttgl.KeyPress
        If e.KeyChar = Chr(13) Then
            dan_cbx_pen.Focus()
        End If
    End Sub

    Private Sub dan_cbx_pen_KeyDown(sender As Object, e As KeyEventArgs) Handles dan_cbx_pen.KeyDown
        If e.KeyCode = Keys.Tab Then
            dan_cbx_jab.Focus()
        End If
    End Sub

    Private Sub dan_cbx_jab_keydown(sender As Object, e As KeyEventArgs) Handles dan_cbx_jab.KeyDown
        If e.KeyCode = Keys.Tab Then
            dan_txb_telp.Focus()
        End If
    End Sub

    Private Sub dan_txb_telp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dan_txb_telp.KeyPress
        Try
            If e.KeyChar = Chr(13) Then
                dan_rtxb_alamat.Focus()
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
            'memberikan informasi ketika mencapai batas karakter
            If dan_rtxb_alamat.TextLength = 15 Then
                MsgBox("Maaf anda telah mencapai batas karakter !!!", MsgBoxStyle.Information, "Pesan !!!")
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Error !!!")
        End Try
    End Sub

    Private Sub dan_rtxb_alamat_KeyPress(sender As Object, e As KeyPressEventArgs)
        If e.KeyChar = Chr(13) Then
            If dan_bt_edit.Enabled = True Then
                dan_bt_edit.Focus()
            ElseIf dan_bt_tambah.Enabled = True Then
                dan_bt_tambah.Focus()
            End If
            Return
        End If
        'memberikan informasi ketika mencapai batas karakter
        If dan_rtxb_alamat.TextLength = 30 Then
            MsgBox("Maaf anda telah mencapai batas karakter !!!", MsgBoxStyle.Information, "Pesan !!!")
        End If
    End Sub

    Private Sub dan_rtxb_alamat_KeyDown(sender As Object, e As KeyEventArgs) Handles dan_rtxb_alamat.KeyDown
        If e.KeyCode = Keys.Enter Then
            If dan_bt_edit.Enabled = True Then
                dan_bt_edit.Focus()
            ElseIf dan_bt_tambah.Enabled = True Then
                dan_bt_tambah.Focus()
            End If
            Return
        End If
    End Sub
End Class