<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEVProfileAdvance
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
        Dim StatusLabel As System.Windows.Forms.Label
        Dim TarikhDilantikLabel As System.Windows.Forms.Label
        Dim TarikhPengesahanLantikanLabel As System.Windows.Forms.Label
        Dim DisahkanDalamJawatanLabel As System.Windows.Forms.Label
        Dim PilihanUmurPersaraanLabel As System.Windows.Forms.Label
        Dim TarikhPersaraanWajibLabel As System.Windows.Forms.Label
        Dim CutiYangBerkaitanLabel As System.Windows.Forms.Label
        Dim KursusKursusLabel As System.Windows.Forms.Label
        Dim APCLabel As System.Windows.Forms.Label
        Dim TindakkanTatatertibLabel As System.Windows.Forms.Label
        Dim SejarahLantikanLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEVProfileAdvance))
        Me.EmployeeDataSEDS = New EmployeeDataSE.EmployeeDataSEDS()
        Me.ProfileAdvanceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProfileAdvanceTableAdapter = New EmployeeDataSE.EmployeeDataSEDSTableAdapters.ProfileAdvanceTableAdapter()
        Me.TableAdapterManager = New EmployeeDataSE.EmployeeDataSEDSTableAdapters.TableAdapterManager()
        Me.ProfileAdvanceBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
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
        Me.ProfileAdvanceBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.StatusTextBox = New System.Windows.Forms.TextBox()
        Me.TarikhDilantikDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.TarikhPengesahanLantikanDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.DisahkanDalamJawatanComboBox = New System.Windows.Forms.ComboBox()
        Me.PilihanUmurPersaraanComboBox = New System.Windows.Forms.ComboBox()
        Me.TarikhPersaraanWajibDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.CutiYangBerkaitanComboBox = New System.Windows.Forms.ComboBox()
        Me.KursusKursusTextBox = New System.Windows.Forms.TextBox()
        Me.APCTextBox = New System.Windows.Forms.TextBox()
        Me.TindakkanTatatertibTextBox = New System.Windows.Forms.TextBox()
        Me.SejarahLantikanTextBox = New System.Windows.Forms.TextBox()
        Me.btnReport = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        IDLabel = New System.Windows.Forms.Label()
        StatusLabel = New System.Windows.Forms.Label()
        TarikhDilantikLabel = New System.Windows.Forms.Label()
        TarikhPengesahanLantikanLabel = New System.Windows.Forms.Label()
        DisahkanDalamJawatanLabel = New System.Windows.Forms.Label()
        PilihanUmurPersaraanLabel = New System.Windows.Forms.Label()
        TarikhPersaraanWajibLabel = New System.Windows.Forms.Label()
        CutiYangBerkaitanLabel = New System.Windows.Forms.Label()
        KursusKursusLabel = New System.Windows.Forms.Label()
        APCLabel = New System.Windows.Forms.Label()
        TindakkanTatatertibLabel = New System.Windows.Forms.Label()
        SejarahLantikanLabel = New System.Windows.Forms.Label()
        CType(Me.EmployeeDataSEDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProfileAdvanceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProfileAdvanceBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ProfileAdvanceBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(38, 80)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(22, 13)
        IDLabel.TabIndex = 1
        IDLabel.Text = "ID:"
        '
        'StatusLabel
        '
        StatusLabel.AutoSize = True
        StatusLabel.Location = New System.Drawing.Point(38, 107)
        StatusLabel.Name = "StatusLabel"
        StatusLabel.Size = New System.Drawing.Size(42, 13)
        StatusLabel.TabIndex = 3
        StatusLabel.Text = "Status:"
        '
        'TarikhDilantikLabel
        '
        TarikhDilantikLabel.AutoSize = True
        TarikhDilantikLabel.Location = New System.Drawing.Point(38, 135)
        TarikhDilantikLabel.Name = "TarikhDilantikLabel"
        TarikhDilantikLabel.Size = New System.Drawing.Size(77, 13)
        TarikhDilantikLabel.TabIndex = 5
        TarikhDilantikLabel.Text = "Tarikh Dilantik:"
        '
        'TarikhPengesahanLantikanLabel
        '
        TarikhPengesahanLantikanLabel.AutoSize = True
        TarikhPengesahanLantikanLabel.Location = New System.Drawing.Point(38, 162)
        TarikhPengesahanLantikanLabel.Name = "TarikhPengesahanLantikanLabel"
        TarikhPengesahanLantikanLabel.Size = New System.Drawing.Size(145, 13)
        TarikhPengesahanLantikanLabel.TabIndex = 7
        TarikhPengesahanLantikanLabel.Text = "Tarikh Pengesahan Lantikan:"
        '
        'DisahkanDalamJawatanLabel
        '
        DisahkanDalamJawatanLabel.AutoSize = True
        DisahkanDalamJawatanLabel.Location = New System.Drawing.Point(38, 188)
        DisahkanDalamJawatanLabel.Name = "DisahkanDalamJawatanLabel"
        DisahkanDalamJawatanLabel.Size = New System.Drawing.Size(130, 13)
        DisahkanDalamJawatanLabel.TabIndex = 9
        DisahkanDalamJawatanLabel.Text = "Disahkan Dalam Jawatan:"
        '
        'PilihanUmurPersaraanLabel
        '
        PilihanUmurPersaraanLabel.AutoSize = True
        PilihanUmurPersaraanLabel.Location = New System.Drawing.Point(38, 215)
        PilihanUmurPersaraanLabel.Name = "PilihanUmurPersaraanLabel"
        PilihanUmurPersaraanLabel.Size = New System.Drawing.Size(121, 13)
        PilihanUmurPersaraanLabel.TabIndex = 11
        PilihanUmurPersaraanLabel.Text = "Pilihan Umur Persaraan:"
        '
        'TarikhPersaraanWajibLabel
        '
        TarikhPersaraanWajibLabel.AutoSize = True
        TarikhPersaraanWajibLabel.Location = New System.Drawing.Point(38, 243)
        TarikhPersaraanWajibLabel.Name = "TarikhPersaraanWajibLabel"
        TarikhPersaraanWajibLabel.Size = New System.Drawing.Size(122, 13)
        TarikhPersaraanWajibLabel.TabIndex = 13
        TarikhPersaraanWajibLabel.Text = "Tarikh Persaraan Wajib:"
        '
        'CutiYangBerkaitanLabel
        '
        CutiYangBerkaitanLabel.AutoSize = True
        CutiYangBerkaitanLabel.Location = New System.Drawing.Point(38, 269)
        CutiYangBerkaitanLabel.Name = "CutiYangBerkaitanLabel"
        CutiYangBerkaitanLabel.Size = New System.Drawing.Size(105, 13)
        CutiYangBerkaitanLabel.TabIndex = 15
        CutiYangBerkaitanLabel.Text = "Cuti Yang Berkaitan:"
        '
        'KursusKursusLabel
        '
        KursusKursusLabel.AutoSize = True
        KursusKursusLabel.Location = New System.Drawing.Point(38, 329)
        KursusKursusLabel.Name = "KursusKursusLabel"
        KursusKursusLabel.Size = New System.Drawing.Size(78, 13)
        KursusKursusLabel.TabIndex = 17
        KursusKursusLabel.Text = "Kursus Kursus:"
        '
        'APCLabel
        '
        APCLabel.AutoSize = True
        APCLabel.Location = New System.Drawing.Point(38, 395)
        APCLabel.Name = "APCLabel"
        APCLabel.Size = New System.Drawing.Size(31, 13)
        APCLabel.TabIndex = 19
        APCLabel.Text = "APC:"
        '
        'TindakkanTatatertibLabel
        '
        TindakkanTatatertibLabel.AutoSize = True
        TindakkanTatatertibLabel.Location = New System.Drawing.Point(395, 329)
        TindakkanTatatertibLabel.Name = "TindakkanTatatertibLabel"
        TindakkanTatatertibLabel.Size = New System.Drawing.Size(110, 13)
        TindakkanTatatertibLabel.TabIndex = 21
        TindakkanTatatertibLabel.Text = "Tindakkan Tatatertib:"
        '
        'SejarahLantikanLabel
        '
        SejarahLantikanLabel.AutoSize = True
        SejarahLantikanLabel.Location = New System.Drawing.Point(395, 395)
        SejarahLantikanLabel.Name = "SejarahLantikanLabel"
        SejarahLantikanLabel.Size = New System.Drawing.Size(91, 13)
        SejarahLantikanLabel.TabIndex = 23
        SejarahLantikanLabel.Text = "Sejarah Lantikan:"
        '
        'EmployeeDataSEDS
        '
        Me.EmployeeDataSEDS.DataSetName = "EmployeeDataSEDS"
        Me.EmployeeDataSEDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProfileAdvanceBindingSource
        '
        Me.ProfileAdvanceBindingSource.DataMember = "ProfileAdvance"
        Me.ProfileAdvanceBindingSource.DataSource = Me.EmployeeDataSEDS
        '
        'ProfileAdvanceTableAdapter
        '
        Me.ProfileAdvanceTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ProfileAdvanceTableAdapter = Me.ProfileAdvanceTableAdapter
        Me.TableAdapterManager.ProfileBasicTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = EmployeeDataSE.EmployeeDataSEDSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UserTableAdapter = Nothing
        '
        'ProfileAdvanceBindingNavigator
        '
        Me.ProfileAdvanceBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ProfileAdvanceBindingNavigator.BindingSource = Me.ProfileAdvanceBindingSource
        Me.ProfileAdvanceBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ProfileAdvanceBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ProfileAdvanceBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ProfileAdvanceBindingNavigatorSaveItem})
        Me.ProfileAdvanceBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ProfileAdvanceBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ProfileAdvanceBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ProfileAdvanceBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ProfileAdvanceBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ProfileAdvanceBindingNavigator.Name = "ProfileAdvanceBindingNavigator"
        Me.ProfileAdvanceBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ProfileAdvanceBindingNavigator.Size = New System.Drawing.Size(784, 25)
        Me.ProfileAdvanceBindingNavigator.TabIndex = 0
        Me.ProfileAdvanceBindingNavigator.Text = "BindingNavigator1"
        Me.ProfileAdvanceBindingNavigator.Visible = False
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
        'ProfileAdvanceBindingNavigatorSaveItem
        '
        Me.ProfileAdvanceBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ProfileAdvanceBindingNavigatorSaveItem.Image = CType(resources.GetObject("ProfileAdvanceBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ProfileAdvanceBindingNavigatorSaveItem.Name = "ProfileAdvanceBindingNavigatorSaveItem"
        Me.ProfileAdvanceBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ProfileAdvanceBindingNavigatorSaveItem.Text = "Save Data"
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProfileAdvanceBindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(189, 77)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.ReadOnly = True
        Me.IDTextBox.Size = New System.Drawing.Size(100, 21)
        Me.IDTextBox.TabIndex = 2
        '
        'StatusTextBox
        '
        Me.StatusTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProfileAdvanceBindingSource, "Status", True))
        Me.StatusTextBox.Location = New System.Drawing.Point(189, 104)
        Me.StatusTextBox.Name = "StatusTextBox"
        Me.StatusTextBox.Size = New System.Drawing.Size(200, 21)
        Me.StatusTextBox.TabIndex = 4
        '
        'TarikhDilantikDateTimePicker
        '
        Me.TarikhDilantikDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ProfileAdvanceBindingSource, "TarikhDilantik", True))
        Me.TarikhDilantikDateTimePicker.Location = New System.Drawing.Point(189, 131)
        Me.TarikhDilantikDateTimePicker.Name = "TarikhDilantikDateTimePicker"
        Me.TarikhDilantikDateTimePicker.Size = New System.Drawing.Size(200, 21)
        Me.TarikhDilantikDateTimePicker.TabIndex = 6
        '
        'TarikhPengesahanLantikanDateTimePicker
        '
        Me.TarikhPengesahanLantikanDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ProfileAdvanceBindingSource, "TarikhPengesahanLantikan", True))
        Me.TarikhPengesahanLantikanDateTimePicker.Location = New System.Drawing.Point(189, 158)
        Me.TarikhPengesahanLantikanDateTimePicker.Name = "TarikhPengesahanLantikanDateTimePicker"
        Me.TarikhPengesahanLantikanDateTimePicker.Size = New System.Drawing.Size(200, 21)
        Me.TarikhPengesahanLantikanDateTimePicker.TabIndex = 8
        '
        'DisahkanDalamJawatanComboBox
        '
        Me.DisahkanDalamJawatanComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProfileAdvanceBindingSource, "DisahkanDalamJawatan", True))
        Me.DisahkanDalamJawatanComboBox.FormattingEnabled = True
        Me.DisahkanDalamJawatanComboBox.Location = New System.Drawing.Point(189, 185)
        Me.DisahkanDalamJawatanComboBox.Name = "DisahkanDalamJawatanComboBox"
        Me.DisahkanDalamJawatanComboBox.Size = New System.Drawing.Size(200, 21)
        Me.DisahkanDalamJawatanComboBox.TabIndex = 10
        '
        'PilihanUmurPersaraanComboBox
        '
        Me.PilihanUmurPersaraanComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProfileAdvanceBindingSource, "PilihanUmurPersaraan", True))
        Me.PilihanUmurPersaraanComboBox.FormattingEnabled = True
        Me.PilihanUmurPersaraanComboBox.Location = New System.Drawing.Point(189, 212)
        Me.PilihanUmurPersaraanComboBox.Name = "PilihanUmurPersaraanComboBox"
        Me.PilihanUmurPersaraanComboBox.Size = New System.Drawing.Size(200, 21)
        Me.PilihanUmurPersaraanComboBox.TabIndex = 12
        '
        'TarikhPersaraanWajibDateTimePicker
        '
        Me.TarikhPersaraanWajibDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ProfileAdvanceBindingSource, "TarikhPersaraanWajib", True))
        Me.TarikhPersaraanWajibDateTimePicker.Location = New System.Drawing.Point(189, 239)
        Me.TarikhPersaraanWajibDateTimePicker.Name = "TarikhPersaraanWajibDateTimePicker"
        Me.TarikhPersaraanWajibDateTimePicker.Size = New System.Drawing.Size(200, 21)
        Me.TarikhPersaraanWajibDateTimePicker.TabIndex = 14
        '
        'CutiYangBerkaitanComboBox
        '
        Me.CutiYangBerkaitanComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProfileAdvanceBindingSource, "CutiYangBerkaitan", True))
        Me.CutiYangBerkaitanComboBox.FormattingEnabled = True
        Me.CutiYangBerkaitanComboBox.Location = New System.Drawing.Point(189, 266)
        Me.CutiYangBerkaitanComboBox.Name = "CutiYangBerkaitanComboBox"
        Me.CutiYangBerkaitanComboBox.Size = New System.Drawing.Size(200, 21)
        Me.CutiYangBerkaitanComboBox.TabIndex = 16
        '
        'KursusKursusTextBox
        '
        Me.KursusKursusTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProfileAdvanceBindingSource, "KursusKursus", True))
        Me.KursusKursusTextBox.Location = New System.Drawing.Point(189, 326)
        Me.KursusKursusTextBox.Multiline = True
        Me.KursusKursusTextBox.Name = "KursusKursusTextBox"
        Me.KursusKursusTextBox.Size = New System.Drawing.Size(200, 60)
        Me.KursusKursusTextBox.TabIndex = 18
        '
        'APCTextBox
        '
        Me.APCTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProfileAdvanceBindingSource, "APC", True))
        Me.APCTextBox.Location = New System.Drawing.Point(189, 392)
        Me.APCTextBox.Multiline = True
        Me.APCTextBox.Name = "APCTextBox"
        Me.APCTextBox.Size = New System.Drawing.Size(200, 60)
        Me.APCTextBox.TabIndex = 20
        '
        'TindakkanTatatertibTextBox
        '
        Me.TindakkanTatatertibTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProfileAdvanceBindingSource, "TindakkanTatatertib", True))
        Me.TindakkanTatatertibTextBox.Location = New System.Drawing.Point(546, 326)
        Me.TindakkanTatatertibTextBox.Multiline = True
        Me.TindakkanTatatertibTextBox.Name = "TindakkanTatatertibTextBox"
        Me.TindakkanTatatertibTextBox.Size = New System.Drawing.Size(200, 60)
        Me.TindakkanTatatertibTextBox.TabIndex = 22
        '
        'SejarahLantikanTextBox
        '
        Me.SejarahLantikanTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProfileAdvanceBindingSource, "SejarahLantikan", True))
        Me.SejarahLantikanTextBox.Location = New System.Drawing.Point(546, 392)
        Me.SejarahLantikanTextBox.Multiline = True
        Me.SejarahLantikanTextBox.Name = "SejarahLantikanTextBox"
        Me.SejarahLantikanTextBox.Size = New System.Drawing.Size(200, 60)
        Me.SejarahLantikanTextBox.TabIndex = 24
        '
        'btnReport
        '
        Me.btnReport.Location = New System.Drawing.Point(652, 527)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(120, 23)
        Me.btnReport.TabIndex = 25
        Me.btnReport.Text = "&Laporan >"
        Me.btnReport.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(571, 527)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 26
        Me.Button1.Text = "Ke&maskini"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmEVProfileAdvance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnReport)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(StatusLabel)
        Me.Controls.Add(Me.StatusTextBox)
        Me.Controls.Add(TarikhDilantikLabel)
        Me.Controls.Add(Me.TarikhDilantikDateTimePicker)
        Me.Controls.Add(TarikhPengesahanLantikanLabel)
        Me.Controls.Add(Me.TarikhPengesahanLantikanDateTimePicker)
        Me.Controls.Add(DisahkanDalamJawatanLabel)
        Me.Controls.Add(Me.DisahkanDalamJawatanComboBox)
        Me.Controls.Add(PilihanUmurPersaraanLabel)
        Me.Controls.Add(Me.PilihanUmurPersaraanComboBox)
        Me.Controls.Add(TarikhPersaraanWajibLabel)
        Me.Controls.Add(Me.TarikhPersaraanWajibDateTimePicker)
        Me.Controls.Add(CutiYangBerkaitanLabel)
        Me.Controls.Add(Me.CutiYangBerkaitanComboBox)
        Me.Controls.Add(KursusKursusLabel)
        Me.Controls.Add(Me.KursusKursusTextBox)
        Me.Controls.Add(APCLabel)
        Me.Controls.Add(Me.APCTextBox)
        Me.Controls.Add(TindakkanTatatertibLabel)
        Me.Controls.Add(Me.TindakkanTatatertibTextBox)
        Me.Controls.Add(SejarahLantikanLabel)
        Me.Controls.Add(Me.SejarahLantikanTextBox)
        Me.Controls.Add(Me.ProfileAdvanceBindingNavigator)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frmEVProfileAdvance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmEVProfileAdvance"
        CType(Me.EmployeeDataSEDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProfileAdvanceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProfileAdvanceBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ProfileAdvanceBindingNavigator.ResumeLayout(False)
        Me.ProfileAdvanceBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents EmployeeDataSEDS As EmployeeDataSE.EmployeeDataSEDS
    Friend WithEvents ProfileAdvanceBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProfileAdvanceTableAdapter As EmployeeDataSE.EmployeeDataSEDSTableAdapters.ProfileAdvanceTableAdapter
    Friend WithEvents TableAdapterManager As EmployeeDataSE.EmployeeDataSEDSTableAdapters.TableAdapterManager
    Friend WithEvents ProfileAdvanceBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents ProfileAdvanceBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StatusTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TarikhDilantikDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents TarikhPengesahanLantikanDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents DisahkanDalamJawatanComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents PilihanUmurPersaraanComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents TarikhPersaraanWajibDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents CutiYangBerkaitanComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents KursusKursusTextBox As System.Windows.Forms.TextBox
    Friend WithEvents APCTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TindakkanTatatertibTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SejarahLantikanTextBox As System.Windows.Forms.TextBox
    Friend WithEvents btnReport As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
