<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sphereForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dumlabel = New System.Windows.Forms.Label()
        Me.headerLabel = New System.Windows.Forms.Label()
        Me.sphereCalculations = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.radiusOutput = New System.Windows.Forms.Label()
        Me.diameterOutput = New System.Windows.Forms.Label()
        Me.volumeOutput = New System.Windows.Forms.Label()
        Me.surfaceAreaOutput = New System.Windows.Forms.Label()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.sphereCalculations.SuspendLayout()
        Me.MenuStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'calcCubeBtn
        '
        Me.calcCubeBtn.Location = New System.Drawing.Point(74, 104)
        Me.calcCubeBtn.Name = "calcCubeBtn"
        Me.calcCubeBtn.Size = New System.Drawing.Size(75, 23)
        Me.calcCubeBtn.TabIndex = 27
        Me.calcCubeBtn.Text = "Calculate"
        Me.calcCubeBtn.UseVisualStyleBackColor = True
        '
        'radiusInput
        '
        Me.radiusInput.Location = New System.Drawing.Point(62, 78)
        Me.radiusInput.Name = "radiusInput"
        Me.radiusInput.Size = New System.Drawing.Size(100, 20)
        Me.radiusInput.TabIndex = 26
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Radius:"
        '
        'dumlabel
        '
        Me.dumlabel.AutoSize = True
        Me.dumlabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dumlabel.Location = New System.Drawing.Point(13, 58)
        Me.dumlabel.Name = "dumlabel"
        Me.dumlabel.Size = New System.Drawing.Size(274, 17)
        Me.dumlabel.TabIndex = 20
        Me.dumlabel.Text = "Please Input The Dimensions Of the Solid:"
        '
        'headerLabel
        '
        Me.headerLabel.AutoSize = True
        Me.headerLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.headerLabel.Location = New System.Drawing.Point(12, 34)
        Me.headerLabel.Name = "headerLabel"
        Me.headerLabel.Size = New System.Drawing.Size(256, 24)
        Me.headerLabel.TabIndex = 19
        Me.headerLabel.Text = "Sphere Dimension Generator"
        '
        'sphereCalculations
        '
        Me.sphereCalculations.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.sphereCalculations.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.sphereCalculations.Controls.Add(Me.surfaceAreaOutput)
        Me.sphereCalculations.Controls.Add(Me.volumeOutput)
        Me.sphereCalculations.Controls.Add(Me.diameterOutput)
        Me.sphereCalculations.Controls.Add(Me.radiusOutput)
        Me.sphereCalculations.Controls.Add(Me.Label6)
        Me.sphereCalculations.Controls.Add(Me.Label5)
        Me.sphereCalculations.Controls.Add(Me.Label4)
        Me.sphereCalculations.Controls.Add(Me.Label3)
        Me.sphereCalculations.Controls.Add(Me.Label2)
        Me.sphereCalculations.Location = New System.Drawing.Point(316, 34)
        Me.sphereCalculations.Name = "sphereCalculations"
        Me.sphereCalculations.Size = New System.Drawing.Size(200, 177)
        Me.sphereCalculations.TabIndex = 28
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(25, 118)
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
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Radius:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(20, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(153, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Sphere Dimension Calculations"
        '
        'radiusOutput
        '
        Me.radiusOutput.AutoSize = True
        Me.radiusOutput.Location = New System.Drawing.Point(66, 45)
        Me.radiusOutput.Name = "radiusOutput"
        Me.radiusOutput.Size = New System.Drawing.Size(0, 13)
        Me.radiusOutput.TabIndex = 8
        '
        'diameterOutput
        '
        Me.diameterOutput.AutoSize = True
        Me.diameterOutput.Location = New System.Drawing.Point(81, 68)
        Me.diameterOutput.Name = "diameterOutput"
        Me.diameterOutput.Size = New System.Drawing.Size(0, 13)
        Me.diameterOutput.TabIndex = 9
        '
        'volumeOutput
        '
        Me.volumeOutput.AutoSize = True
        Me.volumeOutput.Location = New System.Drawing.Point(74, 94)
        Me.volumeOutput.Name = "volumeOutput"
        Me.volumeOutput.Size = New System.Drawing.Size(0, 13)
        Me.volumeOutput.TabIndex = 10
        '
        'surfaceAreaOutput
        '
        Me.surfaceAreaOutput.AutoSize = True
        Me.surfaceAreaOutput.Location = New System.Drawing.Point(103, 118)
        Me.surfaceAreaOutput.Name = "surfaceAreaOutput"
        Me.surfaceAreaOutput.Size = New System.Drawing.Size(0, 13)
        Me.surfaceAreaOutput.TabIndex = 11
        '
        'MenuStrip2
        '
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripMenuItem4})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip2.TabIndex = 29
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2, Me.ToolStripMenuItem3})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(37, 20)
        Me.ToolStripMenuItem1.Text = "File"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(180, 22)
        Me.ToolStripMenuItem2.Text = "Print"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(180, 22)
        Me.ToolStripMenuItem3.Text = "History"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(44, 20)
        Me.ToolStripMenuItem4.Text = "Help"
        '
        'sphereForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip2)
        Me.Controls.Add(Me.sphereCalculations)
        Me.Controls.Add(Me.calcCubeBtn)
        Me.Controls.Add(Me.radiusInput)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dumlabel)
        Me.Controls.Add(Me.headerLabel)
        Me.Name = "sphereForm"
        Me.Text = "sphereForm"
        Me.sphereCalculations.ResumeLayout(False)
        Me.sphereCalculations.PerformLayout()
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents calcCubeBtn As Button
    Friend WithEvents radiusInput As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dumlabel As Label
    Friend WithEvents headerLabel As Label
    Friend WithEvents sphereCalculations As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents surfaceAreaOutput As Label
    Friend WithEvents volumeOutput As Label
    Friend WithEvents diameterOutput As Label
    Friend WithEvents radiusOutput As Label
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As ToolStripMenuItem
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
End Class
