Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Book1, Book2, Book3, Book4, Book5 As Double
        Dim Max, Min As Double
        Dim Sum1 As Double
        Book1 = TextBox1.Text
        Book2 = TextBox2.Text
        Book3 = TextBox3.Text
        Book4 = TextBox4.Text
        Book5 = TextBox5.Text
        Max = Book1
        Min = Book5
        If (Book2 > Max) Then
            Max = Book2
        End If
        If (Book3 > Max) Then
            Max = Book3
        End If

        If (Book4 > Max) Then
            Max = Book4
        End If

        If (Book5 > Max) Then
            Max = Book5
        End If
        Sum1 = (Max * 15) / 100
        MsgBox("ราคาหนังสือที่มากที่สุด = " & Max & " ราคาที่ลด " & Sum1)
    End Sub
End Class
