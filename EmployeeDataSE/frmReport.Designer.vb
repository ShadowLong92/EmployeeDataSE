<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReport
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
        Me.tsmiReport = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiPrint = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiPrintPreview = New System.Windows.Forms.ToolStripMenuItem()
        Me.ieReport = New System.Windows.Forms.WebBrowser()
        Me.menuBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'menuBar
        '
        Me.menuBar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menuBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiReport})
        Me.menuBar.Location = New System.Drawing.Point(0, 0)
        Me.menuBar.Name = "menuBar"
        Me.menuBar.Size = New System.Drawing.Size(784, 24)
        Me.menuBar.TabIndex = 1
        Me.menuBar.Text = "MenuStrip1"
        Me.menuBar.Visible = False
        '
        'tsmiReport
        '
        Me.tsmiReport.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiPrint, Me.tsmiPrintPreview})
        Me.tsmiReport.Name = "tsmiReport"
        Me.tsmiReport.Size = New System.Drawing.Size(58, 20)
        Me.tsmiReport.Text = "&Laporan"
        '
        'tsmiPrint
        '
        Me.tsmiPrint.Name = "tsmiPrint"
        Me.tsmiPrint.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.tsmiPrint.Size = New System.Drawing.Size(230, 22)
        Me.tsmiPrint.Text = "Cetak La&poran Ini"
        '
        'tsmiPrintPreview
        '
        Me.tsmiPrintPreview.Name = "tsmiPrintPreview"
        Me.tsmiPrintPreview.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                    Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.tsmiPrintPreview.Size = New System.Drawing.Size(230, 22)
        Me.tsmiPrintPreview.Text = "Paparkan &Cetakan"
        '
        'ieReport
        '
        Me.ieReport.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ieReport.Location = New System.Drawing.Point(0, 0)
        Me.ieReport.MinimumSize = New System.Drawing.Size(20, 20)
        Me.ieReport.Name = "ieReport"
        Me.ieReport.Size = New System.Drawing.Size(784, 562)
        Me.ieReport.TabIndex = 2
        '
        'frmReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.ieReport)
        Me.Controls.Add(Me.menuBar)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.MainMenuStrip = Me.menuBar
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frmReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmReport"
        Me.menuBar.ResumeLayout(False)
        Me.menuBar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents menuBar As System.Windows.Forms.MenuStrip
    Friend WithEvents tsmiReport As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiPrint As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ieReport As System.Windows.Forms.WebBrowser
    Friend WithEvents tsmiPrintPreview As System.Windows.Forms.ToolStripMenuItem
End Class
