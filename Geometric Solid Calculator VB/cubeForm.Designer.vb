<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cubeForm
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
        Me.headerLabel = New System.Windows.Forms.Label()
        Me.dumlabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.widthInput = New System.Windows.Forms.TextBox()
        Me.heightInput = New System.Windows.Forms.TextBox()
        Me.lengthInput = New System.Windows.Forms.TextBox()
        Me.calcCubeBtn = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HistoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.sphereCalculations = New System.Windows.Forms.Panel()
        Me.volumeOutput = New System.Windows.Forms.Label()
        Me.surfaceAreaOutput = New System.Windows.Forms.Label()
        Me.areaSide2Output = New System.Windows.Forms.Label()
        Me.areaSide1Output = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.MenuStrip1.SuspendLayout()
        Me.sphereCalculations.SuspendLayout()
        Me.SuspendLayout()
        '
        'headerLabel
        '
        Me.headerLabel.AutoSize = True
        Me.headerLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.headerLabel.Location = New System.Drawing.Point(12, 33)
        Me.headerLabel.Name = "headerLabel"
        Me.headerLabel.Size = New System.Drawing.Size(240, 24)
        Me.headerLabel.TabIndex = 1
        Me.headerLabel.Text = "Cube Dimension Generator"
        '
        'dumlabel
        '
        Me.dumlabel.AutoSize = True
        Me.dumlabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dumlabel.Location = New System.Drawing.Point(13, 57)
        Me.dumlabel.Name = "dumlabel"
        Me.dumlabel.Size = New System.Drawing.Size(274, 17)
        Me.dumlabel.TabIndex = 2
        Me.dumlabel.Text = "Please Input The Dimensions Of the Solid:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Length:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Width:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 147)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Height:"
        '
        'widthInput
        '
        Me.widthInput.Location = New System.Drawing.Point(62, 109)
        Me.widthInput.Name = "widthInput"
        Me.widthInput.Size = New System.Drawing.Size(100, 20)
        Me.widthInput.TabIndex = 6
        '
        'heightInput
        '
        Me.heightInput.Location = New System.Drawing.Point(60, 144)
        Me.heightInput.Name = "heightInput"
        Me.heightInput.Size = New System.Drawing.Size(100, 20)
        Me.heightInput.TabIndex = 7
        '
        'lengthInput
        '
        Me.lengthInput.Location = New System.Drawing.Point(62, 77)
        Me.lengthInput.Name = "lengthInput"
        Me.lengthInput.Size = New System.Drawing.Size(100, 20)
        Me.lengthInput.TabIndex = 8
        '
        'calcCubeBtn
        '
        Me.calcCubeBtn.Location = New System.Drawing.Point(62, 192)
        Me.calcCubeBtn.Name = "calcCubeBtn"
        Me.calcCubeBtn.Size = New System.Drawing.Size(75, 23)
        Me.calcCubeBtn.TabIndex = 9
        Me.calcCubeBtn.Text = "Calculate"
        Me.calcCubeBtn.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(543, 24)
        Me.MenuStrip1.TabIndex = 10
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
        Me.sphereCalculations.Controls.Add(Me.volumeOutput)
        Me.sphereCalculations.Controls.Add(Me.surfaceAreaOutput)
        Me.sphereCalculations.Controls.Add(Me.areaSide2Output)
        Me.sphereCalculations.Controls.Add(Me.areaSide1Output)
        Me.sphereCalculations.Controls.Add(Me.Label9)
        Me.sphereCalculations.Controls.Add(Me.Label5)
        Me.sphereCalculations.Controls.Add(Me.Label4)
        Me.sphereCalculations.Controls.Add(Me.Label7)
        Me.sphereCalculations.Controls.Add(Me.Label8)
        Me.sphereCalculations.Location = New System.Drawing.Point(308, 33)
        Me.sphereCalculations.Name = "sphereCalculations"
        Me.sphereCalculations.Size = New System.Drawing.Size(200, 177)
        Me.sphereCalculations.TabIndex = 30
        '
        'volumeOutput
        '
        Me.volumeOutput.AutoSize = True
        Me.volumeOutput.Location = New System.Drawing.Point(71, 115)
        Me.volumeOutput.Name = "volumeOutput"
        Me.volumeOutput.Size = New System.Drawing.Size(0, 13)
        Me.volumeOutput.TabIndex = 9
        '
        'surfaceAreaOutput
        '
        Me.surfaceAreaOutput.AutoSize = True
        Me.surfaceAreaOutput.Location = New System.Drawing.Point(98, 90)
        Me.surfaceAreaOutput.Name = "surfaceAreaOutput"
        Me.surfaceAreaOutput.Size = New System.Drawing.Size(0, 13)
        Me.surfaceAreaOutput.TabIndex = 8
        '
        'areaSide2Output
        '
        Me.areaSide2Output.AutoSize = True
        Me.areaSide2Output.Location = New System.Drawing.Point(101, 65)
        Me.areaSide2Output.Name = "areaSide2Output"
        Me.areaSide2Output.Size = New System.Drawing.Size(0, 13)
        Me.areaSide2Output.TabIndex = 7
        '
        'areaSide1Output
        '
        Me.areaSide1Output.AutoSize = True
        Me.areaSide1Output.Location = New System.Drawing.Point(102, 42)
        Me.areaSide1Output.Name = "areaSide1Output"
        Me.areaSide1Output.Size = New System.Drawing.Size(0, 13)
        Me.areaSide1Output.TabIndex = 6
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(20, 65)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(75, 13)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Area of side 2:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 115)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Volume:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 90)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Surface Area:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(20, 42)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Area of side 1:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(20, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(144, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Cube Dimension Calculations"
        '
        'cubeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(543, 237)
        Me.Controls.Add(Me.sphereCalculations)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.calcCubeBtn)
        Me.Controls.Add(Me.lengthInput)
        Me.Controls.Add(Me.heightInput)
        Me.Controls.Add(Me.widthInput)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dumlabel)
        Me.Controls.Add(Me.headerLabel)
        Me.Name = "cubeForm"
        Me.Text = "Cube Form"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.sphereCalculations.ResumeLayout(False)
        Me.sphereCalculations.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents headerLabel As Label
    Friend WithEvents dumlabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents widthInput As TextBox
    Friend WithEvents heightInput As TextBox
    Friend WithEvents lengthInput As TextBox
    Friend WithEvents calcCubeBtn As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrintToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HistoryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents sphereCalculations As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents volumeOutput As Label
    Friend WithEvents surfaceAreaOutput As Label
    Friend WithEvents areaSide2Output As Label
    Friend WithEvents areaSide1Output As Label
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
End Class
