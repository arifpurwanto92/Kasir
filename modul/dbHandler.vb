Imports MySql.Data.MySqlClient
Module dbHandler
    Private conn As MySqlConnection
    Private host As String = My.Settings.host
    Private port As String = My.Settings.port
    Private user As String = My.Settings.user
    Private pass As String = My.Settings.pass
    Private dbase As String = My.Settings.dbase

    Public Sub openConnection()
        'conn = New MySqlConnection("server=10.200.200.3; port=3307; uid=rekening; pwd=iwanys; database=billing; persistsecurityinfo=True;")
        conn = New MySqlConnection("server=" + host + "; port=" + port + "; uid=" + user + "; pwd=" + pass + "; 
                                    database=" + dbase + "; persistsecurityinfo=True;")
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
        Catch ex As Exception
            MsgBox("Tidak dapat menghubungkan ke database. (" & ex.ToString & ")", MsgBoxStyle.Critical)
            frmSetting.ShowDialog()
        End Try
    End Sub

    Public Function getDbConnection()
        Try
            If conn.State = ConnectionState.Open Then
                Return conn
            Else
                openConnection()
                Return conn
            End If
        Catch ex As Exception
            openConnection()
        End Try
    End Function

    Public Function closeConnection()
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
    End Function

    Public Function getHost()
        Return host
    End Function
    Public Function getUid()
        Return user
    End Function
    Public Function getPass()
        Return pass
    End Function
    Public Function getPort()
        Return port
    End Function
    Public Function getDb()
        Return dbase
    End Function
End Module
