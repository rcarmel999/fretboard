Imports System.Windows
Public Class frmDisplaySettings
    Private m_chords As New List(Of Scale)
    Private m_boardChords As List(Of Scale)
    Private m_fretBoard As frmFretBoard

    Public Overloads Function ShowDialog(owner As System.Windows.Forms.IWin32Window, chrds As List(Of Scale), frm As frmFretBoard) As System.Windows.Forms.DialogResult
        m_boardChords = chrds
        m_fretBoard = frm

        'lstChords.Items.Clear()
        'For Each s As Scale In m_boardChords
        '    lstChords.Items.Add(s)
        'Next


        Return Me.ShowDialog(owner)

    End Function

    Private Sub frmDisplaySettings_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        m_fretBoard.StartFret = Me.txtStartFret.Text
        m_fretBoard.EndFret = Me.txtEndFret.Text

    End Sub
End Class