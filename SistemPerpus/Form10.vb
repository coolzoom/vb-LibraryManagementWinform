Imports MySql.Data.MySqlClient
Public Class Form10
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

            Query = "select * from peminjaman"
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

            Query = "select * from anggota where id_peminjaman ='" & tb_search.DefaultText & "' or id_buku ='" & tb_search.DefaultText & "' or id_petugas ='" & tb_search.DefaultText & "' or id_anggota ='" & tb_search.DefaultText & "'  "
            Command = New MySqlCommand(Query, MysqlConn)
            Tampil()

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
            If (tb_id_anggota.Text = "") Then
                MessageBox.Show("Select Row First!", "Attention")
            Else

                Query = "UPDATE peminjaman SET id_peminjaman = '" & tb_id_peminjaman.Text & "',id_buku = '" & tb_id_buku.Text & "',id_petugas = '" & tb_petugas.Text & "',id_anggota = '" & tb_id_anggota.Text & "',tgl_pinjam = '" & tb_status.Text & "' where id_peminjaman ='" & tb_id_peminjaman.Text & "'  "
                Selected = "select * from peminjaman"

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

    Private Sub bt_hapus_Click(sender As Object, e As EventArgs) Handles bt_hapus.Click
        Koneksi()

        Try
            MysqlConn.Open()
            Query = "DELETE from peminjaman where id_peminjaman ='" & tb_id_peminjaman.Text & "' "
            Selected = "select * from peminjaman"
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

    Private Sub DataGridView1_RowHeaderMouseClick(ByVal sender As Object, ByVal e As DataGridViewCellMouseEventArgs) Handles DataGridView1.RowHeaderMouseClick
        Try
            tb_id_peminjaman.Text = DataGridView1.SelectedCells(0).Value
            tb_id_buku.Text = DataGridView1.SelectedCells(1).Value
            tb_petugas.Text = DataGridView1.SelectedCells(2).Value
            tb_id_anggota.Text = DataGridView1.SelectedCells(3).Value
            tb_status.Text = DataGridView1.SelectedCells(4).Value


            bt_hapus.Visible = True
        Catch
            MessageBox.Show("Select Row With Value", "Attention")
        End Try
    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        Form4.Show()
        Hide()
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

    Private Sub add_member_Click(sender As Object, e As EventArgs) Handles add_member.Click
        Form11.Show()
        Hide()

    End Sub

    Private Sub BunifuThinButton25_Click(sender As Object, e As EventArgs) Handles BunifuThinButton25.Click
        Form12.Show()
        Hide()

    End Sub
End Class