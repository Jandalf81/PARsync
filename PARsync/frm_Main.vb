Imports System.ComponentModel

Public Class frm_Main
    Public listOfTracks As New Tracklist()
    Public settings As New Settings()
    Public WithEvents bs As New BindingSource()

#Region "onLoad"
    Private Sub frm_Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' TODO remove this setting
        'System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = False

        settings.load()
        txt_LocalMainPath.Text = settings._localMainPath
        txt_RemoteMainPath.Text = settings._remoteMainPath
        Select Case settings._syncMode
            Case Settings.syncModeEnum.askUser
                rad_SyncMode_AskUser.Checked = True
                rad_SyncMode_UseLocalRating.Checked = False
                rad_SyncMode_UseRemoteRating.Checked = False
            Case Settings.syncModeEnum.useTagRating
                rad_SyncMode_AskUser.Checked = False
                rad_SyncMode_UseLocalRating.Checked = True
                rad_SyncMode_UseRemoteRating.Checked = False
            Case Settings.syncModeEnum.usePowerampRating
                rad_SyncMode_AskUser.Checked = False
                rad_SyncMode_UseLocalRating.Checked = False
                rad_SyncMode_UseRemoteRating.Checked = True
        End Select

        tst_NoOfTracks.Text = "Number of Tracks: 0"
        tst_Status.Text = "| Status: Idle"

        Me.dgv_Tracklist.ReadOnly() = True
        Me.dgv_Tracklist.AllowUserToAddRows = False
        Me.dgv_Tracklist.AutoGenerateColumns = False
        Me.dgv_Tracklist.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        Me.dgv_Tracklist.RowHeadersVisible = False

        Me.bs.DataSource = listOfTracks.tracks
        Me.dgv_Tracklist.DataSource = Me.bs

        ' prepare columns for DataGridView
        Dim col_Artist As New DataGridViewTextBoxColumn()
        col_Artist.DataPropertyName = "_artist"
        col_Artist.Name = "Artist"

        Dim col_Album As New DataGridViewTextBoxColumn()
        col_Album.DataPropertyName = "_album"
        col_Album.Name = "Album"

        Dim col_Trackno As New DataGridViewTextBoxColumn()
        col_Trackno.DataPropertyName = "_trackno"
        col_Trackno.Name = "#"

        Dim col_Track As New DataGridViewTextBoxColumn()
        col_Track.DataPropertyName = "_track"
        col_Track.Name = "Track"

        Dim col_LocalRating As New DataGridViewTextBoxColumn()
        col_LocalRating.DataPropertyName = "_localRating"
        col_LocalRating.Name = "local" + vbCrLf + "Rating"

        Dim col_LocalRatingImage As New DataGridViewImageColumn()
        col_LocalRatingImage.DataPropertyName = "_localRatingImage"
        col_LocalRatingImage.Name = "local" + vbCrLf + "Rating"

        Dim col_RemoteRating As New DataGridViewTextBoxColumn()
        col_RemoteRating.DataPropertyName = "_remoteRating"
        col_RemoteRating.Name = "remote" + vbCrLf + "Rating"

        Dim col_RemoteRatingImage As New DataGridViewImageColumn()
        col_RemoteRatingImage.DataPropertyName = "_remoteRatingImage"
        col_RemoteRatingImage.Name = "remote" + vbCrLf + "Rating"

        Dim col_LocalPath As New DataGridViewTextBoxColumn()
        col_LocalPath.DataPropertyName = "_localPath"
        col_LocalPath.Name = "local" + vbCrLf + "Path"

        Dim col_RemotePath As New DataGridViewTextBoxColumn()
        col_RemotePath.DataPropertyName = "_remotePath"
        col_RemotePath.Name = "remote" + vbCrLf + "Path"

        Dim col_TrackImage As New DataGridViewImageColumn()
        col_TrackImage.DataPropertyName = "_trackImage"
        col_TrackImage.Name = "Status"

        ' add prepared columns to DataGridView
        dgv_Tracklist.Columns.Add(col_TrackImage)
        dgv_Tracklist.Columns.Add(col_Artist)
        dgv_Tracklist.Columns.Add(col_Album)
        dgv_Tracklist.Columns.Add(col_Trackno)
        dgv_Tracklist.Columns.Add(col_Track)
        dgv_Tracklist.Columns.Add(col_LocalRating)
        dgv_Tracklist.Columns.Add(col_LocalRatingImage)
        dgv_Tracklist.Columns.Add(col_RemoteRating)
        dgv_Tracklist.Columns.Add(col_RemoteRatingImage)
        dgv_Tracklist.Columns.Add(col_LocalPath)
        dgv_Tracklist.Columns.Add(col_RemotePath)

        dgv_Tracklist.Columns.Item(0).Width = 45

        ' disable some control elements
        grp_FilterDGV.Enabled = False
        grp_Sync.Enabled = False
        grp_Target.Enabled = False
    End Sub
#End Region

#Region "grp_Settings"
    Private Sub btn_LocalMainPath_Click(sender As Object, e As EventArgs) Handles btn_LocalMainPath.Click
        Dim result As DialogResult = fbd_LocalMainPath.ShowDialog()

        If result = DialogResult.OK Then
            txt_LocalMainPath.Text = fbd_LocalMainPath.SelectedPath
            settings._localMainPath = fbd_LocalMainPath.SelectedPath
        Else
            txt_LocalMainPath.Text = ""
            settings._localMainPath = ""
        End If
    End Sub

    Private Sub txt_RemoteMainPath_TextChanged(sender As Object, e As EventArgs) Handles txt_RemoteMainPath.TextChanged
        settings._remoteMainPath = txt_RemoteMainPath.Text
    End Sub
#End Region

#Region "grp_Source"
    Private Sub btn_OFD_Click(sender As Object, e As EventArgs) Handles btn_OFD.Click
        Dim result As DialogResult = ofd_AllTracksCSV.ShowDialog()

        If result = DialogResult.OK Then
            txt_OFD.Text = ofd_AllTracksCSV.FileName

            tst_Status.Text = "| Status: Reading CSV..."
            listOfTracks.importCSV(txt_OFD.Text)
            tst_NoOfTracks.Text = "Number of Tracks: " + listOfTracks.tracks.Count.ToString
            tst_Status.Text = "| Status: Idle"

            Me.bs.ResetBindings(False) ' refresh DataGridView bound to BindingSource

            tst_Status.Text = "| Status: getting Local Path..."
            bgw_transformLocalPath.RunWorkerAsync()
        End If
    End Sub
#End Region

#Region "grp_Sync"
    ' TODO make the DGV filter-able and sort-able
    Private Sub chk_Synced_CheckedChanged(sender As Object, e As EventArgs) Handles chk_Synced.CheckedChanged
        set_DGV_Filter()
    End Sub

    Private Sub set_DGV_Filter()
        Dim filterList As New List(Of String)
        Dim filter As String = ""

        If chk_ToRead.Checked = True Then
            filterList.Add("_trackStatus = ""toRead""")
        End If

        If chk_NotFound.Checked = True Then
            filterList.Add("_trackStatus = ""notFound""")
        End If

        If chk_ToSync.Checked = True Then
            filterList.Add("_trackStatus = ""toSync""")
        End If

        If chk_Synced.Checked = True Then
            filterList.Add("_trackStatus = ""synced""")
        End If

        For Each fl In filterList
            filter = filter + fl + " OR "
        Next

        filter = filter.Substring(0, filter.Length - 4)
    End Sub

    Private Sub rad_SyncMode_CheckedChanged(sender As Object, e As EventArgs) Handles _
        rad_SyncMode_AskUser.CheckedChanged,
        rad_SyncMode_UseLocalRating.CheckedChanged,
        rad_SyncMode_UseRemoteRating.CheckedChanged

        Dim checkedButton As New RadioButton()
        checkedButton = grp_SyncMode.Controls.OfType(Of RadioButton)().FirstOrDefault(Function(radioButton) radioButton.Checked)

        If Not (checkedButton Is Nothing) Then
            Select Case checkedButton.Name
                Case "rad_SyncMode_AskUser"
                    settings._syncMode = Settings.syncModeEnum.askUser
                Case "rad_SyncMode_UseLocalRating"
                    settings._syncMode = Settings.syncModeEnum.useTagRating
                Case "rad_SyncMode_UseRemoteRating"
                    settings._syncMode = Settings.syncModeEnum.usePowerampRating
            End Select
        End If
    End Sub

    Private Sub btn_SyncNow_Click(sender As Object, e As EventArgs) Handles btn_SyncNow.Click
        tst_Status.Text = " | Status: syncing ratings..."

        bgw_SyncNow.RunWorkerAsync()
    End Sub
#End Region

#Region "grp_Target"
    Private Sub btn_exportNPM_Click(sender As Object, e As EventArgs) Handles btn_exportNPM.Click
        sfd_exportNPM.ShowDialog()
    End Sub

    Private Sub sfd_exportNPM_FileOk(sender As Object, e As CancelEventArgs) Handles sfd_exportNPM.FileOk
        listOfTracks.exportNPM(sfd_exportNPM.FileName)
    End Sub

    Private Sub sfd_AllTracksCSV_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles sfd_AllTracksCSV.FileOk
        listOfTracks.exportCSV(sfd_AllTracksCSV.FileName())
    End Sub
#End Region

#Region "onClose"
    Private Sub frm_Main_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        settings.save()
    End Sub
#End Region


#Region "bgw_transformLocalPath"
    Private Sub bgw_transformLocalPath_DoWork(sender As Object, e As DoWorkEventArgs) Handles bgw_transformLocalPath.DoWork
        ' TODO make the DGV follow progress
        ' https://www.opentechguides.com/how-to/article/vb/66/vb-backgroundworker.html

        Dim percent As Integer = 0
        Dim i As Integer = 0

        For Each track As Track In bs.List
            track.transformToLocalPath(settings._remoteMainPath, settings._localMainPath)

            i = i + 1
            percent = i * 100 / bs.Count
            bgw_transformLocalPath.ReportProgress(percent)
        Next
    End Sub
    Private Sub bgw_transformLocalPath_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles bgw_transformLocalPath.ProgressChanged
        tsp_Progress.ProgressBar.Value = e.ProgressPercentage
    End Sub
    Private Sub bgw_transformLocalPath_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bgw_transformLocalPath.RunWorkerCompleted
        tst_Status.Text = "| Status: Getting local Rating..."
        bgw_ReadLocalRating.RunWorkerAsync()
    End Sub
#End Region

#Region "bgw_ReadLocalRating"
    Private Sub bgw_ReadLocalRating_DoWork(sender As Object, e As DoWorkEventArgs) Handles bgw_ReadLocalRating.DoWork
        Dim percent As Integer = 0
        Dim i As Integer = 0

        For Each track As Track In bs.List
            If (My.Computer.FileSystem.FileExists(track._localPath) = True) Then
                track.readLocalRating()
                If (track._localRating = track._remoteRating) Then
                    track._trackStatus = Track.trackStatusEnum.synced
                Else
                    track._trackStatus = Track.trackStatusEnum.toSync
                End If
            End If

            i = i + 1
            percent = i * 100 / bs.Count
            bgw_ReadLocalRating.ReportProgress(percent)
        Next
    End Sub
    Private Sub bgw_ReadLocalRating_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles bgw_ReadLocalRating.ProgressChanged
        tsp_Progress.ProgressBar.Value = e.ProgressPercentage
    End Sub
    Private Sub bgw_ReadLocalRating_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bgw_ReadLocalRating.RunWorkerCompleted
        tst_Status.Text = "| Status: Idle"
        tsp_Progress.ProgressBar.Value = 0

        'TODO enable following controls
        grp_FilterDGV.Enabled = True
        grp_Sync.Enabled = True
    End Sub
#End Region

#Region "bgw_SyncNow"
    Private Sub bgw_SyncNow_DoWork(sender As Object, e As DoWorkEventArgs) Handles bgw_SyncNow.DoWork
        Dim percent As Integer = 0
        Dim i As Integer = 0

        Dim frm_SyncDecision As New frm_SyncDecision()

        For Each track As Track In bs.List
            If (track._trackStatus <> Track.trackStatusEnum.notFound) Then
                If (track._localRating <> track._remoteRating) Then

                    Select Case settings._syncMode
                        Case Settings.syncModeEnum.askUser
                            ' create new Window, ask for user decision
                            frm_SyncDecision._track = track

                            Select Case frm_SyncDecision.ShowDialog()
                                Case frm_SyncDecision.syncDecisionResult.useTagRating
                                    track._remoteRating = track._localRating
                                    track._trackStatus = Track.trackStatusEnum.synced
                                Case frm_SyncDecision.syncDecisionResult.usePowerampRating
                                    track._localRating = track._remoteRating
                                    track._trackStatus = Track.trackStatusEnum.synced
                                Case frm_SyncDecision.syncDecisionResult.Cancel
                                    MsgBox("Cancel")
                                Case Else
                                    MsgBox("else")
                            End Select
                        Case Settings.syncModeEnum.useTagRating
                            track._remoteRating = track._localRating
                            track._trackStatus = Track.trackStatusEnum.synced
                        Case Settings.syncModeEnum.usePowerampRating
                            track._localRating = track._remoteRating
                            track._trackStatus = Track.trackStatusEnum.synced
                    End Select
                End If
            End If

            i = i + 1
            percent = i * 100 / bs.Count
            bgw_SyncNow.ReportProgress(percent)
        Next

        frm_SyncDecision.Dispose()
    End Sub
    Private Sub bgw_SyncNow_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles bgw_SyncNow.ProgressChanged
        tsp_Progress.ProgressBar.Value = e.ProgressPercentage
    End Sub
    Private Sub bgw_SyncNow_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bgw_SyncNow.RunWorkerCompleted
        tst_Status.Text = "| Status: Idle"
        tsp_Progress.ProgressBar.Value = 0

        grp_Target.Enabled = True
    End Sub
#End Region









    'Private Sub bgw_PopulateDGV_DoWork(sender As Object, e As DoWorkEventArgs) Handles bgw_PopulateDGV.DoWork
    '    ' TODO move these to Background workers
    '    ' https://stackoverflow.com/questions/570537/update-label-while-processing-in-windows-forms
    '    ' https://www.dotnetperls.com/backgroundworker-vbnet
    '    ' https://stackoverflow.com/questions/2240702/crossthread-operation-not-valid-vb-net

    '    'Dim track As New Track()

    '    tst_Status.Text = "| Status: getting Local Path..."
    '    For i As Integer = 0 To dgv_Tracklist.RowCount() - 1
    '        ' select current row
    '        dgv_Tracklist.ClearSelection()
    '        dgv_Tracklist.CurrentCell = dgv_Tracklist.Rows(i).Cells(0)
    '        dgv_Tracklist.Rows(i).Selected = True

    '        ' get TRACK from current row
    '        'Track = DirectCast(dgv_Tracklist.CurrentRow.DataBoundItem, Track)
    '        Dim track As Track = dgv_Tracklist.CurrentRow.DataBoundItem

    '        track.transformToLocalPath(settings._remoteMainPath, settings._localMainPath)

    '        'System.Threading.Thread.CurrentThread.Sleep(50)
    '    Next
    '    tst_Status.Text = "| Status: Idle"

    '    tst_Status.Text = "| Status: Getting local Rating..."
    '    For i As Integer = 0 To dgv_Tracklist.RowCount() - 1
    '        ' select current row
    '        dgv_Tracklist.ClearSelection()
    '        dgv_Tracklist.CurrentCell = dgv_Tracklist.Rows(i).Cells(0)
    '        dgv_Tracklist.Rows(i).Selected = True

    '        ' get TRACK from current row
    '        'track = DirectCast(dgv_Tracklist.CurrentRow.DataBoundItem, Track)
    '        Dim track As Track = dgv_Tracklist.CurrentRow.DataBoundItem

    '        If (My.Computer.FileSystem.FileExists(Track._localPath) = True) Then
    '            Track.readLocalRating()
    '            If (Track._localRating = Track._remoteRating) Then
    '                Track._trackStatus = trackStatusEnum.synced
    '            Else
    '                Track._trackStatus = trackStatusEnum.toSync
    '            End If
    '        End If

    '        'System.Threading.Thread.CurrentThread.Sleep(50)
    '    Next
    '    tst_Status.Text = "| Status: Idle"
    'End Sub


End Class
