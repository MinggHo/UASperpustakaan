Imports System.Data.Sql
Imports System.Data.SqlClient
Module Connection
    Public CONN As SqlConnection
    Public CMD As SqlCommand
    Public DA As SqlDataAdapter
    Public DS As DataSet
    Public DR As SqlDataReader
    Public PR As Integer
    Public STR As String
    Public DT As New DataTable

    Sub koneksi()
        STR = "Data Source = MUKMIN\SQLEXPRESS; Initial Catalog = perpustakaan; Integrated Security=True"
        CONN = New SqlConnection(STR)
        If CONN.State = ConnectionState.Closed Then
            CONN.Open()
        End If
    End Sub

End Module

