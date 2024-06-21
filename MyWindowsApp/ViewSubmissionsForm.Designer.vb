Partial Class ViewSubmissionsForm
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer

    Private Sub InitializeComponent()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.lblSubmissionDetails = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnPrevious
        '
        Me.btnPrevious.Location = New System.Drawing.Point(50, 200)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(100, 30)
        Me.btnPrevious.TabIndex = 0
        Me.btnPrevious.Text = "Previous"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(200, 200)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(100, 30)
        Me.btnNext.TabIndex = 1
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'lblSubmissionDetails
        '
        Me.lblSubmissionDetails.Location = New System.Drawing.Point(50, 50)
        Me.lblSubmissionDetails.Name = "lblSubmissionDetails"
        Me.lblSubmissionDetails.Size = New System.Drawing.Size(250, 100)
        Me.lblSubmissionDetails.TabIndex = 2
        '
        'ViewSubmissionsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(350, 250)
        Me.Controls.Add(Me.lblSubmissionDetails)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnPrevious)
        Me.Name = "ViewSubmissionsForm"
        Me.Text = "View Submissions"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents lblSubmissionDetails As Label
End Class
