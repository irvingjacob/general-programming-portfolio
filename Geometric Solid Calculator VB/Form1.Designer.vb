<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HistoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.selectionLabel = New System.Windows.Forms.Label()
        Me.cubeSelection = New System.Windows.Forms.RadioButton()
        Me.sphereSelection = New System.Windows.Forms.RadioButton()
        Me.coneSelection = New System.Windows.Forms.RadioButton()
        Me.pyramidSelection = New System.Windows.Forms.RadioButton()
        Me.cylinderSelection = New System.Windows.Forms.RadioButton()
        Me.selectBtn = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'headerLabel
        '
        Me.headerLabel.AutoSize = True
        Me.headerLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.headerLabel.Location = New System.Drawing.Point(12, 24)
        Me.headerLabel.Name = "headerLabel"
        Me.headerLabel.Size = New System.Drawing.Size(232, 24)
        Me.headerLabel.TabIndex = 0
        Me.headerLabel.Text = "Geometric Solid Calculator"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(486, 24)
        Me.MenuStrip1.TabIndex = 1
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
        'selectionLabel
        '
        Me.selectionLabel.AutoSize = True
        Me.selectionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.selectionLabel.Location = New System.Drawing.Point(12, 48)
        Me.selectionLabel.Name = "selectionLabel"
        Me.selectionLabel.Size = New System.Drawing.Size(449, 17)
        Me.selectionLabel.TabIndex = 2
        Me.selectionLabel.Text = "Please select the geometric solid you'd like to preform calculations on:"
        '
        'cubeSelection
        '
        Me.cubeSelection.AutoSize = True
        Me.cubeSelection.Checked = True
        Me.cubeSelection.Location = New System.Drawing.Point(12, 68)
        Me.cubeSelection.Name = "cubeSelection"
        Me.cubeSelection.Size = New System.Drawing.Size(50, 17)
        Me.cubeSelection.TabIndex = 3
        Me.cubeSelection.TabStop = True
        Me.cubeSelection.Text = "Cube"
        Me.cubeSelection.UseVisualStyleBackColor = True
        '
        'sphereSelection
        '
        Me.sphereSelection.AutoSize = True
        Me.sphereSelection.Location = New System.Drawing.Point(69, 69)
        Me.sphereSelection.Name = "sphereSelection"
        Me.sphereSelection.Size = New System.Drawing.Size(59, 17)
        Me.sphereSelection.TabIndex = 4
        Me.sphereSelection.Text = "Sphere"
        Me.sphereSelection.UseVisualStyleBackColor = True
        '
        'coneSelection
        '
        Me.coneSelection.AutoSize = True
        Me.coneSelection.Location = New System.Drawing.Point(135, 69)
        Me.coneSelection.Name = "coneSelection"
        Me.coneSelection.Size = New System.Drawing.Size(50, 17)
        Me.coneSelection.TabIndex = 5
        Me.coneSelection.Text = "Cone"
        Me.coneSelection.UseVisualStyleBackColor = True
        '
        'pyramidSelection
        '
        Me.pyramidSelection.AutoSize = True
        Me.pyramidSelection.Location = New System.Drawing.Point(191, 68)
        Me.pyramidSelection.Name = "pyramidSelection"
        Me.pyramidSelection.Size = New System.Drawing.Size(62, 17)
        Me.pyramidSelection.TabIndex = 6
        Me.pyramidSelection.Text = "Pyramid"
        Me.pyramidSelection.UseVisualStyleBackColor = True
        '
        'cylinderSelection
        '
        Me.cylinderSelection.AutoSize = True
        Me.cylinderSelection.Location = New System.Drawing.Point(260, 69)
        Me.cylinderSelection.Name = "cylinderSelection"
        Me.cylinderSelection.Size = New System.Drawing.Size(62, 17)
        Me.cylinderSelection.TabIndex = 7
        Me.cylinderSelection.Text = "Cylinder"
        Me.cylinderSelection.UseVisualStyleBackColor = True
        '
        'selectBtn
        '
        Me.selectBtn.Location = New System.Drawing.Point(12, 92)
        Me.selectBtn.Name = "selectBtn"
        Me.selectBtn.Size = New System.Drawing.Size(75, 23)
        Me.selectBtn.TabIndex = 8
        Me.selectBtn.Text = "Select Solid"
        Me.selectBtn.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(486, 146)
        Me.Controls.Add(Me.selectBtn)
        Me.Controls.Add(Me.cylinderSelection)
        Me.Controls.Add(Me.pyramidSelection)
        Me.Controls.Add(Me.coneSelection)
        Me.Controls.Add(Me.sphereSelection)
        Me.Controls.Add(Me.cubeSelection)
        Me.Controls.Add(Me.selectionLabel)
        Me.Controls.Add(Me.headerLabel)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Object Select Form"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents headerLabel As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrintToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HistoryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents selectionLabel As Label
    Friend WithEvents cubeSelection As RadioButton
    Friend WithEvents sphereSelection As RadioButton
    Friend WithEvents coneSelection As RadioButton
    Friend WithEvents pyramidSelection As RadioButton
    Friend WithEvents cylinderSelection As RadioButton
    Friend WithEvents selectBtn As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
End Class
