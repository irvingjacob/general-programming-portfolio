Public Class coneForm
    Private Sub CalcCubeBtn_Click(sender As Object, e As EventArgs) Handles calcCubeBtn.Click
        Dim height As Integer
        Dim radius As Integer
        Dim diameter As Integer
        Dim bottomArea As Double
        Dim topArea As Double
        Dim surfaceArea As Double
        Dim volume As Double
        Dim check1 As Boolean
        Dim check2 As Boolean
        Dim file As System.IO.StreamWriter

        check1 = Integer.TryParse(heightInput.Text, height)
        check2 = Integer.TryParse(radiusInput.Text, radius)

        If check1 = False Or check2 = False Or height < 1 Or radius < 1 Then
            MessageBox.Show("Please Input Integer Values Above 1 and Try Again")
        Else
            file = My.Computer.FileSystem.OpenTextFileWriter("history.txt", True)
            bottomArea = Math.PI * radius * radius
            surfaceArea = Math.PI * radius * (radius + Math.Sqrt((height * height) + (radius * radius)))
            volume = Math.PI * radius * radius * height / 3
            topArea = surfaceArea - bottomArea
            diameter = radius * 2
            radiusOutput.Text = radius.ToString()
            diameterOutput.Text = diameter.ToString()
            surfaceAreaOutput.Text = surfaceArea.ToString("N")
            bottomAreaOutput.Text = bottomArea.ToString("N")
            topAreaOutput.Text = topArea.ToString("N")
            volumeOutput.Text = volume.ToString("N")
            file.WriteLine("Cone of radius: " + radius.ToString() + ", height: " + height.ToString())
            file.WriteLine("Bottom Area: " + bottomArea.ToString() + ", Top Area : " + topArea.ToString())
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