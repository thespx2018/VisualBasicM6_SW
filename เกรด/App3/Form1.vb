Public Class Form1

    Private Sub BthClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BthClose.Click
        Me.Close()
    End Sub

    Private Sub BtnShow1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnShow1.Click
        Dim Grade As Integer
        Grade = Box1.Text
        If Grade >= 80 And Grade <= 100 Then
            MsgBox("ท่านได้เกรด 4")
        ElseIf Grade >= 101 Then
            MsgBox("กรุณาใส่ 1 - 100")
        ElseIf Grade >= 75 And Grade <= 79 Then
            MsgBox("ท่านได้เกรด 3.5 ")

        ElseIf Grade >= 70 And Grade <= 74 Then
            MsgBox("ท่านได้เกรด 3")
        ElseIf Grade >= 65 And Grade <= 69 Then
            MsgBox("ท่านได้เกรด 2.5")
        ElseIf Grade >= 60 And Grade <= 64 Then
            MsgBox("ท่านได้เกรด 2 ")
        ElseIf Grade >= 56 And Grade <= 59 Then
            MsgBox("ท่านได้เกรด 1.5 ")
        ElseIf Grade >= 50 And Grade <= 55 Then
            MsgBox("ท่านได้เกรด 1 ")
        ElseIf Grade >= 0 And Grade <= 49 Then
            MsgBox("ท่านได้เกรด 0 ")
        ElseIf Grade <= -1 Then
            MsgBox("กรุณาใส่ 1 - 100 ")
        End If
    End Sub
End Class
