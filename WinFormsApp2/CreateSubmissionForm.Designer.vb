<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CreateSubmissionForm
    Inherits System.Windows.Forms.Form

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lblTitle = New Label()
        txtName = New TextBox()
        txtEmail = New TextBox()
        txtPhoneNum = New TextBox()
        txtGithubLink = New TextBox()
        txtStopwatchTime = New TextBox()
        btnToggleStopwatch = New Button()
        btnSubmit = New Button()
        lblName = New Label()
        lblEmail = New Label()
        lblPhoneNum = New Label()
        lblGithubLink = New Label()
        panelForm = New Panel()
        panelForm.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Microsoft Sans Serif", 10F)
        lblTitle.Location = New Point(16, 14)
        lblTitle.Margin = New Padding(4, 0, 4, 0)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(352, 20)
        lblTitle.TabIndex = 0
        lblTitle.Text = "John Doe, Slidely Task 2 - Create Submission"
        ' 
        ' txtName
        ' 
        txtName.BackColor = Color.White
        txtName.BorderStyle = BorderStyle.FixedSingle
        txtName.Location = New Point(200, 62)
        txtName.Margin = New Padding(4, 5, 4, 5)
        txtName.Name = "txtName"
        txtName.Size = New Size(266, 27)
        txtName.TabIndex = 1
        ' 
        ' txtEmail
        ' 
        txtEmail.BackColor = Color.White
        txtEmail.BorderStyle = BorderStyle.FixedSingle
        txtEmail.Location = New Point(200, 108)
        txtEmail.Margin = New Padding(4, 5, 4, 5)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(266, 27)
        txtEmail.TabIndex = 2
        ' 
        ' txtPhoneNum
        ' 
        txtPhoneNum.BackColor = Color.White
        txtPhoneNum.BorderStyle = BorderStyle.FixedSingle
        txtPhoneNum.Location = New Point(200, 154)
        txtPhoneNum.Margin = New Padding(4, 5, 4, 5)
        txtPhoneNum.Name = "txtPhoneNum"
        txtPhoneNum.Size = New Size(266, 27)
        txtPhoneNum.TabIndex = 3
        ' 
        ' txtGithubLink
        ' 
        txtGithubLink.BackColor = Color.White
        txtGithubLink.BorderStyle = BorderStyle.FixedSingle
        txtGithubLink.Location = New Point(200, 200)
        txtGithubLink.Margin = New Padding(4, 5, 4, 5)
        txtGithubLink.Name = "txtGithubLink"
        txtGithubLink.Size = New Size(266, 27)
        txtGithubLink.TabIndex = 4
        ' 
        ' txtStopwatchTime
        ' 
        txtStopwatchTime.BackColor = Color.LightGray
        txtStopwatchTime.BorderStyle = BorderStyle.FixedSingle
        txtStopwatchTime.Location = New Point(360, 251)
        txtStopwatchTime.Margin = New Padding(4, 5, 4, 5)
        txtStopwatchTime.Name = "txtStopwatchTime"
        txtStopwatchTime.ReadOnly = True
        txtStopwatchTime.Size = New Size(106, 27)
        txtStopwatchTime.TabIndex = 5
        ' 
        ' btnToggleStopwatch
        ' 
        btnToggleStopwatch.BackColor = Color.LightYellow
        btnToggleStopwatch.FlatAppearance.BorderColor = Color.Black
        btnToggleStopwatch.FlatAppearance.MouseDownBackColor = Color.LightYellow
        btnToggleStopwatch.FlatAppearance.MouseOverBackColor = Color.LightYellow
        btnToggleStopwatch.FlatStyle = FlatStyle.Flat
        btnToggleStopwatch.Location = New Point(67, 246)
        btnToggleStopwatch.Margin = New Padding(4, 5, 4, 5)
        btnToggleStopwatch.Name = "btnToggleStopwatch"
        btnToggleStopwatch.Size = New Size(267, 35)
        btnToggleStopwatch.TabIndex = 6
        btnToggleStopwatch.Text = "TOGGLE STOPWATCH (CTRL + T)"
        btnToggleStopwatch.UseVisualStyleBackColor = False
        ' 
        ' btnSubmit
        ' 
        btnSubmit.BackColor = Color.LightBlue
        btnSubmit.FlatAppearance.BorderColor = Color.Black
        btnSubmit.FlatAppearance.MouseDownBackColor = Color.LightBlue
        btnSubmit.FlatAppearance.MouseOverBackColor = Color.LightBlue
        btnSubmit.FlatStyle = FlatStyle.Flat
        btnSubmit.Location = New Point(67, 308)
        btnSubmit.Margin = New Padding(4, 5, 4, 5)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(400, 46)
        btnSubmit.TabIndex = 7
        btnSubmit.Text = "SUBMIT (CTRL + S)"
        btnSubmit.UseVisualStyleBackColor = False
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Location = New Point(67, 66)
        lblName.Margin = New Padding(4, 0, 4, 0)
        lblName.Name = "lblName"
        lblName.Size = New Size(49, 20)
        lblName.TabIndex = 8
        lblName.Text = "Name"
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Location = New Point(67, 112)
        lblEmail.Margin = New Padding(4, 0, 4, 0)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(46, 20)
        lblEmail.TabIndex = 9
        lblEmail.Text = "Email"
        ' 
        ' lblPhoneNum
        ' 
        lblPhoneNum.AutoSize = True
        lblPhoneNum.Location = New Point(67, 158)
        lblPhoneNum.Margin = New Padding(4, 0, 4, 0)
        lblPhoneNum.Name = "lblPhoneNum"
        lblPhoneNum.Size = New Size(86, 20)
        lblPhoneNum.TabIndex = 10
        lblPhoneNum.Text = "Phone Num"
        ' 
        ' lblGithubLink
        ' 
        lblGithubLink.AutoSize = True
        lblGithubLink.Location = New Point(67, 192)
        lblGithubLink.Margin = New Padding(4, 0, 4, 0)
        lblGithubLink.Name = "lblGithubLink"
        lblGithubLink.Size = New Size(87, 40)
        lblGithubLink.TabIndex = 11
        lblGithubLink.Text = "Github Link " & vbCrLf & "For Task 2"
        ' 
        ' panelForm
        ' 
        panelForm.Controls.Add(lblGithubLink)
        panelForm.Controls.Add(lblPhoneNum)
        panelForm.Controls.Add(lblEmail)
        panelForm.Controls.Add(lblName)
        panelForm.Controls.Add(txtStopwatchTime)
        panelForm.Controls.Add(txtGithubLink)
        panelForm.Controls.Add(txtPhoneNum)
        panelForm.Controls.Add(txtEmail)
        panelForm.Controls.Add(txtName)
        panelForm.Controls.Add(btnToggleStopwatch)
        panelForm.Controls.Add(btnSubmit)
        panelForm.Location = New Point(20, 46)
        panelForm.Margin = New Padding(4, 5, 4, 5)
        panelForm.Name = "panelForm"
        panelForm.Size = New Size(533, 385)
        panelForm.TabIndex = 13
        ' 
        ' CreateSubmissionForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(533, 415)
        Controls.Add(panelForm)
        Controls.Add(lblTitle)
        Margin = New Padding(4, 5, 4, 5)
        Name = "CreateSubmissionForm"
        Text = "Create Submission"
        panelForm.ResumeLayout(False)
        panelForm.PerformLayout()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhoneNum As TextBox
    Friend WithEvents txtGithubLink As TextBox
    Friend WithEvents txtStopwatchTime As TextBox
    Friend WithEvents btnToggleStopwatch As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents lblName As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblPhoneNum As Label
    Friend WithEvents lblGithubLink As Label
    Friend WithEvents panelForm As Panel

End Class
