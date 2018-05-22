Imports MySql.Data.MySqlClient
Public Class Form3
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

    Private Sub PanelRight_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub

    Private Sub BunifuFlatButton1_Click_1(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        Form5.Show()
        Hide()
    End Sub

    Private Sub add_admin_Click(sender As Object, e As EventArgs) Handles add_admin.Click
        Koneksi()

        Try
            MysqlConn.Open()


            Query = "insert into petugas(Nama, Email, Password, Level) values ('" & tb_nama.Text & "' , '" & tb_email.Text & "' , '" & tb_password.Text & "' , '" & cb_level.Text & "')"

            Command = New MySqlCommand(Query, MysqlConn)
            Command.ExecuteNonQuery()
            MessageBox.Show("Insert Data Success!", "Success")
            tb_nama.ResetText()
            tb_email.ResetText()
            tb_password.ResetText()
            MysqlConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub BunifuThinButton22_Click(sender As Object, e As EventArgs) Handles BunifuThinButton22.Click
        Form6.Show()
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