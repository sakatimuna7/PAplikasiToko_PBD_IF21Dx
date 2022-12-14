<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DanFrmAplikasiMasterPegawai
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
        Me.dan_dtp_ttgl = New System.Windows.Forms.DateTimePicker()
        Me.dan_bt_tambah = New System.Windows.Forms.Button()
        Me.dan_tbl_pegawai = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dan_txb_kp = New System.Windows.Forms.TextBox()
        Me.dan_txb_npeg = New System.Windows.Forms.TextBox()
        Me.dan_txb_tl = New System.Windows.Forms.TextBox()
        Me.dan_txb_telp = New System.Windows.Forms.TextBox()
        Me.dan_cbx_pen = New System.Windows.Forms.ComboBox()
        Me.dan_cbx_jab = New System.Windows.Forms.ComboBox()
        Me.dan_txb_cari = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.dan_bt_edit = New System.Windows.Forms.Button()
        Me.dan_bt_hapus = New System.Windows.Forms.Button()
        Me.dan_bt_bersih = New System.Windows.Forms.Button()
        Me.dan_bt_keluar = New System.Windows.Forms.Button()
        Me.dan_rtxb_alamat = New System.Windows.Forms.RichTextBox()
        CType(Me.dan_tbl_pegawai, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dan_dtp_ttgl
        '
        Me.dan_dtp_ttgl.Location = New System.Drawing.Point(186, 388)
        Me.dan_dtp_ttgl.Name = "dan_dtp_ttgl"
        Me.dan_dtp_ttgl.Size = New System.Drawing.Size(151, 20)
        Me.dan_dtp_ttgl.TabIndex = 0
        '
        'dan_bt_tambah
        '
        Me.dan_bt_tambah.Location = New System.Drawing.Point(20, 474)
        Me.dan_bt_tambah.Name = "dan_bt_tambah"
        Me.dan_bt_tambah.Size = New System.Drawing.Size(189, 41)
        Me.dan_bt_tambah.TabIndex = 2
        Me.dan_bt_tambah.Text = "Tambah"
        Me.dan_bt_tambah.UseVisualStyleBackColor = True
        '
        'dan_tbl_pegawai
        '
        Me.dan_tbl_pegawai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dan_tbl_pegawai.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8})
        Me.dan_tbl_pegawai.Location = New System.Drawing.Point(17, 32)
        Me.dan_tbl_pegawai.Name = "dan_tbl_pegawai"
        Me.dan_tbl_pegawai.Size = New System.Drawing.Size(843, 156)
        Me.dan_tbl_pegawai.TabIndex = 3
        '
        'Column1
        '
        Me.Column1.HeaderText = "Kode Pegawai"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Nama Pegawai"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Tempat Lahir"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Tanggal Lahir"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Pendidikan"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.HeaderText = "Jabatan"
        Me.Column6.Name = "Column6"
        '
        'Column7
        '
        Me.Column7.HeaderText = "No. Telepon"
        Me.Column7.Name = "Column7"
        '
        'Column8
        '
        Me.Column8.HeaderText = "Alamat"
        Me.Column8.Name = "Column8"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(370, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(205, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "TABEL DATA PEGAWAI"
        '
        'LineShape2
        '
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 17
        Me.LineShape2.X2 = 861
        Me.LineShape2.Y1 = 19
        Me.LineShape2.Y2 = 19
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape3, Me.LineShape1, Me.LineShape2})
        Me.ShapeContainer1.Size = New System.Drawing.Size(876, 527)
        Me.ShapeContainer1.TabIndex = 5
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape3
        '
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 20
        Me.LineShape3.X2 = 864
        Me.LineShape3.Y1 = 463
        Me.LineShape3.Y2 = 463
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 19
        Me.LineShape1.X2 = 863
        Me.LineShape1.Y1 = 247
        Me.LineShape1.Y2 = 247
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(58, 285)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Kode Pegawai"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(58, 320)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 16)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Nama Pegawai"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(58, 355)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 16)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Tempat Lahir"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(59, 392)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 16)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Tanggal Lahir"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(463, 387)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 16)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Alamat"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(463, 354)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 16)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "No. Telepon"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(463, 322)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 16)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Jabatan"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(463, 287)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(76, 16)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Pendidikan"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(370, 238)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(205, 20)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "TABEL DATA PEGAWAI"
        '
        'dan_txb_kp
        '
        Me.dan_txb_kp.Location = New System.Drawing.Point(185, 286)
        Me.dan_txb_kp.Name = "dan_txb_kp"
        Me.dan_txb_kp.Size = New System.Drawing.Size(173, 20)
        Me.dan_txb_kp.TabIndex = 15
        '
        'dan_txb_npeg
        '
        Me.dan_txb_npeg.Location = New System.Drawing.Point(185, 318)
        Me.dan_txb_npeg.Name = "dan_txb_npeg"
        Me.dan_txb_npeg.Size = New System.Drawing.Size(248, 20)
        Me.dan_txb_npeg.TabIndex = 16
        '
        'dan_txb_tl
        '
        Me.dan_txb_tl.Location = New System.Drawing.Point(185, 352)
        Me.dan_txb_tl.Name = "dan_txb_tl"
        Me.dan_txb_tl.Size = New System.Drawing.Size(248, 20)
        Me.dan_txb_tl.TabIndex = 17
        '
        'dan_txb_telp
        '
        Me.dan_txb_telp.Location = New System.Drawing.Point(565, 352)
        Me.dan_txb_telp.Name = "dan_txb_telp"
        Me.dan_txb_telp.Size = New System.Drawing.Size(272, 20)
        Me.dan_txb_telp.TabIndex = 18
        '
        'dan_cbx_pen
        '
        Me.dan_cbx_pen.FormattingEnabled = True
        Me.dan_cbx_pen.Location = New System.Drawing.Point(565, 286)
        Me.dan_cbx_pen.Name = "dan_cbx_pen"
        Me.dan_cbx_pen.Size = New System.Drawing.Size(270, 21)
        Me.dan_cbx_pen.TabIndex = 19
        '
        'dan_cbx_jab
        '
        Me.dan_cbx_jab.FormattingEnabled = True
        Me.dan_cbx_jab.Location = New System.Drawing.Point(565, 317)
        Me.dan_cbx_jab.Name = "dan_cbx_jab"
        Me.dan_cbx_jab.Size = New System.Drawing.Size(270, 21)
        Me.dan_cbx_jab.TabIndex = 20
        '
        'dan_txb_cari
        '
        Me.dan_txb_cari.Location = New System.Drawing.Point(582, 202)
        Me.dan_txb_cari.Name = "dan_txb_cari"
        Me.dan_txb_cari.Size = New System.Drawing.Size(278, 20)
        Me.dan_txb_cari.TabIndex = 22
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(483, 206)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(88, 16)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Cari Pegawai"
        '
        'dan_bt_edit
        '
        Me.dan_bt_edit.Location = New System.Drawing.Point(215, 474)
        Me.dan_bt_edit.Name = "dan_bt_edit"
        Me.dan_bt_edit.Size = New System.Drawing.Size(191, 41)
        Me.dan_bt_edit.TabIndex = 24
        Me.dan_bt_edit.Text = "Edit"
        Me.dan_bt_edit.UseVisualStyleBackColor = True
        '
        'dan_bt_hapus
        '
        Me.dan_bt_hapus.Location = New System.Drawing.Point(412, 474)
        Me.dan_bt_hapus.Name = "dan_bt_hapus"
        Me.dan_bt_hapus.Size = New System.Drawing.Size(183, 41)
        Me.dan_bt_hapus.TabIndex = 25
        Me.dan_bt_hapus.Text = "Hapus"
        Me.dan_bt_hapus.UseVisualStyleBackColor = True
        '
        'dan_bt_bersih
        '
        Me.dan_bt_bersih.Location = New System.Drawing.Point(601, 474)
        Me.dan_bt_bersih.Name = "dan_bt_bersih"
        Me.dan_bt_bersih.Size = New System.Drawing.Size(183, 41)
        Me.dan_bt_bersih.TabIndex = 26
        Me.dan_bt_bersih.Text = "Bersih"
        Me.dan_bt_bersih.UseVisualStyleBackColor = True
        '
        'dan_bt_keluar
        '
        Me.dan_bt_keluar.Location = New System.Drawing.Point(790, 474)
        Me.dan_bt_keluar.Name = "dan_bt_keluar"
        Me.dan_bt_keluar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dan_bt_keluar.Size = New System.Drawing.Size(75, 41)
        Me.dan_bt_keluar.TabIndex = 27
        Me.dan_bt_keluar.Text = "Keluar"
        Me.dan_bt_keluar.UseVisualStyleBackColor = True
        '
        'dan_rtxb_alamat
        '
        Me.dan_rtxb_alamat.Location = New System.Drawing.Point(565, 387)
        Me.dan_rtxb_alamat.Name = "dan_rtxb_alamat"
        Me.dan_rtxb_alamat.Size = New System.Drawing.Size(272, 57)
        Me.dan_rtxb_alamat.TabIndex = 28
        Me.dan_rtxb_alamat.Text = ""
        '
        'DanFrmAplikasiMasterPegawai
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(876, 527)
        Me.Controls.Add(Me.dan_rtxb_alamat)
        Me.Controls.Add(Me.dan_bt_keluar)
        Me.Controls.Add(Me.dan_bt_bersih)
        Me.Controls.Add(Me.dan_bt_hapus)
        Me.Controls.Add(Me.dan_bt_edit)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.dan_txb_cari)
        Me.Controls.Add(Me.dan_cbx_jab)
        Me.Controls.Add(Me.dan_cbx_pen)
        Me.Controls.Add(Me.dan_txb_telp)
        Me.Controls.Add(Me.dan_txb_tl)
        Me.Controls.Add(Me.dan_txb_npeg)
        Me.Controls.Add(Me.dan_txb_kp)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dan_tbl_pegawai)
        Me.Controls.Add(Me.dan_bt_tambah)
        Me.Controls.Add(Me.dan_dtp_ttgl)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "DanFrmAplikasiMasterPegawai"
        Me.Text = "Dan Form Aplikasi Master Pegawai"
        CType(Me.dan_tbl_pegawai, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dan_dtp_ttgl As System.Windows.Forms.DateTimePicker
    Friend WithEvents dan_bt_tambah As System.Windows.Forms.Button
    Friend WithEvents dan_tbl_pegawai As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents dan_txb_kp As System.Windows.Forms.TextBox
    Friend WithEvents dan_txb_npeg As System.Windows.Forms.TextBox
    Friend WithEvents dan_txb_tl As System.Windows.Forms.TextBox
    Friend WithEvents dan_txb_telp As System.Windows.Forms.TextBox
    Friend WithEvents dan_cbx_pen As System.Windows.Forms.ComboBox
    Friend WithEvents dan_cbx_jab As System.Windows.Forms.ComboBox
    Friend WithEvents dan_txb_cari As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents dan_bt_edit As System.Windows.Forms.Button
    Friend WithEvents dan_bt_hapus As System.Windows.Forms.Button
    Friend WithEvents dan_bt_bersih As System.Windows.Forms.Button
    Friend WithEvents dan_bt_keluar As System.Windows.Forms.Button
    Friend WithEvents dan_rtxb_alamat As System.Windows.Forms.RichTextBox
End Class
