Imports MySql.Data.MySqlClient
Public Class Form7
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

    Private Sub add_admin_Click(sender As Object, e As EventArgs) Handles add_admin.Click
        Koneksi()

        Try
            MysqlConn.Open()


            Query = "insert into anggota(nama, tahun_ajaran, jurusan, status) values ('" & tb_nama.Text & "' , '" & cb_tahun_ajaran.Text & "' , '" & cb_jurusan.Text & "' , '" & cb_status.Text & "')"

            Command = New MySqlCommand(Query, MysqlConn)
            Command.ExecuteNonQuery()
            MessageBox.Show("Insert Data Success!", "Success")
            tb_nama.ResetText()

            MysqlConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        Form6.Show()
        Hide()
    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        Form5.Show()
        Hide()
    End Sub


    Private Sub BunifuThinButton23_Click(sender As Object, e As EventArgs) Handles BunifuThinButton23.Click
        Form8.Show()
        Hide()

    End Sub


    Private Sub BunifuThinButton24_Click(sender As Object, e As EventArgs) Handles BunifuThinButton24.Click
        Form10.Show()
        Hide()

    End Sub


    Private Sub BunifuThinButton25_Click(sender As Object, e As EventArgs) Handles BunifuThinButton25.Click
        Form12.Show()
        Hide()

    End Sub
End Class