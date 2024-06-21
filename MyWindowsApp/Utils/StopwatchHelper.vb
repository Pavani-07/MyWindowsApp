Imports System.Diagnostics

Public Class StopwatchHelper
    Private ReadOnly stopwatch As Stopwatch = New Stopwatch()

    Public Sub Start()
        stopwatch.Start()
    End Sub

    Public Sub [Stop]()
        stopwatch.Stop()
    End Sub

    Public Function IsRunning() As Boolean
        Return stopwatch.IsRunning
    End Function

    Public Function GetElapsedTime() As String
        Return stopwatch.Elapsed.ToString("hh\:mm\:ss")
    End Function

    Private Sub StopwatchHelper_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
