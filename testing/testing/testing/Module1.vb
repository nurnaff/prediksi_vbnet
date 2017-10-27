Imports System.Data.Odbc
Module Module1
    Public kon As New OdbcConnection
    Public rd As OdbcDataReader
    Public cm As New OdbcCommand
    Public da As New OdbcDataAdapter
    Public ds As New DataSet
    Sub koneksi()
        kon = New OdbcConnection("Driver={MySQL ODBC 3.51 Driver};database=dbjaringan;server=localhost;uid=root")
        If kon.State = ConnectionState.Closed Then
            kon.Open()
        End If
    End Sub
End Module
