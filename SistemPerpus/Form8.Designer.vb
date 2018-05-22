<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form8
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form8))
        Dim StateProperties1 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties()
        Dim StateProperties2 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties()
        Dim StateProperties3 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties()
        Dim StateProperties4 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties()
        Dim StateProperties5 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.welcome = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.add_member = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.BunifuButton4 = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.BunifuButton2 = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.bt_hapus = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.BunifuButton3 = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.tb_id_buku = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.tb_isbn = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.tb_pengarang = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.tb_judul = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.tb_penerbit = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.tb_search = New Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox()
        Me.PanelRight = New System.Windows.Forms.Panel()
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
        Me.tb_halaman = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.tb_tahun_terbit = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuLabel1 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelRight.SuspendLayout()
        Me.PanelLeft.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(820, 5)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(28, 30)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "X"
        '
        'welcome
        '
        Me.welcome.AutoSize = True
        Me.welcome.Font = New System.Drawing.Font("Poor Richard", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.welcome.Location = New System.Drawing.Point(464, 22)
        Me.welcome.Name = "welcome"
        Me.welcome.Size = New System.Drawing.Size(183, 28)
        Me.welcome.TabIndex = 5
        Me.welcome.Text = "Book Management"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(281, 118)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(567, 267)
        Me.DataGridView1.TabIndex = 7
        '
        'add_member
        '
        Me.add_member.BackColor = System.Drawing.Color.Transparent
        Me.add_member.BackgroundImage = CType(resources.GetObject("add_member.BackgroundImage"), System.Drawing.Image)
        Me.add_member.ButtonText = "+ Add Buku"
        Me.add_member.ButtonTextMarginLeft = 0
        Me.add_member.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.add_member.DisabledFillColor = System.Drawing.Color.Gray
        Me.add_member.DisabledForecolor = System.Drawing.Color.White
        Me.add_member.Font = New System.Drawing.Font("Poor Richard", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.add_member.ForeColor = System.Drawing.Color.White
        Me.add_member.IconLeftCursor = System.Windows.Forms.Cursors.Cross
        Me.add_member.IconPadding = 10
        Me.add_member.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.add_member.IdleBorderColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.add_member.IdleBorderRadius = 1
        Me.add_member.IdleBorderThickness = 0
        Me.add_member.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.add_member.IdleIconLeftImage = Nothing
        Me.add_member.IdleIconRightImage = Nothing
        Me.add_member.Location = New System.Drawing.Point(726, 543)
        Me.add_member.Name = "add_member"
        StateProperties1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        StateProperties1.BorderRadius = 1
        StateProperties1.BorderThickness = 1
        StateProperties1.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        StateProperties1.IconLeftImage = Nothing
        StateProperties1.IconRightImage = Nothing
        Me.add_member.onHoverState = StateProperties1
        Me.add_member.Size = New System.Drawing.Size(122, 33)
        Me.add_member.TabIndex = 8
        Me.add_member.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuButton4
        '
        Me.BunifuButton4.BackColor = System.Drawing.Color.Transparent
        Me.BunifuButton4.BackgroundImage = CType(resources.GetObject("BunifuButton4.BackgroundImage"), System.Drawing.Image)
        Me.BunifuButton4.ButtonText = "Search"
        Me.BunifuButton4.ButtonTextMarginLeft = 0
        Me.BunifuButton4.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.BunifuButton4.DisabledFillColor = System.Drawing.Color.Gray
        Me.BunifuButton4.DisabledForecolor = System.Drawing.Color.White
        Me.BunifuButton4.Font = New System.Drawing.Font("Poor Richard", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuButton4.ForeColor = System.Drawing.Color.Black
        Me.BunifuButton4.IconLeftCursor = System.Windows.Forms.Cursors.Cross
        Me.BunifuButton4.IconPadding = 10
        Me.BunifuButton4.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.BunifuButton4.IdleBorderColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.BunifuButton4.IdleBorderRadius = 1
        Me.BunifuButton4.IdleBorderThickness = 0
        Me.BunifuButton4.IdleFillColor = System.Drawing.Color.White
        Me.BunifuButton4.IdleIconLeftImage = Nothing
        Me.BunifuButton4.IdleIconRightImage = Nothing
        Me.BunifuButton4.Location = New System.Drawing.Point(487, 79)
        Me.BunifuButton4.Name = "BunifuButton4"
        StateProperties2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        StateProperties2.BorderRadius = 1
        StateProperties2.BorderThickness = 1
        StateProperties2.FillColor = System.Drawing.Color.White
        StateProperties2.IconLeftImage = Nothing
        StateProperties2.IconRightImage = Nothing
        Me.BunifuButton4.onHoverState = StateProperties2
        Me.BunifuButton4.Size = New System.Drawing.Size(65, 33)
        Me.BunifuButton4.TabIndex = 8
        Me.BunifuButton4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuButton2
        '
        Me.BunifuButton2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuButton2.BackgroundImage = CType(resources.GetObject("BunifuButton2.BackgroundImage"), System.Drawing.Image)
        Me.BunifuButton2.ButtonText = "Update Data"
        Me.BunifuButton2.ButtonTextMarginLeft = 0
        Me.BunifuButton2.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.BunifuButton2.DisabledFillColor = System.Drawing.Color.Gray
        Me.BunifuButton2.DisabledForecolor = System.Drawing.Color.White
        Me.BunifuButton2.Font = New System.Drawing.Font("Poor Richard", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuButton2.ForeColor = System.Drawing.Color.White
        Me.BunifuButton2.IconLeftCursor = System.Windows.Forms.Cursors.Cross
        Me.BunifuButton2.IconPadding = 10
        Me.BunifuButton2.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.BunifuButton2.IdleBorderColor = System.Drawing.Color.ForestGreen
        Me.BunifuButton2.IdleBorderRadius = 1
        Me.BunifuButton2.IdleBorderThickness = 0
        Me.BunifuButton2.IdleFillColor = System.Drawing.Color.ForestGreen
        Me.BunifuButton2.IdleIconLeftImage = CType(resources.GetObject("BunifuButton2.IdleIconLeftImage"), System.Drawing.Image)
        Me.BunifuButton2.IdleIconRightImage = Nothing
        Me.BunifuButton2.Location = New System.Drawing.Point(282, 543)
        Me.BunifuButton2.Name = "BunifuButton2"
        StateProperties3.BorderColor = System.Drawing.Color.ForestGreen
        StateProperties3.BorderRadius = 1
        StateProperties3.BorderThickness = 1
        StateProperties3.FillColor = System.Drawing.Color.ForestGreen
        StateProperties3.IconLeftImage = Nothing
        StateProperties3.IconRightImage = Nothing
        Me.BunifuButton2.onHoverState = StateProperties3
        Me.BunifuButton2.Size = New System.Drawing.Size(122, 33)
        Me.BunifuButton2.TabIndex = 8
        Me.BunifuButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'bt_hapus
        '
        Me.bt_hapus.BackColor = System.Drawing.Color.Transparent
        Me.bt_hapus.BackgroundImage = CType(resources.GetObject("bt_hapus.BackgroundImage"), System.Drawing.Image)
        Me.bt_hapus.ButtonText = "Delete Data"
        Me.bt_hapus.ButtonTextMarginLeft = 0
        Me.bt_hapus.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.bt_hapus.DisabledFillColor = System.Drawing.Color.Gray
        Me.bt_hapus.DisabledForecolor = System.Drawing.Color.White
        Me.bt_hapus.Font = New System.Drawing.Font("Poor Richard", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_hapus.ForeColor = System.Drawing.Color.White
        Me.bt_hapus.IconLeftCursor = System.Windows.Forms.Cursors.Cross
        Me.bt_hapus.IconPadding = 10
        Me.bt_hapus.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.bt_hapus.IdleBorderColor = System.Drawing.Color.Crimson
        Me.bt_hapus.IdleBorderRadius = 1
        Me.bt_hapus.IdleBorderThickness = 0
        Me.bt_hapus.IdleFillColor = System.Drawing.Color.Crimson
        Me.bt_hapus.IdleIconLeftImage = CType(resources.GetObject("bt_hapus.IdleIconLeftImage"), System.Drawing.Image)
        Me.bt_hapus.IdleIconRightImage = Nothing
        Me.bt_hapus.Location = New System.Drawing.Point(726, 391)
        Me.bt_hapus.Name = "bt_hapus"
        StateProperties4.BorderColor = System.Drawing.Color.ForestGreen
        StateProperties4.BorderRadius = 1
        StateProperties4.BorderThickness = 1
        StateProperties4.FillColor = System.Drawing.Color.ForestGreen
        StateProperties4.IconLeftImage = Nothing
        StateProperties4.IconRightImage = Nothing
        Me.bt_hapus.onHoverState = StateProperties4
        Me.bt_hapus.Size = New System.Drawing.Size(122, 33)
        Me.bt_hapus.TabIndex = 8
        Me.bt_hapus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.bt_hapus.Visible = False
        '
        'BunifuButton3
        '
        Me.BunifuButton3.BackColor = System.Drawing.Color.Transparent
        Me.BunifuButton3.BackgroundImage = CType(resources.GetObject("BunifuButton3.BackgroundImage"), System.Drawing.Image)
        Me.BunifuButton3.ButtonText = "Show Data"
        Me.BunifuButton3.ButtonTextMarginLeft = 0
        Me.BunifuButton3.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.BunifuButton3.DisabledFillColor = System.Drawing.Color.Gray
        Me.BunifuButton3.DisabledForecolor = System.Drawing.Color.White
        Me.BunifuButton3.Font = New System.Drawing.Font("Poor Richard", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuButton3.ForeColor = System.Drawing.Color.White
        Me.BunifuButton3.IconLeftCursor = System.Windows.Forms.Cursors.Cross
        Me.BunifuButton3.IconPadding = 10
        Me.BunifuButton3.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.BunifuButton3.IdleBorderColor = System.Drawing.Color.ForestGreen
        Me.BunifuButton3.IdleBorderRadius = 1
        Me.BunifuButton3.IdleBorderThickness = 0
        Me.BunifuButton3.IdleFillColor = System.Drawing.Color.ForestGreen
        Me.BunifuButton3.IdleIconLeftImage = CType(resources.GetObject("BunifuButton3.IdleIconLeftImage"), System.Drawing.Image)
        Me.BunifuButton3.IdleIconRightImage = Nothing
        Me.BunifuButton3.Location = New System.Drawing.Point(726, 79)
        Me.BunifuButton3.Name = "BunifuButton3"
        StateProperties5.BorderColor = System.Drawing.Color.ForestGreen
        StateProperties5.BorderRadius = 1
        StateProperties5.BorderThickness = 1
        StateProperties5.FillColor = System.Drawing.Color.ForestGreen
        StateProperties5.IconLeftImage = Nothing
        StateProperties5.IconRightImage = Nothing
        Me.BunifuButton3.onHoverState = StateProperties5
        Me.BunifuButton3.Size = New System.Drawing.Size(122, 33)
        Me.BunifuButton3.TabIndex = 8
        Me.BunifuButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tb_id_buku
        '
        Me.tb_id_buku.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.tb_id_buku.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.tb_id_buku.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tb_id_buku.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_id_buku.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.tb_id_buku.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_id_buku.HintForeColor = System.Drawing.Color.Empty
        Me.tb_id_buku.HintText = ""
        Me.tb_id_buku.isPassword = False
        Me.tb_id_buku.LineFocusedColor = System.Drawing.Color.Blue
        Me.tb_id_buku.LineIdleColor = System.Drawing.Color.Gray
        Me.tb_id_buku.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.tb_id_buku.LineThickness = 3
        Me.tb_id_buku.Location = New System.Drawing.Point(281, 415)
        Me.tb_id_buku.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_id_buku.MaxLength = 32767
        Me.tb_id_buku.Name = "tb_id_buku"
        Me.tb_id_buku.Size = New System.Drawing.Size(215, 33)
        Me.tb_id_buku.TabIndex = 9
        Me.tb_id_buku.Text = "ID"
        Me.tb_id_buku.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.tb_id_buku.Visible = False
        '
        'tb_isbn
        '
        Me.tb_isbn.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.tb_isbn.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.tb_isbn.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tb_isbn.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_isbn.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.tb_isbn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_isbn.HintForeColor = System.Drawing.Color.Empty
        Me.tb_isbn.HintText = ""
        Me.tb_isbn.isPassword = False
        Me.tb_isbn.LineFocusedColor = System.Drawing.Color.Blue
        Me.tb_isbn.LineIdleColor = System.Drawing.Color.Gray
        Me.tb_isbn.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.tb_isbn.LineThickness = 3
        Me.tb_isbn.Location = New System.Drawing.Point(503, 415)
        Me.tb_isbn.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_isbn.MaxLength = 32767
        Me.tb_isbn.Name = "tb_isbn"
        Me.tb_isbn.Size = New System.Drawing.Size(215, 33)
        Me.tb_isbn.TabIndex = 9
        Me.tb_isbn.Text = "ISBN"
        Me.tb_isbn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'tb_pengarang
        '
        Me.tb_pengarang.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.tb_pengarang.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.tb_pengarang.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tb_pengarang.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_pengarang.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.tb_pengarang.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_pengarang.HintForeColor = System.Drawing.Color.Empty
        Me.tb_pengarang.HintText = ""
        Me.tb_pengarang.isPassword = False
        Me.tb_pengarang.LineFocusedColor = System.Drawing.Color.Blue
        Me.tb_pengarang.LineIdleColor = System.Drawing.Color.Gray
        Me.tb_pengarang.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.tb_pengarang.LineThickness = 3
        Me.tb_pengarang.Location = New System.Drawing.Point(280, 456)
        Me.tb_pengarang.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_pengarang.MaxLength = 32767
        Me.tb_pengarang.Name = "tb_pengarang"
        Me.tb_pengarang.Size = New System.Drawing.Size(215, 33)
        Me.tb_pengarang.TabIndex = 9
        Me.tb_pengarang.Text = "Pengarang"
        Me.tb_pengarang.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'tb_judul
        '
        Me.tb_judul.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.tb_judul.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.tb_judul.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tb_judul.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_judul.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.tb_judul.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_judul.HintForeColor = System.Drawing.Color.Empty
        Me.tb_judul.HintText = ""
        Me.tb_judul.isPassword = False
        Me.tb_judul.LineFocusedColor = System.Drawing.Color.Blue
        Me.tb_judul.LineIdleColor = System.Drawing.Color.Gray
        Me.tb_judul.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.tb_judul.LineThickness = 3
        Me.tb_judul.Location = New System.Drawing.Point(280, 415)
        Me.tb_judul.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_judul.MaxLength = 32767
        Me.tb_judul.Name = "tb_judul"
        Me.tb_judul.Size = New System.Drawing.Size(215, 33)
        Me.tb_judul.TabIndex = 9
        Me.tb_judul.Text = "Judul Buku"
        Me.tb_judul.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'tb_penerbit
        '
        Me.tb_penerbit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.tb_penerbit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.tb_penerbit.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tb_penerbit.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_penerbit.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.tb_penerbit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_penerbit.HintForeColor = System.Drawing.Color.Empty
        Me.tb_penerbit.HintText = ""
        Me.tb_penerbit.isPassword = False
        Me.tb_penerbit.LineFocusedColor = System.Drawing.Color.Blue
        Me.tb_penerbit.LineIdleColor = System.Drawing.Color.Gray
        Me.tb_penerbit.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.tb_penerbit.LineThickness = 3
        Me.tb_penerbit.Location = New System.Drawing.Point(503, 456)
        Me.tb_penerbit.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_penerbit.MaxLength = 32767
        Me.tb_penerbit.Name = "tb_penerbit"
        Me.tb_penerbit.Size = New System.Drawing.Size(215, 33)
        Me.tb_penerbit.TabIndex = 9
        Me.tb_penerbit.Text = "Penerbit"
        Me.tb_penerbit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'tb_search
        '
        Me.tb_search.AcceptsReturn = False
        Me.tb_search.AcceptsTab = False
        Me.tb_search.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.tb_search.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.tb_search.BackColor = System.Drawing.Color.Transparent
        Me.tb_search.BackgroundImage = CType(resources.GetObject("tb_search.BackgroundImage"), System.Drawing.Image)
        Me.tb_search.BorderColorActive = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(145, Byte), Integer))
        Me.tb_search.BorderColorDisabled = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.tb_search.BorderColorHover = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.tb_search.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.tb_search.BorderRadius = 1
        Me.tb_search.BorderThickness = 2
        Me.tb_search.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tb_search.DefaultFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_search.DefaultText = ""
        Me.tb_search.FillColor = System.Drawing.Color.White
        Me.tb_search.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tb_search.HideSelection = True
        Me.tb_search.IconLeft = CType(resources.GetObject("tb_search.IconLeft"), System.Drawing.Image)
        Me.tb_search.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.tb_search.IconPadding = 10
        Me.tb_search.IconRight = Nothing
        Me.tb_search.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.tb_search.Location = New System.Drawing.Point(281, 77)
        Me.tb_search.MaxLength = 32767
        Me.tb_search.MinimumSize = New System.Drawing.Size(100, 35)
        Me.tb_search.Modified = False
        Me.tb_search.Name = "tb_search"
        Me.tb_search.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tb_search.ReadOnly = False
        Me.tb_search.SelectedText = ""
        Me.tb_search.SelectionLength = 0
        Me.tb_search.SelectionStart = 0
        Me.tb_search.ShortcutsEnabled = True
        Me.tb_search.Size = New System.Drawing.Size(200, 36)
        Me.tb_search.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu
        Me.tb_search.TabIndex = 11
        Me.tb_search.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.tb_search.TextMarginLeft = 5
        Me.tb_search.TextPlaceholder = ""
        Me.tb_search.UseSystemPasswordChar = False
        '
        'PanelRight
        '
        Me.PanelRight.Controls.Add(Me.PanelLeft)
        Me.PanelRight.Controls.Add(Me.tb_search)
        Me.PanelRight.Controls.Add(Me.tb_halaman)
        Me.PanelRight.Controls.Add(Me.tb_penerbit)
        Me.PanelRight.Controls.Add(Me.tb_tahun_terbit)
        Me.PanelRight.Controls.Add(Me.tb_pengarang)
        Me.PanelRight.Controls.Add(Me.tb_isbn)
        Me.PanelRight.Controls.Add(Me.BunifuButton3)
        Me.PanelRight.Controls.Add(Me.bt_hapus)
        Me.PanelRight.Controls.Add(Me.BunifuButton2)
        Me.PanelRight.Controls.Add(Me.BunifuButton4)
        Me.PanelRight.Controls.Add(Me.add_member)
        Me.PanelRight.Controls.Add(Me.DataGridView1)
        Me.PanelRight.Controls.Add(Me.welcome)
        Me.PanelRight.Controls.Add(Me.Label5)
        Me.PanelRight.Controls.Add(Me.tb_judul)
        Me.PanelRight.Controls.Add(Me.tb_id_buku)
        Me.PanelRight.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelRight.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelRight.Location = New System.Drawing.Point(0, 0)
        Me.PanelRight.Name = "PanelRight"
        Me.PanelRight.Size = New System.Drawing.Size(860, 602)
        Me.PanelRight.TabIndex = 9
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
        Me.PanelLeft.TabIndex = 12
        '
        'BunifuFlatButton1
        '
        Me.BunifuFlatButton1.Active = False
        Me.BunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.BunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.BunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton1.BorderRadius = 0
        Me.BunifuFlatButton1.ButtonText = "  Home"
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
        Me.BunifuFlatButton1.Location = New System.Drawing.Point(80, 424)
        Me.BunifuFlatButton1.Name = "BunifuFlatButton1"
        Me.BunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.BunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton1.selected = False
        Me.BunifuFlatButton1.Size = New System.Drawing.Size(101, 48)
        Me.BunifuFlatButton1.TabIndex = 4
        Me.BunifuFlatButton1.Text = "  Home"
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
        Me.BunifuThinButton23.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
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
        Me.BunifuThinButton22.IdleFillColor = System.Drawing.Color.Transparent
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
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        'tb_halaman
        '
        Me.tb_halaman.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.tb_halaman.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.tb_halaman.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tb_halaman.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_halaman.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.tb_halaman.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_halaman.HintForeColor = System.Drawing.Color.Empty
        Me.tb_halaman.HintText = ""
        Me.tb_halaman.isPassword = False
        Me.tb_halaman.LineFocusedColor = System.Drawing.Color.Blue
        Me.tb_halaman.LineIdleColor = System.Drawing.Color.Gray
        Me.tb_halaman.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.tb_halaman.LineThickness = 3
        Me.tb_halaman.Location = New System.Drawing.Point(503, 497)
        Me.tb_halaman.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_halaman.MaxLength = 32767
        Me.tb_halaman.Name = "tb_halaman"
        Me.tb_halaman.Size = New System.Drawing.Size(215, 33)
        Me.tb_halaman.TabIndex = 9
        Me.tb_halaman.Text = "Jumlah Halaman"
        Me.tb_halaman.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'tb_tahun_terbit
        '
        Me.tb_tahun_terbit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.tb_tahun_terbit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.tb_tahun_terbit.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tb_tahun_terbit.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_tahun_terbit.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.tb_tahun_terbit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_tahun_terbit.HintForeColor = System.Drawing.Color.Empty
        Me.tb_tahun_terbit.HintText = ""
        Me.tb_tahun_terbit.isPassword = False
        Me.tb_tahun_terbit.LineFocusedColor = System.Drawing.Color.Blue
        Me.tb_tahun_terbit.LineIdleColor = System.Drawing.Color.Gray
        Me.tb_tahun_terbit.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.tb_tahun_terbit.LineThickness = 3
        Me.tb_tahun_terbit.Location = New System.Drawing.Point(280, 497)
        Me.tb_tahun_terbit.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_tahun_terbit.MaxLength = 32767
        Me.tb_tahun_terbit.Name = "tb_tahun_terbit"
        Me.tb_tahun_terbit.Size = New System.Drawing.Size(215, 33)
        Me.tb_tahun_terbit.TabIndex = 9
        Me.tb_tahun_terbit.Text = "Tahun Terbit"
        Me.tb_tahun_terbit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuLabel1
        '
        Me.BunifuLabel1.AutoSize = False
        Me.BunifuLabel1.CursorType = Nothing
        Me.BunifuLabel1.Font = New System.Drawing.Font("Poor Richard", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuLabel1.Location = New System.Drawing.Point(6, 395)
        Me.BunifuLabel1.Name = "BunifuLabel1"
        Me.BunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel1.Size = New System.Drawing.Size(312, 21)
        Me.BunifuLabel1.TabIndex = 10
        Me.BunifuLabel1.Text = "*Select Row Before Update / Or Delete The Data"
        Me.BunifuLabel1.TextAlign = Bunifu.UI.WinForms.BunifuLabel.TextAlignments.Left
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Nothing
        Me.BunifuDragControl1.Vertical = True
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 35
        Me.BunifuElipse1.TargetControl = Me
        '
        'Form8
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(860, 602)
        Me.Controls.Add(Me.PanelRight)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form8"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form8"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelRight.ResumeLayout(False)
        Me.PanelRight.PerformLayout()
        Me.PanelLeft.ResumeLayout(False)
        Me.PanelLeft.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents welcome As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents add_member As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents BunifuButton4 As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents BunifuButton2 As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents bt_hapus As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents BunifuButton3 As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents tb_id_buku As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents tb_isbn As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents tb_pengarang As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents tb_judul As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents tb_penerbit As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents tb_search As Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox
    Friend WithEvents PanelRight As Panel
    Friend WithEvents BunifuLabel1 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
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
    Friend WithEvents tb_halaman As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents tb_tahun_terbit As Bunifu.Framework.UI.BunifuMaterialTextbox
End Class
