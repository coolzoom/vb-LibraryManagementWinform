<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Dim StateProperties1 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties()
        Me.PanelRight = New System.Windows.Forms.Panel()
        Me.cb_level = New Bunifu.UI.WinForms.BunifuDropdown()
        Me.tb_nama = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.tb_password = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.tb_email = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.add_admin = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.welcome = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PanelLeft = New System.Windows.Forms.Panel()
        Me.BunifuFlatButton1 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuThinButton25 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuThinButton24 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuThinButton23 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuThinButton22 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuThinButton21 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuSeparator1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.PanelRight.SuspendLayout()
        Me.PanelLeft.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelRight
        '
        Me.PanelRight.Controls.Add(Me.cb_level)
        Me.PanelRight.Controls.Add(Me.tb_nama)
        Me.PanelRight.Controls.Add(Me.tb_password)
        Me.PanelRight.Controls.Add(Me.tb_email)
        Me.PanelRight.Controls.Add(Me.add_admin)
        Me.PanelRight.Controls.Add(Me.welcome)
        Me.PanelRight.Controls.Add(Me.Label5)
        Me.PanelRight.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelRight.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelRight.Location = New System.Drawing.Point(275, 0)
        Me.PanelRight.Name = "PanelRight"
        Me.PanelRight.Size = New System.Drawing.Size(585, 602)
        Me.PanelRight.TabIndex = 7
        '
        'cb_level
        '
        Me.cb_level.BackColor = System.Drawing.SystemColors.Control
        Me.cb_level.BorderRadius = 5
        Me.cb_level.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down
        Me.cb_level.DisabledColor = System.Drawing.Color.Gray
        Me.cb_level.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cb_level.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thick
        Me.cb_level.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_level.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left
        Me.cb_level.FillDropDown = False
        Me.cb_level.FillIndicator = False
        Me.cb_level.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cb_level.ForeColor = System.Drawing.Color.Purple
        Me.cb_level.FormattingEnabled = True
        Me.cb_level.Icon = Nothing
        Me.cb_level.IndicatorColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.cb_level.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right
        Me.cb_level.ItemBackColor = System.Drawing.Color.White
        Me.cb_level.ItemBorderColor = System.Drawing.Color.White
        Me.cb_level.ItemForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.cb_level.ItemHeight = 25
        Me.cb_level.ItemHighLightColor = System.Drawing.Color.LightSlateGray
        Me.cb_level.Items.AddRange(New Object() {"admin", "super_admin"})
        Me.cb_level.Location = New System.Drawing.Point(181, 254)
        Me.cb_level.MinimumSize = New System.Drawing.Size(48, 0)
        Me.cb_level.Name = "cb_level"
        Me.cb_level.Size = New System.Drawing.Size(215, 31)
        Me.cb_level.TabIndex = 12
        Me.cb_level.Text = Nothing
        '
        'tb_nama
        '
        Me.tb_nama.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.tb_nama.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.tb_nama.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tb_nama.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_nama.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.tb_nama.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_nama.HintForeColor = System.Drawing.Color.Empty
        Me.tb_nama.HintText = "Nama"
        Me.tb_nama.isPassword = False
        Me.tb_nama.LineFocusedColor = System.Drawing.Color.Blue
        Me.tb_nama.LineIdleColor = System.Drawing.Color.Gray
        Me.tb_nama.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.tb_nama.LineThickness = 3
        Me.tb_nama.Location = New System.Drawing.Point(181, 99)
        Me.tb_nama.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_nama.MaxLength = 32767
        Me.tb_nama.Name = "tb_nama"
        Me.tb_nama.Size = New System.Drawing.Size(215, 33)
        Me.tb_nama.TabIndex = 10
        Me.tb_nama.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'tb_password
        '
        Me.tb_password.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.tb_password.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.tb_password.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tb_password.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_password.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.tb_password.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_password.HintForeColor = System.Drawing.Color.Empty
        Me.tb_password.HintText = "Your Password"
        Me.tb_password.isPassword = True
        Me.tb_password.LineFocusedColor = System.Drawing.Color.Blue
        Me.tb_password.LineIdleColor = System.Drawing.Color.Gray
        Me.tb_password.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.tb_password.LineThickness = 3
        Me.tb_password.Location = New System.Drawing.Point(181, 196)
        Me.tb_password.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_password.MaxLength = 32767
        Me.tb_password.Name = "tb_password"
        Me.tb_password.Size = New System.Drawing.Size(215, 33)
        Me.tb_password.TabIndex = 9
        Me.tb_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'tb_email
        '
        Me.tb_email.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.tb_email.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.tb_email.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tb_email.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_email.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.tb_email.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_email.HintForeColor = System.Drawing.Color.Empty
        Me.tb_email.HintText = "Email"
        Me.tb_email.isPassword = False
        Me.tb_email.LineFocusedColor = System.Drawing.Color.Blue
        Me.tb_email.LineIdleColor = System.Drawing.Color.Gray
        Me.tb_email.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.tb_email.LineThickness = 3
        Me.tb_email.Location = New System.Drawing.Point(181, 145)
        Me.tb_email.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_email.MaxLength = 32767
        Me.tb_email.Name = "tb_email"
        Me.tb_email.Size = New System.Drawing.Size(215, 33)
        Me.tb_email.TabIndex = 9
        Me.tb_email.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'add_admin
        '
        Me.add_admin.BackColor = System.Drawing.Color.Transparent
        Me.add_admin.BackgroundImage = CType(resources.GetObject("add_admin.BackgroundImage"), System.Drawing.Image)
        Me.add_admin.ButtonText = "+ Add Admin"
        Me.add_admin.ButtonTextMarginLeft = 0
        Me.add_admin.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.add_admin.DisabledFillColor = System.Drawing.Color.Gray
        Me.add_admin.DisabledForecolor = System.Drawing.Color.White
        Me.add_admin.Font = New System.Drawing.Font("Poor Richard", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.add_admin.ForeColor = System.Drawing.Color.White
        Me.add_admin.IconLeftCursor = System.Windows.Forms.Cursors.Cross
        Me.add_admin.IconPadding = 10
        Me.add_admin.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.add_admin.IdleBorderColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.add_admin.IdleBorderRadius = 1
        Me.add_admin.IdleBorderThickness = 0
        Me.add_admin.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.add_admin.IdleIconLeftImage = Nothing
        Me.add_admin.IdleIconRightImage = Nothing
        Me.add_admin.Location = New System.Drawing.Point(222, 312)
        Me.add_admin.Name = "add_admin"
        StateProperties1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        StateProperties1.BorderRadius = 1
        StateProperties1.BorderThickness = 1
        StateProperties1.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        StateProperties1.IconLeftImage = Nothing
        StateProperties1.IconRightImage = Nothing
        Me.add_admin.onHoverState = StateProperties1
        Me.add_admin.Size = New System.Drawing.Size(122, 33)
        Me.add_admin.TabIndex = 8
        Me.add_admin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'welcome
        '
        Me.welcome.AutoSize = True
        Me.welcome.Font = New System.Drawing.Font("Poor Richard", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.welcome.Location = New System.Drawing.Point(234, 26)
        Me.welcome.Name = "welcome"
        Me.welcome.Size = New System.Drawing.Size(110, 28)
        Me.welcome.TabIndex = 5
        Me.welcome.Text = "Insert Data"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(545, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(28, 30)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "X"
        '
        'PanelLeft
        '
        Me.PanelLeft.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.PanelLeft.Controls.Add(Me.BunifuFlatButton1)
        Me.PanelLeft.Controls.Add(Me.BunifuThinButton25)
        Me.PanelLeft.Controls.Add(Me.BunifuThinButton24)
        Me.PanelLeft.Controls.Add(Me.BunifuThinButton23)
        Me.PanelLeft.Controls.Add(Me.BunifuThinButton22)
        Me.PanelLeft.Controls.Add(Me.BunifuThinButton21)
        Me.PanelLeft.Controls.Add(Me.BunifuSeparator1)
        Me.PanelLeft.Controls.Add(Me.Label1)
        Me.PanelLeft.Controls.Add(Me.PictureBox1)
        Me.PanelLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelLeft.Location = New System.Drawing.Point(0, 0)
        Me.PanelLeft.Name = "PanelLeft"
        Me.PanelLeft.Size = New System.Drawing.Size(275, 602)
        Me.PanelLeft.TabIndex = 6
        '
        'BunifuFlatButton1
        '
        Me.BunifuFlatButton1.Active = False
        Me.BunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.BunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.BunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton1.BorderRadius = 0
        Me.BunifuFlatButton1.ButtonText = "  Back"
        Me.BunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton1.Iconimage = CType(resources.GetObject("BunifuFlatButton1.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton1.Iconimage_right = Nothing
        Me.BunifuFlatButton1.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton1.Iconimage_Selected = Nothing
        Me.BunifuFlatButton1.IconMarginLeft = 0
        Me.BunifuFlatButton1.IconMarginRight = 0
        Me.BunifuFlatButton1.IconRightVisible = True
        Me.BunifuFlatButton1.IconRightZoom = 0R
        Me.BunifuFlatButton1.IconVisible = True
        Me.BunifuFlatButton1.IconZoom = 50.0R
        Me.BunifuFlatButton1.IsTab = False
        Me.BunifuFlatButton1.Location = New System.Drawing.Point(87, 424)
        Me.BunifuFlatButton1.Name = "BunifuFlatButton1"
        Me.BunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.BunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton1.selected = False
        Me.BunifuFlatButton1.Size = New System.Drawing.Size(101, 48)
        Me.BunifuFlatButton1.TabIndex = 4
        Me.BunifuFlatButton1.Text = "  Back"
        Me.BunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton1.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton1.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuThinButton25
        '
        Me.BunifuThinButton25.ActiveBorderThickness = 1
        Me.BunifuThinButton25.ActiveCornerRadius = 20
        Me.BunifuThinButton25.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BunifuThinButton25.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton25.ActiveLineColor = System.Drawing.Color.White
        Me.BunifuThinButton25.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.BunifuThinButton25.BackgroundImage = CType(resources.GetObject("BunifuThinButton25.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton25.ButtonText = "Return Book"
        Me.BunifuThinButton25.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton25.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton25.ForeColor = System.Drawing.Color.White
        Me.BunifuThinButton25.IdleBorderThickness = 1
        Me.BunifuThinButton25.IdleCornerRadius = 20
        Me.BunifuThinButton25.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.BunifuThinButton25.IdleForecolor = System.Drawing.Color.White
        Me.BunifuThinButton25.IdleLineColor = System.Drawing.Color.White
        Me.BunifuThinButton25.Location = New System.Drawing.Point(36, 291)
        Me.BunifuThinButton25.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton25.Name = "BunifuThinButton25"
        Me.BunifuThinButton25.Size = New System.Drawing.Size(198, 54)
        Me.BunifuThinButton25.TabIndex = 3
        Me.BunifuThinButton25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuThinButton24
        '
        Me.BunifuThinButton24.ActiveBorderThickness = 1
        Me.BunifuThinButton24.ActiveCornerRadius = 20
        Me.BunifuThinButton24.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BunifuThinButton24.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton24.ActiveLineColor = System.Drawing.Color.White
        Me.BunifuThinButton24.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.BunifuThinButton24.BackgroundImage = CType(resources.GetObject("BunifuThinButton24.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton24.ButtonText = "Loan Book"
        Me.BunifuThinButton24.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton24.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton24.ForeColor = System.Drawing.Color.White
        Me.BunifuThinButton24.IdleBorderThickness = 1
        Me.BunifuThinButton24.IdleCornerRadius = 20
        Me.BunifuThinButton24.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.BunifuThinButton24.IdleForecolor = System.Drawing.Color.White
        Me.BunifuThinButton24.IdleLineColor = System.Drawing.Color.White
        Me.BunifuThinButton24.Location = New System.Drawing.Point(36, 239)
        Me.BunifuThinButton24.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton24.Name = "BunifuThinButton24"
        Me.BunifuThinButton24.Size = New System.Drawing.Size(198, 54)
        Me.BunifuThinButton24.TabIndex = 3
        Me.BunifuThinButton24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuThinButton23
        '
        Me.BunifuThinButton23.ActiveBorderThickness = 1
        Me.BunifuThinButton23.ActiveCornerRadius = 20
        Me.BunifuThinButton23.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BunifuThinButton23.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton23.ActiveLineColor = System.Drawing.Color.White
        Me.BunifuThinButton23.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.BunifuThinButton23.BackgroundImage = CType(resources.GetObject("BunifuThinButton23.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton23.ButtonText = "Book Management"
        Me.BunifuThinButton23.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton23.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton23.ForeColor = System.Drawing.Color.White
        Me.BunifuThinButton23.IdleBorderThickness = 1
        Me.BunifuThinButton23.IdleCornerRadius = 20
        Me.BunifuThinButton23.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.BunifuThinButton23.IdleForecolor = System.Drawing.Color.White
        Me.BunifuThinButton23.IdleLineColor = System.Drawing.Color.White
        Me.BunifuThinButton23.Location = New System.Drawing.Point(36, 186)
        Me.BunifuThinButton23.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton23.Name = "BunifuThinButton23"
        Me.BunifuThinButton23.Size = New System.Drawing.Size(198, 54)
        Me.BunifuThinButton23.TabIndex = 3
        Me.BunifuThinButton23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuThinButton22
        '
        Me.BunifuThinButton22.ActiveBorderThickness = 1
        Me.BunifuThinButton22.ActiveCornerRadius = 20
        Me.BunifuThinButton22.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BunifuThinButton22.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton22.ActiveLineColor = System.Drawing.Color.White
        Me.BunifuThinButton22.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.BunifuThinButton22.BackgroundImage = CType(resources.GetObject("BunifuThinButton22.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton22.ButtonText = "Member Management"
        Me.BunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton22.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton22.ForeColor = System.Drawing.Color.White
        Me.BunifuThinButton22.IdleBorderThickness = 1
        Me.BunifuThinButton22.IdleCornerRadius = 20
        Me.BunifuThinButton22.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.BunifuThinButton22.IdleForecolor = System.Drawing.Color.White
        Me.BunifuThinButton22.IdleLineColor = System.Drawing.Color.White
        Me.BunifuThinButton22.Location = New System.Drawing.Point(36, 132)
        Me.BunifuThinButton22.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton22.Name = "BunifuThinButton22"
        Me.BunifuThinButton22.Size = New System.Drawing.Size(198, 54)
        Me.BunifuThinButton22.TabIndex = 3
        Me.BunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuThinButton21
        '
        Me.BunifuThinButton21.ActiveBorderThickness = 1
        Me.BunifuThinButton21.ActiveCornerRadius = 20
        Me.BunifuThinButton21.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BunifuThinButton21.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton21.ActiveLineColor = System.Drawing.Color.White
        Me.BunifuThinButton21.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.BunifuThinButton21.BackgroundImage = CType(resources.GetObject("BunifuThinButton21.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton21.ButtonText = "Admin Management"
        Me.BunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton21.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton21.ForeColor = System.Drawing.Color.White
        Me.BunifuThinButton21.IdleBorderThickness = 1
        Me.BunifuThinButton21.IdleCornerRadius = 1
        Me.BunifuThinButton21.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BunifuThinButton21.IdleForecolor = System.Drawing.Color.White
        Me.BunifuThinButton21.IdleLineColor = System.Drawing.Color.White
        Me.BunifuThinButton21.Location = New System.Drawing.Point(36, 78)
        Me.BunifuThinButton21.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton21.Name = "BunifuThinButton21"
        Me.BunifuThinButton21.Size = New System.Drawing.Size(198, 54)
        Me.BunifuThinButton21.TabIndex = 3
        Me.BunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuSeparator1
        '
        Me.BunifuSeparator1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuSeparator1.LineThickness = 1
        Me.BunifuSeparator1.Location = New System.Drawing.Point(69, 52)
        Me.BunifuSeparator1.Name = "BunifuSeparator1"
        Me.BunifuSeparator1.Size = New System.Drawing.Size(132, 18)
        Me.BunifuSeparator1.TabIndex = 2
        Me.BunifuSeparator1.Transparency = 255
        Me.BunifuSeparator1.Vertical = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(95, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 22)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Admin"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-15, 478)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(290, 121)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 35
        Me.BunifuElipse1.TargetControl = Me
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me.PanelLeft
        Me.BunifuDragControl1.Vertical = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(860, 602)
        Me.Controls.Add(Me.PanelRight)
        Me.Controls.Add(Me.PanelLeft)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form3"
        Me.PanelRight.ResumeLayout(False)
        Me.PanelRight.PerformLayout()
        Me.PanelLeft.ResumeLayout(False)
        Me.PanelLeft.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelRight As Panel
    Friend WithEvents tb_email As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents add_admin As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents welcome As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Label5 As Label
    Friend WithEvents PanelLeft As Panel
    Friend WithEvents BunifuFlatButton1 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuThinButton25 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuThinButton24 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuThinButton23 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuThinButton22 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuThinButton21 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuSeparator1 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents cb_level As Bunifu.UI.WinForms.BunifuDropdown
    Friend WithEvents tb_nama As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents tb_password As Bunifu.Framework.UI.BunifuMaterialTextbox
End Class
