<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class license
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(license))
        Me.titleBox = New System.Windows.Forms.PictureBox()
        Me.close_btn = New System.Windows.Forms.Button()
        Me.keyTitle = New System.Windows.Forms.Label()
        Me.keyInput = New System.Windows.Forms.TextBox()
        Me.submit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.help = New System.Windows.Forms.LinkLabel()
        CType(Me.titleBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'titleBox
        '
        Me.titleBox.Image = Global.theia_2.My.Resources.Resources.title
        Me.titleBox.Location = New System.Drawing.Point(45, 80)
        Me.titleBox.Name = "titleBox"
        Me.titleBox.Size = New System.Drawing.Size(309, 35)
        Me.titleBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.titleBox.TabIndex = 3
        Me.titleBox.TabStop = False
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
        Me.close_btn.TabIndex = 10
        Me.close_btn.UseVisualStyleBackColor = True
        '
        'keyTitle
        '
        Me.keyTitle.AutoSize = True
        Me.keyTitle.Font = New System.Drawing.Font("Bahnschrift SemiLight", 12.0!)
        Me.keyTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.keyTitle.Location = New System.Drawing.Point(41, 188)
        Me.keyTitle.Name = "keyTitle"
        Me.keyTitle.Size = New System.Drawing.Size(147, 19)
        Me.keyTitle.TabIndex = 24
        Me.keyTitle.Text = "Enter Liecense Key"
        '
        'keyInput
        '
        Me.keyInput.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.keyInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.keyInput.Font = New System.Drawing.Font("Consolas", 12.0!)
        Me.keyInput.ForeColor = System.Drawing.Color.White
        Me.keyInput.Location = New System.Drawing.Point(45, 225)
        Me.keyInput.MaxLength = 24
        Me.keyInput.Name = "keyInput"
        Me.keyInput.Size = New System.Drawing.Size(309, 26)
        Me.keyInput.TabIndex = 25
        '
        'submit
        '
        Me.submit.AutoSize = True
        Me.submit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.submit.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.submit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.submit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.submit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.submit.Font = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.submit.ForeColor = System.Drawing.Color.White
        Me.submit.Location = New System.Drawing.Point(45, 269)
        Me.submit.Margin = New System.Windows.Forms.Padding(0)
        Me.submit.Name = "submit"
        Me.submit.Size = New System.Drawing.Size(72, 31)
        Me.submit.TabIndex = 26
        Me.submit.Text = "Submit"
        Me.submit.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift SemiLight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(26, 433)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(346, 38)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Please contact the developers if you don't have any serial key"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'help
        '
        Me.help.AutoSize = True
        Me.help.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.help.ForeColor = System.Drawing.SystemColors.Window
        Me.help.LinkColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.help.Location = New System.Drawing.Point(335, 10)
        Me.help.Name = "help"
        Me.help.Size = New System.Drawing.Size(25, 26)
        Me.help.TabIndex = 28
        Me.help.TabStop = True
        Me.help.Text = "?"
        Me.help.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        '
        'license
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(400, 480)
        Me.Controls.Add(Me.help)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.submit)
        Me.Controls.Add(Me.keyInput)
        Me.Controls.Add(Me.keyTitle)
        Me.Controls.Add(Me.close_btn)
        Me.Controls.Add(Me.titleBox)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "license"
        Me.Text = "license"
        CType(Me.titleBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents titleBox As PictureBox
    Friend WithEvents close_btn As Button
    Friend WithEvents keyTitle As Label
    Friend WithEvents keyInput As TextBox
    Friend WithEvents submit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents help As LinkLabel
End Class
