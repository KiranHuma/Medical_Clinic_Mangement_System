﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login_Frm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login_Frm))
        Dim BorderEdges3 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim StateProperties17 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties18 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties19 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties20 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties21 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties22 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties23 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties24 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Me.button2 = New System.Windows.Forms.Label()
        Me.label7 = New System.Windows.Forms.Label()
        Me.label6 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.selectUser = New System.Windows.Forms.ComboBox()
        Me.loginBtn = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.txtPass = New Bunifu.UI.WinForms.BunifuTextBox()
        Me.txtUsername = New Bunifu.UI.WinForms.BunifuTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'button2
        '
        Me.button2.AutoSize = True
        Me.button2.BackColor = System.Drawing.Color.Transparent
        Me.button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button2.ForeColor = System.Drawing.Color.Black
        Me.button2.Location = New System.Drawing.Point(772, 397)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(75, 20)
        Me.button2.TabIndex = 102
        Me.button2.Text = "&Sign Up"
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.BackColor = System.Drawing.Color.Transparent
        Me.label7.Location = New System.Drawing.Point(646, 401)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(120, 16)
        Me.label7.TabIndex = 101
        Me.label7.Text = "Not a member yet?"
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.BackColor = System.Drawing.Color.Transparent
        Me.label6.Location = New System.Drawing.Point(539, 370)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(44, 16)
        Me.label6.TabIndex = 94
        Me.label6.Text = "label6"
        Me.label6.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(97, 123)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(328, 307)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 104
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Monotype Corsiva", 48.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label4.Location = New System.Drawing.Point(198, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(477, 97)
        Me.Label4.TabIndex = 105
        Me.Label4.Text = "Ata Poly Clinic"
        '
        'selectUser
        '
        Me.selectUser.BackColor = System.Drawing.Color.White
        Me.selectUser.DisplayMember = "Select User"
        Me.selectUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.selectUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.selectUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.selectUser.ForeColor = System.Drawing.Color.Black
        Me.selectUser.FormattingEnabled = True
        Me.selectUser.Items.AddRange(New Object() {"User", "Admin"})
        Me.selectUser.Location = New System.Drawing.Point(526, 165)
        Me.selectUser.Name = "selectUser"
        Me.selectUser.Size = New System.Drawing.Size(316, 28)
        Me.selectUser.TabIndex = 0
        '
        'loginBtn
        '
        Me.loginBtn.AllowAnimations = True
        Me.loginBtn.AllowMouseEffects = True
        Me.loginBtn.AllowToggling = False
        Me.loginBtn.AnimationSpeed = 200
        Me.loginBtn.AutoGenerateColors = False
        Me.loginBtn.AutoRoundBorders = True
        Me.loginBtn.AutoSizeLeftIcon = False
        Me.loginBtn.AutoSizeRightIcon = False
        Me.loginBtn.BackColor = System.Drawing.Color.Transparent
        Me.loginBtn.BackColor1 = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.loginBtn.BackgroundImage = CType(resources.GetObject("loginBtn.BackgroundImage"), System.Drawing.Image)
        Me.loginBtn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.loginBtn.ButtonText = "Login"
        Me.loginBtn.ButtonTextMarginLeft = 0
        Me.loginBtn.ColorContrastOnClick = 45
        Me.loginBtn.ColorContrastOnHover = 45
        Me.loginBtn.Cursor = System.Windows.Forms.Cursors.Default
        BorderEdges3.BottomLeft = True
        BorderEdges3.BottomRight = False
        BorderEdges3.TopLeft = False
        BorderEdges3.TopRight = False
        Me.loginBtn.CustomizableEdges = BorderEdges3
        Me.loginBtn.DialogResult = System.Windows.Forms.DialogResult.None
        Me.loginBtn.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.loginBtn.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.loginBtn.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.loginBtn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.loginBtn.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginBtn.ForeColor = System.Drawing.Color.White
        Me.loginBtn.IconLeftAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.loginBtn.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.loginBtn.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.loginBtn.IconMarginLeft = 11
        Me.loginBtn.IconPadding = 10
        Me.loginBtn.IconRightAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.loginBtn.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.loginBtn.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.loginBtn.IconSize = 25
        Me.loginBtn.IdleBorderColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.loginBtn.IdleBorderRadius = 37
        Me.loginBtn.IdleBorderThickness = 1
        Me.loginBtn.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.loginBtn.IdleIconLeftImage = Nothing
        Me.loginBtn.IdleIconRightImage = Nothing
        Me.loginBtn.IndicateFocus = False
        Me.loginBtn.Location = New System.Drawing.Point(526, 291)
        Me.loginBtn.Name = "loginBtn"
        Me.loginBtn.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.loginBtn.OnDisabledState.BorderRadius = 1
        Me.loginBtn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.loginBtn.OnDisabledState.BorderThickness = 1
        Me.loginBtn.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.loginBtn.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.loginBtn.OnDisabledState.IconLeftImage = Nothing
        Me.loginBtn.OnDisabledState.IconRightImage = Nothing
        Me.loginBtn.onHoverState.BorderColor = System.Drawing.Color.Turquoise
        Me.loginBtn.onHoverState.BorderRadius = 1
        Me.loginBtn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.loginBtn.onHoverState.BorderThickness = 1
        Me.loginBtn.onHoverState.FillColor = System.Drawing.Color.Turquoise
        Me.loginBtn.onHoverState.ForeColor = System.Drawing.Color.White
        Me.loginBtn.onHoverState.IconLeftImage = Nothing
        Me.loginBtn.onHoverState.IconRightImage = Nothing
        Me.loginBtn.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.loginBtn.OnIdleState.BorderRadius = 1
        Me.loginBtn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.loginBtn.OnIdleState.BorderThickness = 1
        Me.loginBtn.OnIdleState.FillColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.loginBtn.OnIdleState.ForeColor = System.Drawing.Color.White
        Me.loginBtn.OnIdleState.IconLeftImage = Nothing
        Me.loginBtn.OnIdleState.IconRightImage = Nothing
        Me.loginBtn.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.loginBtn.OnPressedState.BorderRadius = 1
        Me.loginBtn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.loginBtn.OnPressedState.BorderThickness = 1
        Me.loginBtn.OnPressedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.loginBtn.OnPressedState.ForeColor = System.Drawing.Color.White
        Me.loginBtn.OnPressedState.IconLeftImage = Nothing
        Me.loginBtn.OnPressedState.IconRightImage = Nothing
        Me.loginBtn.Size = New System.Drawing.Size(321, 39)
        Me.loginBtn.TabIndex = 106
        Me.loginBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.loginBtn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.loginBtn.TextMarginLeft = 0
        Me.loginBtn.TextPadding = New System.Windows.Forms.Padding(0)
        Me.loginBtn.UseDefaultRadiusAndThickness = True
        '
        'txtPass
        '
        Me.txtPass.AcceptsReturn = False
        Me.txtPass.AcceptsTab = False
        Me.txtPass.AnimationSpeed = 200
        Me.txtPass.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.txtPass.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.txtPass.BackColor = System.Drawing.Color.White
        Me.txtPass.BackgroundImage = CType(resources.GetObject("txtPass.BackgroundImage"), System.Drawing.Image)
        Me.txtPass.BorderColorActive = System.Drawing.Color.DodgerBlue
        Me.txtPass.BorderColorDisabled = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.txtPass.BorderColorHover = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPass.BorderColorIdle = System.Drawing.Color.Silver
        Me.txtPass.BorderRadius = 1
        Me.txtPass.BorderThickness = 1
        Me.txtPass.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtPass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPass.DefaultFont = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.txtPass.DefaultText = ""
        Me.txtPass.FillColor = System.Drawing.Color.White
        Me.txtPass.HideSelection = True
        Me.txtPass.IconLeft = Nothing
        Me.txtPass.IconLeftCursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPass.IconPadding = 3
        Me.txtPass.IconRight = CType(resources.GetObject("txtPass.IconRight"), System.Drawing.Image)
        Me.txtPass.IconRightCursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPass.Lines = New String(-1) {}
        Me.txtPass.Location = New System.Drawing.Point(526, 245)
        Me.txtPass.MaxLength = 32767
        Me.txtPass.MinimumSize = New System.Drawing.Size(1, 1)
        Me.txtPass.Modified = False
        Me.txtPass.Multiline = False
        Me.txtPass.Name = "txtPass"
        StateProperties17.BorderColor = System.Drawing.Color.LightSeaGreen
        StateProperties17.FillColor = System.Drawing.Color.Empty
        StateProperties17.ForeColor = System.Drawing.Color.Empty
        StateProperties17.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.txtPass.OnActiveState = StateProperties17
        StateProperties18.BorderColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        StateProperties18.FillColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        StateProperties18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        StateProperties18.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.txtPass.OnDisabledState = StateProperties18
        StateProperties19.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        StateProperties19.FillColor = System.Drawing.Color.Empty
        StateProperties19.ForeColor = System.Drawing.Color.Empty
        StateProperties19.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.txtPass.OnHoverState = StateProperties19
        StateProperties20.BorderColor = System.Drawing.Color.Silver
        StateProperties20.FillColor = System.Drawing.Color.White
        StateProperties20.ForeColor = System.Drawing.Color.Empty
        StateProperties20.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.txtPass.OnIdleState = StateProperties20
        Me.txtPass.Padding = New System.Windows.Forms.Padding(3)
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPass.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.txtPass.PlaceholderText = "Enter Password"
        Me.txtPass.ReadOnly = False
        Me.txtPass.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPass.SelectedText = ""
        Me.txtPass.SelectionLength = 0
        Me.txtPass.SelectionStart = 0
        Me.txtPass.ShortcutsEnabled = True
        Me.txtPass.Size = New System.Drawing.Size(316, 40)
        Me.txtPass.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Material
        Me.txtPass.TabIndex = 3
        Me.txtPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtPass.TextMarginBottom = 0
        Me.txtPass.TextMarginLeft = 3
        Me.txtPass.TextMarginTop = 0
        Me.txtPass.TextPlaceholder = "Enter Password"
        Me.txtPass.UseSystemPasswordChar = False
        Me.txtPass.WordWrap = True
        '
        'txtUsername
        '
        Me.txtUsername.AcceptsReturn = False
        Me.txtUsername.AcceptsTab = False
        Me.txtUsername.AnimationSpeed = 200
        Me.txtUsername.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.txtUsername.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.txtUsername.BackColor = System.Drawing.Color.White
        Me.txtUsername.BackgroundImage = CType(resources.GetObject("txtUsername.BackgroundImage"), System.Drawing.Image)
        Me.txtUsername.BorderColorActive = System.Drawing.Color.DodgerBlue
        Me.txtUsername.BorderColorDisabled = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.txtUsername.BorderColorHover = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUsername.BorderColorIdle = System.Drawing.Color.Silver
        Me.txtUsername.BorderRadius = 1
        Me.txtUsername.BorderThickness = 1
        Me.txtUsername.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUsername.DefaultFont = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.txtUsername.DefaultText = ""
        Me.txtUsername.FillColor = System.Drawing.Color.White
        Me.txtUsername.HideSelection = True
        Me.txtUsername.IconLeft = Nothing
        Me.txtUsername.IconLeftCursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUsername.IconPadding = 3
        Me.txtUsername.IconRight = CType(resources.GetObject("txtUsername.IconRight"), System.Drawing.Image)
        Me.txtUsername.IconRightCursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUsername.Lines = New String(-1) {}
        Me.txtUsername.Location = New System.Drawing.Point(526, 199)
        Me.txtUsername.MaxLength = 32767
        Me.txtUsername.MinimumSize = New System.Drawing.Size(1, 1)
        Me.txtUsername.Modified = False
        Me.txtUsername.Multiline = False
        Me.txtUsername.Name = "txtUsername"
        StateProperties21.BorderColor = System.Drawing.Color.LightSeaGreen
        StateProperties21.FillColor = System.Drawing.Color.Empty
        StateProperties21.ForeColor = System.Drawing.Color.Empty
        StateProperties21.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.txtUsername.OnActiveState = StateProperties21
        StateProperties22.BorderColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        StateProperties22.FillColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        StateProperties22.ForeColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        StateProperties22.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.txtUsername.OnDisabledState = StateProperties22
        StateProperties23.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        StateProperties23.FillColor = System.Drawing.Color.Empty
        StateProperties23.ForeColor = System.Drawing.Color.Empty
        StateProperties23.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.txtUsername.OnHoverState = StateProperties23
        StateProperties24.BorderColor = System.Drawing.Color.Silver
        StateProperties24.FillColor = System.Drawing.Color.White
        StateProperties24.ForeColor = System.Drawing.Color.Empty
        StateProperties24.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.txtUsername.OnIdleState = StateProperties24
        Me.txtUsername.Padding = New System.Windows.Forms.Padding(3)
        Me.txtUsername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUsername.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.txtUsername.PlaceholderText = "Enter Username"
        Me.txtUsername.ReadOnly = False
        Me.txtUsername.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtUsername.SelectedText = ""
        Me.txtUsername.SelectionLength = 0
        Me.txtUsername.SelectionStart = 0
        Me.txtUsername.ShortcutsEnabled = True
        Me.txtUsername.Size = New System.Drawing.Size(316, 40)
        Me.txtUsername.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Material
        Me.txtUsername.TabIndex = 108
        Me.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtUsername.TextMarginBottom = 0
        Me.txtUsername.TextMarginLeft = 3
        Me.txtUsername.TextMarginTop = 0
        Me.txtUsername.TextPlaceholder = "Enter Username"
        Me.txtUsername.UseSystemPasswordChar = False
        Me.txtUsername.WordWrap = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(762, 397)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(14, 20)
        Me.Label1.TabIndex = 109
        Me.Label1.Text = "|"
        '
        'Login_Frm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(898, 479)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.selectUser)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.loginBtn)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.button2)
        Me.Controls.Add(Me.label7)
        Me.Controls.Add(Me.label6)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login_Frm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents button2 As Label
    Private WithEvents label7 As Label
    Private WithEvents label6 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents selectUser As ComboBox
    Friend WithEvents loginBtn As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents txtPass As Bunifu.UI.WinForms.BunifuTextBox
    Friend WithEvents txtUsername As Bunifu.UI.WinForms.BunifuTextBox
    Private WithEvents Label1 As Label
End Class
