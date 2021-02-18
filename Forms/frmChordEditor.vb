Public Class frmChordEditor
    Private m_chords As New List(Of Scale)
    Private m_boardChords As List(Of Scale)
    Private m_fretBoard As frmFretBoard



    Public Sub New(sc As List(Of Scale))
        Me.InitializeComponent()

        m_chords = sc

        Me.lstChords.DisplayMember = "ChordName"
        Me.lstChordType.DataSource = Me.m_chords
        Me.lstChordType.DisplayMember = "Name"



        'InitListBoxes()

    End Sub

    Public Overloads Function ShowDialog(owner As System.Windows.Forms.IWin32Window, chrds As List(Of Scale), frm As frmFretBoard) As System.Windows.Forms.DialogResult
        m_boardChords = chrds
        m_fretBoard = frm

        lstChords.Items.Clear()
        For Each s As Scale In m_boardChords
            lstChords.Items.Add(s)
        Next


        Return Me.ShowDialog(owner)

    End Function

    Private Sub cmdRemove_Click(sender As System.Object, e As System.EventArgs) Handles cmdRemove.Click
        RemoveChord()
    End Sub

    Private Sub cmdAdd_Click(sender As System.Object, e As System.EventArgs) Handles cmdAdd.Click
        Call AddChord()
    End Sub

    Private Sub RemoveChord()
        Dim a As New ArrayList
        For Each item As Scale In Me.lstChords.SelectedItems
            a.Add(item)
        Next

        For Each item As Scale In a
            If m_boardChords.Contains(item) Then
                m_boardChords.Remove(item)
            End If
            Me.lstChords.Items.Remove(item)
        Next
        m_fretBoard.CalculateBoard()
    End Sub
    Private Sub AddChord()
        If Me.lstChordRoot.SelectedIndex = -1 Then
            Me.lstChordRoot.SelectedIndex = 0
        End If


        For Each item As Scale In Me.lstChordType.SelectedItems

            Dim newScale As New Scale
            newScale.Intervals = item.Intervals
            newScale.ChordName = Me.lstChordRoot.SelectedItem & " " & item.ScaleName
            newScale.CalculateNotes([Enum].Parse(GetType(Notes), Me.lstChordRoot.SelectedItem))
            newScale.ChordColor = Color.Yellow
            newScale.ChordRootColor = cmdRoot.BackColor
            newScale.Chord3rdColor = cmd3rd.BackColor
            newScale.Chord5thColor = cmd5th.BackColor
            newScale.Chord7thColor = cmd7th.BackColor
            newScale.Chord9thColor = cmd9th.BackColor
            newScale.Chord13thColor = cmd13th.BackColor


            m_boardChords.Add(newScale)


            Me.lstChords.Items.Add(newScale)

        Next

        m_fretBoard.CalculateBoard()
    End Sub

    Private Sub lstChordType_DoubleClick(sender As Object, e As System.EventArgs) Handles lstChordType.DoubleClick
        Call AddChord()
    End Sub

    Private Sub lstChords_DoubleClick(sender As Object, e As System.EventArgs) Handles lstChords.DoubleClick
        Call RemoveChord()
    End Sub



    Private Sub cmdRoot_Click(sender As System.Object, e As System.EventArgs) Handles cmdRoot.Click
        SetColor(sender)

    End Sub

    Private Sub cmd3rd_Click(sender As System.Object, e As System.EventArgs) Handles cmd3rd.Click
        SetColor(sender)

    End Sub

    Private Sub cmd5th_Click(sender As System.Object, e As System.EventArgs) Handles cmd5th.Click
        SetColor(sender)
    End Sub

    Private Sub cmd7th_Click(sender As System.Object, e As System.EventArgs) Handles cmd7th.Click
        SetColor(sender)
    End Sub

    Private Sub SetColor(sender As System.Object)
        If CD.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            CD.AnyColor = True
            sender.BackColor = CD.Color
        End If
    End Sub

    Private Sub cmd9th_Click(sender As Object, e As EventArgs) Handles cmd9th.Click
        SetColor(sender)
    End Sub

    Private Sub cmd13th_Click(sender As Object, e As EventArgs) Handles cmd13th.Click
        SetColor(sender)
    End Sub
End Class