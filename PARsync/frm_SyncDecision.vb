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
            lbl_Track_Track.Text = track._track
            lbl_Track_Title.Text = track._title

            lbl_Track_LocalPath.Text = track._localPath
            lbl_Track_RemotePath.Text = track._remotePath

            Dim coverPath As String
            coverPath = track._localPath.Remove(track._localPath.LastIndexOf("\")) & "\folder.jpg"
            If (My.Computer.FileSystem.FileExists(coverPath)) Then
                pic_Cover.Image = Image.FromFile(coverPath)
            Else
                'TODO set default image here
            End If

            btn_UseTagRating.Image = track._TagRatingImage
            btn_UsePowerampRating.Image = track._PowerampRatingImage
        End Set
    End Property



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

    Private Sub frm_SyncDecision_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        'MsgBox("Modal: " + Me.Modal.ToString)
    End Sub

#Region "Buttons"
    Private Sub btn_UseTagRating_Click(sender As Object, e As EventArgs) Handles btn_UseTagRating.Click
        Me.DialogResult = syncDecisionResult.useTagRating
    End Sub
    Private Sub btn_UseTagRating_MouseEnter(sender As Object, e As EventArgs) Handles _
            btn_UseTagRating.MouseEnter,
            btn_UseTagRating.GotFocus
        pic_syncMode.Image = My.Resources.arrow_right
    End Sub

    Private Sub btn_UsePowerampRating_Click(sender As Object, e As EventArgs) Handles btn_UsePowerampRating.Click
        Me.DialogResult = syncDecisionResult.usePowerampRating
    End Sub
    Private Sub btn_UsePowerampRating_MouseEnter(sender As Object, e As EventArgs) Handles _
            btn_UsePowerampRating.MouseEnter,
            btn_UsePowerampRating.GotFocus
        pic_syncMode.Image = My.Resources.arrow_left
    End Sub

    Private Sub btn_Cancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
        Me.DialogResult = syncDecisionResult.Cancel
    End Sub
    Private Sub btn_Cancel_MouseEnter(sender As Object, e As EventArgs) Handles _
            btn_Cancel.MouseEnter,
            btn_Cancel.GotFocus
        pic_syncMode.Image = My.Resources.cancel
    End Sub

    Private Sub btn_SyncDecision_MouseLeave(sender As Object, e As EventArgs) Handles _
            btn_UseTagRating.MouseLeave,
            btn_UsePowerampRating.MouseLeave,
            btn_Cancel.MouseLeave
        pic_syncMode.Image = My.Resources.toSync
    End Sub
#End Region
End Class