Imports System.Data.SqlClient
Public Class Search
    'Dim con As New SqlConnection("Data Source=INFRPC;Initial Catalog=ListNoireEntrepreneur;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False")
    Dim con As New SqlConnection("SERVER=10.30.0.156;DATABASE=ListNoireEntrepreneur;USER ID=AS;PASSWORD=a1c-2b3")
    Private Sub label1_Click(sender As Object, e As EventArgs) Handles label1.Click
        Dim log As New ShowPswd
        log.Show()
        Me.Hide()
    End Sub

    Private Sub pictureBox2_Click(sender As Object, e As EventArgs) Handles pictureBox2.Click
        Dim log As New ShowPswd
        log.Show()
        Me.Hide()
    End Sub

    Private Sub Label18_Click(sender As Object, e As EventArgs) Handles Label18.Click
        Application.Exit()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

        Try
            con.Open()
            Dim sql As String
            sql = ""
            If ChoixRecherch.SelectedItem.ToString = "الولاية" Then
                sql = "select * from ListNoirEntrep where Wilaya=N'" & SearchText.Text & "'"
            ElseIf ChoixRecherch.SelectedItem.ToString = "رقم الارسال" Then
                sql = "select * from ListNoirEntrep where Num_envoi=N'" & SearchText.Text & "'"
            ElseIf ChoixRecherch.SelectedItem.ToString = "اسم المؤسسة" Then
                sql = "select * from ListNoirEntrep where Nom like N'%" & SearchText.Text & "%' "
            ElseIf ChoixRecherch.SelectedItem.ToString = "اسم المسير" Then
                sql = "select * from ListNoirEntrep where Gerant=N'" & SearchText.Text & "'"
            End If
            Dim adapter As SqlDataAdapter
            adapter = New SqlDataAdapter(sql, con)
            Dim builder As SqlCommandBuilder
            builder = New SqlCommandBuilder(adapter)
            Dim ds As DataSet
            ds = New DataSet
            adapter.Fill(ds)
            DataGridViewSearchTBL.DataSource = ds.Tables(0)
            'LNTbl.DataSource = ds.Tables(0)
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        
    End Sub


    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ChoixRecherch.SelectedIndexChanged

    End Sub

    Private Sub Search_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NameUser.Text = ShowPswd.User.ToString
    End Sub

    Private Sub HomeBtn_Click(sender As Object, e As EventArgs) Handles HomeBtn.Click
        Me.Hide()
        Dim Home = New MainForm
        Home.Show()
    End Sub

    Private Sub DataGridViewSearchTBL_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewSearchTBL.CellContentClick

    End Sub
End Class