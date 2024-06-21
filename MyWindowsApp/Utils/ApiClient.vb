Imports System.Net.Http
Imports System.Text
Imports System.Threading.Tasks
Imports Newtonsoft.Json

Public Class ApiClient
    Private Shared ReadOnly client As New HttpClient()

    ' Get a specific submission by index
    Public Shared Async Function GetSubmission(index As Integer) As Task(Of HttpResponseMessage)
        Return Await client.GetAsync($"http://localhost:3000/read?index={index}")
    End Function

    ' Get the total number of submissions
    Public Shared Async Function GetTotalSubmissions() As Task(Of Integer)
        Dim response = Await client.GetAsync("http://localhost:3000/submissions/count")
        response.EnsureSuccessStatusCode()
        Dim responseBody = Await response.Content.ReadAsStringAsync()
        Dim json = JsonConvert.DeserializeObject(Of Dictionary(Of String, Integer))(responseBody)
        Return json("count")
    End Function

    ' Submit form data to the backend
    Public Shared Async Function SubmitFormData(name As String, email As String, phone As String, githubLink As String, stopwatchTime As String) As Task(Of HttpResponseMessage)
        Dim submission As New Dictionary(Of String, String) From {
            {"name", name},
            {"email", email},
            {"phone", phone},
            {"github_link", githubLink},
            {"stopwatch_time", stopwatchTime}
        }
        Dim json = JsonConvert.SerializeObject(submission)
        Dim content = New StringContent(json, Encoding.UTF8, "application/json")
        Return Await client.PostAsync("http://localhost:3000/submit", content)
    End Function

    Private Sub ApiClient_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
