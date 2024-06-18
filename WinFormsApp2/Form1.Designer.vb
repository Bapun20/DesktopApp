<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnViewSubmissions = New System.Windows.Forms.Button()
        Me.btnCreateSubmission = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblTitle.Location = New System.Drawing.Point(12, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(258, 17)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "John Doe, Slidely Task 2 - Slidely Form App"
        '
        'btnViewSubmissions
        '
        Me.btnViewSubmissions.BackColor = System.Drawing.Color.LightYellow
        Me.btnViewSubmissions.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewSubmissions.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnViewSubmissions.FlatAppearance.BorderSize = 1
        Me.btnViewSubmissions.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightYellow
        Me.btnViewSubmissions.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightYellow
        Me.btnViewSubmissions.Location = New System.Drawing.Point(12, 35)
        Me.btnViewSubmissions.Name = "btnViewSubmissions"
        Me.btnViewSubmissions.Size = New System.Drawing.Size(260, 30)
        Me.btnViewSubmissions.TabIndex = 1
        Me.btnViewSubmissions.Text = "View Submissions (CTRL + V)"
        Me.btnViewSubmissions.UseVisualStyleBackColor = False
        '
        'btnCreateSubmission
        '
        Me.btnCreateSubmission.BackColor = System.Drawing.Color.LightBlue
        Me.btnCreateSubmission.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCreateSubmission.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnCreateSubmission.FlatAppearance.BorderSize = 1
        Me.btnCreateSubmission.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightBlue
        Me.btnCreateSubmission.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue
        Me.btnCreateSubmission.Location = New System.Drawing.Point(12, 70)
        Me.btnCreateSubmission.Name = "btnCreateSubmission"
        Me.btnCreateSubmission.Size = New System.Drawing.Size(260, 30)
        Me.btnCreateSubmission.TabIndex = 2
        Me.btnCreateSubmission.Text = "Create New Submission (CTRL + N)"
        Me.btnCreateSubmission.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 121)
        Me.Controls.Add(Me.btnCreateSubmission)
        Me.Controls.Add(Me.btnViewSubmissions)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "Form1"
        Me.Text = "Slidely Form App"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents btnViewSubmissions As Button
    Friend WithEvents btnCreateSubmission As Button

End Class
