<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmKasir
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmKasir))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtTotFee = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtJmlRek = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtSubtotal = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtAdm = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.txtGol = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtAlamat = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNopel = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PrintDoc = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.btnBayar = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.DataGridView1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 0, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 130.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1200, 661)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txtTotFee)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.txtJmlRek)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.txtSubtotal)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.txtAdm)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtTotal)
        Me.Panel1.Controls.Add(Me.txtGol)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtAlamat)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtNama)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtNopel)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(10)
        Me.Panel1.Size = New System.Drawing.Size(1192, 124)
        Me.Panel1.TabIndex = 0
        '
        'txtTotFee
        '
        Me.txtTotFee.BackColor = System.Drawing.SystemColors.Info
        Me.txtTotFee.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotFee.Location = New System.Drawing.Point(965, 49)
        Me.txtTotFee.Margin = New System.Windows.Forms.Padding(10)
        Me.txtTotFee.Name = "txtTotFee"
        Me.txtTotFee.ReadOnly = True
        Me.txtTotFee.Size = New System.Drawing.Size(128, 32)
        Me.txtTotFee.TabIndex = 18
        Me.txtTotFee.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(256, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(0, 22)
        Me.Label9.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(1099, 65)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(85, 49)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Rekening Dicetak"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtJmlRek
        '
        Me.txtJmlRek.BackColor = System.Drawing.SystemColors.Info
        Me.txtJmlRek.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtJmlRek.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtJmlRek.Font = New System.Drawing.Font("Trebuchet MS", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJmlRek.Location = New System.Drawing.Point(1108, 9)
        Me.txtJmlRek.Name = "txtJmlRek"
        Me.txtJmlRek.ReadOnly = True
        Me.txtJmlRek.Size = New System.Drawing.Size(66, 50)
        Me.txtJmlRek.TabIndex = 14
        Me.txtJmlRek.Text = "999"
        Me.txtJmlRek.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(784, 16)
        Me.Label7.Margin = New System.Windows.Forms.Padding(10)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 22)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "SubTotal"
        '
        'txtSubtotal
        '
        Me.txtSubtotal.BackColor = System.Drawing.SystemColors.Info
        Me.txtSubtotal.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubtotal.Location = New System.Drawing.Point(893, 9)
        Me.txtSubtotal.Margin = New System.Windows.Forms.Padding(10)
        Me.txtSubtotal.Name = "txtSubtotal"
        Me.txtSubtotal.ReadOnly = True
        Me.txtSubtotal.Size = New System.Drawing.Size(200, 32)
        Me.txtSubtotal.TabIndex = 12
        Me.txtSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(786, 56)
        Me.Label6.Margin = New System.Windows.Forms.Padding(10)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 22)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Adm"
        '
        'txtAdm
        '
        Me.txtAdm.BackColor = System.Drawing.SystemColors.Info
        Me.txtAdm.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdm.Location = New System.Drawing.Point(895, 49)
        Me.txtAdm.Margin = New System.Windows.Forms.Padding(10)
        Me.txtAdm.Name = "txtAdm"
        Me.txtAdm.ReadOnly = True
        Me.txtAdm.Size = New System.Drawing.Size(67, 32)
        Me.txtAdm.TabIndex = 10
        Me.txtAdm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(786, 94)
        Me.Label5.Margin = New System.Windows.Forms.Padding(10)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 22)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Total Harga"
        '
        'txtTotal
        '
        Me.txtTotal.BackColor = System.Drawing.SystemColors.Info
        Me.txtTotal.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(895, 87)
        Me.txtTotal.Margin = New System.Windows.Forms.Padding(10)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(198, 32)
        Me.txtTotal.TabIndex = 8
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtGol
        '
        Me.txtGol.BackColor = System.Drawing.SystemColors.Info
        Me.txtGol.Location = New System.Drawing.Point(468, 53)
        Me.txtGol.Margin = New System.Windows.Forms.Padding(10)
        Me.txtGol.Name = "txtGol"
        Me.txtGol.ReadOnly = True
        Me.txtGol.Size = New System.Drawing.Size(53, 26)
        Me.txtGol.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(365, 56)
        Me.Label4.Margin = New System.Windows.Forms.Padding(10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 22)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Golongan"
        '
        'txtAlamat
        '
        Me.txtAlamat.BackColor = System.Drawing.SystemColors.Info
        Me.txtAlamat.Location = New System.Drawing.Point(143, 91)
        Me.txtAlamat.Name = "txtAlamat"
        Me.txtAlamat.ReadOnly = True
        Me.txtAlamat.Size = New System.Drawing.Size(378, 26)
        Me.txtAlamat.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 94)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 22)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Alamat"
        '
        'txtNama
        '
        Me.txtNama.BackColor = System.Drawing.SystemColors.Info
        Me.txtNama.Location = New System.Drawing.Point(143, 52)
        Me.txtNama.Margin = New System.Windows.Forms.Padding(10)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.ReadOnly = True
        Me.txtNama.Size = New System.Drawing.Size(202, 26)
        Me.txtNama.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 55)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 22)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nama"
        '
        'txtNopel
        '
        Me.txtNopel.Location = New System.Drawing.Point(143, 13)
        Me.txtNopel.Margin = New System.Windows.Forms.Padding(10)
        Me.txtNopel.MaxLength = 7
        Me.txtNopel.Name = "txtNopel"
        Me.txtNopel.Size = New System.Drawing.Size(100, 26)
        Me.txtNopel.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 16)
        Me.Label1.Margin = New System.Windows.Forms.Padding(10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&No Pelanggan"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(876, 56)
        Me.Label10.Margin = New System.Windows.Forms.Padding(10)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(22, 22)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "@"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(4, 135)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1192, 421)
        Me.DataGridView1.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnBayar)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(4, 563)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1192, 94)
        Me.Panel2.TabIndex = 2
        '
        'PrintDoc
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'btnBayar
        '
        Me.btnBayar.AutoSize = True
        Me.btnBayar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBayar.Image = Global.KasirPerumdam.My.Resources.Resources.printer
        Me.btnBayar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnBayar.Location = New System.Drawing.Point(9, 6)
        Me.btnBayar.Name = "btnBayar"
        Me.btnBayar.Padding = New System.Windows.Forms.Padding(5)
        Me.btnBayar.Size = New System.Drawing.Size(104, 82)
        Me.btnBayar.TabIndex = 0
        Me.btnBayar.Text = "Bayar (F2)"
        Me.btnBayar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBayar.UseVisualStyleBackColor = True
        '
        'frmKasir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 661)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximumSize = New System.Drawing.Size(1216, 700)
        Me.Name = "frmKasir"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Kasir Perumdam"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents txtGol As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNopel As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnBayar As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents txtJmlRek As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtSubtotal As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtAdm As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents PrintDoc As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents Label10 As Label
    Friend WithEvents txtTotFee As TextBox
End Class
