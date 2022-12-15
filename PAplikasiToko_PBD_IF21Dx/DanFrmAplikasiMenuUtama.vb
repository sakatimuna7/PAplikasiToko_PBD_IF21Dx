Public Class DanFrmAplikasiMenuUtama
    Private Sub DanFrmAplikasiMenuUtama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Terkunci()
        DanFrmAplikasiLogin.ShowDialog()

    End Sub

    Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem.Click
        DanFrmAplikasiLogin.ShowDialog()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        vMessage = MsgBox("Apakah anda yakin Logout Keluar ?", vbExclamation + vbYesNo, "perhatian")
        If vMessage = vbNo Then Exit Sub
        Call Terkunci()
        DanFrmAplikasiLogin.ShowDialog()
    End Sub
    '========= Master Aplikasi
    Private Sub MasterBarangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MasterBarangToolStripMenuItem.Click
        DanFromAplikasimasterBarang.ShowDialog()
    End Sub

    Private Sub MasterSupplierToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MasterSupplierToolStripMenuItem.Click
        DanFrmAplikasiMasterSupplier.ShowDialog()
    End Sub

    Private Sub MasterPegawaiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MasterPegawaiToolStripMenuItem.Click
        DanFrmAplikasiMasterPegawai.ShowDialog()
    End Sub
    '========== Transaksi

    Private Sub PembelianBarangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PembelianBarangToolStripMenuItem.Click
        DanFrmAplikasiMasterPembelian.ShowDialog()
    End Sub

    Private Sub PenjualanBarangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PenjualanBarangToolStripMenuItem.Click
        DanFrmAplikasiMasterPenjualan.ShowDialog()
    End Sub

    Private Sub LaporanPembelianToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaporanPembelianToolStripMenuItem.Click
        DanFrmLaporanPembelian.ShowDialog()
    End Sub

    Private Sub LaporanDataMasterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaporanDataMasterToolStripMenuItem.Click
        DanFrmLaporanDataMaster.ShowDialog()
    End Sub

    'user sedang Login
    Private Sub UserLoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UserLoginToolStripMenuItem.Click

    End Sub

    Private Sub TentangAplikasiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TentangAplikasiToolStripMenuItem.Click
        DanFrmTentang.ShowDialog()
    End Sub
End Class