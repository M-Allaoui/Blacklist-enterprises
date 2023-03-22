Imports System.Data.SqlClient

Public Class GestionUser
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
    Private Sub Populate()
        Try
            con.Open()
            Dim sql = "select * from Utilisateur"
            Dim adapter As SqlDataAdapter
            adapter = New SqlDataAdapter(sql, con)
            Dim builder As SqlCommandBuilder
            builder = New SqlCommandBuilder(adapter)
            Dim ds As DataSet
            ds = New DataSet
            adapter.Fill(ds)
            LNTbl.DataSource = ds.Tables(0)
            con.Close()
            NameUser.Text = ShowPswd.User.ToString
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Dim key = 0
    Private Sub LNTbl_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles LNTbl.CellMouseClick
        Dim row As DataGridViewRow = LNTbl.Rows(e.RowIndex)
        key = Convert.ToInt32(row.Cells(3).Value.ToString)
        'key = row.Cells(0).Value.ToString
        KeyID.Text = row.Cells(3).Value.ToString
        UserID.Text = row.Cells(0).Value.ToString
        MotPss.Text = row.Cells(1).Value.ToString
        Previlege.SelectedItem = row.Cells(2).Value
    End Sub
    Private Sub Clear()
        UserID.Text = ""
        MotPss.Text = ""
        Previlege.SelectedItem = ""
        key = ""

    End Sub

    Private Sub GestionUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Populate()
        NameUser.Text = ShowPswd.User.ToString
    End Sub

    Private Sub AddBtn_Click(sender As Object, e As EventArgs) Handles AddBtn.Click
        Try
            con.Open()
            Dim Query As String
            Query = "insert into Utilisateur values(N'" & UserID.Text & "', N'" & MotPss.Text & "', N'" & Previlege.SelectedItem.ToString & "','" & KeyID.Text & "')"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(Query, con)
            cmd.ExecuteNonQuery()
            MsgBox("Nouvel utilisateur est ajouté avec succès")
            con.Close()
            Populate()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        
    End Sub

    Private Sub EditBtn_Click(sender As Object, e As EventArgs) Handles EditBtn.Click
        If UserID.Text = "" Or MotPss.Text = "" Or Previlege.SelectedItem.ToString = "" Then
            MsgBox("Des informations manquante")
        Else
            Try
                con.Open()
                Dim Query As String
                Query = "update Utilisateur set UserId=N'" & UserID.Text & "', Password=N'" & MotPss.Text & "' ,privilage=N'" & Previlege.SelectedItem.ToString & "',KeyID='" & KeyID.Text & "' where KeyID='" & key & "'"
                Dim cmd As SqlCommand
                cmd = New SqlCommand(Query, con)
                cmd.ExecuteNonQuery()
                MsgBox("L'utilisateur est edité avec succès")
                con.Close()
                Populate()
                Clear()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            

        End If
    End Sub

    Private Sub DeletBtn_Click(sender As Object, e As EventArgs) Handles DeletBtn.Click
        If key = 0 Then
            MsgBox("Sélectionnez l'utilisateur que vous souhaitez supprimer")
        Else
            Try
                con.Open()
                Dim Query As String
                Query = "delete from Utilisateur where KeyID=" & key & ""
                Dim cmd As SqlCommand
                cmd = New SqlCommand(Query, con)
                cmd.ExecuteNonQuery()
                MsgBox("L'Utilisateur est supprimé avec succès")
                con.Close()
                Populate()
                Clear()


            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Application.Exit()
    End Sub

    Private Sub HomeBtn_Click(sender As Object, e As EventArgs) Handles HomeBtn.Click
        Me.Hide()
        Dim Home = New MainForm
        Home.Show()
    End Sub

    Private Sub LNTbl_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles LNTbl.CellContentClick

    End Sub
End Class