<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class home
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(home))
        Me.minimize = New System.Windows.Forms.Button()
        Me.close_btn = New System.Windows.Forms.Button()
        Me.titleBox = New System.Windows.Forms.PictureBox()
        Me.scanOption = New System.Windows.Forms.Button()
        Me.printOption = New System.Windows.Forms.Button()
        CType(Me.titleBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.minimize.TabIndex = 4
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
        Me.close_btn.TabIndex = 3
        Me.close_btn.UseVisualStyleBackColor = True
        '
        'titleBox
        '
        Me.titleBox.Image = Global.theia_2.My.Resources.Resources.title
        Me.titleBox.Location = New System.Drawing.Point(45, 80)
        Me.titleBox.Name = "titleBox"
        Me.titleBox.Size = New System.Drawing.Size(309, 35)
        Me.titleBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.titleBox.TabIndex = 2
        Me.titleBox.TabStop = False
        '
        'scanOption
        '
        Me.scanOption.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.scanOption.BackgroundImage = Global.theia_2.My.Resources.Resources.scan_option
        Me.scanOption.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.scanOption.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.scanOption.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.scanOption.Location = New System.Drawing.Point(44, 302)
        Me.scanOption.Name = "scanOption"
        Me.scanOption.Size = New System.Drawing.Size(309, 45)
        Me.scanOption.TabIndex = 1
        Me.scanOption.UseVisualStyleBackColor = False
        '
        'printOption
        '
        Me.printOption.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.printOption.BackgroundImage = Global.theia_2.My.Resources.Resources.print_option
        Me.printOption.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.printOption.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.printOption.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.printOption.Location = New System.Drawing.Point(44, 227)
        Me.printOption.Name = "printOption"
        Me.printOption.Size = New System.Drawing.Size(309, 45)
        Me.printOption.TabIndex = 0
        Me.printOption.UseVisualStyleBackColor = False
        '
        'home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(400, 480)
        Me.Controls.Add(Me.minimize)
        Me.Controls.Add(Me.close_btn)
        Me.Controls.Add(Me.titleBox)
        Me.Controls.Add(Me.scanOption)
        Me.Controls.Add(Me.printOption)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "home"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Theia_OMR_Solution"
        CType(Me.titleBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents printOption As Button
    Friend WithEvents scanOption As Button
    Friend WithEvents titleBox As PictureBox
    Friend WithEvents close_btn As Button
    Friend WithEvents minimize As Button
End Class
