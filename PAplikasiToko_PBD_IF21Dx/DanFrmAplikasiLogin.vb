Imports System.Data.SqlClient

Public Class DanFrmAplikasiLogin
    '============== deklarasi
    Dim table As OleDb.OleDbDataAdapter
    Dim data As DataSet
    Dim record As New BindingSource

    '============== Pertamakali Load
    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dan_txb_username.Text = "admin"
        dan_txb_password.Text = "admin"
        dan_bt_login.Focus()
    End Sub

    Private Sub dan_bt_batal_Click(sender As Object, e As EventArgs) Handles dan_bt_batal.Click
        Me.Hide()
    End Sub

    Private Sub dan_bt_login_Click(sender As Object, e As EventArgs) Handles dan_bt_login.Click
        Try
            Call Koneksi()
            Da = New SqlDataAdapter("select dan_user_login.dan_level, dan_pegawai.dan_nm_peg from dan_user_login inner join dan_pegawai on dan_user_login.dan_kd_peg = dan_pegawai.dan_kd_peg where dan_user_login.dan_username='" & dan_txb_username.Text & "' and dan_user_login.dan_password='" & dan_txb_password.Text & "'", Conn)
            Dt = New DataTable
            Da.Fill(Dt)
            If Dt.Rows.Count > 0 Then
                'cek level login
                nama_user = Dt.Rows(0).Item(1)
                public_username = dan_txb_username.Text
                If Dt.Rows(0).Item(0) = "user" Then
                    Call userTerbuka()
                    public_level = "user"
                ElseIf Dt.Rows(0).Item(0) = "admin" Then
                    Call adnminTerbuka()
                    public_level = "admin"
                End If
                Me.Hide()
            Else
                MsgBox("Username Atau Password Tidak Cokok", MsgBoxStyle.Exclamation, "Perhatian !!!")
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Error !!!")
        End Try
    End Sub

    Private Sub dan_txb_username_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dan_txb_username.KeyPress
        If e.KeyChar = Chr(13) Then
            dan_txb_password.Focus()
            Return
        End If
        ' membatasi karakter yang di input
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyz1234567890@_-!#"
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
        If e.KeyChar = Chr(13) Then
            dan_bt_login.Focus()
            Return
        End If
        ' membatasi karakter yang di input
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyz1234567890@_-!#"
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
        'memberikan informasi ketika mencapai batas karakter
        If dan_txb_password.TextLength = 20 Then
            MsgBox("Maaf anda telah mencapai batas karakter !!!", MsgBoxStyle.Information, "Pesan !!!")
        End If
    End Sub

End Class