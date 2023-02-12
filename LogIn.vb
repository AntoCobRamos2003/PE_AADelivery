'Program name: Double A Delivery
'Members: Anthony Cob, Adimir Gongora
'Course: CS206 Programming II
Public Class LogIn
    'User's username
    Public strUsername As String
    'Check if text boxes are empty
    Private Sub btnLogIn_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click
        If String.IsNullOrEmpty(txtUsername.Text.Trim) Then
            ErrorProvider1.SetError(txtUsername, "Username is required")
        Else 'if empty prompt error message
            ErrorProvider1.SetError(txtUsername, String.Empty)
            strUsername = txtUsername.Text
        End If

        If String.IsNullOrEmpty(txtPassword.Text.Trim) Then
            ErrorProvider2.SetError(txtPassword, "Password is required")
        Else
            ErrorProvider2.SetError(txtPassword, String.Empty)
        End If
        If txtUsername.Text <> "" And txtPassword.Text <> "" Then
            Me.Hide()
            main.Show()
        End If
    End Sub
    'Exit app when exit button is clicked
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblExit.Click
        Application.Exit()
    End Sub
End Class