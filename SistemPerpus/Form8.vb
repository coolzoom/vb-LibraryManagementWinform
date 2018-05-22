Imports MySql.Data.MySqlClient
Public Class Form8
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
    Private Sub BunifuButton3_Click(sender As Object, e As EventArgs) Handles BunifuButton3.Click

        Koneksi()

        Try
            MysqlConn.Open()

            Query = "select * from buku"
            Command = New MySqlCommand(Query, MysqlConn)
            Tampil()

            MysqlConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub BunifuButton4_Click(sender As Object, e As EventArgs) Handles BunifuButton4.Click
        Koneksi()

        Try
            MysqlConn.Open()

            Query = "select * from buku where id_buku ='" & tb_search.DefaultText & "' "
            Command = New MySqlCommand(Query, MysqlConn)
            Tampil()

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
            Query = "DELETE from buku where id_buku ='" & tb_id_buku.Text & "' "
            Selected = "select * from buku"
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

    Private Sub BunifuButton2_Click(sender As Object, e As EventArgs) Handles BunifuButton2.Click
        Koneksi()

        Try
            MysqlConn.Open()
            If (tb_id_buku.Text = "") Then
                MessageBox.Show("Select Row First!", "Attention")
            Else

                Query = "UPDATE buku SET id_buku = '" & tb_id_buku.Text & "',isbn = '" & tb_isbn.Text & "',judul_buku = '" & tb_judul.Text & "',pengarang = '" & tb_pengarang.Text & "',penerbit = '" & tb_penerbit.Text & "',tahun_terbit = '" & tb_tahun_terbit.Text & "',jumlah_halaman = '" & tb_halaman.Text & "' where id_buku ='" & tb_id_buku.Text & "'  "
                Selected = "select * from buku"

                Command = New MySqlCommand(Query, MysqlConn)
                Command.ExecuteNonQuery()

                MessageBox.Show("Update Data Success!", "Success")
                Command2 = New MySqlCommand(Selected, MysqlConn)


                Tampil_Update()

            End If




            MysqlConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub DataGridView1_RowHeaderMouseClick(ByVal sender As Object, ByVal e As DataGridViewCellMouseEventArgs) Handles DataGridView1.RowHeaderMouseClick
        Try
            tb_id_buku.Text = DataGridView1.SelectedCells(0).Value
            tb_judul.Text = DataGridView1.SelectedCells(2).Value
            tb_isbn.Text = DataGridView1.SelectedCells(1).Value
            tb_pengarang.Text = DataGridView1.SelectedCells(3).Value
            tb_penerbit.Text = DataGridView1.SelectedCells(4).Value
            tb_tahun_terbit.Text = DataGridView1.SelectedCells(5).Value
            tb_halaman.Text = DataGridView1.SelectedCells(6).Value
            bt_hapus.Visible = True
        Catch
            MessageBox.Show("Select Row With Value", "Attention")
        End Try
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Application.Exit()
    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        Form4.Show()
        Hide()
    End Sub

    Private Sub add_member_Click(sender As Object, e As EventArgs) Handles add_member.Click
        Form9.Show()
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