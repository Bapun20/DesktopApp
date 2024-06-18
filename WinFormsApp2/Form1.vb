Imports System.Drawing

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True

        ' Add event handlers for focus events
        AddHandler btnViewSubmissions.Enter, AddressOf Button_Enter
        AddHandler btnViewSubmissions.Leave, AddressOf Button_Leave
        AddHandler btnCreateSubmission.Enter, AddressOf Button_Enter
        AddHandler btnCreateSubmission.Leave, AddressOf Button_Leave
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.V Then
            btnViewSubmissions.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.N Then
            btnCreateSubmission.PerformClick()
        End If
    End Sub

    Private Sub btnViewSubmissions_Click(sender As Object, e As EventArgs) Handles btnViewSubmissions.Click
        Dim viewForm As New ViewSubmissionsForm()
        viewForm.Show()
    End Sub

    Private Sub btnCreateSubmission_Click(sender As Object, e As EventArgs) Handles btnCreateSubmission.Click
        Dim createForm As New CreateSubmissionForm()
        createForm.Show()
    End Sub

    ' Event handlers to remove dark boundary when button is focused
    Private Sub Button_Enter(sender As Object, e As EventArgs)
        Dim btn As Button = CType(sender, Button)
        btn.FlatAppearance.BorderSize = 0
    End Sub

    Private Sub Button_Leave(sender As Object, e As EventArgs)
        Dim btn As Button = CType(sender, Button)
        btn.FlatAppearance.BorderSize = 1
    End Sub
End Class
