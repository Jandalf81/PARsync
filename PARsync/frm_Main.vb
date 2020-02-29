Imports System.ComponentModel

Public Class frm_Main
    Public listOfTracks As New Tracklist()
    Public settings As New Settings()
    'Public WithEvents bs As New BindingSource()

    Public bs As Equin.ApplicationFramework.BindingListView(Of Track) = New Equin.ApplicationFramework.BindingListView(Of Track)(listOfTracks.tracks)
    'Public bs As New Equin.ApplicationFramework.BindingListView(Of Track)(listOfTracks.tracks)


#Region "onLoad"
    Private Sub frm_Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        settings.load()
        txt_LocalMainPath.Text = settings._localMainPath
        txt_RemoteMainPath.Text = settings._remoteMainPath
        Select Case settings._syncMode
            Case Settings.syncModeEnum.askUser
                rad_SyncMode_AskUser.Checked = True
                rad_SyncMode_UseTagRating.Checked = False
                rad_SyncMode_UsePowerampRating.Checked = False
                btn_SyncNow.Image = My.Resources.arrow_refresh
            Case Settings.syncModeEnum.useTagRating
                rad_SyncMode_AskUser.Checked = False
                rad_SyncMode_UseTagRating.Checked = True
                rad_SyncMode_UsePowerampRating.Checked = False
                btn_SyncNow.Image = My.Resources.arrow_right
            Case Settings.syncModeEnum.usePowerampRating
                rad_SyncMode_AskUser.Checked = False
                rad_SyncMode_UseTagRating.Checked = False
                rad_SyncMode_UsePowerampRating.Checked = True
                btn_SyncNow.Image = My.Resources.arrow_left
        End Select

        tst_NoOfTracks.Text = "Number of Tracks: 0"
        tst_Status.Text = "| Status: Idle"

        Me.dgv_Tracklist.ReadOnly() = True
        Me.dgv_Tracklist.AllowUserToAddRows = False
        Me.dgv_Tracklist.AutoGenerateColumns = False
        Me.dgv_Tracklist.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        Me.dgv_Tracklist.RowHeadersVisible = False

        'Me.bs.DataSource = listOfTracks.tracks
        '  bs = New Equin.ApplicationFramework.BindingListView(Of Track)(listOfTracks.tracks)
        '  Me.dgv_Tracklist.DataSource = Me.bs

        ' prepare columns for DataGridView
        Dim col_Artist As New DataGridViewTextBoxColumn()
        col_Artist.DataPropertyName = "_artist"
        col_Artist.Name = "Artist"

        Dim col_Album As New DataGridViewTextBoxColumn()
        col_Album.DataPropertyName = "_album"
        col_Album.Name = "Album"

        Dim col_Track As New DataGridViewTextBoxColumn()
        col_Track.DataPropertyName = "_track"
        col_Track.Name = "#"

        Dim com_Title As New DataGridViewTextBoxColumn()
        com_Title.DataPropertyName = "_title"
        com_Title.Name = "Title"

        Dim col_TagRating As New DataGridViewTextBoxColumn()
        col_TagRating.DataPropertyName = "_TagRating"
        col_TagRating.Name = "Tag" + vbCrLf + "Rating"

        Dim col_TagRatingImage As New DataGridViewImageColumn()
        col_TagRatingImage.DataPropertyName = "_TagRatingImage"
        col_TagRatingImage.Name = "Tag" + vbCrLf + "Rating"
        col_TagRatingImage.SortMode = DataGridViewColumnSortMode.Programmatic

        Dim col_SyncStatusImage As New DataGridViewImageColumn()
        col_SyncStatusImage.DataPropertyName = "_syncStatusImage"
        col_SyncStatusImage.Name = "Sync" + vbCrLf + "Status"
        col_SyncStatusImage.SortMode = DataGridViewColumnSortMode.Programmatic

        Dim col_PowerampRating As New DataGridViewTextBoxColumn()
        col_PowerampRating.DataPropertyName = "_PowerampRating"
        col_PowerampRating.Name = "Poweramp" + vbCrLf + "Rating"

        Dim col_PowerampRatingImage As New DataGridViewImageColumn()
        col_PowerampRatingImage.DataPropertyName = "_PowerampRatingImage"
        col_PowerampRatingImage.Name = "Poweramp" + vbCrLf + "Rating"
        col_PowerampRatingImage.SortMode = DataGridViewColumnSortMode.Programmatic

        Dim col_LocalPath As New DataGridViewTextBoxColumn()
        col_LocalPath.DataPropertyName = "_localPath"
        col_LocalPath.Name = "local" + vbCrLf + "Path"

        Dim col_RemotePath As New DataGridViewTextBoxColumn()
        col_RemotePath.DataPropertyName = "_remotePath"
        col_RemotePath.Name = "remote" + vbCrLf + "Path"

        Dim col_TrackStatusImage As New DataGridViewImageColumn()
        col_TrackStatusImage.DataPropertyName = "_trackStatusImage"
        col_TrackStatusImage.Name = "Track" + vbCrLf + "Status"
        col_TrackStatusImage.SortMode = DataGridViewColumnSortMode.Programmatic

        ' add prepared columns to DataGridView
        dgv_Tracklist.Columns.Add(col_TrackStatusImage)

        dgv_Tracklist.Columns.Add(col_Artist)
        dgv_Tracklist.Columns.Add(col_Album)
        dgv_Tracklist.Columns.Add(col_Track)
        dgv_Tracklist.Columns.Add(com_Title)

        'dgv_Tracklist.Columns.Add(col_TagRating)
        dgv_Tracklist.Columns.Add(col_TagRatingImage)
        dgv_Tracklist.Columns.Add(col_SyncStatusImage)
        'dgv_Tracklist.Columns.Add(col_PowerampRating)
        dgv_Tracklist.Columns.Add(col_PowerampRatingImage)

        dgv_Tracklist.Columns.Add(col_LocalPath)
        dgv_Tracklist.Columns.Add(col_RemotePath)

        dgv_Tracklist.Columns.Item("Track" + vbCrLf + "Status").Width = 65
        dgv_Tracklist.Columns.Item("Sync" + vbCrLf + "Status").Width = 65

        ' disable some control elements
        grp_Filter_TrackStatus.Enabled = False
        grp_Filter_SyncStatus.Enabled = False
        grp_SyncMode.Enabled = False
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
    Private Sub rad_Source_NPM_CheckedChanged(sender As Object, e As EventArgs) Handles rad_Source_NPM.CheckedChanged
        btn_OFD.Enabled = rad_Source_NPM.Checked
        btn_Help_OpenSourceFile.Enabled = rad_Source_NPM.Checked
    End Sub

    Private Sub rad_Source_ADB_CheckedChanged(sender As Object, e As EventArgs) Handles rad_Source_ADB.CheckedChanged
        btn_ADB.Enabled = rad_Source_ADB.Checked
    End Sub

    Private Sub btn_OFD_Click(sender As Object, e As EventArgs) Handles btn_OFD.Click
        Dim result As DialogResult = ofd_AllTracksCSV.ShowDialog()

        If result = DialogResult.OK Then
            txt_OFD.Text = ofd_AllTracksCSV.FileName

            tst_Status.Text = "| Status: reading CSV file..."
            lbl_Progress.Text = "reading CSV file..."
            bgw_ReadCSV.RunWorkerAsync()
        End If
    End Sub

    Private Sub btn_ADB_Click(sender As Object, e As EventArgs) Handles btn_ADB.Click
        tst_Status.Text = "| Status: reading from ADB..."
        lbl_Progress.Text = "reading from ADB..."
        bgw_ReadADB.RunWorkerAsync()
    End Sub
#End Region

#Region "grp_Sync"
    ' TODO make the DGV filter-able: https://archive.codeplex.com/?p=adgv, https://www.nuget.org/packages/ADGV/

    ' make the DGV sort-able: http://blw.sourceforge.net/
    Private Sub dgv_Tracklist_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgv_Tracklist.ColumnHeaderMouseClick
        Dim clickedColumn As String = dgv_Tracklist.Columns.Item(e.ColumnIndex).DataPropertyName

        Dim specialColumns As String() = {"_trackStatusImage", "_TagRatingImage", "_syncStatusImage", "_PowerampRatingImage"}

        If specialColumns.Contains(clickedColumn) Then
            Dim currentSortColumn As String = bs.Sort
            Dim currentSortOrder As ListSortDirection = bs.SortDirection

            Dim newSortColumn As String = ""
            Dim newSortOrder As String = ""

            Dim clickedColumnDPN = clickedColumn

            clickedColumn = clickedColumn.Replace("Image", "")

            Select Case currentSortColumn
                Case = ""
                    newSortColumn = clickedColumn
                    newSortOrder = ""
                Case = clickedColumn
                    newSortColumn = currentSortColumn

                    If currentSortOrder = ListSortDirection.Ascending Then
                        newSortOrder = " DESC"
                    Else
                        newSortOrder = ""
                    End If
                Case <> clickedColumn
                    newSortColumn = clickedColumn
                    newSortOrder = ""
            End Select

            bs.ApplySort(newSortColumn + newSortOrder)
            Select Case newSortOrder
                Case ""
                    dgv_Tracklist.Columns.Item(e.ColumnIndex).HeaderCell.SortGlyphDirection = SortOrder.Ascending
                Case " DESC"
                    dgv_Tracklist.Columns.Item(e.ColumnIndex).HeaderCell.SortGlyphDirection = SortOrder.Descending
            End Select
        End If
    End Sub

    Private Sub rad_SyncMode_CheckedChanged(sender As Object, e As EventArgs) Handles _
            rad_SyncMode_AskUser.CheckedChanged,
            rad_SyncMode_UseTagRating.CheckedChanged,
            rad_SyncMode_UsePowerampRating.CheckedChanged
        Dim checkedButton As New RadioButton()
        checkedButton = grp_SyncMode.Controls.OfType(Of RadioButton)().FirstOrDefault(Function(radioButton) radioButton.Checked)

        If Not (checkedButton Is Nothing) Then
            Select Case checkedButton.Name
                Case "rad_SyncMode_AskUser"
                    settings._syncMode = Settings.syncModeEnum.askUser
                    btn_SyncNow.Image = My.Resources.arrow_refresh
                Case "rad_SyncMode_UseTagRating"
                    settings._syncMode = Settings.syncModeEnum.useTagRating
                    btn_SyncNow.Image = My.Resources.arrow_right
                Case "rad_SyncMode_UsePowerampRating"
                    settings._syncMode = Settings.syncModeEnum.usePowerampRating
                    btn_SyncNow.Image = My.Resources.arrow_left
            End Select
        End If
    End Sub

    Private Sub btn_SyncNow_Click(sender As Object, e As EventArgs) Handles btn_SyncNow.Click
        chk_Track_ToRead.Checked = True
        chk_Track_NotFound.Checked = True
        chk_Track_ToSync.Checked = True
        chk_Track_Synced.Checked = True
        grp_Filter_TrackStatus.Enabled = False
        bs.RemoveFilter()

        tst_Status.Text = " | Status: syncing Ratings..."
        bgw_SyncNow.RunWorkerAsync()
    End Sub

#Region "filter DataGridView"
    'handle changes of CHECKBOXes in grp_Filter_TrackStatus
    Private Sub chk_TrackFilter_Click(sender As Object, e As EventArgs) Handles _
            chk_Track_ToRead.CheckedChanged,
            chk_Track_NotFound.CheckedChanged,
            chk_Track_ToSync.CheckedChanged,
            chk_Track_Synced.CheckedChanged
        bs.ApplyFilter(AddressOf trackStatusFilter)
    End Sub

    'handle changes of CHECKBOXes in grp_Filter_SyncStatus
    Private Sub chk_SyncFilter_Click(sender As Object, e As EventArgs) Handles _
            chk_Sync_Synced.CheckedChanged,
            chk_Sync_UsedTagRating.CheckedChanged,
            chk_Sync_UsedPowerampRating.CheckedChanged,
            chk_Sync_Cancelled.CheckedChanged
        bs.ApplyFilter(AddressOf syncStatusFilter)
    End Sub

    Private Function trackStatusFilter(ByVal track As Track) As Boolean
        If (chk_Track_ToRead.Checked = True AndAlso track._trackStatus = Track.trackStatusEnum.toRead) Then Return True
        If (chk_Track_NotFound.Checked = True AndAlso track._trackStatus = Track.trackStatusEnum.notFound) Then Return True
        If (chk_Track_ToSync.Checked = True AndAlso track._trackStatus = Track.trackStatusEnum.toSync) Then Return True
        If (chk_Track_Synced.Checked = True AndAlso track._trackStatus = Track.trackStatusEnum.synced) Then Return True

        Return False
    End Function

    Private Function syncStatusFilter(ByVal track As Track) As Boolean
        If (chk_Sync_Synced.Checked = True AndAlso track._syncStatus = Track.syncStatusEnum.synced) Then Return True
        If (chk_Sync_UsedTagRating.Checked = True AndAlso track._syncStatus = Track.syncStatusEnum.usedTagRating) Then Return True
        If (chk_Sync_UsedPowerampRating.Checked = True AndAlso track._syncStatus = Track.syncStatusEnum.usedPowerampRating) Then Return True
        If (chk_Sync_Cancelled.Checked = True AndAlso track._syncStatus = Track.syncStatusEnum.Cancelled) Then Return True

        Return False
    End Function
#End Region
#End Region

#Region "grp_Target"
    Private Sub btn_exportNPM_Click(sender As Object, e As EventArgs) Handles btn_exportNPM.Click
        sfd_exportNPM.ShowDialog()
    End Sub

    Private Sub sfd_exportNPM_FileOk(sender As Object, e As CancelEventArgs) Handles sfd_exportNPM.FileOk
        listOfTracks.exportNPM(sfd_exportNPM.FileName)
        txt_SavePath.Text = sfd_exportNPM.FileName
    End Sub

    Private Sub sfd_AllTracksCSV_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles sfd_AllTracksCSV.FileOk
        listOfTracks.exportCSV(sfd_AllTracksCSV.FileName())
    End Sub

    Private Sub btn_OpenSavePath_Click(sender As Object, e As EventArgs) Handles btn_OpenSavePath.Click
        Process.Start("explorer.exe", txt_SavePath.Text.Remove(txt_SavePath.Text.LastIndexOf("\")))
    End Sub
#End Region

#Region "onClose"
    Private Sub frm_Main_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        settings.save()
    End Sub
#End Region


#Region "bgw_ReadCSV"
    Private Sub bgw_ReadCSV_DoWork(sender As Object, e As DoWorkEventArgs) Handles bgw_ReadCSV.DoWork
        listOfTracks.importCSV(txt_OFD.Text)
    End Sub
    Private Sub bgw_ReadCSV_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bgw_ReadCSV.RunWorkerCompleted
        tst_NoOfTracks.Text = "Number of Tracks: " + listOfTracks.tracks.Count.ToString
        tst_Status.Text = "| Status: Idle"

        bs = New Equin.ApplicationFramework.BindingListView(Of Track)(listOfTracks.tracks)
        Me.dgv_Tracklist.DataSource = Me.bs

        tst_Status.Text = "| Status: getting local Path..."
        lbl_Progress.Text = "testing local files... (0%)"
        bgw_transformLocalPath.RunWorkerAsync()
    End Sub
#End Region

#Region "bgw_ReadADB"
    Private Sub bgw_ReadADB_DoWork(sender As Object, e As DoWorkEventArgs) Handles bgw_ReadADB.DoWork
        listOfTracks.getFromADB()
    End Sub

    Private Sub bgw_ReadADB_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bgw_ReadADB.RunWorkerCompleted
        tst_NoOfTracks.Text = "Number of Tracks: " + listOfTracks.tracks.Count.ToString
        tst_Status.Text = "| Status: Idle"

        bs = New Equin.ApplicationFramework.BindingListView(Of Track)(listOfTracks.tracks)
        Me.dgv_Tracklist.DataSource = Me.bs

        tst_Status.Text = "| Status: getting local Path..."
        lbl_Progress.Text = "testing local files... (0%)"
        bgw_transformLocalPath.RunWorkerAsync()
    End Sub
#End Region

#Region "bgw_transformLocalPath"
    Private Sub bgw_transformLocalPath_DoWork(sender As Object, e As DoWorkEventArgs) Handles bgw_transformLocalPath.DoWork
        ' TODO make the DGV follow progress
        ' https://www.opentechguides.com/how-to/article/vb/66/vb-backgroundworker.html

        Dim percent As Integer = 0
        Dim i As Integer = 0

        For Each track As Track In listOfTracks.tracks
            track.transformToLocalPath(settings._remoteMainPath, settings._localMainPath)

            ' DEBUG
            My.Application.Log.WriteEntry("Pfad transformiert: " + i.ToString + " / " + bs.Count.ToString)

            i = i + 1
            percent = i * 100 / bs.Count
            bgw_transformLocalPath.ReportProgress(percent)
        Next
    End Sub

    Private Sub bgw_transformLocalPath_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles bgw_transformLocalPath.ProgressChanged
        tsp_Progress.ProgressBar.Value = e.ProgressPercentage
        prb_Progress.Value = e.ProgressPercentage
        lbl_Progress.Text = "testing local files... (" + e.ProgressPercentage.ToString + "%)"
    End Sub

    Private Sub bgw_transformLocalPath_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bgw_transformLocalPath.RunWorkerCompleted
        tst_Status.Text = "| Status: getting Tag Rating..."
        tsp_Progress.ProgressBar.Value = 0

        lbl_Progress.Text = "getting Tag Ratings... (0%)"
        bgw_ReadTagRating.RunWorkerAsync()
    End Sub
#End Region

#Region "bgw_ReadTagRating"
    Private Sub bgw_ReadTagRating_DoWork(sender As Object, e As DoWorkEventArgs) Handles bgw_ReadTagRating.DoWork
        Dim percent As Integer = 0
        Dim i As Integer = 0

        For Each track As Track In listOfTracks.tracks
            If (My.Computer.FileSystem.FileExists(track._localPath) = True) Then
                track.readTagRating()
                If (track._TagRating = track._PowerampRating) Then
                    track._trackStatus = Track.trackStatusEnum.synced
                    track._syncStatus = Track.syncStatusEnum.synced
                Else
                    track._trackStatus = Track.trackStatusEnum.toSync
                    track._syncStatus = Track.syncStatusEnum.toSync
                End If
            End If

            ' DEBUG
            My.Application.Log.WriteEntry("Track-Ratings gelesen: " + i.ToString + " / " + bs.Count.ToString)

            i = i + 1
            percent = i * 100 / bs.Count
            bgw_ReadTagRating.ReportProgress(percent)
        Next
    End Sub
    Private Sub bgw_ReadTagRating_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles bgw_ReadTagRating.ProgressChanged
        tsp_Progress.ProgressBar.Value = e.ProgressPercentage
        prb_Progress.Value = e.ProgressPercentage
        lbl_Progress.Text = "getting Tag ratings... (" + e.ProgressPercentage.ToString + "%)"
    End Sub
    Private Sub bgw_ReadTagRating_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bgw_ReadTagRating.RunWorkerCompleted
        tst_Status.Text = "| Status: Idle"
        tsp_Progress.ProgressBar.Value = 0

        Me.dgv_Tracklist.DataSource = Me.bs

        'enable following controls
        grp_Filter_TrackStatus.Enabled = True
        grp_SyncMode.Enabled = True
        prb_Progress.Visible = False
        lbl_Progress.Visible = False
    End Sub
#End Region

#Region "bgw_SyncNow"
    Private Sub bgw_SyncNow_DoWork(sender As Object, e As DoWorkEventArgs) Handles bgw_SyncNow.DoWork
        Dim percent As Integer = 0
        Dim i As Integer = 0

        Dim syncMethod As String = ""

        If (rad_Source_ADB.Checked = True) Then syncMethod = "ADB"
        If (rad_Source_NPM.Checked = True) Then syncMethod = "NPM"

        Dim frm_SyncDecision As New frm_SyncDecision()
        frm_SyncDecision.StartPosition = FormStartPosition.CenterParent
        Dim retval As frm_SyncDecision.syncDecisionResult

        For Each track As Track In listOfTracks.tracks
            If (track._trackStatus <> Track.trackStatusEnum.notFound) Then
                If (track._TagRating <> track._PowerampRating) Then

                    Select Case settings._syncMode
                        Case Settings.syncModeEnum.askUser
                            ' create new Window, ask for user decision
                            frm_SyncDecision._track = track

                            retval = frm_SyncDecision.ShowDialog(My.Forms.frm_Main)

                            Select Case retval
                                Case frm_SyncDecision.syncDecisionResult.useTagRating
                                    track.useTagRating(syncMethod)
                                Case frm_SyncDecision.syncDecisionResult.usePowerampRating
                                    track.usePowerampRating()
                                Case frm_SyncDecision.syncDecisionResult.Cancel
                                    track.cancelSync()
                                Case Else
                                    MsgBox("else")
                            End Select
                        Case Settings.syncModeEnum.useTagRating
                            track.useTagRating(syncMethod)
                        Case Settings.syncModeEnum.usePowerampRating
                            track.usePowerampRating()
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

        grp_Filter_SyncStatus.Enabled = True
        grp_Target.Enabled = True
    End Sub
#End Region

#Region "Help Buttons"
    Private Sub btn_Help_OpenSourceFile_Click(sender As Object, e As EventArgs) Handles btn_Help_OpenSourceFile.Click
        MsgBox("1. Open 'New Playlist Manager' on your Android Device" + vbCrLf +
                "2. Open the burger menu, navigate to 'Library'" + vbCrLf +
                "3. Open the context menu, select 'Export all tracks to CSV format'" + vbCrLf +
                "4. Wait for the export to finish" + vbCrLf +
                "5. Select the created file here",
            MsgBoxStyle.OkOnly,
            "PARsync - Open source file")
    End Sub

    Private Sub btn_Help_Save_Click(sender As Object, e As EventArgs) Handles btn_Help_Save.Click
        MsgBox("1. Save the file to your Computer" + vbCrLf +
               "2. Copy the file to your Android device, place it in '/storage/emulated/0/playlist_manager'" + vbCrLf +
               "3. Open 'New Playlist Manager' on your Android device" + vbCrLf +
               "4. In 'New Playlist Manager' go to the 'Poweramp' tab" + vbCrLf +
               "5. Open the context menu, select 'tags and ratings / restore ratings'" + vbCrLf +
               "6. Wait for the process to finish" + vbCrLf +
               "7. Re-Start 'Poweramp' to see the just imported ratings",
            MsgBoxStyle.OkOnly,
            "PARsync - Save for NPM")
    End Sub

    Private Sub btn_Help_LocalMainPath_Click(sender As Object, e As EventArgs) Handles btn_Help_LocalMainPath.Click
        MsgBox("1. Select your local main path of your music here" + vbCrLf +
               "2. This is the path where all your local tracks should be" + vbCrLf +
               "3. The diretory structure on your Android device has to mirror the local one",
            MsgBoxStyle.OkOnly,
            "PARsync - Set local main Path")
    End Sub

    Private Sub btn_Help_RemoteMainPath_Click(sender As Object, e As EventArgs) Handles btn_Help_RemoteMainPath.Click
        MsgBox("1. Select your remote main path of your music here" + vbCrLf +
               "2. This is the path where all your remote tracks should be" + vbCrLf +
               "3. The diretory structure on your Android device has to mirror the local one",
            MsgBoxStyle.OkOnly,
            "PARsync - Set remote main Path")
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
