Public Class frmNotepad

    Dim subText As String
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles tsmExit.Click

        Application.Exit()

    End Sub

    Private Sub tsmCopy_Click(sender As Object, e As EventArgs) Handles tsmCopy.Click

        rtbEditor.Copy()

        MsgBox(rtbEditor.SelectedText)

        Clipboard.SetText(rtbEditor.SelectedText)

        'subText = rtbEditor.Text.Substring(rtbEditor.SelectionStart, rtbEditor.SelectionLength)

        'Clipboard.SetText(subText)

    End Sub

    Private Sub tsmCut_Click(sender As Object, e As EventArgs) Handles tsmCut.Click

        'rtbEditor.Cut()

    End Sub

    Private Sub tsmPaste_Click(sender As Object, e As EventArgs) Handles tsmPaste.Click

        rtbEditor.Paste()

        'rtbEditor.Text = rtbEditor.Text.Insert(rtbEditor.SelectedText, subText)

        'rtbEditor.SelectionStart = rtbEditor.SelectedText + subText.Length


    End Sub

    Private Sub rtbEditor_MouseDown(sender As Object, e As MouseEventArgs) Handles rtbEditor.MouseDown

        If e.Button = MouseButtons.Right Then

            cmsCopyCutPasteReplace.Show(rtbEditor, e.Location)

        End If

    End Sub

    Private Sub tsmReplace_Click(sender As Object, e As EventArgs) Handles tsmReplace.Click

        Dim stTextToReplace As String
        Dim stNewText As String

        stTextToReplace = InputBox("Enter text to replace ")
        stNewText = InputBox("Enter new text ")


        rtbEditor.Text = rtbEditor.Text.Replace(stTextToReplace, stNewText)

    End Sub

    Private Sub ToolStripMenuItem7_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem7.Click

        Environment.Exit(0)

    End Sub

    Private Sub tsmSaveAs_Click(sender As Object, e As EventArgs) Handles tsmSaveAs.Click

        Dim sfd As SaveFileDialog = New SaveFileDialog

        sfd.Filter = "TXT Files (*.txt*)|*.txt"

        If sfd.ShowDialog = Windows.Forms.DialogResult.OK Then

            My.Computer.FileSystem.WriteAllText(sfd.FileName, rtbEditor.Text, True)

        End If

        Dim ofd As New OpenFileDialog

        ofd.Filter = "(*.jpg) | (*.png)"


    End Sub

    Private Sub cmsCopy_Click(sender As Object, e As EventArgs) Handles cmsCopy.Click

        tsmCopy_Click(sender, e)

    End Sub

    Private Sub cmsCut_Click(sender As Object, e As EventArgs) Handles cmsCut.Click

        tsmCut_Click(sender, e)

    End Sub

    Private Sub cmsPaste_Click(sender As Object, e As EventArgs) Handles cmsPaste.Click

        tsmPaste_Click(sender, e)

    End Sub

    Private Sub cmsReplace_Click(sender As Object, e As EventArgs) Handles cmsReplace.Click

        tsmReplace_Click(sender, e)

    End Sub

    Private Sub rtbEditor_TextChanged(sender As Object, e As EventArgs) Handles rtbEditor.TextChanged
        rtbEditor.AcceptsTab = True
    End Sub
End Class
