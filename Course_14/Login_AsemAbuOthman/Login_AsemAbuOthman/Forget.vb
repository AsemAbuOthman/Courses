Public Class frmForget

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        If Not txtNewPassword.Text = "" And Not txtNewPassword.Text = "" Then

            Profile.stUserName = txtNewUsername.Text
            Profile.stPassword = txtNewPassword.Text

            MsgBox("Your Information has saved Successfully")


        Else
            MsgBox("Plz enter your new username and password")

        End If

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        Dim doYouWantToExit As MsgBoxResult

        doYouWantToExit = MsgBox("Are your sure you want to exit ? ", vbYesNo, "Exit")

        If doYouWantToExit = vbYes Then

            Application.Exit()

        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        frmLogin.Show()
        Me.Close()
    End Sub

    Private Sub frmForget_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        intNoOfPage = 5

    End Sub
End Class