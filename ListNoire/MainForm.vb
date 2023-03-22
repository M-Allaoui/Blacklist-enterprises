Public Class MainForm

    Private Sub pictureBox4_Click(sender As Object, e As EventArgs) Handles pictureBox4.Click
        Me.Hide()
        Dim LNE = New LNEntrep
        LNE.Show()


    End Sub

    Private Sub label3_Click(sender As Object, e As EventArgs) Handles label3.Click
        Me.Hide()
        Dim LNE = New LNEntrep
        LNE.Show()
    End Sub

    Private Sub pictureBox3_Click(sender As Object, e As EventArgs) Handles pictureBox3.Click
        Me.Hide()
        Dim search = New Search
        search.Show()
    End Sub

    Private Sub label4_Click(sender As Object, e As EventArgs) Handles label4.Click
        Me.Hide()
        Dim search = New Search
        search.Show()
    End Sub

    Private Sub Label18_Click(sender As Object, e As EventArgs) Handles Label18.Click
        Application.Exit()
    End Sub

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

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NameUser.Text = ShowPswd.User.ToString
    End Sub
End Class