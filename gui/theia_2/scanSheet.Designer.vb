<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class scanSheet
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(scanSheet))
        Me.QsnCountInput = New System.Windows.Forms.NumericUpDown()
        Me.copyCountLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.fileDir = New System.Windows.Forms.TextBox()
        Me.browse = New System.Windows.Forms.Button()
        Me.print_title = New System.Windows.Forms.PictureBox()
        Me.minimize = New System.Windows.Forms.Button()
        Me.close_btn = New System.Windows.Forms.Button()
        Me.recentLocations = New System.Windows.Forms.ListBox()
        Me.recLocLabel = New System.Windows.Forms.Label()
        Me.scanAnsConfirm = New System.Windows.Forms.Button()
        Me.senseBar = New System.Windows.Forms.TrackBar()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.QsnCountInput, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.print_title, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.senseBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'QsnCountInput
        '
        Me.QsnCountInput.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.QsnCountInput.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.QsnCountInput.Font = New System.Drawing.Font("Bahnschrift SemiBold", 14.25!, System.Drawing.FontStyle.Bold)
        Me.QsnCountInput.ForeColor = System.Drawing.Color.White
        Me.QsnCountInput.Location = New System.Drawing.Point(215, 129)
        Me.QsnCountInput.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.QsnCountInput.Name = "QsnCountInput"
        Me.QsnCountInput.Size = New System.Drawing.Size(150, 26)
        Me.QsnCountInput.TabIndex = 15
        Me.QsnCountInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.QsnCountInput.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'copyCountLabel
        '
        Me.copyCountLabel.AutoSize = True
        Me.copyCountLabel.Font = New System.Drawing.Font("Bahnschrift SemiBold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.copyCountLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.copyCountLabel.Location = New System.Drawing.Point(22, 128)
        Me.copyCountLabel.Name = "copyCountLabel"
        Me.copyCountLabel.Size = New System.Drawing.Size(190, 23)
        Me.copyCountLabel.TabIndex = 14
        Me.copyCountLabel.Text = "Number of Questions :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift SemiLight", 12.0!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(22, 238)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(300, 19)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Enter Location of Scanned Answer Sheet"
        '
        'fileDir
        '
        Me.fileDir.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.fileDir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.fileDir.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fileDir.ForeColor = System.Drawing.Color.White
        Me.fileDir.Location = New System.Drawing.Point(26, 264)
        Me.fileDir.Name = "fileDir"
        Me.fileDir.Size = New System.Drawing.Size(280, 22)
        Me.fileDir.TabIndex = 17
        '
        'browse
        '
        Me.browse.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.browse.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.browse.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.browse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.browse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.browse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.browse.ForeColor = System.Drawing.Color.White
        Me.browse.Location = New System.Drawing.Point(312, 264)
        Me.browse.Name = "browse"
        Me.browse.Size = New System.Drawing.Size(53, 22)
        Me.browse.TabIndex = 18
        Me.browse.Text = "Browse"
        Me.browse.UseVisualStyleBackColor = False
        '
        'print_title
        '
        Me.print_title.Image = CType(resources.GetObject("print_title.Image"), System.Drawing.Image)
        Me.print_title.Location = New System.Drawing.Point(68, 54)
        Me.print_title.Name = "print_title"
        Me.print_title.Size = New System.Drawing.Size(255, 45)
        Me.print_title.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.print_title.TabIndex = 10
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
        Me.minimize.TabIndex = 8
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
        Me.close_btn.TabIndex = 7
        Me.close_btn.UseVisualStyleBackColor = True
        '
        'recentLocations
        '
        Me.recentLocations.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.recentLocations.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.recentLocations.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.recentLocations.ForeColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.recentLocations.FormattingEnabled = True
        Me.recentLocations.ItemHeight = 14
        Me.recentLocations.Location = New System.Drawing.Point(26, 317)
        Me.recentLocations.Name = "recentLocations"
        Me.recentLocations.Size = New System.Drawing.Size(339, 154)
        Me.recentLocations.TabIndex = 19
        '
        'recLocLabel
        '
        Me.recLocLabel.AutoSize = True
        Me.recLocLabel.Font = New System.Drawing.Font("Bahnschrift SemiLight", 12.0!)
        Me.recLocLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.recLocLabel.Location = New System.Drawing.Point(22, 294)
        Me.recLocLabel.Name = "recLocLabel"
        Me.recLocLabel.Size = New System.Drawing.Size(132, 19)
        Me.recLocLabel.TabIndex = 20
        Me.recLocLabel.Text = "Recent Locations"
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
        Me.scanAnsConfirm.Location = New System.Drawing.Point(294, 477)
        Me.scanAnsConfirm.Name = "scanAnsConfirm"
        Me.scanAnsConfirm.Size = New System.Drawing.Size(71, 31)
        Me.scanAnsConfirm.TabIndex = 21
        Me.scanAnsConfirm.Text = "Next >>"
        Me.scanAnsConfirm.UseVisualStyleBackColor = False
        '
        'senseBar
        '
        Me.senseBar.LargeChange = 10
        Me.senseBar.Location = New System.Drawing.Point(145, 176)
        Me.senseBar.Maximum = 80
        Me.senseBar.Minimum = 20
        Me.senseBar.Name = "senseBar"
        Me.senseBar.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.senseBar.Size = New System.Drawing.Size(220, 45)
        Me.senseBar.SmallChange = 5
        Me.senseBar.TabIndex = 22
        Me.senseBar.Value = 60
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift SemiBold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(22, 181)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 23)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Sensitivity:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Bahnschrift SemiLight", 12.0!)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(314, 207)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 19)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Dark"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Bahnschrift SemiLight", 12.0!)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(141, 207)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 19)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Light"
        '
        'scanSheet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(400, 534)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.senseBar)
        Me.Controls.Add(Me.scanAnsConfirm)
        Me.Controls.Add(Me.recLocLabel)
        Me.Controls.Add(Me.recentLocations)
        Me.Controls.Add(Me.browse)
        Me.Controls.Add(Me.fileDir)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.QsnCountInput)
        Me.Controls.Add(Me.copyCountLabel)
        Me.Controls.Add(Me.print_title)
        Me.Controls.Add(Me.minimize)
        Me.Controls.Add(Me.close_btn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "scanSheet"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "scanSheet"
        CType(Me.QsnCountInput, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.print_title, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.senseBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents minimize As Button
    Friend WithEvents close_btn As Button
    Friend WithEvents print_title As PictureBox
    Friend WithEvents QsnCountInput As NumericUpDown
    Friend WithEvents copyCountLabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents fileDir As TextBox
    Friend WithEvents browse As Button
    Friend WithEvents recentLocations As ListBox
    Friend WithEvents recLocLabel As Label
    Friend WithEvents scanAnsConfirm As Button
    Friend WithEvents senseBar As TrackBar
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
