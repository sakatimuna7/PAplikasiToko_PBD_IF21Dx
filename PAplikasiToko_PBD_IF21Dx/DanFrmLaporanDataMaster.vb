Public Class DanFrmLaporanDataMaster

    Private Sub dan_btn_cetak_data_barang_Click(sender As Object, e As EventArgs) Handles dan_btn_cetak_data_barang.Click
        AxCrystalReportLaporanMaster.ReportFileName = "laporanDataBarang.rpt"
        AxCrystalReportLaporanMaster.WindowState = Crystal.WindowStateConstants.crptMaximized
        AxCrystalReportLaporanMaster.RetrieveDataFiles()
        AxCrystalReportLaporanMaster.Action = 1
    End Sub

    Private Sub dan_btn_cetak_data_supplier_Click(sender As Object, e As EventArgs) Handles dan_btn_cetak_data_supplier.Click
        AxCrystalReportLaporanMaster.ReportFileName = "laporanDataSupplier.rpt"
        AxCrystalReportLaporanMaster.WindowState = Crystal.WindowStateConstants.crptMaximized
        AxCrystalReportLaporanMaster.RetrieveDataFiles()
        AxCrystalReportLaporanMaster.Action = 1
    End Sub

    Private Sub dan_btn_cetak_data_pegawai_Click(sender As Object, e As EventArgs) Handles dan_btn_cetak_data_pegawai.Click
        AxCrystalReportLaporanMaster.ReportFileName = "laporanDataPegawai.rpt"
        AxCrystalReportLaporanMaster.WindowState = Crystal.WindowStateConstants.crptMaximized
        AxCrystalReportLaporanMaster.RetrieveDataFiles()
        AxCrystalReportLaporanMaster.Action = 1
    End Sub
End Class