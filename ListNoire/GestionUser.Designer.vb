<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestionUser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GestionUser))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pictureBox2 = New System.Windows.Forms.PictureBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.NameUser = New System.Windows.Forms.Label()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.KeyID = New System.Windows.Forms.TextBox()
        Me.Previlege = New System.Windows.Forms.ComboBox()
        Me.LNTbl = New Guna.UI.WinForms.GunaDataGridView()
        Me.HomeBtn = New System.Windows.Forms.Button()
        Me.DeletBtn = New System.Windows.Forms.Button()
        Me.EditBtn = New System.Windows.Forms.Button()
        Me.AddBtn = New System.Windows.Forms.Button()
        Me.label10 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.MotPss = New System.Windows.Forms.TextBox()
        Me.UserID = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.LNTbl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pictureBox2
        '
        Me.pictureBox2.Image = CType(resources.GetObject("pictureBox2.Image"), System.Drawing.Image)
        Me.pictureBox2.Location = New System.Drawing.Point(312, 29)
        Me.pictureBox2.Name = "pictureBox2"
        Me.pictureBox2.Size = New System.Drawing.Size(28, 21)
        Me.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBox2.TabIndex = 18
        Me.pictureBox2.TabStop = False
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.label1.Location = New System.Drawing.Point(346, 33)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(129, 19)
        Me.label1.TabIndex = 17
        Me.label1.Text = "Se déconnecter"
        '
        'NameUser
        '
        Me.NameUser.AutoSize = True
        Me.NameUser.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameUser.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.NameUser.Location = New System.Drawing.Point(56, 33)
        Me.NameUser.Name = "NameUser"
        Me.NameUser.Size = New System.Drawing.Size(86, 19)
        Me.NameUser.TabIndex = 16
        Me.NameUser.Text = "Utilisateur"
        '
        'pictureBox1
        '
        Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Image)
        Me.pictureBox1.Location = New System.Drawing.Point(3, 4)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(47, 46)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBox1.TabIndex = 15
        Me.pictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.KeyID)
        Me.Panel1.Controls.Add(Me.Previlege)
        Me.Panel1.Controls.Add(Me.LNTbl)
        Me.Panel1.Controls.Add(Me.HomeBtn)
        Me.Panel1.Controls.Add(Me.DeletBtn)
        Me.Panel1.Controls.Add(Me.EditBtn)
        Me.Panel1.Controls.Add(Me.AddBtn)
        Me.Panel1.Controls.Add(Me.label10)
        Me.Panel1.Controls.Add(Me.label4)
        Me.Panel1.Controls.Add(Me.label3)
        Me.Panel1.Controls.Add(Me.MotPss)
        Me.Panel1.Controls.Add(Me.UserID)
        Me.Panel1.Location = New System.Drawing.Point(3, 56)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(472, 297)
        Me.Panel1.TabIndex = 19
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label5.Location = New System.Drawing.Point(8, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 14)
        Me.Label5.TabIndex = 47
        Me.Label5.Text = "KeyID"
        '
        'KeyID
        '
        Me.KeyID.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyID.Location = New System.Drawing.Point(11, 33)
        Me.KeyID.Name = "KeyID"
        Me.KeyID.Size = New System.Drawing.Size(129, 20)
        Me.KeyID.TabIndex = 48
        '
        'Previlege
        '
        Me.Previlege.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Previlege.FormattingEnabled = True
        Me.Previlege.Items.AddRange(New Object() {"1", "2", "3"})
        Me.Previlege.Location = New System.Drawing.Point(11, 160)
        Me.Previlege.Name = "Previlege"
        Me.Previlege.Size = New System.Drawing.Size(129, 22)
        Me.Previlege.TabIndex = 46
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
        Me.LNTbl.Location = New System.Drawing.Point(146, 3)
        Me.LNTbl.Name = "LNTbl"
        Me.LNTbl.RowHeadersVisible = False
        Me.LNTbl.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.LNTbl.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.LNTbl.Size = New System.Drawing.Size(320, 252)
        Me.LNTbl.TabIndex = 45
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
        Me.HomeBtn.Location = New System.Drawing.Point(220, 261)
        Me.HomeBtn.Name = "HomeBtn"
        Me.HomeBtn.Size = New System.Drawing.Size(62, 33)
        Me.HomeBtn.TabIndex = 44
        Me.HomeBtn.Text = "Accueil"
        Me.HomeBtn.UseVisualStyleBackColor = False
        '
        'DeletBtn
        '
        Me.DeletBtn.BackColor = System.Drawing.Color.Navy
        Me.DeletBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DeletBtn.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeletBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DeletBtn.Location = New System.Drawing.Point(129, 261)
        Me.DeletBtn.Name = "DeletBtn"
        Me.DeletBtn.Size = New System.Drawing.Size(88, 33)
        Me.DeletBtn.TabIndex = 43
        Me.DeletBtn.Text = "Supprimer"
        Me.DeletBtn.UseVisualStyleBackColor = False
        '
        'EditBtn
        '
        Me.EditBtn.BackColor = System.Drawing.Color.Navy
        Me.EditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EditBtn.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.EditBtn.Location = New System.Drawing.Point(70, 261)
        Me.EditBtn.Name = "EditBtn"
        Me.EditBtn.Size = New System.Drawing.Size(56, 33)
        Me.EditBtn.TabIndex = 42
        Me.EditBtn.Text = "Editer"
        Me.EditBtn.UseVisualStyleBackColor = False
        '
        'AddBtn
        '
        Me.AddBtn.BackColor = System.Drawing.Color.Navy
        Me.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddBtn.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.AddBtn.Location = New System.Drawing.Point(7, 261)
        Me.AddBtn.Name = "AddBtn"
        Me.AddBtn.Size = New System.Drawing.Size(61, 33)
        Me.AddBtn.TabIndex = 41
        Me.AddBtn.Text = "Ajouter"
        Me.AddBtn.UseVisualStyleBackColor = False
        '
        'label10
        '
        Me.label10.AutoSize = True
        Me.label10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label10.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.label10.Location = New System.Drawing.Point(10, 143)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(47, 14)
        Me.label10.TabIndex = 30
        Me.label10.Text = "Privilège"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.label4.Location = New System.Drawing.Point(10, 100)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(72, 14)
        Me.label4.TabIndex = 25
        Me.label4.Text = "Mot de passe"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.label3.Location = New System.Drawing.Point(8, 58)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(54, 14)
        Me.label3.TabIndex = 23
        Me.label3.Text = "Utilisateur"
        '
        'MotPss
        '
        Me.MotPss.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MotPss.Location = New System.Drawing.Point(13, 117)
        Me.MotPss.Name = "MotPss"
        Me.MotPss.Size = New System.Drawing.Size(127, 20)
        Me.MotPss.TabIndex = 26
        '
        'UserID
        '
        Me.UserID.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserID.Location = New System.Drawing.Point(11, 75)
        Me.UserID.Name = "UserID"
        Me.UserID.Size = New System.Drawing.Size(129, 20)
        Me.UserID.TabIndex = 24
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label6.Location = New System.Drawing.Point(455, 3)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(20, 19)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "X"
        '
        'GestionUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Navy
        Me.ClientSize = New System.Drawing.Size(477, 365)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pictureBox2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.NameUser)
        Me.Controls.Add(Me.pictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "GestionUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GestionUser"
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.LNTbl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents pictureBox2 As System.Windows.Forms.PictureBox
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents NameUser As System.Windows.Forms.Label
    Private WithEvents pictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Private WithEvents label10 As System.Windows.Forms.Label
    Private WithEvents label4 As System.Windows.Forms.Label
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents MotPss As System.Windows.Forms.TextBox
    Private WithEvents UserID As System.Windows.Forms.TextBox
    Private WithEvents HomeBtn As System.Windows.Forms.Button
    Private WithEvents DeletBtn As System.Windows.Forms.Button
    Private WithEvents EditBtn As System.Windows.Forms.Button
    Private WithEvents AddBtn As System.Windows.Forms.Button
    Private WithEvents LNTbl As Guna.UI.WinForms.GunaDataGridView
    Private WithEvents Previlege As System.Windows.Forms.ComboBox
    Private WithEvents Label5 As System.Windows.Forms.Label
    Private WithEvents KeyID As System.Windows.Forms.TextBox
    Private WithEvents Label6 As System.Windows.Forms.Label
End Class
