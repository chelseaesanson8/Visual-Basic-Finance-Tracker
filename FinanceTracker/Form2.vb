Imports Newtonsoft.Json.Linq
Imports System.IO

Public Class UserDashboard
    Private loggedInUser As JObject
    Private transactions As List(Of Transaction)
    Private budgets As List(Of Budget)

    Private usersFilePath As String = "users.json"

    ' Constructor that receives the user data
    Public Sub New(user As JObject)
        InitializeComponent()
        loggedInUser = user
        transactions = New List(Of Transaction)()
        budgets = New List(Of Budget)()
        LoadTransactions()
    End Sub

    Private Sub UserDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Use loggedInUser to update UI elements with user data
        usernameLbl.Text = loggedInUser("username").ToString()
        UpdateTransactionListBox()
        UpdateBudgetListBox()
        UpdateCurrentBalance()
    End Sub

    Private Sub addWithdrawalBtn_Click(sender As Object, e As EventArgs)
        AddTransaction(TransactionType.Withdrawal)
    End Sub

    Private Sub addDepositBtn_Click(sender As Object, e As EventArgs) Handles addDepositBtn.Click
        AddTransaction(TransactionType.Deposit)
    End Sub

    Private Sub AddTransaction(type As TransactionType)
        Dim transactionForm As New TransactionForm(type)
        If transactionForm.ShowDialog() = DialogResult.OK Then
            transactions.Add(transactionForm.GetTransaction())
            UpdateTransactionListBox()
            UpdateCurrentBalance()
            SaveUserData()
        End If
    End Sub

    Private Sub UpdateTransactionListBox()
        transactionsLst.Items.Clear()
        For Each transaction In transactions
            transactionsLst.Items.Add(transaction.ToString())
        Next
    End Sub

    Private Sub UpdateCurrentBalance()
        Dim currentBalance As Decimal = 0
        For Each transaction In transactions
            If transaction.Type = TransactionType.Deposit Then
                currentBalance += transaction.Amount
            ElseIf transaction.Type = TransactionType.Withdrawal Then
                currentBalance -= transaction.Amount
            End If
        Next
        lblCurrentBalance.Text = $"Current balance: {currentBalance:C}"
    End Sub

    Private Sub LoadTransactions()
        Try
            If File.Exists(usersFilePath) Then
                Dim jsonContent As String = File.ReadAllText(usersFilePath)
                Dim usersArray As JArray = JArray.Parse(jsonContent)

                ' Find transactions and budgets for the current user
                Dim currentUser = usersArray _
                .Where(Function(user) user("username").ToString() = loggedInUser("username").ToString()) _
                .FirstOrDefault()

                If currentUser IsNot Nothing Then
                    transactions = currentUser("transactions").ToObject(Of List(Of Transaction))()
                    budgets = currentUser("budgets").ToObject(Of List(Of Budget))()

                    UpdateTransactionListBox()
                    UpdateBudgetListBox()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show($"Error loading transactions and budgets: {ex.Message}")
        End Try
    End Sub

    Private Sub SaveUserData()
        Try
            ' Update the transactions for the current user in the users.json file
            Dim jsonContent As String = File.ReadAllText(usersFilePath)
            Dim usersArray As JArray = JArray.Parse(jsonContent)

            Dim currentUser = usersArray _
                .Where(Function(user) user("username").ToString() = loggedInUser("username").ToString()) _
                .FirstOrDefault()

            If currentUser IsNot Nothing Then
                currentUser("transactions") = JToken.FromObject(transactions)
                currentUser("budgets") = JToken.FromObject(budgets)
                File.WriteAllText(usersFilePath, usersArray.ToString())
            End If
        Catch ex As Exception
            MessageBox.Show($"Error saving user data: {ex.Message}")
        End Try
    End Sub

    Public Class Transaction
        Public Property Amount As Decimal
        Public Property Type As TransactionType
        Public Property [Date] As DateTime

        Public Overrides Function ToString() As String
            ' Only return the amount as the string representation of the transaction
            Return Amount.ToString("C")
        End Function

    End Class

    Public Enum TransactionType
        Deposit
        Withdrawal
    End Enum

    'Update the budget listbox
    Private Sub UpdateBudgetListBox()
        budgetsLst.Items.Clear()
        For Each budget In budgets
            budgetsLst.Items.Add($"Category: {budget.Category}, Amount: {budget.Amount:C}")
        Next
    End Sub

    Private Sub addBudgetBtn_Click(sender As Object, e As EventArgs) Handles addBudgetBtn.Click
        Dim budgetForm As New BudgetForm()
        If budgetForm.ShowDialog() = DialogResult.OK Then
            budgets.Add(budgetForm.GetBudget())
            SaveUserData()
            UpdateBudgetListBox()
        End If
    End Sub
End Class
