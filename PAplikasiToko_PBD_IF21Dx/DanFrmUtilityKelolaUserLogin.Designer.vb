<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DanFrmUtilityKelolaUserLogin
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
        Me.Label11 = New System.Windows.Forms.Label()
        Me.dan_txb_cari = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dan_tbl_user_login = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dan_txb_username = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dan_lbl_nm_peg = New System.Windows.Forms.Label()
        Me.dan_txb_password = New System.Windows.Forms.TextBox()
        Me.dan_txb_kdpeg = New System.Windows.Forms.TextBox()
        Me.dan_cbx_level = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dan_bt_keluar = New System.Windows.Forms.Button()
        Me.dan_bt_bersih = New System.Windows.Forms.Button()
        Me.dan_bt_hapus = New System.Windows.Forms.Button()
        Me.dan_bt_edit = New System.Windows.Forms.Button()
        Me.dan_bt_tambah = New System.Windows.Forms.Button()
        Me.dan_chxb_pw = New System.Windows.Forms.CheckBox()
        CType(Me.dan_tbl_user_login, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(216, 203)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(64, 16)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "Cari User"
        '
        'dan_txb_cari
        '
        Me.dan_txb_cari.Location = New System.Drawing.Point(286, 201)
        Me.dan_txb_cari.Name = "dan_txb_cari"
        Me.dan_txb_cari.Size = New System.Drawing.Size(181, 20)
        Me.dan_txb_cari.TabIndex = 26
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(119, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(232, 20)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "TABEL DATA USER LOGIN"
        '
        'dan_tbl_user_login
        '
        Me.dan_tbl_user_login.AllowUserToAddRows = False
        Me.dan_tbl_user_login.AllowUserToDeleteRows = False
        Me.dan_tbl_user_login.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dan_tbl_user_login.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        Me.dan_tbl_user_login.Location = New System.Drawing.Point(12, 35)
        Me.dan_tbl_user_login.Name = "dan_tbl_user_login"
        Me.dan_tbl_user_login.ReadOnly = True
        Me.dan_tbl_user_login.Size = New System.Drawing.Size(455, 156)
        Me.dan_tbl_user_login.TabIndex = 24
        '
        'Column1
        '
        Me.Column1.HeaderText = "Username"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Nama Pegawai"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Jabatan"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "Level"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(119, 235)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(228, 20)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "INPUT DATA USER LOGIN"
        '
        'dan_txb_username
        '
        Me.dan_txb_username.Location = New System.Drawing.Point(138, 278)
        Me.dan_txb_username.Name = "dan_txb_username"
        Me.dan_txb_username.Size = New System.Drawing.Size(125, 20)
        Me.dan_txb_username.TabIndex = 29
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(27, 279)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 16)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Username"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(27, 309)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 16)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Password"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(27, 338)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 16)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Kode Pegawai"
        '
        'dan_lbl_nm_peg
        '
        Me.dan_lbl_nm_peg.AutoSize = True
        Me.dan_lbl_nm_peg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dan_lbl_nm_peg.Location = New System.Drawing.Point(283, 338)
        Me.dan_lbl_nm_peg.Name = "dan_lbl_nm_peg"
        Me.dan_lbl_nm_peg.Size = New System.Drawing.Size(0, 16)
        Me.dan_lbl_nm_peg.TabIndex = 33
        '
        'dan_txb_password
        '
        Me.dan_txb_password.Location = New System.Drawing.Point(138, 305)
        Me.dan_txb_password.Name = "dan_txb_password"
        Me.dan_txb_password.Size = New System.Drawing.Size(162, 20)
        Me.dan_txb_password.TabIndex = 34
        '
        'dan_txb_kdpeg
        '
        Me.dan_txb_kdpeg.Location = New System.Drawing.Point(138, 334)
        Me.dan_txb_kdpeg.Name = "dan_txb_kdpeg"
        Me.dan_txb_kdpeg.Size = New System.Drawing.Size(125, 20)
        Me.dan_txb_kdpeg.TabIndex = 35
        '
        'dan_cbx_level
        '
        Me.dan_cbx_level.FormattingEnabled = True
        Me.dan_cbx_level.Location = New System.Drawing.Point(138, 365)
        Me.dan_cbx_level.Name = "dan_cbx_level"
        Me.dan_cbx_level.Size = New System.Drawing.Size(125, 21)
        Me.dan_cbx_level.TabIndex = 36
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(27, 366)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 16)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "Level"
        '
        'dan_bt_keluar
        '
        Me.dan_bt_keluar.Location = New System.Drawing.Point(390, 407)
        Me.dan_bt_keluar.Name = "dan_bt_keluar"
        Me.dan_bt_keluar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dan_bt_keluar.Size = New System.Drawing.Size(67, 41)
        Me.dan_bt_keluar.TabIndex = 42
        Me.dan_bt_keluar.Text = "Keluar"
        Me.dan_bt_keluar.UseVisualStyleBackColor = True
        '
        'dan_bt_bersih
        '
        Me.dan_bt_bersih.Location = New System.Drawing.Point(293, 407)
        Me.dan_bt_bersih.Name = "dan_bt_bersih"
        Me.dan_bt_bersih.Size = New System.Drawing.Size(91, 41)
        Me.dan_bt_bersih.TabIndex = 41
        Me.dan_bt_bersih.Text = "Bersih"
        Me.dan_bt_bersih.UseVisualStyleBackColor = True
        '
        'dan_bt_hapus
        '
        Me.dan_bt_hapus.Location = New System.Drawing.Point(199, 407)
        Me.dan_bt_hapus.Name = "dan_bt_hapus"
        Me.dan_bt_hapus.Size = New System.Drawing.Size(88, 41)
        Me.dan_bt_hapus.TabIndex = 40
        Me.dan_bt_hapus.Text = "Hapus"
        Me.dan_bt_hapus.UseVisualStyleBackColor = True
        '
        'dan_bt_edit
        '
        Me.dan_bt_edit.Location = New System.Drawing.Point(123, 407)
        Me.dan_bt_edit.Name = "dan_bt_edit"
        Me.dan_bt_edit.Size = New System.Drawing.Size(70, 41)
        Me.dan_bt_edit.TabIndex = 39
        Me.dan_bt_edit.Text = "Edit"
        Me.dan_bt_edit.UseVisualStyleBackColor = True
        '
        'dan_bt_tambah
        '
        Me.dan_bt_tambah.Location = New System.Drawing.Point(12, 407)
        Me.dan_bt_tambah.Name = "dan_bt_tambah"
        Me.dan_bt_tambah.Size = New System.Drawing.Size(105, 41)
        Me.dan_bt_tambah.TabIndex = 38
        Me.dan_bt_tambah.Text = "Tambah"
        Me.dan_bt_tambah.UseVisualStyleBackColor = True
        '
        'dan_chxb_pw
        '
        Me.dan_chxb_pw.AutoSize = True
        Me.dan_chxb_pw.Location = New System.Drawing.Point(306, 307)
        Me.dan_chxb_pw.Name = "dan_chxb_pw"
        Me.dan_chxb_pw.Size = New System.Drawing.Size(98, 17)
        Me.dan_chxb_pw.TabIndex = 43
        Me.dan_chxb_pw.Text = "Lihat Password"
        Me.dan_chxb_pw.UseVisualStyleBackColor = True
        '
        'DanFrmUtilityKelolaUserLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(479, 460)
        Me.Controls.Add(Me.dan_chxb_pw)
        Me.Controls.Add(Me.dan_bt_keluar)
        Me.Controls.Add(Me.dan_bt_bersih)
        Me.Controls.Add(Me.dan_bt_hapus)
        Me.Controls.Add(Me.dan_bt_edit)
        Me.Controls.Add(Me.dan_bt_tambah)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dan_cbx_level)
        Me.Controls.Add(Me.dan_txb_kdpeg)
        Me.Controls.Add(Me.dan_txb_password)
        Me.Controls.Add(Me.dan_lbl_nm_peg)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dan_txb_username)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.dan_txb_cari)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dan_tbl_user_login)
        Me.Name = "DanFrmUtilityKelolaUserLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Kelola User Login"
        CType(Me.dan_tbl_user_login, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents dan_txb_cari As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dan_tbl_user_login As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dan_txb_username As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dan_lbl_nm_peg As System.Windows.Forms.Label
    Friend WithEvents dan_txb_password As System.Windows.Forms.TextBox
    Friend WithEvents dan_txb_kdpeg As System.Windows.Forms.TextBox
    Friend WithEvents dan_cbx_level As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dan_bt_keluar As System.Windows.Forms.Button
    Friend WithEvents dan_bt_bersih As System.Windows.Forms.Button
    Friend WithEvents dan_bt_hapus As System.Windows.Forms.Button
    Friend WithEvents dan_bt_edit As System.Windows.Forms.Button
    Friend WithEvents dan_bt_tambah As System.Windows.Forms.Button
    Friend WithEvents dan_chxb_pw As System.Windows.Forms.CheckBox
End Class
