<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCalculator
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
        Me.lblNumber1 = New System.Windows.Forms.Label()
        Me.lblNumber2 = New System.Windows.Forms.Label()
        Me.txtNumber1 = New System.Windows.Forms.TextBox()
        Me.txtNumber2 = New System.Windows.Forms.TextBox()
        Me.txtResult = New System.Windows.Forms.TextBox()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnDivDec = New System.Windows.Forms.Button()
        Me.btnMul = New System.Windows.Forms.Button()
        Me.btnSub = New System.Windows.Forms.Button()
        Me.btnMod = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnEqual = New System.Windows.Forms.Button()
        Me.txtOperation = New System.Windows.Forms.TextBox()
        Me.btnSqrt = New System.Windows.Forms.Button()
        Me.btnCeil = New System.Windows.Forms.Button()
        Me.btnExp = New System.Windows.Forms.Button()
        Me.btnFloor = New System.Windows.Forms.Button()
        Me.btnAbs = New System.Windows.Forms.Button()
        Me.btnPeriodNotation = New System.Windows.Forms.Button()
        Me.btnRound = New System.Windows.Forms.Button()
        Me.btnMin = New System.Windows.Forms.Button()
        Me.btnMax = New System.Windows.Forms.Button()
        Me.btnFour = New System.Windows.Forms.Button()
        Me.btnFive = New System.Windows.Forms.Button()
        Me.btnSix = New System.Windows.Forms.Button()
        Me.btnOne = New System.Windows.Forms.Button()
        Me.btnTwo = New System.Windows.Forms.Button()
        Me.btnThree = New System.Windows.Forms.Button()
        Me.btnZero = New System.Windows.Forms.Button()
        Me.btnNine = New System.Windows.Forms.Button()
        Me.btnEight = New System.Windows.Forms.Button()
        Me.btnSeven = New System.Windows.Forms.Button()
        Me.btnDel = New System.Windows.Forms.Button()
        Me.btnPi = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnOneDivX = New System.Windows.Forms.Button()
        Me.btnEuilerNum = New System.Windows.Forms.Button()
        Me.btnPow = New System.Windows.Forms.Button()
        Me.btnLog10 = New System.Windows.Forms.Button()
        Me.btnParenthesis = New System.Windows.Forms.Button()
        Me.btnLeftParenthesis = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblNumber1
        '
        Me.lblNumber1.AutoSize = True
        Me.lblNumber1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblNumber1.Font = New System.Drawing.Font("Arial", 13.0!)
        Me.lblNumber1.ForeColor = System.Drawing.Color.White
        Me.lblNumber1.Location = New System.Drawing.Point(14, 17)
        Me.lblNumber1.Name = "lblNumber1"
        Me.lblNumber1.Size = New System.Drawing.Size(57, 21)
        Me.lblNumber1.TabIndex = 39
        Me.lblNumber1.Text = "Num1"
        '
        'lblNumber2
        '
        Me.lblNumber2.AutoSize = True
        Me.lblNumber2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblNumber2.Font = New System.Drawing.Font("Arial", 13.0!)
        Me.lblNumber2.ForeColor = System.Drawing.Color.White
        Me.lblNumber2.Location = New System.Drawing.Point(14, 104)
        Me.lblNumber2.Name = "lblNumber2"
        Me.lblNumber2.Size = New System.Drawing.Size(57, 21)
        Me.lblNumber2.TabIndex = 40
        Me.lblNumber2.Text = "Num2"
        '
        'txtNumber1
        '
        Me.txtNumber1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtNumber1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNumber1.Font = New System.Drawing.Font("Arial", 13.0!)
        Me.txtNumber1.ForeColor = System.Drawing.Color.White
        Me.txtNumber1.Location = New System.Drawing.Point(91, 15)
        Me.txtNumber1.Name = "txtNumber1"
        Me.txtNumber1.Size = New System.Drawing.Size(214, 27)
        Me.txtNumber1.TabIndex = 0
        '
        'txtNumber2
        '
        Me.txtNumber2.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtNumber2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNumber2.Font = New System.Drawing.Font("Arial", 13.0!)
        Me.txtNumber2.ForeColor = System.Drawing.Color.White
        Me.txtNumber2.Location = New System.Drawing.Point(91, 102)
        Me.txtNumber2.Name = "txtNumber2"
        Me.txtNumber2.Size = New System.Drawing.Size(214, 27)
        Me.txtNumber2.TabIndex = 1
        '
        'txtResult
        '
        Me.txtResult.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtResult.Font = New System.Drawing.Font("Arial", 13.0!)
        Me.txtResult.ForeColor = System.Drawing.Color.White
        Me.txtResult.Location = New System.Drawing.Point(91, 183)
        Me.txtResult.Multiline = True
        Me.txtResult.Name = "txtResult"
        Me.txtResult.ReadOnly = True
        Me.txtResult.Size = New System.Drawing.Size(214, 40)
        Me.txtResult.TabIndex = 37
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblResult.Font = New System.Drawing.Font("Arial", 13.0!)
        Me.lblResult.ForeColor = System.Drawing.Color.White
        Me.lblResult.Location = New System.Drawing.Point(14, 202)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(61, 21)
        Me.lblResult.TabIndex = 38
        Me.lblResult.Text = "Result"
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.btnAdd.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Arial", 13.0!)
        Me.btnAdd.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnAdd.Location = New System.Drawing.Point(252, 445)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(1)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(60, 36)
        Me.btnAdd.TabIndex = 35
        Me.btnAdd.Text = "&+"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnDivDec
        '
        Me.btnDivDec.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnDivDec.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnDivDec.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.btnDivDec.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnDivDec.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDivDec.Font = New System.Drawing.Font("Arial", 13.0!)
        Me.btnDivDec.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnDivDec.Location = New System.Drawing.Point(252, 331)
        Me.btnDivDec.Margin = New System.Windows.Forms.Padding(1)
        Me.btnDivDec.Name = "btnDivDec"
        Me.btnDivDec.Size = New System.Drawing.Size(60, 36)
        Me.btnDivDec.TabIndex = 20
        Me.btnDivDec.Text = "&÷"
        Me.btnDivDec.UseVisualStyleBackColor = True
        '
        'btnMul
        '
        Me.btnMul.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnMul.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnMul.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.btnMul.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnMul.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMul.Font = New System.Drawing.Font("Arial", 13.0!)
        Me.btnMul.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnMul.Location = New System.Drawing.Point(252, 369)
        Me.btnMul.Margin = New System.Windows.Forms.Padding(1)
        Me.btnMul.Name = "btnMul"
        Me.btnMul.Size = New System.Drawing.Size(60, 36)
        Me.btnMul.TabIndex = 33
        Me.btnMul.Text = "&x"
        Me.btnMul.UseVisualStyleBackColor = True
        '
        'btnSub
        '
        Me.btnSub.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnSub.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnSub.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.btnSub.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnSub.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSub.Font = New System.Drawing.Font("Arial", 13.0!)
        Me.btnSub.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnSub.Location = New System.Drawing.Point(252, 407)
        Me.btnSub.Margin = New System.Windows.Forms.Padding(1)
        Me.btnSub.Name = "btnSub"
        Me.btnSub.Size = New System.Drawing.Size(60, 36)
        Me.btnSub.TabIndex = 34
        Me.btnSub.Text = "&-"
        Me.btnSub.UseVisualStyleBackColor = True
        '
        'btnMod
        '
        Me.btnMod.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnMod.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnMod.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.btnMod.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnMod.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnMod.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.btnMod.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMod.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.btnMod.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnMod.Location = New System.Drawing.Point(252, 293)
        Me.btnMod.Margin = New System.Windows.Forms.Padding(1)
        Me.btnMod.Name = "btnMod"
        Me.btnMod.Size = New System.Drawing.Size(60, 36)
        Me.btnMod.TabIndex = 16
        Me.btnMod.Text = "mod"
        Me.btnMod.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.btnClear.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.btnClear.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnClear.Location = New System.Drawing.Point(190, 255)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(1)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(60, 36)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "C"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnEqual
        '
        Me.btnEqual.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btnEqual.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnEqual.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.btnEqual.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnEqual.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnEqual.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.btnEqual.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEqual.Font = New System.Drawing.Font("Arial", 13.0!)
        Me.btnEqual.ForeColor = System.Drawing.Color.Black
        Me.btnEqual.Location = New System.Drawing.Point(252, 483)
        Me.btnEqual.Margin = New System.Windows.Forms.Padding(1)
        Me.btnEqual.Name = "btnEqual"
        Me.btnEqual.Size = New System.Drawing.Size(60, 36)
        Me.btnEqual.TabIndex = 36
        Me.btnEqual.Text = "&="
        Me.btnEqual.UseVisualStyleBackColor = False
        '
        'txtOperation
        '
        Me.txtOperation.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtOperation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOperation.Font = New System.Drawing.Font("Arial", 13.0!)
        Me.txtOperation.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.txtOperation.Location = New System.Drawing.Point(230, 54)
        Me.txtOperation.Margin = New System.Windows.Forms.Padding(2)
        Me.txtOperation.MaxLength = 1
        Me.txtOperation.Multiline = True
        Me.txtOperation.Name = "txtOperation"
        Me.txtOperation.ReadOnly = True
        Me.txtOperation.Size = New System.Drawing.Size(60, 36)
        Me.txtOperation.TabIndex = 41
        Me.txtOperation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtOperation.WordWrap = False
        '
        'btnSqrt
        '
        Me.btnSqrt.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnSqrt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnSqrt.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.btnSqrt.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnSqrt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSqrt.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.btnSqrt.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnSqrt.Location = New System.Drawing.Point(4, 331)
        Me.btnSqrt.Margin = New System.Windows.Forms.Padding(1)
        Me.btnSqrt.Name = "btnSqrt"
        Me.btnSqrt.Size = New System.Drawing.Size(60, 36)
        Me.btnSqrt.TabIndex = 8
        Me.btnSqrt.Text = "sqrt"
        Me.btnSqrt.UseVisualStyleBackColor = True
        '
        'btnCeil
        '
        Me.btnCeil.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnCeil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnCeil.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.btnCeil.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnCeil.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCeil.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.btnCeil.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnCeil.Location = New System.Drawing.Point(4, 445)
        Me.btnCeil.Margin = New System.Windows.Forms.Padding(1)
        Me.btnCeil.Name = "btnCeil"
        Me.btnCeil.Size = New System.Drawing.Size(60, 36)
        Me.btnCeil.TabIndex = 11
        Me.btnCeil.Text = "⌈x⌉"
        Me.btnCeil.UseVisualStyleBackColor = True
        '
        'btnExp
        '
        Me.btnExp.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnExp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnExp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.btnExp.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnExp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExp.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.btnExp.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnExp.Location = New System.Drawing.Point(190, 293)
        Me.btnExp.Margin = New System.Windows.Forms.Padding(1)
        Me.btnExp.Name = "btnExp"
        Me.btnExp.Size = New System.Drawing.Size(60, 36)
        Me.btnExp.TabIndex = 15
        Me.btnExp.Text = "exp"
        Me.btnExp.UseVisualStyleBackColor = True
        '
        'btnFloor
        '
        Me.btnFloor.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnFloor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnFloor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.btnFloor.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnFloor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFloor.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.btnFloor.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnFloor.Location = New System.Drawing.Point(4, 483)
        Me.btnFloor.Margin = New System.Windows.Forms.Padding(1)
        Me.btnFloor.Name = "btnFloor"
        Me.btnFloor.Size = New System.Drawing.Size(60, 36)
        Me.btnFloor.TabIndex = 12
        Me.btnFloor.Text = "⌊x⌋"
        Me.btnFloor.UseVisualStyleBackColor = True
        '
        'btnAbs
        '
        Me.btnAbs.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnAbs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnAbs.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.btnAbs.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnAbs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAbs.Font = New System.Drawing.Font("Arial", 13.0!)
        Me.btnAbs.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnAbs.Location = New System.Drawing.Point(128, 293)
        Me.btnAbs.Margin = New System.Windows.Forms.Padding(1)
        Me.btnAbs.Name = "btnAbs"
        Me.btnAbs.Size = New System.Drawing.Size(60, 36)
        Me.btnAbs.TabIndex = 14
        Me.btnAbs.Text = "|x|"
        Me.btnAbs.UseVisualStyleBackColor = True
        '
        'btnPeriodNotation
        '
        Me.btnPeriodNotation.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnPeriodNotation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnPeriodNotation.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.btnPeriodNotation.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnPeriodNotation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPeriodNotation.Font = New System.Drawing.Font("Arial", 13.0!)
        Me.btnPeriodNotation.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnPeriodNotation.Location = New System.Drawing.Point(190, 483)
        Me.btnPeriodNotation.Margin = New System.Windows.Forms.Padding(1)
        Me.btnPeriodNotation.Name = "btnPeriodNotation"
        Me.btnPeriodNotation.Size = New System.Drawing.Size(60, 36)
        Me.btnPeriodNotation.TabIndex = 21
        Me.btnPeriodNotation.Text = "."
        Me.btnPeriodNotation.UseVisualStyleBackColor = False
        '
        'btnRound
        '
        Me.btnRound.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnRound.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnRound.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.btnRound.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnRound.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRound.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.btnRound.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnRound.Location = New System.Drawing.Point(4, 293)
        Me.btnRound.Margin = New System.Windows.Forms.Padding(1)
        Me.btnRound.Name = "btnRound"
        Me.btnRound.Size = New System.Drawing.Size(60, 36)
        Me.btnRound.TabIndex = 7
        Me.btnRound.Text = "rnd"
        Me.btnRound.UseVisualStyleBackColor = True
        '
        'btnMin
        '
        Me.btnMin.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnMin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.btnMin.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMin.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.btnMin.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnMin.Location = New System.Drawing.Point(4, 407)
        Me.btnMin.Margin = New System.Windows.Forms.Padding(1)
        Me.btnMin.Name = "btnMin"
        Me.btnMin.Size = New System.Drawing.Size(60, 36)
        Me.btnMin.TabIndex = 10
        Me.btnMin.Text = "min"
        Me.btnMin.UseVisualStyleBackColor = True
        '
        'btnMax
        '
        Me.btnMax.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnMax.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnMax.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.btnMax.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMax.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.btnMax.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnMax.Location = New System.Drawing.Point(4, 369)
        Me.btnMax.Margin = New System.Windows.Forms.Padding(1)
        Me.btnMax.Name = "btnMax"
        Me.btnMax.Size = New System.Drawing.Size(60, 36)
        Me.btnMax.TabIndex = 9
        Me.btnMax.Text = "max"
        Me.btnMax.UseVisualStyleBackColor = True
        '
        'btnFour
        '
        Me.btnFour.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnFour.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnFour.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.btnFour.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnFour.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFour.Font = New System.Drawing.Font("Arial", 13.0!)
        Me.btnFour.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnFour.Location = New System.Drawing.Point(66, 407)
        Me.btnFour.Margin = New System.Windows.Forms.Padding(1)
        Me.btnFour.Name = "btnFour"
        Me.btnFour.Size = New System.Drawing.Size(60, 36)
        Me.btnFour.TabIndex = 27
        Me.btnFour.Text = "4"
        Me.btnFour.UseVisualStyleBackColor = False
        '
        'btnFive
        '
        Me.btnFive.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnFive.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnFive.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.btnFive.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnFive.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFive.Font = New System.Drawing.Font("Arial", 13.0!)
        Me.btnFive.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnFive.Location = New System.Drawing.Point(128, 407)
        Me.btnFive.Margin = New System.Windows.Forms.Padding(1)
        Me.btnFive.Name = "btnFive"
        Me.btnFive.Size = New System.Drawing.Size(60, 36)
        Me.btnFive.TabIndex = 28
        Me.btnFive.Text = "5"
        Me.btnFive.UseVisualStyleBackColor = False
        '
        'btnSix
        '
        Me.btnSix.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnSix.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnSix.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.btnSix.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnSix.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSix.Font = New System.Drawing.Font("Arial", 13.0!)
        Me.btnSix.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnSix.Location = New System.Drawing.Point(190, 407)
        Me.btnSix.Margin = New System.Windows.Forms.Padding(1)
        Me.btnSix.Name = "btnSix"
        Me.btnSix.Size = New System.Drawing.Size(60, 36)
        Me.btnSix.TabIndex = 29
        Me.btnSix.Text = "6"
        Me.btnSix.UseVisualStyleBackColor = False
        '
        'btnOne
        '
        Me.btnOne.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnOne.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnOne.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.btnOne.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOne.Font = New System.Drawing.Font("Arial", 13.0!)
        Me.btnOne.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnOne.Location = New System.Drawing.Point(66, 445)
        Me.btnOne.Margin = New System.Windows.Forms.Padding(1)
        Me.btnOne.Name = "btnOne"
        Me.btnOne.Size = New System.Drawing.Size(60, 36)
        Me.btnOne.TabIndex = 24
        Me.btnOne.Text = "1"
        Me.btnOne.UseVisualStyleBackColor = False
        '
        'btnTwo
        '
        Me.btnTwo.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnTwo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnTwo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.btnTwo.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnTwo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTwo.Font = New System.Drawing.Font("Arial", 13.0!)
        Me.btnTwo.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnTwo.Location = New System.Drawing.Point(128, 445)
        Me.btnTwo.Margin = New System.Windows.Forms.Padding(1)
        Me.btnTwo.Name = "btnTwo"
        Me.btnTwo.Size = New System.Drawing.Size(60, 36)
        Me.btnTwo.TabIndex = 25
        Me.btnTwo.Text = "2"
        Me.btnTwo.UseVisualStyleBackColor = False
        '
        'btnThree
        '
        Me.btnThree.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnThree.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnThree.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.btnThree.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnThree.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnThree.Font = New System.Drawing.Font("Arial", 13.0!)
        Me.btnThree.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnThree.Location = New System.Drawing.Point(190, 445)
        Me.btnThree.Margin = New System.Windows.Forms.Padding(1)
        Me.btnThree.Name = "btnThree"
        Me.btnThree.Size = New System.Drawing.Size(60, 36)
        Me.btnThree.TabIndex = 26
        Me.btnThree.Text = "3"
        Me.btnThree.UseVisualStyleBackColor = False
        '
        'btnZero
        '
        Me.btnZero.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnZero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnZero.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.btnZero.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnZero.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnZero.Font = New System.Drawing.Font("Arial", 13.0!)
        Me.btnZero.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnZero.Location = New System.Drawing.Point(128, 483)
        Me.btnZero.Margin = New System.Windows.Forms.Padding(1)
        Me.btnZero.Name = "btnZero"
        Me.btnZero.Size = New System.Drawing.Size(60, 36)
        Me.btnZero.TabIndex = 23
        Me.btnZero.Text = "0"
        Me.btnZero.UseVisualStyleBackColor = False
        '
        'btnNine
        '
        Me.btnNine.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnNine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnNine.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.btnNine.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnNine.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNine.Font = New System.Drawing.Font("Arial", 13.0!)
        Me.btnNine.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnNine.Location = New System.Drawing.Point(190, 369)
        Me.btnNine.Margin = New System.Windows.Forms.Padding(1)
        Me.btnNine.Name = "btnNine"
        Me.btnNine.Size = New System.Drawing.Size(60, 36)
        Me.btnNine.TabIndex = 32
        Me.btnNine.Text = "9"
        Me.btnNine.UseVisualStyleBackColor = False
        '
        'btnEight
        '
        Me.btnEight.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnEight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnEight.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.btnEight.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnEight.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEight.Font = New System.Drawing.Font("Arial", 13.0!)
        Me.btnEight.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnEight.Location = New System.Drawing.Point(128, 369)
        Me.btnEight.Margin = New System.Windows.Forms.Padding(1)
        Me.btnEight.Name = "btnEight"
        Me.btnEight.Size = New System.Drawing.Size(60, 36)
        Me.btnEight.TabIndex = 31
        Me.btnEight.Text = "8"
        Me.btnEight.UseVisualStyleBackColor = False
        '
        'btnSeven
        '
        Me.btnSeven.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnSeven.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnSeven.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.btnSeven.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnSeven.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSeven.Font = New System.Drawing.Font("Arial", 13.0!)
        Me.btnSeven.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnSeven.Location = New System.Drawing.Point(66, 369)
        Me.btnSeven.Margin = New System.Windows.Forms.Padding(1)
        Me.btnSeven.Name = "btnSeven"
        Me.btnSeven.Size = New System.Drawing.Size(60, 36)
        Me.btnSeven.TabIndex = 30
        Me.btnSeven.Text = "7"
        Me.btnSeven.UseVisualStyleBackColor = False
        '
        'btnDel
        '
        Me.btnDel.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnDel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnDel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.btnDel.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDel.Font = New System.Drawing.Font("Arial", 13.0!)
        Me.btnDel.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnDel.Location = New System.Drawing.Point(252, 255)
        Me.btnDel.Margin = New System.Windows.Forms.Padding(1)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(60, 36)
        Me.btnDel.TabIndex = 6
        Me.btnDel.Text = "del"
        Me.btnDel.UseVisualStyleBackColor = True
        '
        'btnPi
        '
        Me.btnPi.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnPi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnPi.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.btnPi.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnPi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPi.Font = New System.Drawing.Font("Arial", 13.0!)
        Me.btnPi.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnPi.Location = New System.Drawing.Point(66, 255)
        Me.btnPi.Margin = New System.Windows.Forms.Padding(1)
        Me.btnPi.Name = "btnPi"
        Me.btnPi.Size = New System.Drawing.Size(60, 36)
        Me.btnPi.TabIndex = 3
        Me.btnPi.Text = "𝛑"
        Me.btnPi.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.Button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Arial", 13.0!)
        Me.Button1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Button1.Location = New System.Drawing.Point(66, 483)
        Me.Button1.Margin = New System.Windows.Forms.Padding(1)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(60, 36)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "+/-"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnOneDivX
        '
        Me.btnOneDivX.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnOneDivX.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnOneDivX.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.btnOneDivX.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnOneDivX.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOneDivX.Font = New System.Drawing.Font("Arial", 13.0!)
        Me.btnOneDivX.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnOneDivX.Location = New System.Drawing.Point(66, 293)
        Me.btnOneDivX.Margin = New System.Windows.Forms.Padding(1)
        Me.btnOneDivX.Name = "btnOneDivX"
        Me.btnOneDivX.Size = New System.Drawing.Size(60, 36)
        Me.btnOneDivX.TabIndex = 13
        Me.btnOneDivX.Text = "1/x"
        Me.btnOneDivX.UseVisualStyleBackColor = True
        '
        'btnEuilerNum
        '
        Me.btnEuilerNum.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnEuilerNum.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnEuilerNum.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.btnEuilerNum.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnEuilerNum.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEuilerNum.Font = New System.Drawing.Font("Arial", 13.0!)
        Me.btnEuilerNum.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnEuilerNum.Location = New System.Drawing.Point(128, 255)
        Me.btnEuilerNum.Margin = New System.Windows.Forms.Padding(1)
        Me.btnEuilerNum.Name = "btnEuilerNum"
        Me.btnEuilerNum.Size = New System.Drawing.Size(60, 36)
        Me.btnEuilerNum.TabIndex = 4
        Me.btnEuilerNum.Text = "e"
        Me.btnEuilerNum.UseVisualStyleBackColor = True
        '
        'btnPow
        '
        Me.btnPow.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnPow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnPow.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.btnPow.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnPow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPow.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.btnPow.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnPow.Location = New System.Drawing.Point(4, 255)
        Me.btnPow.Margin = New System.Windows.Forms.Padding(1)
        Me.btnPow.Name = "btnPow"
        Me.btnPow.Size = New System.Drawing.Size(60, 36)
        Me.btnPow.TabIndex = 2
        Me.btnPow.Text = "pow"
        Me.btnPow.UseVisualStyleBackColor = True
        '
        'btnLog10
        '
        Me.btnLog10.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnLog10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnLog10.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.btnLog10.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnLog10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLog10.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.btnLog10.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnLog10.Location = New System.Drawing.Point(190, 331)
        Me.btnLog10.Margin = New System.Windows.Forms.Padding(1)
        Me.btnLog10.Name = "btnLog10"
        Me.btnLog10.Size = New System.Drawing.Size(60, 36)
        Me.btnLog10.TabIndex = 19
        Me.btnLog10.Text = "log"
        Me.btnLog10.UseVisualStyleBackColor = True
        '
        'btnParenthesis
        '
        Me.btnParenthesis.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnParenthesis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnParenthesis.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.btnParenthesis.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnParenthesis.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnParenthesis.Font = New System.Drawing.Font("Arial", 13.0!)
        Me.btnParenthesis.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnParenthesis.Location = New System.Drawing.Point(128, 331)
        Me.btnParenthesis.Margin = New System.Windows.Forms.Padding(1)
        Me.btnParenthesis.Name = "btnParenthesis"
        Me.btnParenthesis.Size = New System.Drawing.Size(60, 36)
        Me.btnParenthesis.TabIndex = 18
        Me.btnParenthesis.Text = ")"
        Me.btnParenthesis.UseVisualStyleBackColor = True
        '
        'btnLeftParenthesis
        '
        Me.btnLeftParenthesis.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnLeftParenthesis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnLeftParenthesis.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.btnLeftParenthesis.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnLeftParenthesis.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLeftParenthesis.Font = New System.Drawing.Font("Arial", 13.0!)
        Me.btnLeftParenthesis.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnLeftParenthesis.Location = New System.Drawing.Point(66, 331)
        Me.btnLeftParenthesis.Margin = New System.Windows.Forms.Padding(1)
        Me.btnLeftParenthesis.Name = "btnLeftParenthesis"
        Me.btnLeftParenthesis.Size = New System.Drawing.Size(60, 36)
        Me.btnLeftParenthesis.TabIndex = 17
        Me.btnLeftParenthesis.Text = "("
        Me.btnLeftParenthesis.UseVisualStyleBackColor = True
        '
        'frmCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(317, 522)
        Me.Controls.Add(Me.btnLeftParenthesis)
        Me.Controls.Add(Me.btnParenthesis)
        Me.Controls.Add(Me.btnLog10)
        Me.Controls.Add(Me.btnPow)
        Me.Controls.Add(Me.btnEuilerNum)
        Me.Controls.Add(Me.btnOneDivX)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnPi)
        Me.Controls.Add(Me.btnDel)
        Me.Controls.Add(Me.btnNine)
        Me.Controls.Add(Me.btnEight)
        Me.Controls.Add(Me.btnSeven)
        Me.Controls.Add(Me.btnZero)
        Me.Controls.Add(Me.btnThree)
        Me.Controls.Add(Me.btnTwo)
        Me.Controls.Add(Me.btnOne)
        Me.Controls.Add(Me.btnSix)
        Me.Controls.Add(Me.btnFive)
        Me.Controls.Add(Me.btnFour)
        Me.Controls.Add(Me.btnMax)
        Me.Controls.Add(Me.btnMin)
        Me.Controls.Add(Me.btnRound)
        Me.Controls.Add(Me.btnPeriodNotation)
        Me.Controls.Add(Me.btnAbs)
        Me.Controls.Add(Me.btnExp)
        Me.Controls.Add(Me.btnFloor)
        Me.Controls.Add(Me.btnCeil)
        Me.Controls.Add(Me.btnSqrt)
        Me.Controls.Add(Me.txtOperation)
        Me.Controls.Add(Me.btnEqual)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnMod)
        Me.Controls.Add(Me.btnSub)
        Me.Controls.Add(Me.btnMul)
        Me.Controls.Add(Me.btnDivDec)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.txtResult)
        Me.Controls.Add(Me.txtNumber2)
        Me.Controls.Add(Me.txtNumber1)
        Me.Controls.Add(Me.lblNumber2)
        Me.Controls.Add(Me.lblNumber1)
        Me.ForeColor = System.Drawing.Color.Transparent
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmCalculator"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNumber1 As Label
    Friend WithEvents lblNumber2 As Label
    Friend WithEvents txtNumber1 As TextBox
    Friend WithEvents txtNumber2 As TextBox
    Friend WithEvents txtResult As TextBox
    Friend WithEvents lblResult As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnDivDec As Button
    Friend WithEvents btnMul As Button
    Friend WithEvents btnSub As Button
    Friend WithEvents btnMod As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnEqual As Button
    Friend WithEvents txtOperation As TextBox
    Friend WithEvents btnSqrt As Button
    Friend WithEvents btnCeil As Button
    Friend WithEvents btnExp As Button
    Friend WithEvents btnFloor As Button
    Friend WithEvents btnAbs As Button
    Friend WithEvents btnPeriodNotation As Button
    Friend WithEvents btnRound As Button
    Friend WithEvents btnMin As Button
    Friend WithEvents btnMax As Button
    Friend WithEvents btnFour As Button
    Friend WithEvents btnFive As Button
    Friend WithEvents btnSix As Button
    Friend WithEvents btnOne As Button
    Friend WithEvents btnTwo As Button
    Friend WithEvents btnThree As Button
    Friend WithEvents btnZero As Button
    Friend WithEvents btnNine As Button
    Friend WithEvents btnEight As Button
    Friend WithEvents btnSeven As Button
    Friend WithEvents btnDel As Button
    Friend WithEvents btnPi As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents btnOneDivX As Button
    Friend WithEvents btnEuilerNum As Button
    Friend WithEvents btnPow As Button
    Friend WithEvents btnLog10 As Button
    Friend WithEvents btnParenthesis As Button
    Friend WithEvents btnLeftParenthesis As Button
End Class
