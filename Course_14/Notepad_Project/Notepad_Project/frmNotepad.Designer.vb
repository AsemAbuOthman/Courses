<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmNotepad
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
        Me.components = New System.ComponentModel.Container()
        Me.rtbEditor = New System.Windows.Forms.RichTextBox()
        Me.msNotepad = New System.Windows.Forms.MenuStrip()
        Me.tsmFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmSaveAs = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem7 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmCopy = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmCut = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmPaste = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmReplace = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsCopyCutPasteReplace = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmsCopy = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsCut = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsPaste = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsReplace = New System.Windows.Forms.ToolStripMenuItem()
        Me.msNotepad.SuspendLayout()
        Me.cmsCopyCutPasteReplace.SuspendLayout()
        Me.SuspendLayout()
        '
        'rtbEditor
        '
        Me.rtbEditor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rtbEditor.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.rtbEditor.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtbEditor.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbEditor.ForeColor = System.Drawing.Color.White
        Me.rtbEditor.Location = New System.Drawing.Point(9, 45)
        Me.rtbEditor.Margin = New System.Windows.Forms.Padding(0)
        Me.rtbEditor.Name = "rtbEditor"
        Me.rtbEditor.Size = New System.Drawing.Size(782, 396)
        Me.rtbEditor.TabIndex = 0
        Me.rtbEditor.Text = ""
        '
        'msNotepad
        '
        Me.msNotepad.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.msNotepad.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmFile, Me.tsmEdit})
        Me.msNotepad.Location = New System.Drawing.Point(0, 0)
        Me.msNotepad.Name = "msNotepad"
        Me.msNotepad.Size = New System.Drawing.Size(800, 29)
        Me.msNotepad.TabIndex = 1
        Me.msNotepad.Text = "MenuStrip1"
        '
        'tsmFile
        '
        Me.tsmFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.tsmFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmSave, Me.tsmSaveAs, Me.ToolStripMenuItem7})
        Me.tsmFile.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsmFile.ForeColor = System.Drawing.Color.White
        Me.tsmFile.Name = "tsmFile"
        Me.tsmFile.Size = New System.Drawing.Size(46, 25)
        Me.tsmFile.Text = "File"
        '
        'tsmSave
        '
        Me.tsmSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.tsmSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.tsmSave.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsmSave.ForeColor = System.Drawing.Color.White
        Me.tsmSave.Name = "tsmSave"
        Me.tsmSave.Size = New System.Drawing.Size(123, 22)
        Me.tsmSave.Text = "Save"
        '
        'tsmSaveAs
        '
        Me.tsmSaveAs.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.tsmSaveAs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.tsmSaveAs.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsmSaveAs.ForeColor = System.Drawing.Color.White
        Me.tsmSaveAs.Name = "tsmSaveAs"
        Me.tsmSaveAs.Size = New System.Drawing.Size(123, 22)
        Me.tsmSaveAs.Text = "Save As"
        '
        'ToolStripMenuItem7
        '
        Me.ToolStripMenuItem7.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.ToolStripMenuItem7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ToolStripMenuItem7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripMenuItem7.ForeColor = System.Drawing.Color.White
        Me.ToolStripMenuItem7.Name = "ToolStripMenuItem7"
        Me.ToolStripMenuItem7.Size = New System.Drawing.Size(123, 22)
        Me.ToolStripMenuItem7.Text = "Exit"
        '
        'tsmEdit
        '
        Me.tsmEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.tsmEdit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmCopy, Me.tsmCut, Me.tsmPaste, Me.tsmReplace, Me.tsmExit})
        Me.tsmEdit.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsmEdit.ForeColor = System.Drawing.Color.White
        Me.tsmEdit.Name = "tsmEdit"
        Me.tsmEdit.Size = New System.Drawing.Size(48, 25)
        Me.tsmEdit.Text = "Edit"
        '
        'tsmCopy
        '
        Me.tsmCopy.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.tsmCopy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.tsmCopy.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsmCopy.ForeColor = System.Drawing.Color.White
        Me.tsmCopy.Name = "tsmCopy"
        Me.tsmCopy.Size = New System.Drawing.Size(117, 22)
        Me.tsmCopy.Text = "Copy"
        '
        'tsmCut
        '
        Me.tsmCut.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.tsmCut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.tsmCut.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsmCut.ForeColor = System.Drawing.Color.White
        Me.tsmCut.Name = "tsmCut"
        Me.tsmCut.Size = New System.Drawing.Size(117, 22)
        Me.tsmCut.Text = "Cut"
        '
        'tsmPaste
        '
        Me.tsmPaste.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.tsmPaste.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.tsmPaste.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsmPaste.ForeColor = System.Drawing.Color.White
        Me.tsmPaste.Name = "tsmPaste"
        Me.tsmPaste.Size = New System.Drawing.Size(117, 22)
        Me.tsmPaste.Text = "Paste"
        '
        'tsmReplace
        '
        Me.tsmReplace.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.tsmReplace.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.tsmReplace.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsmReplace.ForeColor = System.Drawing.Color.White
        Me.tsmReplace.Name = "tsmReplace"
        Me.tsmReplace.Size = New System.Drawing.Size(117, 22)
        Me.tsmReplace.Text = "Replce"
        '
        'tsmExit
        '
        Me.tsmExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.tsmExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.tsmExit.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsmExit.ForeColor = System.Drawing.Color.White
        Me.tsmExit.Name = "tsmExit"
        Me.tsmExit.Size = New System.Drawing.Size(117, 22)
        Me.tsmExit.Text = "Exit"
        '
        'cmsCopyCutPasteReplace
        '
        Me.cmsCopyCutPasteReplace.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmsCopy, Me.cmsCut, Me.cmsPaste, Me.cmsReplace})
        Me.cmsCopyCutPasteReplace.Name = "cmsCopyCutPasteReplace"
        Me.cmsCopyCutPasteReplace.Size = New System.Drawing.Size(181, 114)
        '
        'cmsCopy
        '
        Me.cmsCopy.Name = "cmsCopy"
        Me.cmsCopy.Size = New System.Drawing.Size(180, 22)
        Me.cmsCopy.Text = "Copy"
        '
        'cmsCut
        '
        Me.cmsCut.Name = "cmsCut"
        Me.cmsCut.Size = New System.Drawing.Size(180, 22)
        Me.cmsCut.Text = "Cut"
        '
        'cmsPaste
        '
        Me.cmsPaste.Name = "cmsPaste"
        Me.cmsPaste.Size = New System.Drawing.Size(180, 22)
        Me.cmsPaste.Text = "Paste"
        '
        'cmsReplace
        '
        Me.cmsReplace.Name = "cmsReplace"
        Me.cmsReplace.Size = New System.Drawing.Size(180, 22)
        Me.cmsReplace.Text = "Replace"
        '
        'frmNotepad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.rtbEditor)
        Me.Controls.Add(Me.msNotepad)
        Me.MainMenuStrip = Me.msNotepad
        Me.Name = "frmNotepad"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Notepad"
        Me.msNotepad.ResumeLayout(False)
        Me.msNotepad.PerformLayout()
        Me.cmsCopyCutPasteReplace.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents rtbEditor As RichTextBox
    Friend WithEvents msNotepad As MenuStrip
    Friend WithEvents tsmEdit As ToolStripMenuItem
    Friend WithEvents tsmCopy As ToolStripMenuItem
    Friend WithEvents tsmCut As ToolStripMenuItem
    Friend WithEvents tsmPaste As ToolStripMenuItem
    Friend WithEvents tsmReplace As ToolStripMenuItem
    Friend WithEvents tsmExit As ToolStripMenuItem
    Friend WithEvents tsmFile As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem7 As ToolStripMenuItem
    Friend WithEvents tsmSave As ToolStripMenuItem
    Friend WithEvents tsmSaveAs As ToolStripMenuItem
    Friend WithEvents cmsCopyCutPasteReplace As ContextMenuStrip
    Friend WithEvents cmsCopy As ToolStripMenuItem
    Friend WithEvents cmsCut As ToolStripMenuItem
    Friend WithEvents cmsPaste As ToolStripMenuItem
    Friend WithEvents cmsReplace As ToolStripMenuItem
End Class
