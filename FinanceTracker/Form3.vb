Public Class TransactionForm
    ' establishes transaction 
    Private transaction As UserDashboard.Transaction

    ' creates new type of transaction 
    Public Sub New(type As UserDashboard.TransactionType)
        InitializeComponent()
        transaction = New UserDashboard.Transaction()
        transaction.Type = type
    End Sub

    ' once transaction from form submitted
    Private Sub submitBtn_Click(sender As Object, e As EventArgs) Handles submitBtn.Click
        ' if correct format then
        If Decimal.TryParse(txtAmount.Text, transaction.Amount) Then
            ' date set from current time submitted
            transaction.Date = DateTime.Now
            ' category grabbed from txtCategory textbox
            transaction.Category = txtCategory.Text
            ' if dialog result is valid then close form
            DialogResult = DialogResult.OK
            Close()
            ' if amount not valid throw error
        Else
            MessageBox.Show("Please enter a valid amount.")
        End If
    End Sub

    ' returns transaction to UserDashboard
    Public Function GetTransaction() As UserDashboard.Transaction
        Return transaction
    End Function


End Class
