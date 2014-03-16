<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSearchEmpId
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
        Me.ProfileBasicBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmployeeDataSEDS = New EmployeeDataSE.EmployeeDataSEDS()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ProfileBasicTableAdapter = New EmployeeDataSE.EmployeeDataSEDSTableAdapters.ProfileBasicTableAdapter()
        Me.lstName = New System.Windows.Forms.ListBox()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.txtId = New System.Windows.Forms.TextBox()
        CType(Me.ProfileBasicBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeeDataSEDS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(73, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Cari dengan ID:"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(57, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Cari dengan Nama:"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(298, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "atau"
        '
        'ProfileBasicTableAdapter
        '
        Me.ProfileBasicTableAdapter.ClearBeforeFill = True
        '
        'lstName
        '
        Me.lstName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lstName.DataSource = Me.ProfileBasicBindingSource
        Me.lstName.DisplayMember = "NamaPegawai"
        Me.lstName.FormattingEnabled = True
        Me.lstName.Location = New System.Drawing.Point(162, 95)
        Me.lstName.Name = "lstName"
        Me.lstName.Size = New System.Drawing.Size(300, 290)
        Me.lstName.TabIndex = 5
        '
        'btnNext
        '
        Me.btnNext.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnNext.Location = New System.Drawing.Point(468, 54)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 21)
        Me.btnNext.TabIndex = 6
        Me.btnNext.Text = "&Cari!"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'txtId
        '
        Me.txtId.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtId.Location = New System.Drawing.Point(162, 54)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(300, 21)
        Me.txtId.TabIndex = 7
        '
        'frmSearchEmpId
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 442)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.lstName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.MinimumSize = New System.Drawing.Size(640, 480)
        Me.Name = "frmSearchEmpId"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmSearchEmpId"
        CType(Me.ProfileBasicBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeeDataSEDS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents EmployeeDataSEDS As EmployeeDataSE.EmployeeDataSEDS
    Friend WithEvents ProfileBasicBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProfileBasicTableAdapter As EmployeeDataSE.EmployeeDataSEDSTableAdapters.ProfileBasicTableAdapter
    Friend WithEvents lstName As System.Windows.Forms.ListBox
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents txtId As System.Windows.Forms.TextBox
End Class
