Imports System.Data.SqlClient
Module Module1
    Public Conn As SqlConnection
    Public Da As SqlDataAdapter
    Public Rd As SqlDataReader
    Public Cmd As SqlCommand
    Public Ds As DataSet
    Public Dt As DataTable
    Public MyDb, namaServer, database As String
    Public vMessage As String
    'variable nama table
    Public dan_pembelian = "dan_pembelian"
    Public dan_penjualan = "dan_penjualan"
    Public dan_jual = "dan_jual"
    Public dan_barang = "dan_barang"
    Public dan_supplier = "dan_supplier"
    Public dan_pegawai = "dan_pegawai"
    'variable nama view
    Public dan_view_penjualan = "dan_view_tbl_penjualan"
    'nama user login
    Public nama_user As String

    Public Sub Koneksi()
        'namaServer = "DESKTOP-DF5KEJ6"
        namaServer = Environment.MachineName
        database = "db_toko_if21dx"
        MyDb = "data source=" & namaServer & ";initial catalog=" & database & ";integrated security =true"
        Conn = New SqlConnection(MyDb)
        Try
            If Conn.State = ConnectionState.Closed Then
                Conn.Open()
            End If
        Catch ex As Exception
            MsgBox("Data base gagal koneksi karena " & ex.Message)
        End Try
    End Sub

    '=========== fungsi merubah float menjadi mata uang dan sebaliknya
    Function dan_f_to_mony(text As String)
        Try
            Dim amount As Double
            If Double.TryParse(text, amount) = False Then
                text = dan_m_to_float(text)
            End If
            amount = Double.Parse(text, Globalization.NumberStyles.AllowDecimalPoint)
            text = amount.ToString("Rp#,###.00")
            Return text
        Catch ex As Exception
            'MsgBox(ex.Message.ToString)
            Return text
        End Try
    End Function
    Function dan_m_to_float(text As String)
        Dim NewString As String = Replace(Replace(text, "Rp", ""), ",", "")
        Return NewString
    End Function

    '=========== auto complate
    'fungsi add item , untuk autocomplate/saran kode supplier
    Public Function dan_add_ks_Items(kunci As String)
        Dim col As New AutoCompleteStringCollection
        Try
            Koneksi()
            Da = New SqlDataAdapter("select dan_kd_sup from " & dan_supplier & "  where dan_kd_sup LIKE '%" & kunci & "%'", Conn)
            Dt = New DataTable
            Da.Fill(Dt)
            For Each row In Dt.Rows
                col.Add(row(0))
            Next
            Dt.Rows.Clear()
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Error !!!")
            Return False
        End Try
        Return col
    End Function
    ' add item , untuk autocomplate/saran kode barang
    Public Function dan_add_kb_Items(kunci As String)
        Dim col As New AutoCompleteStringCollection
        Try
            Koneksi()
            Da = New SqlDataAdapter("select dan_kd_brg from " & dan_barang & "  where dan_kd_brg LIKE '%" & kunci & "%'", Conn)
            Dt = New DataTable
            Da.Fill(Dt)
            For Each row In Dt.Rows
                col.Add(row(0))
            Next
            Dt.Rows.Clear()
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Error !!!")
            Return False
        End Try
        Return col
    End Function
    ' add item , untuk autocomplate/saran kode pegawai
    Public Function dan_add_kdpeg_Items(kunci As String)
        Dim col As New AutoCompleteStringCollection
        Try
            Koneksi()
            Da = New SqlDataAdapter("select dan_kd_peg from " & dan_pegawai & "  where dan_kd_peg LIKE '%" & kunci & "%'", Conn)
            Dt = New DataTable
            Da.Fill(Dt)
            For Each row In Dt.Rows
                col.Add(row(0))
            Next
            Dt.Rows.Clear()
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Error !!!")
            Return False
        End Try
        Return col
    End Function

    '====== fugsi pengecekan

    'fungsi cek kode supplier terdaftar atau tidak
    Function dan_cek_ks(cek As String)
        Call Koneksi()
        Da = New SqlDataAdapter("select dan_kd_sup from " & dan_supplier & " where dan_kd_sup='" & cek & "'", Conn)
        Dt = New DataTable
        Da.Fill(Dt)
        If Dt.Rows.Count > 0 Then
            'jika kode ditemukan maka akan lanjut, berarti retrun false
            Return False
        End If
        'jika kode tidak ditemukan maka akan gagal, berarti true false
        Return True
    End Function
    'fungsi cek kode barang terdaftar atau tidak
    Function dan_cek_kb(cek As String)
        Call Koneksi()
        Da = New SqlDataAdapter("select dan_kd_brg from " & dan_barang & " where dan_kd_brg='" & cek & "'", Conn)
        Dt = New DataTable
        Da.Fill(Dt)
        If Dt.Rows.Count > 0 Then
            'jika kode ditemukan maka akan lanjut, berarti retrun false
            Return False
        End If
        'jika kode tidak ditemukan maka akan gagal, berarti true false
        Return True
    End Function
    'fungsi cek kode pegawai terdaftar atau tidak
    Function dan_cek_kd_peg(cek As String)
        Call Koneksi()
        Da = New SqlDataAdapter("select dan_kd_peg from " & dan_pegawai & " where dan_kd_peg='" & cek & "'", Conn)
        Dt = New DataTable
        Da.Fill(Dt)
        If Dt.Rows.Count > 0 Then
            'jika kode ditemukan maka akan lanjut, berarti retrun false
            Return False
        End If
        'jika kode tidak ditemukan maka akan gagal, berarti true false
        Return True
    End Function

    '=========== Login
    'untuk diawal terkunci
    Sub Terkunci()
        DanFrmAplikasiMenuUtama.LoginToolStripMenuItem.Enabled = True
        DanFrmAplikasiMenuUtama.LogoutToolStripMenuItem.Enabled = False
        DanFrmAplikasiMenuUtama.MasterAplikasiToolStripMenuItem.Enabled = False
        DanFrmAplikasiMenuUtama.TransaksiToolStripMenuItem.Enabled = False
        DanFrmAplikasiMenuUtama.LaporanToolStripMenuItem.Enabled = False
        DanFrmAplikasiMenuUtama.MasterPegawaiToolStripMenuItem.Visible = False
        DanFrmAplikasiMenuUtama.UtilityToolStripMenuItem.Enabled = False
        DanFrmAplikasiMenuUtama.UtilityToolStripMenuItem.Visible = False
    End Sub
    'jika berhasil login dan status user
    Sub userTerbuka()
        DanFrmAplikasiMenuUtama.LoginToolStripMenuItem.Enabled = False
        DanFrmAplikasiMenuUtama.LogoutToolStripMenuItem.Enabled = True
        DanFrmAplikasiMenuUtama.MasterAplikasiToolStripMenuItem.Enabled = True
        DanFrmAplikasiMenuUtama.TransaksiToolStripMenuItem.Enabled = True
        DanFrmAplikasiMenuUtama.LaporanToolStripMenuItem.Enabled = True
        DanFrmAplikasiMenuUtama.UserLoginToolStripMenuItem.Text = nama_user
    End Sub
    'jika berhasil login dan status admin
    Sub adnminTerbuka()
        DanFrmAplikasiMenuUtama.LoginToolStripMenuItem.Enabled = False
        DanFrmAplikasiMenuUtama.LogoutToolStripMenuItem.Enabled = True
        DanFrmAplikasiMenuUtama.MasterAplikasiToolStripMenuItem.Enabled = True
        DanFrmAplikasiMenuUtama.TransaksiToolStripMenuItem.Enabled = True
        DanFrmAplikasiMenuUtama.LaporanToolStripMenuItem.Enabled = True
        DanFrmAplikasiMenuUtama.MasterPegawaiToolStripMenuItem.Visible = True
        DanFrmAplikasiMenuUtama.UtilityToolStripMenuItem.Enabled = True
        DanFrmAplikasiMenuUtama.UtilityToolStripMenuItem.Visible = True
        DanFrmAplikasiMenuUtama.UserLoginToolStripMenuItem.Text = nama_user
    End Sub


End Module