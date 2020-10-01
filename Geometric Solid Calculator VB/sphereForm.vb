Public Class sphereForm
    Private Sub CalcCubeBtn_Click(sender As Object, e As EventArgs) Handles calcCubeBtn.Click
        Dim radius As Integer
        Dim diameter As Integer
        Dim surfaceArea As Double
        Dim volume As Double
        Dim check1 As Boolean
        Dim file As System.IO.StreamWriter

        check1 = Integer.TryParse(radiusInput.Text, radius)

        If check1 = False Or radius < 1 Then
            MessageBox.Show("Please Input Integer Values Above 1 and Try Again")
        Else
            file = My.Computer.FileSystem.OpenTextFileWriter("history.txt", True)
            diameter = radius * 2
            surfaceArea = 4 * Math.PI * radius * radius
            volume = 4 / 3 * Math.PI * radius * radius * radius
            radiusOutput.Text = radius.ToString()
            diameterOutput.Text = diameter.ToString()
            surfaceAreaOutput.Text = surfaceArea.ToString("N")
            volumeOutput.Text = volume.ToString("N")
            file.WriteLine("Sphere of radius: " + radius.ToString() + ", diameter: " + diameter.ToString())
            file.WriteLine("Surface Area: " + surfaceArea.ToString() + ", Volume: " + volume.ToString())
            file.WriteLine("________________________________________________________________________________________________________________")
            file.Close()
        End If
    End Sub

    Private Sub SphereCalculations_Paint(sender As Object, e As PaintEventArgs) Handles sphereCalculations.Paint

    End Sub

    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem4.Click
        MessageBox.Show("On the first form: Select the Solid You Would LIke to Calculate For. Once You choose Your Shape, Input Appropriate Sizes of Your Shape And You Will See Your Calculations On the Right Side of the Window.")
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        PrintDocument1.Print()
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        System.Diagnostics.Process.Start("history.txt")

    End Sub
End Class