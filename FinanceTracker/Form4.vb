Public Class BudgetForm
    ' establish new budget
    Private budget As New Budget()

    ' submit button handler
    Private Sub submitBudgetBtn_Click(sender As Object, e As EventArgs) Handles submitBudgetBtn.Click
        ' if correct format for budgetAmount
        If Decimal.TryParse(txtBudgetAmount.Text, budget.Amount) Then
            ' set budget category from textbox
            budget.Category = txtCategory.Text

            ' close form if valid
            DialogResult = DialogResult.OK
            Close()
            ' throw error if invalid budget data
        Else
            MessageBox.Show("Please enter valid budget details.")
        End If
    End Sub

    ' return budget to UserDashboard
    Public Function GetBudget() As Budget
        Return budget
    End Function
End Class