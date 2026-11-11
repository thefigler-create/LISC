<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        cmbGrade7 = New ComboBox()
        cmbGrade8 = New ComboBox()
        cmbGrade9 = New ComboBox()
        cmbGrade10 = New ComboBox()
        cmbGrade11 = New ComboBox()
        cmbGrade12 = New ComboBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        SuspendLayout()
        ' 
        ' cmbGrade7
        ' 
        cmbGrade7.BackColor = Color.Lime
        cmbGrade7.DropDownStyle = ComboBoxStyle.DropDownList
        cmbGrade7.FlatStyle = FlatStyle.Flat
        cmbGrade7.Font = New Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cmbGrade7.FormattingEnabled = True
        cmbGrade7.Items.AddRange(New Object() {"Euclid", "Pascal", "Babbage", "Descartes"})
        cmbGrade7.Location = New Point(12, 170)
        cmbGrade7.Name = "cmbGrade7"
        cmbGrade7.Size = New Size(177, 41)
        cmbGrade7.TabIndex = 0
        cmbGrade7.TabStop = False
        ' 
        ' cmbGrade8
        ' 
        cmbGrade8.BackColor = Color.Yellow
        cmbGrade8.DropDownStyle = ComboBoxStyle.DropDownList
        cmbGrade8.FlatStyle = FlatStyle.Flat
        cmbGrade8.Font = New Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cmbGrade8.FormattingEnabled = True
        cmbGrade8.Items.AddRange(New Object() {"Brewster", "Crick", "Darwin", "Fleming", "Mendel", "Watson", "Schwann"})
        cmbGrade8.Location = New Point(195, 170)
        cmbGrade8.Name = "cmbGrade8"
        cmbGrade8.Size = New Size(177, 41)
        cmbGrade8.TabIndex = 1
        cmbGrade8.TabStop = False
        ' 
        ' cmbGrade9
        ' 
        cmbGrade9.BackColor = Color.Red
        cmbGrade9.DropDownStyle = ComboBoxStyle.DropDownList
        cmbGrade9.FlatStyle = FlatStyle.Flat
        cmbGrade9.Font = New Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cmbGrade9.FormattingEnabled = True
        cmbGrade9.Items.AddRange(New Object() {"Boyle", "Curie", "Mendeleev", "Avogadro", "Dalton", "Rutherford"})
        cmbGrade9.Location = New Point(378, 170)
        cmbGrade9.Name = "cmbGrade9"
        cmbGrade9.Size = New Size(177, 41)
        cmbGrade9.TabIndex = 2
        cmbGrade9.TabStop = False
        ' 
        ' cmbGrade10
        ' 
        cmbGrade10.BackColor = Color.DodgerBlue
        cmbGrade10.DropDownStyle = ComboBoxStyle.DropDownList
        cmbGrade10.FlatStyle = FlatStyle.Flat
        cmbGrade10.Font = New Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cmbGrade10.FormattingEnabled = True
        cmbGrade10.Items.AddRange(New Object() {"Aristole ", "Copernicus ", "Diophantus ", "Einstein ", "Galileo ", "Newton"})
        cmbGrade10.Location = New Point(561, 170)
        cmbGrade10.Name = "cmbGrade10"
        cmbGrade10.Size = New Size(177, 41)
        cmbGrade10.TabIndex = 3
        cmbGrade10.TabStop = False
        ' 
        ' cmbGrade11
        ' 
        cmbGrade11.DropDownStyle = ComboBoxStyle.DropDownList
        cmbGrade11.Font = New Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cmbGrade11.FormattingEnabled = True
        cmbGrade11.Location = New Point(810, 170)
        cmbGrade11.Name = "cmbGrade11"
        cmbGrade11.Size = New Size(177, 41)
        cmbGrade11.TabIndex = 4
        ' 
        ' cmbGrade12
        ' 
        cmbGrade12.DropDownStyle = ComboBoxStyle.DropDownList
        cmbGrade12.Font = New Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cmbGrade12.FormattingEnabled = True
        cmbGrade12.Location = New Point(993, 170)
        cmbGrade12.Name = "cmbGrade12"
        cmbGrade12.Size = New Size(177, 41)
        cmbGrade12.TabIndex = 5
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 25F, FontStyle.Bold)
        Label1.Location = New Point(329, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(93, 49)
        Label1.TabIndex = 6
        Label1.Text = "JHS"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 25F, FontStyle.Bold)
        Label2.Location = New Point(950, 9)
        Label2.Name = "Label2"
        Label2.Size = New Size(95, 49)
        Label2.TabIndex = 7
        Label2.Text = "SHS"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century Gothic", 16F, FontStyle.Bold)
        Label3.Location = New Point(37, 135)
        Label3.Name = "Label3"
        Label3.Size = New Size(122, 32)
        Label3.TabIndex = 8
        Label3.Text = "Grade 7"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Century Gothic", 16F, FontStyle.Bold)
        Label4.Location = New Point(227, 135)
        Label4.Name = "Label4"
        Label4.Size = New Size(122, 32)
        Label4.TabIndex = 9
        Label4.Text = "Grade 8"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Century Gothic", 16F, FontStyle.Bold)
        Label5.Location = New Point(414, 135)
        Label5.Name = "Label5"
        Label5.Size = New Size(122, 32)
        Label5.TabIndex = 10
        Label5.Text = "Grade 9"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Century Gothic", 16F, FontStyle.Bold)
        Label6.Location = New Point(581, 135)
        Label6.Name = "Label6"
        Label6.Size = New Size(137, 32)
        Label6.TabIndex = 11
        Label6.Text = "Grade 10"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Century Gothic", 16F, FontStyle.Bold)
        Label7.Location = New Point(830, 135)
        Label7.Name = "Label7"
        Label7.Size = New Size(137, 32)
        Label7.TabIndex = 12
        Label7.Text = "Grade 11"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Century Gothic", 16F, FontStyle.Bold)
        Label8.Location = New Point(1011, 135)
        Label8.Name = "Label8"
        Label8.Size = New Size(137, 32)
        Label8.TabIndex = 13
        Label8.Text = "Grade 12"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(9F, 23F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Orange
        ClientSize = New Size(1182, 853)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(cmbGrade12)
        Controls.Add(cmbGrade11)
        Controls.Add(cmbGrade10)
        Controls.Add(cmbGrade9)
        Controls.Add(cmbGrade8)
        Controls.Add(cmbGrade7)
        Name = "Form2"
        Text = "CLEAR"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents cmbGrade7 As ComboBox
    Friend WithEvents cmbGrade8 As ComboBox
    Friend WithEvents cmbGrade9 As ComboBox
    Friend WithEvents cmbGrade10 As ComboBox
    Friend WithEvents cmbGrade11 As ComboBox
    Friend WithEvents cmbGrade12 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
End Class
