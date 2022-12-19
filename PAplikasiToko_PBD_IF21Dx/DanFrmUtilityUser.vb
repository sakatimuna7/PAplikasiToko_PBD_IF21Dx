Imports System.Data
Imports System.Data.SqlClient
Imports System.Runtime.InteropServices
Public Class DanFrmUtilityUser
    '============== deklarasi
    Dim table As OleDb.OleDbDataAdapter
    Dim data As DataSet
    Dim record As New BindingSource
    Dim status As String
    '============= function dan sub
    Sub kondisiAwal()
        dan_txb_password.ReadOnly = True
        dan_txb_kdpeg.ReadOnly = True
        dan_txb_kdpeg.UseSystemPasswordChar = True
        dan_cbx_level.Enabled = False
        dan_bt_simpan.Enabled = False
        status = "lihat"
        dan_bt_edit.Text = "Edit"
    End Sub
    Sub kondisiEdit()
        dan_txb_password.ReadOnly = False
        If public_level = "admin" Then
            dan_cbx_level.Enabled = True
            dan_txb_kdpeg.ReadOnly = False
            dan_txb_kdpeg.UseSystemPasswordChar = False
        End If
        dan_bt_simpan.Enabled = True
        status = "edit"
        dan_bt_edit.Text = "Batal"
    End Sub
    '========= Load Pertama
    Private Sub DanFrmUtilityUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call kondisiAwal()
        dan_txb_username.ReadOnly = True
        dan_txb_username.MaxLength = 10
        dan_txb_password.MaxLength = 20
        dan_txb_kdpeg.MaxLength = 10
        dan_lbl_nm_peg.Text = nama_user
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
        'pengecekan password admin panel
        If DanDialogCekPassword.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.Show()
        Else
            Me.Close()
        End If
        Call tampil()
    End Sub
    'tampilkan data
    Sub tampil()
        Try
            'cari data
            Da = New SqlDataAdapter("select * from dan_user_login where dan_username ='" & public_username & "'", Conn)
            Dt = New DataTable
            Da.Fill(Dt)
            dan_txb_username.Text = Dt.Rows(0).Item(0).ToString
            dan_txb_password.Text = Dt.Rows(0).Item(1).ToString
            dan_txb_kdpeg.Text = Dt.Rows(0).Item(2).ToString
            dan_cbx_level.SelectedItem = Dt.Rows(0).Item(3).ToString
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Error !!!")
        End Try
    End Sub
    'jika checkbox password di check
    Private Sub dan_chxb_pw_CheckedChanged(sender As Object, e As EventArgs) Handles dan_chxb_pw.CheckedChanged
        If dan_chxb_pw.Checked = True Then
            dan_txb_password.UseSystemPasswordChar = False
        Else
            dan_txb_password.UseSystemPasswordChar = True
        End If
    End Sub

    'merubah nama pegawai
    

    '===== Button

    Private Sub dan_bt_edit_Click(sender As Object, e As EventArgs) Handles dan_bt_edit.Click
        If status = "lihat" Then
            Call kondisiEdit()
        ElseIf status = "edit" Then
            Call kondisiAwal()
        End If
    End Sub

    Private Sub dan_bt_simpan_Click(sender As Object, e As EventArgs) Handles dan_bt_simpan.Click
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
                Call tampil()
                dan_bt_simpan.Enabled = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Error !!!")
        End Try
    End Sub

    Private Sub dan_bt_keluar_Click(sender As Object, e As EventArgs) Handles dan_bt_keluar.Click
        Me.Close()
    End Sub
End Class