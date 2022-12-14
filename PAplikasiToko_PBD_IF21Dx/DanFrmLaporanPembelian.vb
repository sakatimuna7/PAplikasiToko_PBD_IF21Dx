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
        'merubah format date time piker awal
        dtp_lap_awal.Format = DateTimePickerFormat.Custom
        dtp_lap_awal.CustomFormat = "yyyy,MM,dd"
        'merubah format date time piker akhir
        dtp_lap_akhir.Format = DateTimePickerFormat.Custom
        dtp_lap_akhir.CustomFormat = "yyyy-MM-dd"
        ' combo box bulanan
        cbx_bulan.Items.Clear()
        cbx_bulan.Items.Add("1")
        cbx_bulan.Items.Add("2")
        cbx_bulan.Items.Add("3")
        cbx_bulan.Items.Add("4")
        cbx_bulan.Items.Add("5")
        cbx_bulan.Items.Add("6")
        cbx_bulan.Items.Add("7")
        cbx_bulan.Items.Add("8")
        cbx_bulan.Items.Add("9")
        cbx_bulan.Items.Add("10")
        cbx_bulan.Items.Add("11")
        cbx_bulan.Items.Add("12")
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
    'LAPORAN HARIAN
    Private Sub btn_cetak_lap_harian_Click(sender As Object, e As EventArgs) Handles btn_cetak_lap_harian.Click
        Try
ulangi:
            AxCrystalReportLaporanPembelian.SelectionFormula = "totext({dan_view_laporan_pembelian.dan_tgl_beli})='" & dtp_lap_harian.Value.Date.ToString("yyyy-MM-dd") & "'"
            AxCrystalReportLaporanPembelian.ReportFileName = "laporanPembelian.rpt"
            AxCrystalReportLaporanPembelian.WindowState = Crystal.WindowStateConstants.crptMaximized
            AxCrystalReportLaporanPembelian.RetrieveDataFiles()
            AxCrystalReportLaporanPembelian.Action = 1
        Catch ex As Exception
            vMessage = MsgBox(ex.Message.ToString, MsgBoxStyle.RetryCancel, "Error Pencetakan !!!")
            If vMessage = vbRetry Then
                GoTo ulangi
            End If
        End Try
    End Sub

    'LAPORAN BY KODE BELI
    Private Sub btn_cetak_lap_by_kdbli_Click(sender As Object, e As EventArgs) Handles btn_cetak_lap_by_kdbli.Click
        Try
ulangi:
            AxCrystalReportLaporanPembelian.SelectionFormula = "totext({dan_view_laporan_pembelian.dan_kd_beli})='" & txb_kd_beli.Text & "'"
            AxCrystalReportLaporanPembelian.ReportFileName = "laporanPembelian.rpt"
            AxCrystalReportLaporanPembelian.WindowState = Crystal.WindowStateConstants.crptMaximized
            AxCrystalReportLaporanPembelian.RetrieveDataFiles()
            AxCrystalReportLaporanPembelian.Action = 1
        Catch ex As Exception
            vMessage = MsgBox(ex.Message.ToString, MsgBoxStyle.RetryCancel, "Error Pencetakan !!!")
            If vMessage = vbRetry Then
                GoTo ulangi
            End If
        End Try
    End Sub

    'LAPORAN BULANAN
    Private Sub btn_cetak_lap_bulanan_Click(sender As Object, e As EventArgs) Handles btn_cetak_lap_bulanan.Click
        Try
ulangi:
            AxCrystalReportLaporanPembelian.SelectionFormula = "Year(CDate({dan_view_laporan_pembelian.dan_tgl_beli}))=" & Val(cbx_tahun.Text) & " and Month(CDate({dan_view_laporan_pembelian.dan_tgl_beli}))=" & Val(cbx_bulan.Text)
            AxCrystalReportLaporanPembelian.ReportFileName = "laporanPembelianBulanan.rpt"
            AxCrystalReportLaporanPembelian.WindowState = Crystal.WindowStateConstants.crptMaximized
            AxCrystalReportLaporanPembelian.RetrieveDataFiles()
            AxCrystalReportLaporanPembelian.Action = 1
        Catch ex As Exception
            vMessage = MsgBox(ex.Message.ToString, MsgBoxStyle.RetryCancel, "Error Pencetakan !!!")
            If vMessage = vbRetry Then
                GoTo ulangi
            End If
        End Try
    End Sub
    'LAPORAN BERJANGKA / LAPORAN MINGGUAN
    Private Sub btn_cetak_lap_mingguan_Click(sender As Object, e As EventArgs) Handles btn_cetak_lap_mingguan.Click
        Try
ulangi:
            'AxCrystalReportLaporanPenjualan.SelectionFormula = "CDateTime({dan_view_laporan_pembelian.dan_tgl_beli}) In DateTime(CDateTime(" & Label7.Text & ")) To DateTime(CDateTime(" & Label8.Text & "))"
            AxCrystalReportLaporanPembelian.SelectionFormula = "CDate({dan_view_laporan_pembelian.dan_tgl_beli})>= CDate(" & dtp_lap_awal.Value.Date.ToString("yyyy,MM,dd") & ") and CDate({dan_view_laporan_pembelian.dan_tgl_beli})<= CDate(" & dtp_lap_akhir.Value.Date.ToString("yyyy,MM,dd") & ")"
            AxCrystalReportLaporanPembelian.ReportFileName = "laporanPembelianDiantara.rpt"
            AxCrystalReportLaporanPembelian.WindowState = Crystal.WindowStateConstants.crptMaximized
            AxCrystalReportLaporanPembelian.RetrieveDataFiles()
            AxCrystalReportLaporanPembelian.Action = 1
        Catch ex As Exception
            vMessage = MsgBox(ex.Message.ToString, MsgBoxStyle.RetryCancel, "Error Pencetakan !!!")
            If vMessage = vbRetry Then
                GoTo ulangi
            End If
        End Try
    End Sub
End Class