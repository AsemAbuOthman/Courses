Imports System.Data.SqlClient

Module SqlControl

    Public Conn As New SqlConnection("Initial Catalog=LeonDB;Data Source=LEON;Integrated Security=SSPI;Persist Security Info=False;")
    Public Cmd As New SqlCommand
    Public Query As String
    Public Reader As SqlDataReader
    Public Adapter As SqlDataAdapter
    Public DT As DataTable

End Module
