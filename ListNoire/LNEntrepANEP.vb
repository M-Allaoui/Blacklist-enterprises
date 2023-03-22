Imports System.Data.SqlClient
Imports System.Drawing.Printing
Public Class LNEntrepANEP
    Dim MyDataGridViewPrinter As DataGridViewPrinter
    'Dim con As New SqlConnection("Data Source=INFRPC;Initial Catalog=ListNoireEntrepreneur;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False")
    Dim con As New SqlConnection("SERVER=10.30.0.156;DATABASE=ListNoireEntrepreneur;USER ID=AS;PASSWORD=a1c-2b3")
    Private Sub Populate()
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

    End Sub
    Private Sub LNEntrepANEP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Populate()
        NameUser.Text = ShowPswd.User.ToString
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
End Class