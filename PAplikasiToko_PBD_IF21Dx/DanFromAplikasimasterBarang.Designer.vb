<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DanFromAplikasimasterBarang
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbl_brg = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Db_toko_if21dx = New PAplikasiToko_PBD_IF21Dx.db_toko_if21dx()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txb_kode_barang = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txb_nama_barang = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txb_diskon = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txb_harga_jual = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txb_jumlah_barang = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txb_rusak = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txb_sisa_barang = New System.Windows.Forms.TextBox()
        Me.bt_tambah = New System.Windows.Forms.Button()
        Me.bt_edit = New System.Windows.Forms.Button()
        Me.bt_hapus = New System.Windows.Forms.Button()
        Me.bt_keluar = New System.Windows.Forms.Button()
        Me.Dbtokoif21dxBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btn_bersih = New System.Windows.Forms.Button()
        Me.txb_cari = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        CType(Me.tbl_brg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Db_toko_if21dx, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dbtokoif21dxBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(302, 14)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(197, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "TABEL DATA BARANG"
        '
        'tbl_brg
        '
        Me.tbl_brg.AutoGenerateColumns = False
        Me.tbl_brg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tbl_brg.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7})
        Me.tbl_brg.DataSource = Me.Db_toko_if21dx
        Me.tbl_brg.Location = New System.Drawing.Point(17, 56)
        Me.tbl_brg.Name = "tbl_brg"
        Me.tbl_brg.Size = New System.Drawing.Size(744, 169)
        Me.tbl_brg.TabIndex = 1
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
        Me.Column3.HeaderText = "Diskon"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Harga Jual"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Jumlah Barang"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.HeaderText = "Rusak"
        Me.Column6.Name = "Column6"
        '
        'Column7
        '
        Me.Column7.HeaderText = "Sisa Barang"
        Me.Column7.Name = "Column7"
        '
        'Db_toko_if21dx
        '
        Me.Db_toko_if21dx.DataSetName = "db_toko_if21dx"
        Me.Db_toko_if21dx.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape3, Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(775, 598)
        Me.ShapeContainer1.TabIndex = 2
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape3
        '
        Me.LineShape3.Cursor = System.Windows.Forms.Cursors.Default
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 16
        Me.LineShape3.X2 = 759
        Me.LineShape3.Y1 = 286
        Me.LineShape3.Y2 = 286
        '
        'LineShape2
        '
        Me.LineShape2.Cursor = System.Windows.Forms.Cursors.Default
        Me.LineShape2.Name = "LineShape1"
        Me.LineShape2.X1 = 20
        Me.LineShape2.X2 = 763
        Me.LineShape2.Y1 = 511
        Me.LineShape2.Y2 = 511
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 17
        Me.LineShape1.X2 = 760
        Me.LineShape1.Y1 = 25
        Me.LineShape1.Y2 = 25
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(302, 276)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(193, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "INPUT DATA BARANG"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 307)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "DATA BARANG"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(478, 307)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 16)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "STOK BARANG"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(41, 353)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 16)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Kode Barang"
        '
        'txb_kode_barang
        '
        Me.txb_kode_barang.Location = New System.Drawing.Point(190, 350)
        Me.txb_kode_barang.Name = "txb_kode_barang"
        Me.txb_kode_barang.Size = New System.Drawing.Size(125, 22)
        Me.txb_kode_barang.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(41, 388)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 16)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Nama Barang"
        '
        'txb_nama_barang
        '
        Me.txb_nama_barang.Location = New System.Drawing.Point(190, 385)
        Me.txb_nama_barang.Name = "txb_nama_barang"
        Me.txb_nama_barang.Size = New System.Drawing.Size(240, 22)
        Me.txb_nama_barang.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(41, 428)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 16)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Diskon"
        '
        'txb_diskon
        '
        Me.txb_diskon.Location = New System.Drawing.Point(190, 425)
        Me.txb_diskon.Name = "txb_diskon"
        Me.txb_diskon.Size = New System.Drawing.Size(81, 22)
        Me.txb_diskon.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(41, 467)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 16)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Harga Jual"
        '
        'txb_harga_jual
        '
        Me.txb_harga_jual.Location = New System.Drawing.Point(190, 464)
        Me.txb_harga_jual.Name = "txb_harga_jual"
        Me.txb_harga_jual.Size = New System.Drawing.Size(240, 22)
        Me.txb_harga_jual.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(147, 467)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(29, 16)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Rp."
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(480, 350)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(98, 16)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Jumlah Barang"
        '
        'txb_jumlah_barang
        '
        Me.txb_jumlah_barang.Location = New System.Drawing.Point(585, 347)
        Me.txb_jumlah_barang.Name = "txb_jumlah_barang"
        Me.txb_jumlah_barang.Size = New System.Drawing.Size(174, 22)
        Me.txb_jumlah_barang.TabIndex = 3
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(480, 386)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(47, 16)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Rusak"
        '
        'txb_rusak
        '
        Me.txb_rusak.Location = New System.Drawing.Point(585, 383)
        Me.txb_rusak.Name = "txb_rusak"
        Me.txb_rusak.Size = New System.Drawing.Size(174, 22)
        Me.txb_rusak.TabIndex = 3
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(480, 426)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(82, 16)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Sisa Barang"
        '
        'txb_sisa_barang
        '
        Me.txb_sisa_barang.Location = New System.Drawing.Point(585, 423)
        Me.txb_sisa_barang.Name = "txb_sisa_barang"
        Me.txb_sisa_barang.Size = New System.Drawing.Size(174, 22)
        Me.txb_sisa_barang.TabIndex = 3
        '
        'bt_tambah
        '
        Me.bt_tambah.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_tambah.Location = New System.Drawing.Point(19, 527)
        Me.bt_tambah.Name = "bt_tambah"
        Me.bt_tambah.Size = New System.Drawing.Size(157, 37)
        Me.bt_tambah.TabIndex = 4
        Me.bt_tambah.Text = "Tambah"
        Me.bt_tambah.UseVisualStyleBackColor = True
        '
        'bt_edit
        '
        Me.bt_edit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_edit.Location = New System.Drawing.Point(190, 527)
        Me.bt_edit.Name = "bt_edit"
        Me.bt_edit.Size = New System.Drawing.Size(154, 37)
        Me.bt_edit.TabIndex = 4
        Me.bt_edit.Text = "Edit"
        Me.bt_edit.UseVisualStyleBackColor = True
        '
        'bt_hapus
        '
        Me.bt_hapus.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.bt_hapus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_hapus.Location = New System.Drawing.Point(507, 527)
        Me.bt_hapus.Name = "bt_hapus"
        Me.bt_hapus.Size = New System.Drawing.Size(151, 37)
        Me.bt_hapus.TabIndex = 4
        Me.bt_hapus.Text = "Hapus"
        Me.bt_hapus.UseVisualStyleBackColor = False
        '
        'bt_keluar
        '
        Me.bt_keluar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_keluar.Location = New System.Drawing.Point(664, 527)
        Me.bt_keluar.Name = "bt_keluar"
        Me.bt_keluar.Size = New System.Drawing.Size(100, 37)
        Me.bt_keluar.TabIndex = 4
        Me.bt_keluar.Text = "Keluar"
        Me.bt_keluar.UseVisualStyleBackColor = True
        '
        'Dbtokoif21dxBindingSource
        '
        Me.Dbtokoif21dxBindingSource.DataSource = Me.Db_toko_if21dx
        Me.Dbtokoif21dxBindingSource.Position = 0
        '
        'btn_bersih
        '
        Me.btn_bersih.Location = New System.Drawing.Point(351, 527)
        Me.btn_bersih.Name = "btn_bersih"
        Me.btn_bersih.Size = New System.Drawing.Size(150, 37)
        Me.btn_bersih.TabIndex = 5
        Me.btn_bersih.Text = "Bersihkan"
        Me.btn_bersih.UseVisualStyleBackColor = True
        '
        'txb_cari
        '
        Me.txb_cari.Location = New System.Drawing.Point(588, 252)
        Me.txb_cari.Name = "txb_cari"
        Me.txb_cari.Size = New System.Drawing.Size(171, 22)
        Me.txb_cari.TabIndex = 6
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(502, 255)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(79, 16)
        Me.Label13.TabIndex = 7
        Me.Label13.Text = "Cari Barang"
        '
        'FromAplikasimasterBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(775, 598)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txb_cari)
        Me.Controls.Add(Me.btn_bersih)
        Me.Controls.Add(Me.bt_keluar)
        Me.Controls.Add(Me.bt_hapus)
        Me.Controls.Add(Me.bt_edit)
        Me.Controls.Add(Me.bt_tambah)
        Me.Controls.Add(Me.txb_jumlah_barang)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txb_sisa_barang)
        Me.Controls.Add(Me.txb_rusak)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txb_harga_jual)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txb_diskon)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txb_nama_barang)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txb_kode_barang)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbl_brg)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FromAplikasimasterBarang"
        Me.Text = "APLIKASI MASTER BARANG"
        CType(Me.tbl_brg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Db_toko_if21dx, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dbtokoif21dxBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbl_brg As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txb_kode_barang As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txb_nama_barang As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txb_diskon As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txb_harga_jual As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txb_jumlah_barang As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txb_rusak As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txb_sisa_barang As System.Windows.Forms.TextBox
    Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents bt_tambah As System.Windows.Forms.Button
    Friend WithEvents bt_edit As System.Windows.Forms.Button
    Friend WithEvents bt_hapus As System.Windows.Forms.Button
    Friend WithEvents bt_keluar As System.Windows.Forms.Button
    Friend WithEvents Db_toko_if21dx As PAplikasiToko_PBD_IF21Dx.db_toko_if21dx
    Friend WithEvents Dbtokoif21dxBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents btn_bersih As System.Windows.Forms.Button
    Friend WithEvents txb_cari As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label

End Class
