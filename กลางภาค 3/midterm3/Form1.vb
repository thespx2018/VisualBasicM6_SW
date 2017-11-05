Public Class Form1

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
       
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Num01 As Integer
        Dim sum1 As Single
        
            Num01 = TextBox1.Text

        sum1 = (Num01 - 543)
            MsgBox("เท่ากับปีคศ " & sum1)


    End Sub
End Class
