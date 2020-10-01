Public Class pyramidForm
    Private Sub CalcCubeBtn_Click(sender As Object, e As EventArgs) Handles calcCubeBtn.Click
        Dim height As Integer
        Dim length As Integer
        Dim width As Integer
        Dim area1 As Integer
        Dim area2 As Integer
        Dim bottomArea As Integer
        Dim surfaceArea As Double
        Dim volume As Double
        Dim check1 As Boolean
        Dim check2 As Boolean
        Dim check3 As Boolean
        Dim file As System.IO.StreamWriter

        check1 = Integer.TryParse(heightInput.Text, height)
        check2 = Integer.TryParse(lengthInput.Text, length)
        check3 = Integer.TryParse(widthInput.Text, width)

        If check1 = False Or check2 = False Or check3 = False Or height < 1 Or width < 1 Or length < 1 Then
            MessageBox.Show("Please Input Integer Values Above 1 and Try Again")
        Else
            file = My.Computer.FileSystem.OpenTextFileWriter("history.txt", True)
            area1 = length * height
            area2 = width * height
            bottomArea = length * width
            surfaceArea = area1 * 2 + area2 * 2 + bottomArea
            volume = length * width * height / 3
            bottomAreaOutput.Text = bottomArea.ToString("N")
            sideArea1Output.Text = area1.ToString()
            sideArea2Output.Text = area2.ToString()
            surfaceAreaOutput.Text = surfaceArea.ToString("N")
            volumeOutput.Text = volume.ToString("N")
            file.WriteLine("Pyramid of length: " + length.ToString() + ", width: " + width.ToString() + ", height:" + height.ToString())
            file.WriteLine("Bottom Area: " + bottomArea.ToString() + ", Side Area 1: " + area1.ToString + ", Side Area 2: " + area2.ToString())
            file.WriteLine("Surface Area: " + surfaceArea.ToString() + ", Volume: " + volume.ToString())
            file.WriteLine("________________________________________________________________________________________________________________")
            file.Close()

        End If

    End Sub

    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click
        MessageBox.Show("On the first form: Select the Solid You Would LIke to Calculate For. Once You choose Your Shape, Input Appropriate Sizes of Your Shape And You Will See Your Calculations On the Right Side of the Window.")
    End Sub

    Private Sub PrintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintToolStripMenuItem.Click
        PrintDocument1.Print()
    End Sub

    Private Sub HistoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HistoryToolStripMenuItem.Click
        System.Diagnostics.Process.Start("history.txt")

    End Sub
End Class