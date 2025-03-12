<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        DateInput = New DateTimePicker()
        LogWatchLabel = New Label()
        LogTitleLabel = New Label()
        LogTitleInput = New TextBox()
        DateInputLabel = New Label()
        RatingLabel = New Label()
        RatingInput = New NumericUpDown()
        ReviewInput = New RichTextBox()
        ReviewLabel = New Label()
        LogRequiredLabel = New Label()
        LogButton = New Button()
        SearchLogsLabel = New Label()
        SearchTitleLabel = New Label()
        SearchTitleInput = New TextBox()
        OutputLabel = New Label()
        SearchButton = New Button()
        Output = New ListBox()
        SearchRequiredLabel = New Label()
        CType(RatingInput, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DateInput
        ' 
        DateInput.Location = New Point(12, 153)
        DateInput.Name = "DateInput"
        DateInput.Size = New Size(500, 39)
        DateInput.TabIndex = 0
        ' 
        ' LogWatchLabel
        ' 
        LogWatchLabel.AutoSize = True
        LogWatchLabel.Location = New Point(12, 9)
        LogWatchLabel.Name = "LogWatchLabel"
        LogWatchLabel.Size = New Size(126, 32)
        LogWatchLabel.TabIndex = 1
        LogWatchLabel.Text = "Log Watch"
        ' 
        ' LogTitleLabel
        ' 
        LogTitleLabel.AutoSize = True
        LogTitleLabel.Location = New Point(12, 41)
        LogTitleLabel.Name = "LogTitleLabel"
        LogTitleLabel.Size = New Size(70, 32)
        LogTitleLabel.TabIndex = 2
        LogTitleLabel.Text = "Title*"
        ' 
        ' LogTitleInput
        ' 
        LogTitleInput.Location = New Point(12, 76)
        LogTitleInput.Name = "LogTitleInput"
        LogTitleInput.Size = New Size(500, 39)
        LogTitleInput.TabIndex = 3
        ' 
        ' DateInputLabel
        ' 
        DateInputLabel.AutoSize = True
        DateInputLabel.Location = New Point(12, 118)
        DateInputLabel.Name = "DateInputLabel"
        DateInputLabel.Size = New Size(74, 32)
        DateInputLabel.TabIndex = 4
        DateInputLabel.Text = "Date*"
        ' 
        ' RatingLabel
        ' 
        RatingLabel.AutoSize = True
        RatingLabel.Location = New Point(12, 195)
        RatingLabel.Name = "RatingLabel"
        RatingLabel.Size = New Size(92, 32)
        RatingLabel.TabIndex = 5
        RatingLabel.Text = "Rating*"
        ' 
        ' RatingInput
        ' 
        RatingInput.Location = New Point(12, 230)
        RatingInput.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        RatingInput.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        RatingInput.Name = "RatingInput"
        RatingInput.Size = New Size(500, 39)
        RatingInput.TabIndex = 7
        RatingInput.Value = New Decimal(New Integer() {5, 0, 0, 0})
        ' 
        ' ReviewInput
        ' 
        ReviewInput.Location = New Point(12, 307)
        ReviewInput.Name = "ReviewInput"
        ReviewInput.Size = New Size(500, 192)
        ReviewInput.TabIndex = 8
        ReviewInput.Text = ""
        ' 
        ' ReviewLabel
        ' 
        ReviewLabel.AutoSize = True
        ReviewLabel.Location = New Point(12, 272)
        ReviewLabel.Name = "ReviewLabel"
        ReviewLabel.Size = New Size(88, 32)
        ReviewLabel.TabIndex = 9
        ReviewLabel.Text = "Review"
        ' 
        ' LogRequiredLabel
        ' 
        LogRequiredLabel.AutoSize = True
        LogRequiredLabel.Location = New Point(12, 554)
        LogRequiredLabel.Name = "LogRequiredLabel"
        LogRequiredLabel.Size = New Size(126, 32)
        LogRequiredLabel.TabIndex = 10
        LogRequiredLabel.Text = "* Required"
        ' 
        ' LogButton
        ' 
        LogButton.Location = New Point(12, 505)
        LogButton.Name = "LogButton"
        LogButton.Size = New Size(500, 46)
        LogButton.TabIndex = 11
        LogButton.Text = "Submit"
        LogButton.UseVisualStyleBackColor = True
        ' 
        ' SearchLogsLabel
        ' 
        SearchLogsLabel.AutoSize = True
        SearchLogsLabel.Location = New Point(540, 9)
        SearchLogsLabel.Name = "SearchLogsLabel"
        SearchLogsLabel.Size = New Size(141, 32)
        SearchLogsLabel.TabIndex = 12
        SearchLogsLabel.Text = "Search Logs"
        ' 
        ' SearchTitleLabel
        ' 
        SearchTitleLabel.AutoSize = True
        SearchTitleLabel.Location = New Point(540, 41)
        SearchTitleLabel.Name = "SearchTitleLabel"
        SearchTitleLabel.Size = New Size(70, 32)
        SearchTitleLabel.TabIndex = 13
        SearchTitleLabel.Text = "Title*"
        ' 
        ' SearchTitleInput
        ' 
        SearchTitleInput.Location = New Point(540, 76)
        SearchTitleInput.Name = "SearchTitleInput"
        SearchTitleInput.Size = New Size(500, 39)
        SearchTitleInput.TabIndex = 14
        ' 
        ' OutputLabel
        ' 
        OutputLabel.AutoSize = True
        OutputLabel.Location = New Point(540, 170)
        OutputLabel.Name = "OutputLabel"
        OutputLabel.Size = New Size(90, 32)
        OutputLabel.TabIndex = 15
        OutputLabel.Text = "Output"
        ' 
        ' SearchButton
        ' 
        SearchButton.Location = New Point(540, 121)
        SearchButton.Name = "SearchButton"
        SearchButton.Size = New Size(500, 46)
        SearchButton.TabIndex = 16
        SearchButton.Text = "Search"
        SearchButton.UseVisualStyleBackColor = True
        ' 
        ' Output
        ' 
        Output.FormattingEnabled = True
        Output.ItemHeight = 32
        Output.Location = New Point(540, 205)
        Output.Name = "Output"
        Output.Size = New Size(500, 196)
        Output.TabIndex = 17
        ' 
        ' SearchRequiredLabel
        ' 
        SearchRequiredLabel.AutoSize = True
        SearchRequiredLabel.Location = New Point(540, 404)
        SearchRequiredLabel.Name = "SearchRequiredLabel"
        SearchRequiredLabel.Size = New Size(126, 32)
        SearchRequiredLabel.TabIndex = 18
        SearchRequiredLabel.Text = "* Required"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1057, 595)
        Controls.Add(SearchRequiredLabel)
        Controls.Add(Output)
        Controls.Add(SearchButton)
        Controls.Add(OutputLabel)
        Controls.Add(SearchTitleInput)
        Controls.Add(SearchTitleLabel)
        Controls.Add(SearchLogsLabel)
        Controls.Add(LogButton)
        Controls.Add(LogRequiredLabel)
        Controls.Add(ReviewLabel)
        Controls.Add(ReviewInput)
        Controls.Add(RatingInput)
        Controls.Add(RatingLabel)
        Controls.Add(DateInputLabel)
        Controls.Add(LogTitleInput)
        Controls.Add(LogTitleLabel)
        Controls.Add(LogWatchLabel)
        Controls.Add(DateInput)
        Name = "Form1"
        Text = "Log And Search"
        CType(RatingInput, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DateInput As DateTimePicker
    Friend WithEvents LogWatchLabel As Label
    Friend WithEvents LogTitleLabel As Label
    Friend WithEvents LogTitleInput As TextBox
    Friend WithEvents DateInputLabel As Label
    Friend WithEvents RatingLabel As Label
    Friend WithEvents RatingInput As NumericUpDown
    Friend WithEvents ReviewInput As RichTextBox
    Friend WithEvents ReviewLabel As Label
    Friend WithEvents LogRequiredLabel As Label
    Friend WithEvents LogButton As Button
    Friend WithEvents SearchLogsLabel As Label
    Friend WithEvents SearchTitleLabel As Label
    Friend WithEvents SearchTitleInput As TextBox
    Friend WithEvents OutputLabel As Label
    Friend WithEvents SearchButton As Button
    Friend WithEvents Output As ListBox
    Friend WithEvents SearchRequiredLabel As Label
End Class
