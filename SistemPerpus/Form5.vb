Imports MySql.Data.MySqlClient

Public Class Form5
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

    Sub Tampil()
        sqlDataAdapter.SelectCommand = Command
        dt.Clear()
        sqlDataAdapter.Fill(dt)
        bSource.DataSource = dt

        DataGridView1.DataSource = bSource


        sqlDataAdapter.Update(dt)
    End Sub
    Sub Tampil_Update()
        sqlDataAdapter.SelectCommand = Command2
        dt.Clear()
        sqlDataAdapter.Fill(dt)
        bSource.DataSource = dt

        DataGridView1.DataSource = bSource


        sqlDataAdapter.Update(dt)
    End Sub

    Private Sub BunifuButton1_Click(sender As Object, e As EventArgs) Handles BunifuButton4.Click

        Koneksi()

        Try
            MysqlConn.Open()

            Query = "select * from petugas where id_petugas ='" & tb_search.DefaultText & "' or nama ='" & tb_search.DefaultText & "' or email ='" & tb_search.DefaultText & "' or level ='" & tb_search.DefaultText & "'   "
            Command = New MySqlCommand(Query, MysqlConn)
            Tampil()

            MysqlConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        Hide()
        Form4.Show()

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Application.Exit()
    End Sub

    Private Sub BunifuButton3_Click(sender As Object, e As EventArgs) Handles BunifuButton3.Click

        Koneksi()

        Try
            MysqlConn.Open()

            Query = "select * from petugas"
            Command = New MySqlCommand(Query, MysqlConn)
            Tampil()

            MysqlConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub DataGridView1_RowHeaderMouseClick(ByVal sender As Object, ByVal e As DataGridViewCellMouseEventArgs) Handles DataGridView1.RowHeaderMouseClick
        Try
            tb_id.Text = DataGridView1.SelectedCells(0).Value
            tb_nama.Text = DataGridView1.SelectedCells(1).Value
            tb_email.Text = DataGridView1.SelectedCells(2).Value
            tb_password.Text = DataGridView1.SelectedCells(3).Value
            tb_level.Text = DataGridView1.SelectedCells(4).Value
            bt_hapus.Visible = True
        Catch
            MessageBox.Show("Select Row With Value", "Attention")
        End Try
    End Sub

    Private Sub PanelRight_Paint(sender As Object, e As PaintEventArgs) Handles PanelRight.Paint

    End Sub

    Private Sub PanelLeft_Paint(sender As Object, e As PaintEventArgs) Handles PanelLeft.Paint

    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs)
        bt_hapus.Visible = False

    End Sub

    Private Sub BunifuButton2_Click(sender As Object, e As EventArgs) Handles BunifuButton2.Click
        Koneksi()

        Try
            MysqlConn.Open()


            Query = "UPDATE petugas SET id_petugas = '" & tb_id.Text & "',nama = '" & tb_nama.Text & "',email = '" & tb_email.Text & "',password = '" & tb_password.Text & "',level = '" & tb_level.Text & "' where id_petugas ='" & tb_id.Text & "'  "
            Selected = "select * from petugas"

            Command = New MySqlCommand(Query, MysqlConn)
            Command.ExecuteNonQuery()

            MessageBox.Show("Update Data Success!", "Success")
                Command2 = New MySqlCommand(Selected, MysqlConn)


            Tampil_Update()



            MysqlConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub bt_hapus_Click(sender As Object, e As EventArgs) Handles bt_hapus.Click
        Koneksi()

        Try
            MysqlConn.Open()
            Query = "DELETE from petugas where id_petugas ='" & tb_id.Text & "' "
            Selected = "select * from petugas"
            Command = New MySqlCommand(Query, MysqlConn)
            Command.ExecuteNonQuery()
            MessageBox.Show("Delete Data Success!", "Success")
            Command2 = New MySqlCommand(Selected, MysqlConn)

            Tampil_Update()
            MysqlConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub add_admin_Click(sender As Object, e As EventArgs) Handles add_admin.Click
        Form3.Show()
        Hide()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

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