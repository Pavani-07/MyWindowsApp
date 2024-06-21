Public Class ViewSubmissionsForm
    Private submissions As List(Of String) = New List(Of String) ' Replace with actual submission data
    Private currentIndex As Integer = 0

    Private Sub ViewSubmissionsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Example submissions
        submissions.Add("Name: John Doe, Email: john@example.com, Phone: 1234567890, GitHub: https://github.com/johndoe")
        submissions.Add("Name: Jane Smith, Email: jane@example.com, Phone: 0987654321, GitHub: https://github.com/janesmith")
        DisplaySubmission()
    End Sub

    Private Sub DisplaySubmission()
        If submissions.Count > 0 Then
            lblSubmissionDetails.Text = submissions(currentIndex)
        Else
            lblSubmissionDetails.Text = "No submissions available."
        End If
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If currentIndex > 0 Then
            currentIndex -= 1
            DisplaySubmission()
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If currentIndex < submissions.Count - 1 Then
            currentIndex += 1
            DisplaySubmission()
        End If
    End Sub
End Class
