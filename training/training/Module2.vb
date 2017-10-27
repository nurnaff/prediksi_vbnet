Imports System.Console
Module Module2
    Dim x1(4), x2(4), t(4) As Integer
    Dim alpha, tse As Double
    Dim v01, v02, v03, v04, v11, v12, v13, v14, v21, v22, v23, v24 As Double
    Dim w01, w11, w21, w31, w41 As Double
    Dim kondisi As Boolean
    Dim epoch As Integer
    Dim z_in1, z_in2, z_in3, z_in4, y_in1 As Double
    Dim z1, z2, z3, z4, y1, salah, dy1, Dw01, Dw11, Dw21, Dw31, Dw41 As Double
    Dim d_in1, d_in2, d_in3, d_in4, dz1, dz2, dz3, dz4 As Double
    Dim Dv01, Dv02, Dv03, Dv04, Dv11, Dv12, Dv13, Dv14, Dv21, Dv22, Dv23, Dv24 As Double
    Sub Main()
        x1(0) = 1
        x1(1) = 1
        x1(2) = 0
        x1(3) = 0
        x2(0) = 1
        x2(1) = 0
        x2(2) = 1
        x2(3) = 0
        t(0) = 0
        t(1) = 1
        t(2) = 1
        t(3) = 0
        alpha = 0.02
        v01 = -0.3378
        v02 = 0.2771
        v03 = 0.2859
        v04 = -0.3329
        v11 = 0.197
        v12 = 0.3191
        v13 = -0.1448
        v14 = 0.3594
        v21 = 0.3099
        v22 = 0.1904
        v23 = -0.0347
        v24 = -0.4861
        w01 = -0.1401
        w11 = 0.4919
        w21 = -0.2913
        w31 = -0.3979
        w41 = 0.3581
        tse = 0
        kondisi = False
        epoch = 0
        Do While Not (kondisi = True)
            For i = 0 To 3
                tse = 0
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
                salah = t(i) - y1
                tse += (salah ^ 2)
                dy1 = salah * (1.0 / (1.0 + (Math.Exp(-y_in1))))
                Dw11 = alpha * dy1 * z1
                Dw21 = alpha * dy1 * z2
                Dw31 = alpha * dy1 * z3
                Dw41 = alpha * dy1 * z4
                Dw01 = alpha * dy1

                d_in1 = dy1 * w11
                d_in2 = dy1 * w21
                d_in3 = dy1 * w31
                d_in4 = dy1 * w41

                dz1 = d_in1 * (z1) * (1.0 - z1)
                dz2 = d_in2 * (z2) * (1.0 - z2)
                dz3 = d_in3 * (z3) * (1.0 - z3)
                dz4 = d_in4 * (z4) * (1.0 - z4)

                Dv11 = alpha * dz1 * x1(i)
                Dv21 = alpha * dz1 * x2(i)
                Dv12 = alpha * dz2 * x1(i)
                Dv22 = alpha * dz2 * x2(i)
                Dv13 = alpha * dz3 * x1(i)
                Dv23 = alpha * dz3 * x2(i)
                Dv14 = alpha * dz4 * x1(i)
                Dv24 = alpha * dz4 * x2(i)

                Dv01 = alpha * dz1
                Dv02 = alpha * dz2
                Dv03 = alpha * dz3
                Dv04 = alpha * dz4

                w01 += Dw01
                w11 += Dw11
                w21 += Dw21
                w31 += Dw31
                w41 += Dw41

                v01 += Dv01
                v11 += Dv11
                v21 += Dv21

                v02 += Dv02
                v12 += Dv12
                v22 += Dv22

                v03 += Dv03
                v13 += Dv13
                v23 += Dv23

                v04 += Dv04
                v14 += Dv14
                v24 += Dv24


                WriteLine("i=" & epoch)
                WriteLine("input1=" & x1(i))
                WriteLine("input2=" & x2(i))
                WriteLine("output=" & y1)
                WriteLine("tse=" & tse)
                If ((tse < 0.05) And (i Mod 4 = 0)) Then
                    kondisi = True
                End If
            Next
            epoch += 1
        Loop
        ReadKey()
    End Sub
End Module
