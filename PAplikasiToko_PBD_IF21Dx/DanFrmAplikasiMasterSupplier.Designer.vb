<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DanFrmAplikasiMasterSupplier
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dan_txb_ks = New System.Windows.Forms.TextBox()
        Me.dan_txb_np = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dan_txb_npj = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dan_txb_notel = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dan_txb_email = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dan_rtxb_alamat = New System.Windows.Forms.RichTextBox()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.dan_bt_tambah = New System.Windows.Forms.Button()
        Me.dan_bt_edit = New System.Windows.Forms.Button()
        Me.dan_bt_hapus = New System.Windows.Forms.Button()
        Me.dan_bt_keluar = New System.Windows.Forms.Button()
        Me.dan_tbl_sup = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Dbtokoif21dxBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Db_toko_if21dx = New PAplikasiToko_PBD_IF21Dx.db_toko_if21dx()
        Me.dan_txb_cari = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dan_bt_bersih = New System.Windows.Forms.Button()
        CType(Me.dan_tbl_sup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dbtokoif21dxBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Db_toko_if21dx, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(247, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(210, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "TABEL DATA SUPPLIER"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(47, 230)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(206, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "INPUT DATA SUPPLIER"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(85, 265)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Kode Supplier"
        '
        'dan_txb_ks
        '
        Me.dan_txb_ks.Location = New System.Drawing.Point(280, 261)
        Me.dan_txb_ks.Name = "dan_txb_ks"
        Me.dan_txb_ks.Size = New System.Drawing.Size(161, 20)
        Me.dan_txb_ks.TabIndex = 1
        '
        'dan_txb_np
        '
        Me.dan_txb_np.Location = New System.Drawing.Point(281, 294)
        Me.dan_txb_np.Name = "dan_txb_np"
        Me.dan_txb_np.Size = New System.Drawing.Size(319, 20)
        Me.dan_txb_np.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(86, 298)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(121, 16)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Nama Perusahaan"
        '
        'dan_txb_npj
        '
        Me.dan_txb_npj.Location = New System.Drawing.Point(280, 329)
        Me.dan_txb_npj.Name = "dan_txb_npj"
        Me.dan_txb_npj.Size = New System.Drawing.Size(319, 20)
        Me.dan_txb_npj.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(85, 333)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(165, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "nama Penanggung Jawab"
        '
        'dan_txb_notel
        '
        Me.dan_txb_notel.Location = New System.Drawing.Point(280, 363)
        Me.dan_txb_notel.Name = "dan_txb_notel"
        Me.dan_txb_notel.Size = New System.Drawing.Size(319, 20)
        Me.dan_txb_notel.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(85, 367)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(75, 16)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "No. Telpon"
        '
        'dan_txb_email
        '
        Me.dan_txb_email.Location = New System.Drawing.Point(279, 397)
        Me.dan_txb_email.Name = "dan_txb_email"
        Me.dan_txb_email.Size = New System.Drawing.Size(319, 20)
        Me.dan_txb_email.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(84, 401)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 16)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Email"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(85, 438)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 16)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Alamat"
        '
        'dan_rtxb_alamat
        '
        Me.dan_rtxb_alamat.Location = New System.Drawing.Point(279, 435)
        Me.dan_rtxb_alamat.Name = "dan_rtxb_alamat"
        Me.dan_rtxb_alamat.Size = New System.Drawing.Size(319, 96)
        Me.dan_rtxb_alamat.TabIndex = 10
        Me.dan_rtxb_alamat.Text = ""
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 19
        Me.LineShape1.X2 = 676
        Me.LineShape1.Y1 = 240
        Me.LineShape1.Y2 = 240
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape3, Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(686, 604)
        Me.ShapeContainer1.TabIndex = 11
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape3
        '
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 23
        Me.LineShape3.X2 = 678
        Me.LineShape3.Y1 = 544
        Me.LineShape3.Y2 = 544
        '
        'LineShape2
        '
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 20
        Me.LineShape2.X2 = 677
        Me.LineShape2.Y1 = 20
        Me.LineShape2.Y2 = 20
        '
        'dan_bt_tambah
        '
        Me.dan_bt_tambah.Location = New System.Drawing.Point(23, 555)
        Me.dan_bt_tambah.Name = "dan_bt_tambah"
        Me.dan_bt_tambah.Size = New System.Drawing.Size(112, 37)
        Me.dan_bt_tambah.TabIndex = 12
        Me.dan_bt_tambah.Text = "Tambah"
        Me.dan_bt_tambah.UseVisualStyleBackColor = True
        '
        'dan_bt_edit
        '
        Me.dan_bt_edit.Location = New System.Drawing.Point(141, 555)
        Me.dan_bt_edit.Name = "dan_bt_edit"
        Me.dan_bt_edit.Size = New System.Drawing.Size(115, 37)
        Me.dan_bt_edit.TabIndex = 13
        Me.dan_bt_edit.Text = "Edit"
        Me.dan_bt_edit.UseVisualStyleBackColor = True
        '
        'dan_bt_hapus
        '
        Me.dan_bt_hapus.Location = New System.Drawing.Point(262, 555)
        Me.dan_bt_hapus.Name = "dan_bt_hapus"
        Me.dan_bt_hapus.Size = New System.Drawing.Size(136, 37)
        Me.dan_bt_hapus.TabIndex = 14
        Me.dan_bt_hapus.Text = "Hapus"
        Me.dan_bt_hapus.UseVisualStyleBackColor = True
        '
        'dan_bt_keluar
        '
        Me.dan_bt_keluar.Location = New System.Drawing.Point(564, 555)
        Me.dan_bt_keluar.Name = "dan_bt_keluar"
        Me.dan_bt_keluar.Size = New System.Drawing.Size(111, 37)
        Me.dan_bt_keluar.TabIndex = 15
        Me.dan_bt_keluar.Text = "Keluar"
        Me.dan_bt_keluar.UseVisualStyleBackColor = True
        '
        'dan_tbl_sup
        '
        Me.dan_tbl_sup.AutoGenerateColumns = False
        Me.dan_tbl_sup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dan_tbl_sup.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        Me.dan_tbl_sup.DataSource = Me.Dbtokoif21dxBindingSource
        Me.dan_tbl_sup.Location = New System.Drawing.Point(28, 32)
        Me.dan_tbl_sup.Name = "dan_tbl_sup"
        Me.dan_tbl_sup.Size = New System.Drawing.Size(640, 161)
        Me.dan_tbl_sup.TabIndex = 16
        '
        'Column1
        '
        Me.Column1.HeaderText = "kode Supplier"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Nama Perusahaan"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Nama Penanggungjawab"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "No. Telepon"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Email"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.HeaderText = "Alamat"
        Me.Column6.Name = "Column6"
        '
        'Dbtokoif21dxBindingSource
        '
        Me.Dbtokoif21dxBindingSource.DataSource = Me.Db_toko_if21dx
        Me.Dbtokoif21dxBindingSource.Position = 0
        '
        'Db_toko_if21dx
        '
        Me.Db_toko_if21dx.DataSetName = "db_toko_if21dx"
        Me.Db_toko_if21dx.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'dan_txb_cari
        '
        Me.dan_txb_cari.Location = New System.Drawing.Point(497, 205)
        Me.dan_txb_cari.Name = "dan_txb_cari"
        Me.dan_txb_cari.Size = New System.Drawing.Size(167, 20)
        Me.dan_txb_cari.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(406, 207)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(85, 16)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Cari Supplier"
        '
        'dan_bt_bersih
        '
        Me.dan_bt_bersih.Location = New System.Drawing.Point(404, 555)
        Me.dan_bt_bersih.Name = "dan_bt_bersih"
        Me.dan_bt_bersih.Size = New System.Drawing.Size(154, 37)
        Me.dan_bt_bersih.TabIndex = 19
        Me.dan_bt_bersih.Text = "Bersih"
        Me.dan_bt_bersih.UseVisualStyleBackColor = True
        '
        'DanFrmAplikasiMasterSupplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(686, 604)
        Me.Controls.Add(Me.dan_bt_bersih)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.dan_txb_cari)
        Me.Controls.Add(Me.dan_tbl_sup)
        Me.Controls.Add(Me.dan_bt_keluar)
        Me.Controls.Add(Me.dan_bt_hapus)
        Me.Controls.Add(Me.dan_bt_edit)
        Me.Controls.Add(Me.dan_bt_tambah)
        Me.Controls.Add(Me.dan_rtxb_alamat)
        Me.Controls.Add(Me.dan_txb_email)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.dan_txb_notel)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dan_txb_npj)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dan_txb_np)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dan_txb_ks)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "DanFrmAplikasiMasterSupplier"
        Me.Text = "Dan Aplikasi Master Supplier"
        CType(Me.dan_tbl_sup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dbtokoif21dxBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Db_toko_if21dx, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dan_txb_ks As System.Windows.Forms.TextBox
    Friend WithEvents dan_txb_np As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dan_txb_npj As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dan_txb_notel As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dan_txb_email As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents dan_rtxb_alamat As System.Windows.Forms.RichTextBox
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents dan_bt_tambah As System.Windows.Forms.Button
    Friend WithEvents dan_bt_edit As System.Windows.Forms.Button
    Friend WithEvents dan_bt_hapus As System.Windows.Forms.Button
    Friend WithEvents dan_bt_keluar As System.Windows.Forms.Button
    Friend WithEvents dan_tbl_sup As System.Windows.Forms.DataGridView
    Friend WithEvents Dbtokoif21dxBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Db_toko_if21dx As PAplikasiToko_PBD_IF21Dx.db_toko_if21dx
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dan_txb_cari As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents dan_bt_bersih As System.Windows.Forms.Button
End Class
