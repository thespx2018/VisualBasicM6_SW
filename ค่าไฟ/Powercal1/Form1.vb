Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim No As Double
        Dim Vat As Double
        Dim CalNo As Double
        Dim Sum As Double
        No = TextBox1.Text
        If No <= 0 Then
            MsgBox("กรุณากรอกหน่วยที่ถูกต้อง")

        ElseIf No >= 1 And No <= 10.99 Then

            CalNo = (No * 5)
            Vat = (CalNo * 7) / 100
            Sum = Vat + CalNo
            MsgBox("ค่าไฟ" & Sum)
        ElseIf No >= 11 And No <= 49.99 Then
            CalNo = (No * 10)
            Vat = (CalNo * 7) / 100
            Sum = Vat + CalNo
            MsgBox("ค่าไฟ " & CalNo & vbNewLine & "เงินที่ต้องจ่าย " & Sum)
        ElseIf No >= 50 And No <= 70.99 Then
            CalNo = (No * 15)
            Vat = (CalNo * 7) / 100
            Sum = Vat + CalNo
            MsgBox("ค่าไฟ" & Sum)
        ElseIf No >= 71 Then
            CalNo = (No * 20)
            Vat = (CalNo * 7) / 100
            Sum = Vat + CalNo
            MsgBox("ค่าไฟ" & Sum)

        End If
    End Sub
End Class
