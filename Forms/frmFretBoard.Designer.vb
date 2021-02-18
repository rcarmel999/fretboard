<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFretBoard
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
        Me.components = New System.ComponentModel.Container()
        Me.pnlBoard = New System.Windows.Forms.Panel()
        Me.pnlFretMarkers = New System.Windows.Forms.Panel()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuScales = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuChords = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDisplay = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdDisplayAll = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlBoard
        '
        Me.pnlBoard.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlBoard.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlBoard.Location = New System.Drawing.Point(0, 18)
        Me.pnlBoard.Name = "pnlBoard"
        Me.pnlBoard.Size = New System.Drawing.Size(952, 197)
        Me.pnlBoard.TabIndex = 0
        '
        'pnlFretMarkers
        '
        Me.pnlFretMarkers.BackColor = System.Drawing.Color.White
        Me.pnlFretMarkers.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlFretMarkers.Location = New System.Drawing.Point(0, 0)
        Me.pnlFretMarkers.Name = "pnlFretMarkers"
        Me.pnlFretMarkers.Size = New System.Drawing.Size(952, 18)
        Me.pnlFretMarkers.TabIndex = 1
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuScales, Me.mnuChords, Me.mnuDisplay, Me.cmdDisplayAll})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(130, 92)
        '
        'mnuScales
        '
        Me.mnuScales.Name = "mnuScales"
        Me.mnuScales.Size = New System.Drawing.Size(152, 22)
        Me.mnuScales.Text = "Scales..."
        '
        'mnuChords
        '
        Me.mnuChords.Name = "mnuChords"
        Me.mnuChords.Size = New System.Drawing.Size(152, 22)
        Me.mnuChords.Text = "Chords..."
        '
        'mnuDisplay
        '
        Me.mnuDisplay.Name = "mnuDisplay"
        Me.mnuDisplay.Size = New System.Drawing.Size(152, 22)
        Me.mnuDisplay.Text = "Display..."
        '
        'cmdDisplayAll
        '
        Me.cmdDisplayAll.Name = "cmdDisplayAll"
        Me.cmdDisplayAll.Size = New System.Drawing.Size(152, 22)
        Me.cmdDisplayAll.Text = "Display All"
        '
        'frmFretBoard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(952, 215)
        Me.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Controls.Add(Me.pnlBoard)
        Me.Controls.Add(Me.pnlFretMarkers)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFretBoard"
        Me.ShowInTaskbar = False
        Me.Text = "Fret Board"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlBoard As System.Windows.Forms.Panel
    Friend WithEvents pnlFretMarkers As System.Windows.Forms.Panel
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents mnuScales As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuChords As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuDisplay As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdDisplayAll As System.Windows.Forms.ToolStripMenuItem
End Class
