Imports System.Data.SqlClient

Public Class frmConnection



    'Dim strName As String = ""
    'Dim intID, intAge, intSalary As Integer

    'Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click

    '    strName = txtName.Text
    '    intID = Val(txtID.Text)
    '    intAge = Val(txtAge.Text)
    '    intSalary = Val(txtSalary.Text)

    '    If strName = "" And intID = 0 And intAge = 0 And intSalary = 0 Then

    '        MessageBox.Show("Data Is empty Plz fill info.", "Error", MessageBoxButtons.OK)

    '    End If

    '    Try
    '        Conn.Open()

    '        Cmd.Connection = Conn

    '        'Cmd.CommandText = "INSERT INTO EMP VALUES('" & strName & "' , " & intID & ", " & intAge & ", " & intSalary & ");"

    '        Cmd.CommandText = "DROP TABLE EMP"

    '        If Conn.State = ConnectionState.Open Then

    '            MsgBox("Connected Sccessfully")

    '        End If


    '        Cmd.ExecuteNonQuery()

    '        Conn.Close()

    '    Catch ex As Exception

    '        MsgBox("Connection faild")

    '    End Try

    'End Sub
End Class
