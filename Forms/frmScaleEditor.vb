Public Class frmScaleEditor
    Private m_scales As New List(Of Scale)
    Private m_boardScales As List(Of Scale)
    Private m_fretBoard As frmFretBoard



    Public Sub New(sc As List(Of Scale))
        Me.InitializeComponent()

        Me.lstBoardScales.DisplayMember = "Name"
        m_scales = sc

        InitListBoxes()

    End Sub

    Public Overloads Function ShowDialog(owner As System.Windows.Forms.IWin32Window, sc As List(Of Scale), frm As frmFretBoard) As System.Windows.Forms.DialogResult
        m_boardScales = sc
        m_fretBoard = frm

        lstBoardScales.Items.Clear()
        For Each s As Scale In m_boardScales
            lstBoardScales.Items.Add(s)
        Next


        Return Me.ShowDialog(owner)

    End Function
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

        
        Me.lstScales.DisplayMember = "Name"

        'Me.lstChords.DisplayMember = "ChordName"

    End Sub

    Private Sub lstCategory_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstCategory.SelectedIndexChanged
        Call Me.FillScaleList(Me.lstCategory.SelectedItem)
    End Sub

    Private Sub cmdRemove_Click(sender As System.Object, e As System.EventArgs) Handles cmdRemove.Click

        RemoveScale()

    End Sub
    Private Sub RemoveScale()
        If lstBoardScales.SelectedIndex = -1 Then
            If lstBoardScales.Items.Count > 0 Then
                lstBoardScales.SelectedIndex = 0
            Else
                Exit Sub
            End If
        End If

        Me.m_boardScales.Remove(lstBoardScales.SelectedItem)
        Me.lstBoardScales.Items.Remove(lstBoardScales.SelectedItem)
        m_fretBoard.CalculateBoard()

    End Sub
    Private Sub cmdAdd_Click(sender As System.Object, e As System.EventArgs) Handles cmdAdd.Click
        Call AddScale()

    End Sub

    Private Sub AddScale()
        If Me.lstRoot.SelectedIndex = -1 Then
            Me.lstRoot.SelectedIndex = 0
        End If
        ' If Me.m_currentForm IsNot Nothing Then
        'Me.m_currentForm.Scales.Clear()
        Dim ss As Scale = lstScales.SelectedItem
        Dim s As New Scale()
        s.Intervals.AddRange(ss.Intervals)

        s.OverrideScaleColor = True
        s.ScaleColor = cmdColor.BackColor
        If s IsNot Nothing Then
            s.CalculateNotes([Enum].Parse(GetType(Notes), Me.lstRoot.SelectedItem))
            s.Name = lstRoot.SelectedItem.ToString() & " " & ss.Name
            m_boardScales.Add(s)
            Me.lstBoardScales.Items.Add(s)
            m_fretBoard.CalculateBoard()
        End If
    End Sub

    Private Sub lstScales_DoubleClick(sender As Object, e As System.EventArgs) Handles lstScales.DoubleClick
        Call AddScale()
    End Sub

    Private Sub lstBoardScales_DoubleClick(sender As Object, e As System.EventArgs) Handles lstBoardScales.DoubleClick
        Call RemoveScale()
    End Sub


    
    Private Sub cmdColor_Click(sender As System.Object, e As System.EventArgs) Handles cmdColor.Click
        If CD.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            CD.AnyColor = True
            cmdColor.BackColor = CD.Color

        End If
    End Sub
End Class