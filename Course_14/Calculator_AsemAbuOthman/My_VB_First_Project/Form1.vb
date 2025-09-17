Imports System.Math

Public Class frmCalculator

    Public decNumber1, decNumber2, decResult As Decimal
    Public chOperation As String

    Private Sub frmCalculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtNumber1.Focus()


    End Sub

    Private Sub txtNumber1_TextChanged(sender As Object, e As EventArgs) Handles txtNumber1.TextChanged

        If txtNumber1.Text <> "" Then

            Try

                If txtNumber1.Text = "-" Then

                    decNumber1 = Val("-" & txtNumber1.Text)

                Else

                    decNumber1 = txtNumber1.Text

                End If


            Catch ex As Exception

                MsgBox("Plz enter a numeric value in (Num1) ")

                txtNumber1.Clear()
                txtNumber1.Focus()
            End Try

        End If

    End Sub

    Private Sub txtNumber2_TextChanged(sender As Object, e As EventArgs) Handles txtNumber2.TextChanged

        If txtNumber2.Text <> "" Then

            Try

                If txtNumber2.Text = "-" Then

                    decNumber2 = Val("-" & txtNumber2.Text)

                Else

                    decNumber2 = txtNumber2.Text

                End If

            Catch ex As Exception


                MsgBox("Plz enter a numeric value in (Num2) ")
                txtNumber2.Clear()
                txtNumber2.Focus()

            End Try

        End If

    End Sub

    Private Sub btnZero_Click(sender As Object, e As EventArgs) Handles btnZero.Click

        txtNumber1.SelectedText = btnZero.Text
        decNumber1 += Val(txtNumber1.Text)

        txtNumber1.Focus()

    End Sub


    Private Sub btnOne_Click(sender As Object, e As EventArgs) Handles btnOne.Click

        txtNumber1.SelectedText = btnOne.Text
        decNumber1 += Val(txtNumber1.Text)

        txtNumber1.Focus()
    End Sub

    Private Sub btnTwo_Click(sender As Object, e As EventArgs) Handles btnTwo.Click

        txtNumber1.SelectedText = btnTwo.Text
        decNumber1 += Val(txtNumber1.Text)

        txtNumber1.Focus()



    End Sub

    Private Sub btnThree_Click(sender As Object, e As EventArgs) Handles btnThree.Click


        txtNumber1.SelectedText = btnThree.Text
        decNumber1 += Val(txtNumber1.Text)

        txtNumber1.Focus()


    End Sub

    Private Sub btnFour_Click(sender As Object, e As EventArgs) Handles btnFour.Click

        txtNumber1.SelectedText = btnFour.Text
        decNumber1 += Val(txtNumber1.Text)

        txtNumber1.Focus()



    End Sub

    Private Sub btnFive_Click(sender As Object, e As EventArgs) Handles btnFive.Click


        txtNumber1.SelectedText = btnFive.Text
        decNumber1 += Val(txtNumber1.Text)

        txtNumber1.Focus()


    End Sub

    Private Sub btnSix_Click(sender As Object, e As EventArgs) Handles btnSix.Click

        txtNumber1.SelectedText = btnSix.Text
        decNumber1 += Val(txtNumber1.Text)

        txtNumber1.Focus()


    End Sub

    Private Sub btnSeven_Click(sender As Object, e As EventArgs) Handles btnSeven.Click

        txtNumber1.SelectedText = btnSeven.Text
        decNumber1 += Val(txtNumber1.Text)

        txtNumber1.Focus()

    End Sub

    Private Sub btnEight_Click(sender As Object, e As EventArgs) Handles btnEight.Click

        txtNumber1.SelectedText = btnEight.Text
        decNumber1 += Val(txtNumber1.Text)

        txtNumber1.Focus()
    End Sub

    Private Sub btnNine_Click(sender As Object, e As EventArgs) Handles btnNine.Click

        txtNumber1.SelectedText = btnNine.Text
        decNumber1 += Val(txtNumber1.Text)

        txtNumber1.Focus()

    End Sub


    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click


        decNumber1 = Val(txtNumber1.Text)
        decNumber2 = Val(txtNumber2.Text)

        decResult = decNumber1 + decNumber2
        txtOperation.Text = "+"
    End Sub

    Private Sub btnSub_Click(sender As Object, e As EventArgs) Handles btnSub.Click

        decResult = decNumber1 - decNumber2
        txtOperation.Text = "-"
    End Sub

    Private Sub btnMod_Click(sender As Object, e As EventArgs) Handles btnMod.Click

        Try

            decResult = decNumber1 Mod decNumber2
            txtOperation.Text = "%"
            chOperation = "%"
        Catch ex As Exception

            MessageBox.Show("Error: (Divied by Zero) ")

            txtResult.Clear()
            txtNumber1.Clear()
            txtNumber2.Clear()

            Exit Sub

        End Try

    End Sub

    Private Sub btnMul_Click(sender As Object, e As EventArgs) Handles btnMul.Click

        Try

            decResult = decNumber1 * decNumber2
            txtOperation.Text = "*"
        Catch ex As Exception

            MessageBox.Show("Error you must enter a number!")

            txtResult.Clear()

            Exit Sub

        End Try


    End Sub

    Private Sub btnDiv_Click(sender As Object, e As EventArgs) Handles btnDivDec.Click

        Try

            decResult = decNumber1 / decNumber2
            txtOperation.Text = "/"

        Catch ex As Exception

            MessageBox.Show("Error: (Divied by Zero) ")

            txtResult.Clear()
            txtNumber1.Clear()
            txtNumber2.Clear()

            Exit Sub

        End Try

    End Sub

    Private Sub btnPow_Click(sender As Object, e As EventArgs) Handles btnExp.Click

        decResult = Math.Pow(decNumber1, decNumber2)
        chOperation = "exp"

        txtOperation.Text = "exp"
    End Sub

    Private Sub btnCeil_Click(sender As Object, e As EventArgs) Handles btnCeil.Click

        decResult = Math.Ceiling(decNumber1)
        chOperation = "⌈x⌉"
        txtOperation.Text = "⌈x⌉"

    End Sub

    Private Sub btnFloor_Click(sender As Object, e As EventArgs) Handles btnFloor.Click

        decResult = Math.Floor(decNumber1)
        chOperation = "⌊x⌋"
        txtOperation.Text = "⌊x⌋"
    End Sub

    Private Sub btnRound_Click(sender As Object, e As EventArgs) Handles btnRound.Click

        decResult = Math.Round(decNumber1)
        chOperation = "rnd"
        txtOperation.Text = "rnd"

    End Sub

    Private Sub btnMin_Click(sender As Object, e As EventArgs) Handles btnMin.Click

        decResult = Math.Min(decNumber1, decNumber2)
        chOperation = "min"
        txtOperation.Text = "min"

    End Sub

    Private Sub btnMax_Click(sender As Object, e As EventArgs) Handles btnMax.Click

        decResult = Math.Max(decNumber1, decNumber2)
        chOperation = "max"
        txtOperation.Text = "max"

    End Sub

    Private Sub btnSqrt_Click(sender As Object, e As EventArgs) Handles btnSqrt.Click

        decResult = Math.Sqrt(decNumber1)
        chOperation = "sqrt"
        txtOperation.Text = "sqrt"
    End Sub

    Private Sub btnAbs_Click(sender As Object, e As EventArgs) Handles btnAbs.Click

        decResult = Math.Abs(decNumber1)
        chOperation = "|x|"

    End Sub

    Private Sub btnPow_Click_1(sender As Object, e As EventArgs) Handles btnPow.Click

        decResult = Math.Pow(decNumber1, decNumber2)

        chOperation = "pow"

        txtOperation.Text = "pow"

    End Sub

    Private Sub btnPi_Click(sender As Object, e As EventArgs) Handles btnPi.Click

        If txtNumber1.Focus() = True Then

            txtNumber1.Text = Math.PI.ToString

            decNumber1 = Val(txtNumber1.Text)

        ElseIf txtNumber2.Focus() = True Then

            txtNumber2.Text = Math.PI.ToString

            decNumber2 = Val(txtNumber2.Text)

        End If

    End Sub

    Private Sub btnEqual_Click(sender As Object, e As EventArgs) Handles btnEqual.Click

        Try

            If txtNumber1.Text = "" Then

                MessageBox.Show("Plz enter a number 1")
                txtNumber1.Focus()

            ElseIf txtNumber2.Text = "" Then

                MessageBox.Show("Plz enter a number 2")
                txtNumber2.Focus()

            ElseIf txtOperation.Text = "" Then

                MessageBox.Show("Plz enter an Operation")

            Else
                txtResult.Text = decResult

            End If



        Catch ex As Exception

            MsgBox(ex.Message)


        End Try

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        txtNumber1.Text = ""
        txtNumber2.Text = ""
        txtOperation.Text = ""
        txtResult.Text = ""

        decNumber1 = Val(txtNumber1.Text)
        decNumber2 = Val(txtNumber2.Text)
        decResult = Val(txtResult.Text)

        txtNumber1.Focus()

    End Sub


End Class
