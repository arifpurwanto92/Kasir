Imports MySql.Data.MySqlClient
Module dbHandler
    Private conn As MySqlConnection

    Public Sub openConnection()
        conn = New MySqlConnection("server=127.0.0.1; uid=root; database=simas; persistsecurityinfo=True;")
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
        Catch ex As Exception
            MsgBox("Tidak dapat menghubungkan ke database. (" & ex.ToString & ")", MsgBoxStyle.Critical)
        End Try
    End Sub

    Public Function getDbConnection()
        If conn.State = ConnectionState.Open Then
            Return conn
        Else
            openConnection()
            Return conn
        End If
    End Function

    Public Function closeConnection()
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
    End Function
End Module
