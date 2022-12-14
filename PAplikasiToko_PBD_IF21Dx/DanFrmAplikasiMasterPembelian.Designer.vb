<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DanFrmAplikasiMasterPembelian
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.dan_tbl_pembelian = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dan_txb_cari = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dan_txb_kdtrans = New System.Windows.Forms.TextBox()
        Me.dan_txb_ks = New System.Windows.Forms.TextBox()
        Me.dan_txb_kb = New System.Windows.Forms.TextBox()
        Me.dan_txb_jumbel = New System.Windows.Forms.TextBox()
        Me.dan_txb_hrgbel = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dan_dtp_trans = New System.Windows.Forms.DateTimePicker()
        Me.dan_bt_keluar = New System.Windows.Forms.Button()
        Me.dan_bt_bersih = New System.Windows.Forms.Button()
        Me.dan_bt_hapus = New System.Windows.Forms.Button()
        Me.dan_bt_edit = New System.Windows.Forms.Button()
        Me.dan_bt_tambah = New System.Windows.Forms.Button()
        CType(Me.dan_tbl_pembelian, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(454, 206)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 16)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Cari "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(242, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(223, 20)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "TABEL DATA PEMBELIAN"
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 11
        Me.LineShape1.X2 = 685
        Me.LineShape1.Y1 = 19
        Me.LineShape1.Y2 = 19
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape3, Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(700, 469)
        Me.ShapeContainer1.TabIndex = 10
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape3
        '
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 14
        Me.LineShape3.X2 = 688
        Me.LineShape3.Y1 = 401
        Me.LineShape3.Y2 = 401
        '
        'LineShape2
        '
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 10
        Me.LineShape2.X2 = 684
        Me.LineShape2.Y1 = 238
        Me.LineShape2.Y2 = 238
        '
        'dan_tbl_pembelian
        '
        Me.dan_tbl_pembelian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dan_tbl_pembelian.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        Me.dan_tbl_pembelian.Location = New System.Drawing.Point(25, 32)
        Me.dan_tbl_pembelian.Name = "dan_tbl_pembelian"
        Me.dan_tbl_pembelian.Size = New System.Drawing.Size(644, 150)
        Me.dan_tbl_pembelian.TabIndex = 11
        '
        'Column1
        '
        Me.Column1.HeaderText = "Kode Pembelian"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Tanggal Pembelian"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Kode Supplier"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Kode Barang"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Jumlah Pembelian"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.HeaderText = "Harga Beli"
        Me.Column6.Name = "Column6"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(71, 227)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(324, 20)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "INPUT DATA TRANSAKSI PEMBELIAN"
        '
        'dan_txb_cari
        '
        Me.dan_txb_cari.Location = New System.Drawing.Point(495, 202)
        Me.dan_txb_cari.Name = "dan_txb_cari"
        Me.dan_txb_cari.Size = New System.Drawing.Size(174, 20)
        Me.dan_txb_cari.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(22, 278)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 16)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Kode Transaksi"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(22, 314)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(122, 16)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Tanggal Transaksi"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(22, 352)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 16)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Kode Supplier"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(348, 278)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 16)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Kode Barang"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(348, 314)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(119, 16)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Jumlah Pembelian"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(348, 352)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 16)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Harga Beli"
        '
        'dan_txb_kdtrans
        '
        Me.dan_txb_kdtrans.Location = New System.Drawing.Point(151, 274)
        Me.dan_txb_kdtrans.Name = "dan_txb_kdtrans"
        Me.dan_txb_kdtrans.Size = New System.Drawing.Size(157, 20)
        Me.dan_txb_kdtrans.TabIndex = 20
        '
        'dan_txb_ks
        '
        Me.dan_txb_ks.Location = New System.Drawing.Point(151, 348)
        Me.dan_txb_ks.Name = "dan_txb_ks"
        Me.dan_txb_ks.Size = New System.Drawing.Size(157, 20)
        Me.dan_txb_ks.TabIndex = 22
        '
        'dan_txb_kb
        '
        Me.dan_txb_kb.Location = New System.Drawing.Point(489, 274)
        Me.dan_txb_kb.Name = "dan_txb_kb"
        Me.dan_txb_kb.Size = New System.Drawing.Size(110, 20)
        Me.dan_txb_kb.TabIndex = 23
        '
        'dan_txb_jumbel
        '
        Me.dan_txb_jumbel.Location = New System.Drawing.Point(489, 310)
        Me.dan_txb_jumbel.Name = "dan_txb_jumbel"
        Me.dan_txb_jumbel.Size = New System.Drawing.Size(180, 20)
        Me.dan_txb_jumbel.TabIndex = 24
        '
        'dan_txb_hrgbel
        '
        Me.dan_txb_hrgbel.Location = New System.Drawing.Point(489, 348)
        Me.dan_txb_hrgbel.Name = "dan_txb_hrgbel"
        Me.dan_txb_hrgbel.Size = New System.Drawing.Size(180, 20)
        Me.dan_txb_hrgbel.TabIndex = 25
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(454, 350)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(29, 16)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "Rp."
        '
        'dan_dtp_trans
        '
        Me.dan_dtp_trans.Location = New System.Drawing.Point(151, 314)
        Me.dan_dtp_trans.Name = "dan_dtp_trans"
        Me.dan_dtp_trans.Size = New System.Drawing.Size(191, 20)
        Me.dan_dtp_trans.TabIndex = 27
        '
        'dan_bt_keluar
        '
        Me.dan_bt_keluar.Location = New System.Drawing.Point(610, 416)
        Me.dan_bt_keluar.Name = "dan_bt_keluar"
        Me.dan_bt_keluar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dan_bt_keluar.Size = New System.Drawing.Size(75, 41)
        Me.dan_bt_keluar.TabIndex = 32
        Me.dan_bt_keluar.Text = "Keluar"
        Me.dan_bt_keluar.UseVisualStyleBackColor = True
        '
        'dan_bt_bersih
        '
        Me.dan_bt_bersih.Location = New System.Drawing.Point(483, 416)
        Me.dan_bt_bersih.Name = "dan_bt_bersih"
        Me.dan_bt_bersih.Size = New System.Drawing.Size(121, 41)
        Me.dan_bt_bersih.TabIndex = 31
        Me.dan_bt_bersih.Text = "Bersih"
        Me.dan_bt_bersih.UseVisualStyleBackColor = True
        '
        'dan_bt_hapus
        '
        Me.dan_bt_hapus.Location = New System.Drawing.Point(356, 416)
        Me.dan_bt_hapus.Name = "dan_bt_hapus"
        Me.dan_bt_hapus.Size = New System.Drawing.Size(121, 41)
        Me.dan_bt_hapus.TabIndex = 30
        Me.dan_bt_hapus.Text = "Hapus"
        Me.dan_bt_hapus.UseVisualStyleBackColor = True
        '
        'dan_bt_edit
        '
        Me.dan_bt_edit.Location = New System.Drawing.Point(200, 416)
        Me.dan_bt_edit.Name = "dan_bt_edit"
        Me.dan_bt_edit.Size = New System.Drawing.Size(150, 41)
        Me.dan_bt_edit.TabIndex = 29
        Me.dan_bt_edit.Text = "Edit"
        Me.dan_bt_edit.UseVisualStyleBackColor = True
        '
        'dan_bt_tambah
        '
        Me.dan_bt_tambah.Location = New System.Drawing.Point(15, 416)
        Me.dan_bt_tambah.Name = "dan_bt_tambah"
        Me.dan_bt_tambah.Size = New System.Drawing.Size(179, 41)
        Me.dan_bt_tambah.TabIndex = 28
        Me.dan_bt_tambah.Text = "Tambah"
        Me.dan_bt_tambah.UseVisualStyleBackColor = True
        '
        'DanFrmAplikasiMasterPembelian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(700, 469)
        Me.Controls.Add(Me.dan_bt_keluar)
        Me.Controls.Add(Me.dan_bt_bersih)
        Me.Controls.Add(Me.dan_bt_hapus)
        Me.Controls.Add(Me.dan_bt_edit)
        Me.Controls.Add(Me.dan_bt_tambah)
        Me.Controls.Add(Me.dan_dtp_trans)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.dan_txb_hrgbel)
        Me.Controls.Add(Me.dan_txb_jumbel)
        Me.Controls.Add(Me.dan_txb_kb)
        Me.Controls.Add(Me.dan_txb_ks)
        Me.Controls.Add(Me.dan_txb_kdtrans)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dan_txb_cari)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dan_tbl_pembelian)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "DanFrmAplikasiMasterPembelian"
        Me.Text = "Dan From Master Pembelian"
        CType(Me.dan_tbl_pembelian, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents dan_tbl_pembelian As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dan_txb_cari As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents dan_txb_kdtrans As System.Windows.Forms.TextBox
    Friend WithEvents dan_txb_ks As System.Windows.Forms.TextBox
    Friend WithEvents dan_txb_kb As System.Windows.Forms.TextBox
    Friend WithEvents dan_txb_jumbel As System.Windows.Forms.TextBox
    Friend WithEvents dan_txb_hrgbel As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents dan_dtp_trans As System.Windows.Forms.DateTimePicker
    Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents dan_bt_keluar As System.Windows.Forms.Button
    Friend WithEvents dan_bt_bersih As System.Windows.Forms.Button
    Friend WithEvents dan_bt_hapus As System.Windows.Forms.Button
    Friend WithEvents dan_bt_edit As System.Windows.Forms.Button
    Friend WithEvents dan_bt_tambah As System.Windows.Forms.Button
End Class
