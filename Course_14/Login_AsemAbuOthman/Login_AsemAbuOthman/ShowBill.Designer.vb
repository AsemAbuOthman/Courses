<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmShowInfo
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
        Me.mnsShowInfo = New System.Windows.Forms.MenuStrip()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.grpBill = New System.Windows.Forms.GroupBox()
        Me.rtxShowInfo = New System.Windows.Forms.RichTextBox()
        Me.mnsShowInfo.SuspendLayout()
        Me.grpBill.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnsShowInfo
        '
        Me.mnsShowInfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.mnsShowInfo.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuExit})
        Me.mnsShowInfo.Location = New System.Drawing.Point(0, 0)
        Me.mnsShowInfo.Name = "mnsShowInfo"
        Me.mnsShowInfo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.mnsShowInfo.Size = New System.Drawing.Size(348, 24)
        Me.mnsShowInfo.TabIndex = 6
        '
        'mnuExit
        '
        Me.mnuExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuExit.ForeColor = System.Drawing.Color.White
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.mnuExit.Size = New System.Drawing.Size(39, 20)
        Me.mnuExit.Text = "Exit"
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBack.ForeColor = System.Drawing.Color.White
        Me.btnBack.Location = New System.Drawing.Point(138, 397)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(74, 30)
        Me.btnBack.TabIndex = 8
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'grpBill
        '
        Me.grpBill.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.grpBill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.grpBill.Controls.Add(Me.rtxShowInfo)
        Me.grpBill.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpBill.ForeColor = System.Drawing.Color.White
        Me.grpBill.Location = New System.Drawing.Point(22, 41)
        Me.grpBill.Name = "grpBill"
        Me.grpBill.Size = New System.Drawing.Size(307, 347)
        Me.grpBill.TabIndex = 9
        Me.grpBill.TabStop = False
        Me.grpBill.Text = "Bill"
        '
        'rtxShowInfo
        '
        Me.rtxShowInfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.rtxShowInfo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtxShowInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtxShowInfo.ForeColor = System.Drawing.Color.White
        Me.rtxShowInfo.Location = New System.Drawing.Point(23, 28)
        Me.rtxShowInfo.Margin = New System.Windows.Forms.Padding(5)
        Me.rtxShowInfo.Name = "rtxShowInfo"
        Me.rtxShowInfo.ReadOnly = True
        Me.rtxShowInfo.Size = New System.Drawing.Size(256, 293)
        Me.rtxShowInfo.TabIndex = 8
        Me.rtxShowInfo.Text = ""
        '
        'frmShowInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(348, 439)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.mnsShowInfo)
        Me.Controls.Add(Me.grpBill)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmShowInfo"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ShowInfo"
        Me.mnsShowInfo.ResumeLayout(False)
        Me.mnsShowInfo.PerformLayout()
        Me.grpBill.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnsShowInfo As MenuStrip
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents btnBack As Button
    Friend WithEvents grpBill As GroupBox
    Friend WithEvents rtxShowInfo As RichTextBox
End Class
