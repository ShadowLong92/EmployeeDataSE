<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProfileBasic
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
        Dim IDLabel As System.Windows.Forms.Label
        Dim NamaPegawaiLabel As System.Windows.Forms.Label
        Dim NoJbtLabel As System.Windows.Forms.Label
        Dim NoPengenalanLabel As System.Windows.Forms.Label
        Dim NoKWSPLabel As System.Windows.Forms.Label
        Dim TarikhLahirLabel As System.Windows.Forms.Label
        Dim TempatLahirLabel As System.Windows.Forms.Label
        Dim AlamatRumahLabel As System.Windows.Forms.Label
        Dim JantinaLabel As System.Windows.Forms.Label
        Dim AgamaLabel As System.Windows.Forms.Label
        Dim Waris1Label As System.Windows.Forms.Label
        Dim Waris2Label As System.Windows.Forms.Label
        Dim KelayakanLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProfileBasic))
        Me.ProfileBasicBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.ProfileBasicBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmployeeDataSEDS = New EmployeeDataSE.EmployeeDataSEDS()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ProfileBasicBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.NamaPegawaiTextBox = New System.Windows.Forms.TextBox()
        Me.NoJbtTextBox = New System.Windows.Forms.TextBox()
        Me.NoPengenalanTextBox = New System.Windows.Forms.TextBox()
        Me.NoKWSPTextBox = New System.Windows.Forms.TextBox()
        Me.TarikhLahirDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.TempatLahirTextBox = New System.Windows.Forms.TextBox()
        Me.AlamatRumahTextBox = New System.Windows.Forms.TextBox()
        Me.JantinaComboBox = New System.Windows.Forms.ComboBox()
        Me.AgamaComboBox = New System.Windows.Forms.ComboBox()
        Me.Waris1TextBox = New System.Windows.Forms.TextBox()
        Me.Waris2TextBox = New System.Windows.Forms.TextBox()
        Me.KelayakanComboBox = New System.Windows.Forms.ComboBox()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.ProfileBasicTableAdapter = New EmployeeDataSE.EmployeeDataSEDSTableAdapters.ProfileBasicTableAdapter()
        Me.TableAdapterManager = New EmployeeDataSE.EmployeeDataSEDSTableAdapters.TableAdapterManager()
        Me.TimerId = New System.Windows.Forms.Timer(Me.components)
        Me.JantinaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.JantinaTableAdapter = New EmployeeDataSE.EmployeeDataSEDSTableAdapters.JantinaTableAdapter()
        Me.AgamaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AgamaTableAdapter = New EmployeeDataSE.EmployeeDataSEDSTableAdapters.AgamaTableAdapter()
        Me.KelayakanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KelayakanTableAdapter = New EmployeeDataSE.EmployeeDataSEDSTableAdapters.KelayakanTableAdapter()
        IDLabel = New System.Windows.Forms.Label()
        NamaPegawaiLabel = New System.Windows.Forms.Label()
        NoJbtLabel = New System.Windows.Forms.Label()
        NoPengenalanLabel = New System.Windows.Forms.Label()
        NoKWSPLabel = New System.Windows.Forms.Label()
        TarikhLahirLabel = New System.Windows.Forms.Label()
        TempatLahirLabel = New System.Windows.Forms.Label()
        AlamatRumahLabel = New System.Windows.Forms.Label()
        JantinaLabel = New System.Windows.Forms.Label()
        AgamaLabel = New System.Windows.Forms.Label()
        Waris1Label = New System.Windows.Forms.Label()
        Waris2Label = New System.Windows.Forms.Label()
        KelayakanLabel = New System.Windows.Forms.Label()
        CType(Me.ProfileBasicBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ProfileBasicBindingNavigator.SuspendLayout()
        CType(Me.ProfileBasicBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeeDataSEDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JantinaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AgamaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KelayakanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(100, 120)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(22, 13)
        IDLabel.TabIndex = 1
        IDLabel.Text = "ID:"
        '
        'NamaPegawaiLabel
        '
        NamaPegawaiLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        NamaPegawaiLabel.AutoSize = True
        NamaPegawaiLabel.Location = New System.Drawing.Point(100, 147)
        NamaPegawaiLabel.Name = "NamaPegawaiLabel"
        NamaPegawaiLabel.Size = New System.Drawing.Size(81, 13)
        NamaPegawaiLabel.TabIndex = 3
        NamaPegawaiLabel.Text = "Nama Pegawai:"
        '
        'NoJbtLabel
        '
        NoJbtLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        NoJbtLabel.AutoSize = True
        NoJbtLabel.Location = New System.Drawing.Point(100, 174)
        NoJbtLabel.Name = "NoJbtLabel"
        NoJbtLabel.Size = New System.Drawing.Size(42, 13)
        NoJbtLabel.TabIndex = 5
        NoJbtLabel.Text = "No Jbt:"
        '
        'NoPengenalanLabel
        '
        NoPengenalanLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        NoPengenalanLabel.AutoSize = True
        NoPengenalanLabel.Location = New System.Drawing.Point(100, 201)
        NoPengenalanLabel.Name = "NoPengenalanLabel"
        NoPengenalanLabel.Size = New System.Drawing.Size(83, 13)
        NoPengenalanLabel.TabIndex = 7
        NoPengenalanLabel.Text = "No Pengenalan:"
        '
        'NoKWSPLabel
        '
        NoKWSPLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        NoKWSPLabel.AutoSize = True
        NoKWSPLabel.Location = New System.Drawing.Point(100, 228)
        NoKWSPLabel.Name = "NoKWSPLabel"
        NoKWSPLabel.Size = New System.Drawing.Size(55, 13)
        NoKWSPLabel.TabIndex = 9
        NoKWSPLabel.Text = "No KWSP:"
        '
        'TarikhLahirLabel
        '
        TarikhLahirLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        TarikhLahirLabel.AutoSize = True
        TarikhLahirLabel.Location = New System.Drawing.Point(100, 256)
        TarikhLahirLabel.Name = "TarikhLahirLabel"
        TarikhLahirLabel.Size = New System.Drawing.Size(66, 13)
        TarikhLahirLabel.TabIndex = 11
        TarikhLahirLabel.Text = "Tarikh Lahir:"
        '
        'TempatLahirLabel
        '
        TempatLahirLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        TempatLahirLabel.AutoSize = True
        TempatLahirLabel.Location = New System.Drawing.Point(100, 282)
        TempatLahirLabel.Name = "TempatLahirLabel"
        TempatLahirLabel.Size = New System.Drawing.Size(73, 13)
        TempatLahirLabel.TabIndex = 13
        TempatLahirLabel.Text = "Tempat Lahir:"
        '
        'AlamatRumahLabel
        '
        AlamatRumahLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        AlamatRumahLabel.AutoSize = True
        AlamatRumahLabel.Location = New System.Drawing.Point(100, 368)
        AlamatRumahLabel.Name = "AlamatRumahLabel"
        AlamatRumahLabel.Size = New System.Drawing.Size(80, 13)
        AlamatRumahLabel.TabIndex = 15
        AlamatRumahLabel.Text = "Alamat Rumah:"
        '
        'JantinaLabel
        '
        JantinaLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        JantinaLabel.AutoSize = True
        JantinaLabel.Location = New System.Drawing.Point(395, 147)
        JantinaLabel.Name = "JantinaLabel"
        JantinaLabel.Size = New System.Drawing.Size(46, 13)
        JantinaLabel.TabIndex = 17
        JantinaLabel.Text = "Jantina:"
        '
        'AgamaLabel
        '
        AgamaLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        AgamaLabel.AutoSize = True
        AgamaLabel.Location = New System.Drawing.Point(395, 174)
        AgamaLabel.Name = "AgamaLabel"
        AgamaLabel.Size = New System.Drawing.Size(44, 13)
        AgamaLabel.TabIndex = 19
        AgamaLabel.Text = "Agama:"
        '
        'Waris1Label
        '
        Waris1Label.Anchor = System.Windows.Forms.AnchorStyles.None
        Waris1Label.AutoSize = True
        Waris1Label.Location = New System.Drawing.Point(395, 201)
        Waris1Label.Name = "Waris1Label"
        Waris1Label.Size = New System.Drawing.Size(44, 13)
        Waris1Label.TabIndex = 21
        Waris1Label.Text = "Waris1:"
        '
        'Waris2Label
        '
        Waris2Label.Anchor = System.Windows.Forms.AnchorStyles.None
        Waris2Label.AutoSize = True
        Waris2Label.Location = New System.Drawing.Point(395, 228)
        Waris2Label.Name = "Waris2Label"
        Waris2Label.Size = New System.Drawing.Size(44, 13)
        Waris2Label.TabIndex = 23
        Waris2Label.Text = "Waris2:"
        '
        'KelayakanLabel
        '
        KelayakanLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        KelayakanLabel.AutoSize = True
        KelayakanLabel.Location = New System.Drawing.Point(395, 255)
        KelayakanLabel.Name = "KelayakanLabel"
        KelayakanLabel.Size = New System.Drawing.Size(60, 13)
        KelayakanLabel.TabIndex = 25
        KelayakanLabel.Text = "Kelayakan:"
        '
        'ProfileBasicBindingNavigator
        '
        Me.ProfileBasicBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ProfileBasicBindingNavigator.BindingSource = Me.ProfileBasicBindingSource
        Me.ProfileBasicBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ProfileBasicBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ProfileBasicBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ProfileBasicBindingNavigatorSaveItem})
        Me.ProfileBasicBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ProfileBasicBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ProfileBasicBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ProfileBasicBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ProfileBasicBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ProfileBasicBindingNavigator.Name = "ProfileBasicBindingNavigator"
        Me.ProfileBasicBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ProfileBasicBindingNavigator.Size = New System.Drawing.Size(784, 25)
        Me.ProfileBasicBindingNavigator.TabIndex = 0
        Me.ProfileBasicBindingNavigator.Text = "BindingNavigator1"
        Me.ProfileBasicBindingNavigator.Visible = False
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'ProfileBasicBindingSource
        '
        Me.ProfileBasicBindingSource.DataMember = "ProfileBasic"
        Me.ProfileBasicBindingSource.DataSource = Me.EmployeeDataSEDS
        '
        'EmployeeDataSEDS
        '
        Me.EmployeeDataSEDS.DataSetName = "EmployeeDataSEDS"
        Me.EmployeeDataSEDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ProfileBasicBindingNavigatorSaveItem
        '
        Me.ProfileBasicBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ProfileBasicBindingNavigatorSaveItem.Image = CType(resources.GetObject("ProfileBasicBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ProfileBasicBindingNavigatorSaveItem.Name = "ProfileBasicBindingNavigatorSaveItem"
        Me.ProfileBasicBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ProfileBasicBindingNavigatorSaveItem.Text = "Save Data"
        '
        'IDTextBox
        '
        Me.IDTextBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProfileBasicBindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(189, 117)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.ReadOnly = True
        Me.IDTextBox.Size = New System.Drawing.Size(200, 21)
        Me.IDTextBox.TabIndex = 2
        '
        'NamaPegawaiTextBox
        '
        Me.NamaPegawaiTextBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.NamaPegawaiTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProfileBasicBindingSource, "NamaPegawai", True))
        Me.NamaPegawaiTextBox.Location = New System.Drawing.Point(189, 144)
        Me.NamaPegawaiTextBox.Name = "NamaPegawaiTextBox"
        Me.NamaPegawaiTextBox.Size = New System.Drawing.Size(200, 21)
        Me.NamaPegawaiTextBox.TabIndex = 4
        '
        'NoJbtTextBox
        '
        Me.NoJbtTextBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.NoJbtTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProfileBasicBindingSource, "NoJbt", True))
        Me.NoJbtTextBox.Location = New System.Drawing.Point(189, 171)
        Me.NoJbtTextBox.Name = "NoJbtTextBox"
        Me.NoJbtTextBox.Size = New System.Drawing.Size(200, 21)
        Me.NoJbtTextBox.TabIndex = 6
        '
        'NoPengenalanTextBox
        '
        Me.NoPengenalanTextBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.NoPengenalanTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProfileBasicBindingSource, "NoPengenalan", True))
        Me.NoPengenalanTextBox.Location = New System.Drawing.Point(189, 198)
        Me.NoPengenalanTextBox.Name = "NoPengenalanTextBox"
        Me.NoPengenalanTextBox.Size = New System.Drawing.Size(200, 21)
        Me.NoPengenalanTextBox.TabIndex = 8
        '
        'NoKWSPTextBox
        '
        Me.NoKWSPTextBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.NoKWSPTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProfileBasicBindingSource, "NoKWSP", True))
        Me.NoKWSPTextBox.Location = New System.Drawing.Point(189, 225)
        Me.NoKWSPTextBox.Name = "NoKWSPTextBox"
        Me.NoKWSPTextBox.Size = New System.Drawing.Size(200, 21)
        Me.NoKWSPTextBox.TabIndex = 10
        '
        'TarikhLahirDateTimePicker
        '
        Me.TarikhLahirDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TarikhLahirDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ProfileBasicBindingSource, "TarikhLahir", True))
        Me.TarikhLahirDateTimePicker.Location = New System.Drawing.Point(189, 252)
        Me.TarikhLahirDateTimePicker.Name = "TarikhLahirDateTimePicker"
        Me.TarikhLahirDateTimePicker.Size = New System.Drawing.Size(200, 21)
        Me.TarikhLahirDateTimePicker.TabIndex = 12
        '
        'TempatLahirTextBox
        '
        Me.TempatLahirTextBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TempatLahirTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProfileBasicBindingSource, "TempatLahir", True))
        Me.TempatLahirTextBox.Location = New System.Drawing.Point(189, 279)
        Me.TempatLahirTextBox.Multiline = True
        Me.TempatLahirTextBox.Name = "TempatLahirTextBox"
        Me.TempatLahirTextBox.Size = New System.Drawing.Size(495, 80)
        Me.TempatLahirTextBox.TabIndex = 14
        '
        'AlamatRumahTextBox
        '
        Me.AlamatRumahTextBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.AlamatRumahTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProfileBasicBindingSource, "AlamatRumah", True))
        Me.AlamatRumahTextBox.Location = New System.Drawing.Point(189, 365)
        Me.AlamatRumahTextBox.Multiline = True
        Me.AlamatRumahTextBox.Name = "AlamatRumahTextBox"
        Me.AlamatRumahTextBox.Size = New System.Drawing.Size(495, 80)
        Me.AlamatRumahTextBox.TabIndex = 16
        '
        'JantinaComboBox
        '
        Me.JantinaComboBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.JantinaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProfileBasicBindingSource, "Jantina", True))
        Me.JantinaComboBox.DataSource = Me.JantinaBindingSource
        Me.JantinaComboBox.DisplayMember = "Sex"
        Me.JantinaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.JantinaComboBox.FormattingEnabled = True
        Me.JantinaComboBox.Location = New System.Drawing.Point(484, 144)
        Me.JantinaComboBox.Name = "JantinaComboBox"
        Me.JantinaComboBox.Size = New System.Drawing.Size(200, 21)
        Me.JantinaComboBox.TabIndex = 18
        '
        'AgamaComboBox
        '
        Me.AgamaComboBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.AgamaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProfileBasicBindingSource, "Agama", True))
        Me.AgamaComboBox.DataSource = Me.AgamaBindingSource
        Me.AgamaComboBox.DisplayMember = "Agama"
        Me.AgamaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.AgamaComboBox.FormattingEnabled = True
        Me.AgamaComboBox.Location = New System.Drawing.Point(484, 171)
        Me.AgamaComboBox.Name = "AgamaComboBox"
        Me.AgamaComboBox.Size = New System.Drawing.Size(200, 21)
        Me.AgamaComboBox.TabIndex = 20
        '
        'Waris1TextBox
        '
        Me.Waris1TextBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Waris1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProfileBasicBindingSource, "Waris1", True))
        Me.Waris1TextBox.Location = New System.Drawing.Point(484, 198)
        Me.Waris1TextBox.Name = "Waris1TextBox"
        Me.Waris1TextBox.Size = New System.Drawing.Size(200, 21)
        Me.Waris1TextBox.TabIndex = 22
        '
        'Waris2TextBox
        '
        Me.Waris2TextBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Waris2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProfileBasicBindingSource, "Waris2", True))
        Me.Waris2TextBox.Location = New System.Drawing.Point(484, 225)
        Me.Waris2TextBox.Name = "Waris2TextBox"
        Me.Waris2TextBox.Size = New System.Drawing.Size(200, 21)
        Me.Waris2TextBox.TabIndex = 24
        '
        'KelayakanComboBox
        '
        Me.KelayakanComboBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.KelayakanComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProfileBasicBindingSource, "Kelayakan", True))
        Me.KelayakanComboBox.DataSource = Me.KelayakanBindingSource
        Me.KelayakanComboBox.DisplayMember = "Kelulusan"
        Me.KelayakanComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.KelayakanComboBox.FormattingEnabled = True
        Me.KelayakanComboBox.Location = New System.Drawing.Point(484, 252)
        Me.KelayakanComboBox.Name = "KelayakanComboBox"
        Me.KelayakanComboBox.Size = New System.Drawing.Size(200, 21)
        Me.KelayakanComboBox.TabIndex = 26
        '
        'btnNext
        '
        Me.btnNext.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnNext.Location = New System.Drawing.Point(652, 527)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(120, 23)
        Me.btnNext.TabIndex = 27
        Me.btnNext.Text = "&Seterusnya >"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'ProfileBasicTableAdapter
        '
        Me.ProfileBasicTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AgamaTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.JantinaTableAdapter = Nothing
        Me.TableAdapterManager.JawatanTableAdapter = Nothing
        Me.TableAdapterManager.KelayakanTableAdapter = Nothing
        Me.TableAdapterManager.ProfileAdvanceTableAdapter = Nothing
        Me.TableAdapterManager.ProfileBasicTableAdapter = Me.ProfileBasicTableAdapter
        Me.TableAdapterManager.StatusKerjaTableAdapter = Nothing
        Me.TableAdapterManager.UmurPencenTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = EmployeeDataSE.EmployeeDataSEDSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UserTableAdapter = Nothing
        '
        'TimerId
        '
        '
        'JantinaBindingSource
        '
        Me.JantinaBindingSource.DataMember = "Jantina"
        Me.JantinaBindingSource.DataSource = Me.EmployeeDataSEDS
        '
        'JantinaTableAdapter
        '
        Me.JantinaTableAdapter.ClearBeforeFill = True
        '
        'AgamaBindingSource
        '
        Me.AgamaBindingSource.DataMember = "Agama"
        Me.AgamaBindingSource.DataSource = Me.EmployeeDataSEDS
        '
        'AgamaTableAdapter
        '
        Me.AgamaTableAdapter.ClearBeforeFill = True
        '
        'KelayakanBindingSource
        '
        Me.KelayakanBindingSource.DataMember = "Kelayakan"
        Me.KelayakanBindingSource.DataSource = Me.EmployeeDataSEDS
        '
        'KelayakanTableAdapter
        '
        Me.KelayakanTableAdapter.ClearBeforeFill = True
        '
        'frmProfileBasic
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(NamaPegawaiLabel)
        Me.Controls.Add(Me.NamaPegawaiTextBox)
        Me.Controls.Add(NoJbtLabel)
        Me.Controls.Add(Me.NoJbtTextBox)
        Me.Controls.Add(NoPengenalanLabel)
        Me.Controls.Add(Me.NoPengenalanTextBox)
        Me.Controls.Add(NoKWSPLabel)
        Me.Controls.Add(Me.NoKWSPTextBox)
        Me.Controls.Add(TarikhLahirLabel)
        Me.Controls.Add(Me.TarikhLahirDateTimePicker)
        Me.Controls.Add(TempatLahirLabel)
        Me.Controls.Add(Me.TempatLahirTextBox)
        Me.Controls.Add(AlamatRumahLabel)
        Me.Controls.Add(Me.AlamatRumahTextBox)
        Me.Controls.Add(JantinaLabel)
        Me.Controls.Add(Me.JantinaComboBox)
        Me.Controls.Add(AgamaLabel)
        Me.Controls.Add(Me.AgamaComboBox)
        Me.Controls.Add(Waris1Label)
        Me.Controls.Add(Me.Waris1TextBox)
        Me.Controls.Add(Waris2Label)
        Me.Controls.Add(Me.Waris2TextBox)
        Me.Controls.Add(KelayakanLabel)
        Me.Controls.Add(Me.KelayakanComboBox)
        Me.Controls.Add(Me.ProfileBasicBindingNavigator)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frmProfileBasic"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmProfileBasic"
        CType(Me.ProfileBasicBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ProfileBasicBindingNavigator.ResumeLayout(False)
        Me.ProfileBasicBindingNavigator.PerformLayout()
        CType(Me.ProfileBasicBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeeDataSEDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JantinaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AgamaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KelayakanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents EmployeeDataSEDS As EmployeeDataSE.EmployeeDataSEDS
    Friend WithEvents ProfileBasicBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProfileBasicTableAdapter As EmployeeDataSE.EmployeeDataSEDSTableAdapters.ProfileBasicTableAdapter
    Friend WithEvents TableAdapterManager As EmployeeDataSE.EmployeeDataSEDSTableAdapters.TableAdapterManager
    Friend WithEvents ProfileBasicBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ProfileBasicBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NamaPegawaiTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NoJbtTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NoPengenalanTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NoKWSPTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TarikhLahirDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents TempatLahirTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AlamatRumahTextBox As System.Windows.Forms.TextBox
    Friend WithEvents JantinaComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents AgamaComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Waris1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Waris2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents KelayakanComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents TimerId As System.Windows.Forms.Timer
    Friend WithEvents JantinaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents JantinaTableAdapter As EmployeeDataSE.EmployeeDataSEDSTableAdapters.JantinaTableAdapter
    Friend WithEvents AgamaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AgamaTableAdapter As EmployeeDataSE.EmployeeDataSEDSTableAdapters.AgamaTableAdapter
    Friend WithEvents KelayakanBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents KelayakanTableAdapter As EmployeeDataSE.EmployeeDataSEDSTableAdapters.KelayakanTableAdapter
End Class
