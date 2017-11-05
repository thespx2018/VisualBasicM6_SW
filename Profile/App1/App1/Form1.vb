Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Name, Lastname, Address, School, SClass, Phonenum, email As String
        Name = BoxFName.Text
        Lastname = BoxLName.Text
        Address = BoxAddress.Text
        School = BoxSchool.Text
        SClass = BoxSclass.Text
        Phonenum = BoxPhonenum.Text
        email = Boxemail.Text
        MsgBox("ชื่อ " & Name & vbNewLine & "นามสกุล " & Lastname & vbNewLine & "ที่อยู่ " & Address & vbNewLine & "โรงเรียน " & School & vbNewLine & "ชั้นเรียน " & SClass & vbNewLine & "เบอร์โทร " & Phonenum & vbNewLine & "E-mail " & email & vbNewLine)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
