<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class scanDirectorty
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(scanDirectorty))
        Me.RightLabel = New System.Windows.Forms.Label()
        Me.WrongLabel = New System.Windows.Forms.Label()
        Me.RightMarksInput = New System.Windows.Forms.NumericUpDown()
        Me.WrongMarksInput = New System.Windows.Forms.NumericUpDown()
        Me.browse_btn = New System.Windows.Forms.Button()
        Me.folderLoc = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.scanAnsConfirm = New System.Windows.Forms.Button()
        Me.examNameInput = New System.Windows.Forms.TextBox()
        Me.examNameTitle = New System.Windows.Forms.Label()
        Me.animLoad = New System.Windows.Forms.PictureBox()
        Me.print_title = New System.Windows.Forms.PictureBox()
        Me.minimize = New System.Windows.Forms.Button()
        Me.close_btn = New System.Windows.Forms.Button()
        CType(Me.RightMarksInput, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WrongMarksInput, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.animLoad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.print_title, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RightLabel
        '
        Me.RightLabel.AutoSize = True
        Me.RightLabel.Font = New System.Drawing.Font("Bahnschrift SemiBold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RightLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.RightLabel.Location = New System.Drawing.Point(30, 205)
        Me.RightLabel.Name = "RightLabel"
        Me.RightLabel.Size = New System.Drawing.Size(210, 23)
        Me.RightLabel.TabIndex = 15
        Me.RightLabel.Text = "Marks Per Right Answer"
        '
        'WrongLabel
        '
        Me.WrongLabel.AutoSize = True
        Me.WrongLabel.Font = New System.Drawing.Font("Bahnschrift SemiBold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WrongLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.WrongLabel.Location = New System.Drawing.Point(30, 241)
        Me.WrongLabel.Name = "WrongLabel"
        Me.WrongLabel.Size = New System.Drawing.Size(233, 23)
        Me.WrongLabel.TabIndex = 16
        Me.WrongLabel.Text = "Penalty Per Wrong Answer"
        '
        'RightMarksInput
        '
        Me.RightMarksInput.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.RightMarksInput.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RightMarksInput.DecimalPlaces = 2
        Me.RightMarksInput.Font = New System.Drawing.Font("Bahnschrift SemiBold", 14.25!, System.Drawing.FontStyle.Bold)
        Me.RightMarksInput.ForeColor = System.Drawing.Color.White
        Me.RightMarksInput.Increment = New Decimal(New Integer() {25, 0, 0, 131072})
        Me.RightMarksInput.Location = New System.Drawing.Point(282, 206)
        Me.RightMarksInput.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.RightMarksInput.Minimum = New Decimal(New Integer() {25, 0, 0, 131072})
        Me.RightMarksInput.Name = "RightMarksInput"
        Me.RightMarksInput.Size = New System.Drawing.Size(85, 26)
        Me.RightMarksInput.TabIndex = 17
        Me.RightMarksInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.RightMarksInput.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'WrongMarksInput
        '
        Me.WrongMarksInput.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.WrongMarksInput.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WrongMarksInput.DecimalPlaces = 2
        Me.WrongMarksInput.Font = New System.Drawing.Font("Bahnschrift SemiBold", 14.25!, System.Drawing.FontStyle.Bold)
        Me.WrongMarksInput.ForeColor = System.Drawing.Color.White
        Me.WrongMarksInput.Increment = New Decimal(New Integer() {25, 0, 0, 131072})
        Me.WrongMarksInput.Location = New System.Drawing.Point(282, 242)
        Me.WrongMarksInput.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.WrongMarksInput.Name = "WrongMarksInput"
        Me.WrongMarksInput.Size = New System.Drawing.Size(85, 26)
        Me.WrongMarksInput.TabIndex = 18
        Me.WrongMarksInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'browse_btn
        '
        Me.browse_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.browse_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.browse_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.browse_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.browse_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.browse_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.browse_btn.ForeColor = System.Drawing.Color.White
        Me.browse_btn.Location = New System.Drawing.Point(318, 323)
        Me.browse_btn.Name = "browse_btn"
        Me.browse_btn.Size = New System.Drawing.Size(53, 22)
        Me.browse_btn.TabIndex = 21
        Me.browse_btn.Text = "Browse"
        Me.browse_btn.UseVisualStyleBackColor = False
        '
        'folderLoc
        '
        Me.folderLoc.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.folderLoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.folderLoc.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.folderLoc.ForeColor = System.Drawing.Color.White
        Me.folderLoc.Location = New System.Drawing.Point(32, 323)
        Me.folderLoc.Name = "folderLoc"
        Me.folderLoc.Size = New System.Drawing.Size(280, 22)
        Me.folderLoc.TabIndex = 20
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift SemiLight", 12.0!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(28, 297)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(295, 19)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Enter Location of Scanned OMR Sheet(s)"
        '
        'scanAnsConfirm
        '
        Me.scanAnsConfirm.AutoSize = True
        Me.scanAnsConfirm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.scanAnsConfirm.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.scanAnsConfirm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.scanAnsConfirm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.scanAnsConfirm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.scanAnsConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.scanAnsConfirm.Font = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.scanAnsConfirm.ForeColor = System.Drawing.Color.White
        Me.scanAnsConfirm.Location = New System.Drawing.Point(32, 366)
        Me.scanAnsConfirm.Name = "scanAnsConfirm"
        Me.scanAnsConfirm.Size = New System.Drawing.Size(57, 31)
        Me.scanAnsConfirm.TabIndex = 22
        Me.scanAnsConfirm.Text = "Scan"
        Me.scanAnsConfirm.UseVisualStyleBackColor = False
        '
        'examNameInput
        '
        Me.examNameInput.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.examNameInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.examNameInput.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.examNameInput.ForeColor = System.Drawing.Color.White
        Me.examNameInput.Location = New System.Drawing.Point(34, 158)
        Me.examNameInput.Name = "examNameInput"
        Me.examNameInput.Size = New System.Drawing.Size(333, 22)
        Me.examNameInput.TabIndex = 24
        '
        'examNameTitle
        '
        Me.examNameTitle.AutoSize = True
        Me.examNameTitle.Font = New System.Drawing.Font("Bahnschrift SemiLight", 12.0!)
        Me.examNameTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.examNameTitle.Location = New System.Drawing.Point(30, 128)
        Me.examNameTitle.Name = "examNameTitle"
        Me.examNameTitle.Size = New System.Drawing.Size(139, 19)
        Me.examNameTitle.TabIndex = 23
        Me.examNameTitle.Text = "Enter Exam Name"
        '
        'animLoad
        '
        Me.animLoad.Image = Global.theia_2.My.Resources.Resources.loading_2
        Me.animLoad.Location = New System.Drawing.Point(165, 398)
        Me.animLoad.Name = "animLoad"
        Me.animLoad.Size = New System.Drawing.Size(70, 70)
        Me.animLoad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.animLoad.TabIndex = 25
        Me.animLoad.TabStop = False
        Me.animLoad.Visible = False
        '
        'print_title
        '
        Me.print_title.Image = CType(resources.GetObject("print_title.Image"), System.Drawing.Image)
        Me.print_title.Location = New System.Drawing.Point(68, 54)
        Me.print_title.Name = "print_title"
        Me.print_title.Size = New System.Drawing.Size(255, 45)
        Me.print_title.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.print_title.TabIndex = 11
        Me.print_title.TabStop = False
        '
        'minimize
        '
        Me.minimize.BackgroundImage = Global.theia_2.My.Resources.Resources.close_yellow
        Me.minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.minimize.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.minimize.Location = New System.Drawing.Point(334, 12)
        Me.minimize.Name = "minimize"
        Me.minimize.Size = New System.Drawing.Size(25, 23)
        Me.minimize.TabIndex = 10
        Me.minimize.UseVisualStyleBackColor = True
        '
        'close_btn
        '
        Me.close_btn.BackgroundImage = Global.theia_2.My.Resources.Resources.close
        Me.close_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.close_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.close_btn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.close_btn.Location = New System.Drawing.Point(363, 12)
        Me.close_btn.Name = "close_btn"
        Me.close_btn.Size = New System.Drawing.Size(25, 23)
        Me.close_btn.TabIndex = 9
        Me.close_btn.UseVisualStyleBackColor = True
        '
        'scanDirectorty
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(400, 480)
        Me.Controls.Add(Me.animLoad)
        Me.Controls.Add(Me.scanAnsConfirm)
        Me.Controls.Add(Me.examNameInput)
        Me.Controls.Add(Me.examNameTitle)
        Me.Controls.Add(Me.browse_btn)
        Me.Controls.Add(Me.folderLoc)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.WrongMarksInput)
        Me.Controls.Add(Me.RightMarksInput)
        Me.Controls.Add(Me.WrongLabel)
        Me.Controls.Add(Me.RightLabel)
        Me.Controls.Add(Me.print_title)
        Me.Controls.Add(Me.minimize)
        Me.Controls.Add(Me.close_btn)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "scanDirectorty"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "scanDirectorty"
        CType(Me.RightMarksInput, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WrongMarksInput, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.animLoad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.print_title, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents minimize As Button
    Friend WithEvents close_btn As Button
    Friend WithEvents print_title As PictureBox
    Friend WithEvents RightLabel As Label
    Friend WithEvents WrongLabel As Label
    Friend WithEvents RightMarksInput As NumericUpDown
    Friend WithEvents WrongMarksInput As NumericUpDown
    Friend WithEvents browse_btn As Button
    Friend WithEvents folderLoc As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents scanAnsConfirm As Button
    Friend WithEvents examNameInput As TextBox
    Friend WithEvents examNameTitle As Label
    Friend WithEvents animLoad As PictureBox
End Class
