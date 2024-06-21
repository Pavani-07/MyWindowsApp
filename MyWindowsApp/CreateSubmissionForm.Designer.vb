Partial Class CreateSubmissionForm
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer

    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtPhoneNumber = New System.Windows.Forms.TextBox()
        Me.txtGithubLink = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblPhoneNumber = New System.Windows.Forms.Label()
        Me.lblGithubLink = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnStopwatch = New System.Windows.Forms.Button()
        Me.lblStopwatch = New System.Windows.Forms.Label()
        Me.timerStopwatch = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(150, 30)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(200, 22)
        Me.txtName.TabIndex = 0
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(150, 70)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(200, 22)
        Me.txtEmail.TabIndex = 1
        '
        'txtPhoneNumber
        '
        Me.txtPhoneNumber.Location = New System.Drawing.Point(150, 110)
        Me.txtPhoneNumber.Name = "txtPhoneNumber"
        Me.txtPhoneNumber.Size = New System.Drawing.Size(200, 22)
        Me.txtPhoneNumber.TabIndex = 2
        '
        'txtGithubLink
        '
        Me.txtGithubLink.Location = New System.Drawing.Point(150, 150)
        Me.txtGithubLink.Name = "txtGithubLink"
        Me.txtGithubLink.Size = New System.Drawing.Size(200, 22)
        Me.txtGithubLink.TabIndex = 3
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(50, 33)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(45, 17)
        Me.lblName.TabIndex = 4
        Me.lblName.Text = "Name"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(50, 73)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(42, 17)
        Me.lblEmail.TabIndex = 5
        Me.lblEmail.Text = "Email"
        '
        'lblPhoneNumber
        '
        Me.lblPhoneNumber.AutoSize = True
        Me.lblPhoneNumber.Location = New System.Drawing.Point(50, 113)
        Me.lblPhoneNumber.Name = "lblPhoneNumber"
        Me.lblPhoneNumber.Size = New System.Drawing.Size(103, 17)
        Me.lblPhoneNumber.TabIndex = 6
        Me.lblPhoneNumber.Text = "Phone Number"
        '
        'lblGithubLink
        '
        Me.lblGithubLink.AutoSize = True
        Me.lblGithubLink.Location = New System.Drawing.Point(50, 153)
        Me.lblGithubLink.Name = "lblGithubLink"
        Me.lblGithubLink.Size = New System.Drawing.Size(81, 17)
        Me.lblGithubLink.TabIndex = 7
        Me.lblGithubLink.Text = "GitHub Link"
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(150, 200)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(100, 30)
        Me.btnSubmit.TabIndex = 8
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'btnStopwatch
        '
        Me.btnStopwatch.Location = New System.Drawing.Point(150, 250)
        Me.btnStopwatch.Name = "btnStopwatch"
        Me.btnStopwatch.Size = New System.Drawing.Size(100, 30)
        Me.btnStopwatch.TabIndex = 9
        Me.btnStopwatch.Text = "Pause"
        Me.btnStopwatch.UseVisualStyleBackColor = True
        '
        'lblStopwatch
        '
        Me.lblStopwatch.AutoSize = True
        Me.lblStopwatch.Location = New System.Drawing.Point(150, 290)
        Me.lblStopwatch.Name = "lblStopwatch"
        Me.lblStopwatch.Size = New System.Drawing.Size(0, 17)
        Me.lblStopwatch.TabIndex = 10
        '
        'timerStopwatch
        '
        '
        'CreateSubmissionForm
        '
        Me.ClientSize = New System.Drawing.Size(400, 350)
        Me.Controls.Add(Me.lblStopwatch)
        Me.Controls.Add(Me.btnStopwatch)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.lblGithubLink)
        Me.Controls.Add(Me.lblPhoneNumber)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.txtGithubLink)
        Me.Controls.Add(Me.txtPhoneNumber)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtName)
        Me.Name = "CreateSubmissionForm"
        Me.Text = "Create New Submission"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents txtName As System.Windows.Forms.TextBox
    Private WithEvents txtEmail As System.Windows.Forms.TextBox
    Private WithEvents txtPhoneNumber As System.Windows.Forms.TextBox
    Private WithEvents txtGithubLink As System.Windows.Forms.TextBox
    Private WithEvents lblName As System.Windows.Forms.Label
    Private WithEvents lblEmail As System.Windows.Forms.Label
    Private WithEvents lblPhoneNumber As System.Windows.Forms.Label
    Private WithEvents lblGithubLink As System.Windows.Forms.Label
    Private WithEvents btnSubmit As System.Windows.Forms.Button
    Private WithEvents btnStopwatch As System.Windows.Forms.Button
    Private WithEvents lblStopwatch As System.Windows.Forms.Label
    Private WithEvents timerStopwatch As System.Windows.Forms.Timer

End Class
