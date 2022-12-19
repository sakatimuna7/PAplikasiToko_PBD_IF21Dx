Public Class DanDialogCekPassword
    Dim i As Integer
    Private Sub DanFrmCekPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dan_txb_password.UseSystemPasswordChar = True
        dan_txb_password.Text = ""
        i = 0
        dan_txb_password.Focus()
    End Sub

    Private Sub dan_txb_password_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dan_txb_password.KeyPress
        If e.KeyChar = Chr(13) Then
            dan_bt_ok_Click(sender, e)
            Return
        End If
    End Sub

    Private Sub dan_bt_ok_Click(sender As Object, e As EventArgs) Handles dan_bt_ok.Click
        If dan_cek_password(dan_txb_password.Text) Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Else
            MsgBox("Password Yang Anda Masukan Salah " & i & "x", MsgBoxStyle.Exclamation, "Peringatan !!!")
            i += 1
        End If
        If i > 3 Then
            MsgBox("Terlalu Banyak Melakukan Percobaan", MsgBoxStyle.Exclamation, "Peringatan !!!")
            Me.Close()
        End If
    End Sub

    Private Sub dan_bt_batal_Click(sender As Object, e As EventArgs) Handles dan_bt_batal.Click
        Me.Close()
    End Sub

End Class