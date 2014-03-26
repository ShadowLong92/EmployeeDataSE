<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPassword
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
        Dim UserNameLabel As System.Windows.Forms.Label
        Dim PasswordLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPassword))
        Me.EmployeeDataSEDS = New EmployeeDataSE.EmployeeDataSEDS()
        Me.UserBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UserTableAdapter = New EmployeeDataSE.EmployeeDataSEDSTableAdapters.UserTableAdapter()
        Me.TableAdapterManager = New EmployeeDataSE.EmployeeDataSEDSTableAdapters.TableAdapterManager()
        Me.UserBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.UserBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.UserNameTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.txtRePassword = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        IDLabel = New System.Windows.Forms.Label()
        UserNameLabel = New System.Windows.Forms.Label()
        PasswordLabel = New System.Windows.Forms.Label()
        CType(Me.EmployeeDataSEDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UserBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(148, 173)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(22, 13)
        IDLabel.TabIndex = 1
        IDLabel.Text = "ID:"
        '
        'UserNameLabel
        '
        UserNameLabel.AutoSize = True
        UserNameLabel.Location = New System.Drawing.Point(148, 200)
        UserNameLabel.Name = "UserNameLabel"
        UserNameLabel.Size = New System.Drawing.Size(52, 13)
        UserNameLabel.TabIndex = 3
        UserNameLabel.Text = "Nama ID:"
        '
        'PasswordLabel
        '
        PasswordLabel.AutoSize = True
        PasswordLabel.Location = New System.Drawing.Point(148, 227)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New System.Drawing.Size(64, 13)
        PasswordLabel.TabIndex = 5
        PasswordLabel.Text = "Kata laluan:"
        '
        'EmployeeDataSEDS
        '
        Me.EmployeeDataSEDS.DataSetName = "EmployeeDataSEDS"
        Me.EmployeeDataSEDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UserBindingSource
        '
        Me.UserBindingSource.DataMember = "User"
        Me.UserBindingSource.DataSource = Me.EmployeeDataSEDS
        '
        'UserTableAdapter
        '
        Me.UserTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AgamaTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CutiBerkaitTableAdapter = Nothing
        Me.TableAdapterManager.JantinaTableAdapter = Nothing
        Me.TableAdapterManager.JawatanTableAdapter = Nothing
        Me.TableAdapterManager.KelayakanTableAdapter = Nothing
        Me.TableAdapterManager.ProfileAdvanceTableAdapter = Nothing
        Me.TableAdapterManager.ProfileBasicTableAdapter = Nothing
        Me.TableAdapterManager.StatusKerjaTableAdapter = Nothing
        Me.TableAdapterManager.UmurPencenTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = EmployeeDataSE.EmployeeDataSEDSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UserTableAdapter = Me.UserTableAdapter
        '
        'UserBindingNavigator
        '
        Me.UserBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.UserBindingNavigator.BindingSource = Me.UserBindingSource
        Me.UserBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.UserBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.UserBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.UserBindingNavigatorSaveItem})
        Me.UserBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.UserBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.UserBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.UserBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.UserBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.UserBindingNavigator.Name = "UserBindingNavigator"
        Me.UserBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.UserBindingNavigator.Size = New System.Drawing.Size(624, 25)
        Me.UserBindingNavigator.TabIndex = 0
        Me.UserBindingNavigator.Text = "BindingNavigator1"
        Me.UserBindingNavigator.Visible = False
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
        'UserBindingNavigatorSaveItem
        '
        Me.UserBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.UserBindingNavigatorSaveItem.Image = CType(resources.GetObject("UserBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.UserBindingNavigatorSaveItem.Name = "UserBindingNavigatorSaveItem"
        Me.UserBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.UserBindingNavigatorSaveItem.Text = "Save Data"
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserBindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(277, 170)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.ReadOnly = True
        Me.IDTextBox.Size = New System.Drawing.Size(200, 21)
        Me.IDTextBox.TabIndex = 2
        '
        'UserNameTextBox
        '
        Me.UserNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserBindingSource, "UserName", True))
        Me.UserNameTextBox.Location = New System.Drawing.Point(277, 197)
        Me.UserNameTextBox.Name = "UserNameTextBox"
        Me.UserNameTextBox.ReadOnly = True
        Me.UserNameTextBox.Size = New System.Drawing.Size(200, 21)
        Me.UserNameTextBox.TabIndex = 4
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserBindingSource, "Password", True))
        Me.PasswordTextBox.Location = New System.Drawing.Point(277, 224)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9829)
        Me.PasswordTextBox.Size = New System.Drawing.Size(200, 21)
        Me.PasswordTextBox.TabIndex = 6
        '
        'txtRePassword
        '
        Me.txtRePassword.Location = New System.Drawing.Point(277, 251)
        Me.txtRePassword.Name = "txtRePassword"
        Me.txtRePassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9829)
        Me.txtRePassword.Size = New System.Drawing.Size(200, 21)
        Me.txtRePassword.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(148, 254)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Tulis semula kata laluan:"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(537, 407)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "&Keluar"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(411, 407)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(120, 23)
        Me.btnSave.TabIndex = 10
        Me.btnSave.Text = "&Tukar dan Keluar"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'frmPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 442)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtRePassword)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(UserNameLabel)
        Me.Controls.Add(Me.UserNameTextBox)
        Me.Controls.Add(PasswordLabel)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(Me.UserBindingNavigator)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximumSize = New System.Drawing.Size(640, 480)
        Me.MinimumSize = New System.Drawing.Size(640, 480)
        Me.Name = "frmPassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tukar kata laluan"
        CType(Me.EmployeeDataSEDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UserBindingNavigator.ResumeLayout(False)
        Me.UserBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents EmployeeDataSEDS As EmployeeDataSE.EmployeeDataSEDS
    Friend WithEvents UserBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UserTableAdapter As EmployeeDataSE.EmployeeDataSEDSTableAdapters.UserTableAdapter
    Friend WithEvents TableAdapterManager As EmployeeDataSE.EmployeeDataSEDSTableAdapters.TableAdapterManager
    Friend WithEvents UserBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents UserBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UserNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents txtRePassword As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
End Class
