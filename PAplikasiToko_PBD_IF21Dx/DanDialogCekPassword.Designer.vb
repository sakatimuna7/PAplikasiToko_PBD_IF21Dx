<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DanDialogCekPassword
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dan_txb_password = New System.Windows.Forms.TextBox()
        Me.dan_bt_ok = New System.Windows.Forms.Button()
        Me.dan_bt_batal = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(76, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Masukan Password"
        '
        'dan_txb_password
        '
        Me.dan_txb_password.Location = New System.Drawing.Point(12, 32)
        Me.dan_txb_password.Name = "dan_txb_password"
        Me.dan_txb_password.Size = New System.Drawing.Size(282, 20)
        Me.dan_txb_password.TabIndex = 1
        '
        'dan_bt_ok
        '
        Me.dan_bt_ok.Location = New System.Drawing.Point(12, 65)
        Me.dan_bt_ok.Name = "dan_bt_ok"
        Me.dan_bt_ok.Size = New System.Drawing.Size(135, 28)
        Me.dan_bt_ok.TabIndex = 2
        Me.dan_bt_ok.Text = "Ok"
        Me.dan_bt_ok.UseVisualStyleBackColor = True
        '
        'dan_bt_batal
        '
        Me.dan_bt_batal.Location = New System.Drawing.Point(153, 65)
        Me.dan_bt_batal.Name = "dan_bt_batal"
        Me.dan_bt_batal.Size = New System.Drawing.Size(141, 28)
        Me.dan_bt_batal.TabIndex = 3
        Me.dan_bt_batal.Text = "Batal"
        Me.dan_bt_batal.UseVisualStyleBackColor = True
        '
        'DanFrmCekPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(306, 105)
        Me.ControlBox = False
        Me.Controls.Add(Me.dan_bt_batal)
        Me.Controls.Add(Me.dan_bt_ok)
        Me.Controls.Add(Me.dan_txb_password)
        Me.Controls.Add(Me.Label1)
        Me.Name = "DanFrmCekPassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Cek Password"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dan_txb_password As System.Windows.Forms.TextBox
    Friend WithEvents dan_bt_ok As System.Windows.Forms.Button
    Friend WithEvents dan_bt_batal As System.Windows.Forms.Button
End Class
