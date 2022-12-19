<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DanFrmLaporanPenjualan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DanFrmLaporanPenjualan))
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.cbx_tahun = New System.Windows.Forms.ComboBox()
        Me.cbx_bulan = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btn_cetak_lap_bulanan = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dtp_lap_akhir = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtp_lap_awal = New System.Windows.Forms.DateTimePicker()
        Me.btn_cetak_lap_mingguan = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dtp_lap_harian = New System.Windows.Forms.DateTimePicker()
        Me.btn_cetak_lap_harian = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txb_kd_trans = New System.Windows.Forms.TextBox()
        Me.btn_cetak_lap_by_kdtrans = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AxCrystalReportLaporanPenjualan = New AxCrystal.AxCrystalReport()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.AxCrystalReportLaporanPenjualan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.cbx_tahun)
        Me.GroupBox4.Controls.Add(Me.cbx_bulan)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.btn_cetak_lap_bulanan)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Location = New System.Drawing.Point(263, 159)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(236, 141)
        Me.GroupBox4.TabIndex = 12
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Laporan Bulanan"
        '
        'cbx_tahun
        '
        Me.cbx_tahun.FormattingEnabled = True
        Me.cbx_tahun.Location = New System.Drawing.Point(99, 50)
        Me.cbx_tahun.Name = "cbx_tahun"
        Me.cbx_tahun.Size = New System.Drawing.Size(121, 21)
        Me.cbx_tahun.TabIndex = 7
        '
        'cbx_bulan
        '
        Me.cbx_bulan.FormattingEnabled = True
        Me.cbx_bulan.Location = New System.Drawing.Point(99, 19)
        Me.cbx_bulan.Name = "cbx_bulan"
        Me.cbx_bulan.Size = New System.Drawing.Size(121, 21)
        Me.cbx_bulan.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 53)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Tahun"
        '
        'btn_cetak_lap_bulanan
        '
        Me.btn_cetak_lap_bulanan.Location = New System.Drawing.Point(18, 93)
        Me.btn_cetak_lap_bulanan.Name = "btn_cetak_lap_bulanan"
        Me.btn_cetak_lap_bulanan.Size = New System.Drawing.Size(202, 31)
        Me.btn_cetak_lap_bulanan.TabIndex = 3
        Me.btn_cetak_lap_bulanan.Text = "Cetak Laporan"
        Me.btn_cetak_lap_bulanan.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Bulan"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dtp_lap_akhir)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.dtp_lap_awal)
        Me.GroupBox3.Controls.Add(Me.btn_cetak_lap_mingguan)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 159)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(236, 141)
        Me.GroupBox3.TabIndex = 11
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Laporan Mingguan / by tanggal"
        '
        'dtp_lap_akhir
        '
        Me.dtp_lap_akhir.Location = New System.Drawing.Point(93, 48)
        Me.dtp_lap_akhir.Name = "dtp_lap_akhir"
        Me.dtp_lap_akhir.Size = New System.Drawing.Size(127, 20)
        Me.dtp_lap_akhir.TabIndex = 6
        Me.dtp_lap_akhir.Value = New Date(2022, 12, 15, 0, 0, 0, 0)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 53)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Tanggal Akhir"
        '
        'dtp_lap_awal
        '
        Me.dtp_lap_awal.Location = New System.Drawing.Point(93, 19)
        Me.dtp_lap_awal.Name = "dtp_lap_awal"
        Me.dtp_lap_awal.Size = New System.Drawing.Size(127, 20)
        Me.dtp_lap_awal.TabIndex = 4
        Me.dtp_lap_awal.Value = New Date(2022, 12, 15, 0, 0, 0, 0)
        '
        'btn_cetak_lap_mingguan
        '
        Me.btn_cetak_lap_mingguan.Location = New System.Drawing.Point(18, 93)
        Me.btn_cetak_lap_mingguan.Name = "btn_cetak_lap_mingguan"
        Me.btn_cetak_lap_mingguan.Size = New System.Drawing.Size(202, 31)
        Me.btn_cetak_lap_mingguan.TabIndex = 3
        Me.btn_cetak_lap_mingguan.Text = "Cetak Laporan"
        Me.btn_cetak_lap_mingguan.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Tanggal Awal"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dtp_lap_harian)
        Me.GroupBox2.Controls.Add(Me.btn_cetak_lap_harian)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(263, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(236, 141)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Laporan Harian"
        '
        'dtp_lap_harian
        '
        Me.dtp_lap_harian.Location = New System.Drawing.Point(67, 22)
        Me.dtp_lap_harian.Name = "dtp_lap_harian"
        Me.dtp_lap_harian.Size = New System.Drawing.Size(153, 20)
        Me.dtp_lap_harian.TabIndex = 4
        Me.dtp_lap_harian.Value = New Date(2022, 12, 14, 0, 0, 0, 0)
        '
        'btn_cetak_lap_harian
        '
        Me.btn_cetak_lap_harian.Location = New System.Drawing.Point(18, 93)
        Me.btn_cetak_lap_harian.Name = "btn_cetak_lap_harian"
        Me.btn_cetak_lap_harian.Size = New System.Drawing.Size(202, 31)
        Me.btn_cetak_lap_harian.TabIndex = 3
        Me.btn_cetak_lap_harian.Text = "Cetak Laporan"
        Me.btn_cetak_lap_harian.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Tanggal"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txb_kd_trans)
        Me.GroupBox1.Controls.Add(Me.btn_cetak_lap_by_kdtrans)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(236, 141)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Laporan By Kode Transaksi"
        '
        'txb_kd_trans
        '
        Me.txb_kd_trans.Location = New System.Drawing.Point(102, 22)
        Me.txb_kd_trans.Name = "txb_kd_trans"
        Me.txb_kd_trans.Size = New System.Drawing.Size(118, 20)
        Me.txb_kd_trans.TabIndex = 3
        '
        'btn_cetak_lap_by_kdtrans
        '
        Me.btn_cetak_lap_by_kdtrans.Location = New System.Drawing.Point(18, 93)
        Me.btn_cetak_lap_by_kdtrans.Name = "btn_cetak_lap_by_kdtrans"
        Me.btn_cetak_lap_by_kdtrans.Size = New System.Drawing.Size(202, 31)
        Me.btn_cetak_lap_by_kdtrans.TabIndex = 3
        Me.btn_cetak_lap_by_kdtrans.Text = "Cetak Laporan"
        Me.btn_cetak_lap_by_kdtrans.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Kode Transaksi"
        '
        'AxCrystalReportLaporanPenjualan
        '
        Me.AxCrystalReportLaporanPenjualan.Enabled = True
        Me.AxCrystalReportLaporanPenjualan.Location = New System.Drawing.Point(242, 146)
        Me.AxCrystalReportLaporanPenjualan.Name = "AxCrystalReportLaporanPenjualan"
        Me.AxCrystalReportLaporanPenjualan.OcxState = CType(resources.GetObject("AxCrystalReportLaporanPenjualan.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxCrystalReportLaporanPenjualan.Size = New System.Drawing.Size(28, 28)
        Me.AxCrystalReportLaporanPenjualan.TabIndex = 8
        '
        'DanFrmLaporanPenjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(513, 314)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.AxCrystalReportLaporanPenjualan)
        Me.MaximumSize = New System.Drawing.Size(529, 353)
        Me.MinimumSize = New System.Drawing.Size(529, 353)
        Me.Name = "DanFrmLaporanPenjualan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "LAPORAN PENJUALAN"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.AxCrystalReportLaporanPenjualan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents cbx_tahun As System.Windows.Forms.ComboBox
    Friend WithEvents cbx_bulan As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btn_cetak_lap_bulanan As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents dtp_lap_akhir As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtp_lap_awal As System.Windows.Forms.DateTimePicker
    Friend WithEvents btn_cetak_lap_mingguan As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dtp_lap_harian As System.Windows.Forms.DateTimePicker
    Friend WithEvents btn_cetak_lap_harian As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txb_kd_trans As System.Windows.Forms.TextBox
    Friend WithEvents btn_cetak_lap_by_kdtrans As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents AxCrystalReportLaporanPenjualan As AxCrystal.AxCrystalReport
End Class
