Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim price As Single
        Dim discount As Single
        Dim Caldis As Single
        Dim percent As Integer
        price = TextBox1.Text
        If price >= 500 And price <= 1000.99 Then
            discount = price - (price * 5 / 100)
            Caldis = (price * 5 / 100)
            percent = 5
            MsgBox("สรุปราคาที่จ่าย " & discount & vbNewLine & "ราคาที่ลด " & Caldis & vbNewLine & "ได้ส่วนลด " & percent)
        ElseIf price >= 1000.1 And price <= 5000.9 Then
            discount = price - (price * 10 / 100)
            Caldis = (price * 10 / 100)
            percent = 10
            MsgBox("สรุปราคาที่จ่าย " & discount & vbNewLine & "ราคาที่ลด " & Caldis & vbNewLine & "ได้ส่วนลด " & percent)
        ElseIf price >= 5001 Then
            discount = price - (price * 20 / 100)
            Caldis = (price * 20 / 100)
            percent = 20
            MsgBox("สรุปราคาที่จ่าย " & discount & vbNewLine & "ราคาที่ลด " & Caldis & vbNewLine & "ได้ส่วนลด " & percent)
        ElseIf price >= 0.1 And price <= 499.9 Then

            discount = price
            percent = 0
            MsgBox("ไม่มีส่วนลด ")
            MsgBox("สรุปราคาที่จ่าย " & discount & vbNewLine & "ราคาที่ลด " & Caldis & vbNewLine & "ได้ส่วนลด " & percent)
        ElseIf price <= 0 Then
            MsgBox("กรุณากรอกราคาที่ถูกต้อง")
        End If



    End Sub
End Class
