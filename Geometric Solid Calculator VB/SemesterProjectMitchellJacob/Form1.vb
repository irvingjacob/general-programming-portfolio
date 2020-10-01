Public Class Form1
    Private Sub SelectBtn_Click(sender As Object, e As EventArgs) Handles selectBtn.Click
        If cubeSelection.Checked Then
            cubeForm.ShowDialog()
        ElseIf sphereSelection.Checked Then
            sphereForm.ShowDialog()
        ElseIf coneSelection.Checked Then
            coneForm.ShowDialog()
        ElseIf pyramidSelection.Checked Then
            pyramidForm.ShowDialog()
        ElseIf cylinderSelection.Checked Then
            cylinderForm.ShowDialog()
        End If
    End Sub

    Private Sub PrintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintToolStripMenuItem.Click
        PrintDocument1.Print()
    End Sub

    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click
        MessageBox.Show("On the first form: Select the Solid You Would LIke to Calculate For. Once You choose Your Shape, Input Appropriate Sizes of Your Shape And You Will See Your Calculations On the Right Side of the Window.")
    End Sub

    Private Sub HistoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HistoryToolStripMenuItem.Click
        System.Diagnostics.Process.Start("history.txt")

    End Sub
End Class
