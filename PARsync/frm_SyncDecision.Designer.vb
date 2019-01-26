<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_SyncDecision
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grp_Track = New System.Windows.Forms.GroupBox()
        Me.lbl_Track_RemotePath = New System.Windows.Forms.Label()
        Me.lbl_RemotePath = New System.Windows.Forms.Label()
        Me.lbl_Track_LocalPath = New System.Windows.Forms.Label()
        Me.lbl_LocalPath = New System.Windows.Forms.Label()
        Me.pic_Cover = New System.Windows.Forms.PictureBox()
        Me.lbl_Track_Title = New System.Windows.Forms.Label()
        Me.lbl_Track_Track = New System.Windows.Forms.Label()
        Me.lbl_Track_Album = New System.Windows.Forms.Label()
        Me.lbl_Track_Artist = New System.Windows.Forms.Label()
        Me.lbl_Title = New System.Windows.Forms.Label()
        Me.lbl_Track = New System.Windows.Forms.Label()
        Me.lbl_Album = New System.Windows.Forms.Label()
        Me.lbl_Artist = New System.Windows.Forms.Label()
        Me.grp_Buttons = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btn_UseRemoteRating = New System.Windows.Forms.Button()
        Me.btn_UseLocalRating = New System.Windows.Forms.Button()
        Me.btn_Cancel = New System.Windows.Forms.Button()
        Me.grp_Track.SuspendLayout()
        CType(Me.pic_Cover, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_Buttons.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(227, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Please decide which rating to use for this track"
        '
        'grp_Track
        '
        Me.grp_Track.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grp_Track.Controls.Add(Me.lbl_Track_RemotePath)
        Me.grp_Track.Controls.Add(Me.lbl_RemotePath)
        Me.grp_Track.Controls.Add(Me.lbl_Track_LocalPath)
        Me.grp_Track.Controls.Add(Me.lbl_LocalPath)
        Me.grp_Track.Controls.Add(Me.pic_Cover)
        Me.grp_Track.Controls.Add(Me.lbl_Track_Title)
        Me.grp_Track.Controls.Add(Me.lbl_Track_Track)
        Me.grp_Track.Controls.Add(Me.lbl_Track_Album)
        Me.grp_Track.Controls.Add(Me.lbl_Track_Artist)
        Me.grp_Track.Controls.Add(Me.lbl_Title)
        Me.grp_Track.Controls.Add(Me.lbl_Track)
        Me.grp_Track.Controls.Add(Me.lbl_Album)
        Me.grp_Track.Controls.Add(Me.lbl_Artist)
        Me.grp_Track.Location = New System.Drawing.Point(12, 25)
        Me.grp_Track.Name = "grp_Track"
        Me.grp_Track.Size = New System.Drawing.Size(553, 172)
        Me.grp_Track.TabIndex = 4
        Me.grp_Track.TabStop = False
        Me.grp_Track.Text = "Track"
        '
        'lbl_Track_RemotePath
        '
        Me.lbl_Track_RemotePath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Track_RemotePath.AutoEllipsis = True
        Me.lbl_Track_RemotePath.Location = New System.Drawing.Point(106, 90)
        Me.lbl_Track_RemotePath.Name = "lbl_Track_RemotePath"
        Me.lbl_Track_RemotePath.Size = New System.Drawing.Size(289, 13)
        Me.lbl_Track_RemotePath.TabIndex = 12
        Me.lbl_Track_RemotePath.Text = "Label2"
        '
        'lbl_RemotePath
        '
        Me.lbl_RemotePath.AutoSize = True
        Me.lbl_RemotePath.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_RemotePath.Location = New System.Drawing.Point(7, 90)
        Me.lbl_RemotePath.Name = "lbl_RemotePath"
        Me.lbl_RemotePath.Size = New System.Drawing.Size(84, 13)
        Me.lbl_RemotePath.TabIndex = 11
        Me.lbl_RemotePath.Text = "Remote Path:"
        '
        'lbl_Track_LocalPath
        '
        Me.lbl_Track_LocalPath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Track_LocalPath.AutoEllipsis = True
        Me.lbl_Track_LocalPath.Location = New System.Drawing.Point(106, 77)
        Me.lbl_Track_LocalPath.Name = "lbl_Track_LocalPath"
        Me.lbl_Track_LocalPath.Size = New System.Drawing.Size(289, 13)
        Me.lbl_Track_LocalPath.TabIndex = 10
        Me.lbl_Track_LocalPath.Text = "Label2"
        '
        'lbl_LocalPath
        '
        Me.lbl_LocalPath.AutoSize = True
        Me.lbl_LocalPath.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_LocalPath.Location = New System.Drawing.Point(7, 77)
        Me.lbl_LocalPath.Name = "lbl_LocalPath"
        Me.lbl_LocalPath.Size = New System.Drawing.Size(72, 13)
        Me.lbl_LocalPath.TabIndex = 9
        Me.lbl_LocalPath.Text = "Local Path:"
        '
        'pic_Cover
        '
        Me.pic_Cover.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pic_Cover.Location = New System.Drawing.Point(401, 20)
        Me.pic_Cover.Name = "pic_Cover"
        Me.pic_Cover.Size = New System.Drawing.Size(146, 146)
        Me.pic_Cover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_Cover.TabIndex = 8
        Me.pic_Cover.TabStop = False
        '
        'lbl_Track_Title
        '
        Me.lbl_Track_Title.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Track_Title.AutoEllipsis = True
        Me.lbl_Track_Title.Location = New System.Drawing.Point(106, 59)
        Me.lbl_Track_Title.Name = "lbl_Track_Title"
        Me.lbl_Track_Title.Size = New System.Drawing.Size(289, 14)
        Me.lbl_Track_Title.TabIndex = 7
        Me.lbl_Track_Title.Text = "Label2"
        '
        'lbl_Track_Track
        '
        Me.lbl_Track_Track.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Track_Track.AutoEllipsis = True
        Me.lbl_Track_Track.Location = New System.Drawing.Point(106, 46)
        Me.lbl_Track_Track.Name = "lbl_Track_Track"
        Me.lbl_Track_Track.Size = New System.Drawing.Size(289, 14)
        Me.lbl_Track_Track.TabIndex = 6
        Me.lbl_Track_Track.Text = "Label2"
        '
        'lbl_Track_Album
        '
        Me.lbl_Track_Album.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Track_Album.AutoEllipsis = True
        Me.lbl_Track_Album.Location = New System.Drawing.Point(106, 33)
        Me.lbl_Track_Album.Name = "lbl_Track_Album"
        Me.lbl_Track_Album.Size = New System.Drawing.Size(289, 14)
        Me.lbl_Track_Album.TabIndex = 5
        Me.lbl_Track_Album.Text = "Label2"
        '
        'lbl_Track_Artist
        '
        Me.lbl_Track_Artist.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Track_Artist.AutoEllipsis = True
        Me.lbl_Track_Artist.Location = New System.Drawing.Point(106, 20)
        Me.lbl_Track_Artist.Name = "lbl_Track_Artist"
        Me.lbl_Track_Artist.Size = New System.Drawing.Size(289, 14)
        Me.lbl_Track_Artist.TabIndex = 4
        Me.lbl_Track_Artist.Text = "Label2"
        '
        'lbl_Title
        '
        Me.lbl_Title.AutoSize = True
        Me.lbl_Title.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Title.Location = New System.Drawing.Point(7, 59)
        Me.lbl_Title.Name = "lbl_Title"
        Me.lbl_Title.Size = New System.Drawing.Size(36, 13)
        Me.lbl_Title.TabIndex = 3
        Me.lbl_Title.Text = "Title:"
        '
        'lbl_Track
        '
        Me.lbl_Track.AutoSize = True
        Me.lbl_Track.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Track.Location = New System.Drawing.Point(7, 46)
        Me.lbl_Track.Name = "lbl_Track"
        Me.lbl_Track.Size = New System.Drawing.Size(44, 13)
        Me.lbl_Track.TabIndex = 2
        Me.lbl_Track.Text = "Track:"
        '
        'lbl_Album
        '
        Me.lbl_Album.AutoSize = True
        Me.lbl_Album.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Album.Location = New System.Drawing.Point(7, 33)
        Me.lbl_Album.Name = "lbl_Album"
        Me.lbl_Album.Size = New System.Drawing.Size(45, 13)
        Me.lbl_Album.TabIndex = 1
        Me.lbl_Album.Text = "Album:"
        '
        'lbl_Artist
        '
        Me.lbl_Artist.AutoSize = True
        Me.lbl_Artist.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Artist.Location = New System.Drawing.Point(7, 20)
        Me.lbl_Artist.Name = "lbl_Artist"
        Me.lbl_Artist.Size = New System.Drawing.Size(40, 13)
        Me.lbl_Artist.TabIndex = 0
        Me.lbl_Artist.Text = "Artist:"
        '
        'grp_Buttons
        '
        Me.grp_Buttons.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grp_Buttons.Controls.Add(Me.TableLayoutPanel1)
        Me.grp_Buttons.Controls.Add(Me.btn_Cancel)
        Me.grp_Buttons.Location = New System.Drawing.Point(12, 203)
        Me.grp_Buttons.Name = "grp_Buttons"
        Me.grp_Buttons.Size = New System.Drawing.Size(554, 143)
        Me.grp_Buttons.TabIndex = 5
        Me.grp_Buttons.TabStop = False
        Me.grp_Buttons.Text = "Decision"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btn_UseRemoteRating, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_UseLocalRating, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(6, 19)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(541, 57)
        Me.TableLayoutPanel1.TabIndex = 7
        '
        'btn_UseRemoteRating
        '
        Me.btn_UseRemoteRating.AutoSize = True
        Me.btn_UseRemoteRating.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_UseRemoteRating.Image = Global.PARsync.My.Resources.Resources.star_0
        Me.btn_UseRemoteRating.Location = New System.Drawing.Point(273, 0)
        Me.btn_UseRemoteRating.Margin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.btn_UseRemoteRating.Name = "btn_UseRemoteRating"
        Me.btn_UseRemoteRating.Size = New System.Drawing.Size(268, 57)
        Me.btn_UseRemoteRating.TabIndex = 6
        Me.btn_UseRemoteRating.Text = "use PowerAmp Rating"
        Me.btn_UseRemoteRating.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btn_UseRemoteRating.UseVisualStyleBackColor = True
        '
        'btn_UseLocalRating
        '
        Me.btn_UseLocalRating.AutoSize = True
        Me.btn_UseLocalRating.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_UseLocalRating.Image = Global.PARsync.My.Resources.Resources.star_0
        Me.btn_UseLocalRating.Location = New System.Drawing.Point(0, 0)
        Me.btn_UseLocalRating.Margin = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.btn_UseLocalRating.Name = "btn_UseLocalRating"
        Me.btn_UseLocalRating.Size = New System.Drawing.Size(267, 57)
        Me.btn_UseLocalRating.TabIndex = 5
        Me.btn_UseLocalRating.Text = "use Tag Rating"
        Me.btn_UseLocalRating.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btn_UseLocalRating.UseVisualStyleBackColor = True
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Cancel.Location = New System.Drawing.Point(6, 81)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(542, 57)
        Me.btn_Cancel.TabIndex = 6
        Me.btn_Cancel.Text = "Cancel" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "no Change"
        Me.btn_Cancel.UseVisualStyleBackColor = True
        '
        'frm_SyncDecision
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(577, 352)
        Me.Controls.Add(Me.grp_Buttons)
        Me.Controls.Add(Me.grp_Track)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_SyncDecision"
        Me.ShowInTaskbar = False
        Me.Text = "PARsync - Sync Decision"
        Me.grp_Track.ResumeLayout(False)
        Me.grp_Track.PerformLayout()
        CType(Me.pic_Cover, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_Buttons.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents grp_Track As GroupBox
    Friend WithEvents lbl_Track_Title As Label
    Friend WithEvents lbl_Track_Track As Label
    Friend WithEvents lbl_Track_Album As Label
    Friend WithEvents lbl_Track_Artist As Label
    Friend WithEvents lbl_Title As Label
    Friend WithEvents lbl_Track As Label
    Friend WithEvents lbl_Album As Label
    Friend WithEvents lbl_Artist As Label
    Friend WithEvents pic_Cover As PictureBox
    Friend WithEvents lbl_LocalPath As Label
    Friend WithEvents lbl_Track_LocalPath As Label
    Friend WithEvents lbl_Track_RemotePath As Label
    Friend WithEvents lbl_RemotePath As Label
    Friend WithEvents grp_Buttons As GroupBox
    Friend WithEvents btn_Cancel As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btn_UseRemoteRating As Button
    Friend WithEvents btn_UseLocalRating As Button
End Class
