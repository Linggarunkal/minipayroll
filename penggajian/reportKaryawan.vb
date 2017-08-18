Imports MySql.Data.MySqlClient
Imports MySql.Data
Imports MySql.Data.MySqlClient.MySqlConnection
Public Class reportKaryawan
    Dim koneksi As MySqlConnection

    Private Sub reportKaryawan_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        koneksi = New MySqlConnection("server=localhost;uid=root;database=penggajian;")
        koneksi.Open()

        Call comboBulan()
        Me.ActiveControl = cmbMonth
        txtNim.Enabled = False
        txtNama.Enabled = False
        txtJabatan.Enabled = False
        txtGolongan.Enabled = False
        txtTotPotongan.Enabled = False
        txtTotTunjangan.Enabled = False
        txtGapok.Enabled = False
        txtGajiBersih.Enabled = False
        txtGajiKotor.Enabled = False


    End Sub

    Private Sub comboBulan()
        Dim sql As String

        Try
            sql = "select date_format(priodgajian, '%M %Y') as priodgajian from tb_gajian;"
            cd = New MySqlCommand(sql, koneksi)
            rd = cd.ExecuteReader

            Do While rd.Read
                cmbMonth.Items.Add(rd("priodgajian"))
            Loop

        Catch ex As Exception

        End Try
    End Sub

    Dim combo As String

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        combo = cmbMonth.SelectedItem

        txttest.Text = combo


    End Sub
End Class