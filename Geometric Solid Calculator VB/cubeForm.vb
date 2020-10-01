Public Class cubeForm
    Private Sub CalcCubeBtn_Click(sender As Object, e As EventArgs) Handles calcCubeBtn.Click
        Dim height As Integer
        Dim length As Integer
        Dim width As Integer
        Dim area1 As Integer
        Dim area2 As Integer
        Dim surfaceArea As Integer
        Dim volume As Integer
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
            area1 = height * width
            area2 = length * height
            surfaceArea = area1 * 2 + area2 * 4
            volume = length * width * height
            areaSide1Output.Text = area1.ToString()
            areaSide2Output.Text = area2.ToString()
            surfaceAreaOutput.Text = surfaceArea.ToString()
            volumeOutput.Text = volume.ToString()
            file.WriteLine("Cube of length: " + length.ToString() + ", height: " + height.ToString() + ", width: " + width.ToString())
            file.WriteLine("Side 1 Area: " + area1.ToString() + ", Side 2 Area : " + area2.ToString())
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