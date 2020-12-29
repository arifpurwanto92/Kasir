Imports MySql.Data.MySqlClient
Imports Microsoft.Reporting.WinForms
Imports System.IO
Imports System.Text
Imports System.Drawing.Imaging
Imports System.Drawing.Printing

Public Class frmKasir
    Dim subtot, total, adm, feeadm As Double
    Dim rd As MySqlDataReader
    Dim cmd As New MySqlCommand
    Dim nopel As String
    Dim page As Integer
    Dim nama, loket, opr As String
    Dim noLpp, tgl_byr, jam_byr As String

    Private m_currentPageIndex As Integer
    Private m_streams As IList(Of Stream)
    Private Sub stateAwal()
        txtNopel.Text = ""
        txtNama.Text = ""
        txtAlamat.Text = ""
        txtGol.Text = ""
        txtSubtotal.Text = "0"
        txtAdm.Text = "0"
        txtTotFee.Text = "0"
        txtTotal.Text = "0"
        txtJmlRek.Text = "0"
        subtot = 0
        total = 0
        adm = 2500
    End Sub

    Private Sub showDataDg()
        cmd.Parameters.Clear()
        cmd.CommandText = "select b.periode, b.MET_L, b.MET_K, b.pakai, (b.R1+b.R2+b.R3+b.R4) as h_air, b.ang_sb,b.adm, b.denda, b.materai, " _
                        & "b.dnmet, b.R1+b.R2+b.R3+b.R4+b.adm+b.ang_sb+b.denda+b.materai+b.dnmet as jumlah from rekair b where b.tg=1 And b.statrek='A'" _
                        & "And b.nosamw = @nosam"
        cmd.Parameters.AddWithValue("nosam", nopel)
        Dim da As New MySqlDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)
        DataGridView1.DataSource = dt

        'initialize column 
        DataGridView1.Columns(0).HeaderText = "Periode"
        DataGridView1.Columns(1).HeaderText = "M. Lalu"
        DataGridView1.Columns(2).HeaderText = "M. Kini"
        DataGridView1.Columns(3).HeaderText = "Pakai"
        DataGridView1.Columns(4).HeaderText = "Harga Air"
        DataGridView1.Columns(4).DefaultCellStyle.Format = "N0"
        DataGridView1.Columns(5).HeaderText = "Angsuran"
        DataGridView1.Columns(5).DefaultCellStyle.Format = "N0"
        DataGridView1.Columns(6).HeaderText = "Abodemen"
        DataGridView1.Columns(6).DefaultCellStyle.Format = "N0"
        DataGridView1.Columns(7).HeaderText = "Denda"
        DataGridView1.Columns(7).DefaultCellStyle.Format = "N0"
        DataGridView1.Columns(8).HeaderText = "Materai"
        DataGridView1.Columns(8).DefaultCellStyle.Format = "N0"
        DataGridView1.Columns(9).HeaderText = "Retribusi"
        DataGridView1.Columns(9).DefaultCellStyle.Format = "N0"
        DataGridView1.Columns(10).HeaderText = "Jumlah"
        DataGridView1.Columns(10).DefaultCellStyle.Format = "N0"
        DataGridView1.Refresh()
        da.Dispose()
    End Sub

    Private Sub txtNopel_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNopel.KeyDown
        Dim succ, lunas As Boolean
        If e.KeyCode = Keys.Enter Then
            nopel = txtNopel.Text
            Label9.Text = "/ " & txtNopel.Text
            Debug.WriteLine("Proses nopel : " & nopel)

            Debug.WriteLine("Query to check available data")
            cmd.Parameters.Clear()
            cmd.CommandText = "select count(nosamw) as n from rekair where tg=1 And statrek='A' and nosamw=@nosam "
            cmd.Parameters.AddWithValue("nosam", nopel)
            rd = cmd.ExecuteReader
            Debug.WriteLine("done execute query")
            rd.Read()
            If rd.GetInt16("n") > 0 Then
                Debug.WriteLine("Lunas : False")
                lunas = False
                rd.Close()
            Else
                Debug.WriteLine("Lunas : true")
                lunas = True
                MsgBox("Tagihan atas no pelanggan : " & nopel & " telah dilunasi")
                cmd.Parameters.Clear()
                stateAwal()
                rd.Close()
            End If
            If lunas = False Then
                Debug.WriteLine("Proses data detail tagihan")

                cmd.CommandText = "select a.nama, a.alamat, a.jlw, count(b.periode) as jml_rek, sum(b.dnmet)+sum(b.adm)+sum(b.R1)+sum(b.R2)+sum(B.R3)+sum(b.R4)" _
                                & "+sum(b.denda)+sum(b.B_TUTUP)+sum(b.ANG_SB)+sum(b.LISTRIK)+sum(b.MATERAI) as tagihan from cust a, rekair b where a.nosamw=b.nosamw " _
                                & "And b.tg=1 And b.statrek='A' and a.nosamw=@nosam"
                rd = cmd.ExecuteReader
                If rd.HasRows Then
                    While rd.Read
                        Debug.WriteLine("Tampilkan data tagihan")
                        txtNama.Text = rd.GetString("NAMA").ToString
                        txtAlamat.Text = rd.GetString("ALAMAT").ToString
                        txtGol.Text = rd.GetString("JLW").ToString

                        txtJmlRek.Text = rd.GetString("jml_rek").ToString
                        txtSubtotal.Text = String.Format("{0:n0}", CDec(rd.GetDouble("tagihan")))
                        txtAdm.Text = String.Format("{0:n0}", feeadm)
                        txtTotFee.Text = String.Format("{0:n0}", feeadm * CInt(txtJmlRek.Text))
                        txtTotal.Text = String.Format("{0:n0}", CDec(rd.GetDouble("tagihan") + (feeadm * CInt(txtJmlRek.Text))))
                        succ = True
                        txtNopel.Text = ""
                    End While
                End If
                rd.Close()
                cmd.Parameters.Clear()
                showDataDg()
            Else
                DataGridView1.DataSource = Nothing
                DataGridView1.Refresh()
            End If
        End If
    End Sub
    Private Sub btnBayar_Click(sender As Object, e As EventArgs) Handles btnBayar.Click
        page = 0
        'cek no cetak
        Dim curdate As String = Date.Now.ToString("yyyy-MM-dd")
        jam_byr = Date.Now.ToString("H:m:s")
        cmd.Parameters.Clear()
        'cmd.CommandText = "select count(*) as n from rekair where tgl_byr=@tglbyr and loket_byr=@loket group by tgl_byr"
        cmd.CommandText = "select count(distinct(nosamw)) as n from rekair where tgl_byr='" + curdate + "' and loket_byr='" + getLoket() + "' group by tgl_byr"
        'cmd.Parameters.AddWithValue("tglbyr", curdate)
        'cmd.Parameters.AddWithValue("loket", getLoket)

        rd = cmd.ExecuteReader
        If rd.HasRows Then
            rd.Read()
            updateNumCetak(rd.Item(0) + 1)

        Else
            updateNumCetak(1)
        End If
        rd.Close()
        Console.WriteLine("No Urut Cetak : " + getNumCetak().ToString)
        'cmd.Parameters.Clear()
        PrintDoc.DefaultPageSettings.PaperSize = New Printing.PaperSize("custom", 850, 250)
        'PrintPreviewDialog1.Document = PrintDoc
        'PrintPreviewDialog1.ShowDialog()
        PrintDoc.Print()
        DataGridView1.DataSource = Nothing
        DataGridView1.Refresh()
        txtNopel.Select()

    End Sub


    Private Sub PrintDoc_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDoc.PrintPage
        Dim head As New Font("Courier New", 10)
        Dim body As New Font("Courier New", 9)
        Dim bsh As New SolidBrush(Color.Black)
        Dim rect As Rectangle
        Dim format As New StringFormat(StringFormatFlags.DirectionRightToLeft)
        Console.WriteLine("Update to database")
        cmd.Parameters.Clear()
        Dim query As String = "update rekair set TG = @tg, SC=@sc, tgl_byr=@tgl_byr, no_byr=@noByr, " _
                        & "person=@person, loket_byr=@loketByr, norek=@norek, kjml_na=@fee, nodrda=@jambayar where nosamw=@wNosamw and " _
                        & "periode=@periode"
        cmd.CommandText = query
        cmd.Parameters.AddWithValue("tg", CDbl(Val("0")))
        cmd.Parameters.AddWithValue("sc", CDbl(Val("1")))
        cmd.Parameters.AddWithValue("tgl_byr", tgl_byr)
        cmd.Parameters.AddWithValue("noByr", noLpp)
        cmd.Parameters.AddWithValue("person", getNama)
        cmd.Parameters.AddWithValue("loketByr", getLoket)
        cmd.Parameters.AddWithValue("norek", getNumCetak)
        cmd.Parameters.AddWithValue("wNosamw", nopel)
        cmd.Parameters.AddWithValue("periode", DataGridView1.Rows(page).Cells(0).Value)
        cmd.Parameters.AddWithValue("fee", feeadm)
        cmd.Parameters.AddWithValue("jambayar", jam_byr)
        Console.WriteLine(cmd.CommandText)
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Terjadi kesalahan pembayaran. Error Code : 444" + vbNewLine + ex.ToString, MsgBoxStyle.Critical)
            Exit Sub
        End Try
        Console.WriteLine("Printing page : " + page.ToString + "....")
        e.Graphics.DrawString("PERUMDAM TIRTA KENCANA", head, bsh, 5, 5)
        e.Graphics.DrawString("Jl. Tirta Kencana Kota Samarinda", head, bsh, 5, 20)
        e.Graphics.DrawString("---------------------------------------------------", head, bsh, 5, 35)
        e.Graphics.DrawString("KWITANSI PEMBAYARAN REKENING AIR", head, bsh, 5, 50)

        e.Graphics.DrawString("Bulan", body, bsh, 5, 65)
        e.Graphics.DrawString(": " & DataGridView1.Rows(page).Cells(0).Value, body, bsh, 85, 65)
        e.Graphics.DrawString("> Harga Air", body, bsh, 300, 65)
        e.Graphics.DrawString(": Rp", body, bsh, 420, 65)
        rect = New Rectangle(430, 65, 150, 15)
        e.Graphics.DrawString(String.Format("{0:n0}", DataGridView1.Rows(page).Cells(4).Value), body, bsh, rect, format)

        e.Graphics.DrawString("No. Samb", body, bsh, 5, 80)
        e.Graphics.DrawString(": " + nopel, body, bsh, 85, 80)
        e.Graphics.DrawString("> Abonemen", body, bsh, 300, 80)
        e.Graphics.DrawString(": Rp", body, bsh, 420, 80)
        rect = New Rectangle(430, 80, 150, 15)
        e.Graphics.DrawString(String.Format("{0:n0}", DataGridView1.Rows(page).Cells(6).Value), body, bsh, rect, format)

        e.Graphics.DrawString("Nama", body, bsh, 5, 95)
        e.Graphics.DrawString(": " & txtNama.Text.ToUpper, body, bsh, 85, 95)
        e.Graphics.DrawString("> Listrik/Mtri", body, bsh, 300, 95)
        e.Graphics.DrawString(": Rp", body, bsh, 420, 95)
        rect = New Rectangle(430, 95, 150, 15)
        e.Graphics.DrawString(String.Format("{0:n0}", DataGridView1.Rows(page).Cells(8).Value), body, bsh, rect, format)

        e.Graphics.DrawString("Alamat", body, bsh, 5, 110)
        Dim tAlm As String
        If txtAlamat.Text.Length > 24 Then
            tAlm = txtAlamat.Text.Substring(0, 24)
        Else
            tAlm = txtAlamat.Text
        End If
        e.Graphics.DrawString(": " & tAlm, body, bsh, 85, 110)
        e.Graphics.DrawString("> Retribusi", body, bsh, 300, 110)
        e.Graphics.DrawString(": Rp", body, bsh, 420, 110)
        rect = New Rectangle(430, 110, 150, 15)
        e.Graphics.DrawString(String.Format("{0:n0}", DataGridView1.Rows(page).Cells(9).Value), body, bsh, rect, format)
        e.Graphics.DrawString("Tanggal", body, bsh, 600, 110)
        e.Graphics.DrawString(": " & Date.Now().ToShortDateString.ToString, body, bsh, 660, 110)

        e.Graphics.DrawString("Golongan", body, bsh, 5, 125)
        e.Graphics.DrawString(": " & txtGol.Text, body, bsh, 85, 125)
        e.Graphics.DrawString("> Denda/B.Buka", body, bsh, 300, 125)
        e.Graphics.DrawString(": Rp", body, bsh, 420, 125)
        rect = New Rectangle(430, 125, 150, 15)
        e.Graphics.DrawString(String.Format("{0:n0}", DataGridView1.Rows(page).Cells(7).Value), body, bsh, rect, format)
        e.Graphics.DrawString("NoRek", body, bsh, 600, 125)
        e.Graphics.DrawString(": " & getNumCetak() & " / " & page + 1, body, bsh, 660, 125)

        e.Graphics.DrawString("STAND METER (M3) DAN TARIF Rp/M3", head, bsh, 5, 140)
        e.Graphics.DrawString("> Admin Loket", body, bsh, 300, 140)
        e.Graphics.DrawString(": Rp", body, bsh, 420, 140)
        rect = New Rectangle(430, 140, 150, 15)
        e.Graphics.DrawString(String.Format("{0:n0}", feeadm), body, bsh, rect, format)
        e.Graphics.DrawString("Loket", body, bsh, 600, 140)
        e.Graphics.DrawString(": " & getLoket(), body, bsh, 660, 140)

        e.Graphics.DrawString("Bln Ini", body, bsh, 5, 155)
        e.Graphics.DrawString(": " & String.Format("{0:n0}", DataGridView1.Rows(page).Cells(2).Value), body, bsh, 85, 155)
        e.Graphics.DrawString("Bln Lalu", body, bsh, 150, 155)
        e.Graphics.DrawString(": " & String.Format("{0:n0}", DataGridView1.Rows(page).Cells(1).Value), body, bsh, 220, 155)
        e.Graphics.DrawString("> Ang. Air", body, bsh, 300, 155)
        e.Graphics.DrawString(": Rp", body, bsh, 420, 155)
        rect = New Rectangle(430, 155, 150, 15)
        e.Graphics.DrawString(String.Format("{0:n0}", DataGridView1.Rows(page).Cells(5).Value), body, bsh, rect, format)
        e.Graphics.DrawString("Kasir", body, bsh, 600, 155)
        e.Graphics.DrawString(": " & getNama(), body, bsh, 660, 155)

        e.Graphics.DrawString("Pemakaian", body, bsh, 5, 170)
        e.Graphics.DrawString(": " & String.Format("{0:n0}", DataGridView1.Rows(page).Cells(3).Value), body, bsh, 85, 170)
        e.Graphics.DrawString("JUMLAH TAGIHAN", body, bsh, 300, 170)
        e.Graphics.DrawString(": Rp", body, bsh, 420, 170)
        rect = New Rectangle(430, 170, 150, 15)
        e.Graphics.DrawString(String.Format("{0:n0}", DataGridView1.Rows(page).Cells(10).Value + 2500), body, bsh, rect, format)
        e.Graphics.DrawString("" & Date.Now.ToString("dd-MM-yyyy HH:mm:ss"), body, bsh, 600, 170)
        page = page + 1
        e.HasMorePages = page <= DataGridView1.Rows.Count - 1


    End Sub

    Private Sub frmKasir_Load(sender As Object, e As EventArgs) Handles Me.Load
        'open db connection
        Dim regDate As Date = Date.Now()
        tgl_byr = regDate.ToString("yyyy-MM-dd")
        noLpp = "DPHA" + regDate.ToString("yyyyMMdd")
        stateAwal()
        openConnection()
        nama = getNama()
        opr = getOpr()
        loket = getLoket()
        cmd.Connection = getDbConnection()
        cmd.CommandText = "select admbank from mloket where loket='" + loket + "'"
        rd = cmd.ExecuteReader
        rd.Read()
        feeadm = rd.GetDouble("admbank")
        rd.Close()

    End Sub
End Class