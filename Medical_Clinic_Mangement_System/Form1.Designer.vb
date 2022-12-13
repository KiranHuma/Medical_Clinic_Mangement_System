<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.button2 = New System.Windows.Forms.Label()
        Me.label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.selectUser = New System.Windows.Forms.ComboBox()
        Me.panel3 = New System.Windows.Forms.Panel()
        Me.pictureBox3 = New System.Windows.Forms.PictureBox()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.pictureBox2 = New System.Windows.Forms.PictureBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.label6 = New System.Windows.Forms.Label()
        Me.loginBtn = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.panel3.SuspendLayout()
        CType(Me.pictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'button2
        '
        Me.button2.AutoSize = True
        Me.button2.BackColor = System.Drawing.Color.Transparent
        Me.button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button2.ForeColor = System.Drawing.Color.Black
        Me.button2.Location = New System.Drawing.Point(494, 410)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(75, 20)
        Me.button2.TabIndex = 102
        Me.button2.Text = "&Sign Up"
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.BackColor = System.Drawing.Color.Transparent
        Me.label7.Location = New System.Drawing.Point(531, 413)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(123, 16)
        Me.label7.TabIndex = 101
        Me.label7.Text = "Not a member yet?|"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(424, 272)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 16)
        Me.Label3.TabIndex = 100
        Me.Label3.Text = "Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(424, 223)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 16)
        Me.Label2.TabIndex = 99
        Me.Label2.Text = "UserName"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(424, 173)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 16)
        Me.Label1.TabIndex = 98
        Me.Label1.Text = "Select User"
        '
        'selectUser
        '
        Me.selectUser.BackColor = System.Drawing.Color.White
        Me.selectUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.selectUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.selectUser.ForeColor = System.Drawing.Color.Black
        Me.selectUser.FormattingEnabled = True
        Me.selectUser.Items.AddRange(New Object() {"User", "Admin"})
        Me.selectUser.Location = New System.Drawing.Point(539, 170)
        Me.selectUser.Name = "selectUser"
        Me.selectUser.Size = New System.Drawing.Size(269, 24)
        Me.selectUser.TabIndex = 97
        '
        'panel3
        '
        Me.panel3.BackColor = System.Drawing.Color.White
        Me.panel3.Controls.Add(Me.pictureBox3)
        Me.panel3.Controls.Add(Me.txtPass)
        Me.panel3.Location = New System.Drawing.Point(539, 252)
        Me.panel3.Name = "panel3"
        Me.panel3.Size = New System.Drawing.Size(272, 37)
        Me.panel3.TabIndex = 96
        '
        'pictureBox3
        '
        Me.pictureBox3.BackColor = System.Drawing.Color.White
        Me.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pictureBox3.Image = CType(resources.GetObject("pictureBox3.Image"), System.Drawing.Image)
        Me.pictureBox3.Location = New System.Drawing.Point(239, 2)
        Me.pictureBox3.Name = "pictureBox3"
        Me.pictureBox3.Size = New System.Drawing.Size(27, 26)
        Me.pictureBox3.TabIndex = 2
        Me.pictureBox3.TabStop = False
        '
        'txtPass
        '
        Me.txtPass.BackColor = System.Drawing.Color.White
        Me.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPass.Font = New System.Drawing.Font("Trebuchet MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPass.ForeColor = System.Drawing.Color.Black
        Me.txtPass.Location = New System.Drawing.Point(5, 6)
        Me.txtPass.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtPass.Multiline = True
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPass.Size = New System.Drawing.Size(228, 27)
        Me.txtPass.TabIndex = 47
        Me.txtPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Controls.Add(Me.pictureBox2)
        Me.Panel4.Controls.Add(Me.txtUsername)
        Me.Panel4.Location = New System.Drawing.Point(539, 209)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(272, 37)
        Me.Panel4.TabIndex = 95
        '
        'pictureBox2
        '
        Me.pictureBox2.BackColor = System.Drawing.Color.White
        Me.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pictureBox2.Image = CType(resources.GetObject("pictureBox2.Image"), System.Drawing.Image)
        Me.pictureBox2.Location = New System.Drawing.Point(239, 3)
        Me.pictureBox2.Name = "pictureBox2"
        Me.pictureBox2.Size = New System.Drawing.Size(27, 27)
        Me.pictureBox2.TabIndex = 2
        Me.pictureBox2.TabStop = False
        '
        'txtUsername
        '
        Me.txtUsername.BackColor = System.Drawing.Color.White
        Me.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUsername.Font = New System.Drawing.Font("Trebuchet MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.ForeColor = System.Drawing.Color.Black
        Me.txtUsername.Location = New System.Drawing.Point(6, 4)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtUsername.Multiline = True
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(224, 27)
        Me.txtUsername.TabIndex = 46
        Me.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.BackColor = System.Drawing.Color.Transparent
        Me.label6.Location = New System.Drawing.Point(434, 355)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(44, 16)
        Me.label6.TabIndex = 94
        Me.label6.Text = "label6"
        Me.label6.Visible = False
        '
        'loginBtn
        '
        Me.loginBtn.BackColor = System.Drawing.Color.RoyalBlue
        Me.loginBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.loginBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.loginBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed
        Me.loginBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed
        Me.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.loginBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginBtn.ForeColor = System.Drawing.Color.White
        Me.loginBtn.Location = New System.Drawing.Point(539, 305)
        Me.loginBtn.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.loginBtn.Name = "loginBtn"
        Me.loginBtn.Size = New System.Drawing.Size(272, 34)
        Me.loginBtn.TabIndex = 93
        Me.loginBtn.Text = "&Login"
        Me.loginBtn.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(35, 99)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(383, 358)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 104
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Monotype Corsiva", 48.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(438, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(503, 97)
        Me.Label4.TabIndex = 105
        Me.Label4.Text = "Atta Poly Clinic"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(988, 479)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.button2)
        Me.Controls.Add(Me.label7)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.selectUser)
        Me.Controls.Add(Me.panel3)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.label6)
        Me.Controls.Add(Me.loginBtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.panel3.ResumeLayout(False)
        Me.panel3.PerformLayout()
        CType(Me.pictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents button2 As Label
    Private WithEvents label7 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents selectUser As ComboBox
    Private WithEvents panel3 As Panel
    Private WithEvents pictureBox3 As PictureBox
    Friend WithEvents txtPass As TextBox
    Private WithEvents Panel4 As Panel
    Private WithEvents pictureBox2 As PictureBox
    Friend WithEvents txtUsername As TextBox
    Private WithEvents label6 As Label
    Friend WithEvents loginBtn As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
End Class
