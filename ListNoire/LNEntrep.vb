'Option Strict On
'Option Explicit On

Imports System.Data.SqlClient
Imports System.Drawing.Printing

Public Class LNEntrep
    Dim MyDataGridViewPrinter As DataGridViewPrinter
    'Dim con As New SqlConnection("Data Source=INFRPC;Initial Catalog=ListNoireEntrepreneur;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False")
    Dim con As New SqlConnection("SERVER=10.30.0.156;DATABASE=ListNoireEntrepreneur;USER ID=AS;PASSWORD=a1c-2b3")
    Private Sub LNEntrep_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Populate()

    End Sub
    Private Sub Populate()
        'Try
        con.Open()
        Dim sql = "select * from ListNoirEntrep"
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(sql, con)
        Dim builder As SqlCommandBuilder
        builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        DataGridViewTBL.DataSource = ds.Tables(0)
        con.Close()
        NameUser.Text = ShowPswd.User.ToString
        'Catch ex As Exception
        'MsgBox(ex.Message)
        'End Try


    End Sub

    Private Sub AddBtn_Click(sender As Object, e As EventArgs) Handles AddBtn.Click
        Try
            con.Open()
            Dim Query As String
            Dim NewC As String
            If IsNothing(NewClass.SelectedItem) Then
                NewC = ""
            Else
                NewC = NewClass.SelectedItem.ToString
            End If

            Dim NewType As String
            If IsNothing(Type.SelectedItem) Then
                NewType = ""
            Else
                NewType = Type.SelectedItem.ToString
            End If

            Dim NewSujet As String
            If IsNothing(Sujet.SelectedItem) Then
                NewSujet = ""
            Else
                NewSujet = Sujet.SelectedItem.ToString
            End If

            If NomEntrep.Text = "" Then
                MsgBox("من فضلك ادخل اسم المؤسسة")
                con.Close()
            Else
                Query = "insert into ListNoirEntrep values(N'" & Wilaya.Text & "', N'" & NumEnvoi.Text & "','" & DateEnvoi.Text & "', N'" & AdminConcernee.Text & "',N'" & NewType & "', N'" & NomEntrep.Text & "',N'" & Gerant.Text & "', N'" & NewSujet & "','" & DateEvenemet.Text & "', N'" & MotifExclu.Text & "',N'" & PeroidExclu.Text & "', N'" & NewC & "', N'" & NewNumCertf.Text & "', N'" & RefExclu.Text & "','" & DateReconsid.Text & "',(select ISNULL(MAX(EntrepID)+1,1) from ListNoirEntrep));"
                Dim cmd As SqlCommand
                cmd = New SqlCommand(Query, con)
                cmd.ExecuteNonQuery()
                Dim Query1 As String
                Dim trans As String
                trans = "Ajouter nouvel enregistrement"
                Query1 = "insert into Transactions values( N'" & ShowPswd.User & "','" & DateTime.Now & "', N'" & trans & "' ,(select ISNULL(MAX(KeyID)+1,1) from Transactions), (select EntrepID from ListNoirEntrep where Num_envoi='" & NumEnvoi.Text & "' and Nom='" & NomEntrep.Text & "' and Gerant='" & Gerant.Text & "'));"
                Dim cmd1 As SqlCommand
                cmd1 = New SqlCommand(Query1, con)
                cmd1.ExecuteNonQuery()
                MsgBox("Nouvel enregistrement ajouté avec succès")
                con.Close()
                Populate()
            End If
            
        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()
        End Try

    End Sub
    Dim key = 0
    Private Sub Clear()
        Wilaya.Text = ""
        NumEnvoi.Text = ""
        DateEnvoi.Text = ""
        AdminConcernee.Text = ""
        Type.SelectedItem = ""
        NomEntrep.Text = ""
        Gerant.Text = ""
        Sujet.SelectedItem = ""
        DateEvenemet.Text = ""
        MotifExclu.Text = ""
        PeroidExclu.Text = ""
        NewClass.SelectedItem = ""
        NewNumCertf.Text = ""
        RefExclu.Text = ""
        DateReconsid.Text = ""
    End Sub
    Private Sub DeletBtn_Click(sender As Object, e As EventArgs) Handles DeletBtn.Click
        If key = 0 Then
            MsgBox("Sélectionnez l'enregistrement que vous souhaitez supprimer")
        Else
            Try
                con.Open()
                Dim Query As String
                Query = "delete from ListNoirEntrep where EntrepID=" & key & ""
                Dim cmd As SqlCommand
                cmd = New SqlCommand(Query, con)
                cmd.ExecuteNonQuery()
                Dim Query1 As String
                Dim trans As String
                trans = "Supprimer un enregistrement"
                Query1 = "insert into Transactions values( N'" & ShowPswd.User & "','" & DateTime.Now & "', N'" & trans & "',(select ISNULL(MAX(KeyID)+1,1) from Transactions), N'" & key & "');"
                Dim cmd1 As SqlCommand
                cmd1 = New SqlCommand(Query1, con)
                cmd1.ExecuteNonQuery()
                MsgBox("L'enregistrement est supprimé avec succès")
                con.Close()
                Populate()
                Clear()


            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

    End Sub


    Private Sub LNTbl_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridViewTBL.CellMouseClick
        Dim row As DataGridViewRow = DataGridViewTBL.Rows(e.RowIndex)
        'LNTbl.Rows(e.RowIndex)
        key = Convert.ToInt32(row.Cells(15).Value.ToString)
        Wilaya.Text = row.Cells(0).Value.ToString
        NumEnvoi.Text = row.Cells(1).Value.ToString
        DateEnvoi.Text = row.Cells(2).Value.ToString
        AdminConcernee.Text = row.Cells(3).Value.ToString
        Type.SelectedItem = row.Cells(4).Value.ToString
        NomEntrep.Text = row.Cells(5).Value.ToString
        Gerant.Text = row.Cells(6).Value.ToString
        Sujet.SelectedItem = row.Cells(7).Value.ToString
        DateEvenemet.Text = row.Cells(8).Value.ToString
        MotifExclu.Text = row.Cells(9).Value.ToString
        PeroidExclu.Text = row.Cells(10).Value.ToString
        NewClass.SelectedItem = row.Cells(11).Value.ToString
        NewNumCertf.Text = row.Cells(12).Value.ToString
        RefExclu.Text = row.Cells(13).Value.ToString
        DateReconsid.Text = row.Cells(14).Value.ToString
    End Sub

    Private Sub EditBtn_Click(sender As Object, e As EventArgs) Handles EditBtn.Click
        Dim NewC As String
        If IsNothing(NewClass.SelectedItem) Then
            NewC = ""
        Else
            NewC = NewClass.SelectedItem.ToString
        End If

        Dim NewType As String
        If IsNothing(Type.SelectedItem) Then
            NewType = ""
        Else
            NewType = Type.SelectedItem.ToString
        End If

        Dim NewSujet As String
        If IsNothing(Sujet.SelectedItem) Then
            NewSujet = ""
        Else
            NewSujet = Sujet.SelectedItem.ToString
        End If
        'If Wilaya.Text = "" Or NumEnvoi.Text = "" Or AdminConcernee.Text = "" Or Type.SelectedItem.ToString = "" Or NomEntrep.Text = "" Or Gerant.Text = "" Or Sujet.SelectedItem.ToString = "" Or MotifExclu.Text = "" Or PeroidExclu.Text = "" Or NewClass.SelectedItem.ToString = "" Or NewNumCertf.Text = "" Or RefExclu.Text = "" Then
        'MsgBox("Des informations manquante")
        'Else
        Try
            con.Open()
            Dim Query As String
            Query = "update ListNoirEntrep set Wilaya=N'" & Wilaya.Text & "', Num_envoi=N'" & NumEnvoi.Text & "',Date_envoi='" & DateEnvoi.Text & "', Admin_concernee=N'" & AdminConcernee.Text & "',Type=N'" & NewType & "', Nom=N'" & NomEntrep.Text & "',Gerant=N'" & Gerant.Text & "', Sujet=N'" & NewSujet & "',Date_Evenment='" & DateEvenemet.Text & "', Motif_exclu=N'" & MotifExclu.Text & "',Peroid_exclu=N'" & PeroidExclu.Text & "', New_class=N'" & NewC & "', New_num_certaficat=N'" & NewNumCertf.Text & "', Ref_exclu=N'" & RefExclu.Text & "',Date_reconsideration='" & DateReconsid.Text & "' where EntrepID='" & key & "'"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(Query, con)
            cmd.ExecuteNonQuery()
            Dim Query1 As String
            Dim trans As String
            trans = "Edition de enregistrement"
            Query1 = "insert into Transactions values( N'" & ShowPswd.User & "','" & DateTime.Now & "', N'" & trans & "' ,(select ISNULL(MAX(KeyID)+1,1) from Transactions), N'" & key & "');"
            Dim cmd1 As SqlCommand
            cmd1 = New SqlCommand(Query1, con)
            cmd1.ExecuteNonQuery()
            MsgBox("L'enregistrement est edité avec succès")
            con.Close()
            Populate()
            Clear()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        'End If
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

    Private Sub HomeBtn_Click(sender As Object, e As EventArgs) Handles HomeBtn.Click
        Me.Hide()
        Dim Home = New MainForm
        Home.Show()
    End Sub

    Private Sub PrintBtn_Click(sender As Object, e As EventArgs) Handles PrintBtn.Click
        If SetupThePrinting() Then
            PrintDocument1.Print()
        End If
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim more As Boolean = MyDataGridViewPrinter.DrawDataGridView(e.Graphics)
        If more = True Then
            e.HasMorePages = True
        End If
    End Sub

    Private Sub PrintPreviewDialog1_Load(sender As Object, e As EventArgs) Handles PrintPreviewDialog1.Load

    End Sub


    Private Sub Preview_Click(sender As Object, e As EventArgs) Handles Preview.Click
        If SetupThePrinting() Then
            Dim MyPrintPreviewDialog As PrintPreviewDialog = New PrintPreviewDialog()
            MyPrintPreviewDialog.Document = PrintDocument1
            MyPrintPreviewDialog.ShowDialog()
        End If
    End Sub
    Private Function SetupThePrinting() As Boolean
        Dim MyPrintDialog As PrintDialog = New PrintDialog()
        MyPrintDialog.AllowCurrentPage = False
        MyPrintDialog.AllowPrintToFile = False
        MyPrintDialog.AllowSelection = False
        MyPrintDialog.AllowSomePages = False
        MyPrintDialog.PrintToFile = False
        MyPrintDialog.ShowHelp = False
        MyPrintDialog.ShowNetwork = False

        If MyPrintDialog.ShowDialog() <> DialogResult.OK Then
            Return False
        End If

        PrintDocument1.DocumentName = "Customers Report"
        PrintDocument1.PrinterSettings = MyPrintDialog.PrinterSettings
        PrintDocument1.DefaultPageSettings = MyPrintDialog.PrinterSettings.DefaultPageSettings
        PrintDocument1.DefaultPageSettings.Margins = New Margins(40, 40, 40, 40)

        If MessageBox.Show("Do you want the report to be centered on the page", "InvoiceManager - Center on Page", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            MyDataGridViewPrinter = New DataGridViewPrinter(DataGridViewTBL, PrintDocument1, True, True, "Customers", New Font("Tahoma", 18, FontStyle.Bold, GraphicsUnit.Point), Color.Black, True)
        Else
            MyDataGridViewPrinter = New DataGridViewPrinter(DataGridViewTBL, PrintDocument1, False, True, "Customers", New Font("Tahoma", 18, FontStyle.Bold, GraphicsUnit.Point), Color.Black, True)
        End If

        Return True
    End Function

    Private Sub DataGridViewTBL_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewTBL.CellContentClick

    End Sub

    Private Sub Type_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Type.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Clear()

    End Sub
End Class