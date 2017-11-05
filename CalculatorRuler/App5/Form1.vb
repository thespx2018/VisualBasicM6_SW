Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Num1, sum99 As Double
        Dim sum1 As Double
        Dim Num2 As Integer
        Dim sum88, sum2 As Double
        sum99 = 12
        Num1 = TextBox1.Text
        sum1 = sum99 * Num1
        sum88 = 2.54
        sum2 = sum1 * 2.54
        MsgBox("ฟุตเป็นนิ้ว = " & sum1 & "  นิ้วเป็นเซน = " & sum2)
    End Sub
End Class
