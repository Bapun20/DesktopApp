<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ViewSubmissionsForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        txtName = New TextBox()
        txtEmail = New TextBox()
        txtPhoneNum = New TextBox()
        txtGithubLink = New TextBox()
        txtStopwatchTime = New TextBox()
        btnPrevious = New Button()
        btnNext = New Button()
        btnDelete = New Button()
        lblTitle = New Label()
        lblName = New Label()
        lblEmail = New Label()
        lblPhoneNum = New Label()
        lblGithubLink = New Label()
        lblStopwatchTime = New Label()
        SuspendLayout()
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(140, 50)
        txtName.Name = "txtName"
        txtName.ReadOnly = True
        txtName.Size = New Size(200, 27)
        txtName.TabIndex = 0
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(140, 90)
        txtEmail.Name = "txtEmail"
        txtEmail.ReadOnly = True
        txtEmail.Size = New Size(200, 27)
        txtEmail.TabIndex = 1
        ' 
        ' txtPhoneNum
        ' 
        txtPhoneNum.Location = New Point(140, 130)
        txtPhoneNum.Name = "txtPhoneNum"
        txtPhoneNum.ReadOnly = True
        txtPhoneNum.Size = New Size(200, 27)
        txtPhoneNum.TabIndex = 2
        ' 
        ' txtGithubLink
        ' 
        txtGithubLink.Location = New Point(140, 170)
        txtGithubLink.Name = "txtGithubLink"
        txtGithubLink.ReadOnly = True
        txtGithubLink.Size = New Size(200, 27)
        txtGithubLink.TabIndex = 3
        ' 
        ' txtStopwatchTime
        ' 
        txtStopwatchTime.Location = New Point(140, 210)
        txtStopwatchTime.Name = "txtStopwatchTime"
        txtStopwatchTime.ReadOnly = True
        txtStopwatchTime.Size = New Size(200, 27)
        txtStopwatchTime.TabIndex = 4
        ' 
        ' btnPrevious
        ' 
        btnPrevious.Location = New Point(20, 260)
        btnPrevious.Name = "btnPrevious"
        btnPrevious.Size = New Size(164, 30)
        btnPrevious.TabIndex = 5
        btnPrevious.Text = "PREVIOUS (CTRL + P)"
        btnPrevious.UseVisualStyleBackColor = True
        ' 
        ' btnNext
        ' 
        btnNext.Location = New Point(209, 260)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(164, 30)
        btnNext.TabIndex = 6
        btnNext.Text = "NEXT (CTRL + N)"
        btnNext.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(100, 300)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(164, 30)
        btnDelete.TabIndex = 7
        btnDelete.Text = "DELETE (CTRL + D)"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Location = New Point(20, 10)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(296, 20)
        lblTitle.TabIndex = 8
        lblTitle.Text = "John Doe, Slidely Task 2 - View Submissions"
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Location = New Point(10, 50)
        lblName.Name = "lblName"
        lblName.Size = New Size(49, 20)
        lblName.TabIndex = 9
        lblName.Text = "Name"
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Location = New Point(10, 90)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(46, 20)
        lblEmail.TabIndex = 10
        lblEmail.Text = "Email"
        ' 
        ' lblPhoneNum
        ' 
        lblPhoneNum.AutoSize = True
        lblPhoneNum.Location = New Point(10, 130)
        lblPhoneNum.Name = "lblPhoneNum"
        lblPhoneNum.Size = New Size(86, 20)
        lblPhoneNum.TabIndex = 11
        lblPhoneNum.Text = "Phone Num"
        ' 
        ' lblGithubLink
        ' 
        lblGithubLink.AutoSize = True
        lblGithubLink.Location = New Point(10, 173)
        lblGithubLink.Name = "lblGithubLink"
        lblGithubLink.Size = New Size(83, 20)
        lblGithubLink.TabIndex = 12
        lblGithubLink.Text = "Github Link"
        ' 
        ' lblStopwatchTime
        ' 
        lblStopwatchTime.AutoSize = True
        lblStopwatchTime.Location = New Point(10, 210)
        lblStopwatchTime.Name = "lblStopwatchTime"
        lblStopwatchTime.Size = New Size(116, 20)
        lblStopwatchTime.TabIndex = 13
        lblStopwatchTime.Text = "Stopwatch Time"
        ' 
        ' ViewSubmissionsForm
        ' 
        ClientSize = New Size(391, 350)
        Controls.Add(lblStopwatchTime)
        Controls.Add(lblGithubLink)
        Controls.Add(lblPhoneNum)
        Controls.Add(lblEmail)
        Controls.Add(lblName)
        Controls.Add(lblTitle)
        Controls.Add(btnDelete)
        Controls.Add(btnNext)
        Controls.Add(btnPrevious)
        Controls.Add(txtStopwatchTime)
        Controls.Add(txtGithubLink)
        Controls.Add(txtPhoneNum)
        Controls.Add(txtEmail)
        Controls.Add(txtName)
        Name = "ViewSubmissionsForm"
        Text = "View Submissions"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhoneNum As TextBox
    Friend WithEvents txtGithubLink As TextBox
    Friend WithEvents txtStopwatchTime As TextBox
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblPhoneNum As Label
    Friend WithEvents lblGithubLink As Label
    Friend WithEvents lblStopwatchTime As Label
End Class
