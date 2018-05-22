<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim StateProperties1 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties()
        Me.PanelLeft = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelRight = New System.Windows.Forms.Panel()
        Me.Cek_Koneksi = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuSeparator1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.BunifuButton1 = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.Password = New Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Email = New Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.PanelLeft.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelRight.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelLeft
        '
        Me.PanelLeft.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.PanelLeft.Controls.Add(Me.PictureBox2)
        Me.PanelLeft.Controls.Add(Me.Label1)
        Me.PanelLeft.Controls.Add(Me.PictureBox1)
        Me.PanelLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelLeft.Location = New System.Drawing.Point(0, 0)
        Me.PanelLeft.Name = "PanelLeft"
        Me.PanelLeft.Size = New System.Drawing.Size(290, 528)
        Me.PanelLeft.TabIndex = 0
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(66, 182)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(145, 132)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(3, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(272, 44)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Sistem Informasi " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Management Perpustakaan"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 407)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(290, 121)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PanelRight
        '
        Me.PanelRight.Controls.Add(Me.Cek_Koneksi)
        Me.PanelRight.Controls.Add(Me.LinkLabel1)
        Me.PanelRight.Controls.Add(Me.PictureBox4)
        Me.PanelRight.Controls.Add(Me.PictureBox3)
        Me.PanelRight.Controls.Add(Me.BunifuCustomLabel2)
        Me.PanelRight.Controls.Add(Me.BunifuCustomLabel1)
        Me.PanelRight.Controls.Add(Me.BunifuSeparator1)
        Me.PanelRight.Controls.Add(Me.BunifuButton1)
        Me.PanelRight.Controls.Add(Me.Password)
        Me.PanelRight.Controls.Add(Me.Label7)
        Me.PanelRight.Controls.Add(Me.Label6)
        Me.PanelRight.Controls.Add(Me.Label4)
        Me.PanelRight.Controls.Add(Me.Email)
        Me.PanelRight.Controls.Add(Me.Label3)
        Me.PanelRight.Controls.Add(Me.Label5)
        Me.PanelRight.Controls.Add(Me.Label2)
        Me.PanelRight.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelRight.Location = New System.Drawing.Point(290, 0)
        Me.PanelRight.Name = "PanelRight"
        Me.PanelRight.Size = New System.Drawing.Size(441, 528)
        Me.PanelRight.TabIndex = 1
        '
        'Cek_Koneksi
        '
        Me.Cek_Koneksi.ActiveBorderThickness = 1
        Me.Cek_Koneksi.ActiveCornerRadius = 20
        Me.Cek_Koneksi.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.Cek_Koneksi.ActiveForecolor = System.Drawing.Color.White
        Me.Cek_Koneksi.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.Cek_Koneksi.BackColor = System.Drawing.SystemColors.Control
        Me.Cek_Koneksi.BackgroundImage = CType(resources.GetObject("Cek_Koneksi.BackgroundImage"), System.Drawing.Image)
        Me.Cek_Koneksi.ButtonText = "Connection"
        Me.Cek_Koneksi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cek_Koneksi.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cek_Koneksi.ForeColor = System.Drawing.Color.SeaGreen
        Me.Cek_Koneksi.IdleBorderThickness = 1
        Me.Cek_Koneksi.IdleCornerRadius = 20
        Me.Cek_Koneksi.IdleFillColor = System.Drawing.Color.White
        Me.Cek_Koneksi.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.Cek_Koneksi.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.Cek_Koneksi.Location = New System.Drawing.Point(284, 325)
        Me.Cek_Koneksi.Margin = New System.Windows.Forms.Padding(5)
        Me.Cek_Koneksi.Name = "Cek_Koneksi"
        Me.Cek_Koneksi.Size = New System.Drawing.Size(116, 37)
        Me.Cek_Koneksi.TabIndex = 7
        Me.Cek_Koneksi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(380, 506)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(49, 13)
        Me.LinkLabel1.TabIndex = 6
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "MoreInfo"
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(0, 475)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(100, 41)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 5
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(0, 419)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 5
        Me.PictureBox3.TabStop = False
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(255, 418)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(46, 22)
        Me.BunifuCustomLabel2.TabIndex = 4
        Me.BunifuCustomLabel2.Text = "V 1.0"
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Monotype Corsiva", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(156, 390)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(130, 28)
        Me.BunifuCustomLabel1.TabIndex = 4
        Me.BunifuCustomLabel1.Text = "What's New?"
        '
        'BunifuSeparator1
        '
        Me.BunifuSeparator1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BunifuSeparator1.LineThickness = 1
        Me.BunifuSeparator1.Location = New System.Drawing.Point(-100, 352)
        Me.BunifuSeparator1.Name = "BunifuSeparator1"
        Me.BunifuSeparator1.Size = New System.Drawing.Size(639, 35)
        Me.BunifuSeparator1.TabIndex = 3
        Me.BunifuSeparator1.Transparency = 255
        Me.BunifuSeparator1.Vertical = False
        '
        'BunifuButton1
        '
        Me.BunifuButton1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuButton1.BackgroundImage = CType(resources.GetObject("BunifuButton1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuButton1.ButtonText = "Sign In"
        Me.BunifuButton1.ButtonTextMarginLeft = 0
        Me.BunifuButton1.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.BunifuButton1.DisabledFillColor = System.Drawing.SystemColors.Control
        Me.BunifuButton1.DisabledForecolor = System.Drawing.Color.White
        Me.BunifuButton1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuButton1.ForeColor = System.Drawing.Color.White
        Me.BunifuButton1.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.BunifuButton1.IconPadding = 10
        Me.BunifuButton1.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.BunifuButton1.IdleBorderColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.BunifuButton1.IdleBorderRadius = 1
        Me.BunifuButton1.IdleBorderThickness = 0
        Me.BunifuButton1.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.BunifuButton1.IdleIconLeftImage = Nothing
        Me.BunifuButton1.IdleIconRightImage = Nothing
        Me.BunifuButton1.Location = New System.Drawing.Point(190, 253)
        Me.BunifuButton1.Name = "BunifuButton1"
        StateProperties1.BorderColor = System.Drawing.Color.Black
        StateProperties1.BorderRadius = 1
        StateProperties1.BorderThickness = 1
        StateProperties1.FillColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(37, Byte), Integer))
        StateProperties1.IconLeftImage = Nothing
        StateProperties1.IconRightImage = Nothing
        Me.BunifuButton1.onHoverState = StateProperties1
        Me.BunifuButton1.Size = New System.Drawing.Size(210, 45)
        Me.BunifuButton1.TabIndex = 2
        Me.BunifuButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Password
        '
        Me.Password.AcceptsReturn = False
        Me.Password.AcceptsTab = False
        Me.Password.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.Password.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.Password.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.Password.BackColor = System.Drawing.Color.Transparent
        Me.Password.BackgroundImage = CType(resources.GetObject("Password.BackgroundImage"), System.Drawing.Image)
        Me.Password.BorderColorActive = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.Password.BorderColorDisabled = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.Password.BorderColorHover = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.Password.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.Password.BorderRadius = 1
        Me.Password.BorderThickness = 2
        Me.Password.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.Password.DefaultFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Password.DefaultText = ""
        Me.Password.FillColor = System.Drawing.Color.White
        Me.Password.HideSelection = True
        Me.Password.IconLeft = CType(resources.GetObject("Password.IconLeft"), System.Drawing.Image)
        Me.Password.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.Password.IconPadding = 10
        Me.Password.IconRight = Nothing
        Me.Password.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.Password.Location = New System.Drawing.Point(30, 182)
        Me.Password.MaxLength = 32767
        Me.Password.MinimumSize = New System.Drawing.Size(100, 35)
        Me.Password.Modified = False
        Me.Password.Name = "Password"
        Me.Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.Password.ReadOnly = False
        Me.Password.SelectedText = ""
        Me.Password.SelectionLength = 0
        Me.Password.SelectionStart = 0
        Me.Password.ShortcutsEnabled = True
        Me.Password.Size = New System.Drawing.Size(370, 35)
        Me.Password.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu
        Me.Password.TabIndex = 2
        Me.Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Password.TextMarginLeft = 5
        Me.Password.TextPlaceholder = ""
        Me.Password.UseSystemPasswordChar = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(100, 486)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(108, 21)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Add 10 Book"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(100, 433)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 21)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Optimizing"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(26, 157)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 21)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Password"
        '
        'Email
        '
        Me.Email.AcceptsReturn = False
        Me.Email.AcceptsTab = False
        Me.Email.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.Email.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.Email.BackColor = System.Drawing.Color.Transparent
        Me.Email.BackgroundImage = CType(resources.GetObject("Email.BackgroundImage"), System.Drawing.Image)
        Me.Email.BorderColorActive = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.Email.BorderColorDisabled = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.Email.BorderColorHover = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.Email.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.Email.BorderRadius = 1
        Me.Email.BorderThickness = 2
        Me.Email.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.Email.DefaultFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Email.DefaultText = ""
        Me.Email.FillColor = System.Drawing.Color.White
        Me.Email.HideSelection = True
        Me.Email.IconLeft = CType(resources.GetObject("Email.IconLeft"), System.Drawing.Image)
        Me.Email.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.Email.IconPadding = 10
        Me.Email.IconRight = Nothing
        Me.Email.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.Email.Location = New System.Drawing.Point(30, 109)
        Me.Email.MaxLength = 32767
        Me.Email.MinimumSize = New System.Drawing.Size(100, 35)
        Me.Email.Modified = False
        Me.Email.Name = "Email"
        Me.Email.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Email.ReadOnly = False
        Me.Email.SelectedText = ""
        Me.Email.SelectionLength = 0
        Me.Email.SelectionStart = 0
        Me.Email.ShortcutsEnabled = True
        Me.Email.Size = New System.Drawing.Size(370, 35)
        Me.Email.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu
        Me.Email.TabIndex = 1
        Me.Email.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Email.TextMarginLeft = 5
        Me.Email.TextPlaceholder = ""
        Me.Email.UseSystemPasswordChar = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(26, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 21)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Email"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(401, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(28, 30)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "X"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(25, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 30)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Sign In"
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
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(731, 528)
        Me.Controls.Add(Me.PanelRight)
        Me.Controls.Add(Me.PanelLeft)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.PanelLeft.ResumeLayout(False)
        Me.PanelLeft.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelRight.ResumeLayout(False)
        Me.PanelRight.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelLeft As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PanelRight As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Email As Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox
    Friend WithEvents BunifuButton1 As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents Password As Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuSeparator1 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Cek_Koneksi As Bunifu.Framework.UI.BunifuThinButton2
End Class
