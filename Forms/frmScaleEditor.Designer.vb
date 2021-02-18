<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmScaleEditor
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
        Me.lstScales = New System.Windows.Forms.ListBox()
        Me.lstRoot = New System.Windows.Forms.ListBox()
        Me.lstCategory = New System.Windows.Forms.ListBox()
        Me.lstBoardScales = New System.Windows.Forms.ListBox()
        Me.cmdRemove = New System.Windows.Forms.Button()
        Me.cmdAdd = New System.Windows.Forms.Button()
        Me.CD = New System.Windows.Forms.ColorDialog()
        Me.cmdColor = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstScales
        '
        Me.lstScales.FormattingEnabled = True
        Me.lstScales.Location = New System.Drawing.Point(187, 12)
        Me.lstScales.Name = "lstScales"
        Me.lstScales.Size = New System.Drawing.Size(166, 160)
        Me.lstScales.TabIndex = 11
        '
        'lstRoot
        '
        Me.lstRoot.FormattingEnabled = True
        Me.lstRoot.Items.AddRange(New Object() {"C", "Db", "D", "Eb", "E", "F", "Gb", "G", "Ab", "A", "B", "Bb"})
        Me.lstRoot.Location = New System.Drawing.Point(10, 12)
        Me.lstRoot.Name = "lstRoot"
        Me.lstRoot.Size = New System.Drawing.Size(50, 160)
        Me.lstRoot.TabIndex = 10
        '
        'lstCategory
        '
        Me.lstCategory.FormattingEnabled = True
        Me.lstCategory.Location = New System.Drawing.Point(63, 12)
        Me.lstCategory.Name = "lstCategory"
        Me.lstCategory.Size = New System.Drawing.Size(120, 160)
        Me.lstCategory.TabIndex = 9
        '
        'lstBoardScales
        '
        Me.lstBoardScales.FormattingEnabled = True
        Me.lstBoardScales.Location = New System.Drawing.Point(407, 12)
        Me.lstBoardScales.Name = "lstBoardScales"
        Me.lstBoardScales.Size = New System.Drawing.Size(166, 160)
        Me.lstBoardScales.TabIndex = 16
        '
        'cmdRemove
        '
        Me.cmdRemove.Location = New System.Drawing.Point(359, 98)
        Me.cmdRemove.Name = "cmdRemove"
        Me.cmdRemove.Size = New System.Drawing.Size(42, 23)
        Me.cmdRemove.TabIndex = 19
        Me.cmdRemove.Text = "<"
        Me.cmdRemove.UseVisualStyleBackColor = True
        '
        'cmdAdd
        '
        Me.cmdAdd.Location = New System.Drawing.Point(359, 57)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(42, 23)
        Me.cmdAdd.TabIndex = 18
        Me.cmdAdd.Text = ">"
        Me.cmdAdd.UseVisualStyleBackColor = True
        '
        'cmdColor
        '
        Me.cmdColor.BackColor = System.Drawing.Color.Yellow
        Me.cmdColor.Location = New System.Drawing.Point(363, 12)
        Me.cmdColor.Name = "cmdColor"
        Me.cmdColor.Size = New System.Drawing.Size(33, 28)
        Me.cmdColor.TabIndex = 20
        Me.cmdColor.UseVisualStyleBackColor = False
        '
        'frmScaleEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(583, 181)
        Me.Controls.Add(Me.cmdColor)
        Me.Controls.Add(Me.cmdRemove)
        Me.Controls.Add(Me.cmdAdd)
        Me.Controls.Add(Me.lstBoardScales)
        Me.Controls.Add(Me.lstScales)
        Me.Controls.Add(Me.lstRoot)
        Me.Controls.Add(Me.lstCategory)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmScaleEditor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Scales"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstScales As System.Windows.Forms.ListBox
    Friend WithEvents lstRoot As System.Windows.Forms.ListBox
    Friend WithEvents lstCategory As System.Windows.Forms.ListBox
    Friend WithEvents lstBoardScales As System.Windows.Forms.ListBox
    Friend WithEvents cmdRemove As System.Windows.Forms.Button
    Friend WithEvents cmdAdd As System.Windows.Forms.Button
    Friend WithEvents CD As System.Windows.Forms.ColorDialog
    Friend WithEvents cmdColor As System.Windows.Forms.Button
End Class
