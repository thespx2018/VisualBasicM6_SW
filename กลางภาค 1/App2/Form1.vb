Public Class Form1

    Private Sub Close1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Close1.Click
        Me.Close()

    End Sub

    Private Sub CAL1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CAL1.Click
        Dim Num1, Num2, Num3, Num4, Num5, Num6, Num7, Num8, Num9, Num00, sum2, sum3 As Single
        Dim sum4 As Double
        Dim sum5, sum1 As Double
        Num1 = Num01.Text
        Num2 = Num02.Text
        Num3 = Num03.Text
        Num4 = Num04.Text
        Num5 = Num05.Text
        Num6 = Num06.Text
        Num7 = Num07.Text
        Num8 = Num08.Text
        Num9 = Num09.Text
        Num00 = Num10.Text
        sum1 = Num1 + Num2 + Num3 + Num4 + Num5 + Num6 + Num7 + Num8 + Num9 + Num00
        sum2 = Num1 - Num2 - Num3 - Num4 - Num5 - Num6 - Num7 - Num8 - Num9 - Num00
        sum3 = Num1 * Num2 * Num3 * Num4 * Num5 * Num6 * Num7 * Num8 * Num9 * Num00
        sum4 = Num1 / Num2 / Num3 / Num4 / Num5 / Num6 / Num7 / Num8 / Num9 / Num00
        sum5 = (sum1 + sum2 + sum3) / 3
        MsgBox("ผลบวก = " & sum1 & vbNewLine & "ผลลบ = " & sum2 & vbNewLine & "ผลคูณ = " & sum3 & vbNewLine & "ผลหาร =" & sum4 & vbNewLine & "ค่าเฉลี่ย = " & sum5)
    End Sub
End Class
