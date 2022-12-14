<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DanFrmAplikasiLogin
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
        Me.dan_lbl_ver = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dan_bt_batal = New System.Windows.Forms.Button()
        Me.dan_bt_login = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dan_txb_password = New System.Windows.Forms.TextBox()
        Me.dan_txb_username = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'dan_lbl_ver
        '
        Me.dan_lbl_ver.AutoSize = True
        Me.dan_lbl_ver.BackColor = System.Drawing.Color.Transparent
        Me.dan_lbl_ver.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dan_lbl_ver.ForeColor = System.Drawing.Color.White
        Me.dan_lbl_ver.Location = New System.Drawing.Point(21, 323)
        Me.dan_lbl_ver.Name = "dan_lbl_ver"
        Me.dan_lbl_ver.Size = New System.Drawing.Size(111, 13)
        Me.dan_lbl_ver.TabIndex = 19
        Me.dan_lbl_ver.Text = "Versi Aplikasi 1.1 beta"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(114, 210)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Lupa Password ?"
        '
        'dan_bt_batal
        '
        Me.dan_bt_batal.Location = New System.Drawing.Point(108, 165)
        Me.dan_bt_batal.Name = "dan_bt_batal"
        Me.dan_bt_batal.Size = New System.Drawing.Size(89, 30)
        Me.dan_bt_batal.TabIndex = 17
        Me.dan_bt_batal.Text = "Batal"
        Me.dan_bt_batal.UseVisualStyleBackColor = True
        '
        'dan_bt_login
        '
        Me.dan_bt_login.AutoEllipsis = True
        Me.dan_bt_login.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.dan_bt_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.dan_bt_login.Location = New System.Drawing.Point(203, 165)
        Me.dan_bt_login.Name = "dan_bt_login"
        Me.dan_bt_login.Size = New System.Drawing.Size(86, 30)
        Me.dan_bt_login.TabIndex = 16
        Me.dan_bt_login.Text = "Login"
        Me.dan_bt_login.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(19, 297)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 25)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Welcome"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(19, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 20)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(19, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 20)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Username"
        '
        'dan_txb_password
        '
        Me.dan_txb_password.BackColor = System.Drawing.Color.WhiteSmoke
        Me.dan_txb_password.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dan_txb_password.Location = New System.Drawing.Point(108, 124)
        Me.dan_txb_password.Name = "dan_txb_password"
        Me.dan_txb_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.dan_txb_password.Size = New System.Drawing.Size(181, 26)
        Me.dan_txb_password.TabIndex = 12
        '
        'dan_txb_username
        '
        Me.dan_txb_username.BackColor = System.Drawing.Color.WhiteSmoke
        Me.dan_txb_username.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dan_txb_username.Location = New System.Drawing.Point(108, 83)
        Me.dan_txb_username.Name = "dan_txb_username"
        Me.dan_txb_username.Size = New System.Drawing.Size(181, 26)
        Me.dan_txb_username.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(132, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 20)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Login"
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PAplikasiToko_PBD_IF21Dx.My.Resources.Resources.bg1
        Me.ClientSize = New System.Drawing.Size(316, 359)
        Me.ControlBox = False
        Me.Controls.Add(Me.dan_lbl_ver)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dan_bt_batal)
        Me.Controls.Add(Me.dan_bt_login)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dan_txb_password)
        Me.Controls.Add(Me.dan_txb_username)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(332, 398)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(332, 398)
        Me.Name = "login"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dan_lbl_ver As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dan_bt_batal As System.Windows.Forms.Button
    Friend WithEvents dan_bt_login As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dan_txb_password As System.Windows.Forms.TextBox
    Friend WithEvents dan_txb_username As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
