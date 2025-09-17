
Public Class frmLogin


    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUserName.Text = stUserName And txtPassword.Text = stPassword Then

            Me.Hide()
            frmEdit.Show()

        Else

            MsgBox("Plz enter a valid username or password")

        End If

        txtUserName.Clear()
        txtPassword.Clear()
        txtUserName.Focus()

    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        intNoOfPage = 1
        txtUserName.Focus()
    End Sub

    Private Sub btnForget_Click(sender As Object, e As EventArgs) Handles btnForget.Click
        Me.Hide()
        frmForget.Show()

    End Sub
End Class
