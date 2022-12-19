<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DanFrmUtilityUser
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.dan_chxb_pw = New System.Windows.Forms.CheckBox()
        Me.dan_bt_keluar = New System.Windows.Forms.Button()
        Me.dan_bt_edit = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dan_cbx_level = New System.Windows.Forms.ComboBox()
        Me.dan_txb_kdpeg = New System.Windows.Forms.TextBox()
        Me.dan_txb_password = New System.Windows.Forms.TextBox()
        Me.dan_lbl_nm_peg = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dan_txb_username = New System.Windows.Forms.TextBox()
        Me.dan_bt_simpan = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'dan_chxb_pw
        '
        Me.dan_chxb_pw.AutoSize = True
        Me.dan_chxb_pw.Location = New System.Drawing.Point(228, 72)
        Me.dan_chxb_pw.Name = "dan_chxb_pw"
        Me.dan_chxb_pw.Size = New System.Drawing.Size(98, 17)
        Me.dan_chxb_pw.TabIndex = 58
        Me.dan_chxb_pw.Text = "Lihat Password"
        Me.dan_chxb_pw.UseVisualStyleBackColor = True
        '
        'dan_bt_keluar
        '
        Me.dan_bt_keluar.Location = New System.Drawing.Point(228, 172)
        Me.dan_bt_keluar.Name = "dan_bt_keluar"
        Me.dan_bt_keluar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dan_bt_keluar.Size = New System.Drawing.Size(98, 41)
        Me.dan_bt_keluar.TabIndex = 57
        Me.dan_bt_keluar.Text = "Keluar"
        Me.dan_bt_keluar.UseVisualStyleBackColor = True
        '
        'dan_bt_edit
        '
        Me.dan_bt_edit.Location = New System.Drawing.Point(17, 172)
        Me.dan_bt_edit.Name = "dan_bt_edit"
        Me.dan_bt_edit.Size = New System.Drawing.Size(93, 41)
        Me.dan_bt_edit.TabIndex = 54
        Me.dan_bt_edit.Text = "Edit"
        Me.dan_bt_edit.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(14, 131)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 16)
        Me.Label6.TabIndex = 52
        Me.Label6.Text = "Level"
        '
        'dan_cbx_level
        '
        Me.dan_cbx_level.FormattingEnabled = True
        Me.dan_cbx_level.Location = New System.Drawing.Point(125, 130)
        Me.dan_cbx_level.Name = "dan_cbx_level"
        Me.dan_cbx_level.Size = New System.Drawing.Size(125, 21)
        Me.dan_cbx_level.TabIndex = 51
        '
        'dan_txb_kdpeg
        '
        Me.dan_txb_kdpeg.Location = New System.Drawing.Point(125, 99)
        Me.dan_txb_kdpeg.Name = "dan_txb_kdpeg"
        Me.dan_txb_kdpeg.Size = New System.Drawing.Size(125, 20)
        Me.dan_txb_kdpeg.TabIndex = 50
        '
        'dan_txb_password
        '
        Me.dan_txb_password.Location = New System.Drawing.Point(125, 70)
        Me.dan_txb_password.Name = "dan_txb_password"
        Me.dan_txb_password.Size = New System.Drawing.Size(97, 20)
        Me.dan_txb_password.TabIndex = 49
        '
        'dan_lbl_nm_peg
        '
        Me.dan_lbl_nm_peg.AutoSize = True
        Me.dan_lbl_nm_peg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dan_lbl_nm_peg.Location = New System.Drawing.Point(122, 9)
        Me.dan_lbl_nm_peg.Name = "dan_lbl_nm_peg"
        Me.dan_lbl_nm_peg.Size = New System.Drawing.Size(41, 16)
        Me.dan_lbl_nm_peg.TabIndex = 48
        Me.dan_lbl_nm_peg.Text = "User"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(14, 103)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 16)
        Me.Label5.TabIndex = 47
        Me.Label5.Text = "Kode Pegawai"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(14, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 16)
        Me.Label4.TabIndex = 46
        Me.Label4.Text = "Password"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(14, 44)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 16)
        Me.Label7.TabIndex = 45
        Me.Label7.Text = "Username"
        '
        'dan_txb_username
        '
        Me.dan_txb_username.Location = New System.Drawing.Point(125, 43)
        Me.dan_txb_username.Name = "dan_txb_username"
        Me.dan_txb_username.Size = New System.Drawing.Size(125, 20)
        Me.dan_txb_username.TabIndex = 44
        '
        'dan_bt_simpan
        '
        Me.dan_bt_simpan.Location = New System.Drawing.Point(117, 172)
        Me.dan_bt_simpan.Name = "dan_bt_simpan"
        Me.dan_bt_simpan.Size = New System.Drawing.Size(105, 41)
        Me.dan_bt_simpan.TabIndex = 59
        Me.dan_bt_simpan.Text = "Simpan"
        Me.dan_bt_simpan.UseVisualStyleBackColor = True
        '
        'DanFrmUtilityUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(338, 232)
        Me.Controls.Add(Me.dan_bt_simpan)
        Me.Controls.Add(Me.dan_chxb_pw)
        Me.Controls.Add(Me.dan_bt_keluar)
        Me.Controls.Add(Me.dan_bt_edit)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dan_cbx_level)
        Me.Controls.Add(Me.dan_txb_kdpeg)
        Me.Controls.Add(Me.dan_txb_password)
        Me.Controls.Add(Me.dan_lbl_nm_peg)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.dan_txb_username)
        Me.Name = "DanFrmUtilityUser"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "User"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dan_chxb_pw As System.Windows.Forms.CheckBox
    Friend WithEvents dan_bt_keluar As System.Windows.Forms.Button
    Friend WithEvents dan_bt_edit As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dan_cbx_level As System.Windows.Forms.ComboBox
    Friend WithEvents dan_txb_kdpeg As System.Windows.Forms.TextBox
    Friend WithEvents dan_txb_password As System.Windows.Forms.TextBox
    Friend WithEvents dan_lbl_nm_peg As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents dan_txb_username As System.Windows.Forms.TextBox
    Friend WithEvents dan_bt_simpan As System.Windows.Forms.Button
End Class
