Imports MySql.Data.MySqlClient

Public Class Form13
    Dim MysqlConn As MySqlConnection
    Dim Command As MySqlCommand
    Dim Command2 As MySqlCommand
    Dim Reader As MySqlDataReader
    Dim sqlDataAdapter As New MySqlDataAdapter
    Dim dt As New DataTable
    Dim bSource As New BindingSource
    Dim Query As String
    Dim Selected As String

    Sub Koneksi()
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost; userid=root; password=; database=simp"
    End Sub
    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        Form12.Show()
        Hide()

    End Sub

    Private Sub add_admin_Click(sender As Object, e As EventArgs) Handles add_admin.Click
        Koneksi()

        Try
            MysqlConn.Open()

            Dim Tanggal As String = Format(Now, "yyyy-MM-dd")
            Query = "insert into pengembalian(id_pinjam, tgl_kembali,denda) values ('" & tb_id_pinjam.Text & "' , '" & tb_tgl_kembali.Text & "' , '" & tb_denda.Text & "' )"

            Command = New MySqlCommand(Query, MysqlConn)
            Command.ExecuteNonQuery()
            MessageBox.Show("Insert Data Success!", "Success")
            tb_id_pinjam.ResetText()
            MysqlConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Application.Exit()
    End Sub
End Class