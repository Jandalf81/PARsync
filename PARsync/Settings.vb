Imports System.IO

Public Class Settings
    Private localMainPath As String
    Public Property _localMainPath As String
        Get
            Return localMainPath
        End Get
        Set(ByVal value As String)
            localMainPath = value
        End Set
    End Property

    Private remoteMainPath As String
    Public Property _remoteMainPath As String
        Get
            Return remoteMainPath
        End Get
        Set(ByVal value As String)
            remoteMainPath = value
        End Set
    End Property

    Public Enum syncModeEnum
        askUser
        useTagRating
        usePowerampRating
    End Enum

    Private syncMode As syncModeEnum
    Public Property _syncMode As syncModeEnum
        Get
            Return syncMode
        End Get
        Set(ByVal value As syncModeEnum)
            syncMode = value
        End Set
    End Property

    Public Sub save()
        Dim x As New Xml.Serialization.XmlSerializer(Me.GetType)
        Dim fileWriter As StreamWriter

        fileWriter = My.Computer.FileSystem.OpenTextFileWriter(My.Application.Info.DirectoryPath + "\settings.xml", False)
        x.Serialize(fileWriter, Me)
        fileWriter.Close()
    End Sub

    Public Sub load()
        Dim ISettings As New Settings()
        Dim x As New Xml.Serialization.XmlSerializer(Me.GetType)

        Using fs As New FileStream(My.Application.Info.DirectoryPath + "\settings.xml", FileMode.Open)
            ISettings = x.Deserialize(fs)
        End Using

        Me._localMainPath = ISettings._localMainPath
        Me._remoteMainPath = ISettings._remoteMainPath
        Me._syncMode = ISettings._syncMode
    End Sub
End Class
