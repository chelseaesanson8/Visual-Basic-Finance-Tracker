Imports Newtonsoft.Json.Linq
Imports System.IO
Public Class Form1
    Private Sub loginBtn_Click(sender As Object, e As EventArgs) Handles loginBtn.Click
        Dim filePath As String = "users.json"

        ' get user input
        Dim enteredUsername As String = txtUsername.Text
        Dim enteredPassword As String = txtPassword.Text

        Try
            ' read information from users.json
            Dim jsonString As String = File.ReadAllText(filePath)
            Dim users As JArray = JArray.Parse(jsonString)

            Dim loginSuccessful As Boolean = False

            ' check user credentials
            For Each user As JObject In users
                If user("username").ToString() = enteredUsername AndAlso user("password").ToString() = enteredPassword Then
                    ' set loginSuccessful flag 
                    loginSuccessful = True
                End If
            Next

            If loginSuccessful Then
                ' Find the user with the entered credentials
                Dim loggedInUser As JObject = users.FirstOrDefault(Function(u) u("username").ToString() = enteredUsername AndAlso u("password").ToString() = enteredPassword)

                If loggedInUser IsNot Nothing Then
                    ' Access the "fullName" property of the found user
                    Dim fullName As String = loggedInUser("fullName").ToString()
                    MessageBox.Show($"Login successful! Welcome, {fullName}!")

                    ' Create new dashboard view for user
                    Dim UserDashboard As New UserDashboard()
                    ' route to dashboard
                    UserDashboard.Show()
                    ' hide login form
                    Me.Hide()

                End If
            Else
                ' if no user found 
                MessageBox.Show("Invalid username or password. Please try again.")
            End If

        Catch ex As Exception
            MessageBox.Show($"Error reading or parsing the file: {ex.Message}")
        End Try
    End Sub
End Class
