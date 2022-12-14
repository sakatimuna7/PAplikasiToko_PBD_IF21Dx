Imports System.Data
Imports System.Data.SqlClient
Imports System.Runtime.InteropServices
Public Class DanFrmAplikasiMasterSupplier

    '============== deklarasi
    Dim table As OleDb.OleDbDataAdapter
    Dim data As DataSet
    Dim record As New BindingSource

    '============= function dan sub
    'sub untuk mengkosongkan texbox
    Sub KosongkanData()
        dan_txb_ks.Enabled = True
        dan_bt_tambah.Enabled = True
        dan_bt_edit.Enabled = False
        dan_bt_hapus.Enabled = False
        dan_txb_cari.Text = ""
        dan_txb_ks.Text = ""
        dan_txb_np.Text = ""
        dan_txb_npj.Text = ""
        dan_txb_notel.Text = ""
        dan_txb_email.Text = ""
        dan_rtxb_alamat.Text = ""
    End Sub

    'fungsi untuk menampilkan data di tabel
    Function tampil(kunci As String)
        dan_tbl_sup.DataSource = Nothing
        dan_tbl_sup.Rows.Clear()
        Try
            Call Koneksi()
            If kunci = "" Then
                Da = New SqlDataAdapter("select * from " & dan_supplier & " order by dan_kd_sup asc", Conn)
            End If
            Da = New SqlDataAdapter("select * from " & dan_supplier & " where dan_kd_sup LIKE '%" & kunci & "%' or dan_nm_per LIKE '%" & kunci & "%' order by dan_kd_sup asc", Conn)
            Dt = New DataTable
            Da.Fill(Dt)
            For Each row In Dt.Rows
                dan_tbl_sup.Rows.Add(row(0), row(1), row(2), row(3), row(4), row(5))
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
    Private Sub DanFrmAplikasiMasterSupplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dan_txb_ks.MaxLength = 10
        dan_txb_np.MaxLength = 20
        dan_txb_npj.MaxLength = 20
        dan_txb_notel.MaxLength = 15
        dan_txb_email.MaxLength = 20
        dan_rtxb_alamat.MaxLength = 30
        'pangil tampil
        Call tampil("")
        ' buat filer texbox
        dan_txb_ks.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        dan_txb_cari.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        dan_txb_np.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
    End Sub

    '=========================== pencarian 
    Private Sub dan_txb_cari_TextChanged(sender As Object, e As EventArgs) Handles dan_txb_cari.TextChanged
        Call tampil(dan_txb_cari.Text)
        Try
            If dan_txb_cari.TextLength = 0 Then
                KosongkanData()
                Return
            End If
            Dim selectedRow = dan_tbl_sup.Rows(0)
            dan_txb_ks.Text = selectedRow.Cells(0).Value.ToString
            dan_txb_np.Text = selectedRow.Cells(1).Value.ToString
            dan_txb_npj.Text = selectedRow.Cells(2).Value.ToString
            dan_txb_notel.Text = selectedRow.Cells(3).Value.ToString
            dan_txb_email.Text = selectedRow.Cells(4).Value.ToString
            dan_rtxb_alamat.Text = selectedRow.Cells(5).Value.ToString
            dan_bt_edit.Enabled = True
            dan_bt_hapus.Enabled = True
            dan_bt_tambah.Enabled = False
            dan_txb_ks.Enabled = False
        Catch ex As Exception
            MsgBox("Kode tidak ditemukan !!!", MsgBoxStyle.Exclamation, "Perhatian !!!")
        End Try
    End Sub
    Private Sub dan_txb_cari_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dan_txb_cari.KeyPress
        If e.KeyChar = Chr(13) Then
            dan_txb_np.Focus()
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
    Private Sub dan_tbl_sup_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dan_tbl_sup.CellClick
        Call KosongkanData()
        Try
            If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
                Dim selectedRow = dan_tbl_sup.Rows(e.RowIndex)
                dan_txb_ks.Text = selectedRow.Cells(0).Value.ToString
                dan_txb_np.Text = selectedRow.Cells(1).Value.ToString
                dan_txb_npj.Text = selectedRow.Cells(2).Value.ToString
                dan_txb_notel.Text = selectedRow.Cells(3).Value.ToString
                dan_txb_email.Text = selectedRow.Cells(4).Value.ToString
                dan_rtxb_alamat.Text = selectedRow.Cells(5).Value.ToString
                dan_bt_edit.Enabled = True
                dan_bt_hapus.Enabled = True
                dan_bt_tambah.Enabled = False
                dan_txb_ks.Enabled = False
            End If
            MsgBox("Kode Barang Terpilih !", MsgBoxStyle.Information, "Pesan !!!")
        Catch ex As Exception
            MsgBox("Data yang dipilih kosong !!!", MsgBoxStyle.Exclamation, "Perhatian !!!")
        End Try
    End Sub

    '========= Button / tombol aksi

    Private Sub dan_bt_tambah_Click(sender As Object, e As EventArgs) Handles dan_bt_tambah.Click
        Try
            If dan_txb_ks.Text = "" Then
                MsgBox("Kode Supplier Kosong", MsgBoxStyle.Exclamation, "Perhatian !!!")
            Else
                'cek jika kode sudah pernag terisi atau belum
                Call Koneksi()
                Da = New SqlDataAdapter("select dan_kd_sup from " & dan_supplier & " where dan_kd_sup='" & dan_txb_ks.Text & "'", Conn)
                Dt = New DataTable
                Da.Fill(Dt)
                If Dt.Rows.Count > 0 Then
                    MsgBox("Kode Barang tidak boleh sama !!!", MsgBoxStyle.Critical, "Error !!!")
                    Return
                End If
                'eksekusi program
                Call Koneksi()
                Dim InputData As String = "insert into " & dan_supplier & " values ('" & dan_txb_ks.Text & "','" & dan_txb_np.Text & "','" & dan_txb_npj.Text & "','" & dan_txb_notel.Text & "','" & dan_txb_email.Text & "','" & dan_rtxb_alamat.Text & "')"
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
            If dan_txb_ks.Text = "" Then
                MsgBox("Kode Supplier Kosong", MsgBoxStyle.Exclamation, "Perhatian !!!")
            Else
                vMessage = MsgBox("Apakah anda yakin ingin mengubah data " & dan_txb_ks.Text & " ini ?", vbExclamation + vbYesNo, "perhatian")
                If vMessage = vbNo Then Exit Sub
                Call Koneksi()
                Dim EditData As String = "Update " & dan_supplier & " Set dan_nm_per='" & dan_txb_np.Text & "',dan_nm_pen='" & dan_txb_npj.Text & "',dan_no_telp='" & dan_txb_notel.Text & "',dan_email='" & dan_txb_email.Text & "',dan_alamat='" & dan_rtxb_alamat.Text & "' WHERE dan_kd_sup='" & dan_txb_ks.Text & "'"
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
            If dan_txb_ks.Text = "" Then
                MsgBox("Kode Supplier Kosong", MsgBoxStyle.Exclamation, "Perhatian !!!")
            Else
                vMessage = MsgBox("Apakah anda yakin ingin menghapus data " & dan_txb_ks.Text & " ini ?", vbExclamation + vbYesNo, "perhatian")
                If vMessage = vbNo Then Exit Sub
                Call Koneksi()
                Dim HapusData As String = "Delete " & dan_supplier & " where dan_kd_sup='" & dan_txb_ks.Text & "'"
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

    Private Sub dan_txb_ks_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dan_txb_ks.KeyPress
        If e.KeyChar = Chr(13) Then
            'cek jika kode sudah pernah terisi atau belum
            Call Koneksi()
            Da = New SqlDataAdapter("select dan_kd_sup from " & dan_supplier & " where dan_kd_sup='" & dan_txb_ks.Text & "'", Conn)
            Dt = New DataTable
            Da.Fill(Dt)
            If Dt.Rows.Count > 0 Then
                MsgBox("Kode Barang tidak boleh sama !!!", MsgBoxStyle.Critical, "Error !!!")
                dan_txb_ks.Focus()
                Return
            End If
            'jika kode aman
            dan_txb_np.Focus()
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
        If dan_txb_ks.TextLength = 10 Then
            MsgBox("Maaf anda telah mencapai batas karakter !!!", MsgBoxStyle.Information, "Pesan !!!")
        End If
    End Sub

    Private Sub dan_txb_np_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dan_txb_np.KeyPress
        If e.KeyChar = Chr(13) Then
            dan_txb_npj.Focus()
            Return
        End If
        'memberikan informasi ketika mencapai batas karakter
        If dan_txb_np.TextLength = 20 Then
            MsgBox("Maaf anda telah mencapai batas karakter !!!", MsgBoxStyle.Information, "Pesan !!!")
        End If
    End Sub

    Private Sub dan_txb_npj_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dan_txb_npj.KeyPress
        If e.KeyChar = Chr(13) Then
            dan_txb_notel.Focus()
            Return
        End If
        'memberikan informasi ketika mencapai batas karakter
        If dan_txb_npj.TextLength = 20 Then
            MsgBox("Maaf anda telah mencapai batas karakter !!!", MsgBoxStyle.Information, "Pesan !!!")
        End If
    End Sub

    Private Sub dan_txb_notel_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dan_txb_notel.KeyPress
        If e.KeyChar = Chr(13) Then
            dan_txb_email.Focus()
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
        If dan_txb_notel.TextLength = 15 Then
            MsgBox("Maaf anda telah mencapai batas karakter !!!", MsgBoxStyle.Information, "Pesan !!!")
        End If
    End Sub

    Private Sub dan_txb_email_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dan_txb_email.KeyPress
        If e.KeyChar = Chr(13) Then
            dan_rtxb_alamat.Focus()
            Return
        End If
        ' membatasi karakter yang di input
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyz1234567890@_-."
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
        'memberikan informasi ketika mencapai batas karakter
        If dan_txb_email.TextLength = 20 Then
            MsgBox("Maaf anda telah mencapai batas karakter !!!", MsgBoxStyle.Information, "Pesan !!!")
        End If
    End Sub

    Private Sub dan_rtxb_alamat_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dan_rtxb_alamat.KeyPress
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
End Class
