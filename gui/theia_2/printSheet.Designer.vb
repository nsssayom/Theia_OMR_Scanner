<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class printSheet
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(printSheet))
        Me.copyCountLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.printerList = New System.Windows.Forms.ListBox()
        Me.copyInput = New System.Windows.Forms.NumericUpDown()
        Me.print = New System.Windows.Forms.Button()
        Me.print_title = New System.Windows.Forms.PictureBox()
        Me.minimize = New System.Windows.Forms.Button()
        Me.close_btn = New System.Windows.Forms.Button()
        CType(Me.copyInput, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.print_title, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'copyCountLabel
        '
        Me.copyCountLabel.AutoSize = True
        Me.copyCountLabel.Font = New System.Drawing.Font("Bahnschrift SemiBold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.copyCountLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.copyCountLabel.Location = New System.Drawing.Point(22, 128)
        Me.copyCountLabel.Name = "copyCountLabel"
        Me.copyCountLabel.Size = New System.Drawing.Size(163, 23)
        Me.copyCountLabel.TabIndex = 8
        Me.copyCountLabel.Text = "Number of Copies :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift SemiLight", 12.0!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(22, 164)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 19)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Select Printer"
        '
        'printerList
        '
        Me.printerList.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.printerList.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.printerList.Font = New System.Drawing.Font("Consolas", 12.0!)
        Me.printerList.ForeColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.printerList.FormattingEnabled = True
        Me.printerList.ItemHeight = 19
        Me.printerList.Location = New System.Drawing.Point(25, 192)
        Me.printerList.Name = "printerList"
        Me.printerList.Size = New System.Drawing.Size(340, 190)
        Me.printerList.TabIndex = 11
        '
        'copyInput
        '
        Me.copyInput.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.copyInput.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.copyInput.Font = New System.Drawing.Font("Bahnschrift SemiBold", 14.25!, System.Drawing.FontStyle.Bold)
        Me.copyInput.ForeColor = System.Drawing.Color.White
        Me.copyInput.Location = New System.Drawing.Point(215, 129)
        Me.copyInput.Maximum = New Decimal(New Integer() {200, 0, 0, 0})
        Me.copyInput.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.copyInput.Name = "copyInput"
        Me.copyInput.Size = New System.Drawing.Size(150, 26)
        Me.copyInput.TabIndex = 13
        Me.copyInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.copyInput.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'print
        '
        Me.print.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.print.BackgroundImage = Global.theia_2.My.Resources.Resources.printIcon
        Me.print.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.print.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.print.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.print.Location = New System.Drawing.Point(323, 408)
        Me.print.Name = "print"
        Me.print.Size = New System.Drawing.Size(42, 45)
        Me.print.TabIndex = 12
        Me.print.UseVisualStyleBackColor = False
        '
        'print_title
        '
        Me.print_title.Image = Global.theia_2.My.Resources.Resources.printTitle
        Me.print_title.Location = New System.Drawing.Point(68, 54)
        Me.print_title.Name = "print_title"
        Me.print_title.Size = New System.Drawing.Size(255, 45)
        Me.print_title.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.print_title.TabIndex = 9
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
        Me.minimize.TabIndex = 6
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
        Me.close_btn.TabIndex = 5
        Me.close_btn.UseVisualStyleBackColor = True
        '
        'printSheet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(400, 480)
        Me.Controls.Add(Me.copyInput)
        Me.Controls.Add(Me.print)
        Me.Controls.Add(Me.printerList)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.print_title)
        Me.Controls.Add(Me.copyCountLabel)
        Me.Controls.Add(Me.minimize)
        Me.Controls.Add(Me.close_btn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "printSheet"
        Me.Text = "Print OMR Sheet"
        CType(Me.copyInput, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.print_title, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents minimize As Button
    Friend WithEvents close_btn As Button
    Friend WithEvents copyCountLabel As Label
    Friend WithEvents print_title As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents printerList As ListBox
    Friend WithEvents print As Button
    Friend WithEvents copyInput As NumericUpDown
End Class
