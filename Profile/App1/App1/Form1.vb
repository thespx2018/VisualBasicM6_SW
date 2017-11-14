Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Name, Lastname, Address, School, SClass, Phonenum, email As String
        Name = Textbox1.Text
        Lastname = Textbox2.Text
        Address = Textbox3.Text
        School = Textbox4.Text
        SClass = Textbox5.Text
        Phonenum = Textbox6.Text
        email = Textbox7.Text
        MsgBox("ชื่อ " & Name & vbNewLine & "นามสกุล " & Lastname & vbNewLine & "ที่อยู่ " & Address & vbNewLine & "โรงเรียน " & School & vbNewLine & "ชั้นเรียน " & SClass & vbNewLine & "เบอร์โทร " & Phonenum & vbNewLine & "E-mail " & email & vbNewLine)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
