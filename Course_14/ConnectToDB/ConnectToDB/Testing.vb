Imports System.Data.SqlClient

Public Class Testing

    Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click

        Try
            SqlControl.Query = "SELECT * FROM CARS"

            SqlControl.Conn.Open()

            SqlControl.Cmd.Connection = SqlControl.Conn
            SqlControl.Cmd.CommandText = SqlControl.Query
            SqlControl.Reader = SqlControl.Cmd.ExecuteReader()


            While SqlControl.Reader.Read()

                Dim results As String = ""

                results = SqlControl.Reader("car_name") &
                    vbTab & SqlControl.Reader("car_model") &
                    vbTab & vbTab & SqlControl.Reader("car_year") &
                    vbTab & SqlControl.Reader("car_price") & Environment.NewLine

                rtbQuery.AppendText(results)

                results = ""

            End While

            SqlControl.Conn.Close()
        Catch ex As Exception

            MessageBox.Show("Connectino has Faild", "Connection Error", MessageBoxButtons.OK)


        End Try

    End Sub
End Class
