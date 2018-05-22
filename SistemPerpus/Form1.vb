Imports MySql.Data.MySqlClient

Public Class Form1
    Dim MysqlConn As MySqlConnection
    Dim Command As MySqlCommand
    Dim Reader As MySqlDataReader

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Me.Close()
        Form2.Close()
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("http://yogichandra.me")
    End Sub

    Private Sub Cek_Koneksi_Click(sender As Object, e As EventArgs) Handles Cek_Koneksi.Click


        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost; userid=root; password=; database=simp"
        Try
            MysqlConn.Open()
            MessageBox.Show("Connection Succesfull", "Connection to Database")
            MysqlConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub BunifuButton1_Click(sender As Object, e As EventArgs) Handles BunifuButton1.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost; userid=root; password=; database=simp"


        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "select * from petugas where email = '" & Email.DefaultText & "'and password = '" & Password.DefaultText & "' "
            Command = New MySqlCommand(Query, MysqlConn)
            Reader = Command.ExecuteReader
            Dim Count As Integer
            Dim Status As String
            Count = 0
            Status = ""
            Name = ""
            While Reader.Read
                Count += 1
                Status = Reader.GetString("level")
                Name = Reader.GetString("Nama")
            End While

            If Count = 1 And Status = "super_admin" Then
                Form4.admin_name.Text = Name
                Form4.Show()
                Me.Hide()
            ElseIf Count = 1 And Status = "admin" Then
                Form4.admin_name.Text = Name
                Form4.BunifuThinButton21.Visible = False
                Form6.BunifuThinButton21.Visible = False
                Form3.BunifuThinButton21.Visible = False
                Form5.BunifuThinButton21.Visible = False
                Form6.BunifuThinButton21.Visible = False
                Form7.BunifuThinButton21.Visible = False
                Form8.BunifuThinButton21.Visible = False
                Form9.BunifuThinButton21.Visible = False
                Form10.BunifuThinButton21.Visible = False
                Form11.BunifuThinButton21.Visible = False
                Form12.BunifuThinButton21.Visible = False
                Form13.BunifuThinButton21.Visible = False
                Form4.Show()
                Me.Hide()
            Else
                MessageBox.Show("Incorrect Email or Password", "Error")
            End If

            MysqlConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub Password_TextChange(sender As Object, e As EventArgs) Handles Password.TextChange

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub PanelLeft_Paint(sender As Object, e As PaintEventArgs) Handles PanelLeft.Paint

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

    End Sub

    Private Sub BunifuCustomLabel2_Click(sender As Object, e As EventArgs) Handles BunifuCustomLabel2.Click

    End Sub

    Private Sub BunifuCustomLabel1_Click(sender As Object, e As EventArgs) Handles BunifuCustomLabel1.Click

    End Sub

    Private Sub BunifuSeparator1_Load(sender As Object, e As EventArgs) Handles BunifuSeparator1.Load

    End Sub

    Private Sub PanelRight_Paint(sender As Object, e As PaintEventArgs) Handles PanelRight.Paint

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Email_TextChange(sender As Object, e As EventArgs) Handles Email.TextChange

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class
