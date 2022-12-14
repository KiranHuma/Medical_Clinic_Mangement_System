<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dashboard_Frm
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
        Me.components = New System.ComponentModel.Container()
        Dim BorderEdges1 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim BorderEdges2 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim BorderEdges3 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim BorderEdges4 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim Animation2 As Bunifu.UI.WinForms.BunifuAnimatorNS.Animation = New Bunifu.UI.WinForms.BunifuAnimatorNS.Animation()
        Dim Animation1 As Bunifu.UI.WinForms.BunifuAnimatorNS.Animation = New Bunifu.UI.WinForms.BunifuAnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dashboard_Frm))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.sidemenu = New System.Windows.Forms.Panel()
        Me.records_btn = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.logo1 = New System.Windows.Forms.Label()
        Me.manInventory_btn = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.addinventory_btn = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.inventory_btn = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.btnmenu = New Bunifu.UI.WinForms.BunifuImageButton()
        Me.logo = New System.Windows.Forms.PictureBox()
        Me.header = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BunifuImageButton2 = New Bunifu.UI.WinForms.BunifuImageButton()
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.logoAnimator = New Bunifu.UI.WinForms.BunifuTransition(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PanelAnimator = New Bunifu.UI.WinForms.BunifuTransition(Me.components)
        Me.sidemenu.SuspendLayout()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.header.SuspendLayout()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'sidemenu
        '
        Me.sidemenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.sidemenu.Controls.Add(Me.records_btn)
        Me.sidemenu.Controls.Add(Me.logo1)
        Me.sidemenu.Controls.Add(Me.manInventory_btn)
        Me.sidemenu.Controls.Add(Me.addinventory_btn)
        Me.sidemenu.Controls.Add(Me.inventory_btn)
        Me.sidemenu.Controls.Add(Me.btnmenu)
        Me.sidemenu.Controls.Add(Me.logo)
        Me.PanelAnimator.SetDecoration(Me.sidemenu, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.logoAnimator.SetDecoration(Me.sidemenu, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.sidemenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.sidemenu.Location = New System.Drawing.Point(0, 92)
        Me.sidemenu.Name = "sidemenu"
        Me.sidemenu.Size = New System.Drawing.Size(360, 721)
        Me.sidemenu.TabIndex = 0
        '
        'records_btn
        '
        Me.records_btn.AllowAnimations = True
        Me.records_btn.AllowMouseEffects = True
        Me.records_btn.AllowToggling = False
        Me.records_btn.AnimationSpeed = 200
        Me.records_btn.AutoGenerateColors = False
        Me.records_btn.AutoRoundBorders = False
        Me.records_btn.AutoSizeLeftIcon = True
        Me.records_btn.AutoSizeRightIcon = True
        Me.records_btn.BackColor = System.Drawing.Color.Transparent
        Me.records_btn.BackColor1 = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.records_btn.BackgroundImage = CType(resources.GetObject("records_btn.BackgroundImage"), System.Drawing.Image)
        Me.records_btn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.records_btn.ButtonText = "Records"
        Me.records_btn.ButtonTextMarginLeft = 0
        Me.records_btn.ColorContrastOnClick = 45
        Me.records_btn.ColorContrastOnHover = 45
        Me.records_btn.Cursor = System.Windows.Forms.Cursors.Default
        BorderEdges1.BottomLeft = True
        BorderEdges1.BottomRight = True
        BorderEdges1.TopLeft = True
        BorderEdges1.TopRight = True
        Me.records_btn.CustomizableEdges = BorderEdges1
        Me.PanelAnimator.SetDecoration(Me.records_btn, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.logoAnimator.SetDecoration(Me.records_btn, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.records_btn.DialogResult = System.Windows.Forms.DialogResult.None
        Me.records_btn.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.records_btn.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.records_btn.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.records_btn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.records_btn.Font = New System.Drawing.Font("Sitka Banner", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.records_btn.ForeColor = System.Drawing.Color.White
        Me.records_btn.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.records_btn.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.records_btn.IconLeftPadding = New System.Windows.Forms.Padding(19, 3, 3, 3)
        Me.records_btn.IconMarginLeft = 11
        Me.records_btn.IconPadding = -7
        Me.records_btn.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.records_btn.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.records_btn.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.records_btn.IconSize = 60
        Me.records_btn.IdleBorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.records_btn.IdleBorderRadius = 1
        Me.records_btn.IdleBorderThickness = 1
        Me.records_btn.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.records_btn.IdleIconLeftImage = CType(resources.GetObject("records_btn.IdleIconLeftImage"), System.Drawing.Image)
        Me.records_btn.IdleIconRightImage = Nothing
        Me.records_btn.IndicateFocus = False
        Me.records_btn.Location = New System.Drawing.Point(-9, 148)
        Me.records_btn.Name = "records_btn"
        Me.records_btn.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.records_btn.OnDisabledState.BorderRadius = 1
        Me.records_btn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.records_btn.OnDisabledState.BorderThickness = 1
        Me.records_btn.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.records_btn.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.records_btn.OnDisabledState.IconLeftImage = Nothing
        Me.records_btn.OnDisabledState.IconRightImage = Nothing
        Me.records_btn.onHoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.records_btn.onHoverState.BorderRadius = 1
        Me.records_btn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.records_btn.onHoverState.BorderThickness = 1
        Me.records_btn.onHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.records_btn.onHoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.records_btn.onHoverState.IconLeftImage = Nothing
        Me.records_btn.onHoverState.IconRightImage = Nothing
        Me.records_btn.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.records_btn.OnIdleState.BorderRadius = 1
        Me.records_btn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.records_btn.OnIdleState.BorderThickness = 1
        Me.records_btn.OnIdleState.FillColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.records_btn.OnIdleState.ForeColor = System.Drawing.Color.White
        Me.records_btn.OnIdleState.IconLeftImage = CType(resources.GetObject("records_btn.OnIdleState.IconLeftImage"), System.Drawing.Image)
        Me.records_btn.OnIdleState.IconRightImage = Nothing
        Me.records_btn.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.records_btn.OnPressedState.BorderRadius = 1
        Me.records_btn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.records_btn.OnPressedState.BorderThickness = 1
        Me.records_btn.OnPressedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.records_btn.OnPressedState.ForeColor = System.Drawing.Color.White
        Me.records_btn.OnPressedState.IconLeftImage = Nothing
        Me.records_btn.OnPressedState.IconRightImage = Nothing
        Me.records_btn.Size = New System.Drawing.Size(365, 39)
        Me.records_btn.TabIndex = 48
        Me.records_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.records_btn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.records_btn.TextMarginLeft = 0
        Me.records_btn.TextPadding = New System.Windows.Forms.Padding(-16, 2, 0, 0)
        Me.records_btn.UseDefaultRadiusAndThickness = True
        '
        'logo1
        '
        Me.logo1.AutoSize = True
        Me.logo1.BackColor = System.Drawing.Color.Transparent
        Me.logoAnimator.SetDecoration(Me.logo1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.PanelAnimator.SetDecoration(Me.logo1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.logo1.Font = New System.Drawing.Font("Sitka Text", 24.0!)
        Me.logo1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.logo1.Location = New System.Drawing.Point(25, 78)
        Me.logo1.Name = "logo1"
        Me.logo1.Size = New System.Drawing.Size(311, 58)
        Me.logo1.TabIndex = 47
        Me.logo1.Text = "Atta Poly Clinic"
        '
        'manInventory_btn
        '
        Me.manInventory_btn.AllowAnimations = True
        Me.manInventory_btn.AllowMouseEffects = True
        Me.manInventory_btn.AllowToggling = False
        Me.manInventory_btn.AnimationSpeed = 200
        Me.manInventory_btn.AutoGenerateColors = False
        Me.manInventory_btn.AutoRoundBorders = False
        Me.manInventory_btn.AutoSizeLeftIcon = True
        Me.manInventory_btn.AutoSizeRightIcon = True
        Me.manInventory_btn.BackColor = System.Drawing.Color.Transparent
        Me.manInventory_btn.BackColor1 = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.manInventory_btn.BackgroundImage = CType(resources.GetObject("manInventory_btn.BackgroundImage"), System.Drawing.Image)
        Me.manInventory_btn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.manInventory_btn.ButtonText = "Manage Inventory"
        Me.manInventory_btn.ButtonTextMarginLeft = 0
        Me.manInventory_btn.ColorContrastOnClick = 45
        Me.manInventory_btn.ColorContrastOnHover = 45
        Me.manInventory_btn.Cursor = System.Windows.Forms.Cursors.Default
        BorderEdges2.BottomLeft = True
        BorderEdges2.BottomRight = True
        BorderEdges2.TopLeft = True
        BorderEdges2.TopRight = True
        Me.manInventory_btn.CustomizableEdges = BorderEdges2
        Me.PanelAnimator.SetDecoration(Me.manInventory_btn, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.logoAnimator.SetDecoration(Me.manInventory_btn, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.manInventory_btn.DialogResult = System.Windows.Forms.DialogResult.None
        Me.manInventory_btn.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.manInventory_btn.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.manInventory_btn.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.manInventory_btn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.manInventory_btn.Font = New System.Drawing.Font("Sitka Banner", 12.0!, System.Drawing.FontStyle.Bold)
        Me.manInventory_btn.ForeColor = System.Drawing.Color.White
        Me.manInventory_btn.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.manInventory_btn.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.manInventory_btn.IconLeftPadding = New System.Windows.Forms.Padding(19, 3, 3, 3)
        Me.manInventory_btn.IconMarginLeft = 11
        Me.manInventory_btn.IconPadding = -7
        Me.manInventory_btn.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.manInventory_btn.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.manInventory_btn.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.manInventory_btn.IconSize = 60
        Me.manInventory_btn.IdleBorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.manInventory_btn.IdleBorderRadius = 1
        Me.manInventory_btn.IdleBorderThickness = 1
        Me.manInventory_btn.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.manInventory_btn.IdleIconLeftImage = CType(resources.GetObject("manInventory_btn.IdleIconLeftImage"), System.Drawing.Image)
        Me.manInventory_btn.IdleIconRightImage = Nothing
        Me.manInventory_btn.IndicateFocus = False
        Me.manInventory_btn.Location = New System.Drawing.Point(-9, 283)
        Me.manInventory_btn.Name = "manInventory_btn"
        Me.manInventory_btn.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.manInventory_btn.OnDisabledState.BorderRadius = 1
        Me.manInventory_btn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.manInventory_btn.OnDisabledState.BorderThickness = 1
        Me.manInventory_btn.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.manInventory_btn.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.manInventory_btn.OnDisabledState.IconLeftImage = Nothing
        Me.manInventory_btn.OnDisabledState.IconRightImage = Nothing
        Me.manInventory_btn.onHoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.manInventory_btn.onHoverState.BorderRadius = 1
        Me.manInventory_btn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.manInventory_btn.onHoverState.BorderThickness = 1
        Me.manInventory_btn.onHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.manInventory_btn.onHoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.manInventory_btn.onHoverState.IconLeftImage = Nothing
        Me.manInventory_btn.onHoverState.IconRightImage = Nothing
        Me.manInventory_btn.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.manInventory_btn.OnIdleState.BorderRadius = 1
        Me.manInventory_btn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.manInventory_btn.OnIdleState.BorderThickness = 1
        Me.manInventory_btn.OnIdleState.FillColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.manInventory_btn.OnIdleState.ForeColor = System.Drawing.Color.White
        Me.manInventory_btn.OnIdleState.IconLeftImage = CType(resources.GetObject("manInventory_btn.OnIdleState.IconLeftImage"), System.Drawing.Image)
        Me.manInventory_btn.OnIdleState.IconRightImage = Nothing
        Me.manInventory_btn.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.manInventory_btn.OnPressedState.BorderRadius = 1
        Me.manInventory_btn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.manInventory_btn.OnPressedState.BorderThickness = 1
        Me.manInventory_btn.OnPressedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.manInventory_btn.OnPressedState.ForeColor = System.Drawing.Color.White
        Me.manInventory_btn.OnPressedState.IconLeftImage = Nothing
        Me.manInventory_btn.OnPressedState.IconRightImage = Nothing
        Me.manInventory_btn.Size = New System.Drawing.Size(365, 39)
        Me.manInventory_btn.TabIndex = 5
        Me.manInventory_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.manInventory_btn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.manInventory_btn.TextMarginLeft = 0
        Me.manInventory_btn.TextPadding = New System.Windows.Forms.Padding(20, 2, 0, 0)
        Me.manInventory_btn.UseDefaultRadiusAndThickness = True
        '
        'addinventory_btn
        '
        Me.addinventory_btn.AllowAnimations = True
        Me.addinventory_btn.AllowMouseEffects = True
        Me.addinventory_btn.AllowToggling = False
        Me.addinventory_btn.AnimationSpeed = 200
        Me.addinventory_btn.AutoGenerateColors = False
        Me.addinventory_btn.AutoRoundBorders = False
        Me.addinventory_btn.AutoSizeLeftIcon = True
        Me.addinventory_btn.AutoSizeRightIcon = True
        Me.addinventory_btn.BackColor = System.Drawing.Color.Transparent
        Me.addinventory_btn.BackColor1 = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.addinventory_btn.BackgroundImage = CType(resources.GetObject("addinventory_btn.BackgroundImage"), System.Drawing.Image)
        Me.addinventory_btn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.addinventory_btn.ButtonText = "Add Inventory"
        Me.addinventory_btn.ButtonTextMarginLeft = 0
        Me.addinventory_btn.ColorContrastOnClick = 45
        Me.addinventory_btn.ColorContrastOnHover = 45
        Me.addinventory_btn.Cursor = System.Windows.Forms.Cursors.Default
        BorderEdges3.BottomLeft = True
        BorderEdges3.BottomRight = True
        BorderEdges3.TopLeft = True
        BorderEdges3.TopRight = True
        Me.addinventory_btn.CustomizableEdges = BorderEdges3
        Me.PanelAnimator.SetDecoration(Me.addinventory_btn, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.logoAnimator.SetDecoration(Me.addinventory_btn, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.addinventory_btn.DialogResult = System.Windows.Forms.DialogResult.None
        Me.addinventory_btn.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.addinventory_btn.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.addinventory_btn.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.addinventory_btn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.addinventory_btn.Font = New System.Drawing.Font("Sitka Banner", 12.0!, System.Drawing.FontStyle.Bold)
        Me.addinventory_btn.ForeColor = System.Drawing.Color.White
        Me.addinventory_btn.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.addinventory_btn.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.addinventory_btn.IconLeftPadding = New System.Windows.Forms.Padding(19, 3, 3, 3)
        Me.addinventory_btn.IconMarginLeft = 11
        Me.addinventory_btn.IconPadding = -7
        Me.addinventory_btn.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.addinventory_btn.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.addinventory_btn.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.addinventory_btn.IconSize = 60
        Me.addinventory_btn.IdleBorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.addinventory_btn.IdleBorderRadius = 1
        Me.addinventory_btn.IdleBorderThickness = 1
        Me.addinventory_btn.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.addinventory_btn.IdleIconLeftImage = CType(resources.GetObject("addinventory_btn.IdleIconLeftImage"), System.Drawing.Image)
        Me.addinventory_btn.IdleIconRightImage = Nothing
        Me.addinventory_btn.IndicateFocus = False
        Me.addinventory_btn.Location = New System.Drawing.Point(-9, 238)
        Me.addinventory_btn.Name = "addinventory_btn"
        Me.addinventory_btn.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.addinventory_btn.OnDisabledState.BorderRadius = 1
        Me.addinventory_btn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.addinventory_btn.OnDisabledState.BorderThickness = 1
        Me.addinventory_btn.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.addinventory_btn.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.addinventory_btn.OnDisabledState.IconLeftImage = Nothing
        Me.addinventory_btn.OnDisabledState.IconRightImage = Nothing
        Me.addinventory_btn.onHoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.addinventory_btn.onHoverState.BorderRadius = 1
        Me.addinventory_btn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.addinventory_btn.onHoverState.BorderThickness = 1
        Me.addinventory_btn.onHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.addinventory_btn.onHoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.addinventory_btn.onHoverState.IconLeftImage = Nothing
        Me.addinventory_btn.onHoverState.IconRightImage = Nothing
        Me.addinventory_btn.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.addinventory_btn.OnIdleState.BorderRadius = 1
        Me.addinventory_btn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.addinventory_btn.OnIdleState.BorderThickness = 1
        Me.addinventory_btn.OnIdleState.FillColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.addinventory_btn.OnIdleState.ForeColor = System.Drawing.Color.White
        Me.addinventory_btn.OnIdleState.IconLeftImage = CType(resources.GetObject("addinventory_btn.OnIdleState.IconLeftImage"), System.Drawing.Image)
        Me.addinventory_btn.OnIdleState.IconRightImage = Nothing
        Me.addinventory_btn.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.addinventory_btn.OnPressedState.BorderRadius = 1
        Me.addinventory_btn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.addinventory_btn.OnPressedState.BorderThickness = 1
        Me.addinventory_btn.OnPressedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.addinventory_btn.OnPressedState.ForeColor = System.Drawing.Color.White
        Me.addinventory_btn.OnPressedState.IconLeftImage = Nothing
        Me.addinventory_btn.OnPressedState.IconRightImage = Nothing
        Me.addinventory_btn.Size = New System.Drawing.Size(365, 39)
        Me.addinventory_btn.TabIndex = 4
        Me.addinventory_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.addinventory_btn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.addinventory_btn.TextMarginLeft = 0
        Me.addinventory_btn.TextPadding = New System.Windows.Forms.Padding(5, 2, 0, 0)
        Me.addinventory_btn.UseDefaultRadiusAndThickness = True
        '
        'inventory_btn
        '
        Me.inventory_btn.AllowAnimations = True
        Me.inventory_btn.AllowMouseEffects = True
        Me.inventory_btn.AllowToggling = False
        Me.inventory_btn.AnimationSpeed = 200
        Me.inventory_btn.AutoGenerateColors = False
        Me.inventory_btn.AutoRoundBorders = False
        Me.inventory_btn.AutoSizeLeftIcon = True
        Me.inventory_btn.AutoSizeRightIcon = True
        Me.inventory_btn.BackColor = System.Drawing.Color.Transparent
        Me.inventory_btn.BackColor1 = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.inventory_btn.BackgroundImage = CType(resources.GetObject("inventory_btn.BackgroundImage"), System.Drawing.Image)
        Me.inventory_btn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.inventory_btn.ButtonText = "Inventory"
        Me.inventory_btn.ButtonTextMarginLeft = 0
        Me.inventory_btn.ColorContrastOnClick = 45
        Me.inventory_btn.ColorContrastOnHover = 45
        Me.inventory_btn.Cursor = System.Windows.Forms.Cursors.Default
        BorderEdges4.BottomLeft = True
        BorderEdges4.BottomRight = True
        BorderEdges4.TopLeft = True
        BorderEdges4.TopRight = True
        Me.inventory_btn.CustomizableEdges = BorderEdges4
        Me.PanelAnimator.SetDecoration(Me.inventory_btn, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.logoAnimator.SetDecoration(Me.inventory_btn, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.inventory_btn.DialogResult = System.Windows.Forms.DialogResult.None
        Me.inventory_btn.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.inventory_btn.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.inventory_btn.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.inventory_btn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.inventory_btn.Font = New System.Drawing.Font("Sitka Banner", 12.0!, System.Drawing.FontStyle.Bold)
        Me.inventory_btn.ForeColor = System.Drawing.Color.White
        Me.inventory_btn.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.inventory_btn.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.inventory_btn.IconLeftPadding = New System.Windows.Forms.Padding(19, 3, 3, 3)
        Me.inventory_btn.IconMarginLeft = 11
        Me.inventory_btn.IconPadding = -7
        Me.inventory_btn.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.inventory_btn.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.inventory_btn.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.inventory_btn.IconSize = 60
        Me.inventory_btn.IdleBorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.inventory_btn.IdleBorderRadius = 1
        Me.inventory_btn.IdleBorderThickness = 1
        Me.inventory_btn.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.inventory_btn.IdleIconLeftImage = CType(resources.GetObject("inventory_btn.IdleIconLeftImage"), System.Drawing.Image)
        Me.inventory_btn.IdleIconRightImage = Nothing
        Me.inventory_btn.IndicateFocus = False
        Me.inventory_btn.Location = New System.Drawing.Point(-9, 193)
        Me.inventory_btn.Name = "inventory_btn"
        Me.inventory_btn.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.inventory_btn.OnDisabledState.BorderRadius = 1
        Me.inventory_btn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.inventory_btn.OnDisabledState.BorderThickness = 1
        Me.inventory_btn.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.inventory_btn.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.inventory_btn.OnDisabledState.IconLeftImage = Nothing
        Me.inventory_btn.OnDisabledState.IconRightImage = Nothing
        Me.inventory_btn.onHoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.inventory_btn.onHoverState.BorderRadius = 1
        Me.inventory_btn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.inventory_btn.onHoverState.BorderThickness = 1
        Me.inventory_btn.onHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.inventory_btn.onHoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.inventory_btn.onHoverState.IconLeftImage = Nothing
        Me.inventory_btn.onHoverState.IconRightImage = Nothing
        Me.inventory_btn.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.inventory_btn.OnIdleState.BorderRadius = 1
        Me.inventory_btn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.inventory_btn.OnIdleState.BorderThickness = 1
        Me.inventory_btn.OnIdleState.FillColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.inventory_btn.OnIdleState.ForeColor = System.Drawing.Color.White
        Me.inventory_btn.OnIdleState.IconLeftImage = CType(resources.GetObject("inventory_btn.OnIdleState.IconLeftImage"), System.Drawing.Image)
        Me.inventory_btn.OnIdleState.IconRightImage = Nothing
        Me.inventory_btn.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.inventory_btn.OnPressedState.BorderRadius = 1
        Me.inventory_btn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.inventory_btn.OnPressedState.BorderThickness = 1
        Me.inventory_btn.OnPressedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.inventory_btn.OnPressedState.ForeColor = System.Drawing.Color.White
        Me.inventory_btn.OnPressedState.IconLeftImage = Nothing
        Me.inventory_btn.OnPressedState.IconRightImage = Nothing
        Me.inventory_btn.Size = New System.Drawing.Size(365, 39)
        Me.inventory_btn.TabIndex = 3
        Me.inventory_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.inventory_btn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.inventory_btn.TextMarginLeft = 0
        Me.inventory_btn.TextPadding = New System.Windows.Forms.Padding(-10, 2, 0, 0)
        Me.inventory_btn.UseDefaultRadiusAndThickness = True
        '
        'btnmenu
        '
        Me.btnmenu.ActiveImage = Nothing
        Me.btnmenu.AllowAnimations = True
        Me.btnmenu.AllowBuffering = False
        Me.btnmenu.AllowToggling = False
        Me.btnmenu.AllowZooming = False
        Me.btnmenu.AllowZoomingOnFocus = False
        Me.btnmenu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnmenu.BackColor = System.Drawing.Color.Transparent
        Me.btnmenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PanelAnimator.SetDecoration(Me.btnmenu, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.logoAnimator.SetDecoration(Me.btnmenu, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.btnmenu.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnmenu.ErrorImage = CType(resources.GetObject("btnmenu.ErrorImage"), System.Drawing.Image)
        Me.btnmenu.FadeWhenInactive = False
        Me.btnmenu.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Horizontal
        Me.btnmenu.Image = CType(resources.GetObject("btnmenu.Image"), System.Drawing.Image)
        Me.btnmenu.ImageActive = Nothing
        Me.btnmenu.ImageLocation = Nothing
        Me.btnmenu.ImageMargin = 20
        Me.btnmenu.ImageSize = New System.Drawing.Size(58, 35)
        Me.btnmenu.ImageZoomSize = New System.Drawing.Size(78, 55)
        Me.btnmenu.InitialImage = CType(resources.GetObject("btnmenu.InitialImage"), System.Drawing.Image)
        Me.btnmenu.Location = New System.Drawing.Point(273, 0)
        Me.btnmenu.Name = "btnmenu"
        Me.btnmenu.Rotation = 0
        Me.btnmenu.ShowActiveImage = True
        Me.btnmenu.ShowCursorChanges = True
        Me.btnmenu.ShowImageBorders = True
        Me.btnmenu.ShowSizeMarkers = False
        Me.btnmenu.Size = New System.Drawing.Size(78, 55)
        Me.btnmenu.TabIndex = 1
        Me.btnmenu.ToolTipText = ""
        Me.btnmenu.WaitOnLoad = False
        Me.btnmenu.Zoom = 20
        Me.btnmenu.ZoomSpeed = 10
        '
        'logo
        '
        Me.logoAnimator.SetDecoration(Me.logo, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.PanelAnimator.SetDecoration(Me.logo, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.logo.Image = CType(resources.GetObject("logo.Image"), System.Drawing.Image)
        Me.logo.Location = New System.Drawing.Point(3, 6)
        Me.logo.Name = "logo"
        Me.logo.Size = New System.Drawing.Size(126, 69)
        Me.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.logo.TabIndex = 0
        Me.logo.TabStop = False
        '
        'header
        '
        Me.header.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.header.Controls.Add(Me.Label1)
        Me.header.Controls.Add(Me.BunifuImageButton2)
        Me.PanelAnimator.SetDecoration(Me.header, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.logoAnimator.SetDecoration(Me.header, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.header.Dock = System.Windows.Forms.DockStyle.Top
        Me.header.Location = New System.Drawing.Point(0, 0)
        Me.header.Name = "header"
        Me.header.Size = New System.Drawing.Size(1407, 92)
        Me.header.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.logoAnimator.SetDecoration(Me.Label1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.PanelAnimator.SetDecoration(Me.Label1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.Label1.Font = New System.Drawing.Font("Sitka Text", 24.0!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(3, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(225, 58)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Dashboard"
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
        Me.PanelAnimator.SetDecoration(Me.BunifuImageButton2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.logoAnimator.SetDecoration(Me.BunifuImageButton2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
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
        Me.BunifuImageButton2.Location = New System.Drawing.Point(1318, 10)
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
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me.header
        Me.BunifuDragControl1.Vertical = True
        '
        'logoAnimator
        '
        Me.logoAnimator.AnimationType = Bunifu.UI.WinForms.BunifuAnimatorNS.AnimationType.ScaleAndRotate
        Me.logoAnimator.Cursor = Nothing
        Animation2.AnimateOnlyDifferences = True
        Animation2.BlindCoeff = CType(resources.GetObject("Animation2.BlindCoeff"), System.Drawing.PointF)
        Animation2.LeafCoeff = 0!
        Animation2.MaxTime = 1.0!
        Animation2.MinTime = 0!
        Animation2.MosaicCoeff = CType(resources.GetObject("Animation2.MosaicCoeff"), System.Drawing.PointF)
        Animation2.MosaicShift = CType(resources.GetObject("Animation2.MosaicShift"), System.Drawing.PointF)
        Animation2.MosaicSize = 0
        Animation2.Padding = New System.Windows.Forms.Padding(30)
        Animation2.RotateCoeff = 0.5!
        Animation2.RotateLimit = 0.2!
        Animation2.ScaleCoeff = CType(resources.GetObject("Animation2.ScaleCoeff"), System.Drawing.PointF)
        Animation2.SlideCoeff = CType(resources.GetObject("Animation2.SlideCoeff"), System.Drawing.PointF)
        Animation2.TimeCoeff = 0!
        Animation2.TransparencyCoeff = 0!
        Me.logoAnimator.DefaultAnimation = Animation2
        '
        'Panel2
        '
        Me.PanelAnimator.SetDecoration(Me.Panel2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.logoAnimator.SetDecoration(Me.Panel2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(360, 92)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1047, 721)
        Me.Panel2.TabIndex = 2
        '
        'PanelAnimator
        '
        Me.PanelAnimator.AnimationType = Bunifu.UI.WinForms.BunifuAnimatorNS.AnimationType.Particles
        Me.PanelAnimator.Cursor = Nothing
        Animation1.AnimateOnlyDifferences = True
        Animation1.BlindCoeff = CType(resources.GetObject("Animation1.BlindCoeff"), System.Drawing.PointF)
        Animation1.LeafCoeff = 0!
        Animation1.MaxTime = 1.0!
        Animation1.MinTime = 0!
        Animation1.MosaicCoeff = CType(resources.GetObject("Animation1.MosaicCoeff"), System.Drawing.PointF)
        Animation1.MosaicShift = CType(resources.GetObject("Animation1.MosaicShift"), System.Drawing.PointF)
        Animation1.MosaicSize = 1
        Animation1.Padding = New System.Windows.Forms.Padding(100, 50, 100, 150)
        Animation1.RotateCoeff = 0!
        Animation1.RotateLimit = 0!
        Animation1.ScaleCoeff = CType(resources.GetObject("Animation1.ScaleCoeff"), System.Drawing.PointF)
        Animation1.SlideCoeff = CType(resources.GetObject("Animation1.SlideCoeff"), System.Drawing.PointF)
        Animation1.TimeCoeff = 2.0!
        Animation1.TransparencyCoeff = 0!
        Me.PanelAnimator.DefaultAnimation = Animation1
        '
        'dashboard_Frm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1407, 813)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.sidemenu)
        Me.Controls.Add(Me.header)
        Me.PanelAnimator.SetDecoration(Me, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.logoAnimator.SetDecoration(Me, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "dashboard_Frm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "dashboard_Frm"
        Me.sidemenu.ResumeLayout(False)
        Me.sidemenu.PerformLayout()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.header.ResumeLayout(False)
        Me.header.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents sidemenu As Panel
    Friend WithEvents btnmenu As Bunifu.UI.WinForms.BunifuImageButton
    Friend WithEvents logo As PictureBox
    Friend WithEvents header As Panel
    Friend WithEvents BunifuImageButton2 As Bunifu.UI.WinForms.BunifuImageButton
    Friend WithEvents Label1 As Label
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents manInventory_btn As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents addinventory_btn As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents inventory_btn As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents logoAnimator As Bunifu.UI.WinForms.BunifuTransition
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PanelAnimator As Bunifu.UI.WinForms.BunifuTransition
    Friend WithEvents logo1 As Label
    Friend WithEvents records_btn As Bunifu.UI.WinForms.BunifuButton.BunifuButton
End Class
