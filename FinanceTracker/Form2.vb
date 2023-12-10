' import JSON library
Imports Newtonsoft.Json.Linq
Imports System.IO

Public Class UserDashboard
    ' create loggedInUser with Json object
    Private loggedInUser As JObject
    ' create transactions 
    Private transactions As List(Of Transaction)
    ' create budgets
    Private budgets As List(Of Budget)

    ' establish usersFilePath
    Private usersFilePath As String = "users.json"

    ' Constructor that receives the user data
    Public Sub New(user As JObject)
        InitializeComponent()
        ' set loggedInUser as user
        loggedInUser = user
        ' create new list of transactions and budgets for user
        transactions = New List(Of Transaction)()
        budgets = New List(Of Budget)()
        ' load in any previous transactions and budgets for user
        LoadTransactions()
    End Sub

    Private Sub UserDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Use loggedInUser to update UI elements with user data
        usernameLbl.Text = loggedInUser("fullName").ToString()
        ' update the transaction list box based on user logged in
        UpdateTransactionListBox()
        ' update the budget list box based on user logged in
        UpdateBudgetListBox()
        ' update current balance based on user logged in 
        UpdateCurrentBalance()
    End Sub

    Private Sub addWithdrawalBtn_Click(sender As Object, e As EventArgs)
        AddTransaction(TransactionType.Withdrawal)
    End Sub

    Private Sub addDepositBtn_Click(sender As Object, e As EventArgs) Handles addDepositBtn.Click
        AddTransaction(TransactionType.Deposit)
    End Sub

    ' adding  transaction to list
    Private Sub AddTransaction(type As TransactionType)
        Dim transactionForm As New TransactionForm(type)
        ' if transaction form data is valid, add transaction to list
        If transactionForm.ShowDialog() = DialogResult.OK Then
            transactions.Add(transactionForm.GetTransaction())
            UpdateTransactionListBox()
            UpdateCurrentBalance()
            SaveUserData()
        End If
    End Sub

    ' updating the transaction listbox
    Private Sub UpdateTransactionListBox()
        transactionsLst.Items.Clear() ' clear previous
        ' add transactions from user array
        For Each transaction In transactions
            transactionsLst.Items.Add(transaction.ToString())
        Next
    End Sub

    ' updating the curretn balance
    Private Sub UpdateCurrentBalance()
        ' set balance to 0
        Dim currentBalance As Decimal = 0
        ' calculate from transaction list
        For Each transaction In transactions
            ' if deposit then add to current balance
            If transaction.Type = TransactionType.Deposit Then
                currentBalance += transaction.Amount
                ' if withdrawal then subtract from current balance
            ElseIf transaction.Type = TransactionType.Withdrawal Then
                currentBalance -= transaction.Amount
            End If
        Next
        ' display current balance
        lblCurrentBalance.Text = $"Current balance: {currentBalance:C}"
    End Sub

    ' load transactions and budgets from array
    Private Sub LoadTransactions()
        Try
            ' if can access file then read and parse array of objects
            If File.Exists(usersFilePath) Then
                Dim jsonContent As String = File.ReadAllText(usersFilePath)
                Dim usersArray As JArray = JArray.Parse(jsonContent)

                ' Find transactions and budgets for the current user
                Dim currentUser = usersArray _
                .Where(Function(user) user("username").ToString() = loggedInUser("username").ToString()) _
                .FirstOrDefault()
                ' if current user is found then add budgets and transactions 
                If currentUser IsNot Nothing Then
                    transactions = currentUser("transactions").ToObject(Of List(Of Transaction))()
                    budgets = currentUser("budgets").ToObject(Of List(Of Budget))()
                    ' update the transaction list box and budget list box based on objects in array from user
                    UpdateTransactionListBox()
                    UpdateBudgetListBox()
                End If
            End If
            ' if cannot find user transactions and budgets throw error
        Catch ex As Exception
            MessageBox.Show($"Error loading transactions and budgets: {ex.Message}")
        End Try
    End Sub

    ' save the user data if added
    Private Sub SaveUserData()
        Try
            ' Update the transactions for the current user in the users.json file
            Dim jsonContent As String = File.ReadAllText(usersFilePath)
            Dim usersArray As JArray = JArray.Parse(jsonContent)
            ' update based on current user, find the username in array
            Dim currentUser = usersArray _
                .Where(Function(user) user("username").ToString() = loggedInUser("username").ToString()) _
                .FirstOrDefault()
            ' update with transactions and budgets and write to file
            If currentUser IsNot Nothing Then
                currentUser("transactions") = JToken.FromObject(transactions)
                currentUser("budgets") = JToken.FromObject(budgets)
                File.WriteAllText(usersFilePath, usersArray.ToString())
            End If
            ' if cannot save user data, then throw error
        Catch ex As Exception
            MessageBox.Show($"Error saving user data: {ex.Message}")
        End Try
    End Sub

    ' transaction class
    Public Class Transaction
        Public Property Amount As Decimal
        Public Property Type As TransactionType
        Public Property [Date] As DateTime

        Public Property Category As String

        Public Overrides Function ToString() As String
            ' Returns what the user will see in list box
            Return $"{Amount:C} - Category: {Category} - Date: {[Date]}"
        End Function

    End Class

    ' Transaction enum type declaration
    Public Enum TransactionType
        Deposit
        Withdrawal
    End Enum

    'Update the budget listbox
    Private Sub UpdateBudgetListBox()
        ' clear previous items
        budgetsLst.Items.Clear()
        ' add items from the list
        For Each budget In budgets
            budgetsLst.Items.Add($"Category: {budget.Category}, Amount: {budget.Amount:C}")
        Next
    End Sub

    ' add budget button click handler
    Private Sub addBudgetBtn_Click(sender As Object, e As EventArgs) Handles addBudgetBtn.Click
        Dim budgetForm As New BudgetForm()
        If budgetForm.ShowDialog() = DialogResult.OK Then
            budgets.Add(budgetForm.GetBudget())
            SaveUserData()
            UpdateBudgetListBox()
        End If
    End Sub

    ' logout handler - returns user to log in again
    Private Sub logoutBtn_Click(sender As Object, e As EventArgs) Handles logoutBtn.Click
        Form1.Show()
        Me.Hide()
    End Sub


End Class