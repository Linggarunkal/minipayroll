Imports MySql.Data.MySqlClient
Imports MySql.Data
Imports MySql.Data.MySqlClient.MySqlConnection

Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Call connection()

        connect.Open()
        cd = New MySqlCommand("select * from testing where username = '" + txtuser.Text + "' and password = '" + txtpass.Text + "'", connect)
        rd = cd.ExecuteReader
        rd.Read()

        If rd.HasRows Then
            MsgBox("Login Successfull", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
            menuKaryawan.Show()
            Me.Hide()
        Else
            rd.Close()
            MsgBox("Username or Password Wrong", MsgBoxStyle.Critical)
            txtuser.Focus()

        End If


    End Sub

    Private Sub txtuser_TextChanged(sender As Object, e As EventArgs) Handles txtuser.TextChanged

    End Sub
End Class
