Imports System.IO
Imports System.Net
Imports System.Net.Http
Imports System.Threading
Imports Newtonsoft.Json

Public Class mainform
    Dim ResolveTemplate As String = "http://api.soundcloud.com/resolve?url={0}&client_id={1}"
    Dim StreamTemplate As String = "{0}?client_id={1}"
    Dim [Set] As Settings

    Private Sub mainform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetColors()
        SetFormLocation()
        GetSettings()
    End Sub

    Private Sub GetSettings()
        Dim pathToSettings As String = String.Format("{0}\settings.json", Application.StartupPath)

        If File.Exists(pathToSettings) Then
            Using reader As New StreamReader(pathToSettings)
                [Set] = JsonConvert.DeserializeObject(Of Settings)(reader.ReadToEnd)
            End Using
        Else
            [Set] = New Settings
            [Set].ClientID = "2t9loNQH90kzJcsFCODdigxfp325aq4z"
            [Set].Directory = String.Format("{0}\{1}", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "SoundCloud")

            If Not Directory.Exists([Set].Directory) Then
                Directory.CreateDirectory([Set].Directory)
            End If

            Using writer As New StreamWriter(pathToSettings)
                writer.Write(JsonConvert.SerializeObject([Set]))
            End Using
        End If
    End Sub

    Private Sub SetColors()
        Me.BackColor = Colors.LightBlack

        Dim buttons As FlatButton() = {FlatButton2, FlatButton3}
        For Each button As FlatButton In buttons
            button.BackColor = Colors.LightBlack
            button.FlatAppearance.BorderSize = 0
            button.FlatAppearance.MouseDownBackColor = Colors.Black
            button.FlatAppearance.MouseOverBackColor = Colors.LightBlack
            button.FlatAppearance.CheckedBackColor = Color.Black
            button.Font = New Font("Segoe UI", 9)
        Next
    End Sub

    Private Sub SetFormLocation()
        Me.DesktopLocation = New Point(My.Computer.Screen.WorkingArea.Width - (Me.Width + 15), My.Computer.Screen.WorkingArea.Height - (Me.Height + 15))
    End Sub

    Private Sub tWatcher_Tick(sender As Object, e As EventArgs) Handles tWatcher.Tick
        If Clipboard.ContainsText Then
            If Clipboard.GetData(DataFormats.Text).ToString.Contains("https://soundcloud.com/") Then
                ThreadPool.QueueUserWorkItem(AddressOf Download, Clipboard.GetData(DataFormats.Text).ToString)

                Clipboard.Clear()
            End If
        End If
    End Sub

    Public Function RetrieveSource(ByVal url As String) As String
        Using cl As New HttpClient
            Dim response = cl.GetAsync(String.Format(ResolveTemplate, url, [Set].ClientID))

            If response.Result.StatusCode = Net.HttpStatusCode.OK Then
                Return response.Result.Content.ReadAsStringAsync.Result
            Else
                Return String.Empty
            End If
        End Using
    End Function

    Private Sub Download(ByVal url As String)
        Dim page As String = RetrieveSource(url)
        Dim track As Track = JsonConvert.DeserializeObject(Of Track)(page)
        Dim streamUrl As String = String.Format(StreamTemplate, track.StreamUrl, [Set].ClientID)
        Dim fileName As String = String.Format("{0}\{1}.mp3", [Set].Directory, track.Title)

        If Not File.Exists(fileName) Then
            Dim req As HttpWebRequest

            Try
                req = HttpWebRequest.Create(streamUrl)
            Catch ex As WebException
                MsgBox("Download failed" & vbNewLine & vbNewLine & ex.Message)
            End Try

            Using resp As HttpWebResponse = DirectCast(req.GetResponse, HttpWebResponse)
                Dim buffer(1024 * 8) As Byte
                Dim cSize As Long = 0
                Dim tSize As Long = resp.ContentLength

                Using fs As New FileStream(fileName, FileMode.Create)
                    Do While cSize < tSize
                        Dim read As Integer = resp.GetResponseStream.Read(buffer, 0, buffer.Length)

                        fs.Write(buffer, 0, read)

                        cSize += read
                    Loop
                End Using
            End Using
        End If

        track = Nothing
    End Sub

End Class
