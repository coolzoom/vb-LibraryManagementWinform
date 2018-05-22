Imports MySql.Data.MySqlClient

Public Class Form11
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

            Dim Tanggal As String = Format(Now, "yyyy-MM-dd")
            Query = "insert into peminjaman(id_buku, id_petugas, id_anggota, tgl_pinjam) values ('" & tb_id_buku.Text & "' , '" & tb_id_petugas.Text & "' , '" & tb_id_anggota.Text & "' , '" & Tanggal & "')"

            Command = New MySqlCommand(Query, MysqlConn)
            Command.ExecuteNonQuery()
            MessageBox.Show("Insert Data Success!", "Success")
            tb_id_buku.ResetText()
            tb_id_anggota.ResetText()
            tb_id_petugas.ResetText()

            MysqlConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        Form10.Show()
        Hide()

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Application.Exit()

    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        Form5.Show()
        Hide()
    End Sub

    Private Sub BunifuThinButton22_Click(sender As Object, e As EventArgs) Handles BunifuThinButton22.Click
        Form6.Show()
        Hide()

    End Sub

    Private Sub BunifuThinButton23_Click(sender As Object, e As EventArgs) Handles BunifuThinButton23.Click
        Form8.Show()
        Hide()

    End Sub

    Private Sub PanelRight_Paint(sender As Object, e As PaintEventArgs) Handles PanelRight.Paint

    End Sub


    Private Sub BunifuThinButton25_Click(sender As Object, e As EventArgs) Handles BunifuThinButton25.Click
        Form12.Show()
        Hide()

    End Sub
End Class