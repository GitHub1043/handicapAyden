Public Class Form1

    Private Sub btnScore_Click(sender As Object, e As EventArgs) Handles btnScore.Click
        Dim intCount As Integer
        Dim intNum As Integer
        Dim sngDiff As Single
        Dim intAverage As Integer
        Const COURSE As Integer = 69
        Const SLOPE As Integer = 94

        For intCount = 1 To 5
            intNum = Val(InputBox("Enter Score" & intCount))
            sngDiff = sngDiff + (intNum - COURSE) * 113 / SLOPE
        Next

        intAverage = (sngDiff) \ 5
        MessageBox.Show(intAverage)

    End Sub
End Class