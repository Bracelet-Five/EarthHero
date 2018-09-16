<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Avatar2 = New System.Windows.Forms.PictureBox()
        Me.Avatar1 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.Avatar2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Avatar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(196, 644)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(215, 87)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Select"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Avatar2
        '
        Me.Avatar2.BackColor = System.Drawing.Color.Transparent
        Me.Avatar2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Avatar2.Enabled = False
        Me.Avatar2.Image = Global.WindowsApp1.My.Resources.Resources.avatar2
        Me.Avatar2.Location = New System.Drawing.Point(155, 309)
        Me.Avatar2.Name = "Avatar2"
        Me.Avatar2.Size = New System.Drawing.Size(284, 263)
        Me.Avatar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Avatar2.TabIndex = 6
        Me.Avatar2.TabStop = False
        Me.Avatar2.Visible = False
        '
        'Avatar1
        '
        Me.Avatar1.BackColor = System.Drawing.Color.Transparent
        Me.Avatar1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Avatar1.Image = Global.WindowsApp1.My.Resources.Resources.avatar1
        Me.Avatar1.Location = New System.Drawing.Point(139, 309)
        Me.Avatar1.Name = "Avatar1"
        Me.Avatar1.Size = New System.Drawing.Size(284, 263)
        Me.Avatar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Avatar1.TabIndex = 9
        Me.Avatar1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe Print", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(107, 57)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(401, 75)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Sign up sucessful!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(111, 234)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(379, 50)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Please select your avatar:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button4
        '
        Me.Button4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Button4.BackColor = System.Drawing.Color.Transparent
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.142858!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.Location = New System.Drawing.Point(445, 366)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(103, 186)
        Me.Button4.TabIndex = 12
        Me.Button4.UseCompatibleTextRendering = True
        Me.Button4.UseMnemonic = False
        Me.Button4.UseVisualStyleBackColor = False
        Me.Button4.UseWaitCursor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.142858!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.DimGray
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(22, 357)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(181, 205)
        Me.Button1.TabIndex = 13
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.White
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.Font = New System.Drawing.Font("Segoe Print", 14.14286!)
        Me.Button3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button3.Location = New System.Drawing.Point(166, 627)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(299, 108)
        Me.Button3.TabIndex = 14
        Me.Button3.Text = "Select"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.screen1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(616, 896)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Avatar1)
        Me.Controls.Add(Me.Avatar2)
        Me.DoubleBuffered = True
        Me.MinimumSize = New System.Drawing.Size(640, 960)
        Me.Name = "Form3"
        Me.Text = "Form3"
        CType(Me.Avatar2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Avatar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button2 As Button
    Friend WithEvents Avatar2 As PictureBox
    Friend WithEvents Avatar1 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
End Class
