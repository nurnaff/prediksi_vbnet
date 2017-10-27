Imports System.Data.Odbc
Public Class Form2
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
    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        koneksi()
        da = New OdbcDataAdapter("select * from hastrain", kon)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "hastrain")
        DataGridView1.DataSource = (ds.Tables("hastrain"))
        kon.Close()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        Form1.Show()
    End Sub
End Class