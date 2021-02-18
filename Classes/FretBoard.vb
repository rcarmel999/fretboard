Public Class FretBoard

    Dim m_board(5)() As Fret
    Dim m_strings(5) As Notes

    Public Sub New()
        m_strings(0) = Notes.E
        m_strings(1) = Notes.B
        m_strings(2) = Notes.G
        m_strings(3) = Notes.D
        m_strings(4) = Notes.A
        m_strings(5) = Notes.E

        For i As Integer = 0 To 5
            Me.m_board(i) = New Fret() {New Fret(), New Fret(), New Fret(), New Fret(), New Fret(), New Fret(), New Fret(), New Fret(), New Fret(), New Fret(), New Fret(), New Fret(), New Fret(), New Fret(), New Fret(), New Fret(), New Fret(), New Fret(), New Fret(), New Fret(), New Fret(), New Fret(), New Fret()}

        Next
    End Sub
    Public Sub CalculateScales(ByVal scales As List(Of Scale), ByVal chords As List(Of Scale), ByVal bDisplayAll As Boolean)
        For i As Integer = 0 To 5
            Dim note = m_strings(i)
            For j As Integer = 0 To 22
                Dim f As New Fret

                f = Me.m_board(i)(j)

                f.Visible = False
                f.Color = Color.Transparent

                If bDisplayAll Then
                    f.Visible = True
                End If

                For Each sc As Scale In scales
                    Dim scn As ScaleNote = sc.GetScaleNote(f.Note)
                    If scn IsNot Nothing Then
                        If sc.OverrideScaleColor Then
                            f.Color = sc.ScaleColor
                        Else
                            f.Color = scn.Color
                        End If
                        f.IntervalLabel = ""
                        f.Visible = True
                        Exit For
                    End If
                Next

                For Each ch As Scale In chords
                    Dim scn As ScaleNote = ch.GetScaleNote(f.Note)
                    If scn IsNot Nothing Then
                        If scn.NoteType = NoteType.ROOT Then
                            f.Color = ch.ChordRootColor

                        ElseIf scn.NoteType = NoteType.THIRD Then
                            f.Color = ch.Chord3rdColor

                        ElseIf scn.NoteType = NoteType.FIFTH Then
                            f.Color = ch.Chord5thColor

                        ElseIf scn.NoteType = NoteType.SEVENTH Then
                            f.Color = ch.Chord7thColor

                        ElseIf scn.NoteType = NoteType.NINTH Then
                            f.Color = ch.Chord9thColor
                        ElseIf scn.NoteType = NoteType.THIRTEENTH Then
                            f.Color = ch.Chord13thColor
                        Else
                            f.Color = scn.Color
                        End If

                        f.IntervalLabel = scn.IntervalName

                        f.Visible = True
                    End If
                Next

            Next
        Next


    End Sub

    Public Sub CalculateBoard()

        For i As Integer = 0 To 5
            Dim note = m_strings(i)
            For j As Integer = 0 To 22
                Dim f As New Fret
                f.Note = note
                f.Color = Color.Black
                Me.m_board(i)(j) = f

                note += 1
                If note Mod 12 = 0 Then
                    note = 0
                End If

            Next
        Next

    End Sub

#Region " Properties "
    Public ReadOnly Property Board() As Fret()()
        Get
            Return m_board
        End Get

    End Property

#End Region


End Class



Public Class Fret
    Dim m_note As Notes
    Dim m_color As System.Drawing.Color
    Dim m_visible As Boolean = False


#Region " Properties "
    Public Property Note() As Notes
        Get
            Return m_note
        End Get
        Set(ByVal Value As Notes)
            m_note = Value
        End Set
    End Property

    Public Property Color() As System.Drawing.Color
        Get
            Return m_color
        End Get
        Set(ByVal Value As System.Drawing.Color)
            m_color = Value
        End Set
    End Property

    Public Property Visible() As Boolean
        Get
            Return m_visible
        End Get
        Set(ByVal Value As Boolean)
            m_visible = Value
        End Set
    End Property

    Private m_intervalLabel As String
    Public Property IntervalLabel() As String
        Get
            Return m_intervalLabel
        End Get
        Set(ByVal value As String)
            m_intervalLabel = value
        End Set
    End Property




#End Region
End Class








Public Enum NoteType
    SCALE
    ROOT
    BLUE
    THIRD
    FIFTH
    SEVENTH
    NINTH
    THIRTEENTH

End Enum

Public Class ScaleNote
    Public Note As Notes
    Public NoteType As NoteType
    Public Color As System.Drawing.Color
    Public IntervalName As String


    Public Sub New(ByVal n As Notes, ByVal type As NoteType, intervalName As String)
        Me.Note = n
        Me.NoteType = type
        Me.IntervalName = intervalName
        Select Case type
            Case RNC.Fretboard.NoteType.BLUE
                Me.Color = Drawing.Color.LightBlue
            Case RNC.Fretboard.NoteType.ROOT
                Me.Color = Drawing.Color.LightPink
            Case RNC.Fretboard.NoteType.SCALE
                Me.Color = Drawing.Color.LightGreen
            Case RNC.Fretboard.NoteType.THIRD, RNC.Fretboard.NoteType.FIFTH, RNC.Fretboard.NoteType.SEVENTH
                Me.Color = Drawing.Color.Yellow
        End Select
    End Sub
End Class
Public Enum Notes
    C
    Db
    D
    Eb
    E
    F
    Gb
    G
    Ab
    A
    Bb
    B
End Enum
Public Class Scale

#Region " Members "
    Public ScaleNotes As New List(Of ScaleNote)
    Public Intervals As New List(Of String)
    Public ScaleName As String
    Public BlueNotes As New List(Of String)
    Private m_intervals As New Hashtable
    Private m_category As String
    Private m_scaleID As Integer
    Private m_chordName As String
    Public ChordColor As System.Drawing.Color
    Public ChordRootColor As System.Drawing.Color
    Public Chord3rdColor As System.Drawing.Color
    Public Chord5thColor As System.Drawing.Color
    Public Chord7thColor As System.Drawing.Color
    Public Chord9thColor As System.Drawing.Color
    Public Chord13thColor As System.Drawing.Color
    Public ScaleColor As System.Drawing.Color
    Public OverrideScaleColor As Boolean = False
#End Region


#Region " Properties "
    Public Property ChordName() As String
        Get
            Return Me.m_chordName
        End Get
        Set(ByVal value As String)
            Me.m_chordName = value
        End Set
    End Property

    Public Property ID() As Integer
        Get
            Return Me.m_scaleID
        End Get
        Set(ByVal value As Integer)
            Me.m_scaleID = value
        End Set
    End Property
    Public Property Name() As String
        Get
            Return ScaleName
        End Get
        Set(ByVal value As String)
            ScaleName = value
        End Set
    End Property

    Public Property Category() As String
        Get
            Return Me.m_category
        End Get
        Set(ByVal value As String)
            Me.m_category = value
        End Set
    End Property
#End Region

    Public Sub New()
        ' Convert interval to semitones
        m_intervals("1") = 0 ' C
        m_intervals("2b") = 1
        m_intervals("2") = 2 ' D
        m_intervals("3b") = 3
        m_intervals("3") = 4 'E
        m_intervals("4") = 5 'F
        m_intervals("5b") = 6
        m_intervals("5") = 7 ' G
        m_intervals("6b") = 8
        m_intervals("6") = 9 ' A
        m_intervals("7b") = 10
        m_intervals("7") = 11 ' B

        m_intervals("8") = 12 ' C
        m_intervals("9b") = 13
        m_intervals("9") = 14 ' D
        m_intervals("10b") = 15
        m_intervals("10") = 16 'E
        m_intervals("11") = 17 'F
        m_intervals("12b") = 18 ' 
        m_intervals("12") = 19 'G
        m_intervals("13b") = 20
        m_intervals("13") = 21 ' A
        m_intervals("14b") = 22
        m_intervals("14") = 23 'B



    End Sub

    Public Sub CalculateNotes(ByVal rootNote As Notes)
        ScaleNotes.Clear()
        ScaleNotes.Add(New ScaleNote(rootNote, NoteType.ROOT, Intervals(0)))


        For i As Integer = 1 To Intervals.Count - 1
            Dim note As Notes = rootNote
            Dim interval As Integer = m_intervals(Intervals(i))


            If note + interval > 11 Then
                'Dim dif As Integer = 11 - note + 1
                'note = Notes.C
                'note += interval - dif
                note = ((interval + note) Mod 12)
            Else
                note += interval
            End If

            Dim sNote As ScaleNote = Nothing

            Select Case Intervals(i)
                Case "3", "3b"
                    sNote = New ScaleNote(note, NoteType.THIRD, Intervals(i))
                Case "5"
                    sNote = New ScaleNote(note, NoteType.FIFTH, Intervals(i))
                Case "7", "7b"
                    sNote = New ScaleNote(note, NoteType.SEVENTH, Intervals(i))
                Case "13"
                    sNote = New ScaleNote(note, NoteType.THIRTEENTH, Intervals(i))
                Case "9"
                    sNote = New ScaleNote(note, NoteType.NINTH, Intervals(i))
                Case Else
                    If Me.BlueNotes.Contains(Intervals(i)) Then
                        sNote = New ScaleNote(note, NoteType.BLUE, Intervals(i))
                    Else
                        sNote = New ScaleNote(note, NoteType.SCALE, Intervals(i))
                    End If

            End Select
            'If Me.BlueNotes.Contains(Intervals(i)) Then
            '    sNote = New ScaleNote(note, NoteType.BLUE)
            'ElseIf interval = 3 Then

            'ElseIf interval = 5 Then
            '    sNote = New ScaleNote(note, NoteType.FIFTH)
            'ElseIf interval = 7 Then
            '    sNote = New ScaleNote(note, NoteType.BLUE)
            'Else

            '    sNote = New ScaleNote(note, NoteType.SCALE)
            'End If
            ScaleNotes.Add(sNote)
        Next
    End Sub

    Public Function GetScaleNote(ByVal value As Notes) As ScaleNote
        For Each n As ScaleNote In Me.ScaleNotes
            If n.Note = value Then
                Return n
            End If
        Next

        Return Nothing
    End Function

    Public Function GetChords() As ArrayList
        Dim a As New ArrayList

   

        For j As Integer = 0 To Me.ScaleNotes.Count - 1

            Dim note As Notes = Me.ScaleNotes(j).Note
            Dim chordName As String = note.ToString
            Dim flatFive As String = String.Empty


            For i As Integer = 3 + j To 13 + j Step 2
                Dim iNote As Integer = 0
                iNote = (i - 1) Mod Me.ScaleNotes.Count

                Dim nextNote As Notes = Me.ScaleNotes(iNote).Note

                Dim interval As Integer = 0
                If nextNote > note Then
                    interval = nextNote - note
                ElseIf nextNote < note Then
                    interval = nextNote - note + 12
                End If


                Select Case i - j
                    Case 3
                        If interval = 3 Then
                            chordName &= "Min"
                        End If
                    Case 5
                        Select Case interval
                            Case 6
                                flatFive = "b5"
                            Case 8
                                flatFive = "#5"

                        End Select
                    Case 7
                        Select Case interval
                            Case 10
                                chordName &= "7"
                            Case 9
                                chordName &= "Min7"
                            Case 11
                                chordName &= "Maj7"
                        End Select

                        chordName &= flatFive
                    Case 9
                        Select Case interval
                            Case 3 '15
                                chordName &= "#9"
                            Case 1 '13
                                chordName &= "b9"
                        End Select

                    Case 11
                        Select Case interval
                            Case 6 '18
                                chordName &= "#11"
                            Case 4 '16
                                chordName &= "b11"
                        End Select


                    Case 13
                        Select Case interval
                            Case 8 '20
                                chordName &= "b13"
                            Case 10 ' 22
                                chordName &= "#13"
                        End Select

                End Select

            Next
            a.Add(chordName)
        Next j


        Return a

    End Function

    

End Class