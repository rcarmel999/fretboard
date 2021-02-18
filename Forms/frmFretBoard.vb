Public Class frmFretBoard
    Private m_board As New FretBoard

    Private m_scales As New List(Of Scale)
    Private m_chords As New List(Of Scale)
    Private m_scaleEditor As frmScaleEditor
    Private m_chordEditor As frmChordEditor
    Private m_bDisplayAll As Boolean = False

    Private m_startFret As Integer = 0
    Public Property StartFret() As Integer
        Get
            Return m_startFret
        End Get
        Set(ByVal value As Integer)
            m_startFret = value
        End Set
    End Property

    Private m_endFret As Integer = 22
    Public Property EndFret() As Integer
        Get
            Return m_endFret
        End Get
        Set(ByVal value As Integer)
            m_endFret = value
        End Set

    End Property





    Public Sub CalculateBoard()
        Me.m_board.CalculateScales(Me.m_scales, Me.m_chords, m_bDisplayAll)
        Me.pnlBoard.Invalidate()


    End Sub
    Private Sub pnlFretMarkers_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles pnlFretMarkers.Paint
        Dim x As Integer = 0
        Dim y As Integer = 0



        x = Me.pnlBoard.Width / 23
        For j As Integer = 0 To 22
            'e.Graphics.DrawString(j +1, Me.pnlBoard.Font, Brushes.Black, x, 0)

            Dim size As SizeF = e.Graphics.MeasureString(j, Me.pnlBoard.Font)
            Dim l As Integer = size.Width / 2
            Dim fheight = size.Height / 2

            e.Graphics.DrawString(j, Me.pnlBoard.Font, Brushes.Black, x - (Me.pnlBoard.Width / 23 / 2) - l, 0) ' y - fheight)


            x += Me.pnlBoard.Width / 23


        Next
    End Sub

    Private Sub pnlBoard_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles pnlBoard.MouseClick
        Dim x As Integer = (pnlBoard.Width \ 23)


        Dim y As Integer = (pnlBoard.Height \ 6)

        Dim xPos As Integer
        Dim yPos As Integer
        
        xPos = CType((e.X \ x), Integer)
            
        yPos = CType(e.Y \ y, Integer)



        'Me.Text = e.X & ", " & yPos
        Dim f As Fret = Me.m_board.Board(yPos)(xPos)

        f.Color = Color.Blue

        pnlBoard.Invalidate()


        'For Each sc As Scale In Scales
        '    Dim scn As ScaleNote = sc.GetScaleNote(f.Note)
        '    If scn IsNot Nothing Then

        '    End If

        'Next


        'Me.m_board.CalculateBoard()


    End Sub
    Private Sub pnlBoard_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles pnlBoard.Paint
        Dim rm As New Resources.ResourceManager("RNC.Fretboard.Resources", System.Reflection.Assembly.GetExecutingAssembly())


        Dim img As System.Drawing.Image = rm.GetObject("wood_2")



        Dim p As New Point(0, 0)



        e.Graphics.DrawImage(img, 0, 0, Me.pnlBoard.Width, Me.pnlBoard.Height)



        Dim x As Integer = 0
        Dim y As Integer = 0

        ' Draw Frets?
        Dim pp As New Pen(Color.Gray)
        x = Me.pnlBoard.Width / 23
        For j As Integer = 0 To 22
            pp.Color = Color.Gray
            pp.Width = 2
            e.Graphics.DrawLine(pp, x, 0, x, Me.pnlBoard.Height)
            pp.Width = 1
            pp.Color = Color.White
            e.Graphics.DrawLine(pp, x, 0, x, Me.pnlBoard.Height)
            x += Me.pnlBoard.Width / 23
        Next


        ' Draw horozontal lines
        pp.Color = Color.LightGray
        pp.Width = 2
        y = Me.pnlBoard.Height / 6 / 2
        x = Me.pnlBoard.Width / 23
        For i As Integer = 0 To 5
            e.Graphics.DrawLine(pp, x, y, Me.pnlBoard.Width, y)
            y += Me.pnlBoard.Height / 6
        Next

        pp.Dispose()

        y = 0

        Dim fnt As System.Drawing.Font = Me.pnlBoard.Font

        Dim intFnt As System.Drawing.Font = New Font(Me.pnlBoard.Font.FontFamily, 8, FontStyle.Italic)




        ' Draw notes?
        y = Me.pnlBoard.Height / 6 / 2
        For i As Integer = 0 To 5

            x = Me.pnlBoard.Width / 23
            For j As Integer = 0 To 22
                Dim f As Fret = Me.m_board.Board(i)(j)
                If f.Visible And j >= m_startFret And j <= m_endFret Then


                    Dim value As String = f.Note.ToString
                    Dim size As SizeF = e.Graphics.MeasureString(value, fnt)
                    Dim l As Integer = size.Width / 2
                    Dim fheight = size.Height / 2

                    Dim b As New SolidBrush(f.Color)
                    e.Graphics.FillEllipse(b, New Rectangle(x - (Me.pnlBoard.Width / 23 / 2) - 12, y - 12, 24, 24))
                    If f.Color <> Color.Transparent Then
                        e.Graphics.DrawEllipse(Pens.Black, New Rectangle(x - (Me.pnlBoard.Width / 23 / 2) - 12, y - 12, 24, 24))
                    End If
                    e.Graphics.DrawString(f.Note.ToString, fnt, Brushes.Black, x - (Me.pnlBoard.Width / 23 / 2) - l, y - fheight)
                    If f.IntervalLabel <> String.Empty Then
                        Dim tsize As SizeF = e.Graphics.MeasureString(f.IntervalLabel, intFnt)
                        Dim xt As Int16 = x - (Me.pnlBoard.Width / 23 / 2) - 12
                        xt = (xt - (tsize.Width)) + 2

                        Dim yt As Int16 = y - fheight
                        yt = yt - ((tsize.Height / 2))

                        e.Graphics.DrawString(f.IntervalLabel, intFnt, Brushes.Black, xt, yt)

                    End If


                    b.Dispose()
                End If
                x += Me.pnlBoard.Width / 23
            Next
            y += (Me.pnlBoard.Height / 6)
        Next

        intFnt.Dispose()

    End Sub

    Private Sub frmFretBoard_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        CType(Me.MdiParent, frmMain).SelectForm(Me)
    End Sub

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        m_board.CalculateBoard()
        Dim i As Integer = 0

        
        Me.Text = "Fretboard "




    End Sub

  


    Private Sub frmFretBoard_ResizeEnd(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ResizeEnd
        Me.pnlBoard.Invalidate()
        Me.pnlFretMarkers.Invalidate()

    End Sub




#Region " Properties "
    Public ReadOnly Property Scales() As List(Of Scale)
        Get
            Return m_scales
        End Get
    End Property

    Public ReadOnly Property Chords() As List(Of Scale)
        Get
            Return m_chords
        End Get
    End Property

    Public Property DisplayAll() As Boolean
        Get
            Return Me.m_bDisplayAll
        End Get
        Set(ByVal value As Boolean)
            Me.m_bDisplayAll = value
            Call Me.CalculateBoard()
        End Set
    End Property
#End Region


    Private Sub mnuScales_Click(sender As Object, e As System.EventArgs) Handles mnuScales.Click
        m_scaleEditor.ShowDialog(Owner, Me.m_scales, Me)

    End Sub

    Public Sub New(frmSE As frmScaleEditor, frmCE As frmChordEditor)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        m_scaleEditor = frmSE
        m_chordEditor = frmCE

    End Sub

    Private Sub mnuDisplay_Click(sender As System.Object, e As System.EventArgs) Handles mnuDisplay.Click
        Dim f As New frmDisplaySettings
        f.txtStartFret.Text = Me.StartFret
        f.txtEndFret.Text = Me.EndFret

        f.ShowDialog(Me, Nothing, Me)



    End Sub

    Private Sub mnuChords_Click(sender As System.Object, e As System.EventArgs) Handles mnuChords.Click
        m_chordEditor.ShowDialog(Owner, Me.m_chords, Me)
    End Sub

    Private Sub cmdDisplayAll_Click(sender As System.Object, e As System.EventArgs) Handles cmdDisplayAll.Click
        Me.DisplayAll = Not DisplayAll


    End Sub
End Class