<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChordEditor
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
        Me.cmdRemove = New System.Windows.Forms.Button()
        Me.cmdAdd = New System.Windows.Forms.Button()
        Me.lstChords = New System.Windows.Forms.ListBox()
        Me.lstChordRoot = New System.Windows.Forms.ListBox()
        Me.lstChordType = New System.Windows.Forms.ListBox()
        Me.CD = New System.Windows.Forms.ColorDialog()
        Me.cmdRoot = New System.Windows.Forms.Button()
        Me.cmd3rd = New System.Windows.Forms.Button()
        Me.cmd5th = New System.Windows.Forms.Button()
        Me.cmd7th = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmd9th = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmd13th = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmdRemove
        '
        Me.cmdRemove.Location = New System.Drawing.Point(193, 148)
        Me.cmdRemove.Name = "cmdRemove"
        Me.cmdRemove.Size = New System.Drawing.Size(42, 23)
        Me.cmdRemove.TabIndex = 22
        Me.cmdRemove.Text = "<"
        Me.cmdRemove.UseVisualStyleBackColor = True
        '
        'cmdAdd
        '
        Me.cmdAdd.Location = New System.Drawing.Point(193, 13)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(42, 23)
        Me.cmdAdd.TabIndex = 21
        Me.cmdAdd.Text = ">"
        Me.cmdAdd.UseVisualStyleBackColor = True
        '
        'lstChords
        '
        Me.lstChords.FormattingEnabled = True
        Me.lstChords.Location = New System.Drawing.Point(241, 12)
        Me.lstChords.Name = "lstChords"
        Me.lstChords.Size = New System.Drawing.Size(166, 160)
        Me.lstChords.TabIndex = 20
        '
        'lstChordRoot
        '
        Me.lstChordRoot.FormattingEnabled = True
        Me.lstChordRoot.Items.AddRange(New Object() {"C", "Db", "D", "Eb", "E", "F", "Gb", "G", "Ab", "A", "B", "Bb"})
        Me.lstChordRoot.Location = New System.Drawing.Point(7, 13)
        Me.lstChordRoot.Name = "lstChordRoot"
        Me.lstChordRoot.Size = New System.Drawing.Size(50, 160)
        Me.lstChordRoot.TabIndex = 19
        '
        'lstChordType
        '
        Me.lstChordType.FormattingEnabled = True
        Me.lstChordType.Location = New System.Drawing.Point(63, 12)
        Me.lstChordType.Name = "lstChordType"
        Me.lstChordType.Size = New System.Drawing.Size(109, 160)
        Me.lstChordType.TabIndex = 18
        '
        'cmdRoot
        '
        Me.cmdRoot.BackColor = System.Drawing.Color.Yellow
        Me.cmdRoot.Location = New System.Drawing.Point(202, 42)
        Me.cmdRoot.Name = "cmdRoot"
        Me.cmdRoot.Size = New System.Drawing.Size(33, 18)
        Me.cmdRoot.TabIndex = 23
        Me.cmdRoot.UseVisualStyleBackColor = False
        '
        'cmd3rd
        '
        Me.cmd3rd.BackColor = System.Drawing.Color.Yellow
        Me.cmd3rd.Location = New System.Drawing.Point(202, 59)
        Me.cmd3rd.Name = "cmd3rd"
        Me.cmd3rd.Size = New System.Drawing.Size(33, 18)
        Me.cmd3rd.TabIndex = 24
        Me.cmd3rd.UseVisualStyleBackColor = False
        '
        'cmd5th
        '
        Me.cmd5th.BackColor = System.Drawing.Color.Yellow
        Me.cmd5th.Location = New System.Drawing.Point(202, 76)
        Me.cmd5th.Name = "cmd5th"
        Me.cmd5th.Size = New System.Drawing.Size(33, 18)
        Me.cmd5th.TabIndex = 25
        Me.cmd5th.UseVisualStyleBackColor = False
        '
        'cmd7th
        '
        Me.cmd7th.BackColor = System.Drawing.Color.Yellow
        Me.cmd7th.Location = New System.Drawing.Point(202, 93)
        Me.cmd7th.Name = "cmd7th"
        Me.cmd7th.Size = New System.Drawing.Size(33, 18)
        Me.cmd7th.TabIndex = 26
        Me.cmd7th.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(182, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(15, 13)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "R"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(179, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(22, 13)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "3rd"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(179, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(22, 13)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "5th"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(179, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(22, 13)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "7th"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(179, 109)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(22, 13)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "9th"
        '
        'cmd9th
        '
        Me.cmd9th.BackColor = System.Drawing.Color.Yellow
        Me.cmd9th.Location = New System.Drawing.Point(202, 109)
        Me.cmd9th.Name = "cmd9th"
        Me.cmd9th.Size = New System.Drawing.Size(33, 18)
        Me.cmd9th.TabIndex = 31
        Me.cmd9th.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(173, 126)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(28, 13)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "13th"
        '
        'cmd13th
        '
        Me.cmd13th.BackColor = System.Drawing.Color.Yellow
        Me.cmd13th.Location = New System.Drawing.Point(202, 126)
        Me.cmd13th.Name = "cmd13th"
        Me.cmd13th.Size = New System.Drawing.Size(33, 18)
        Me.cmd13th.TabIndex = 33
        Me.cmd13th.UseVisualStyleBackColor = False
        '
        'frmChordEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(424, 179)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmd13th)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmd9th)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmd7th)
        Me.Controls.Add(Me.cmd5th)
        Me.Controls.Add(Me.cmd3rd)
        Me.Controls.Add(Me.cmdRoot)
        Me.Controls.Add(Me.cmdRemove)
        Me.Controls.Add(Me.cmdAdd)
        Me.Controls.Add(Me.lstChords)
        Me.Controls.Add(Me.lstChordRoot)
        Me.Controls.Add(Me.lstChordType)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmChordEditor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Chord Editor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdRemove As System.Windows.Forms.Button
    Friend WithEvents cmdAdd As System.Windows.Forms.Button
    Friend WithEvents lstChords As System.Windows.Forms.ListBox
    Friend WithEvents lstChordRoot As System.Windows.Forms.ListBox
    Friend WithEvents lstChordType As System.Windows.Forms.ListBox
    Friend WithEvents CD As System.Windows.Forms.ColorDialog
    Friend WithEvents cmdRoot As System.Windows.Forms.Button
    Friend WithEvents cmd3rd As System.Windows.Forms.Button
    Friend WithEvents cmd5th As System.Windows.Forms.Button
    Friend WithEvents cmd7th As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cmd9th As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents cmd13th As Button
End Class
