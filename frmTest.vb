Public Class frmTest
    Dim page As Integer = 0
    Dim cet As Boolean = True
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim head As New Font("Courier New", 10)
        Dim body As New Font("Courier New", 9)
        Dim bsh As New SolidBrush(Color.Black)
        Dim rect As Rectangle
        Dim format As New StringFormat(StringFormatFlags.DirectionRightToLeft)
        Console.WriteLine("Prepare for loop")
        Console.WriteLine("Page Before : " & page)
        e.Graphics.DrawString("KOPERASI PERUMDAM TIRTA KENCANA", head, bsh, 5, 1)
        e.Graphics.DrawString("Jl. Tirta Kencana Kota Samarinda", head, bsh, 5, 13)
        e.Graphics.DrawString("---------------------------------------------------", head, bsh, 5, 23)
        e.Graphics.DrawString("KWITANSI PEMBAYARAN REKENING AIR", head, bsh, 5, 33)

        e.Graphics.DrawString("Bulan", body, bsh, 5, 50)
        e.Graphics.DrawString(": MMM 8888", body, bsh, 85, 50)
        e.Graphics.DrawString("> Harga Air", body, bsh, 300, 50)
        e.Graphics.DrawString(": Rp", body, bsh, 450, 50)
        rect = New Rectangle(460, 50, 150, 15)
        e.Graphics.DrawString("888.888.888.888", body, bsh, rect, format)

        e.Graphics.DrawString("No. Samb", body, bsh, 5, 65)
        e.Graphics.DrawString(": 8888888", body, bsh, 85, 65)
        e.Graphics.DrawString("> Abonemen", body, bsh, 300, 65)
        e.Graphics.DrawString(": Rp", body, bsh, 450, 65)
        rect = New Rectangle(460, 65, 150, 15)
        e.Graphics.DrawString("88.888", body, bsh, rect, format)

        e.Graphics.DrawString("Nama", body, bsh, 5, 80)
        e.Graphics.DrawString(": MMMMMMMMMMMMMMMM " & page, body, bsh, 85, 80)
        e.Graphics.DrawString("> Listrik/Mtri", body, bsh, 300, 80)
        e.Graphics.DrawString(": Rp", body, bsh, 450, 80)
        rect = New Rectangle(460, 80, 150, 15)
        e.Graphics.DrawString("8.888", body, bsh, rect, format)

        e.Graphics.DrawString("Alamat", body, bsh, 5, 95)
        e.Graphics.DrawString(": MMMMMWWWWWMMMMMWWWWWM", body, bsh, 85, 95)
        e.Graphics.DrawString("> Retribusi", body, bsh, 300, 95)
        e.Graphics.DrawString(": Rp", body, bsh, 450, 95)
        rect = New Rectangle(460, 95, 150, 15)
        e.Graphics.DrawString("88.888", body, bsh, rect, format)
        'e.Graphics.FillRectangle(bsh, rect)

        e.Graphics.DrawString("Daya Listr", body, bsh, 5, 110)
        e.Graphics.DrawString(": W8", body, bsh, 85, 110)
        e.Graphics.DrawString("> Denda/B.Buka", body, bsh, 300, 110)
        e.Graphics.DrawString(": Rp", body, bsh, 450, 110)
        rect = New Rectangle(460, 110, 150, 15)
        e.Graphics.DrawString("888.888", body, bsh, rect, format)

        e.Graphics.DrawString("STAND METER (M3) DAN TARIF Rp/M3", head, bsh, 5, 125)
        e.Graphics.DrawString("> Admin Loket", body, bsh, 300, 125)
        e.Graphics.DrawString(": Rp", body, bsh, 450, 125)
        rect = New Rectangle(460, 125, 150, 15)
        e.Graphics.DrawString("888.888.888.888", body, bsh, rect, format)

        e.Graphics.DrawString("Bln Ini", body, bsh, 5, 140)
        e.Graphics.DrawString(": 888888", body, bsh, 85, 140)
        e.Graphics.DrawString("Bln Lalu", body, bsh, 150, 140)
        e.Graphics.DrawString(": 888888", body, bsh, 200, 140)
        e.Graphics.DrawString("> Ang. Air", body, bsh, 300, 140)
        e.Graphics.DrawString(": Rp", body, bsh, 450, 140)
        rect = New Rectangle(460, 140, 150, 15)
        e.Graphics.DrawString("888.888.888", body, bsh, rect, format)

        e.Graphics.DrawString("Pemakaian", body, bsh, 5, 155)
        e.Graphics.DrawString(": 888888", body, bsh, 85, 155)
        e.Graphics.DrawString("JUMLAH TAGIHAN", body, bsh, 300, 155)
        e.Graphics.DrawString(": Rp", body, bsh, 450, 155)
        rect = New Rectangle(460, 155, 150, 15)
        e.Graphics.DrawString("88.888.888", body, bsh, rect, format)
        page = page + 1
        e.HasMorePages = page < 5
    End Sub

    Private Sub frmTest_Load(sender As Object, e As EventArgs) Handles Me.Load
        page = 0
        PrintDocument1.DefaultPageSettings.PaperSize = New Printing.PaperSize("custom", 850, 250)
        'PrintPreviewDialog1.Document = PrintDocument1
        'PrintPreviewDialog1.ShowDialog()
        PrintDocument1.Print()

    End Sub
End Class