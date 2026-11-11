Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub AnyGradeSection_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbGrade7.SelectionChangeCommitted, cmbGrade8.SelectionChangeCommitted, cmbGrade9.SelectionChangeCommitted, cmbGrade10.SelectionChangeCommitted

        Dim clickedBox As ComboBox = DirectCast(sender, ComboBox)

        If clickedBox.SelectedIndex <> -1 Then

            Label1.Focus()

            Dim result As DialogResult

            result = MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then

                Form3.StartPosition = FormStartPosition.Manual

                Form3.Left = Left
                Form3.Top = Top
                Form3.Show()
                Me.Hide()

                Section = clickedBox.Text

            Else

                clickedBox.SelectedIndex = -1

            End If
        End If
    End Sub
End Class