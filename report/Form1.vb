Public Class frmRptStruk
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.ReportViewer1.RefreshReport()
    End Sub

End Class