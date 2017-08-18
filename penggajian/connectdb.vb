Imports MySql.Data.MySqlClient
Module connectdb
    Public connect As MySqlConnection
    Public da As MySqlDataAdapter
    Public dr As DataTable
    Public ds As DataSet
    Public cd As MySqlCommand
    Public rd As MySqlDataReader

    Sub connection()
        Try
            connect = New MySqlConnection("server=localhost;uid=root;database=penggajian;")
            connect.Open()
            connect.Close()

        Catch ex As Exception
            MsgBox("Connection Failed" & ex.Message)
        End Try
    End Sub
End Module
