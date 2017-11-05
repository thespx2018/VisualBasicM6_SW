Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Input1, Input2, Input3, Input4, Input5, Input6, Input7, Input8, Input9, Input10 As Double
        Dim Max, Min As Double
        Input1 = TextBox1.Text
        Input2 = TextBox2.Text
        Input3 = TextBox3.Text
        Input4 = TextBox4.Text
        Input5 = TextBox5.Text
        Input6 = TextBox6.Text
        Input7 = TextBox7.Text
        Input8 = TextBox8.Text
        Input9 = TextBox9.Text
        Input10 = TextBox10.Text
        Max = Input1
        Min = Input10
        If (Input2 > Max) Then
            Max = Input2
        End If
        If (Input3 > Max) Then
            Max = Input3
        End If

        If (Input4 > Max) Then
            Max = Input4
        End If

        If (Input5 > Max) Then
            Max = Input5
        End If

        If (Input6 > Max) Then
            Max = Input6
        End If
        If (Input7 > Max) Then
            Max = Input7
        End If
        If (Input8 > Max) Then
            Max = Input8
        End If
        If (Input9 > Max) Then
            Max = Input9
        End If
        If (Input10 > Max) Then
            Max = Input10
        End If

        If (Input1 < Min) Then
            Min = Input1
        End If
        If (Input2 < Min) Then
            Min = Input2
        End If
        If (Input3 < Min) Then
            Min = Input3
        End If

        If (Input4 < Min) Then
            Min = Input4
        End If

        If (Input5 < Min) Then
            Min = Input5
        End If

        If (Input6 < Min) Then
            Min = Input6
        End If
        If (Input7 < Min) Then
            Min = Input7
        End If
        If (Input8 < Min) Then
            Min = Input8
        End If
        If (Input9 < Min) Then
            Min = Input9
        End If
    

        MsgBox("ค่ามากที่สุดคือ = " & Max & " ค่าน้อยที่สุดคือ = " & Min)
    End Sub
End Class
