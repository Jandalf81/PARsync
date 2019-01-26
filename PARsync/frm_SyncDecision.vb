Public Class frm_SyncDecision
    Public Enum syncDecisionResult
        test
        useLocalRating
        useRemoteRating
        Cancel
    End Enum

    Private Sub btn_UseLocalRating_Click(sender As Object, e As EventArgs) Handles btn_UseLocalRating.Click
        Me.DialogResult = syncDecisionResult.useLocalRating
    End Sub

    Private Sub btn_UseRemoteRating_Click(sender As Object, e As EventArgs) Handles btn_UseRemoteRating.Click
        Me.DialogResult = syncDecisionResult.useRemoteRating
    End Sub

    Private Sub btn_Cancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
        Me.DialogResult = syncDecisionResult.Cancel
    End Sub

    Private Sub frm_SyncDecision_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            Me.DialogResult = syncDecisionResult.Cancel
        End If
    End Sub
End Class