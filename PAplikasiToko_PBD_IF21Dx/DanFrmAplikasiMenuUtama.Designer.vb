<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DanFrmAplikasiMenuUtama
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MasterAplikasiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MasterBarangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MasterSupplierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MasterPegawaiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransaksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PembelianBarangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PenjualanBarangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanPenjualanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanPembelianToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanDataMasterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BukuManualToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TentangAplikasiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UtilityToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.UserLoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.MasterAplikasiToolStripMenuItem, Me.TransaksiToolStripMenuItem, Me.LaporanToolStripMenuItem, Me.HelpToolStripMenuItem, Me.UtilityToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(908, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoginToolStripMenuItem, Me.LogoutToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'LoginToolStripMenuItem
        '
        Me.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        Me.LoginToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.LoginToolStripMenuItem.Text = "Login"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'MasterAplikasiToolStripMenuItem
        '
        Me.MasterAplikasiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MasterBarangToolStripMenuItem, Me.MasterSupplierToolStripMenuItem, Me.MasterPegawaiToolStripMenuItem})
        Me.MasterAplikasiToolStripMenuItem.Name = "MasterAplikasiToolStripMenuItem"
        Me.MasterAplikasiToolStripMenuItem.Size = New System.Drawing.Size(99, 20)
        Me.MasterAplikasiToolStripMenuItem.Text = "Master Aplikasi"
        '
        'MasterBarangToolStripMenuItem
        '
        Me.MasterBarangToolStripMenuItem.Name = "MasterBarangToolStripMenuItem"
        Me.MasterBarangToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.MasterBarangToolStripMenuItem.Text = "Master Barang"
        '
        'MasterSupplierToolStripMenuItem
        '
        Me.MasterSupplierToolStripMenuItem.Name = "MasterSupplierToolStripMenuItem"
        Me.MasterSupplierToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.MasterSupplierToolStripMenuItem.Text = "Master Supplier"
        '
        'MasterPegawaiToolStripMenuItem
        '
        Me.MasterPegawaiToolStripMenuItem.Name = "MasterPegawaiToolStripMenuItem"
        Me.MasterPegawaiToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.MasterPegawaiToolStripMenuItem.Text = "Master Pegawai"
        '
        'TransaksiToolStripMenuItem
        '
        Me.TransaksiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PembelianBarangToolStripMenuItem, Me.PenjualanBarangToolStripMenuItem})
        Me.TransaksiToolStripMenuItem.Name = "TransaksiToolStripMenuItem"
        Me.TransaksiToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.TransaksiToolStripMenuItem.Text = "Transaksi"
        '
        'PembelianBarangToolStripMenuItem
        '
        Me.PembelianBarangToolStripMenuItem.Name = "PembelianBarangToolStripMenuItem"
        Me.PembelianBarangToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.PembelianBarangToolStripMenuItem.Text = "Pembelian Barang"
        '
        'PenjualanBarangToolStripMenuItem
        '
        Me.PenjualanBarangToolStripMenuItem.Name = "PenjualanBarangToolStripMenuItem"
        Me.PenjualanBarangToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.PenjualanBarangToolStripMenuItem.Text = "Penjualan Barang"
        '
        'LaporanToolStripMenuItem
        '
        Me.LaporanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LaporanPenjualanToolStripMenuItem, Me.LaporanPembelianToolStripMenuItem, Me.LaporanDataMasterToolStripMenuItem})
        Me.LaporanToolStripMenuItem.Name = "LaporanToolStripMenuItem"
        Me.LaporanToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.LaporanToolStripMenuItem.Text = "Laporan"
        '
        'LaporanPenjualanToolStripMenuItem
        '
        Me.LaporanPenjualanToolStripMenuItem.Name = "LaporanPenjualanToolStripMenuItem"
        Me.LaporanPenjualanToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.LaporanPenjualanToolStripMenuItem.Text = "Laporan Penjualan"
        '
        'LaporanPembelianToolStripMenuItem
        '
        Me.LaporanPembelianToolStripMenuItem.Name = "LaporanPembelianToolStripMenuItem"
        Me.LaporanPembelianToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.LaporanPembelianToolStripMenuItem.Text = "Laporan Pembelian"
        '
        'LaporanDataMasterToolStripMenuItem
        '
        Me.LaporanDataMasterToolStripMenuItem.Name = "LaporanDataMasterToolStripMenuItem"
        Me.LaporanDataMasterToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.LaporanDataMasterToolStripMenuItem.Text = "Laporan Data Master"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BukuManualToolStripMenuItem, Me.TentangAplikasiToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'BukuManualToolStripMenuItem
        '
        Me.BukuManualToolStripMenuItem.Name = "BukuManualToolStripMenuItem"
        Me.BukuManualToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.BukuManualToolStripMenuItem.Text = "Buku Manual"
        '
        'TentangAplikasiToolStripMenuItem
        '
        Me.TentangAplikasiToolStripMenuItem.Name = "TentangAplikasiToolStripMenuItem"
        Me.TentangAplikasiToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.TentangAplikasiToolStripMenuItem.Text = "Tentang Aplikasi"
        '
        'UtilityToolStripMenuItem
        '
        Me.UtilityToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UserToolStripMenuItem, Me.ToolStripMenuItem1, Me.UserLoginToolStripMenuItem})
        Me.UtilityToolStripMenuItem.Name = "UtilityToolStripMenuItem"
        Me.UtilityToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.UtilityToolStripMenuItem.Text = "Utility"
        '
        'UserToolStripMenuItem
        '
        Me.UserToolStripMenuItem.Name = "UserToolStripMenuItem"
        Me.UserToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.UserToolStripMenuItem.Text = "Kelola User Login"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(162, 6)
        '
        'UserLoginToolStripMenuItem
        '
        Me.UserLoginToolStripMenuItem.Name = "UserLoginToolStripMenuItem"
        Me.UserLoginToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.UserLoginToolStripMenuItem.Text = "User_Login"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(473, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(404, 35)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Toko Makmur Jaya Abadi I"
        '
        'DanFrmAplikasiMenuUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PAplikasiToko_PBD_IF21Dx.My.Resources.Resources.bg2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(908, 377)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MinimumSize = New System.Drawing.Size(924, 416)
        Me.Name = "DanFrmAplikasiMenuUtama"
        Me.ShowIcon = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu Utama"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoginToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MasterAplikasiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MasterBarangToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MasterSupplierToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MasterPegawaiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TransaksiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PembelianBarangToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PenjualanBarangToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanPenjualanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanPembelianToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BukuManualToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TentangAplikasiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UtilityToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanDataMasterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents UserLoginToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
