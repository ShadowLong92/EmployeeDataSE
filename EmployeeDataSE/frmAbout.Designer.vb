<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAbout
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAbout))
        Me.lblJoin = New System.Windows.Forms.Label()
        Me.lblAbout = New System.Windows.Forms.Label()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblUpdate = New System.Windows.Forms.Label()
        Me.lblMascot = New System.Windows.Forms.Label()
        Me.lnkPrivacy = New System.Windows.Forms.LinkLabel()
        Me.lnkLicense = New System.Windows.Forms.LinkLabel()
        Me.lnkEndUser = New System.Windows.Forms.LinkLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblJoin
        '
        Me.lblJoin.BackColor = System.Drawing.Color.Transparent
        Me.lblJoin.ForeColor = System.Drawing.Color.Black
        Me.lblJoin.Location = New System.Drawing.Point(265, 167)
        Me.lblJoin.Name = "lblJoin"
        Me.lblJoin.Size = New System.Drawing.Size(381, 20)
        Me.lblJoin.TabIndex = 13
        Me.lblJoin.Text = "Free and Open Source project, licensed under GNU GPL 2.0"
        '
        'lblAbout
        '
        Me.lblAbout.BackColor = System.Drawing.Color.Transparent
        Me.lblAbout.ForeColor = System.Drawing.Color.Black
        Me.lblAbout.Location = New System.Drawing.Point(265, 117)
        Me.lblAbout.Name = "lblAbout"
        Me.lblAbout.Size = New System.Drawing.Size(381, 50)
        Me.lblAbout.TabIndex = 12
        Me.lblAbout.Text = "This project was created for local state government office. Provide basic and sim" & _
            "ple employee profile within offline\local database."
        Me.lblAbout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblVersion
        '
        Me.lblVersion.BackColor = System.Drawing.Color.Transparent
        Me.lblVersion.ForeColor = System.Drawing.Color.Black
        Me.lblVersion.Location = New System.Drawing.Point(265, 53)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(381, 32)
        Me.lblVersion.TabIndex = 10
        Me.lblVersion.Text = "1.0.0.0"
        Me.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.Black
        Me.lblTitle.Location = New System.Drawing.Point(262, 21)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(61, 32)
        Me.lblTitle.TabIndex = 9
        Me.lblTitle.Text = "Title"
        '
        'lblUpdate
        '
        Me.lblUpdate.BackColor = System.Drawing.Color.Transparent
        Me.lblUpdate.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUpdate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblUpdate.Location = New System.Drawing.Point(265, 85)
        Me.lblUpdate.Name = "lblUpdate"
        Me.lblUpdate.Size = New System.Drawing.Size(381, 32)
        Me.lblUpdate.TabIndex = 11
        Me.lblUpdate.Text = "appname is up to date!"
        Me.lblUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblMascot
        '
        Me.lblMascot.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMascot.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.lblMascot.Enabled = False
        Me.lblMascot.ForeColor = System.Drawing.Color.Black
        Me.lblMascot.Location = New System.Drawing.Point(12, 273)
        Me.lblMascot.Name = "lblMascot"
        Me.lblMascot.Size = New System.Drawing.Size(624, 24)
        Me.lblMascot.TabIndex = 17
        Me.lblMascot.Text = "Program designed by ShadowLong and Anime4000"
        Me.lblMascot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lnkPrivacy
        '
        Me.lnkPrivacy.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.lnkPrivacy.ForeColor = System.Drawing.Color.Black
        Me.lnkPrivacy.LinkColor = System.Drawing.Color.Blue
        Me.lnkPrivacy.Location = New System.Drawing.Point(450, 248)
        Me.lnkPrivacy.Name = "lnkPrivacy"
        Me.lnkPrivacy.Size = New System.Drawing.Size(186, 15)
        Me.lnkPrivacy.TabIndex = 16
        Me.lnkPrivacy.TabStop = True
        Me.lnkPrivacy.Text = "Privacy Policy"
        Me.lnkPrivacy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lnkLicense
        '
        Me.lnkLicense.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.lnkLicense.ForeColor = System.Drawing.Color.Black
        Me.lnkLicense.LinkColor = System.Drawing.Color.Blue
        Me.lnkLicense.Location = New System.Drawing.Point(204, 248)
        Me.lnkLicense.Name = "lnkLicense"
        Me.lnkLicense.Size = New System.Drawing.Size(240, 15)
        Me.lnkLicense.TabIndex = 15
        Me.lnkLicense.TabStop = True
        Me.lnkLicense.Text = "Lisensing Information"
        Me.lnkLicense.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lnkEndUser
        '
        Me.lnkEndUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.lnkEndUser.ForeColor = System.Drawing.Color.Black
        Me.lnkEndUser.LinkColor = System.Drawing.Color.Blue
        Me.lnkEndUser.Location = New System.Drawing.Point(12, 248)
        Me.lnkEndUser.Name = "lnkEndUser"
        Me.lnkEndUser.Size = New System.Drawing.Size(186, 15)
        Me.lnkEndUser.TabIndex = 14
        Me.lnkEndUser.TabStop = True
        Me.lnkEndUser.Text = "End-User Rights"
        Me.lnkEndUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(60, 60)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(128, 128)
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.PictureBox2.Location = New System.Drawing.Point(0, 230)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(648, 67)
        Me.PictureBox2.TabIndex = 19
        Me.PictureBox2.TabStop = False
        '
        'frmAbout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(648, 297)
        Me.Controls.Add(Me.lblMascot)
        Me.Controls.Add(Me.lnkPrivacy)
        Me.Controls.Add(Me.lnkLicense)
        Me.Controls.Add(Me.lnkEndUser)
        Me.Controls.Add(Me.lblJoin)
        Me.Controls.Add(Me.lblAbout)
        Me.Controls.Add(Me.lblVersion)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblUpdate)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(664, 335)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(664, 335)
        Me.Name = "frmAbout"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmAbout"
        Me.TopMost = True
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblJoin As System.Windows.Forms.Label
    Friend WithEvents lblAbout As System.Windows.Forms.Label
    Friend WithEvents lblVersion As System.Windows.Forms.Label
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblUpdate As System.Windows.Forms.Label
    Friend WithEvents lblMascot As System.Windows.Forms.Label
    Friend WithEvents lnkPrivacy As System.Windows.Forms.LinkLabel
    Friend WithEvents lnkLicense As System.Windows.Forms.LinkLabel
    Friend WithEvents lnkEndUser As System.Windows.Forms.LinkLabel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
End Class
