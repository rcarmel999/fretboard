Public Class frmMain

    Private m_scales As New List(Of Scale)
    Private m_chords As New List(Of Scale)
    Private m_scaleEditor As frmScaleEditor
    Private m_chordEditor As frmChordEditor
    Private m_currentForm As frmFretBoard

    Private Sub LoadScalesAndChords()

        Dim xDoc As New Xml.XmlDocument
        xDoc.Load("Scales.xml")

        Dim xmlScales As Xml.XmlNodeList = xDoc.SelectNodes("SCALES/SCALE")

        Dim i As Integer = 0
        For Each n As Xml.XmlNode In xmlScales
            Dim scale As New Scale
            scale.Category = n.SelectSingleNode("CATEGORY").InnerText
            scale.Name = n.SelectSingleNode("NAME").InnerText
            Dim intervals() As String = n.SelectSingleNode("INTERVALS").InnerText.Split(",")
            scale.Intervals.AddRange(intervals)
            scale.BlueNotes.AddRange(n.SelectSingleNode("BLUE_NOTES").InnerText.Split(","))
            scale.ChordColor = Color.LightGreen
            scale.ID = i
            i += 1


            Me.m_scales.Add(scale)
        Next


        xmlScales = xDoc.SelectNodes("SCALES/CHORD")

        For Each n As Xml.XmlNode In xmlScales
            Dim scale As New Scale
            scale.Name = n.SelectSingleNode("NAME").InnerText
            Dim intervals() As String = n.SelectSingleNode("INTERVALS").InnerText.Split(",")
            scale.Intervals.AddRange(intervals)
            scale.ChordColor = Color.Yellow

            Me.m_chords.Add(scale)
        Next

    End Sub

    Private Sub FillScaleList(ByVal category As String)
        Me.lstScales.Items.Clear()
        For Each s As Scale In Me.m_scales
            If s.Category = category Or category = "All" Then
                Me.lstScales.Items.Add(s)
            End If
        Next
    End Sub
    Private Sub InitListBoxes()
        For Each sc As Scale In Me.m_scales
            If Not Me.lstCategory.Items.Contains(sc.Category) Then
                Me.lstCategory.Items.Add(sc.Category)
            End If
        Next

        Me.lstChordType.DataSource = Me.m_chords
        Me.lstChordType.DisplayMember = "Name"

        Me.lstScales.DisplayMember = "Name"

        Me.lstChords.DisplayMember = "ChordName"

    End Sub
    Public Sub SelectForm(ByVal f As frmFretBoard)

        Exit Sub


        m_currentForm = f

        If f.Scales.Count > 0 Then

            Me.lstCategory.SelectedIndex = Me.lstCategory.Items.IndexOf(f.Scales(0).Category)
            Me.lstScales.SelectedIndex = Me.lstScales.Items.IndexOf(f.Scales(0))
            'Me.lstRoot.SelectedIndex = Me.lstRoot.Items.IndexOf(f.Scales(0).ScaleNotes(0).Note.ToString)
            'Debug.Print(f.Scales(0).ScaleNotes(0).Note.ToString)


        End If

        Me.lstChords.Items.Clear()
        For Each s As Scale In f.Chords
            Me.lstChords.Items.Add(s)
        Next


        Me.chkShowAll.Checked = f.DisplayAll


    End Sub
    Private Sub lstCategory_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstCategory.SelectedIndexChanged
        Call Me.FillScaleList(Me.lstCategory.SelectedItem)
    End Sub

    Private Sub frmMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Call Me.LoadScalesAndChords()
        Call Me.InitListBoxes()

        m_scaleEditor = New frmScaleEditor(Me.m_scales)
        m_chordEditor = New frmChordEditor(Me.m_chords)

        Dim ff As New frmFretBoard(m_scaleEditor, m_chordEditor)

        ff.MdiParent = Me
        ff.Visible = True

        'ff = New frmFretBoard
        'ff.MdiParent = Me
        'ff.Visible = True



        'Dim ff As New Form1

        'ff.MdiParent = Me
        'ff.Visible = True

        'ff = New Form1
        'ff.MdiParent = Me
        'ff.Visible = True
    End Sub

    Private Sub lstScales_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstScales.SelectedIndexChanged
        If Me.lstRoot.SelectedIndex = -1 Then
            Me.lstRoot.SelectedIndex = 0
        End If
        If Me.m_currentForm IsNot Nothing Then
            Me.m_currentForm.Scales.Clear()
            Dim s As Scale = lstScales.SelectedItem
            If s IsNot Nothing Then
                s.CalculateNotes([Enum].Parse(GetType(Notes), Me.lstRoot.SelectedItem))
                Me.m_currentForm.Scales.Add(s)
                Me.m_currentForm.CalculateBoard()
            End If
        End If

    End Sub

    Private Sub chkShowAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkShowAll.CheckedChanged
        If Me.m_currentForm IsNot Nothing Then
            Me.m_currentForm.DisplayAll = Me.chkShowAll.Checked
        End If
    End Sub

    Private Sub Harmonize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim a As ArrayList = Me.m_currentForm.Scales(0).GetChords
        Me.ListBox1.DataSource = a

    End Sub

    Private Sub cmdNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNew.Click
        Dim ff As New frmFretBoard(m_scaleEditor, m_chordEditor)

        ff.MdiParent = Me
        ff.Visible = True
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If Me.lstChordRoot.SelectedIndex = -1 Then
            Me.lstChordRoot.SelectedIndex = 0
        End If


        For Each item As Scale In Me.lstChordType.SelectedItems

            Dim newScale As New Scale
            newScale.Intervals = item.Intervals
            newScale.ChordName = Me.lstChordRoot.SelectedItem & " " & item.ScaleName
            newScale.CalculateNotes([Enum].Parse(GetType(Notes), Me.lstChordRoot.SelectedItem))
            newScale.ChordColor = Color.Yellow

            Me.m_currentForm.Chords.Add(newScale)


            Me.lstChords.Items.Add(newScale)

        Next

        Me.m_currentForm.CalculateBoard()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim a As New ArrayList
        For Each item As Scale In Me.lstChords.SelectedItems
            a.Add(item)
        Next

        For Each item As Scale In a
            If Me.m_currentForm.Chords.Contains(item) Then
                Me.m_currentForm.Chords.Remove(item)
            End If
            Me.lstChords.Items.Remove(item)
        Next
        Me.m_currentForm.CalculateBoard()
    End Sub


    Private Sub lstChords_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lstChords.KeyDown
        If e.KeyCode = Keys.Delete Then
            Dim a As New ArrayList
            For Each item As Scale In Me.lstChords.SelectedItems
                a.Add(item)
            Next

            For Each item As Scale In a
                If Me.m_currentForm.Chords.Contains(item) Then
                    Me.m_currentForm.Chords.Remove(item)
                End If
                Me.lstChords.Items.Remove(item)
            Next
        End If

        Me.m_currentForm.CalculateBoard()
    End Sub


    Private Sub lstChordRoot_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lstChordRoot.SelectedIndexChanged

    End Sub

    Private Sub ToolStripButton1_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton1.Click
        cmdNew.PerformClick()
    End Sub

    Private Sub cmdDisplayAll_Click(sender As System.Object, e As System.EventArgs)

    End Sub
End Class