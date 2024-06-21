Partial Class MainForm
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer

    Private Sub InitializeComponent()
        Me.btnViewSubmissions = New System.Windows.Forms.Button()
        Me.btnCreateSubmission = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnViewSubmissions
        '
        Me.btnViewSubmissions.Location = New System.Drawing.Point(100, 50)
        Me.btnViewSubmissions.Name = "btnViewSubmissions"
        Me.btnViewSubmissions.Size = New System.Drawing.Size(150, 50)
        Me.btnViewSubmissions.TabIndex = 0
        Me.btnViewSubmissions.Text = "&View Submissions"
        Me.btnViewSubmissions.UseVisualStyleBackColor = True
        '
        'btnCreateSubmission
        '
        Me.btnCreateSubmission.Location = New System.Drawing.Point(100, 150)
        Me.btnCreateSubmission.Name = "btnCreateSubmission"
        Me.btnCreateSubmission.Size = New System.Drawing.Size(150, 50)
        Me.btnCreateSubmission.TabIndex = 1
        Me.btnCreateSubmission.Text = "&Create New Submission"
        Me.btnCreateSubmission.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(350, 250)
        Me.Controls.Add(Me.btnCreateSubmission)
        Me.Controls.Add(Me.btnViewSubmissions)
        Me.Name = "MainForm"
        Me.Text = "Main Form"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnViewSubmissions As Button
    Friend WithEvents btnCreateSubmission As Button
End Class
