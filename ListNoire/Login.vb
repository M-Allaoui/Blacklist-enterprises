Imports System.Data.SqlClient
Public Class ShowPswd
    Public Shared User As String
    'Dim con As New SqlConnection("Data Source=INFRPC;Initial Catalog=ListNoireEntrepreneur;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False")
    Dim con As New SqlConnection("SERVER=10.30.0.156;DATABASE=ListNoireEntrepreneur;USER ID=AS;PASSWORD=a1c-2b3")
    Private Sub ResetBtn(sender As Object, e As EventArgs) Handles button2.Click
        UserID.Clear()
        pswd.Clear()
    End Sub
    Dim key = 0
    Private Sub LoginBtn(sender As Object, e As EventArgs) Handles button1.Click
        Try
            If UserID.Text = "" Or pswd.Text = "" Then
                MsgBox("Le champ nom d'utilisateur ou mot de passe est vide")
            Else

                con.Open()
                Dim Query As String

                Query = "select * from Utilisateur where UserId=N'" & UserID.Text & "' and Password=N'" & pswd.Text & "'"
                Dim cmd As SqlCommand
                cmd = New SqlCommand(Query, con)

                Dim adapter As SqlDataAdapter
                adapter = New SqlDataAdapter(Query, con)
                Dim dt As DataTable
                dt = New DataTable
                adapter.Fill(dt)
                If dt.Rows.Count > 0 Then
                    Using reader As SqlDataReader = cmd.ExecuteReader
                        While reader.Read
                            User = reader("UserId").ToString
                            If Convert.ToInt32(reader("privilage").ToString) = 1 Then
                                Me.Hide()
                                Dim LNEANEP = New LNEntrepANEP
                                LNEANEP.Show()
                            ElseIf Convert.ToInt32(reader("privilage").ToString) = 2 Then
                                Me.Hide()
                                Dim Main = New MainForm
                                Main.Show()
                            ElseIf Convert.ToInt32(reader("privilage").ToString) = 3 Then
                                Me.Hide()
                                Dim GestUser = New GestionUser
                                GestUser.Show()


                            End If

                        End While
                    End Using


                Else
                    MsgBox("l'utilisateur n'exist pas")
                End If
            End If
            con.Close()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub label4_Click(sender As Object, e As EventArgs) Handles label4.Click
        Application.Exit()

    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pswd.UseSystemPasswordChar = True

    End Sub

    Private Sub pictureBox2_Click(sender As Object, e As EventArgs)

    End Sub
End Class