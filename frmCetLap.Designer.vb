<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCetLap
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.lblNamaLoket = New System.Windows.Forms.Label()
        Me.txtKodeLoket = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtJmlPendapatan = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtJmlRek = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblPeriode = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.DataGridView1, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(933, 623)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.DateTimePicker2)
        Me.Panel1.Controls.Add(Me.lblNamaLoket)
        Me.Panel1.Controls.Add(Me.txtKodeLoket)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtJmlPendapatan)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtJmlRek)
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.lblPeriode)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(927, 144)
        Me.Panel1.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(230, 45)
        Me.Label6.Margin = New System.Windows.Forms.Padding(5)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 18)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "s / d"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CustomFormat = "yyyy-MM-dd"
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker2.Location = New System.Drawing.Point(274, 41)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(103, 23)
        Me.DateTimePicker2.TabIndex = 15
        Me.DateTimePicker2.Value = New Date(2020, 12, 19, 0, 0, 0, 0)
        '
        'lblNamaLoket
        '
        Me.lblNamaLoket.AutoSize = True
        Me.lblNamaLoket.Location = New System.Drawing.Point(776, 68)
        Me.lblNamaLoket.Name = "lblNamaLoket"
        Me.lblNamaLoket.Size = New System.Drawing.Size(46, 18)
        Me.lblNamaLoket.TabIndex = 14
        Me.lblNamaLoket.Text = "Label6"
        '
        'txtKodeLoket
        '
        Me.txtKodeLoket.BackColor = System.Drawing.SystemColors.Info
        Me.txtKodeLoket.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtKodeLoket.Location = New System.Drawing.Point(730, 66)
        Me.txtKodeLoket.Name = "txtKodeLoket"
        Me.txtKodeLoket.ReadOnly = True
        Me.txtKodeLoket.Size = New System.Drawing.Size(40, 23)
        Me.txtKodeLoket.TabIndex = 13
        '
        'Button2
        '
        Me.Button2.AutoSize = True
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(221, 107)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 30)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "Cetak"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.AutoSize = True
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(119, 107)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 30)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Refresh"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(602, 39)
        Me.Label5.Margin = New System.Windows.Forms.Padding(5)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(107, 18)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Total Pendapatan"
        '
        'txtJmlPendapatan
        '
        Me.txtJmlPendapatan.BackColor = System.Drawing.SystemColors.Info
        Me.txtJmlPendapatan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtJmlPendapatan.Location = New System.Drawing.Point(730, 37)
        Me.txtJmlPendapatan.Name = "txtJmlPendapatan"
        Me.txtJmlPendapatan.ReadOnly = True
        Me.txtJmlPendapatan.Size = New System.Drawing.Size(186, 23)
        Me.txtJmlPendapatan.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(602, 9)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 18)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Rekening Terbayar"
        '
        'txtJmlRek
        '
        Me.txtJmlRek.BackColor = System.Drawing.SystemColors.Info
        Me.txtJmlRek.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtJmlRek.Location = New System.Drawing.Point(730, 7)
        Me.txtJmlRek.Name = "txtJmlRek"
        Me.txtJmlRek.ReadOnly = True
        Me.txtJmlRek.Size = New System.Drawing.Size(63, 23)
        Me.txtJmlRek.TabIndex = 7
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownWidth = 300
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Laporan Rincian Penerimaan Pembayaran (LPP)", "Laporan Rekap Penerimaan Pembayaran (LPP)"})
        Me.ComboBox1.Location = New System.Drawing.Point(119, 9)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(177, 26)
        Me.ComboBox1.TabIndex = 5
        Me.ComboBox1.Text = ">> Pilih Jenis Laporan <<"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "yyyy-MM-dd"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(119, 41)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(103, 23)
        Me.DateTimePicker1.TabIndex = 4
        Me.DateTimePicker1.Value = New Date(2020, 12, 19, 0, 0, 0, 0)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(602, 68)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Lokasi Loket"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 12)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Jenis Laporan"
        '
        'lblPeriode
        '
        Me.lblPeriode.AutoSize = True
        Me.lblPeriode.Location = New System.Drawing.Point(11, 43)
        Me.lblPeriode.Margin = New System.Windows.Forms.Padding(5)
        Me.lblPeriode.Name = "lblPeriode"
        Me.lblPeriode.Size = New System.Drawing.Size(52, 18)
        Me.lblPeriode.TabIndex = 0
        Me.lblPeriode.Text = "Tanggal"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(3, 153)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(927, 467)
        Me.DataGridView1.TabIndex = 1
        '
        'frmCetLap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(933, 623)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmCetLap"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cetak Laporan"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents lblPeriode As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txtJmlPendapatan As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtJmlRek As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents lblNamaLoket As Label
    Friend WithEvents txtKodeLoket As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents DateTimePicker2 As DateTimePicker
End Class
