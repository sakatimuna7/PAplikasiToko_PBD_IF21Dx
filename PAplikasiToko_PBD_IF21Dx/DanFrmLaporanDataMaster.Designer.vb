<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DanFrmLaporanDataMaster
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DanFrmLaporanDataMaster))
        Me.AxCrystalReportLaporanMaster = New AxCrystal.AxCrystalReport()
        Me.dan_btn_cetak_data_barang = New System.Windows.Forms.Button()
        Me.dan_btn_cetak_data_supplier = New System.Windows.Forms.Button()
        Me.dan_btn_cetak_data_pegawai = New System.Windows.Forms.Button()
        CType(Me.AxCrystalReportLaporanMaster, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AxCrystalReportLaporanMaster
        '
        Me.AxCrystalReportLaporanMaster.Enabled = True
        Me.AxCrystalReportLaporanMaster.Location = New System.Drawing.Point(227, 88)
        Me.AxCrystalReportLaporanMaster.Name = "AxCrystalReportLaporanMaster"
        Me.AxCrystalReportLaporanMaster.OcxState = CType(resources.GetObject("AxCrystalReportLaporanMaster.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxCrystalReportLaporanMaster.Size = New System.Drawing.Size(28, 28)
        Me.AxCrystalReportLaporanMaster.TabIndex = 0
        '
        'dan_btn_cetak_data_barang
        '
        Me.dan_btn_cetak_data_barang.Location = New System.Drawing.Point(12, 12)
        Me.dan_btn_cetak_data_barang.Name = "dan_btn_cetak_data_barang"
        Me.dan_btn_cetak_data_barang.Size = New System.Drawing.Size(150, 58)
        Me.dan_btn_cetak_data_barang.TabIndex = 1
        Me.dan_btn_cetak_data_barang.Text = "Laporan Data Barang"
        Me.dan_btn_cetak_data_barang.UseVisualStyleBackColor = True
        '
        'dan_btn_cetak_data_supplier
        '
        Me.dan_btn_cetak_data_supplier.Location = New System.Drawing.Point(169, 12)
        Me.dan_btn_cetak_data_supplier.Name = "dan_btn_cetak_data_supplier"
        Me.dan_btn_cetak_data_supplier.Size = New System.Drawing.Size(150, 58)
        Me.dan_btn_cetak_data_supplier.TabIndex = 2
        Me.dan_btn_cetak_data_supplier.Text = "Laporan Data Supplier"
        Me.dan_btn_cetak_data_supplier.UseVisualStyleBackColor = True
        '
        'dan_btn_cetak_data_pegawai
        '
        Me.dan_btn_cetak_data_pegawai.Location = New System.Drawing.Point(325, 12)
        Me.dan_btn_cetak_data_pegawai.Name = "dan_btn_cetak_data_pegawai"
        Me.dan_btn_cetak_data_pegawai.Size = New System.Drawing.Size(150, 58)
        Me.dan_btn_cetak_data_pegawai.TabIndex = 3
        Me.dan_btn_cetak_data_pegawai.Text = "Laporan Data Pegawai"
        Me.dan_btn_cetak_data_pegawai.UseVisualStyleBackColor = True
        '
        'DanFrmLaporanDataMaster
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(490, 128)
        Me.Controls.Add(Me.dan_btn_cetak_data_pegawai)
        Me.Controls.Add(Me.dan_btn_cetak_data_supplier)
        Me.Controls.Add(Me.dan_btn_cetak_data_barang)
        Me.Controls.Add(Me.AxCrystalReportLaporanMaster)
        Me.Name = "DanFrmLaporanDataMaster"
        Me.Text = "DanFrmLaporanDataMaster"
        CType(Me.AxCrystalReportLaporanMaster, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents AxCrystalReportLaporanMaster As AxCrystal.AxCrystalReport
    Friend WithEvents dan_btn_cetak_data_barang As System.Windows.Forms.Button
    Friend WithEvents dan_btn_cetak_data_supplier As System.Windows.Forms.Button
    Friend WithEvents dan_btn_cetak_data_pegawai As System.Windows.Forms.Button
End Class
