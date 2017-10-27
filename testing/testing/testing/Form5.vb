Imports System.Data.Odbc
Public Class Form5
    Public kon As New OdbcConnection
    Public rd As OdbcDataReader
    Public cm As New OdbcCommand
    Public da As New OdbcDataAdapter
    Public ds As New DataSet
    Dim v01, v02, v03, v04, v11, v12, v13, v14, v21, v22, v23, v24, w01, w11, w21, w31, w41 As Double
    Dim x1, x2, in1, in2, yin, y, hasilprediksi As Double
    Dim z_in1, z_in2, z_in3, z_in4, z1, z2, z3, z4 As Double
    Sub koneksi()
        kon = New OdbcConnection("Driver={MySQL ODBC 3.51 Driver};database=dbjaringan;server=localhost;uid=root")
        If kon.State = ConnectionState.Closed Then
            kon.Open()
        End If
    End Sub
    Private Sub Form5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        koneksi()
        da = New OdbcDataAdapter("select * from haspre", kon)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "haspre")
        DataGridView1.DataSource = (ds.Tables("haspre"))
        kon.Close()
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Hide()
        Form1.Show()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        buka()
    End Sub
    Sub kosong()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
    End Sub
    Sub buka()
        TextBox1.Enabled = True
        TextBox2.Enabled = True
    End Sub
    Sub tutup()
        TextBox1.Enabled = False
        TextBox2.Enabled = False
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        koneksi()
        cm = New OdbcCommand("select * from hastrain", kon)
        rd = cm.ExecuteReader
        While rd.Read
            v01 = rd.GetValue(0)
            v02 = rd.GetValue(1)
            v03 = rd.GetValue(2)
            v04 = rd.GetValue(3)
            v11 = rd.GetValue(4)
            v12 = rd.GetValue(5)
            v13 = rd.GetValue(6)
            v14 = rd.GetValue(7)
            v21 = rd.GetValue(8)
            v22 = rd.GetValue(9)
            v23 = rd.GetValue(10)
            v24 = rd.GetValue(11)
            w01 = rd.GetValue(12)
            w11 = rd.GetValue(13)
            w21 = rd.GetValue(14)
            w31 = rd.GetValue(15)
            w41 = rd.GetValue(16)
        End While
        rd.Close()
        kon.Close()
        x1 = Val(TextBox1.Text)
        x2 = Val(TextBox2.Text)
        in1 = ((x1 - 458000) * (1 - 0) / (554000 - 458000)) + 0
        TextBox4.Text = FormatNumber(in1, 5)
        in2 = ((x2 - 484000) * (1 - 0) / (494000 - 484000)) + 0
        TextBox5.Text = FormatNumber(in2, 5)
        z_in1 = v01 + (in1 * v11) + (in2 * v21)
        z_in2 = v02 + (in1 * v12) + (in2 * v22)
        z_in3 = v03 + (in1 * v13) + (in2 * v23)
        z_in4 = v04 + (in1 * v14) + (in2 * v24)
        z1 = 1.0 / (1.0 + (Math.Exp(-z_in1)))
        z2 = 1.0 / (1.0 + (Math.Exp(-z_in2)))
        z3 = 1.0 / (1.0 + (Math.Exp(-z_in3)))
        z4 = 1.0 / (1.0 + (Math.Exp(-z_in4)))
        yin = w01 + (z1 * w11) + (z2 * w21) + (z3 * w31) + (z4 * w41)
        y = 1.0 / (1.0 + (Math.Exp(-yin)))
        TextBox6.Text = FormatNumber(y, 5)
        hasilprediksi = ((y - 0) * (543400 - 532400) / (1 - 0)) + 532400
        TextBox3.Text = FormatNumber(hasilprediksi, 0)
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        koneksi()
        cm = New OdbcCommand("insert into haspre(x1,x2,y) values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "')", kon)
        If cm.ExecuteNonQuery <= 0 Then
            MsgBox("Insert Gagal")
        End If
        kon.Close()
        Form5_Load(sender, e)
        kosong()
        tutup()
    End Sub
End Class