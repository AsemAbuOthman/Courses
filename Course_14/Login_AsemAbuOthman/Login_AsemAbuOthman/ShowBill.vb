Public Class frmShowInfo
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        frmEdit.Show()
        Me.Hide()
    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        Dim doYouWantToExit As MsgBoxResult

        doYouWantToExit = MsgBox("Are your sure you want to exit ? ", vbYesNo, "Exit")

        If doYouWantToExit = vbYes Then

            Application.Exit()

        End If
    End Sub

End Class