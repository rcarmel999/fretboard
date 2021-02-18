<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.cmdNew = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.chkShowAll = New System.Windows.Forms.CheckBox()
        Me.cmdChordColor = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.lstChords = New System.Windows.Forms.ListBox()
        Me.lstChordRoot = New System.Windows.Forms.ListBox()
        Me.lstChordType = New System.Windows.Forms.ListBox()
        Me.lstScales = New System.Windows.Forms.ListBox()
        Me.lstRoot = New System.Windows.Forms.ListBox()
        Me.lstCategory = New System.Windows.Forms.ListBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.Panel1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.cmdNew)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.ListBox1)
        Me.Panel1.Controls.Add(Me.chkShowAll)
        Me.Panel1.Controls.Add(Me.cmdChordColor)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.lstChords)
        Me.Panel1.Controls.Add(Me.lstChordRoot)
        Me.Panel1.Controls.Add(Me.lstChordType)
        Me.Panel1.Controls.Add(Me.lstScales)
        Me.Panel1.Controls.Add(Me.lstRoot)
        Me.Panel1.Controls.Add(Me.lstCategory)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 522)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1275, 10)
        Me.Panel1.TabIndex = 1
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(353, 77)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(42, 23)
        Me.Button4.TabIndex = 23
        Me.Button4.Text = "Add"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'cmdNew
        '
        Me.cmdNew.Location = New System.Drawing.Point(353, 4)
        Me.cmdNew.Name = "cmdNew"
        Me.cmdNew.Size = New System.Drawing.Size(42, 23)
        Me.cmdNew.TabIndex = 22
        Me.cmdNew.Text = "New "
        Me.cmdNew.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(1024, 4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(76, 23)
        Me.Button3.TabIndex = 21
        Me.Button3.Text = "Harmonize"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(1106, 3)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(166, 160)
        Me.ListBox1.TabIndex = 20
        '
        'chkShowAll
        '
        Me.chkShowAll.AutoSize = True
        Me.chkShowAll.Location = New System.Drawing.Point(876, 77)
        Me.chkShowAll.Name = "chkShowAll"
        Me.chkShowAll.Size = New System.Drawing.Size(67, 17)
        Me.chkShowAll.TabIndex = 19
        Me.chkShowAll.Text = "Show All"
        Me.chkShowAll.UseVisualStyleBackColor = True
        '
        'cmdChordColor
        '
        Me.cmdChordColor.Location = New System.Drawing.Point(851, 4)
        Me.cmdChordColor.Name = "cmdChordColor"
        Me.cmdChordColor.Size = New System.Drawing.Size(60, 23)
        Me.cmdChordColor.TabIndex = 18
        Me.cmdChordColor.Text = "Color"
        Me.cmdChordColor.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(631, 73)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(42, 23)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "<"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(631, 32)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(42, 23)
        Me.Button2.TabIndex = 16
        Me.Button2.Text = ">"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'lstChords
        '
        Me.lstChords.FormattingEnabled = True
        Me.lstChords.Location = New System.Drawing.Point(679, 3)
        Me.lstChords.Name = "lstChords"
        Me.lstChords.Size = New System.Drawing.Size(166, 160)
        Me.lstChords.TabIndex = 15
        '
        'lstChordRoot
        '
        Me.lstChordRoot.FormattingEnabled = True
        Me.lstChordRoot.Items.AddRange(New Object() {"C", "Db", "D", "Eb", "E", "F", "Gb", "G", "Ab", "A", "B", "Bb"})
        Me.lstChordRoot.Location = New System.Drawing.Point(449, 4)
        Me.lstChordRoot.Name = "lstChordRoot"
        Me.lstChordRoot.Size = New System.Drawing.Size(50, 160)
        Me.lstChordRoot.TabIndex = 14
        '
        'lstChordType
        '
        Me.lstChordType.FormattingEnabled = True
        Me.lstChordType.Location = New System.Drawing.Point(505, 3)
        Me.lstChordType.Name = "lstChordType"
        Me.lstChordType.Size = New System.Drawing.Size(120, 160)
        Me.lstChordType.TabIndex = 13
        '
        'lstScales
        '
        Me.lstScales.FormattingEnabled = True
        Me.lstScales.Location = New System.Drawing.Point(181, 3)
        Me.lstScales.Name = "lstScales"
        Me.lstScales.Size = New System.Drawing.Size(166, 160)
        Me.lstScales.TabIndex = 8
        '
        'lstRoot
        '
        Me.lstRoot.FormattingEnabled = True
        Me.lstRoot.Items.AddRange(New Object() {"C", "Db", "D", "Eb", "E", "F", "Gb", "G", "Ab", "A", "B", "Bb"})
        Me.lstRoot.Location = New System.Drawing.Point(4, 3)
        Me.lstRoot.Name = "lstRoot"
        Me.lstRoot.Size = New System.Drawing.Size(50, 160)
        Me.lstRoot.TabIndex = 7
        '
        'lstCategory
        '
        Me.lstCategory.FormattingEnabled = True
        Me.lstCategory.Location = New System.Drawing.Point(57, 3)
        Me.lstCategory.Name = "lstCategory"
        Me.lstCategory.Size = New System.Drawing.Size(120, 160)
        Me.lstCategory.TabIndex = 6
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1275, 25)
        Me.ToolStrip1.TabIndex = 3
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1275, 532)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.IsMdiContainer = True
        Me.Name = "frmMain"
        Me.Text = "Fret Mate"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lstScales As System.Windows.Forms.ListBox
    Friend WithEvents lstRoot As System.Windows.Forms.ListBox
    Friend WithEvents lstCategory As System.Windows.Forms.ListBox
    Friend WithEvents cmdChordColor As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents lstChords As System.Windows.Forms.ListBox
    Friend WithEvents lstChordRoot As System.Windows.Forms.ListBox
    Friend WithEvents lstChordType As System.Windows.Forms.ListBox
    Friend WithEvents chkShowAll As System.Windows.Forms.CheckBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents cmdNew As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
End Class
