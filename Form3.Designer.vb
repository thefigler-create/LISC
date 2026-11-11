<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        txtName = New TextBox()
        clbStudents = New CheckedListBox()
        btnRemove = New Button()
        btnProceed = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(398, 40)
        Label1.Name = "Label1"
        Label1.Size = New Size(450, 51)
        Label1.TabIndex = 0
        Label1.Text = "NAME OF STUDENT/S"
        ' 
        ' txtName
        ' 
        txtName.Font = New Font("Century Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtName.Location = New Point(338, 114)
        txtName.Name = "txtName"
        txtName.Size = New Size(564, 48)
        txtName.TabIndex = 1
        ' 
        ' clbStudents
        ' 
        clbStudents.CheckOnClick = True
        clbStudents.Font = New Font("Century Gothic", 19.8000011F)
        clbStudents.FormattingEnabled = True
        clbStudents.Location = New Point(90, 186)
        clbStudents.Name = "clbStudents"
        clbStudents.Size = New Size(526, 606)
        clbStudents.TabIndex = 2
        clbStudents.ThreeDCheckBoxes = True
        ' 
        ' btnRemove
        ' 
        btnRemove.Font = New Font("Century Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnRemove.Location = New Point(774, 388)
        btnRemove.Name = "btnRemove"
        btnRemove.Size = New Size(206, 76)
        btnRemove.TabIndex = 3
        btnRemove.Text = "REMOVE"
        btnRemove.UseVisualStyleBackColor = True
        ' 
        ' btnProceed
        ' 
        btnProceed.Font = New Font("Century Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnProceed.Location = New Point(774, 485)
        btnProceed.Name = "btnProceed"
        btnProceed.Size = New Size(206, 76)
        btnProceed.TabIndex = 4
        btnProceed.Text = "PROCEED"
        btnProceed.UseVisualStyleBackColor = True
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(9F, 23F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.RoyalBlue
        ClientSize = New Size(1182, 853)
        Controls.Add(btnProceed)
        Controls.Add(btnRemove)
        Controls.Add(clbStudents)
        Controls.Add(txtName)
        Controls.Add(Label1)
        Name = "Form3"
        Text = "Form3"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents clbStudents As CheckedListBox
    Friend WithEvents btnRemove As Button
    Friend WithEvents btnProceed As Button
End Class
