Imports Newtonsoft.Json

Public Class Track
    <JsonProperty("stream_url")>
    Public Property StreamUrl As String

    <JsonProperty("title")>
    Public Property Title As String
End Class
