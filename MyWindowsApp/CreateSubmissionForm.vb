Public Class CreateSubmissionForm
    Private stopwatchRunning As Boolean = False
    Private stopwatchTime As TimeSpan = TimeSpan.Zero

    Private Sub btnStopwatch_Click(sender As Object, e As EventArgs) Handles btnStopwatch.Click
        If stopwatchRunning Then
            timerStopwatch.Stop()
            btnStopwatch.Text = "Start Stopwatch"
        Else
            timerStopwatch.Start()
            btnStopwatch.Text = "Pause Stopwatch"
        End If
        stopwatchRunning = Not stopwatchRunning
    End Sub

    Private Sub timerStopwatch_Tick(sender As Object, e As EventArgs) Handles timerStopwatch.Tick
        stopwatchTime = stopwatchTime.Add(TimeSpan.FromSeconds(1))
        lblStopwatch.Text = stopwatchTime.ToString("hh\:mm\:ss")
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        ' Code to handle form submission, such as saving to a database or a file
        Dim submission As String = $"Name: {txtName.Text}, Email: {txtEmail.Text}, Phone: {txtPhoneNumber.Text}, GitHub: {txtGithubLink.Text}"
        ' Example: Save submission to a file or database
        MessageBox.Show("Submission Saved: " & submission)
    End Sub

    Private Sub CreateSubmissionForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.S Then
            btnSubmit.PerformClick()
        End If
    End Sub
End Class
