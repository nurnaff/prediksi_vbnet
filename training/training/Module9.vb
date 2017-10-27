Imports System.Data.Odbc
Imports System.Console
Module Module9
    Public kon As New OdbcConnection
    Public rd As OdbcDataReader
    Public cm As New OdbcCommand
    Public da As New OdbcDataAdapter
    Public ds As New DataSet
    Dim v01, v02, v03, v04, v11, v12, v13, v14, v21, v22, v23, v24, w01, w11, w21, w31, w41 As Double
    Dim x1(61), x2(61), t(61), y As Double
    Dim z_in1, z_in2, z_in3, z_in4, z1, z2, z3, z4, y_in1, y1 As Double
    Sub koneksi()
        kon = New OdbcConnection("Driver={MySQL ODBC 3.51 Driver};database=penelitian;server=localhost;uid=root")
        If kon.State = ConnectionState.Closed Then
            kon.Open()
        End If
    End Sub
    Sub main()
        koneksi()
        For i = 0 To 10
            cm = New OdbcCommand("select titik_x from kanan_atas where no=" & i, kon)
            x1(i) = cm.ExecuteScalar
        Next
        For i = 0 To 10
            cm = New OdbcCommand("select titik_y from kanan_atas where no=" & i, kon)
            x2(i) = cm.ExecuteScalar
        Next
        For i = 0 To 10
            cm = New OdbcCommand("select y from kanan_atas where no=" & i, kon)
            t(i) = cm.ExecuteScalar
        Next
        cm = New OdbcCommand("select * from bobot", kon)
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
        For i = 0 To 10
            z_in1 = v01 + (x1(i) * v11) + (x2(i) * v21)
            z_in2 = v02 + (x1(i) * v12) + (x2(i) * v22)
            z_in3 = v03 + (x1(i) * v13) + (x2(i) * v23)
            z_in4 = v04 + (x1(i) * v14) + (x2(i) * v24)
            z1 = 1.0 / (1.0 + (Math.Exp(-z_in1)))
            z2 = 1.0 / (1.0 + (Math.Exp(-z_in2)))
            z3 = 1.0 / (1.0 + (Math.Exp(-z_in3)))
            z4 = 1.0 / (1.0 + (Math.Exp(-z_in4)))
            y_in1 = w01 + (z1 * w11) + (z2 * w21) + (z3 * w31) + (z4 * w41)
            y1 = 1.0 / (1.0 + (Math.Exp(-y_in1)))
            If (y1 < 0.5) Then
                y = 0
            Else
                y = 1
            End If
            If (y = t(i)) Then
                WriteLine("i=" & i)
                WriteLine("y=" & y)
                WriteLine("Benar")
            Else
                WriteLine("i=" & i)
                WriteLine("y=" & y)
                WriteLine("Salah")
            End If
        Next
        kon.Close()
        ReadKey()
    End Sub
End Module
