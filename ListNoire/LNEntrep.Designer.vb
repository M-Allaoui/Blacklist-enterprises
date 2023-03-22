<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LNEntrep
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LNEntrep))
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.DateReconsid = New System.Windows.Forms.TextBox()
        Me.DateEvenemet = New System.Windows.Forms.TextBox()
        Me.DateEnvoi = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Preview = New System.Windows.Forms.Button()
        Me.DataGridViewTBL = New System.Windows.Forms.DataGridView()
        Me.PrintBtn = New System.Windows.Forms.Button()
        Me.LNTbl = New Guna.UI.WinForms.GunaDataGridView()
        Me.HomeBtn = New System.Windows.Forms.Button()
        Me.DeletBtn = New System.Windows.Forms.Button()
        Me.EditBtn = New System.Windows.Forms.Button()
        Me.AddBtn = New System.Windows.Forms.Button()
        Me.label17 = New System.Windows.Forms.Label()
        Me.label14 = New System.Windows.Forms.Label()
        Me.label15 = New System.Windows.Forms.Label()
        Me.label16 = New System.Windows.Forms.Label()
        Me.label13 = New System.Windows.Forms.Label()
        Me.label12 = New System.Windows.Forms.Label()
        Me.label11 = New System.Windows.Forms.Label()
        Me.label10 = New System.Windows.Forms.Label()
        Me.label9 = New System.Windows.Forms.Label()
        Me.label8 = New System.Windows.Forms.Label()
        Me.label7 = New System.Windows.Forms.Label()
        Me.label6 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.NewClass = New System.Windows.Forms.ComboBox()
        Me.NewNumCertf = New System.Windows.Forms.TextBox()
        Me.RefExclu = New System.Windows.Forms.TextBox()
        Me.Sujet = New System.Windows.Forms.ComboBox()
        Me.Type = New System.Windows.Forms.ComboBox()
        Me.MotifExclu = New System.Windows.Forms.TextBox()
        Me.NomEntrep = New System.Windows.Forms.TextBox()
        Me.PeroidExclu = New System.Windows.Forms.TextBox()
        Me.AdminConcernee = New System.Windows.Forms.TextBox()
        Me.Gerant = New System.Windows.Forms.TextBox()
        Me.NumEnvoi = New System.Windows.Forms.TextBox()
        Me.Wilaya = New System.Windows.Forms.TextBox()
        Me.pictureBox2 = New System.Windows.Forms.PictureBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.NameUser = New System.Windows.Forms.Label()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.panel1.SuspendLayout()
        CType(Me.DataGridViewTBL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LNTbl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panel1
        '
        Me.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.panel1.Controls.Add(Me.DateReconsid)
        Me.panel1.Controls.Add(Me.DateEvenemet)
        Me.panel1.Controls.Add(Me.DateEnvoi)
        Me.panel1.Controls.Add(Me.Button1)
        Me.panel1.Controls.Add(Me.Label2)
        Me.panel1.Controls.Add(Me.Preview)
        Me.panel1.Controls.Add(Me.DataGridViewTBL)
        Me.panel1.Controls.Add(Me.PrintBtn)
        Me.panel1.Controls.Add(Me.LNTbl)
        Me.panel1.Controls.Add(Me.HomeBtn)
        Me.panel1.Controls.Add(Me.DeletBtn)
        Me.panel1.Controls.Add(Me.EditBtn)
        Me.panel1.Controls.Add(Me.AddBtn)
        Me.panel1.Controls.Add(Me.label17)
        Me.panel1.Controls.Add(Me.label14)
        Me.panel1.Controls.Add(Me.label15)
        Me.panel1.Controls.Add(Me.label16)
        Me.panel1.Controls.Add(Me.label13)
        Me.panel1.Controls.Add(Me.label12)
        Me.panel1.Controls.Add(Me.label11)
        Me.panel1.Controls.Add(Me.label10)
        Me.panel1.Controls.Add(Me.label9)
        Me.panel1.Controls.Add(Me.label8)
        Me.panel1.Controls.Add(Me.label7)
        Me.panel1.Controls.Add(Me.label6)
        Me.panel1.Controls.Add(Me.label5)
        Me.panel1.Controls.Add(Me.label4)
        Me.panel1.Controls.Add(Me.label3)
        Me.panel1.Controls.Add(Me.NewClass)
        Me.panel1.Controls.Add(Me.NewNumCertf)
        Me.panel1.Controls.Add(Me.RefExclu)
        Me.panel1.Controls.Add(Me.Sujet)
        Me.panel1.Controls.Add(Me.Type)
        Me.panel1.Controls.Add(Me.MotifExclu)
        Me.panel1.Controls.Add(Me.NomEntrep)
        Me.panel1.Controls.Add(Me.PeroidExclu)
        Me.panel1.Controls.Add(Me.AdminConcernee)
        Me.panel1.Controls.Add(Me.Gerant)
        Me.panel1.Controls.Add(Me.NumEnvoi)
        Me.panel1.Controls.Add(Me.Wilaya)
        Me.panel1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.panel1.Location = New System.Drawing.Point(0, 49)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(1000, 525)
        Me.panel1.TabIndex = 10
        '
        'DateReconsid
        '
        Me.DateReconsid.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateReconsid.Location = New System.Drawing.Point(856, 342)
        Me.DateReconsid.Name = "DateReconsid"
        Me.DateReconsid.Size = New System.Drawing.Size(132, 20)
        Me.DateReconsid.TabIndex = 49
        '
        'DateEvenemet
        '
        Me.DateEvenemet.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateEvenemet.Location = New System.Drawing.Point(856, 212)
        Me.DateEvenemet.Name = "DateEvenemet"
        Me.DateEvenemet.Size = New System.Drawing.Size(132, 20)
        Me.DateEvenemet.TabIndex = 48
        '
        'DateEnvoi
        '
        Me.DateEnvoi.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateEnvoi.Location = New System.Drawing.Point(856, 68)
        Me.DateEnvoi.Name = "DateEnvoi"
        Me.DateEnvoi.Size = New System.Drawing.Size(132, 20)
        Me.DateEnvoi.TabIndex = 47
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Navy
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(636, 489)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(81, 33)
        Me.Button1.TabIndex = 46
        Me.Button1.Text = " مسح الحقول"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label2.Location = New System.Drawing.Point(959, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 14)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "الولاية"
        '
        'Preview
        '
        Me.Preview.BackColor = System.Drawing.Color.Navy
        Me.Preview.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Preview.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Preview.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Preview.Location = New System.Drawing.Point(781, 489)
        Me.Preview.Name = "Preview"
        Me.Preview.Size = New System.Drawing.Size(52, 33)
        Me.Preview.TabIndex = 44
        Me.Preview.Text = "معاينة"
        Me.Preview.UseVisualStyleBackColor = False
        '
        'DataGridViewTBL
        '
        Me.DataGridViewTBL.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridViewTBL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewTBL.Location = New System.Drawing.Point(8, 0)
        Me.DataGridViewTBL.Name = "DataGridViewTBL"
        Me.DataGridViewTBL.Size = New System.Drawing.Size(705, 471)
        Me.DataGridViewTBL.TabIndex = 43
        '
        'PrintBtn
        '
        Me.PrintBtn.BackColor = System.Drawing.Color.Navy
        Me.PrintBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PrintBtn.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrintBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PrintBtn.Location = New System.Drawing.Point(723, 489)
        Me.PrintBtn.Name = "PrintBtn"
        Me.PrintBtn.Size = New System.Drawing.Size(52, 33)
        Me.PrintBtn.TabIndex = 42
        Me.PrintBtn.Text = "طباعة"
        Me.PrintBtn.UseVisualStyleBackColor = False
        '
        'LNTbl
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.LNTbl.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.LNTbl.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.LNTbl.BackgroundColor = System.Drawing.Color.White
        Me.LNTbl.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LNTbl.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.LNTbl.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.LNTbl.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.LNTbl.ColumnHeadersHeight = 25
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.LNTbl.DefaultCellStyle = DataGridViewCellStyle3
        Me.LNTbl.EnableHeadersVisualStyles = False
        Me.LNTbl.GridColor = System.Drawing.Color.White
        Me.LNTbl.Location = New System.Drawing.Point(180, 380)
        Me.LNTbl.Name = "LNTbl"
        Me.LNTbl.RowHeadersVisible = False
        Me.LNTbl.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.LNTbl.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.LNTbl.Size = New System.Drawing.Size(64, 70)
        Me.LNTbl.TabIndex = 41
        Me.LNTbl.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna
        Me.LNTbl.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.LNTbl.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.LNTbl.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.LNTbl.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.LNTbl.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.LNTbl.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.LNTbl.ThemeStyle.GridColor = System.Drawing.Color.White
        Me.LNTbl.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.LightSteelBlue
        Me.LNTbl.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.LNTbl.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LNTbl.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black
        Me.LNTbl.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.LNTbl.ThemeStyle.HeaderStyle.Height = 25
        Me.LNTbl.ThemeStyle.ReadOnly = False
        Me.LNTbl.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.LNTbl.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.LNTbl.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LNTbl.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.LNTbl.ThemeStyle.RowsStyle.Height = 22
        Me.LNTbl.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LNTbl.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'HomeBtn
        '
        Me.HomeBtn.BackColor = System.Drawing.Color.Navy
        Me.HomeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HomeBtn.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HomeBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.HomeBtn.Location = New System.Drawing.Point(578, 489)
        Me.HomeBtn.Name = "HomeBtn"
        Me.HomeBtn.Size = New System.Drawing.Size(52, 33)
        Me.HomeBtn.TabIndex = 40
        Me.HomeBtn.Text = "الرئيسية"
        Me.HomeBtn.UseVisualStyleBackColor = False
        '
        'DeletBtn
        '
        Me.DeletBtn.BackColor = System.Drawing.Color.Navy
        Me.DeletBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DeletBtn.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeletBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DeletBtn.Location = New System.Drawing.Point(837, 489)
        Me.DeletBtn.Name = "DeletBtn"
        Me.DeletBtn.Size = New System.Drawing.Size(50, 33)
        Me.DeletBtn.TabIndex = 39
        Me.DeletBtn.Text = "حذف"
        Me.DeletBtn.UseVisualStyleBackColor = False
        '
        'EditBtn
        '
        Me.EditBtn.BackColor = System.Drawing.Color.Navy
        Me.EditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EditBtn.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.EditBtn.Location = New System.Drawing.Point(891, 489)
        Me.EditBtn.Name = "EditBtn"
        Me.EditBtn.Size = New System.Drawing.Size(50, 33)
        Me.EditBtn.TabIndex = 38
        Me.EditBtn.Text = "تعديل"
        Me.EditBtn.UseVisualStyleBackColor = False
        '
        'AddBtn
        '
        Me.AddBtn.BackColor = System.Drawing.Color.Navy
        Me.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddBtn.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.AddBtn.Location = New System.Drawing.Point(946, 489)
        Me.AddBtn.Name = "AddBtn"
        Me.AddBtn.Size = New System.Drawing.Size(50, 33)
        Me.AddBtn.TabIndex = 37
        Me.AddBtn.Text = "اضافة"
        Me.AddBtn.UseVisualStyleBackColor = False
        '
        'label17
        '
        Me.label17.AutoSize = True
        Me.label17.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label17.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.label17.Location = New System.Drawing.Point(918, 325)
        Me.label17.Name = "label17"
        Me.label17.Size = New System.Drawing.Size(70, 14)
        Me.label17.TabIndex = 36
        Me.label17.Text = "تاريخ رد الاعتبار"
        '
        'label14
        '
        Me.label14.AutoSize = True
        Me.label14.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label14.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.label14.Location = New System.Drawing.Point(789, 237)
        Me.label14.Name = "label14"
        Me.label14.Size = New System.Drawing.Size(62, 14)
        Me.label14.TabIndex = 34
        Me.label14.Text = "التصنيف الجديد"
        '
        'label15
        '
        Me.label15.AutoSize = True
        Me.label15.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label15.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.label15.Location = New System.Drawing.Point(914, 279)
        Me.label15.Name = "label15"
        Me.label15.Size = New System.Drawing.Size(74, 14)
        Me.label15.TabIndex = 32
        Me.label15.Text = "الرقم الجديد للشهادة"
        '
        'label16
        '
        Me.label16.AutoSize = True
        Me.label16.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label16.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.label16.Location = New System.Drawing.Point(793, 279)
        Me.label16.Name = "label16"
        Me.label16.Size = New System.Drawing.Size(58, 14)
        Me.label16.TabIndex = 29
        Me.label16.Text = "مرجع الاقصاء"
        '
        'label13
        '
        Me.label13.AutoSize = True
        Me.label13.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label13.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.label13.Location = New System.Drawing.Point(930, 195)
        Me.label13.Name = "label13"
        Me.label13.Size = New System.Drawing.Size(58, 14)
        Me.label13.TabIndex = 28
        Me.label13.Text = "تاريخ الاقصاء"
        '
        'label12
        '
        Me.label12.AutoSize = True
        Me.label12.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label12.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.label12.Location = New System.Drawing.Point(796, 195)
        Me.label12.Name = "label12"
        Me.label12.Size = New System.Drawing.Size(55, 14)
        Me.label12.TabIndex = 26
        Me.label12.Text = "سبب الاقصاء"
        '
        'label11
        '
        Me.label11.AutoSize = True
        Me.label11.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label11.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.label11.Location = New System.Drawing.Point(963, 97)
        Me.label11.Name = "label11"
        Me.label11.Size = New System.Drawing.Size(25, 14)
        Me.label11.TabIndex = 24
        Me.label11.Text = "النوع"
        '
        'label10
        '
        Me.label10.AutoSize = True
        Me.label10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label10.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.label10.Location = New System.Drawing.Point(934, 49)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(58, 14)
        Me.label10.TabIndex = 22
        Me.label10.Text = "تاريخ الارسال"
        '
        'label9
        '
        Me.label9.AutoSize = True
        Me.label9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label9.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.label9.Location = New System.Drawing.Point(811, 146)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(40, 14)
        Me.label9.TabIndex = 19
        Me.label9.Text = "الموضوع"
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label8.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.label8.Location = New System.Drawing.Point(826, 98)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(25, 14)
        Me.label8.TabIndex = 17
        Me.label8.Text = "الاسم"
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label7.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.label7.Location = New System.Drawing.Point(939, 237)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(49, 14)
        Me.label7.TabIndex = 15
        Me.label7.Text = "مدة الاقصاء"
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label6.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.label6.Location = New System.Drawing.Point(797, 51)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(54, 14)
        Me.label6.TabIndex = 13
        Me.label6.Text = "الادارة المعنية"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label5.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.label5.Location = New System.Drawing.Point(959, 145)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(29, 14)
        Me.label5.TabIndex = 11
        Me.label5.Text = "المسير"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.label4.Location = New System.Drawing.Point(801, 4)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(50, 14)
        Me.label4.TabIndex = 9
        Me.label4.Text = "رقم الارسال"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.label3.Location = New System.Drawing.Point(2, 4)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(0, 14)
        Me.label3.TabIndex = 7
        '
        'NewClass
        '
        Me.NewClass.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewClass.FormattingEnabled = True
        Me.NewClass.Items.AddRange(New Object() {"الاولى", "الثانية", "الثالثة", "الرابعة", "الخامسة", "السادسة", "السابعة", "الثامنة", "الثاسعة"})
        Me.NewClass.Location = New System.Drawing.Point(719, 252)
        Me.NewClass.Name = "NewClass"
        Me.NewClass.Size = New System.Drawing.Size(132, 22)
        Me.NewClass.TabIndex = 35
        '
        'NewNumCertf
        '
        Me.NewNumCertf.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewNumCertf.Location = New System.Drawing.Point(859, 298)
        Me.NewNumCertf.Name = "NewNumCertf"
        Me.NewNumCertf.Size = New System.Drawing.Size(129, 20)
        Me.NewNumCertf.TabIndex = 31
        '
        'RefExclu
        '
        Me.RefExclu.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RefExclu.Location = New System.Drawing.Point(719, 298)
        Me.RefExclu.Name = "RefExclu"
        Me.RefExclu.Size = New System.Drawing.Size(132, 20)
        Me.RefExclu.TabIndex = 30
        '
        'Sujet
        '
        Me.Sujet.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sujet.FormattingEnabled = True
        Me.Sujet.Items.AddRange(New Object() {"إقصاء", "رد إعتبار", "تقليص مدة الاقصاء", "تغيير التصنيف", "شهادة التأهيل"})
        Me.Sujet.Location = New System.Drawing.Point(719, 162)
        Me.Sujet.Name = "Sujet"
        Me.Sujet.Size = New System.Drawing.Size(132, 22)
        Me.Sujet.TabIndex = 25
        '
        'Type
        '
        Me.Type.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Type.FormattingEnabled = True
        Me.Type.Items.AddRange(New Object() {"المقاولة", "الشركة", "مؤسسة", "مكتب دراسلت"})
        Me.Type.Location = New System.Drawing.Point(859, 113)
        Me.Type.Name = "Type"
        Me.Type.Size = New System.Drawing.Size(129, 22)
        Me.Type.TabIndex = 23
        '
        'MotifExclu
        '
        Me.MotifExclu.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MotifExclu.Location = New System.Drawing.Point(719, 212)
        Me.MotifExclu.Name = "MotifExclu"
        Me.MotifExclu.Size = New System.Drawing.Size(132, 20)
        Me.MotifExclu.TabIndex = 20
        '
        'NomEntrep
        '
        Me.NomEntrep.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NomEntrep.Location = New System.Drawing.Point(719, 115)
        Me.NomEntrep.Name = "NomEntrep"
        Me.NomEntrep.Size = New System.Drawing.Size(132, 20)
        Me.NomEntrep.TabIndex = 18
        '
        'PeroidExclu
        '
        Me.PeroidExclu.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PeroidExclu.Location = New System.Drawing.Point(859, 254)
        Me.PeroidExclu.Name = "PeroidExclu"
        Me.PeroidExclu.Size = New System.Drawing.Size(129, 20)
        Me.PeroidExclu.TabIndex = 16
        '
        'AdminConcernee
        '
        Me.AdminConcernee.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdminConcernee.Location = New System.Drawing.Point(719, 68)
        Me.AdminConcernee.Name = "AdminConcernee"
        Me.AdminConcernee.Size = New System.Drawing.Size(132, 20)
        Me.AdminConcernee.TabIndex = 14
        '
        'Gerant
        '
        Me.Gerant.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gerant.Location = New System.Drawing.Point(859, 161)
        Me.Gerant.Name = "Gerant"
        Me.Gerant.Size = New System.Drawing.Size(129, 20)
        Me.Gerant.TabIndex = 12
        '
        'NumEnvoi
        '
        Me.NumEnvoi.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumEnvoi.Location = New System.Drawing.Point(718, 21)
        Me.NumEnvoi.Name = "NumEnvoi"
        Me.NumEnvoi.Size = New System.Drawing.Size(133, 20)
        Me.NumEnvoi.TabIndex = 10
        '
        'Wilaya
        '
        Me.Wilaya.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Wilaya.Location = New System.Drawing.Point(859, 20)
        Me.Wilaya.Name = "Wilaya"
        Me.Wilaya.Size = New System.Drawing.Size(129, 20)
        Me.Wilaya.TabIndex = 8
        '
        'pictureBox2
        '
        Me.pictureBox2.Image = CType(resources.GetObject("pictureBox2.Image"), System.Drawing.Image)
        Me.pictureBox2.Location = New System.Drawing.Point(886, 21)
        Me.pictureBox2.Name = "pictureBox2"
        Me.pictureBox2.Size = New System.Drawing.Size(28, 21)
        Me.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBox2.TabIndex = 14
        Me.pictureBox2.TabStop = False
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.label1.Location = New System.Drawing.Point(915, 24)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(85, 19)
        Me.label1.TabIndex = 13
        Me.label1.Text = "تسجيل الخروج"
        '
        'NameUser
        '
        Me.NameUser.AutoSize = True
        Me.NameUser.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameUser.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.NameUser.Location = New System.Drawing.Point(66, 30)
        Me.NameUser.Name = "NameUser"
        Me.NameUser.Size = New System.Drawing.Size(86, 19)
        Me.NameUser.TabIndex = 12
        Me.NameUser.Text = "Utilisateur"
        '
        'pictureBox1
        '
        Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Image)
        Me.pictureBox1.Location = New System.Drawing.Point(13, 1)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(47, 46)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBox1.TabIndex = 11
        Me.pictureBox1.TabStop = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label18.Location = New System.Drawing.Point(982, 1)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(18, 19)
        Me.Label18.TabIndex = 15
        Me.Label18.Text = "x"
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'LNEntrep
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Navy
        Me.ClientSize = New System.Drawing.Size(1004, 586)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.panel1)
        Me.Controls.Add(Me.pictureBox2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.NameUser)
        Me.Controls.Add(Me.pictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "LNEntrep"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LNEntrep"
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        CType(Me.DataGridViewTBL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LNTbl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents panel1 As System.Windows.Forms.Panel
    Private WithEvents LNTbl As Guna.UI.WinForms.GunaDataGridView
    Private WithEvents HomeBtn As System.Windows.Forms.Button
    Private WithEvents DeletBtn As System.Windows.Forms.Button
    Private WithEvents EditBtn As System.Windows.Forms.Button
    Private WithEvents AddBtn As System.Windows.Forms.Button
    Private WithEvents label17 As System.Windows.Forms.Label
    Private WithEvents label14 As System.Windows.Forms.Label
    Private WithEvents label15 As System.Windows.Forms.Label
    Private WithEvents label16 As System.Windows.Forms.Label
    Private WithEvents label13 As System.Windows.Forms.Label
    Private WithEvents label12 As System.Windows.Forms.Label
    Private WithEvents label11 As System.Windows.Forms.Label
    Private WithEvents label10 As System.Windows.Forms.Label
    Private WithEvents label9 As System.Windows.Forms.Label
    Private WithEvents label8 As System.Windows.Forms.Label
    Private WithEvents label7 As System.Windows.Forms.Label
    Private WithEvents label6 As System.Windows.Forms.Label
    Private WithEvents label5 As System.Windows.Forms.Label
    Private WithEvents label4 As System.Windows.Forms.Label
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents NewClass As System.Windows.Forms.ComboBox
    Private WithEvents NewNumCertf As System.Windows.Forms.TextBox
    Private WithEvents RefExclu As System.Windows.Forms.TextBox
    Private WithEvents Sujet As System.Windows.Forms.ComboBox
    Private WithEvents Type As System.Windows.Forms.ComboBox
    Private WithEvents MotifExclu As System.Windows.Forms.TextBox
    Private WithEvents NomEntrep As System.Windows.Forms.TextBox
    Private WithEvents PeroidExclu As System.Windows.Forms.TextBox
    Private WithEvents AdminConcernee As System.Windows.Forms.TextBox
    Private WithEvents Gerant As System.Windows.Forms.TextBox
    Private WithEvents NumEnvoi As System.Windows.Forms.TextBox
    Private WithEvents Wilaya As System.Windows.Forms.TextBox
    Private WithEvents pictureBox2 As System.Windows.Forms.PictureBox
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents NameUser As System.Windows.Forms.Label
    Private WithEvents pictureBox1 As System.Windows.Forms.PictureBox
    Private WithEvents Label18 As System.Windows.Forms.Label
    Private WithEvents PrintBtn As System.Windows.Forms.Button
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents DataGridViewTBL As System.Windows.Forms.DataGridView
    Private WithEvents Preview As System.Windows.Forms.Button
    Private WithEvents Label2 As System.Windows.Forms.Label
    Private WithEvents Button1 As System.Windows.Forms.Button
    Private WithEvents DateReconsid As System.Windows.Forms.TextBox
    Private WithEvents DateEvenemet As System.Windows.Forms.TextBox
    Private WithEvents DateEnvoi As System.Windows.Forms.TextBox
End Class
