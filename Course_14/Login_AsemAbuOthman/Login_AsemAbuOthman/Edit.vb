
Public Class frmEdit


    Private Sub stmPersonalInfo_Click(sender As Object, e As EventArgs) Handles mnuEditInfo.Click
        frmOrder.Show()

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuExit.Click

        Dim doYouWantToExit As MsgBoxResult

        doYouWantToExit = MsgBox("Are your sure you want to exit ? ", vbYesNo, "Exit")

        If doYouWantToExit = vbYes Then

            Application.Exit()

        End If

    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        frmLogin.Show()
        Me.Hide()
    End Sub

    Private Sub frmEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        intNoOfPage = 2
        lblWelcome.Text = lblWelcome.Text & stUserName
    End Sub

    Private Sub mnuShowInRichBox_Click(sender As Object, e As EventArgs)
        frmShowInfo.Show()

    End Sub

    Private Sub mnuShowBill_Click(sender As Object, e As EventArgs) Handles mnuShowBill.Click
        frmShowInfo.Show()

    End Sub
End Class