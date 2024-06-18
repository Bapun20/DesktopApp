Imports System.Net.Http
Imports Newtonsoft.Json

Public Class ViewSubmissionsForm
    Private currentIndex As Integer = 0

    Private Async Sub ViewSubmissionsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KeyPreview = True
        Await LoadSubmission(currentIndex)
    End Sub

    Private Async Function LoadSubmission(index As Integer) As Task
        Using client As New HttpClient()
            Dim response As HttpResponseMessage = Await client.GetAsync($"http://localhost:3000/read?index={index}")
            If response.IsSuccessStatusCode Then
                Dim json As String = Await response.Content.ReadAsStringAsync()
                Dim submission As Dictionary(Of String, String) = JsonConvert.DeserializeObject(Of Dictionary(Of String, String))(json)
                DisplaySubmission(submission)
            Else
                MessageBox.Show("Failed to load submission.")
            End If
        End Using
    End Function

    Private Sub DisplaySubmission(submission As Dictionary(Of String, String))
        txtName.Text = submission("name")
        txtEmail.Text = submission("email")
        txtPhoneNum.Text = submission("phone")
        txtGithubLink.Text = submission("github_link")
        txtStopwatchTime.Text = submission("stopwatch_time")
    End Sub

    Private Async Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If currentIndex > 0 Then
            currentIndex -= 1
            Await LoadSubmission(currentIndex)
        End If
    End Sub

    Private Async Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        currentIndex += 1
        Await LoadSubmission(currentIndex)
    End Sub

    Private Async Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Using client As New HttpClient()
            Dim response As HttpResponseMessage = Await client.DeleteAsync($"http://localhost:3000/delete?index={currentIndex}")
            If response.IsSuccessStatusCode Then
                MessageBox.Show("Submission deleted successfully.")
                If currentIndex > 0 Then
                    currentIndex -= 1
                End If
                Await LoadSubmission(currentIndex)
            Else
                MessageBox.Show("Failed to delete submission.")
            End If
        End Using
    End Sub

    Private Sub ViewSubmissionsForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.P Then
            btnPrevious.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.N Then
            btnNext.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.D Then
            btnDelete.PerformClick()
        End If
    End Sub
End Class
