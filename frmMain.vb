Imports System.ComponentModel

Public Class frmMain
    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub btnKasir_Click(sender As Object, e As EventArgs) Handles btnKasir.Click
        frmKasir.Show()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "Anda login sebagai " & getNama() & " hari ini." & Environment.NewLine & "Selamat Bekerja.."
        Label2.Text = "Perumdam Tirta Kencana" & vbNewLine & "Kota Samarinda"
        openConnection()
    End Sub

    Private Sub frmMain_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        closeConnection()
        Application.Exit()
    End Sub

    Private Sub btnSetting_Click(sender As Object, e As EventArgs) Handles btnSetting.Click
        frmSetting.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub frmMain_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

    End Sub

    Private Sub btnLaporan_Click(sender As Object, e As EventArgs) Handles btnLaporan.Click
        frmCetLap.Show()
    End Sub

End Class
