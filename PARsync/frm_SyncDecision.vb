Imports PARsync

Public Class frm_SyncDecision
    Public Enum syncDecisionResult
        thisDoesNotWork
        useTagRating
        usePowerampRating
        Cancel
    End Enum

    Private track As Track
    Public Property _track As Track
        Get
            Return track
        End Get
        Set(value As Track)
            track = value

            ' set the control elements
            lbl_Track_Artist.Text = track._artist
            lbl_Track_Album.Text = track._album
            lbl_Track_Track.Text = track._trackno
            lbl_Track_Title.Text = track._track

            lbl_Track_LocalPath.Text = track._localPath
            lbl_Track_RemotePath.Text = track._remotePath

            Dim coverPath As String
            coverPath = track._localPath.Remove(track._localPath.LastIndexOf("\")) & "\folder.jpg"
            If (My.Computer.FileSystem.FileExists(coverPath)) Then
                pic_Cover.Image = Image.FromFile(coverPath)
            Else
                'TODO set default image here
            End If

            btn_UseLocalRating.Image = track._localRatingImage
            btn_UseRemoteRating.Image = track._remoteRatingImage
        End Set
    End Property

    Private Sub btn_UseLocalRating_Click(sender As Object, e As EventArgs) Handles btn_UseLocalRating.Click
        Me.DialogResult = syncDecisionResult.useTagRating
    End Sub

    Private Sub btn_UseRemoteRating_Click(sender As Object, e As EventArgs) Handles btn_UseRemoteRating.Click
        Me.DialogResult = syncDecisionResult.usePowerampRating
    End Sub

    Private Sub btn_Cancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
        Me.DialogResult = syncDecisionResult.Cancel
    End Sub

    ' handle the user closing the dialog via X or ESCAPE as pushing the CANCEL button
    Private Sub frm_SyncDecision_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            Me.DialogResult = syncDecisionResult.Cancel
        End If
    End Sub

    Private Sub frm_SyncDecision_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
        ' TODO needs a new location on resize
        pic_Cover.Size = New Size(pic_Cover.Size.Height, pic_Cover.Size.Height)
    End Sub
End Class