Public Class DanFrmLaporanPembelian
    '============== deklarasi
    Dim table As OleDb.OleDbDataAdapter
    Dim data As DataSet
    Dim record As New BindingSource

    '============== Load Awal
    Private Sub DanFrmLaporanPembelian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'merubah format date time piker
        dtp_lap_harian.Format = DateTimePickerFormat.Custom
        dtp_lap_harian.CustomFormat = "yyyy-MM-dd"
        ' combo box bulanan
        cbx_bulan.Items.Clear()
        cbx_bulan.Items.Add("01 - JANUARI")
        cbx_bulan.Items.Add("02 - FEBRUARI")
        cbx_bulan.Items.Add("03 - MARET")
        cbx_bulan.Items.Add("04 - APRIL")
        cbx_bulan.Items.Add("05 - MEI")
        cbx_bulan.Items.Add("06 - JUNI")
        cbx_bulan.Items.Add("07 - JULI")
        cbx_bulan.Items.Add("08 - AGUSTUS")
        cbx_bulan.Items.Add("09 - SEPTEMBER")
        cbx_bulan.Items.Add("10 - OKTOBER")
        cbx_bulan.Items.Add("11 - NOVEMBER")
        cbx_bulan.Items.Add("12 - DESEMBER")
        cbx_bulan.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cbx_bulan.AutoCompleteSource = AutoCompleteSource.ListItems
        cbx_bulan.SelectedIndex = 0
        ' combo box Tahunan
        cbx_tahun.Items.Clear()
        cbx_tahun.Text = Date.Now.Year
        For i As Integer = 0 To 10
            cbx_tahun.Items.Add(Date.Now.Year - i)
        Next
        cbx_tahun.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cbx_tahun.AutoCompleteSource = AutoCompleteSource.ListItems
        cbx_tahun.SelectedIndex = 0
    End Sub

    '============== Kode / Button
    Private Sub btn_cetak_lap_harian_Click(sender As Object, e As EventArgs) Handles btn_cetak_lap_harian.Click
        Try
            AxCrystalReportLaporanPenjualan.SelectionFormula = "totext({dan_view_laporan_pembelian.dan_tgl_beli})='" & dtp_lap_harian.Value.Date.ToString("yyyy-MM-dd") & "'"
            AxCrystalReportLaporanPenjualan.ReportFileName = "laporanPembelian.rpt"
            AxCrystalReportLaporanPenjualan.WindowState = Crystal.WindowStateConstants.crptMaximized
            AxCrystalReportLaporanPenjualan.RetrieveDataFiles()
            AxCrystalReportLaporanPenjualan.Action = 1
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.RetryCancel, "Error Pencetakan !!!")
        End Try
    End Sub


    Private Sub btn_cetak_lap_by_kdbli_Click(sender As Object, e As EventArgs) Handles btn_cetak_lap_by_kdbli.Click
        Try
            AxCrystalReportLaporanPenjualan.SelectionFormula = "totext({dan_view_laporan_pembelian.dan_kd_beli})='" & txb_kd_beli.Text & "'"
            AxCrystalReportLaporanPenjualan.ReportFileName = "laporanPembelian.rpt"
            AxCrystalReportLaporanPenjualan.WindowState = Crystal.WindowStateConstants.crptMaximized
            AxCrystalReportLaporanPenjualan.RetrieveDataFiles()
            AxCrystalReportLaporanPenjualan.Action = 1
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.RetryCancel, "Error Pencetakan !!!")
        End Try
    End Sub

    Private Sub btn_cetak_lap_bulanan_Click(sender As Object, e As EventArgs) Handles btn_cetak_lap_bulanan.Click
        Try
            AxCrystalReportLaporanPenjualan.SelectionFormula = "month({dan_view_laporan_pembelian.dan_tgl_beli})='" & Val(cbx_bulan.Text) & "'"
            AxCrystalReportLaporanPenjualan.ReportFileName = "laporanPembelian.rpt"
            AxCrystalReportLaporanPenjualan.WindowState = Crystal.WindowStateConstants.crptMaximized
            AxCrystalReportLaporanPenjualan.RetrieveDataFiles()
            AxCrystalReportLaporanPenjualan.Action = 1
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.RetryCancel, "Error Pencetakan !!!")
        End Try
    End Sub
End Class