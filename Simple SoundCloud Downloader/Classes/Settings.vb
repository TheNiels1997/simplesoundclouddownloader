Imports Newtonsoft.Json

Public Class Settings
    <JsonProperty("Directory")>
    Public Property Directory As String

    <JsonProperty("ClientID")>
    Public Property ClientID As String
End Class
