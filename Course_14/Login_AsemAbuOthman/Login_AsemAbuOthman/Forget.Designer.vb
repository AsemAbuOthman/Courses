<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmForget
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
        Me.grpForget = New System.Windows.Forms.GroupBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lblNewPassword = New System.Windows.Forms.Label()
        Me.lblNewUsername = New System.Windows.Forms.Label()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.txtNewPassword = New System.Windows.Forms.TextBox()
        Me.txtNewUsername = New System.Windows.Forms.TextBox()
        Me.mnsForget = New System.Windows.Forms.MenuStrip()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.grpForget.SuspendLayout()
        Me.mnsForget.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpForget
        '
        Me.grpForget.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.grpForget.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.grpForget.Controls.Add(Me.btnBack)
        Me.grpForget.Controls.Add(Me.lblNewPassword)
        Me.grpForget.Controls.Add(Me.lblNewUsername)
        Me.grpForget.Controls.Add(Me.btnLogin)
        Me.grpForget.Controls.Add(Me.txtNewPassword)
        Me.grpForget.Controls.Add(Me.txtNewUsername)
        Me.grpForget.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.grpForget.ForeColor = System.Drawing.Color.White
        Me.grpForget.Location = New System.Drawing.Point(12, 23)
        Me.grpForget.Name = "grpForget"
        Me.grpForget.Size = New System.Drawing.Size(458, 215)
        Me.grpForget.TabIndex = 1
        Me.grpForget.TabStop = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.White
        Me.btnBack.Location = New System.Drawing.Point(160, 170)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(74, 30)
        Me.btnBack.TabIndex = 5
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'lblNewPassword
        '
        Me.lblNewPassword.AutoSize = True
        Me.lblNewPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNewPassword.ForeColor = System.Drawing.Color.White
        Me.lblNewPassword.Location = New System.Drawing.Point(35, 107)
        Me.lblNewPassword.Name = "lblNewPassword"
        Me.lblNewPassword.Size = New System.Drawing.Size(109, 18)
        Me.lblNewPassword.TabIndex = 4
        Me.lblNewPassword.Text = "New Password"
        '
        'lblNewUsername
        '
        Me.lblNewUsername.AutoSize = True
        Me.lblNewUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNewUsername.ForeColor = System.Drawing.Color.White
        Me.lblNewUsername.Location = New System.Drawing.Point(33, 53)
        Me.lblNewUsername.Name = "lblNewUsername"
        Me.lblNewUsername.Size = New System.Drawing.Size(111, 18)
        Me.lblNewUsername.TabIndex = 3
        Me.lblNewUsername.Text = "New Username"
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.Location = New System.Drawing.Point(264, 170)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(74, 30)
        Me.btnLogin.TabIndex = 2
        Me.btnLogin.Text = "Save"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'txtNewPassword
        '
        Me.txtNewPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.txtNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNewPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewPassword.ForeColor = System.Drawing.Color.White
        Me.txtNewPassword.Location = New System.Drawing.Point(160, 107)
        Me.txtNewPassword.Name = "txtNewPassword"
        Me.txtNewPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNewPassword.Size = New System.Drawing.Size(178, 23)
        Me.txtNewPassword.TabIndex = 1
        '
        'txtNewUsername
        '
        Me.txtNewUsername.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.txtNewUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNewUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewUsername.ForeColor = System.Drawing.Color.White
        Me.txtNewUsername.Location = New System.Drawing.Point(160, 53)
        Me.txtNewUsername.Name = "txtNewUsername"
        Me.txtNewUsername.Size = New System.Drawing.Size(178, 23)
        Me.txtNewUsername.TabIndex = 0
        '
        'mnsForget
        '
        Me.mnsForget.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.mnsForget.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuExit})
        Me.mnsForget.Location = New System.Drawing.Point(0, 0)
        Me.mnsForget.Name = "mnsForget"
        Me.mnsForget.Size = New System.Drawing.Size(482, 24)
        Me.mnsForget.TabIndex = 6
        Me.mnsForget.Text = "MenuStrip1"
        '
        'mnuExit
        '
        Me.mnuExit.ForeColor = System.Drawing.Color.White
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(38, 20)
        Me.mnuExit.Text = "Exit"
        '
        'frmForget
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(482, 251)
        Me.ControlBox = False
        Me.Controls.Add(Me.mnsForget)
        Me.Controls.Add(Me.grpForget)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmForget"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Forget"
        Me.grpForget.ResumeLayout(False)
        Me.grpForget.PerformLayout()
        Me.mnsForget.ResumeLayout(False)
        Me.mnsForget.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpForget As GroupBox
    Friend WithEvents lblNewPassword As Label
    Friend WithEvents lblNewUsername As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents txtNewPassword As TextBox
    Friend WithEvents txtNewUsername As TextBox
    Friend WithEvents mnsForget As MenuStrip
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents btnBack As Button
End Class
