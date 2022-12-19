Imports System.Data
Imports System.Data.SqlClient
Imports System.Runtime.InteropServices
Public Class DanFrmUtilityKelolaUserLogin

    '============== deklarasi
    Dim table As OleDb.OleDbDataAdapter
    Dim data As DataSet
    Dim record As New BindingSource

    '============= function dan sub
    'sub untuk mengkosongkan texbox
    Sub KosongkanData()
        dan_txb_username.Enabled = True
        dan_bt_tambah.Enabled = True
        dan_bt_edit.Enabled = False
        dan_bt_hapus.Enabled = False
        dan_txb_cari.Text = ""
        dan_txb_username.Text = ""
        dan_txb_password.Text = ""
        dan_txb_kdpeg.Text = ""
        dan_lbl_nm_peg.Text = ""
        dan_cbx_level.SelectedIndex = 0
    End Sub
    'fungsi untuk menampilkan data di tabel
    Function tampil(kunci As String)
        dan_tbl_user_login.DataSource = Nothing
        dan_tbl_user_login.Rows.Clear()
        Try
            Call Koneksi()
            If kunci = "" Then
                Da = New SqlDataAdapter("select * from dan_view_user_login order by dan_username asc", Conn)
            End If
            Da = New SqlDataAdapter("select * from dan_view_user_login where dan_nm_peg LIKE '%" & kunci & "%' or dan_username LIKE '%" & kunci & "%' order by dan_username asc", Conn)
            Dt = New DataTable
            Da.Fill(Dt)
            For Each row In Dt.Rows
                dan_tbl_user_login.Rows.Add(row(0), row(1), row(2), row(3))
            Next
            Dt.Rows.Clear()
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, "Error !!!")
        End Try
        dan_bt_edit.Enabled = False
        dan_bt_hapus.Enabled = False
        Return False
    End Function

    '===================Load Pertama Kali
    Private Sub DanFrmUtilityKelolaUserLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Hide()
        dan_txb_username.MaxLength = 10
        dan_txb_password.MaxLength = 20
        dan_txb_kdpeg.MaxLength = 10
        'buat text * pada textbox password
        dan_txb_password.UseSystemPasswordChar = True
        ' buat filer texbox
        dan_txb_kdpeg.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        ' combo box level
        dan_cbx_level.Items.Clear()
        dan_cbx_level.Items.Add("Pilih Level")
        dan_cbx_level.Items.Add("admin")
        dan_cbx_level.Items.Add("user")
        dan_cbx_level.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        dan_cbx_level.AutoCompleteSource = AutoCompleteSource.ListItems
        'autocomplate kode pegawai
        dan_txb_kdpeg.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        dan_txb_kdpeg.AutoCompleteSource = AutoCompleteSource.CustomSource
        dan_txb_kdpeg.AutoCompleteCustomSource = dan_add_kdpeg_Items(dan_txb_kdpeg.Text)
        'pangil tampil
        Call tampil("")
        Call KosongkanData()
        'pengecekan password admin panel
        If DanDialogCekPassword.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.Show()
        Else
            Me.Close()
        End If
    End Sub

    '=========================== pencarian 
    Private Sub dan_txb_cari_TextChanged(sender As Object, e As EventArgs) Handles dan_txb_cari.TextChanged
        Call tampil(dan_txb_cari.Text)
        Try
            If dan_txb_cari.TextLength = 0 Then
                KosongkanData()
                Return
            End If
            Dim selectedRow = dan_tbl_user_login.Rows(0)
            'cari data
            Call Koneksi()
            Da = New SqlDataAdapter("select * from dan_user_login where dan_username ='" & selectedRow.Cells(0).Value.ToString & "'", Conn)
            Dt = New DataTable
            Da.Fill(Dt)
            If Dt.Rows.Count > 0 Then
                dan_txb_username.Text = Dt.Rows(0).Item(0)
                dan_txb_password.Text = Dt.Rows(0).Item(1)
                dan_txb_kdpeg.Text = Dt.Rows(0).Item(2)
                dan_cbx_level.Text = selectedRow.Cells(3).Value.ToString
                dan_lbl_nm_peg.Text = selectedRow.Cells(1).Value.ToString
                dan_bt_edit.Enabled = True
                dan_bt_hapus.Enabled = True
                dan_bt_tambah.Enabled = False
                dan_txb_username.Enabled = False
            End If
        Catch ex As Exception
            MsgBox("Kode tidak ditemukan !!!", MsgBoxStyle.Exclamation, "Perhatian !!!")
        End Try
    End Sub
    Private Sub dan_txb_cari_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dan_txb_cari.KeyPress
        If e.KeyChar = Chr(13) Then
            dan_txb_password.Focus()
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

    Private Sub dan_tbl_user_login_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dan_tbl_user_login.CellClick
        Call KosongkanData()
        Try
            If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
                Dim selectedRow = dan_tbl_user_login.Rows(e.RowIndex)
                'cari data
                Da = New SqlDataAdapter("select * from dan_user_login where dan_username ='" & selectedRow.Cells(0).Value.ToString & "'", Conn)
                Dt = New DataTable
                Da.Fill(Dt)
                dan_txb_username.Text = Dt.Rows(0).Item(0)
                dan_txb_password.Text = Dt.Rows(0).Item(1)
                dan_txb_kdpeg.Text = Dt.Rows(0).Item(2)
                dan_cbx_level.Text = selectedRow.Cells(3).Value.ToString
                dan_lbl_nm_peg.Text = selectedRow.Cells(1).Value.ToString
                dan_bt_edit.Enabled = True
                dan_bt_hapus.Enabled = True
                dan_bt_tambah.Enabled = False
                dan_txb_username.Enabled = False
            End If
            MsgBox("Kode Terpilih !", MsgBoxStyle.Information, "Pesan !!!")
        Catch ex As Exception
            MsgBox("Data yang dipilih kosong !!!", MsgBoxStyle.Exclamation, "Perhatian !!!")
        End Try
    End Sub

    Private Sub dan_chxb_pw_CheckedChanged(sender As Object, e As EventArgs) Handles dan_chxb_pw.CheckedChanged
        If dan_chxb_pw.Checked = True Then
            dan_txb_password.UseSystemPasswordChar = False
        Else
            dan_txb_password.UseSystemPasswordChar = True
        End If
    End Sub

    '========= Button / tombol aksi

    Private Sub dan_bt_simpan_Click(sender As Object, e As EventArgs) Handles dan_bt_tambah.Click
        Try
            If dan_txb_username.Text = "" Then
                MsgBox("Username Kosong", MsgBoxStyle.Exclamation, "Perhatian !!!")
            Else
                'cek jika kode sudah pernag terisi atau belum
                Call Koneksi()
                Da = New SqlDataAdapter("select dan_kd_peg from dan_user_login where dan_username='" & dan_txb_username.Text & "'", Conn)
                Dt = New DataTable
                Da.Fill(Dt)
                If Dt.Rows.Count > 0 Then
                    MsgBox("Username tidak boleh sama !!!", MsgBoxStyle.Critical, "Error !!!")
                    Return
                End If
                'eksekusi program
                Call Koneksi()
                Dim InputData As String = "insert into dan_user_login values ('" & dan_txb_username.Text & "','" & dan_txb_password.Text & "','" & dan_txb_kdpeg.Text & "','" & dan_cbx_level.SelectedItem & "')"
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
            If dan_txb_username.Text = "" Then
                MsgBox("Username Kosong", MsgBoxStyle.Exclamation, "Perhatian !!!")
            Else
                vMessage = MsgBox("Apakah anda yakin ingin mengubah data " & dan_txb_username.Text & " ini ?", vbExclamation + vbYesNo, "perhatian")
                If vMessage = vbNo Then Exit Sub
                Call Koneksi()
                Dim EditData As String = "Update dan_user_login Set dan_username='" & dan_txb_username.Text & "',dan_password='" & dan_txb_password.Text & "',dan_kd_peg='" & dan_txb_kdpeg.Text & "',dan_level='" & dan_cbx_level.SelectedItem & "' where dan_username='" & dan_txb_username.Text & "'"
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
            If dan_txb_username.Text = "" Then
                MsgBox("Username Kosong", MsgBoxStyle.Exclamation, "Perhatian !!!")
            Else
                vMessage = MsgBox("Apakah anda yakin ingin menghapus data " & dan_txb_username.Text & " ini ?", vbExclamation + vbYesNo, "perhatian")
                If vMessage = vbNo Then Exit Sub
                Call Koneksi()
                Da = New SqlDataAdapter("select dan_kd_peg from dan_user_login where dan_username='" & dan_txb_username.Text & "'", Conn)
                Dt = New DataTable
                Da.Fill(Dt)
                If Dt.Rows.Count > 0 Then
                    MsgBox("Dilarang Menghapus Username (admin)", MsgBoxStyle.Critical, "Error !!!")
                Else
                    Dim HapusData As String = "Delete dan_user_login where dan_username ='" & dan_txb_username.Text & "' and dan_username !='admin' "
                    Cmd = New SqlCommand(HapusData, Conn)
                    Cmd.ExecuteNonQuery()
                    MsgBox("Data Berhasil di Hapus", MsgBoxStyle.Information)
                End If         
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

    Private Sub dan_txb_username_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dan_txb_username.KeyPress
        'jika di enter maka next textbox
        If e.KeyChar = Chr(13) Then
            dan_txb_password.Focus()
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
        If dan_txb_username.TextLength = 10 Then
            MsgBox("Maaf anda telah mencapai batas karakter !!!", MsgBoxStyle.Information, "Pesan !!!")
        End If

    End Sub

    Private Sub dan_txb_password_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dan_txb_password.KeyPress
        'memberikan informasi ketika mencapai batas karakter
        If dan_txb_username.TextLength = 20 Then
            MsgBox("Maaf anda telah mencapai batas karakter !!!", MsgBoxStyle.Information, "Pesan !!!")
        End If
        'jika di enter maka next textbox
        If e.KeyChar = Chr(13) Then
            dan_txb_kdpeg.Focus()
        End If
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
        'memberikan informasi ketika mencapai batas karakter
        If dan_txb_username.TextLength = 10 Then
            MsgBox("Maaf anda telah mencapai batas karakter !!!", MsgBoxStyle.Information, "Pesan !!!")
        End If
    End Sub

    Private Sub dan_txb_kdpeg_KeyDown(sender As Object, e As KeyEventArgs) Handles dan_txb_kdpeg.KeyDown
        If e.KeyCode = Keys.Enter Then
            dan_cbx_level.Focus()
        End If
    End Sub

    Private Sub dan_txb_kdpeg_TextChanged(sender As Object, e As EventArgs) Handles dan_txb_kdpeg.TextChanged
        Try
            If dan_txb_kdpeg.TextLength = 0 Then
                dan_lbl_nm_peg.Text = ""
                Return
            End If
            Call Koneksi()
            Da = New SqlDataAdapter("select dan_nm_peg from " & dan_pegawai & " where dan_kd_peg='" & dan_txb_kdpeg.Text & "'", Conn)
            Dt = New DataTable
            Da.Fill(Dt)
            If Dt.Rows.Count > 0 Then
                dan_lbl_nm_peg.Text = Dt.Rows(0).Item(0)
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Error !!!")
        End Try
    End Sub

    Private Sub dan_cbx_level_KeyDown(sender As Object, e As KeyEventArgs) Handles dan_cbx_level.KeyDown
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