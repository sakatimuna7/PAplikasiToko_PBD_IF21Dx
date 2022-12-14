<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DanFrmAplikasiMasterPenjualan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DanFrmAplikasiMasterPenjualan))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape4 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dan_tbl_jual = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dan_txb_kdtrans = New System.Windows.Forms.TextBox()
        Me.dan_dtp_tgl_trans = New System.Windows.Forms.DateTimePicker()
        Me.dan_txb_kdbarang = New System.Windows.Forms.TextBox()
        Me.dan_txb_nmbarang = New System.Windows.Forms.TextBox()
        Me.dan_txb_hrgjual = New System.Windows.Forms.TextBox()
        Me.dan_txb_jmlbli = New System.Windows.Forms.TextBox()
        Me.dan_txb_totharga = New System.Windows.Forms.TextBox()
        Me.dan_txb_kdpeg = New System.Windows.Forms.TextBox()
        Me.dan_txb_nmpeg = New System.Windows.Forms.TextBox()
        Me.dan_txb_total = New System.Windows.Forms.TextBox()
        Me.dan_txb_pembayaran = New System.Windows.Forms.TextBox()
        Me.dan_bt_total = New System.Windows.Forms.Button()
        Me.dan_bt_tambah = New System.Windows.Forms.Button()
        Me.dan_bt_edit = New System.Windows.Forms.Button()
        Me.dan_bt_batal = New System.Windows.Forms.Button()
        Me.dan_bt_simpan = New System.Windows.Forms.Button()
        Me.dan_bt_cetak = New System.Windows.Forms.Button()
        Me.dan_bt_keluar = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.dan_txb_kembalian = New System.Windows.Forms.TextBox()
        Me.dan_bt_hapus = New System.Windows.Forms.Button()
        Me.dan_bt_newtrans = New System.Windows.Forms.Button()
        Me.AxCrystalReportPenjualan = New AxCrystal.AxCrystalReport()
        CType(Me.dan_tbl_jual, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxCrystalReportPenjualan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(284, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(229, 20)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "TERANSAKSI PENJUALAN"
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 19
        Me.LineShape1.X2 = 762
        Me.LineShape1.Y1 = 18
        Me.LineShape1.Y2 = 18
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape4, Me.LineShape3, Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(784, 560)
        Me.ShapeContainer1.TabIndex = 11
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape4
        '
        Me.LineShape4.Name = "LineShape4"
        Me.LineShape4.X1 = 21
        Me.LineShape4.X2 = 764
        Me.LineShape4.Y1 = 269
        Me.LineShape4.Y2 = 269
        '
        'LineShape3
        '
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 21
        Me.LineShape3.X2 = 764
        Me.LineShape3.Y1 = 211
        Me.LineShape3.Y2 = 211
        '
        'LineShape2
        '
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 26
        Me.LineShape2.X2 = 769
        Me.LineShape2.Y1 = 72
        Me.LineShape2.Y2 = 72
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(33, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 16)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Kode Transaksi"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(425, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 16)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Tanggal Transaksi"
        '
        'dan_tbl_jual
        '
        Me.dan_tbl_jual.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dan_tbl_jual.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7})
        Me.dan_tbl_jual.Location = New System.Drawing.Point(19, 284)
        Me.dan_tbl_jual.Name = "dan_tbl_jual"
        Me.dan_tbl_jual.Size = New System.Drawing.Size(744, 150)
        Me.dan_tbl_jual.TabIndex = 17
        '
        'Column1
        '
        Me.Column1.HeaderText = "Kode Barang"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Nama Barang"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Harga Jual"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Jumlah"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Total Harga"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.HeaderText = "Kode Pegawai"
        Me.Column6.Name = "Column6"
        '
        'Column7
        '
        Me.Column7.HeaderText = "Nama Pegawai"
        Me.Column7.Name = "Column7"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(33, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 16)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Kode Barang"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(33, 128)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 16)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Nama Barang"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(425, 128)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 16)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Jumlah Beli"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(425, 88)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 16)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Harga Jual"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(425, 166)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 16)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Total Harga"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(33, 232)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(96, 16)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Kode Pegawai"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(425, 232)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(101, 16)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "Nama Pegawai"
        '
        'dan_txb_kdtrans
        '
        Me.dan_txb_kdtrans.Location = New System.Drawing.Point(142, 39)
        Me.dan_txb_kdtrans.Name = "dan_txb_kdtrans"
        Me.dan_txb_kdtrans.Size = New System.Drawing.Size(109, 20)
        Me.dan_txb_kdtrans.TabIndex = 26
        '
        'dan_dtp_tgl_trans
        '
        Me.dan_dtp_tgl_trans.Location = New System.Drawing.Point(563, 39)
        Me.dan_dtp_tgl_trans.Name = "dan_dtp_tgl_trans"
        Me.dan_dtp_tgl_trans.Size = New System.Drawing.Size(200, 20)
        Me.dan_dtp_tgl_trans.TabIndex = 27
        '
        'dan_txb_kdbarang
        '
        Me.dan_txb_kdbarang.Location = New System.Drawing.Point(142, 88)
        Me.dan_txb_kdbarang.Name = "dan_txb_kdbarang"
        Me.dan_txb_kdbarang.Size = New System.Drawing.Size(156, 20)
        Me.dan_txb_kdbarang.TabIndex = 28
        '
        'dan_txb_nmbarang
        '
        Me.dan_txb_nmbarang.Location = New System.Drawing.Point(142, 127)
        Me.dan_txb_nmbarang.Name = "dan_txb_nmbarang"
        Me.dan_txb_nmbarang.Size = New System.Drawing.Size(241, 20)
        Me.dan_txb_nmbarang.TabIndex = 29
        '
        'dan_txb_hrgjual
        '
        Me.dan_txb_hrgjual.Location = New System.Drawing.Point(534, 88)
        Me.dan_txb_hrgjual.Name = "dan_txb_hrgjual"
        Me.dan_txb_hrgjual.Size = New System.Drawing.Size(229, 20)
        Me.dan_txb_hrgjual.TabIndex = 30
        '
        'dan_txb_jmlbli
        '
        Me.dan_txb_jmlbli.Location = New System.Drawing.Point(534, 127)
        Me.dan_txb_jmlbli.Name = "dan_txb_jmlbli"
        Me.dan_txb_jmlbli.Size = New System.Drawing.Size(133, 20)
        Me.dan_txb_jmlbli.TabIndex = 31
        '
        'dan_txb_totharga
        '
        Me.dan_txb_totharga.Location = New System.Drawing.Point(534, 165)
        Me.dan_txb_totharga.Name = "dan_txb_totharga"
        Me.dan_txb_totharga.Size = New System.Drawing.Size(229, 20)
        Me.dan_txb_totharga.TabIndex = 32
        '
        'dan_txb_kdpeg
        '
        Me.dan_txb_kdpeg.Location = New System.Drawing.Point(142, 232)
        Me.dan_txb_kdpeg.Name = "dan_txb_kdpeg"
        Me.dan_txb_kdpeg.Size = New System.Drawing.Size(156, 20)
        Me.dan_txb_kdpeg.TabIndex = 33
        '
        'dan_txb_nmpeg
        '
        Me.dan_txb_nmpeg.Location = New System.Drawing.Point(534, 232)
        Me.dan_txb_nmpeg.Name = "dan_txb_nmpeg"
        Me.dan_txb_nmpeg.Size = New System.Drawing.Size(229, 20)
        Me.dan_txb_nmpeg.TabIndex = 34
        '
        'dan_txb_total
        '
        Me.dan_txb_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dan_txb_total.Location = New System.Drawing.Point(142, 444)
        Me.dan_txb_total.Name = "dan_txb_total"
        Me.dan_txb_total.Size = New System.Drawing.Size(213, 31)
        Me.dan_txb_total.TabIndex = 35
        '
        'dan_txb_pembayaran
        '
        Me.dan_txb_pembayaran.Location = New System.Drawing.Point(142, 489)
        Me.dan_txb_pembayaran.Name = "dan_txb_pembayaran"
        Me.dan_txb_pembayaran.Size = New System.Drawing.Size(156, 20)
        Me.dan_txb_pembayaran.TabIndex = 36
        '
        'dan_bt_total
        '
        Me.dan_bt_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dan_bt_total.Location = New System.Drawing.Point(19, 441)
        Me.dan_bt_total.Name = "dan_bt_total"
        Me.dan_bt_total.Size = New System.Drawing.Size(110, 37)
        Me.dan_bt_total.TabIndex = 37
        Me.dan_bt_total.Text = "Total"
        Me.dan_bt_total.UseVisualStyleBackColor = True
        '
        'dan_bt_tambah
        '
        Me.dan_bt_tambah.Location = New System.Drawing.Point(397, 440)
        Me.dan_bt_tambah.Name = "dan_bt_tambah"
        Me.dan_bt_tambah.Size = New System.Drawing.Size(93, 38)
        Me.dan_bt_tambah.TabIndex = 38
        Me.dan_bt_tambah.Text = "Tambah"
        Me.dan_bt_tambah.UseVisualStyleBackColor = True
        '
        'dan_bt_edit
        '
        Me.dan_bt_edit.Location = New System.Drawing.Point(496, 440)
        Me.dan_bt_edit.Name = "dan_bt_edit"
        Me.dan_bt_edit.Size = New System.Drawing.Size(85, 37)
        Me.dan_bt_edit.TabIndex = 39
        Me.dan_bt_edit.Text = "Edit"
        Me.dan_bt_edit.UseVisualStyleBackColor = True
        '
        'dan_bt_batal
        '
        Me.dan_bt_batal.Location = New System.Drawing.Point(670, 440)
        Me.dan_bt_batal.Name = "dan_bt_batal"
        Me.dan_bt_batal.Size = New System.Drawing.Size(93, 37)
        Me.dan_bt_batal.TabIndex = 40
        Me.dan_bt_batal.Text = "Batal"
        Me.dan_bt_batal.UseVisualStyleBackColor = True
        '
        'dan_bt_simpan
        '
        Me.dan_bt_simpan.Location = New System.Drawing.Point(396, 506)
        Me.dan_bt_simpan.Name = "dan_bt_simpan"
        Me.dan_bt_simpan.Size = New System.Drawing.Size(130, 37)
        Me.dan_bt_simpan.TabIndex = 41
        Me.dan_bt_simpan.Text = "Simpan/ Cetak"
        Me.dan_bt_simpan.UseVisualStyleBackColor = True
        '
        'dan_bt_cetak
        '
        Me.dan_bt_cetak.Location = New System.Drawing.Point(534, 506)
        Me.dan_bt_cetak.Name = "dan_bt_cetak"
        Me.dan_bt_cetak.Size = New System.Drawing.Size(130, 37)
        Me.dan_bt_cetak.TabIndex = 42
        Me.dan_bt_cetak.Text = "Cetak"
        Me.dan_bt_cetak.UseVisualStyleBackColor = True
        '
        'dan_bt_keluar
        '
        Me.dan_bt_keluar.Location = New System.Drawing.Point(670, 506)
        Me.dan_bt_keluar.Name = "dan_bt_keluar"
        Me.dan_bt_keluar.Size = New System.Drawing.Size(93, 37)
        Me.dan_bt_keluar.TabIndex = 43
        Me.dan_bt_keluar.Text = "Keluar"
        Me.dan_bt_keluar.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(23, 493)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(86, 16)
        Me.Label11.TabIndex = 44
        Me.Label11.Text = "Pembayaran"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(23, 527)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(72, 16)
        Me.Label12.TabIndex = 45
        Me.Label12.Text = "Kembalian"
        '
        'dan_txb_kembalian
        '
        Me.dan_txb_kembalian.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dan_txb_kembalian.Location = New System.Drawing.Point(142, 518)
        Me.dan_txb_kembalian.Name = "dan_txb_kembalian"
        Me.dan_txb_kembalian.Size = New System.Drawing.Size(213, 31)
        Me.dan_txb_kembalian.TabIndex = 46
        '
        'dan_bt_hapus
        '
        Me.dan_bt_hapus.Location = New System.Drawing.Point(587, 440)
        Me.dan_bt_hapus.Name = "dan_bt_hapus"
        Me.dan_bt_hapus.Size = New System.Drawing.Size(77, 38)
        Me.dan_bt_hapus.TabIndex = 47
        Me.dan_bt_hapus.Text = "Hapus"
        Me.dan_bt_hapus.UseVisualStyleBackColor = True
        '
        'dan_bt_newtrans
        '
        Me.dan_bt_newtrans.Location = New System.Drawing.Point(257, 37)
        Me.dan_bt_newtrans.Name = "dan_bt_newtrans"
        Me.dan_bt_newtrans.Size = New System.Drawing.Size(126, 23)
        Me.dan_bt_newtrans.TabIndex = 48
        Me.dan_bt_newtrans.Text = "Transaksi Baru"
        Me.dan_bt_newtrans.UseVisualStyleBackColor = True
        '
        'AxCrystalReportPenjualan
        '
        Me.AxCrystalReportPenjualan.Enabled = True
        Me.AxCrystalReportPenjualan.Location = New System.Drawing.Point(36, 166)
        Me.AxCrystalReportPenjualan.Name = "AxCrystalReportPenjualan"
        Me.AxCrystalReportPenjualan.OcxState = CType(resources.GetObject("AxCrystalReportPenjualan.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxCrystalReportPenjualan.Size = New System.Drawing.Size(28, 28)
        Me.AxCrystalReportPenjualan.TabIndex = 49
        '
        'DanFrmAplikasiMasterPenjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 560)
        Me.Controls.Add(Me.AxCrystalReportPenjualan)
        Me.Controls.Add(Me.dan_bt_newtrans)
        Me.Controls.Add(Me.dan_bt_hapus)
        Me.Controls.Add(Me.dan_txb_kembalian)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.dan_bt_keluar)
        Me.Controls.Add(Me.dan_bt_cetak)
        Me.Controls.Add(Me.dan_bt_simpan)
        Me.Controls.Add(Me.dan_bt_batal)
        Me.Controls.Add(Me.dan_bt_edit)
        Me.Controls.Add(Me.dan_bt_tambah)
        Me.Controls.Add(Me.dan_bt_total)
        Me.Controls.Add(Me.dan_txb_pembayaran)
        Me.Controls.Add(Me.dan_txb_total)
        Me.Controls.Add(Me.dan_txb_nmpeg)
        Me.Controls.Add(Me.dan_txb_kdpeg)
        Me.Controls.Add(Me.dan_txb_totharga)
        Me.Controls.Add(Me.dan_txb_jmlbli)
        Me.Controls.Add(Me.dan_txb_hrgjual)
        Me.Controls.Add(Me.dan_txb_nmbarang)
        Me.Controls.Add(Me.dan_txb_kdbarang)
        Me.Controls.Add(Me.dan_dtp_tgl_trans)
        Me.Controls.Add(Me.dan_txb_kdtrans)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dan_tbl_jual)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "DanFrmAplikasiMasterPenjualan"
        Me.Text = "DanFrmAplikasiMasterPenjualan"
        CType(Me.dan_tbl_jual, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxCrystalReportPenjualan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape4 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dan_tbl_jual As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents dan_txb_kdtrans As System.Windows.Forms.TextBox
    Friend WithEvents dan_dtp_tgl_trans As System.Windows.Forms.DateTimePicker
    Friend WithEvents dan_txb_kdbarang As System.Windows.Forms.TextBox
    Friend WithEvents dan_txb_nmbarang As System.Windows.Forms.TextBox
    Friend WithEvents dan_txb_hrgjual As System.Windows.Forms.TextBox
    Friend WithEvents dan_txb_jmlbli As System.Windows.Forms.TextBox
    Friend WithEvents dan_txb_totharga As System.Windows.Forms.TextBox
    Friend WithEvents dan_txb_kdpeg As System.Windows.Forms.TextBox
    Friend WithEvents dan_txb_nmpeg As System.Windows.Forms.TextBox
    Friend WithEvents dan_txb_total As System.Windows.Forms.TextBox
    Friend WithEvents dan_txb_pembayaran As System.Windows.Forms.TextBox
    Friend WithEvents dan_bt_total As System.Windows.Forms.Button
    Friend WithEvents dan_bt_tambah As System.Windows.Forms.Button
    Friend WithEvents dan_bt_edit As System.Windows.Forms.Button
    Friend WithEvents dan_bt_batal As System.Windows.Forms.Button
    Friend WithEvents dan_bt_simpan As System.Windows.Forms.Button
    Friend WithEvents dan_bt_cetak As System.Windows.Forms.Button
    Friend WithEvents dan_bt_keluar As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents dan_txb_kembalian As System.Windows.Forms.TextBox
    Friend WithEvents dan_bt_hapus As System.Windows.Forms.Button
    Friend WithEvents dan_bt_newtrans As System.Windows.Forms.Button
    Friend WithEvents AxCrystalReportPenjualan As AxCrystal.AxCrystalReport
End Class
