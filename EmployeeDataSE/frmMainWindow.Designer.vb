<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainWindow
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
        Me.menuBar = New System.Windows.Forms.MenuStrip()
        Me.tsmiFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiWork = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiRegNewWorker = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.menuBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'menuBar
        '
        Me.menuBar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menuBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiFile, Me.tsmiEdit, Me.tsmiWork, Me.tsmiHelp})
        Me.menuBar.Location = New System.Drawing.Point(0, 0)
        Me.menuBar.Name = "menuBar"
        Me.menuBar.Size = New System.Drawing.Size(1016, 24)
        Me.menuBar.TabIndex = 1
        Me.menuBar.Text = "menu"
        '
        'tsmiFile
        '
        Me.tsmiFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiExit})
        Me.tsmiFile.Name = "tsmiFile"
        Me.tsmiFile.Size = New System.Drawing.Size(35, 20)
        Me.tsmiFile.Text = "&File"
        '
        'tsmiExit
        '
        Me.tsmiExit.Name = "tsmiExit"
        Me.tsmiExit.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.tsmiExit.Size = New System.Drawing.Size(132, 22)
        Me.tsmiExit.Text = "&Exit"
        '
        'tsmiEdit
        '
        Me.tsmiEdit.Name = "tsmiEdit"
        Me.tsmiEdit.Size = New System.Drawing.Size(37, 20)
        Me.tsmiEdit.Text = "&Edit"
        '
        'tsmiWork
        '
        Me.tsmiWork.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiRegNewWorker, Me.ToolStripSeparator1})
        Me.tsmiWork.Name = "tsmiWork"
        Me.tsmiWork.Size = New System.Drawing.Size(44, 20)
        Me.tsmiWork.Text = "&Work"
        '
        'tsmiHelp
        '
        Me.tsmiHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiAbout})
        Me.tsmiHelp.Name = "tsmiHelp"
        Me.tsmiHelp.Size = New System.Drawing.Size(40, 20)
        Me.tsmiHelp.Text = "&Help"
        '
        'tsmiAbout
        '
        Me.tsmiAbout.Name = "tsmiAbout"
        Me.tsmiAbout.Size = New System.Drawing.Size(260, 22)
        Me.tsmiAbout.Text = "&About Employee Data Standard Edition"
        '
        'tsmiRegNewWorker
        '
        Me.tsmiRegNewWorker.Name = "tsmiRegNewWorker"
        Me.tsmiRegNewWorker.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.tsmiRegNewWorker.Size = New System.Drawing.Size(204, 22)
        Me.tsmiRegNewWorker.Text = "&Daftar Pekerja Baru"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(201, 6)
        '
        'frmMainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1016, 573)
        Me.Controls.Add(Me.menuBar)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.menuBar
        Me.MinimumSize = New System.Drawing.Size(1024, 600)
        Me.Name = "frmMainWindow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employee Data SE"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.menuBar.ResumeLayout(False)
        Me.menuBar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents menuBar As System.Windows.Forms.MenuStrip
    Friend WithEvents tsmiFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiWork As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiHelp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiAbout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiRegNewWorker As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator

End Class
