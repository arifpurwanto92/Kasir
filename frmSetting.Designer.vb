﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Host"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(87, 17)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(131, 23)
        Me.TextBox1.TabIndex = 1
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(87, 46)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(131, 23)
        Me.TextBox2.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Username"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(87, 75)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(131, 23)
        Me.TextBox3.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 18)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Password"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(87, 104)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(79, 23)
        Me.TextBox4.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 107)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 18)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Port"
        '
        'frmSetting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(248, 272)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmSetting"
        Me.Padding = New System.Windows.Forms.Padding(12, 14, 12, 14)
        Me.Text = "Setting | Kasir Perumdam"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label4 As Label
End Class
