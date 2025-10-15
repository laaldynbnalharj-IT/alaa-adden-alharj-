Public Class Form1
    Dim x, y, w, k As String
    Dim i As Integer
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        w = Chr(13) + Chr(10)
        x = "جامعة شبوة" + w
        x = x + "كلية تقنية المعلومات" + w
        x = x + "IT عام" + w
        x = x + "الاستاذ عبدالله سماء" + w
        x = x + "للعام الدراسي 2025م " + w
        y = "حول المشروع"
        MsgBox(x, MsgBoxStyle.Information + MsgBoxStyle.MsgBoxRight, y)
    End Sub
End Class
