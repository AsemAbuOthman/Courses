
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button


Public Class frmOrder

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click


        If Not txtBeverage.Text = "" Then

            modProfileInfo.stBeverage = txtBeverage.Text

        Else

            lblBeverage.Text = "Beverage *"


        End If

        If Not cmbSizeOfCup.Text = "" Then

            modProfileInfo.stSizeOfCup = cmbSizeOfCup.Text

        Else

            lblSizeOfCup.Text = "Size of cup *"

        End If

        If rdoIced.Checked Or rdoHot.Checked Then

            If rdoIced.Checked Then

                stTemperature = "Iced"

            ElseIf rdoHot.Checked Then

                stTemperature = "Hot"

            End If

        Else

            lblTemperature.Text = "Temperature *"

        End If

        If rdoYes.Checked Or rdoNo.Checked Then

            If rdoYes.Checked Then

                stWithMilk = "Yes"

            ElseIf rdoNo.Checked Then

                stWithMilk = "No"

            End If

        Else

            lblWithMilk.Text = "With Milk *"

        End If

        If Not cmbSyrups.Text = "" Then

            modProfileInfo.stSyrups = cmbSyrups.Text

        Else

            lblSyrups.Text = "Syrups *"

        End If


        If Not txtPriceOfCup.Text = "" Then

            intPrice = txtPriceOfCup.Text

        Else

            lblPriceOfCup.Text = "Price of cup *"

        End If

        If Not txtQuantity.Text = "" Then

            intQuantity = txtQuantity.Text

        Else

            lblQuantity.Text = "Quantity *"

        End If

        If Not txtBeverage.Text = "" And
           Not cmbSizeOfCup.Text = "" And
           (Not rdoIced.Checked Or Not rdoHot.Checked) And
           (Not rdoYes.Checked Or Not rdoNo.Checked) And
           Not cmbSyrups.Text = "" And
           Not txtQuantity.Text = "" And
           Not txtPriceOfCup.Text = "" Then

            MsgBox("Your Information has saved Successfully")

        Else

            MsgBox("Plz enter Your Information ")

            txtBeverage.Focus()

        End If

        dateOfOrder = Date.Now

        frmShowInfo.rtxShowInfo.AppendText(vbNewLine)

        frmShowInfo.rtxShowInfo.AppendText(" Beverage: " & vbTab & vbTab & stBeverage & vbNewLine)
        frmShowInfo.rtxShowInfo.AppendText(" Size: " & vbTab & vbTab & vbTab & stSizeOfCup & vbNewLine)
        frmShowInfo.rtxShowInfo.AppendText(" Temperature:" & vbTab & stTemperature & vbNewLine)
        frmShowInfo.rtxShowInfo.AppendText(" Price: " & vbTab & vbTab & vbTab & intPrice.ToString("C") & vbNewLine)
        frmShowInfo.rtxShowInfo.AppendText(" Milk: " & vbTab & vbTab & vbTab & stWithMilk & vbNewLine)
        frmShowInfo.rtxShowInfo.AppendText(" Syrups: " & vbTab & vbTab & stSyrups & vbNewLine)
        frmShowInfo.rtxShowInfo.AppendText(" Quantity: " & vbTab & vbTab & intQuantity & vbNewLine)
        frmShowInfo.rtxShowInfo.AppendText(" ---------------------------------------" & vbNewLine)
        frmShowInfo.rtxShowInfo.AppendText(" Total: " & vbTab & vbTab & vbTab & (intPrice * intQuantity).ToString("C"))

        frmShowInfo.rtxShowInfo.AppendText(vbNewLine & vbNewLine)

        frmShowInfo.rtxShowInfo.AppendText(" Time : " & dateOfOrder)

        frmShowInfo.rtxShowInfo.AppendText(vbNewLine & vbNewLine)

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        Dim doYouWantClaer As MsgBoxResult

        doYouWantClaer = MsgBox("Are you sure you want to clear ? ", vbYesNoCancel)

        If doYouWantClaer = vbYes Then

            txtBeverage.Clear()
            cmbSizeOfCup.ResetText()

            rdoIced.Checked = False
            rdoHot.Checked = False
            rdoYes.Checked = False
            rdoNo.Checked = False

            cmbSyrups.ResetText()

            txtPriceOfCup.Clear()
            txtQuantity.Clear()

            stBeverage = ""
            stSizeOfCup = ""
            stTemperature = ""
            stWithMilk = ""
            stSyrups = ""
            intPrice = 0
            intQuantity = 0


        End If


    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        Me.Hide()

        frmEdit.Activate()


    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuExit.Click

        Dim doYouWantToExit As MsgBoxResult

        doYouWantToExit = MsgBox("Are your sure you want to exit ? ", vbYesNo, "Exit")

        If doYouWantToExit = vbYes Then

            Application.Exit()

        End If
    End Sub


    Private Sub frmProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        intNoOfPage = 3

    End Sub

    Private Sub txtFirstName_TextChanged(sender As Object, e As EventArgs) Handles txtBeverage.TextChanged
        If IsNumeric(txtBeverage.Text) Then

            stBeverage = ""
            txtBeverage.Clear()
        End If

    End Sub


End Class