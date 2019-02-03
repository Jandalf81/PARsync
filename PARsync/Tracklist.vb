Imports System.IO

Public Class Tracklist
    Public Property tracks As New List(Of Track)

    Public Sub New()
    End Sub

    Public Sub importCSV(ByVal myFile As String)
        Me.tracks.Clear()

        If (My.Computer.FileSystem.FileExists(myFile) = True) Then
            ' MsgBox("Datei existiert")

            Dim fileReader As StreamReader
            Dim line As String

            Dim remotePath As String
            Dim trackno As Integer
            Dim track As String
            Dim artist As String
            Dim album As String
            Dim composer As String
            Dim duration As Integer
            Dim remoteRating As Integer
            Dim year As Integer
            Dim timesPlayed As Integer

            fileReader = My.Computer.FileSystem.OpenTextFileReader(myFile)
            line = fileReader.ReadLine

            Do
                line = fileReader.ReadLine

                If line Is Nothing Then Exit Do

                Dim parts As String() = Split(line, """|""")

                ' get fields from line
                remotePath = parts(0).Replace("""", "")
                trackno = CInt(parts(1).Replace("""", ""))
                track = parts(2).Replace("""", "")
                artist = parts(3).Replace("""", "")
                album = parts(4).Replace("""", "")
                composer = parts(5).Replace("""", "")
                duration = CInt(parts(6).Replace("""", "").Replace("null", "0"))
                year = CInt(parts(7).Replace("""", "").Replace("null", "0"))
                remoteRating = CInt(parts(8).Replace("""", "").Replace("null", "0"))
                timesPlayed = CInt(parts(9).Replace("""", ""))

                Dim t As New Track(
                           remotePath,
                           trackno,
                           track,
                           artist,
                           album,
                           composer,
                           duration,
                           remoteRating,
                           year,
                           timesPlayed)

                ' add new Track to Tracklist
                Me.tracks.Add(t)
            Loop

            fileReader.Close()
        Else
            MsgBox("Datei existiert nicht")
        End If
    End Sub

    Public Sub exportCSV(ByVal myFile As String)
        Dim fileWriter As StreamWriter
        Dim line As String = ""
        Dim content As String = ""

        For Each track In tracks
            line = """" + track._remotePath + """|"
            line += """" + track._track.ToString + """|"
            line += """" + track._title + """|"
            line += """" + track._artist + """|"
            line += """" + track._album + """|"
            line += """" + track._composer + """|"
            line += """" + track._duration.ToString + """|"
            line += """" + track._year.ToString + """|"
            line += """" + track._PowerampRating.ToString + """|"
            line += """" + track._timesPlayed.ToString + """"

            content += line + vbCrLf
        Next

        fileWriter = My.Computer.FileSystem.OpenTextFileWriter(myFile, False)
        fileWriter.Write(content)
        fileWriter.Close()
    End Sub

    Public Sub exportNPM(ByVal myFile As String)
        Dim fileWriter As StreamWriter
        Dim line As String = ""
        Dim content As String = ""

        Dim m3u As String = ""

        content = "Track|Rating|Times Played|Last Played|albumTitle|artist|" + vbLf

        For Each track In tracks
            If (track._hasBeenUpdated = True) Then
                line = """" + Path.GetFileName(track._localPath) + """##"
                line += """" + track._PowerampRating.ToString + """##"
                line += """" + track._timesPlayed.ToString + """##"
                line += """0""##"
                line += """" + track._album + """##"
                line += """" + track._artist + """"

                content += line + vbLf
            End If

            If track._PowerampRating > 0 Then
                m3u += track._remotePath + vbCrLf
            End If
        Next

        fileWriter = My.Computer.FileSystem.OpenTextFileWriter(myFile, False)
        fileWriter.Write(content)
        fileWriter.Close()

        fileWriter = My.Computer.FileSystem.OpenTextFileWriter(myFile.Remove(myFile.LastIndexOf("\")) + "\_hasRating.m3u", False)
        fileWriter.Write(m3u)
        fileWriter.Close()
    End Sub
End Class
