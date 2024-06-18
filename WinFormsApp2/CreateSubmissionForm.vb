Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json
Imports System.Diagnostics

Public Class CreateSubmissionForm
    Private stopwatch As New Stopwatch()
    Private WithEvents timer As New Timer()

    Private Sub CreateSubmissionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtStopwatchTime.Text = "00:00:00"
        AddHandler timer.Tick, AddressOf Timer_Tick
        timer.Interval = 1000 ' 1 second
        Me.KeyPreview = True ' Enable key preview for the form to handle key events

        ' Start the stopwatch and timer when the form loads
        stopwatch.Start()
        timer.Start()
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles timer.Tick
        txtStopwatchTime.Text = stopwatch.Elapsed.ToString("hh\:mm\:ss")
    End Sub

    Private Sub btnToggleStopwatch_Click(sender As Object, e As EventArgs) Handles btnToggleStopwatch.Click
        If stopwatch.IsRunning Then
            stopwatch.Stop()
            timer.Stop()
        Else
            stopwatch.Start()
            timer.Start()
        End If
    End Sub

    Private Async Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim submission As New Dictionary(Of String, String) From {
            {"name", txtName.Text},
            {"email", txtEmail.Text},
            {"phone", txtPhoneNum.Text},
            {"github_link", txtGithubLink.Text},
            {"stopwatch_time", txtStopwatchTime.Text}
        }

        Dim json As String = JsonConvert.SerializeObject(submission)
        Dim content As New StringContent(json, Encoding.UTF8, "application/json")

        Using client As New HttpClient()
            Dim response As HttpResponseMessage = Await client.PostAsync("http://localhost:3000/submit", content)
            If response.IsSuccessStatusCode Then
                MessageBox.Show("Submission saved successfully!")
            Else
                MessageBox.Show("Failed to save submission.")
            End If
        End Using
    End Sub

    Private Sub CreateSubmissionForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.T Then
            btnToggleStopwatch.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.S Then
            btnSubmit.PerformClick()
        End If
    End Sub
End Class
