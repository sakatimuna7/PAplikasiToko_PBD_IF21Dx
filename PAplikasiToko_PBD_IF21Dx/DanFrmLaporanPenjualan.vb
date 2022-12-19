Public Class DanFrmLaporanPenjualan
    '============== Deklarasi
    Dim DataCollection As New AutoCompleteStringCollection()

    '============== Load Awal
    Private Sub DanFrmLaporanPenjualan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        'autocomplate kode supplier
        txb_kd_trans.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        txb_kd_trans.AutoCompleteSource = AutoCompleteSource.CustomSource
        DataCollection = dan_add_kdtrans_item(txb_kd_trans.Text)
        txb_kd_trans.AutoCompleteCustomSource = DataCollection
    End Sub
    '============== Kode / Button
    'LAPORAN HARIAN
    Private Sub btn_cetak_lap_harian_Click(sender As Object, e As EventArgs) Handles btn_cetak_lap_harian.Click
        Try
ulangi:
            AxCrystalReportLaporanPenjualan.SelectionFormula = "totext({dan_view_laporan_penjualan.dan_tgl})='" & dtp_lap_harian.Value.Date.ToString("yyyy-MM-dd") & "'"
            AxCrystalReportLaporanPenjualan.ReportFileName = "laporanPenjualanHarian.rpt"
            AxCrystalReportLaporanPenjualan.WindowState = Crystal.WindowStateConstants.crptMaximized
            AxCrystalReportLaporanPenjualan.RetrieveDataFiles()
            AxCrystalReportLaporanPenjualan.Action = 1
        Catch ex As Exception
            vMessage = MsgBox(ex.Message.ToString, MsgBoxStyle.RetryCancel, "Error Pencetakan !!!")
            If vMessage = vbRetry Then
                GoTo ulangi
            End If
        End Try
    End Sub
    'LAPORAN BY KODE TRANSAKSI
    Private Sub btn_cetak_lap_by_kdtrans_Click(sender As Object, e As EventArgs) Handles btn_cetak_lap_by_kdtrans.Click
        Try
ulangi:
            AxCrystalReportLaporanPenjualan.SelectionFormula = "totext({dan_view_laporan_penjualan.dan_kd_trans})='" & txb_kd_trans.Text & "'"
            AxCrystalReportLaporanPenjualan.ReportFileName = "laporanPenjualan.rpt"
            AxCrystalReportLaporanPenjualan.WindowState = Crystal.WindowStateConstants.crptMaximized
            AxCrystalReportLaporanPenjualan.RetrieveDataFiles()
            AxCrystalReportLaporanPenjualan.Action = 1
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
            AxCrystalReportLaporanPenjualan.SelectionFormula = "Year(CDate({dan_view_laporan_penjualan.dan_tgl}))=" & Val(cbx_tahun.Text) & " and Month(CDate({dan_view_laporan_penjualan.dan_tgl}))=" & Val(cbx_bulan.Text)
            AxCrystalReportLaporanPenjualan.ReportFileName = "laporanPenjualanBulanan.rpt"
            AxCrystalReportLaporanPenjualan.WindowState = Crystal.WindowStateConstants.crptMaximized
            AxCrystalReportLaporanPenjualan.RetrieveDataFiles()
            AxCrystalReportLaporanPenjualan.Action = 1
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
            AxCrystalReportLaporanPenjualan.SelectionFormula = "CDate({dan_view_laporan_penjualan.dan_tgl})>= CDate(" & dtp_lap_awal.Value.Date.ToString("yyyy,MM,dd") & ") and CDate({dan_view_laporan_penjualan.dan_tgl})<= CDate(" & dtp_lap_akhir.Value.Date.ToString("yyyy,MM,dd") & ")"
            AxCrystalReportLaporanPenjualan.ReportFileName = "laporanPenjualanBerjangka.rpt"
            AxCrystalReportLaporanPenjualan.WindowState = Crystal.WindowStateConstants.crptMaximized
            AxCrystalReportLaporanPenjualan.RetrieveDataFiles()
            AxCrystalReportLaporanPenjualan.Action = 1
        Catch ex As Exception
            vMessage = MsgBox(ex.Message.ToString, MsgBoxStyle.RetryCancel, "Error Pencetakan !!!")
            If vMessage = vbRetry Then
                GoTo ulangi
            End If
        End Try
    End Sub

    Private Sub txb_kd_trans_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txb_kd_trans.KeyPress   
        ' membatasi karakter yang di input
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyz1234567890"
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txb_kd_trans_KeyDown(sender As Object, e As KeyEventArgs) Handles txb_kd_trans.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call btn_cetak_lap_by_kdtrans_Click(sender, e)
        End If
    End Sub
End Class