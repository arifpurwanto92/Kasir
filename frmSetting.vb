Imports System.Drawing.Printing
Public Class frmSetting
    Private Sub frmSetting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each printer In PrinterSettings.InstalledPrinters
            cbPrinter.Items.Add(printer)
        Next
        txtHost.Text = My.Settings.host
        txtUser.Text = My.Settings.user
        txtPass.Text = My.Settings.pass
        txtPort.Text = My.Settings.port
        txtDbase.Text = My.Settings.dbase
        cbPrinter.Text = My.Settings.printer_name
    End Sub

    Private Sub btnSimpanPrinter_Click(sender As Object, e As EventArgs) Handles btnSimpanPrinter.Click
        My.Settings.printer_name = cbPrinter.SelectedItem
    End Sub

    Private Sub btnTest_Click(sender As Object, e As EventArgs) Handles btnTest.Click
        Dim conn As MySql.Data.MySqlClient.MySqlConnection
        conn = New MySql.Data.MySqlClient.MySqlConnection("server=" + txtHost.Text + "; port=" + txtPort.Text + "; 
                                                           uid=" + txtUser.Text + "; pwd=" + txtPass.Text + "; 
                                                           database=" + txtDbase.Text + "; persistsecurityinfo=True;")
        Try
            conn.Open()
            If conn.State = ConnectionState.Open Then
                MsgBox("Berhasil menghubungkan ke database", MsgBoxStyle.Information)
                conn.Close()
            End If
        Catch ex As Exception
            MsgBox("Tidak dapat menghubungkan ke database. (" & ex.Message.ToString & ")", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnSimpanDb_Click(sender As Object, e As EventArgs) Handles btnSimpanDb.Click
        My.Settings.host = txtHost.Text
        My.Settings.pass = txtPass.Text
        My.Settings.port = txtPort.Text
        My.Settings.dbase = txtDbase.Text
        My.Settings.user = txtUser.Text
        MsgBox("Data berhasil disimpan")
    End Sub
End Class