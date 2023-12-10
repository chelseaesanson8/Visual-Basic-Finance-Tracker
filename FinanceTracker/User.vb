Public Class User
    Public Property Username As String
    Public Property Password As String
    Public Property FullName As String
    Public Property Email As String
    Public Property Transactions As List(Of Transaction)
    Public Property Budgets As List(Of Budget)
End Class

Public Class Transaction
    Public Property Amount As Decimal
    Public Property Type As TransactionType
    Public Property [Date] As DateTime

    Public Property Category As String 

    Public Overrides Function ToString() As String
        ' Only return the amount as the string representation of the transaction
        Return $"{Amount:C} - Category: {Category} - Date: {[Date]}"
    End Function
End Class

Public Class Budget
    Public Property Amount As Decimal
    Public Property Category As String
End Class

Public Enum TransactionType
    Deposit
    Withdrawal
End Enum

