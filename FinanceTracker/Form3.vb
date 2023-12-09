Public Class TransactionForm
    Private transaction As UserDashboard.Transaction

    Public Sub New(type As UserDashboard.TransactionType)
        InitializeComponent()
        transaction = New UserDashboard.Transaction()
        transaction.Type = type
    End Sub

    Private Sub submitBtn_Click(sender As Object, e As EventArgs) Handles submitBtn.Click
        If Decimal.TryParse(txtAmount.Text, transaction.Amount) Then
            transaction.Date = DateTime.Now
            DialogResult = DialogResult.OK
            Close()
        Else
            MessageBox.Show("Please enter a valid amount.")
        End If
    End Sub

    Public Function GetTransaction() As UserDashboard.Transaction
        Return transaction
    End Function
End Class
