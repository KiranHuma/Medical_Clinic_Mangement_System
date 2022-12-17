<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class manage_Inventory_Frm
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(manage_Inventory_Frm))
        Dim StateProperties1 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties2 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties3 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties4 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.header = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BunifuImageButton2 = New Bunifu.UI.WinForms.BunifuImageButton()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtUsername = New Bunifu.UI.WinForms.BunifuTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BunifuDatePicker2 = New Bunifu.UI.WinForms.BunifuDatePicker()
        Me.BunifuDatePicker1 = New Bunifu.UI.WinForms.BunifuDatePicker()
        Me.header.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'header
        '
        Me.header.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.header.Controls.Add(Me.Label1)
        Me.header.Controls.Add(Me.BunifuImageButton2)
        Me.header.Dock = System.Windows.Forms.DockStyle.Top
        Me.header.Location = New System.Drawing.Point(0, 0)
        Me.header.Name = "header"
        Me.header.Size = New System.Drawing.Size(1371, 92)
        Me.header.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Sitka Text", 24.0!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(3, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(366, 58)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Manage Inventory"
        '
        'BunifuImageButton2
        '
        Me.BunifuImageButton2.ActiveImage = Nothing
        Me.BunifuImageButton2.AllowAnimations = True
        Me.BunifuImageButton2.AllowBuffering = False
        Me.BunifuImageButton2.AllowToggling = False
        Me.BunifuImageButton2.AllowZooming = True
        Me.BunifuImageButton2.AllowZoomingOnFocus = False
        Me.BunifuImageButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuImageButton2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuImageButton2.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BunifuImageButton2.ErrorImage = CType(resources.GetObject("BunifuImageButton2.ErrorImage"), System.Drawing.Image)
        Me.BunifuImageButton2.FadeWhenInactive = False
        Me.BunifuImageButton2.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal
        Me.BunifuImageButton2.Image = CType(resources.GetObject("BunifuImageButton2.Image"), System.Drawing.Image)
        Me.BunifuImageButton2.ImageActive = Nothing
        Me.BunifuImageButton2.ImageLocation = Nothing
        Me.BunifuImageButton2.ImageMargin = 20
        Me.BunifuImageButton2.ImageSize = New System.Drawing.Size(57, 47)
        Me.BunifuImageButton2.ImageZoomSize = New System.Drawing.Size(77, 67)
        Me.BunifuImageButton2.InitialImage = CType(resources.GetObject("BunifuImageButton2.InitialImage"), System.Drawing.Image)
        Me.BunifuImageButton2.Location = New System.Drawing.Point(1282, 10)
        Me.BunifuImageButton2.Name = "BunifuImageButton2"
        Me.BunifuImageButton2.Rotation = 0
        Me.BunifuImageButton2.ShowActiveImage = True
        Me.BunifuImageButton2.ShowCursorChanges = True
        Me.BunifuImageButton2.ShowImageBorders = False
        Me.BunifuImageButton2.ShowSizeMarkers = False
        Me.BunifuImageButton2.Size = New System.Drawing.Size(77, 67)
        Me.BunifuImageButton2.TabIndex = 3
        Me.BunifuImageButton2.ToolTipText = ""
        Me.BunifuImageButton2.WaitOnLoad = False
        Me.BunifuImageButton2.Zoom = 20
        Me.BunifuImageButton2.ZoomSpeed = 10
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(112, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(112, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(112, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(112, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.GridColor = System.Drawing.Color.White
        Me.DataGridView1.Location = New System.Drawing.Point(13, 246)
        Me.DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(112, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(112, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1334, 442)
        Me.DataGridView1.TabIndex = 116
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
        Me.txtUsername.Location = New System.Drawing.Point(13, 181)
        Me.txtUsername.MaxLength = 32767
        Me.txtUsername.MinimumSize = New System.Drawing.Size(1, 1)
        Me.txtUsername.Modified = False
        Me.txtUsername.Multiline = False
        Me.txtUsername.Name = "txtUsername"
        StateProperties1.BorderColor = System.Drawing.Color.LightSeaGreen
        StateProperties1.FillColor = System.Drawing.Color.Empty
        StateProperties1.ForeColor = System.Drawing.Color.Empty
        StateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.txtUsername.OnActiveState = StateProperties1
        StateProperties2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        StateProperties2.FillColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        StateProperties2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        StateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.txtUsername.OnDisabledState = StateProperties2
        StateProperties3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        StateProperties3.FillColor = System.Drawing.Color.Empty
        StateProperties3.ForeColor = System.Drawing.Color.Empty
        StateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.txtUsername.OnHoverState = StateProperties3
        StateProperties4.BorderColor = System.Drawing.Color.Silver
        StateProperties4.FillColor = System.Drawing.Color.White
        StateProperties4.ForeColor = System.Drawing.Color.Empty
        StateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.txtUsername.OnIdleState = StateProperties4
        Me.txtUsername.Padding = New System.Windows.Forms.Padding(3)
        Me.txtUsername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUsername.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.txtUsername.PlaceholderText = "Enter User"
        Me.txtUsername.ReadOnly = False
        Me.txtUsername.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtUsername.SelectedText = ""
        Me.txtUsername.SelectionLength = 0
        Me.txtUsername.SelectionStart = 0
        Me.txtUsername.ShortcutsEnabled = True
        Me.txtUsername.Size = New System.Drawing.Size(316, 40)
        Me.txtUsername.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Material
        Me.txtUsername.TabIndex = 115
        Me.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtUsername.TextMarginBottom = 0
        Me.txtUsername.TextMarginLeft = 3
        Me.txtUsername.TextMarginTop = 0
        Me.txtUsername.TextPlaceholder = "Enter User"
        Me.txtUsername.UseSystemPasswordChar = False
        Me.txtUsername.WordWrap = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(1011, 153)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 16)
        Me.Label3.TabIndex = 114
        Me.Label3.Text = "From"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(1011, 205)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(18, 16)
        Me.Label2.TabIndex = 113
        Me.Label2.Text = "to"
        '
        'BunifuDatePicker2
        '
        Me.BunifuDatePicker2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuDatePicker2.BorderRadius = 1
        Me.BunifuDatePicker2.Color = System.Drawing.Color.Silver
        Me.BunifuDatePicker2.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin
        Me.BunifuDatePicker2.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left
        Me.BunifuDatePicker2.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuDatePicker2.DisplayWeekNumbers = False
        Me.BunifuDatePicker2.DPHeight = 0
        Me.BunifuDatePicker2.FillDatePicker = False
        Me.BunifuDatePicker2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BunifuDatePicker2.ForeColor = System.Drawing.Color.Black
        Me.BunifuDatePicker2.Icon = CType(resources.GetObject("BunifuDatePicker2.Icon"), System.Drawing.Image)
        Me.BunifuDatePicker2.IconColor = System.Drawing.Color.Gray
        Me.BunifuDatePicker2.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right
        Me.BunifuDatePicker2.LeftTextMargin = 5
        Me.BunifuDatePicker2.Location = New System.Drawing.Point(1063, 189)
        Me.BunifuDatePicker2.MinimumSize = New System.Drawing.Size(0, 32)
        Me.BunifuDatePicker2.Name = "BunifuDatePicker2"
        Me.BunifuDatePicker2.Size = New System.Drawing.Size(284, 32)
        Me.BunifuDatePicker2.TabIndex = 112
        '
        'BunifuDatePicker1
        '
        Me.BunifuDatePicker1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuDatePicker1.BorderRadius = 1
        Me.BunifuDatePicker1.Color = System.Drawing.Color.Silver
        Me.BunifuDatePicker1.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin
        Me.BunifuDatePicker1.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left
        Me.BunifuDatePicker1.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuDatePicker1.DisplayWeekNumbers = False
        Me.BunifuDatePicker1.DPHeight = 0
        Me.BunifuDatePicker1.FillDatePicker = False
        Me.BunifuDatePicker1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BunifuDatePicker1.ForeColor = System.Drawing.Color.Black
        Me.BunifuDatePicker1.Icon = CType(resources.GetObject("BunifuDatePicker1.Icon"), System.Drawing.Image)
        Me.BunifuDatePicker1.IconColor = System.Drawing.Color.Gray
        Me.BunifuDatePicker1.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right
        Me.BunifuDatePicker1.LeftTextMargin = 5
        Me.BunifuDatePicker1.Location = New System.Drawing.Point(1063, 137)
        Me.BunifuDatePicker1.MinimumSize = New System.Drawing.Size(0, 32)
        Me.BunifuDatePicker1.Name = "BunifuDatePicker1"
        Me.BunifuDatePicker1.Size = New System.Drawing.Size(284, 32)
        Me.BunifuDatePicker1.TabIndex = 111
        '
        'manage_Inventory_Frm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1371, 719)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BunifuDatePicker2)
        Me.Controls.Add(Me.BunifuDatePicker1)
        Me.Controls.Add(Me.header)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "manage_Inventory_Frm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "manage_Inventory_Frm"
        Me.header.ResumeLayout(False)
        Me.header.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents header As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents BunifuImageButton2 As Bunifu.UI.WinForms.BunifuImageButton
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtUsername As Bunifu.UI.WinForms.BunifuTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BunifuDatePicker2 As Bunifu.UI.WinForms.BunifuDatePicker
    Friend WithEvents BunifuDatePicker1 As Bunifu.UI.WinForms.BunifuDatePicker
End Class
