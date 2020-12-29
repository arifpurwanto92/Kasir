<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSetting
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
        Me.btnSimpanDb = New System.Windows.Forms.Button()
        Me.btnTest = New System.Windows.Forms.Button()
        Me.txtDbase = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPort = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtHost = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cbPrinter = New System.Windows.Forms.ComboBox()
        Me.btnSimpanPrinter = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 14)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 68.30065!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.69935!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(354, 307)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnSimpanDb)
        Me.Panel1.Controls.Add(Me.btnTest)
        Me.Panel1.Controls.Add(Me.txtDbase)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtPort)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtPass)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtUser)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtHost)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(346, 201)
        Me.Panel1.TabIndex = 0
        '
        'btnSimpanDb
        '
        Me.btnSimpanDb.AutoSize = True
        Me.btnSimpanDb.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSimpanDb.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSimpanDb.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSimpanDb.Location = New System.Drawing.Point(221, 168)
        Me.btnSimpanDb.Name = "btnSimpanDb"
        Me.btnSimpanDb.Size = New System.Drawing.Size(75, 30)
        Me.btnSimpanDb.TabIndex = 11
        Me.btnSimpanDb.Text = "&Simpan"
        Me.btnSimpanDb.UseVisualStyleBackColor = True
        '
        'btnTest
        '
        Me.btnTest.AutoSize = True
        Me.btnTest.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnTest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTest.Location = New System.Drawing.Point(70, 168)
        Me.btnTest.Name = "btnTest"
        Me.btnTest.Size = New System.Drawing.Size(75, 30)
        Me.btnTest.TabIndex = 10
        Me.btnTest.Text = "&Test"
        Me.btnTest.UseVisualStyleBackColor = True
        '
        'txtDbase
        '
        Me.txtDbase.Location = New System.Drawing.Point(70, 137)
        Me.txtDbase.Margin = New System.Windows.Forms.Padding(5)
        Me.txtDbase.Name = "txtDbase"
        Me.txtDbase.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtDbase.Size = New System.Drawing.Size(226, 23)
        Me.txtDbase.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(5, 140)
        Me.Label5.Margin = New System.Windows.Forms.Padding(5)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 18)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Database"
        '
        'txtPort
        '
        Me.txtPort.Location = New System.Drawing.Point(70, 104)
        Me.txtPort.Margin = New System.Windows.Forms.Padding(5)
        Me.txtPort.Name = "txtPort"
        Me.txtPort.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPort.Size = New System.Drawing.Size(226, 23)
        Me.txtPort.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(5, 107)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 18)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Port"
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(70, 71)
        Me.txtPass.Margin = New System.Windows.Forms.Padding(5)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPass.Size = New System.Drawing.Size(226, 23)
        Me.txtPass.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 74)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 18)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Pass"
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(70, 38)
        Me.txtUser.Margin = New System.Windows.Forms.Padding(5)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtUser.Size = New System.Drawing.Size(226, 23)
        Me.txtUser.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 41)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "User"
        '
        'txtHost
        '
        Me.txtHost.Location = New System.Drawing.Point(70, 5)
        Me.txtHost.Margin = New System.Windows.Forms.Padding(5)
        Me.txtHost.Name = "txtHost"
        Me.txtHost.Size = New System.Drawing.Size(226, 23)
        Me.txtHost.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 8)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Host"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.cbPrinter)
        Me.Panel2.Controls.Add(Me.btnSimpanPrinter)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(4, 212)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(346, 91)
        Me.Panel2.TabIndex = 1
        '
        'cbPrinter
        '
        Me.cbPrinter.FormattingEnabled = True
        Me.cbPrinter.Location = New System.Drawing.Point(65, 8)
        Me.cbPrinter.Name = "cbPrinter"
        Me.cbPrinter.Size = New System.Drawing.Size(278, 26)
        Me.cbPrinter.TabIndex = 13
        '
        'btnSimpanPrinter
        '
        Me.btnSimpanPrinter.AutoSize = True
        Me.btnSimpanPrinter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSimpanPrinter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSimpanPrinter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSimpanPrinter.Location = New System.Drawing.Point(128, 40)
        Me.btnSimpanPrinter.Name = "btnSimpanPrinter"
        Me.btnSimpanPrinter.Size = New System.Drawing.Size(75, 30)
        Me.btnSimpanPrinter.TabIndex = 12
        Me.btnSimpanPrinter.Text = "Sim&pan"
        Me.btnSimpanPrinter.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(10, 11)
        Me.Label6.Margin = New System.Windows.Forms.Padding(5)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 18)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Printer"
        '
        'frmSetting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(378, 335)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "frmSetting"
        Me.Padding = New System.Windows.Forms.Padding(12, 14, 12, 14)
        Me.Text = "Setting | Kasir Perumdam"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnSimpanDb As Button
    Friend WithEvents btnTest As Button
    Friend WithEvents txtDbase As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPort As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPass As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtUser As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtHost As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnSimpanPrinter As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents cbPrinter As ComboBox
End Class
