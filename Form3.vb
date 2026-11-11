\Imports System.Reflection

Public Class Form3
    Private Sub TxtName_KeyDown(sender As Object, e As KeyEventArgs) Handles txtName.KeyDown
        If e.KeyCode = Keys.Enter Then

            e.SuppressKeyPress = True

            If txtName.Text.Trim() <> "" Then
                clbStudents.Items.Add(txtName.Text.Trim())
                txtName.Clear()
                txtName.Focus()
            End If
        End If
    End Sub

    Private Sub BtnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        For i As Integer = clbStudents.CheckedIndices.Count - 1 To 0 Step -1
            clbStudents.Items.RemoveAt(clbStudents.CheckedIndices(i))
        Next
    End Sub

    Private Sub clbStudents_SelectedIndexChanged(sender As Object, e As EventArgs) Handles clbStudents.SelectedIndexChanged
        clbStudents.ClearSelected()
    End Sub

    Private Sub BtnProceed_Click(sender As Object, e As EventArgs) Handles btnProceed.Click

        If clbStudents.Items.Count = "" Then

            MessageBox.Show("Please enter a name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            If DialogResult.Yes Then
                Exit Sub
            End If

        Else

            Form4.StartPosition = FormStartPosition.Manual

            Form4.Left = Left
            Form4.Top = Top
            Form4.Show()
            Me.Hide()

            For Each item As Object In clbStudents.Items
                LISC.Students.Add(item.ToString())
            Next
        End If

    End Sub
End Class