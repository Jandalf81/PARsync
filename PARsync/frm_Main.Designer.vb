<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_Main
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Main))
        Me.rad_SyncMode_UsePowerampRating = New System.Windows.Forms.RadioButton()
        Me.ofd_AllTracksCSV = New System.Windows.Forms.OpenFileDialog()
        Me.grp_Source = New System.Windows.Forms.GroupBox()
        Me.lbl_Source_1 = New System.Windows.Forms.Label()
        Me.btn_OFD = New System.Windows.Forms.Button()
        Me.txt_OFD = New System.Windows.Forms.TextBox()
        Me.grp_Sync = New System.Windows.Forms.GroupBox()
        Me.grp_FilterDGV = New System.Windows.Forms.GroupBox()
        Me.chk_ToRead = New System.Windows.Forms.CheckBox()
        Me.chk_Synced = New System.Windows.Forms.CheckBox()
        Me.chk_ToSync = New System.Windows.Forms.CheckBox()
        Me.chk_NotFound = New System.Windows.Forms.CheckBox()
        Me.btn_SyncNow = New System.Windows.Forms.Button()
        Me.grp_SyncMode = New System.Windows.Forms.GroupBox()
        Me.rad_SyncMode_AskUser = New System.Windows.Forms.RadioButton()
        Me.rad_SyncMode_UseTagRating = New System.Windows.Forms.RadioButton()
        Me.dgv_Tracklist = New System.Windows.Forms.DataGridView()
        Me.grp_Target = New System.Windows.Forms.GroupBox()
        Me.btn_exportNPM = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tst_NoOfTracks = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tst_Status = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsp_Progress = New System.Windows.Forms.ToolStripProgressBar()
        Me.sfd_AllTracksCSV = New System.Windows.Forms.SaveFileDialog()
        Me.grp_Settings = New System.Windows.Forms.GroupBox()
        Me.btn_LocalMainPath = New System.Windows.Forms.Button()
        Me.txt_RemoteMainPath = New System.Windows.Forms.TextBox()
        Me.txt_LocalMainPath = New System.Windows.Forms.TextBox()
        Me.lbl_RemoteMainPath = New System.Windows.Forms.Label()
        Me.lbl_LocalMainPath = New System.Windows.Forms.Label()
        Me.fbd_LocalMainPath = New System.Windows.Forms.FolderBrowserDialog()
        Me.bgw_PopulateDGV = New System.ComponentModel.BackgroundWorker()
        Me.bgw_transformLocalPath = New System.ComponentModel.BackgroundWorker()
        Me.bgw_ReadTagRating = New System.ComponentModel.BackgroundWorker()
        Me.bgw_SyncNow = New System.ComponentModel.BackgroundWorker()
        Me.sfd_exportNPM = New System.Windows.Forms.SaveFileDialog()
        Me.grp_Source.SuspendLayout()
        Me.grp_Sync.SuspendLayout()
        Me.grp_FilterDGV.SuspendLayout()
        Me.grp_SyncMode.SuspendLayout()
        CType(Me.dgv_Tracklist, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_Target.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.grp_Settings.SuspendLayout()
        Me.SuspendLayout()
        '
        'rad_SyncMode_UseRemoteRating
        '
        Me.rad_SyncMode_UsePowerampRating.Image = Global.PARsync.My.Resources.Resources.arrow_left
        Me.rad_SyncMode_UsePowerampRating.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.rad_SyncMode_UsePowerampRating.Location = New System.Drawing.Point(338, 19)
        Me.rad_SyncMode_UsePowerampRating.Name = "rad_SyncMode_UseRemoteRating"
        Me.rad_SyncMode_UsePowerampRating.Size = New System.Drawing.Size(160, 22)
        Me.rad_SyncMode_UsePowerampRating.TabIndex = 1
        Me.rad_SyncMode_UsePowerampRating.TabStop = True
        Me.rad_SyncMode_UsePowerampRating.Text = "Always use remote rating"
        Me.rad_SyncMode_UsePowerampRating.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.rad_SyncMode_UsePowerampRating.UseVisualStyleBackColor = True
        '
        'ofd_AllTracksCSV
        '
        Me.ofd_AllTracksCSV.FileName = "all_tracks.csv"
        Me.ofd_AllTracksCSV.Filter = "all_tracks.csv|*.csv"
        '
        'grp_Source
        '
        Me.grp_Source.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grp_Source.Controls.Add(Me.lbl_Source_1)
        Me.grp_Source.Controls.Add(Me.btn_OFD)
        Me.grp_Source.Controls.Add(Me.txt_OFD)
        Me.grp_Source.Location = New System.Drawing.Point(12, 120)
        Me.grp_Source.Name = "grp_Source"
        Me.grp_Source.Size = New System.Drawing.Size(980, 118)
        Me.grp_Source.TabIndex = 2
        Me.grp_Source.TabStop = False
        Me.grp_Source.Text = "Source"
        '
        'lbl_Source_1
        '
        Me.lbl_Source_1.AutoSize = True
        Me.lbl_Source_1.Location = New System.Drawing.Point(6, 16)
        Me.lbl_Source_1.Name = "lbl_Source_1"
        Me.lbl_Source_1.Size = New System.Drawing.Size(314, 65)
        Me.lbl_Source_1.TabIndex = 4
        Me.lbl_Source_1.Text = resources.GetString("lbl_Source_1.Text")
        '
        'btn_OFD
        '
        Me.btn_OFD.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_OFD.BackgroundImage = Global.PARsync.My.Resources.Resources.script
        Me.btn_OFD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_OFD.Location = New System.Drawing.Point(949, 81)
        Me.btn_OFD.Name = "btn_OFD"
        Me.btn_OFD.Size = New System.Drawing.Size(25, 25)
        Me.btn_OFD.TabIndex = 3
        Me.btn_OFD.UseVisualStyleBackColor = True
        '
        'txt_OFD
        '
        Me.txt_OFD.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_OFD.Location = New System.Drawing.Point(9, 84)
        Me.txt_OFD.Name = "txt_OFD"
        Me.txt_OFD.ReadOnly = True
        Me.txt_OFD.Size = New System.Drawing.Size(934, 20)
        Me.txt_OFD.TabIndex = 2
        '
        'grp_Sync
        '
        Me.grp_Sync.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grp_Sync.Controls.Add(Me.grp_FilterDGV)
        Me.grp_Sync.Controls.Add(Me.btn_SyncNow)
        Me.grp_Sync.Controls.Add(Me.grp_SyncMode)
        Me.grp_Sync.Controls.Add(Me.dgv_Tracklist)
        Me.grp_Sync.Location = New System.Drawing.Point(12, 244)
        Me.grp_Sync.Name = "grp_Sync"
        Me.grp_Sync.Size = New System.Drawing.Size(980, 393)
        Me.grp_Sync.TabIndex = 3
        Me.grp_Sync.TabStop = False
        Me.grp_Sync.Text = "Sync"
        '
        'grp_FilterDGV
        '
        Me.grp_FilterDGV.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grp_FilterDGV.Controls.Add(Me.chk_ToRead)
        Me.grp_FilterDGV.Controls.Add(Me.chk_Synced)
        Me.grp_FilterDGV.Controls.Add(Me.chk_ToSync)
        Me.grp_FilterDGV.Controls.Add(Me.chk_NotFound)
        Me.grp_FilterDGV.Location = New System.Drawing.Point(9, 244)
        Me.grp_FilterDGV.Name = "grp_FilterDGV"
        Me.grp_FilterDGV.Size = New System.Drawing.Size(965, 47)
        Me.grp_FilterDGV.TabIndex = 5
        Me.grp_FilterDGV.TabStop = False
        Me.grp_FilterDGV.Text = "filter View"
        '
        'chk_ToRead
        '
        Me.chk_ToRead.Checked = True
        Me.chk_ToRead.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_ToRead.Image = Global.PARsync.My.Resources.Resources.toRead
        Me.chk_ToRead.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.chk_ToRead.Location = New System.Drawing.Point(6, 19)
        Me.chk_ToRead.Name = "chk_ToRead"
        Me.chk_ToRead.Size = New System.Drawing.Size(106, 25)
        Me.chk_ToRead.TabIndex = 8
        Me.chk_ToRead.Text = "to read"
        Me.chk_ToRead.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.chk_ToRead.UseVisualStyleBackColor = True
        '
        'chk_Synced
        '
        Me.chk_Synced.Checked = True
        Me.chk_Synced.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_Synced.Image = Global.PARsync.My.Resources.Resources.synced
        Me.chk_Synced.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.chk_Synced.Location = New System.Drawing.Point(342, 19)
        Me.chk_Synced.Name = "chk_Synced"
        Me.chk_Synced.Size = New System.Drawing.Size(106, 25)
        Me.chk_Synced.TabIndex = 7
        Me.chk_Synced.Text = "synced"
        Me.chk_Synced.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.chk_Synced.UseVisualStyleBackColor = True
        '
        'chk_ToSync
        '
        Me.chk_ToSync.Checked = True
        Me.chk_ToSync.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_ToSync.Image = Global.PARsync.My.Resources.Resources.toSync
        Me.chk_ToSync.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.chk_ToSync.Location = New System.Drawing.Point(230, 19)
        Me.chk_ToSync.Name = "chk_ToSync"
        Me.chk_ToSync.Size = New System.Drawing.Size(106, 25)
        Me.chk_ToSync.TabIndex = 6
        Me.chk_ToSync.Text = "to sync"
        Me.chk_ToSync.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.chk_ToSync.UseVisualStyleBackColor = True
        '
        'chk_NotFound
        '
        Me.chk_NotFound.Checked = True
        Me.chk_NotFound.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_NotFound.Image = Global.PARsync.My.Resources.Resources.notFound
        Me.chk_NotFound.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.chk_NotFound.Location = New System.Drawing.Point(118, 19)
        Me.chk_NotFound.Name = "chk_NotFound"
        Me.chk_NotFound.Size = New System.Drawing.Size(106, 25)
        Me.chk_NotFound.TabIndex = 5
        Me.chk_NotFound.Text = "File not found"
        Me.chk_NotFound.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.chk_NotFound.UseVisualStyleBackColor = True
        '
        'btn_SyncNow
        '
        Me.btn_SyncNow.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_SyncNow.Location = New System.Drawing.Point(9, 351)
        Me.btn_SyncNow.Name = "btn_SyncNow"
        Me.btn_SyncNow.Size = New System.Drawing.Size(965, 34)
        Me.btn_SyncNow.TabIndex = 3
        Me.btn_SyncNow.Text = "Sync now"
        Me.btn_SyncNow.UseVisualStyleBackColor = True
        '
        'grp_SyncMode
        '
        Me.grp_SyncMode.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grp_SyncMode.Controls.Add(Me.rad_SyncMode_AskUser)
        Me.grp_SyncMode.Controls.Add(Me.rad_SyncMode_UsePowerampRating)
        Me.grp_SyncMode.Controls.Add(Me.rad_SyncMode_UseTagRating)
        Me.grp_SyncMode.Location = New System.Drawing.Point(9, 297)
        Me.grp_SyncMode.Name = "grp_SyncMode"
        Me.grp_SyncMode.Size = New System.Drawing.Size(965, 48)
        Me.grp_SyncMode.TabIndex = 2
        Me.grp_SyncMode.TabStop = False
        Me.grp_SyncMode.Text = "Sync Mode"
        '
        'rad_SyncMode_AskUser
        '
        Me.rad_SyncMode_AskUser.Image = Global.PARsync.My.Resources.Resources.arrow_refresh
        Me.rad_SyncMode_AskUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.rad_SyncMode_AskUser.Location = New System.Drawing.Point(6, 19)
        Me.rad_SyncMode_AskUser.Name = "rad_SyncMode_AskUser"
        Me.rad_SyncMode_AskUser.Size = New System.Drawing.Size(160, 22)
        Me.rad_SyncMode_AskUser.TabIndex = 2
        Me.rad_SyncMode_AskUser.TabStop = True
        Me.rad_SyncMode_AskUser.Text = "Ask me for each track"
        Me.rad_SyncMode_AskUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.rad_SyncMode_AskUser.UseVisualStyleBackColor = True
        '
        'rad_SyncMode_UseLocalRating
        '
        Me.rad_SyncMode_UseTagRating.Image = Global.PARsync.My.Resources.Resources.arrow_right
        Me.rad_SyncMode_UseTagRating.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.rad_SyncMode_UseTagRating.Location = New System.Drawing.Point(172, 19)
        Me.rad_SyncMode_UseTagRating.Name = "rad_SyncMode_UseLocalRating"
        Me.rad_SyncMode_UseTagRating.Size = New System.Drawing.Size(160, 22)
        Me.rad_SyncMode_UseTagRating.TabIndex = 0
        Me.rad_SyncMode_UseTagRating.TabStop = True
        Me.rad_SyncMode_UseTagRating.Text = "Always use local rating"
        Me.rad_SyncMode_UseTagRating.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.rad_SyncMode_UseTagRating.UseVisualStyleBackColor = True
        '
        'dgv_Tracklist
        '
        Me.dgv_Tracklist.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_Tracklist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Tracklist.Location = New System.Drawing.Point(9, 19)
        Me.dgv_Tracklist.Name = "dgv_Tracklist"
        Me.dgv_Tracklist.Size = New System.Drawing.Size(965, 219)
        Me.dgv_Tracklist.TabIndex = 1
        '
        'grp_Target
        '
        Me.grp_Target.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grp_Target.Controls.Add(Me.btn_exportNPM)
        Me.grp_Target.Location = New System.Drawing.Point(12, 643)
        Me.grp_Target.Name = "grp_Target"
        Me.grp_Target.Size = New System.Drawing.Size(980, 52)
        Me.grp_Target.TabIndex = 4
        Me.grp_Target.TabStop = False
        Me.grp_Target.Text = "Target"
        '
        'btn_exportNPM
        '
        Me.btn_exportNPM.Location = New System.Drawing.Point(9, 20)
        Me.btn_exportNPM.Name = "btn_exportNPM"
        Me.btn_exportNPM.Size = New System.Drawing.Size(224, 23)
        Me.btn_exportNPM.TabIndex = 0
        Me.btn_exportNPM.Text = "save for NPM"
        Me.btn_exportNPM.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tst_NoOfTracks, Me.tst_Status, Me.tsp_Progress})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 698)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1002, 22)
        Me.StatusStrip1.TabIndex = 5
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tst_NoOfTracks
        '
        Me.tst_NoOfTracks.Name = "tst_NoOfTracks"
        Me.tst_NoOfTracks.Size = New System.Drawing.Size(87, 17)
        Me.tst_NoOfTracks.Text = "tst_NoOfTracks"
        '
        'tst_Status
        '
        Me.tst_Status.Name = "tst_Status"
        Me.tst_Status.Size = New System.Drawing.Size(57, 17)
        Me.tst_Status.Text = "tst_Status"
        '
        'tsp_Progress
        '
        Me.tsp_Progress.Name = "tsp_Progress"
        Me.tsp_Progress.Size = New System.Drawing.Size(100, 16)
        Me.tsp_Progress.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        '
        'sfd_AllTracksCSV
        '
        Me.sfd_AllTracksCSV.FileName = "export.csv"
        '
        'grp_Settings
        '
        Me.grp_Settings.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grp_Settings.Controls.Add(Me.btn_LocalMainPath)
        Me.grp_Settings.Controls.Add(Me.txt_RemoteMainPath)
        Me.grp_Settings.Controls.Add(Me.txt_LocalMainPath)
        Me.grp_Settings.Controls.Add(Me.lbl_RemoteMainPath)
        Me.grp_Settings.Controls.Add(Me.lbl_LocalMainPath)
        Me.grp_Settings.Location = New System.Drawing.Point(12, 13)
        Me.grp_Settings.Name = "grp_Settings"
        Me.grp_Settings.Size = New System.Drawing.Size(980, 100)
        Me.grp_Settings.TabIndex = 6
        Me.grp_Settings.TabStop = False
        Me.grp_Settings.Text = "Settings"
        '
        'btn_LocalMainPath
        '
        Me.btn_LocalMainPath.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_LocalMainPath.BackgroundImage = Global.PARsync.My.Resources.Resources.folder
        Me.btn_LocalMainPath.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_LocalMainPath.Location = New System.Drawing.Point(949, 14)
        Me.btn_LocalMainPath.Name = "btn_LocalMainPath"
        Me.btn_LocalMainPath.Size = New System.Drawing.Size(25, 25)
        Me.btn_LocalMainPath.TabIndex = 4
        Me.btn_LocalMainPath.UseVisualStyleBackColor = True
        '
        'txt_RemoteMainPath
        '
        Me.txt_RemoteMainPath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_RemoteMainPath.Location = New System.Drawing.Point(111, 44)
        Me.txt_RemoteMainPath.Name = "txt_RemoteMainPath"
        Me.txt_RemoteMainPath.Size = New System.Drawing.Size(863, 20)
        Me.txt_RemoteMainPath.TabIndex = 3
        '
        'txt_LocalMainPath
        '
        Me.txt_LocalMainPath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_LocalMainPath.Location = New System.Drawing.Point(111, 17)
        Me.txt_LocalMainPath.Name = "txt_LocalMainPath"
        Me.txt_LocalMainPath.ReadOnly = True
        Me.txt_LocalMainPath.Size = New System.Drawing.Size(832, 20)
        Me.txt_LocalMainPath.TabIndex = 2
        '
        'lbl_RemoteMainPath
        '
        Me.lbl_RemoteMainPath.AutoSize = True
        Me.lbl_RemoteMainPath.Location = New System.Drawing.Point(9, 47)
        Me.lbl_RemoteMainPath.Name = "lbl_RemoteMainPath"
        Me.lbl_RemoteMainPath.Size = New System.Drawing.Size(96, 13)
        Me.lbl_RemoteMainPath.TabIndex = 1
        Me.lbl_RemoteMainPath.Text = "Remote main path:"
        '
        'lbl_LocalMainPath
        '
        Me.lbl_LocalMainPath.AutoSize = True
        Me.lbl_LocalMainPath.Location = New System.Drawing.Point(9, 20)
        Me.lbl_LocalMainPath.Name = "lbl_LocalMainPath"
        Me.lbl_LocalMainPath.Size = New System.Drawing.Size(85, 13)
        Me.lbl_LocalMainPath.TabIndex = 0
        Me.lbl_LocalMainPath.Text = "Local main path:"
        '
        'fbd_LocalMainPath
        '
        Me.fbd_LocalMainPath.ShowNewFolderButton = False
        '
        'bgw_transformLocalPath
        '
        Me.bgw_transformLocalPath.WorkerReportsProgress = True
        '
        'bgw_ReadLocalRating
        '
        Me.bgw_ReadTagRating.WorkerReportsProgress = True
        '
        'bgw_SyncNow
        '
        Me.bgw_SyncNow.WorkerReportsProgress = True
        '
        'sfd_exportNPM
        '
        Me.sfd_exportNPM.FileName = "poweramp_ratings_backup.txt"
        '
        'frm_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1002, 720)
        Me.Controls.Add(Me.grp_Settings)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.grp_Target)
        Me.Controls.Add(Me.grp_Sync)
        Me.Controls.Add(Me.grp_Source)
        Me.Name = "frm_Main"
        Me.Text = "PARsync"
        Me.grp_Source.ResumeLayout(False)
        Me.grp_Source.PerformLayout()
        Me.grp_Sync.ResumeLayout(False)
        Me.grp_FilterDGV.ResumeLayout(False)
        Me.grp_SyncMode.ResumeLayout(False)
        CType(Me.dgv_Tracklist, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_Target.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.grp_Settings.ResumeLayout(False)
        Me.grp_Settings.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ofd_AllTracksCSV As OpenFileDialog
    Friend WithEvents grp_Source As GroupBox
    Friend WithEvents btn_OFD As Button
    Friend WithEvents txt_OFD As TextBox
    Friend WithEvents grp_Sync As GroupBox
    Friend WithEvents grp_Target As GroupBox
    Friend WithEvents lbl_Source_1 As Label
    Friend WithEvents btn_SyncNow As Button
    Friend WithEvents grp_SyncMode As GroupBox
    Friend WithEvents dgv_Tracklist As DataGridView
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents tst_NoOfTracks As ToolStripStatusLabel
    Friend WithEvents sfd_AllTracksCSV As SaveFileDialog
    Friend WithEvents btn_exportNPM As Button
    Friend WithEvents grp_Settings As GroupBox
    Friend WithEvents tst_Status As ToolStripStatusLabel
    Friend WithEvents txt_LocalMainPath As TextBox
    Friend WithEvents lbl_RemoteMainPath As Label
    Friend WithEvents lbl_LocalMainPath As Label
    Friend WithEvents txt_RemoteMainPath As TextBox
    Friend WithEvents btn_LocalMainPath As Button
    Friend WithEvents fbd_LocalMainPath As FolderBrowserDialog
    Friend WithEvents grp_FilterDGV As GroupBox
    Friend WithEvents chk_ToRead As CheckBox
    Friend WithEvents chk_Synced As CheckBox
    Friend WithEvents chk_ToSync As CheckBox
    Friend WithEvents chk_NotFound As CheckBox
    Friend WithEvents bgw_PopulateDGV As System.ComponentModel.BackgroundWorker
    Friend WithEvents bgw_transformLocalPath As System.ComponentModel.BackgroundWorker
    Friend WithEvents bgw_ReadTagRating As System.ComponentModel.BackgroundWorker
    Friend WithEvents tsp_Progress As ToolStripProgressBar
    Friend WithEvents bgw_SyncNow As System.ComponentModel.BackgroundWorker
    Friend WithEvents sfd_exportNPM As SaveFileDialog
    Friend WithEvents rad_SyncMode_AskUser As RadioButton
    Friend WithEvents rad_SyncMode_UseTagRating As RadioButton
    Friend WithEvents rad_SyncMode_UsePowerampRating As RadioButton
End Class
