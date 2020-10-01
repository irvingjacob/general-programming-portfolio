<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class coneForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.calcCubeBtn = New System.Windows.Forms.Button()
        Me.radiusInput = New System.Windows.Forms.TextBox()
        Me.heightInput = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dumlabel = New System.Windows.Forms.Label()
        Me.headerLabel = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HistoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.sphereCalculations = New System.Windows.Forms.Panel()
        Me.topAreaOutput = New System.Windows.Forms.Label()
        Me.bottomAreaOutput = New System.Windows.Forms.Label()
        Me.surfaceAreaOutput = New System.Windows.Forms.Label()
        Me.volumeOutput = New System.Windows.Forms.Label()
        Me.diameterOutput = New System.Windows.Forms.Label()
        Me.radiusOutput = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.MenuStrip1.SuspendLayout()
        Me.sphereCalculations.SuspendLayout()
        Me.SuspendLayout()
        '
        'calcCubeBtn
        '
        Me.calcCubeBtn.Location = New System.Drawing.Point(73, 124)
        Me.calcCubeBtn.Name = "calcCubeBtn"
        Me.calcCubeBtn.Size = New System.Drawing.Size(75, 23)
        Me.calcCubeBtn.TabIndex = 18
        Me.calcCubeBtn.Text = "Calculate"
        Me.calcCubeBtn.UseVisualStyleBackColor = True
        '
        'radiusInput
        '
        Me.radiusInput.Location = New System.Drawing.Point(62, 74)
        Me.radiusInput.Name = "radiusInput"
        Me.radiusInput.Size = New System.Drawing.Size(100, 20)
        Me.radiusInput.TabIndex = 17
        '
        'heightInput
        '
        Me.heightInput.Location = New System.Drawing.Point(62, 98)
        Me.heightInput.Name = "heightInput"
        Me.heightInput.Size = New System.Drawing.Size(100, 20)
        Me.heightInput.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Height:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Radius:"
        '
        'dumlabel
        '
        Me.dumlabel.AutoSize = True
        Me.dumlabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dumlabel.Location = New System.Drawing.Point(13, 54)
        Me.dumlabel.Name = "dumlabel"
        Me.dumlabel.Size = New System.Drawing.Size(274, 17)
        Me.dumlabel.TabIndex = 11
        Me.dumlabel.Text = "Please Input The Dimensions Of the Solid:"
        '
        'headerLabel
        '
        Me.headerLabel.AutoSize = True
        Me.headerLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.headerLabel.Location = New System.Drawing.Point(12, 30)
        Me.headerLabel.Name = "headerLabel"
        Me.headerLabel.Size = New System.Drawing.Size(240, 24)
        Me.headerLabel.TabIndex = 10
        Me.headerLabel.Text = "Cone Dimension Generator"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 19
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrintToolStripMenuItem, Me.HistoryToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.PrintToolStripMenuItem.Text = "Print"
        '
        'HistoryToolStripMenuItem
        '
        Me.HistoryToolStripMenuItem.Name = "HistoryToolStripMenuItem"
        Me.HistoryToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.HistoryToolStripMenuItem.Text = "History"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'sphereCalculations
        '
        Me.sphereCalculations.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.sphereCalculations.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.sphereCalculations.Controls.Add(Me.topAreaOutput)
        Me.sphereCalculations.Controls.Add(Me.bottomAreaOutput)
        Me.sphereCalculations.Controls.Add(Me.surfaceAreaOutput)
        Me.sphereCalculations.Controls.Add(Me.volumeOutput)
        Me.sphereCalculations.Controls.Add(Me.diameterOutput)
        Me.sphereCalculations.Controls.Add(Me.radiusOutput)
        Me.sphereCalculations.Controls.Add(Me.Label9)
        Me.sphereCalculations.Controls.Add(Me.Label8)
        Me.sphereCalculations.Controls.Add(Me.Label6)
        Me.sphereCalculations.Controls.Add(Me.Label5)
        Me.sphereCalculations.Controls.Add(Me.Label4)
        Me.sphereCalculations.Controls.Add(Me.Label2)
        Me.sphereCalculations.Controls.Add(Me.Label7)
        Me.sphereCalculations.Location = New System.Drawing.Point(333, 30)
        Me.sphereCalculations.Name = "sphereCalculations"
        Me.sphereCalculations.Size = New System.Drawing.Size(200, 204)
        Me.sphereCalculations.TabIndex = 29
        '
        'topAreaOutput
        '
        Me.topAreaOutput.AutoSize = True
        Me.topAreaOutput.Location = New System.Drawing.Point(81, 166)
        Me.topAreaOutput.Name = "topAreaOutput"
        Me.topAreaOutput.Size = New System.Drawing.Size(0, 13)
        Me.topAreaOutput.TabIndex = 13
        '
        'bottomAreaOutput
        '
        Me.bottomAreaOutput.AutoSize = True
        Me.bottomAreaOutput.Location = New System.Drawing.Point(95, 142)
        Me.bottomAreaOutput.Name = "bottomAreaOutput"
        Me.bottomAreaOutput.Size = New System.Drawing.Size(0, 13)
        Me.bottomAreaOutput.TabIndex = 12
        '
        'surfaceAreaOutput
        '
        Me.surfaceAreaOutput.AutoSize = True
        Me.surfaceAreaOutput.Location = New System.Drawing.Point(99, 118)
        Me.surfaceAreaOutput.Name = "surfaceAreaOutput"
        Me.surfaceAreaOutput.Size = New System.Drawing.Size(0, 13)
        Me.surfaceAreaOutput.TabIndex = 11
        '
        'volumeOutput
        '
        Me.volumeOutput.AutoSize = True
        Me.volumeOutput.Location = New System.Drawing.Point(74, 97)
        Me.volumeOutput.Name = "volumeOutput"
        Me.volumeOutput.Size = New System.Drawing.Size(0, 13)
        Me.volumeOutput.TabIndex = 10
        '
        'diameterOutput
        '
        Me.diameterOutput.AutoSize = True
        Me.diameterOutput.Location = New System.Drawing.Point(81, 69)
        Me.diameterOutput.Name = "diameterOutput"
        Me.diameterOutput.Size = New System.Drawing.Size(0, 13)
        Me.diameterOutput.TabIndex = 9
        '
        'radiusOutput
        '
        Me.radiusOutput.AutoSize = True
        Me.radiusOutput.Location = New System.Drawing.Point(72, 45)
        Me.radiusOutput.Name = "radiusOutput"
        Me.radiusOutput.Size = New System.Drawing.Size(0, 13)
        Me.radiusOutput.TabIndex = 8
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(23, 166)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(54, 13)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Top Area:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(21, 142)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 13)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Bottom Area:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(21, 118)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Surface Area:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(23, 94)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Volume:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 68)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Diameter:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Radius:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(20, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(144, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Cone Dimension Calculations"
        '
        'coneForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.sphereCalculations)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.calcCubeBtn)
        Me.Controls.Add(Me.radiusInput)
        Me.Controls.Add(Me.heightInput)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dumlabel)
        Me.Controls.Add(Me.headerLabel)
        Me.Name = "coneForm"
        Me.Text = "Cone Form"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.sphereCalculations.ResumeLayout(False)
        Me.sphereCalculations.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents calcCubeBtn As Button
    Friend WithEvents radiusInput As TextBox
    Friend WithEvents heightInput As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dumlabel As Label
    Friend WithEvents headerLabel As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrintToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HistoryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents sphereCalculations As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents topAreaOutput As Label
    Friend WithEvents bottomAreaOutput As Label
    Friend WithEvents surfaceAreaOutput As Label
    Friend WithEvents volumeOutput As Label
    Friend WithEvents diameterOutput As Label
    Friend WithEvents radiusOutput As Label
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
End Class
