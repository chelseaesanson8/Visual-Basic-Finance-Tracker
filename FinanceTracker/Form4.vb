Imports FinanceTracker.UserDashboard

Public Class BudgetForm
    Private budget As New Budget()

    Private Sub submitBudgetBtn_Click(sender As Object, e As EventArgs) Handles submitBudgetBtn.Click
        If Decimal.TryParse(txtBudgetAmount.Text, budget.Amount) Then
            budget.Category = txtCategory.Text
            budget.StartDate = DateTime.Now ' Adjust as needed
            budget.EndDate = DateTime.Now.AddDays(30) ' Adjust as needed

            DialogResult = DialogResult.OK
            Close()
        Else
            MessageBox.Show("Please enter valid budget details.")
        End If
    End Sub

    Public Function GetBudget() As Budget
        Return budget
    End Function
End Class
