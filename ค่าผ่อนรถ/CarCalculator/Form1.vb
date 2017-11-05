Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim CarPrice As Double
        Dim Down As Double
        Dim Month As Double
        Dim Sum As Double
        Dim Sum1 As Double
        Dim Sum2 As Double
        Dim Year As Double
        Dim Sum3 As Double
        CarPrice = TextBox1.Text
        Down = TextBox2.Text
        Year = TextBox3.Text
        Sum = CarPrice - Down
        Sum1 = Sum + (Sum * 3.25 / 100)
        Sum2 = Year * 12
        Sum3 = Sum1 / Sum2
        MessageBox.Show("ดอกเบี้ยทั้งหมด=" & Sum1 & vbNewLine & "จำนวนเงินที่ชำระต่องวด=" & Sum3)
    End Sub
End Class
