Imports MySql.Data.MySqlClient
Public Class LoginForm1
    Dim conn As MySqlConnection
    Private Function hashString(ByVal str As String)
        Dim cArr() As Char
        Dim tHexStr As String = ""
        Dim fHexStr As String
        Dim hexStr As String
        cArr = str.ToCharArray
        For Each s As Char In cArr
            tHexStr = tHexStr & ChrW(Convert.ToInt32(s) + 72)
        Next
        Return tHexStr
    End Function
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim cmd As New MySqlCommand
        Dim rd As MySqlDataReader
        Dim regDate As Date = Date.Now()
        Dim curdate As String = regDate.ToString("yyyy-MM-dd")
        Dim nama, opr, loket As String
        Dim cet As Integer
        Dim succ As Boolean
        Console.WriteLine("Currdate : " & curdate)
        cmd.Connection = conn
        cmd.CommandText = "select * from user where opr=@user and password=@pass"
        cmd.Parameters.AddWithValue("user", UsernameTextBox.Text)
        cmd.Parameters.AddWithValue("pass", hashString(PasswordTextBox.Text))
        rd = cmd.ExecuteReader
        If rd.HasRows Then
            'save data to modul 
            rd.Read()
            nama = rd.GetString("nama")
            opr = rd.GetString("opr")
            loket = rd.GetString("loket")
            succ = True
            'frmMain.Show()
            'Me.Hide()
        Else
            MsgBox("Tidak dapat login. Mohon periksa kembali username dan password Anda")
            UsernameTextBox.Text = ""
            PasswordTextBox.Text = ""
            UsernameTextBox.Select()
            succ = False
        End If
        rd.Close()
        cmd.Parameters.Clear()

        If succ = True Then
            openConnection()
            cmd.Connection = getDbConnection()
            cmd.Parameters.Clear()
            cmd.CommandText = "select count(*) as n from rekair where tgl_byr='" & curdate & "' and loket_byr=@loket"
            cmd.Parameters.AddWithValue("loket", loket)
            rd = cmd.ExecuteReader
            rd.Read()
            cet = rd.GetInt32(0)
            'sLoginInfo(nama, opr, loket, rd.GetInt32(0))
            rd.Close()
            cmd.Parameters.Clear()

            cmd.CommandText = "select * from mloket where loket='" & loket & "'"
            rd = cmd.ExecuteReader
            rd.Read()
            rd.GetString(1)
            sLoginInfo(nama, opr, loket, rd.GetString(1), cet)
            frmMain.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub LoginForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'conn = New MySqlConnection("server=10.200.200.3; port=3307; uid=rekening; pwd=iwanys; database=aamaster; persistsecurityinfo=True;")
        conn = New MySqlConnection("server=" + getHost() + "; port=" + getPort() + "; uid=" + getUid() + "; pwd=" + getPass() + "; 
                                    database=aamaster; persistsecurityinfo=True;")
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
        Catch ex As Exception
            MsgBox("Tidak dapat menghubungkan ke database!!!!", MsgBoxStyle.Critical)
        End Try
        UsernameTextBox.Select()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmSetting.ShowDialog()
    End Sub
End Class
