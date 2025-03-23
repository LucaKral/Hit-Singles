﻿Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Artist, Song As String
        Dim FileNum As Integer = FreeFile() 'find availabe file number
        FileOpen(FileNum, "Hit Singles.txt", OpenMode.Input) 'open file
        Do Until EOF(FileNum) 'read until end of the file
            Artist = LineInput(FileNum) 'read artist name
            lstArtists.Items.Add(Artist) 'add to list
            Song = LineInput(FileNum) 'read song name
            lstSongs.Items.Add(Song) 'add to list
        Loop
        FileClose(FileNum)
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim MatchFound As Boolean = False
        Dim Last As Integer = lstArtists.Items.Count - 1
        Dim I As Integer = 0
        Dim ThisItem As String = ""
        If txtSearch.Text > "" Then 'must have something to find
            lblSong.Text = ""
            picCover.Image = Nothing
            Do
                'check for a match in this list item
                ThisItem = CStr(lstArtists.Items.Item(I))
                If ThisItem.IndexOf(txtSearch.Text) > -1 Then
                    MatchFound = True
                    lstArtists.SelectedIndex = I 'highlight the match
                End If
                I += 1 'next item
            Loop Until I > Last Or MatchFound
            If Not MatchFound Then
                lstArtists.SelectedIndex -= 1 'nothing selected
                btnShow.Enabled = False
            Else
                btnShow.Enabled = True
            End If
        Else
            lstArtists.SelectedIndex = -1 'nothing selected
            btnShow.Enabled = False
        End If
    End Sub
End Class
