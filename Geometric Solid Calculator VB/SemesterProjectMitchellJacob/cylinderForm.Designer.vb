<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cylinderForm
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HistoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.calcCubeBtn = New System.Windows.Forms.Button()
        Me.radiusInput = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dumlabel = New System.Windows.Forms.Label()
        Me.headerLabel = New System.Windows.Forms.Label()
        Me.heightInput = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.sphereCalculations = New System.Windows.Forms.Panel()
        Me.topAreaOutput = New System.Windows.Forms.Label()
        Me.surfaceAreaOutput = New System.Windows.Forms.Label()
        Me.volumeOutput = New System.Windows.Forms.Label()
        Me.diameterOutput = New System.Windows.Forms.Label()
        Me.radiusOutput = New System.Windows.Forms.Label()
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
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 4
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
        'calcCubeBtn
        '
        Me.calcCubeBtn.Location = New System.Drawing.Point(74, 138)
        Me.calcCubeBtn.Name = "calcCubeBtn"
        Me.calcCubeBtn.Size = New System.Drawing.Size(75, 23)
        Me.calcCubeBtn.TabIndex = 32
        Me.calcCubeBtn.Text = "Calculate"
        Me.calcCubeBtn.UseVisualStyleBackColor = True
        '
        'radiusInput
        '
        Me.radiusInput.Location = New System.Drawing.Point(62, 86)
        Me.radiusInput.Name = "radiusInput"
        Me.radiusInput.Size = New System.Drawing.Size(100, 20)
        Me.radiusInput.TabIndex = 31
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Radius:"
        '
        'dumlabel
        '
        Me.dumlabel.AutoSize = True
        Me.dumlabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dumlabel.Location = New System.Drawing.Point(13, 66)
        Me.dumlabel.Name = "dumlabel"
        Me.dumlabel.Size = New System.Drawing.Size(274, 17)
        Me.dumlabel.TabIndex = 29
        Me.dumlabel.Text = "Please Input The Dimensions Of the Solid:"
        '
        'headerLabel
        '
        Me.headerLabel.AutoSize = True
        Me.headerLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.headerLabel.Location = New System.Drawing.Point(12, 42)
        Me.headerLabel.Name = "headerLabel"
        Me.headerLabel.Size = New System.Drawing.Size(263, 24)
        Me.headerLabel.TabIndex = 28
        Me.headerLabel.Text = "Cylinder Dimension Generator"
        '
        'heightInput
        '
        Me.heightInput.Location = New System.Drawing.Point(62, 112)
        Me.heightInput.Name = "heightInput"
        Me.heightInput.Size = New System.Drawing.Size(100, 20)
        Me.heightInput.TabIndex = 34
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Height:"
        '
        'sphereCalculations
        '
        Me.sphereCalculations.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.sphereCalculations.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.sphereCalculations.Controls.Add(Me.topAreaOutput)
        Me.sphereCalculations.Controls.Add(Me.surfaceAreaOutput)
        Me.sphereCalculations.Controls.Add(Me.volumeOutput)
        Me.sphereCalculations.Controls.Add(Me.diameterOutput)
        Me.sphereCalculations.Controls.Add(Me.radiusOutput)
        Me.sphereCalculations.Controls.Add(Me.Label8)
        Me.sphereCalculations.Controls.Add(Me.Label6)
        Me.sphereCalculations.Controls.Add(Me.Label5)
        Me.sphereCalculations.Controls.Add(Me.Label4)
        Me.sphereCalculations.Controls.Add(Me.Label2)
        Me.sphereCalculations.Controls.Add(Me.Label7)
        Me.sphereCalculations.Location = New System.Drawing.Point(305, 41)
        Me.sphereCalculations.Name = "sphereCalculations"
        Me.sphereCalculations.Size = New System.Drawing.Size(231, 173)
        Me.sphereCalculations.TabIndex = 35
        '
        'topAreaOutput
        '
        Me.topAreaOutput.AutoSize = True
        Me.topAreaOutput.Location = New System.Drawing.Point(137, 142)
        Me.topAreaOutput.Name = "topAreaOutput"
        Me.topAreaOutput.Size = New System.Drawing.Size(0, 13)
        Me.topAreaOutput.TabIndex = 10
        '
        'surfaceAreaOutput
        '
        Me.surfaceAreaOutput.AutoSize = True
        Me.surfaceAreaOutput.Location = New System.Drawing.Point(99, 118)
        Me.surfaceAreaOutput.Name = "surfaceAreaOutput"
        Me.surfaceAreaOutput.Size = New System.Drawing.Size(0, 13)
        Me.surfaceAreaOutput.TabIndex = 9
        '
        'volumeOutput
        '
        Me.volumeOutput.AutoSize = True
        Me.volumeOutput.Location = New System.Drawing.Point(74, 95)
        Me.volumeOutput.Name = "volumeOutput"
        Me.volumeOutput.Size = New System.Drawing.Size(0, 13)
        Me.volumeOutput.TabIndex = 8
        '
        'diameterOutput
        '
        Me.diameterOutput.AutoSize = True
        Me.diameterOutput.Location = New System.Drawing.Point(81, 69)
        Me.diameterOutput.Name = "diameterOutput"
        Me.diameterOutput.Size = New System.Drawing.Size(0, 13)
        Me.diameterOutput.TabIndex = 7
        '
        'radiusOutput
        '
        Me.radiusOutput.AutoSize = True
        Me.radiusOutput.Location = New System.Drawing.Point(72, 44)
        Me.radiusOutput.Name = "radiusOutput"
        Me.radiusOutput.Size = New System.Drawing.Size(0, 13)
        Me.radiusOutput.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(21, 142)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(116, 13)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Top and Bottom Areas:"
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
        Me.Label7.Location = New System.Drawing.Point(32, 10)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(156, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Cylinder Dimension Calculations"
        '
        'cylinderForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 257)
        Me.Controls.Add(Me.sphereCalculations)
        Me.Controls.Add(Me.heightInput)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.calcCubeBtn)
        Me.Controls.Add(Me.radiusInput)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dumlabel)
        Me.Controls.Add(Me.headerLabel)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "cylinderForm"
        Me.Text = "cylinderForm"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.sphereCalculations.ResumeLayout(False)
        Me.sphereCalculations.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrintToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HistoryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents calcCubeBtn As Button
    Friend WithEvents radiusInput As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dumlabel As Label
    Friend WithEvents headerLabel As Label
    Friend WithEvents heightInput As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents sphereCalculations As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents topAreaOutput As Label
    Friend WithEvents surfaceAreaOutput As Label
    Friend WithEvents volumeOutput As Label
    Friend WithEvents diameterOutput As Label
    Friend WithEvents radiusOutput As Label
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
End Class
