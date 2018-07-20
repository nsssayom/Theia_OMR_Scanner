<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class previewImage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(previewImage))
        Me.minimize = New System.Windows.Forms.Button()
        Me.close_btn = New System.Windows.Forms.Button()
        Me.previewBox = New System.Windows.Forms.PictureBox()
        CType(Me.previewBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'minimize
        '
        Me.minimize.BackgroundImage = Global.theia_2.My.Resources.Resources.close_yellow
        Me.minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.minimize.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.minimize.Location = New System.Drawing.Point(434, 12)
        Me.minimize.Name = "minimize"
        Me.minimize.Size = New System.Drawing.Size(25, 23)
        Me.minimize.TabIndex = 14
        Me.minimize.UseVisualStyleBackColor = True
        '
        'close_btn
        '
        Me.close_btn.BackgroundImage = Global.theia_2.My.Resources.Resources.close
        Me.close_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.close_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.close_btn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.close_btn.Location = New System.Drawing.Point(463, 12)
        Me.close_btn.Name = "close_btn"
        Me.close_btn.Size = New System.Drawing.Size(25, 23)
        Me.close_btn.TabIndex = 13
        Me.close_btn.UseVisualStyleBackColor = True
        '
        'previewBox
        '
        Me.previewBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.previewBox.Location = New System.Drawing.Point(0, 0)
        Me.previewBox.Name = "previewBox"
        Me.previewBox.Size = New System.Drawing.Size(500, 700)
        Me.previewBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.previewBox.TabIndex = 0
        Me.previewBox.TabStop = False
        '
        'previewImage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(500, 700)
        Me.Controls.Add(Me.minimize)
        Me.Controls.Add(Me.close_btn)
        Me.Controls.Add(Me.previewBox)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "previewImage"
        Me.Text = "previewImage"
        CType(Me.previewBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents previewBox As PictureBox
    Friend WithEvents minimize As Button
    Friend WithEvents close_btn As Button
End Class
