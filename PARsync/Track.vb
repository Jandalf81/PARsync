Imports PARsync

Public Class Track
    ' fields from csv import
    Private remotePath As String
    Private trackno As Integer
    Private track As String
    Private artist As String
    Private album As String
    Private composer As String
    Private duration As Integer
    Private remoteRating As Integer
    Private year As Integer
    Private timesPlayed As Integer
    ' fields from local metadata
    Private localPath As String
    Private localRating As Integer
    Private trackImage As Image
    Private trackStatus As trackStatusEnum

    Public Enum trackStatusEnum
        toRead
        notFound
        toSync
        synced
    End Enum

    Public Property _remotePath As String
        Get
            Return remotePath
        End Get
        Set(value As String)
            remotePath = value
        End Set
    End Property
    Public Property _trackno As Integer
        Get
            Return trackno
        End Get
        Set(value As Integer)
            trackno = value
        End Set
    End Property
    Public Property _track As String
        Get
            Return track
        End Get
        Set(value As String)
            track = value
        End Set
    End Property
    Public Property _artist As String
        Get
            Return artist
        End Get
        Set(value As String)
            artist = value
        End Set
    End Property
    Public Property _album As String
        Get
            Return album
        End Get
        Set(value As String)
            album = value
        End Set
    End Property
    Public Property _composer As String
        Get
            Return composer
        End Get
        Set(value As String)
            composer = value
        End Set
    End Property
    Public Property _duration As Integer
        Get
            Return duration
        End Get
        Set(value As Integer)
            duration = value
        End Set
    End Property
    Public Property _remoteRating As Integer
        Get
            Return remoteRating
        End Get
        Set(value As Integer)
            remoteRating = value
        End Set
    End Property
    Public Property _year As Integer
        Get
            Return year
        End Get
        Set(value As Integer)
            year = value
        End Set
    End Property
    Public Property _timesPlayed As Integer
        Get
            Return timesPlayed
        End Get
        Set(value As Integer)
            timesPlayed = value
        End Set
    End Property
    Public Property _localPath As String
        Get
            Return localPath
        End Get
        Set(value As String)
            localPath = value
        End Set
    End Property
    Public Property _localRating As Integer
        Get
            Return localRating
        End Get
        Set(value As Integer)
            localRating = value
            writeLocalRating(value)
        End Set
    End Property
    Public Property _trackImage As Image
        Get
            Return trackImage
        End Get
        Set(value As Image)
            trackImage = value
        End Set
    End Property
    Public Property _trackStatus As trackStatusEnum
        Get
            Return trackStatus
        End Get
        Set(value As trackStatusEnum)
            trackStatus = value

            'TODO move resources into application
            Select Case value
                Case trackStatusEnum.toRead
                    _trackImage = My.Resources.toRead
                Case trackStatusEnum.notFound
                    _trackImage = My.Resources.notFound
                Case trackStatusEnum.toSync
                    _trackImage = My.Resources.toSync
                Case trackStatusEnum.synced
                    _trackImage = My.Resources.synced
            End Select

        End Set
    End Property

    Public Sub New()
    End Sub
    Public Sub New(
            ByVal remotePath As String,
            ByVal trackno As Integer,
            ByVal track As String,
            ByVal artist As String,
            ByVal album As String,
            ByVal composer As String,
            ByVal duration As Integer,
            ByVal remoteRating As Integer,
            ByVal year As Integer,
            ByVal timesPlayed As Integer)
        Me.remotePath = remotePath
        Me.trackno = trackno
        Me.track = track
        Me.artist = artist
        Me.album = album
        Me.composer = composer
        Me.duration = duration
        Me.remoteRating = remoteRating
        Me.year = year
        Me.timesPlayed = timesPlayed

        Me.localPath = ""
        Me.localRating = 0
        Me._trackStatus = trackStatusEnum.toRead
    End Sub

    Public Sub transformToLocalPath(ByVal remoteMainPath As String, ByVal localMainPath As String)
        Dim tmpLocalPath As String

        tmpLocalPath = Replace(Me._remotePath, remoteMainPath, localMainPath)
        tmpLocalPath = Replace(tmpLocalPath, "/", "\")

        Me._localPath = tmpLocalPath

        If (My.Computer.FileSystem.FileExists(Me._localPath) = False) Then
            Me.trackImage = Image.FromFile(My.Application.Info.DirectoryPath + "\icons\notFound.png")
        End If
    End Sub

    Public Sub readLocalRating()
        TagLib.Id3v2.Tag.DefaultVersion = 3
        TagLib.Id3v2.Tag.ForceDefaultVersion = True

        If (My.Computer.FileSystem.FileExists(Me._localPath) = True) Then
            Dim mp3 As TagLib.File = TagLib.File.Create(Me._localPath)
            Dim tag As TagLib.Tag = mp3.GetTag(TagLib.TagTypes.Id3v2)

            Dim popm As TagLib.Id3v2.PopularimeterFrame = TagLib.Id3v2.PopularimeterFrame.Get(tag, "Windows Media Player 9 Series", True)

            Select Case popm.Rating
                Case 0
                    Me._localRating = 0
                Case 1
                    Me._localRating = 1
                Case 64
                    Me._localRating = 2
                Case 128
                    Me._localRating = 3
                Case 196
                    Me._localRating = 4
                Case 255
                    Me._localRating = 5
                Case Else
                    MsgBox(popm.Rating.ToString())
            End Select

            mp3.Dispose()
        End If
    End Sub

    Public Sub writeLocalRating(ByVal rating As Integer)
        TagLib.Id3v2.Tag.DefaultVersion = 3
        TagLib.Id3v2.Tag.ForceDefaultVersion = True

        Dim mp3 As TagLib.File = TagLib.File.Create(Me._localPath)
        Dim tag As TagLib.Tag = mp3.GetTag(TagLib.TagTypes.Id3v2)

        Dim popm As TagLib.Id3v2.PopularimeterFrame = TagLib.Id3v2.PopularimeterFrame.Get(tag, "Windows Media Player 9 Series", True)

        Select Case rating
            Case 0
                popm.Rating = 0
            Case 1
                popm.Rating = 1
            Case 2
                popm.Rating = 64
            Case 3
                popm.Rating = 128
            Case 4
                popm.Rating = 196
            Case 5
                popm.Rating = 255
        End Select

        mp3.Save()
        mp3.Dispose()
    End Sub
End Class
