<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmOrder
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txtBeverage = New System.Windows.Forms.TextBox()
        Me.grpProfile = New System.Windows.Forms.GroupBox()
        Me.grpWithMilk = New System.Windows.Forms.GroupBox()
        Me.rdoNo = New System.Windows.Forms.RadioButton()
        Me.rdoYes = New System.Windows.Forms.RadioButton()
        Me.lblWithMilk = New System.Windows.Forms.Label()
        Me.grpTempreature = New System.Windows.Forms.GroupBox()
        Me.rdoHot = New System.Windows.Forms.RadioButton()
        Me.rdoIced = New System.Windows.Forms.RadioButton()
        Me.lblTemperature = New System.Windows.Forms.Label()
        Me.rtxNote = New System.Windows.Forms.RichTextBox()
        Me.cmbSyrups = New System.Windows.Forms.ComboBox()
        Me.lblSyrups = New System.Windows.Forms.Label()
        Me.txtPriceOfCup = New System.Windows.Forms.MaskedTextBox()
        Me.lblPriceOfCup = New System.Windows.Forms.Label()
        Me.cmbSizeOfCup = New System.Windows.Forms.ComboBox()
        Me.txtQuantity = New System.Windows.Forms.MaskedTextBox()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.lblSizeOfCup = New System.Windows.Forms.Label()
        Me.lblBeverage = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.mnsProfile = New System.Windows.Forms.MenuStrip()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.grpProfile.SuspendLayout()
        Me.grpWithMilk.SuspendLayout()
        Me.grpTempreature.SuspendLayout()
        Me.mnsProfile.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtBeverage
        '
        Me.txtBeverage.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.txtBeverage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBeverage.ForeColor = System.Drawing.Color.White
        Me.txtBeverage.Location = New System.Drawing.Point(144, 37)
        Me.txtBeverage.Name = "txtBeverage"
        Me.txtBeverage.Size = New System.Drawing.Size(178, 20)
        Me.txtBeverage.TabIndex = 0
        '
        'grpProfile
        '
        Me.grpProfile.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.grpProfile.Controls.Add(Me.grpWithMilk)
        Me.grpProfile.Controls.Add(Me.grpTempreature)
        Me.grpProfile.Controls.Add(Me.rtxNote)
        Me.grpProfile.Controls.Add(Me.cmbSyrups)
        Me.grpProfile.Controls.Add(Me.lblSyrups)
        Me.grpProfile.Controls.Add(Me.txtPriceOfCup)
        Me.grpProfile.Controls.Add(Me.lblPriceOfCup)
        Me.grpProfile.Controls.Add(Me.cmbSizeOfCup)
        Me.grpProfile.Controls.Add(Me.txtQuantity)
        Me.grpProfile.Controls.Add(Me.lblQuantity)
        Me.grpProfile.Controls.Add(Me.lblSizeOfCup)
        Me.grpProfile.Controls.Add(Me.lblBeverage)
        Me.grpProfile.Controls.Add(Me.txtBeverage)
        Me.grpProfile.Location = New System.Drawing.Point(62, 33)
        Me.grpProfile.Name = "grpProfile"
        Me.grpProfile.Size = New System.Drawing.Size(735, 360)
        Me.grpProfile.TabIndex = 2
        Me.grpProfile.TabStop = False
        '
        'grpWithMilk
        '
        Me.grpWithMilk.Controls.Add(Me.rdoNo)
        Me.grpWithMilk.Controls.Add(Me.rdoYes)
        Me.grpWithMilk.Controls.Add(Me.lblWithMilk)
        Me.grpWithMilk.Location = New System.Drawing.Point(20, 220)
        Me.grpWithMilk.Name = "grpWithMilk"
        Me.grpWithMilk.Size = New System.Drawing.Size(302, 49)
        Me.grpWithMilk.TabIndex = 29
        Me.grpWithMilk.TabStop = False
        '
        'rdoNo
        '
        Me.rdoNo.AutoSize = True
        Me.rdoNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.rdoNo.ForeColor = System.Drawing.Color.White
        Me.rdoNo.Location = New System.Drawing.Point(244, 19)
        Me.rdoNo.Name = "rdoNo"
        Me.rdoNo.Size = New System.Drawing.Size(46, 22)
        Me.rdoNo.TabIndex = 25
        Me.rdoNo.TabStop = True
        Me.rdoNo.Text = "No"
        Me.rdoNo.UseVisualStyleBackColor = True
        '
        'rdoYes
        '
        Me.rdoYes.AutoSize = True
        Me.rdoYes.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.rdoYes.ForeColor = System.Drawing.Color.White
        Me.rdoYes.Location = New System.Drawing.Point(116, 17)
        Me.rdoYes.Name = "rdoYes"
        Me.rdoYes.Size = New System.Drawing.Size(51, 22)
        Me.rdoYes.TabIndex = 24
        Me.rdoYes.TabStop = True
        Me.rdoYes.Text = "Yes"
        Me.rdoYes.UseVisualStyleBackColor = True
        '
        'lblWithMilk
        '
        Me.lblWithMilk.AutoSize = True
        Me.lblWithMilk.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.lblWithMilk.ForeColor = System.Drawing.Color.White
        Me.lblWithMilk.Location = New System.Drawing.Point(11, 19)
        Me.lblWithMilk.Name = "lblWithMilk"
        Me.lblWithMilk.Size = New System.Drawing.Size(69, 18)
        Me.lblWithMilk.TabIndex = 26
        Me.lblWithMilk.Text = "With Milk"
        '
        'grpTempreature
        '
        Me.grpTempreature.Controls.Add(Me.rdoHot)
        Me.grpTempreature.Controls.Add(Me.rdoIced)
        Me.grpTempreature.Controls.Add(Me.lblTemperature)
        Me.grpTempreature.Location = New System.Drawing.Point(20, 150)
        Me.grpTempreature.Name = "grpTempreature"
        Me.grpTempreature.Size = New System.Drawing.Size(302, 49)
        Me.grpTempreature.TabIndex = 28
        Me.grpTempreature.TabStop = False
        '
        'rdoHot
        '
        Me.rdoHot.AutoSize = True
        Me.rdoHot.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.rdoHot.ForeColor = System.Drawing.Color.White
        Me.rdoHot.Location = New System.Drawing.Point(244, 19)
        Me.rdoHot.Name = "rdoHot"
        Me.rdoHot.Size = New System.Drawing.Size(50, 22)
        Me.rdoHot.TabIndex = 3
        Me.rdoHot.TabStop = True
        Me.rdoHot.Text = "Hot"
        Me.rdoHot.UseVisualStyleBackColor = True
        '
        'rdoIced
        '
        Me.rdoIced.AutoSize = True
        Me.rdoIced.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.rdoIced.ForeColor = System.Drawing.Color.White
        Me.rdoIced.Location = New System.Drawing.Point(116, 17)
        Me.rdoIced.Name = "rdoIced"
        Me.rdoIced.Size = New System.Drawing.Size(53, 22)
        Me.rdoIced.TabIndex = 2
        Me.rdoIced.TabStop = True
        Me.rdoIced.Text = "Iced"
        Me.rdoIced.UseVisualStyleBackColor = True
        '
        'lblTemperature
        '
        Me.lblTemperature.AutoSize = True
        Me.lblTemperature.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.lblTemperature.ForeColor = System.Drawing.Color.White
        Me.lblTemperature.Location = New System.Drawing.Point(7, 19)
        Me.lblTemperature.Name = "lblTemperature"
        Me.lblTemperature.Size = New System.Drawing.Size(92, 18)
        Me.lblTemperature.TabIndex = 12
        Me.lblTemperature.Text = "Temperature"
        '
        'rtxNote
        '
        Me.rtxNote.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.rtxNote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.rtxNote.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.rtxNote.ForeColor = System.Drawing.Color.White
        Me.rtxNote.Location = New System.Drawing.Point(407, 166)
        Me.rtxNote.Name = "rtxNote"
        Me.rtxNote.Size = New System.Drawing.Size(284, 155)
        Me.rtxNote.TabIndex = 27
        Me.rtxNote.Text = "For example, you can request light ice, caramel drizzle or extra foam."
        '
        'cmbSyrups
        '
        Me.cmbSyrups.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.cmbSyrups.DropDownHeight = 50
        Me.cmbSyrups.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbSyrups.ForeColor = System.Drawing.Color.White
        Me.cmbSyrups.FormattingEnabled = True
        Me.cmbSyrups.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmbSyrups.IntegralHeight = False
        Me.cmbSyrups.ItemHeight = 13
        Me.cmbSyrups.Items.AddRange(New Object() {"vanilla", "caramel", "hazelnut", "chestnut", "praline"})
        Me.cmbSyrups.Location = New System.Drawing.Point(144, 300)
        Me.cmbSyrups.MaxDropDownItems = 3
        Me.cmbSyrups.Name = "cmbSyrups"
        Me.cmbSyrups.Size = New System.Drawing.Size(178, 21)
        Me.cmbSyrups.TabIndex = 23
        '
        'lblSyrups
        '
        Me.lblSyrups.AutoSize = True
        Me.lblSyrups.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.lblSyrups.ForeColor = System.Drawing.Color.White
        Me.lblSyrups.Location = New System.Drawing.Point(20, 300)
        Me.lblSyrups.Name = "lblSyrups"
        Me.lblSyrups.Size = New System.Drawing.Size(54, 18)
        Me.lblSyrups.TabIndex = 22
        Me.lblSyrups.Text = "Syrups"
        '
        'txtPriceOfCup
        '
        Me.txtPriceOfCup.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.txtPriceOfCup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPriceOfCup.ForeColor = System.Drawing.Color.White
        Me.txtPriceOfCup.Location = New System.Drawing.Point(513, 105)
        Me.txtPriceOfCup.Mask = "00"
        Me.txtPriceOfCup.Name = "txtPriceOfCup"
        Me.txtPriceOfCup.PromptChar = Global.Microsoft.VisualBasic.ChrW(45)
        Me.txtPriceOfCup.RejectInputOnFirstFailure = True
        Me.txtPriceOfCup.ResetOnPrompt = False
        Me.txtPriceOfCup.Size = New System.Drawing.Size(178, 20)
        Me.txtPriceOfCup.TabIndex = 20
        Me.txtPriceOfCup.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblPriceOfCup
        '
        Me.lblPriceOfCup.AutoSize = True
        Me.lblPriceOfCup.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.lblPriceOfCup.ForeColor = System.Drawing.Color.White
        Me.lblPriceOfCup.Location = New System.Drawing.Point(404, 105)
        Me.lblPriceOfCup.Name = "lblPriceOfCup"
        Me.lblPriceOfCup.Size = New System.Drawing.Size(87, 18)
        Me.lblPriceOfCup.TabIndex = 21
        Me.lblPriceOfCup.Text = "Price of cup"
        '
        'cmbSizeOfCup
        '
        Me.cmbSizeOfCup.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.cmbSizeOfCup.DropDownHeight = 50
        Me.cmbSizeOfCup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbSizeOfCup.ForeColor = System.Drawing.Color.White
        Me.cmbSizeOfCup.FormattingEnabled = True
        Me.cmbSizeOfCup.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmbSizeOfCup.IntegralHeight = False
        Me.cmbSizeOfCup.ItemHeight = 13
        Me.cmbSizeOfCup.Items.AddRange(New Object() {"Demi", "Short", "Tall", "Grande", "Venti", "Trenta"})
        Me.cmbSizeOfCup.Location = New System.Drawing.Point(144, 102)
        Me.cmbSizeOfCup.MaxDropDownItems = 3
        Me.cmbSizeOfCup.Name = "cmbSizeOfCup"
        Me.cmbSizeOfCup.Size = New System.Drawing.Size(178, 21)
        Me.cmbSizeOfCup.TabIndex = 19
        '
        'txtQuantity
        '
        Me.txtQuantity.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.txtQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtQuantity.ForeColor = System.Drawing.Color.White
        Me.txtQuantity.Location = New System.Drawing.Point(513, 39)
        Me.txtQuantity.Mask = "00"
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.PromptChar = Global.Microsoft.VisualBasic.ChrW(45)
        Me.txtQuantity.RejectInputOnFirstFailure = True
        Me.txtQuantity.ResetOnPrompt = False
        Me.txtQuantity.Size = New System.Drawing.Size(178, 20)
        Me.txtQuantity.TabIndex = 9
        Me.txtQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblQuantity
        '
        Me.lblQuantity.AutoSize = True
        Me.lblQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.lblQuantity.ForeColor = System.Drawing.Color.White
        Me.lblQuantity.Location = New System.Drawing.Point(404, 39)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(62, 18)
        Me.lblQuantity.TabIndex = 18
        Me.lblQuantity.Text = "Quantity"
        '
        'lblSizeOfCup
        '
        Me.lblSizeOfCup.AutoSize = True
        Me.lblSizeOfCup.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.lblSizeOfCup.ForeColor = System.Drawing.Color.White
        Me.lblSizeOfCup.Location = New System.Drawing.Point(20, 102)
        Me.lblSizeOfCup.Name = "lblSizeOfCup"
        Me.lblSizeOfCup.Size = New System.Drawing.Size(82, 18)
        Me.lblSizeOfCup.TabIndex = 11
        Me.lblSizeOfCup.Text = "Size of cup"
        '
        'lblBeverage
        '
        Me.lblBeverage.AutoSize = True
        Me.lblBeverage.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.lblBeverage.ForeColor = System.Drawing.Color.White
        Me.lblBeverage.Location = New System.Drawing.Point(20, 37)
        Me.lblBeverage.Name = "lblBeverage"
        Me.lblBeverage.Size = New System.Drawing.Size(70, 18)
        Me.lblBeverage.TabIndex = 10
        Me.lblBeverage.Text = "Beverage"
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(391, 408)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(74, 30)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Location = New System.Drawing.Point(723, 408)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(74, 30)
        Me.btnClear.TabIndex = 2
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBack.ForeColor = System.Drawing.Color.White
        Me.btnBack.Location = New System.Drawing.Point(62, 408)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(74, 30)
        Me.btnBack.TabIndex = 3
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'mnsProfile
        '
        Me.mnsProfile.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.mnsProfile.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuExit})
        Me.mnsProfile.Location = New System.Drawing.Point(0, 0)
        Me.mnsProfile.Name = "mnsProfile"
        Me.mnsProfile.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.mnsProfile.Size = New System.Drawing.Size(859, 24)
        Me.mnsProfile.TabIndex = 4
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
        'frmOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(859, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.mnsProfile)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.grpProfile)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmOrder"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Order"
        Me.grpProfile.ResumeLayout(False)
        Me.grpProfile.PerformLayout()
        Me.grpWithMilk.ResumeLayout(False)
        Me.grpWithMilk.PerformLayout()
        Me.grpTempreature.ResumeLayout(False)
        Me.grpTempreature.PerformLayout()
        Me.mnsProfile.ResumeLayout(False)
        Me.mnsProfile.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtBeverage As TextBox
    Friend WithEvents grpProfile As GroupBox
    Friend WithEvents lblQuantity As Label
    Friend WithEvents lblTemperature As Label
    Friend WithEvents lblSizeOfCup As Label
    Friend WithEvents lblBeverage As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents txtQuantity As MaskedTextBox
    Friend WithEvents mnsProfile As MenuStrip
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents rdoHot As RadioButton
    Friend WithEvents rdoIced As RadioButton
    Friend WithEvents cmbSizeOfCup As ComboBox
    Friend WithEvents txtPriceOfCup As MaskedTextBox
    Friend WithEvents lblPriceOfCup As Label
    Friend WithEvents cmbSyrups As ComboBox
    Friend WithEvents lblSyrups As Label
    Friend WithEvents rdoNo As RadioButton
    Friend WithEvents rdoYes As RadioButton
    Friend WithEvents lblWithMilk As Label
    Friend WithEvents rtxNote As RichTextBox
    Friend WithEvents grpWithMilk As GroupBox
    Friend WithEvents grpTempreature As GroupBox
End Class
