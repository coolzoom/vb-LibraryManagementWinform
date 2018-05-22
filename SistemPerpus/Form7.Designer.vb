<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form7))
        Dim StateProperties1 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties()
        Me.cb_jurusan = New Bunifu.UI.WinForms.BunifuDropdown()
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.PanelLeft = New System.Windows.Forms.Panel()
        Me.BunifuThinButton25 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuThinButton24 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuThinButton23 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuThinButton22 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuThinButton21 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuFlatButton1 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuSeparator1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.tb_nama = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.add_admin = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.welcome = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.PanelRight = New System.Windows.Forms.Panel()
        Me.cb_tahun_ajaran = New Bunifu.UI.WinForms.BunifuDropdown()
        Me.cb_status = New Bunifu.UI.WinForms.BunifuDropdown()
        Me.PanelLeft.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelRight.SuspendLayout()
        Me.SuspendLayout()
        '
        'cb_jurusan
        '
        Me.cb_jurusan.BackColor = System.Drawing.SystemColors.Control
        Me.cb_jurusan.BorderRadius = 5
        Me.cb_jurusan.Color = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cb_jurusan.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down
        Me.cb_jurusan.DisabledColor = System.Drawing.Color.Gray
        Me.cb_jurusan.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cb_jurusan.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thick
        Me.cb_jurusan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_jurusan.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left
        Me.cb_jurusan.FillDropDown = False
        Me.cb_jurusan.FillIndicator = False
        Me.cb_jurusan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cb_jurusan.ForeColor = System.Drawing.Color.Purple
        Me.cb_jurusan.FormattingEnabled = True
        Me.cb_jurusan.Icon = Nothing
        Me.cb_jurusan.IndicatorColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.cb_jurusan.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right
        Me.cb_jurusan.ItemBackColor = System.Drawing.Color.White
        Me.cb_jurusan.ItemBorderColor = System.Drawing.Color.White
        Me.cb_jurusan.ItemForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.cb_jurusan.ItemHeight = 25
        Me.cb_jurusan.ItemHighLightColor = System.Drawing.Color.LightSlateGray
        Me.cb_jurusan.Items.AddRange(New Object() {"TKJ", "RPL", "TKR", "TP", "TSM"})
        Me.cb_jurusan.Location = New System.Drawing.Point(181, 213)
        Me.cb_jurusan.MinimumSize = New System.Drawing.Size(48, 0)
        Me.cb_jurusan.Name = "cb_jurusan"
        Me.cb_jurusan.Size = New System.Drawing.Size(215, 31)
        Me.cb_jurusan.TabIndex = 12
        Me.cb_jurusan.Text = Nothing
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me.PanelLeft
        Me.BunifuDragControl1.Vertical = True
        '
        'PanelLeft
        '
        Me.PanelLeft.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.PanelLeft.Controls.Add(Me.BunifuThinButton25)
        Me.PanelLeft.Controls.Add(Me.BunifuThinButton24)
        Me.PanelLeft.Controls.Add(Me.BunifuThinButton23)
        Me.PanelLeft.Controls.Add(Me.BunifuThinButton22)
        Me.PanelLeft.Controls.Add(Me.BunifuThinButton21)
        Me.PanelLeft.Controls.Add(Me.BunifuFlatButton1)
        Me.PanelLeft.Controls.Add(Me.BunifuSeparator1)
        Me.PanelLeft.Controls.Add(Me.Label1)
        Me.PanelLeft.Controls.Add(Me.PictureBox1)
        Me.PanelLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelLeft.Location = New System.Drawing.Point(0, 0)
        Me.PanelLeft.Name = "PanelLeft"
        Me.PanelLeft.Size = New System.Drawing.Size(275, 563)
        Me.PanelLeft.TabIndex = 8
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
        Me.BunifuThinButton25.Location = New System.Drawing.Point(41, 295)
        Me.BunifuThinButton25.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton25.Name = "BunifuThinButton25"
        Me.BunifuThinButton25.Size = New System.Drawing.Size(198, 54)
        Me.BunifuThinButton25.TabIndex = 5
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
        Me.BunifuThinButton24.Location = New System.Drawing.Point(41, 243)
        Me.BunifuThinButton24.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton24.Name = "BunifuThinButton24"
        Me.BunifuThinButton24.Size = New System.Drawing.Size(198, 54)
        Me.BunifuThinButton24.TabIndex = 6
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
        Me.BunifuThinButton23.Location = New System.Drawing.Point(41, 190)
        Me.BunifuThinButton23.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton23.Name = "BunifuThinButton23"
        Me.BunifuThinButton23.Size = New System.Drawing.Size(198, 54)
        Me.BunifuThinButton23.TabIndex = 7
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
        Me.BunifuThinButton22.IdleCornerRadius = 1
        Me.BunifuThinButton22.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BunifuThinButton22.IdleForecolor = System.Drawing.Color.White
        Me.BunifuThinButton22.IdleLineColor = System.Drawing.Color.White
        Me.BunifuThinButton22.Location = New System.Drawing.Point(41, 136)
        Me.BunifuThinButton22.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton22.Name = "BunifuThinButton22"
        Me.BunifuThinButton22.Size = New System.Drawing.Size(198, 54)
        Me.BunifuThinButton22.TabIndex = 8
        Me.BunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuThinButton21
        '
        Me.BunifuThinButton21.ActiveBorderThickness = 1
        Me.BunifuThinButton21.ActiveCornerRadius = 20
        Me.BunifuThinButton21.ActiveFillColor = System.Drawing.Color.Transparent
        Me.BunifuThinButton21.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton21.ActiveLineColor = System.Drawing.Color.White
        Me.BunifuThinButton21.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.BunifuThinButton21.BackgroundImage = CType(resources.GetObject("BunifuThinButton21.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton21.ButtonText = "Admin Management"
        Me.BunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton21.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton21.ForeColor = System.Drawing.Color.White
        Me.BunifuThinButton21.IdleBorderThickness = 1
        Me.BunifuThinButton21.IdleCornerRadius = 20
        Me.BunifuThinButton21.IdleFillColor = System.Drawing.Color.Transparent
        Me.BunifuThinButton21.IdleForecolor = System.Drawing.Color.White
        Me.BunifuThinButton21.IdleLineColor = System.Drawing.Color.White
        Me.BunifuThinButton21.Location = New System.Drawing.Point(41, 82)
        Me.BunifuThinButton21.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton21.Name = "BunifuThinButton21"
        Me.BunifuThinButton21.Size = New System.Drawing.Size(198, 54)
        Me.BunifuThinButton21.TabIndex = 9
        Me.BunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.Label1.Location = New System.Drawing.Point(93, 32)
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
        'add_admin
        '
        Me.add_admin.BackColor = System.Drawing.Color.Transparent
        Me.add_admin.BackgroundImage = CType(resources.GetObject("add_admin.BackgroundImage"), System.Drawing.Image)
        Me.add_admin.ButtonText = "+ Add Member"
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
        'PanelRight
        '
        Me.PanelRight.Controls.Add(Me.cb_tahun_ajaran)
        Me.PanelRight.Controls.Add(Me.cb_status)
        Me.PanelRight.Controls.Add(Me.cb_jurusan)
        Me.PanelRight.Controls.Add(Me.tb_nama)
        Me.PanelRight.Controls.Add(Me.add_admin)
        Me.PanelRight.Controls.Add(Me.welcome)
        Me.PanelRight.Controls.Add(Me.Label5)
        Me.PanelRight.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelRight.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelRight.Location = New System.Drawing.Point(275, 0)
        Me.PanelRight.Name = "PanelRight"
        Me.PanelRight.Size = New System.Drawing.Size(569, 563)
        Me.PanelRight.TabIndex = 9
        '
        'cb_tahun_ajaran
        '
        Me.cb_tahun_ajaran.BackColor = System.Drawing.SystemColors.Control
        Me.cb_tahun_ajaran.BorderRadius = 5
        Me.cb_tahun_ajaran.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down
        Me.cb_tahun_ajaran.DisabledColor = System.Drawing.Color.Gray
        Me.cb_tahun_ajaran.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cb_tahun_ajaran.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thick
        Me.cb_tahun_ajaran.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_tahun_ajaran.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left
        Me.cb_tahun_ajaran.FillDropDown = False
        Me.cb_tahun_ajaran.FillIndicator = False
        Me.cb_tahun_ajaran.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cb_tahun_ajaran.ForeColor = System.Drawing.Color.Purple
        Me.cb_tahun_ajaran.FormattingEnabled = True
        Me.cb_tahun_ajaran.Icon = Nothing
        Me.cb_tahun_ajaran.IndicatorColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.cb_tahun_ajaran.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right
        Me.cb_tahun_ajaran.ItemBackColor = System.Drawing.Color.White
        Me.cb_tahun_ajaran.ItemBorderColor = System.Drawing.Color.White
        Me.cb_tahun_ajaran.ItemForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.cb_tahun_ajaran.ItemHeight = 25
        Me.cb_tahun_ajaran.ItemHighLightColor = System.Drawing.Color.LightSlateGray
        Me.cb_tahun_ajaran.Items.AddRange(New Object() {"2015/2016", "2016/2017", "2017/2018", "2018/2019", "2019/2020"})
        Me.cb_tahun_ajaran.Location = New System.Drawing.Point(181, 159)
        Me.cb_tahun_ajaran.MinimumSize = New System.Drawing.Size(48, 0)
        Me.cb_tahun_ajaran.Name = "cb_tahun_ajaran"
        Me.cb_tahun_ajaran.Size = New System.Drawing.Size(215, 31)
        Me.cb_tahun_ajaran.TabIndex = 12
        Me.cb_tahun_ajaran.Text = Nothing
        '
        'cb_status
        '
        Me.cb_status.BackColor = System.Drawing.SystemColors.Control
        Me.cb_status.BorderRadius = 5
        Me.cb_status.Color = System.Drawing.Color.OrangeRed
        Me.cb_status.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down
        Me.cb_status.DisabledColor = System.Drawing.Color.Gray
        Me.cb_status.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cb_status.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thick
        Me.cb_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_status.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left
        Me.cb_status.FillDropDown = False
        Me.cb_status.FillIndicator = False
        Me.cb_status.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cb_status.ForeColor = System.Drawing.Color.Purple
        Me.cb_status.FormattingEnabled = True
        Me.cb_status.Icon = Nothing
        Me.cb_status.IndicatorColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.cb_status.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right
        Me.cb_status.ItemBackColor = System.Drawing.Color.White
        Me.cb_status.ItemBorderColor = System.Drawing.Color.White
        Me.cb_status.ItemForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.cb_status.ItemHeight = 25
        Me.cb_status.ItemHighLightColor = System.Drawing.Color.LightSlateGray
        Me.cb_status.Items.AddRange(New Object() {"aktif", "tidak_aktif"})
        Me.cb_status.Location = New System.Drawing.Point(181, 266)
        Me.cb_status.MinimumSize = New System.Drawing.Size(48, 0)
        Me.cb_status.Name = "cb_status"
        Me.cb_status.Size = New System.Drawing.Size(215, 31)
        Me.cb_status.TabIndex = 12
        Me.cb_status.Text = Nothing
        '
        'Form7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(844, 563)
        Me.Controls.Add(Me.PanelRight)
        Me.Controls.Add(Me.PanelLeft)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form7"
        Me.Text = "Form7"
        Me.PanelLeft.ResumeLayout(False)
        Me.PanelLeft.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelRight.ResumeLayout(False)
        Me.PanelRight.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cb_jurusan As Bunifu.UI.WinForms.BunifuDropdown
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents PanelLeft As Panel
    Friend WithEvents BunifuFlatButton1 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuSeparator1 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents PanelRight As Panel
    Friend WithEvents tb_nama As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents add_admin As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents welcome As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Label5 As Label
    Friend WithEvents BunifuThinButton25 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuThinButton24 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuThinButton23 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuThinButton22 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuThinButton21 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents cb_tahun_ajaran As Bunifu.UI.WinForms.BunifuDropdown
    Friend WithEvents cb_status As Bunifu.UI.WinForms.BunifuDropdown
End Class
