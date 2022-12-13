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
        Dim StateProperties1 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties2 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties3 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties4 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Me.BunifuTextBox1 = New Bunifu.UI.WinForms.BunifuTextBox()
        Me.SuspendLayout()
        '
        'BunifuTextBox1
        '
        Me.BunifuTextBox1.AcceptsReturn = False
        Me.BunifuTextBox1.AcceptsTab = False
        Me.BunifuTextBox1.AnimationSpeed = 200
        Me.BunifuTextBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.BunifuTextBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.BunifuTextBox1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTextBox1.BackgroundImage = CType(resources.GetObject("BunifuTextBox1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuTextBox1.BorderColorActive = System.Drawing.Color.DodgerBlue
        Me.BunifuTextBox1.BorderColorDisabled = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuTextBox1.BorderColorHover = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuTextBox1.BorderColorIdle = System.Drawing.Color.Silver
        Me.BunifuTextBox1.BorderRadius = 1
        Me.BunifuTextBox1.BorderThickness = 1
        Me.BunifuTextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.BunifuTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuTextBox1.DefaultFont = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.BunifuTextBox1.DefaultText = ""
        Me.BunifuTextBox1.FillColor = System.Drawing.Color.White
        Me.BunifuTextBox1.HideSelection = True
        Me.BunifuTextBox1.IconLeft = Nothing
        Me.BunifuTextBox1.IconLeftCursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuTextBox1.IconPadding = 10
        Me.BunifuTextBox1.IconRight = Nothing
        Me.BunifuTextBox1.IconRightCursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuTextBox1.Lines = New String(-1) {}
        Me.BunifuTextBox1.Location = New System.Drawing.Point(290, 141)
        Me.BunifuTextBox1.MaxLength = 32767
        Me.BunifuTextBox1.MinimumSize = New System.Drawing.Size(1, 1)
        Me.BunifuTextBox1.Modified = False
        Me.BunifuTextBox1.Multiline = False
        Me.BunifuTextBox1.Name = "BunifuTextBox1"
        StateProperties1.BorderColor = System.Drawing.Color.DodgerBlue
        StateProperties1.FillColor = System.Drawing.Color.Empty
        StateProperties1.ForeColor = System.Drawing.Color.Empty
        StateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.BunifuTextBox1.OnActiveState = StateProperties1
        StateProperties2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        StateProperties2.FillColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        StateProperties2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        StateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.BunifuTextBox1.OnDisabledState = StateProperties2
        StateProperties3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        StateProperties3.FillColor = System.Drawing.Color.Empty
        StateProperties3.ForeColor = System.Drawing.Color.Empty
        StateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.BunifuTextBox1.OnHoverState = StateProperties3
        StateProperties4.BorderColor = System.Drawing.Color.Silver
        StateProperties4.FillColor = System.Drawing.Color.White
        StateProperties4.ForeColor = System.Drawing.Color.Empty
        StateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.BunifuTextBox1.OnIdleState = StateProperties4
        Me.BunifuTextBox1.Padding = New System.Windows.Forms.Padding(3)
        Me.BunifuTextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.BunifuTextBox1.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.BunifuTextBox1.PlaceholderText = "Enter text"
        Me.BunifuTextBox1.ReadOnly = False
        Me.BunifuTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.BunifuTextBox1.SelectedText = ""
        Me.BunifuTextBox1.SelectionLength = 0
        Me.BunifuTextBox1.SelectionStart = 0
        Me.BunifuTextBox1.ShortcutsEnabled = True
        Me.BunifuTextBox1.Size = New System.Drawing.Size(260, 41)
        Me.BunifuTextBox1.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu
        Me.BunifuTextBox1.TabIndex = 0
        Me.BunifuTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BunifuTextBox1.TextMarginBottom = 0
        Me.BunifuTextBox1.TextMarginLeft = 3
        Me.BunifuTextBox1.TextMarginTop = 0
        Me.BunifuTextBox1.TextPlaceholder = "Enter text"
        Me.BunifuTextBox1.UseSystemPasswordChar = False
        Me.BunifuTextBox1.WordWrap = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BunifuTextBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuTextBox1 As Bunifu.UI.WinForms.BunifuTextBox
End Class
