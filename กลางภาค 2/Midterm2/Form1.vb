Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Name, Lastname, Address, Room, Number, SClass, Phonenum, email As String
        Name = BoxFName.Text
        Lastname = BoxLName.Text
        Address = BoxAddress.Text
        Room = BoxRoom.Text
        SClass = BoxSclass.Text
        Phonenum = BoxPhonenum.Text
        email = Boxemail.Text
        Number = TextBox1.Text
        MsgBox("ชื่อ " & Name & vbNewLine & "นามสกุล " & Lastname & vbNewLine & "ที่อยู่ " & Address & vbNewLine & "ห้อง " & Room & vbNewLine & "ชั้นเรียน " & SClass & vbNewLine & "เลขที่" & Number & vbNewLine & "เบอร์โทร " & Phonenum & vbNewLine & "E-mail " & email & vbNewLine)



        Dim Num1, Num2, Num3, Num4, Num5, sum1, sum2, sum3 As Single
        Dim sum4 As Double
        Dim sum5 As Single
        Num1 = Num01.Text
        Num2 = Num02.Text
        Num3 = Num03.Text
        Num4 = Num04.Text
        Num5 = Num05.Text
        sum1 = Num1 + Num2 + Num3 + Num4 + Num5
        sum2 = Num1 - Num2 - Num3 - Num4 - Num5
        sum3 = Num1 * Num2 * Num3 * Num4 * Num5
        sum4 = Num1 / Num2 / Num3 / Num4 / Num5
        sum5 = (sum1 + sum2 + sum3) / 3
        MsgBox("ผลบวก = " & sum1 & vbNewLine & "ผลลบ = " & sum2 & vbNewLine & "ผลคูณ = " & sum3 & vbNewLine & "ผลหาร =" & sum4 & vbNewLine & "ค่าเฉลี่ย = " & sum5)
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub
End Class
