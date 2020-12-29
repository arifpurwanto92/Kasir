Imports MySql.Data.MySqlClient
Public Class frmCetLap

    Dim cmd As New MySqlCommand
    Dim rd As MySqlDataReader
    Dim dt As New DataTable
    Dim totag, rek As Integer
    Dim show As Boolean = False

    Private Function valid_date()
        Dim awal As Date = CDate(DateTimePicker1.Text)
        Dim akhir As Date = CDate(DateTimePicker2.Text)
        If akhir < awal Then
            MsgBox("Periode tanggal akhir lebih kecil dari periode tanggal awal")
            Return False
            Exit Function
        End If
    End Function
    Private Sub frmCetLap_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'InitDgv()
        closeConnection()
        openConnection()
        txtKodeLoket.Text = getLoket()
        lblNamaLoket.Text = getNamaLoket()
    End Sub

    Private Sub ShowDgv(ByVal dt As DataTable)
        DataGridView1.DataSource = dt
        'initialize column 
        initializeDgv()

    End Sub

    Private Sub initializeDgv()
        If ComboBox1.SelectedIndex = 0 Then
            dgvRinciLpp()
        ElseIf ComboBox1.SelectedIndex = 1 Then
            dgvRekapLpp()
        End If
    End Sub

    Private Sub dgvRekapLpp()
        DataGridView1.Columns(0).HeaderText = "Tanggal"
        DataGridView1.Columns(0).DefaultCellStyle.Format = "dd.MM.yyyy"

        DataGridView1.Columns(1).HeaderText = "Harga Air" & vbNewLine & "Abodemen"
        DataGridView1.Columns(1).DefaultCellStyle.Format = "N0"

        DataGridView1.Columns(2).HeaderText = "Listrik" & vbNewLine & "Materai"
        DataGridView1.Columns(2).DefaultCellStyle.Format = "N0"

        DataGridView1.Columns(3).HeaderText = "Denda" & vbNewLine & "B. Buka"
        DataGridView1.Columns(3).DefaultCellStyle.Format = "N0"

        DataGridView1.Columns(4).HeaderText = "Retribusi"
        DataGridView1.Columns(4).DefaultCellStyle.Format = "N0"

        DataGridView1.Columns(5).HeaderText = "Angsuran"
        DataGridView1.Columns(5).DefaultCellStyle.Format = "N0"

        DataGridView1.Columns(6).HeaderText = "Total Tagihan"
        DataGridView1.Columns(6).DefaultCellStyle.Format = "N0"

        DataGridView1.Columns(7).HeaderText = "Fee Admin"
        DataGridView1.Columns(7).DefaultCellStyle.Format = "N0"

        DataGridView1.Columns(8).HeaderText = "Sub Total"
        DataGridView1.Columns(8).DefaultCellStyle.Format = "N0"
        DataGridView1.Refresh()
        DataGridView1.RefreshEdit()
    End Sub

    Private Sub dgvRinciLpp()
        DataGridView1.Columns(0).HeaderText = "No Sambungan"
        DataGridView1.Columns(1).HeaderText = "Jml Rek"
        DataGridView1.Columns(2).HeaderText = "Tgl Bayar"
        DataGridView1.Columns(2).DefaultCellStyle.Format = "dd.MM.yyyy"
        DataGridView1.Columns(3).HeaderText = "Jam Bayar"
        DataGridView1.Columns(4).HeaderText = "Tagihan"
        DataGridView1.Columns(4).DefaultCellStyle.Format = "N0"
        DataGridView1.Columns(5).HeaderText = "Fee Admin"
        DataGridView1.Columns(5).DefaultCellStyle.Format = "N0"
        DataGridView1.Columns(6).HeaderText = "Sub Total"
        DataGridView1.Columns(6).DefaultCellStyle.Format = "N0"
        DataGridView1.Refresh()
        DataGridView1.RefreshEdit()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        dt.Rows.Clear()
        show = False
        txtJmlPendapatan.Text = 0
        txtJmlRek.Text = 0
        If Not ComboBox1.SelectedIndex = 0 And Not ComboBox1.SelectedIndex = 1 Then
            MsgBox("Anda belum piih jenis laporan", vbInformation, "Kasir Perumdam")
            show = False
            Exit Sub
        End If

        cmd.Connection = getDbConnection()
        cmd.Parameters.Clear()

        If ComboBox1.SelectedIndex = 0 Then
            'query for rinci
            cmd.CommandText = "select nosamw, count(nosamw) as jrek, tgl_byr, nodrda, " _
                            & "sum(dnmet)+sum(adm)+sum(ret)+sum(R1)+sum(R2)+sum(R3)+sum(R4)+sum(denda)+" _
                            & "sum(b_tutup)+sum(listrik)+sum(ang_sb)+sum(pajak)+sum(materai) as totag, sum(kjml_na) as tot_fee," _
                            & "sum(dnmet)+sum(adm)+sum(ret)+sum(R1)+sum(R2)+sum(R3)+sum(R4)+sum(denda)+" _
                            & "sum(b_tutup)+sum(listrik)+sum(ang_sb)+sum(pajak)+sum(materai)+sum(kjml_na) as total " _
                            & " from rekair where loket_byr=@loket and statrek='A' And (tgl_byr between @tgl1 and @tgl2)" _
                            & " group by nosamw, tgl_byr order by tgl_byr desc, nodrda asc"
            cmd.Parameters.AddWithValue("tgl1", DateTimePicker1.Text)
            cmd.Parameters.AddWithValue("tgl2", DateTimePicker2.Text)
            cmd.Parameters.AddWithValue("loket", getLoket)
        ElseIf ComboBox1.SelectedIndex = 1 Then
            ' Query for rekap data
            cmd.CommandText = "select tgl_byr, sum(R1)+sum(R2)+sum(R3)+sum(R4)+sum(adm) col1, " _
                            & "sum(listrik)+sum(materai) as col2, " _
                            & "sum(denda)+sum(b_tutup) as col3, sum(dnmet) as col4, sum(ang_sb) as col5, " _
                            & "sum(dnmet)+sum(adm)+sum(ret)+sum(R1)+sum(R2)+sum(R3)+sum(R4)+sum(denda)" _
                            & "+sum(b_tutup)+sum(listrik)+sum(ang_sb)+sum(pajak)+sum(materai) as col6, sum(kjml_na) as col7," _
                            & "sum(dnmet)+sum(adm)+sum(ret)+sum(R1)+sum(R2)+sum(R3)+sum(R4)+sum(denda)" _
                            & "+sum(b_tutup)+sum(listrik)+sum(ang_sb)+sum(pajak)+sum(materai)+sum(kjml_na) as col8, count(nosamw) as col9 " _
                            & "from rekair where loket_byr=@loket And (tgl_byr between @tgl1 and @tgl2) and statrek='A' group by tgl_byr"

            cmd.Parameters.AddWithValue("loket", getLoket)
            cmd.Parameters.AddWithValue("tgl1", DateTimePicker1.Text)
            cmd.Parameters.AddWithValue("tgl2", DateTimePicker2.Text)
        End If
        Dim frmWait As New frmWait
        frmWait.Show()
        Application.DoEvents()
        rd = cmd.ExecuteReader
        show = rd.HasRows

        While rd.Read
            If ComboBox1.SelectedIndex = 1 Then
                txtJmlPendapatan.Text = String.Format("{0:n0}", CDbl(txtJmlPendapatan.Text) + rd.GetDouble(8))
                txtJmlRek.Text = String.Format("{0:n0}", CDbl(txtJmlRek.Text) + rd.GetDouble(9))
            End If
            If ComboBox1.SelectedIndex = 0 Then
                txtJmlPendapatan.Text = String.Format("{0:n0}", CDbl(txtJmlPendapatan.Text) + rd.GetDouble("total"))
                txtJmlRek.Text = String.Format("{0:n0}", CDbl(txtJmlRek.Text) + rd.GetDouble(1))
            End If
        End While
        rd.Close()
        If show = True Then
            Console.WriteLine("SQL >>> " & cmd.CommandText)
            Console.WriteLine("Data Row Count >> " & DataGridView1.Rows.Count)

            If DataGridView1.Rows.Count > 0 Then
                DataGridView1.DataSource = Nothing
                DataGridView1.RefreshEdit()
                DataGridView1.Rows.Clear()
                DataGridView1.Columns.Clear()
                DataGridView1.Refresh()
            End If

            Dim da As New MySqlDataAdapter(cmd)
            da.Fill(dt)
            ShowDgv(dt)
        Else
            MsgBox("Tidak ada transaksi untuk tanggal  periode ini", vbInformation)
            show = False
        End If
        frmWait.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If dt.Rows.Count < 1 Then
            Me.Button1.PerformClick()
        End If
        If show = True Then
            With frmCetLpp
                .WindowState = FormWindowState.Maximized
                Console.WriteLine("Button2 Click event >> RowCount : " & DataGridView1.Rows.Count)
                .ReportViewer1.LocalReport.DataSources.Clear()
                .ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
                .ReportViewer1.ZoomPercent = 100
                If DataGridView1.Rows.Count > 0 Then
                    If ComboBox1.SelectedIndex = 0 Then
                        'LPP rincian per hari
                        .ReportViewer1.LocalReport.ReportEmbeddedResource = "KasirPerumdam.Report2.rdlc"
                        .ReportViewer1.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("dsLppRinci", dt))
                        .ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("paramTgl1", DateTimePicker1.Text))
                        .ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("paramTgl2", DateTimePicker2.Text))
                        .ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("paramUser", getNama.ToString))
                        '.ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("namaOperator", getNama.ToString))
                    Else
                        'LPP Rekap per bulan
                        .ReportViewer1.LocalReport.ReportEmbeddedResource = "KasirPerumdam.Report3.rdlc"
                        .ReportViewer1.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("dsRekapLpp", dt))
                        .ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("paramTgl1", DateTimePicker1.Text))
                        .ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("paramTgl2", DateTimePicker2.Text))
                        .ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("paramUser", getNama.ToString))
                    End If
                End If
                .ReportViewer1.Refresh()
            End With
            frmCetLpp.Show()
        End If
    End Sub

    Private Sub ComboBox1_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedValueChanged
        Dim ds As New DataSet1()
        If ComboBox1.SelectedIndex = 0 Then
            'lblPeriode.Text = "Tanggal"
            'DateTimePicker1.CustomFormat = "yyyy-MM-dd"
            'DateTimePicker1.Visible = True
            'DateTimePicker2.Visible = True
            'lblPeriode.Visible = True
            'Label6.Visible = True
            dt.Rows.Clear()
            dt = ds.Tables("tbRincianLpp")

        ElseIf ComboBox1.SelectedIndex = 1 Then
            'lblPeriode.Text = "Periode"
            'lblPeriode.Visible = True
            'DateTimePicker1.CustomFormat = "yyyyMM"
            'DateTimePicker1.Visible = True
            'DateTimePicker2.Visible = False
            'Label6.Visible = False
            dt.Rows.Clear()
            dt = ds.Tables("tbRekapLppHarian")
        End If
    End Sub
End Class