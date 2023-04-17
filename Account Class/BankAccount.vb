Public Class BankAccount
    Private balance As Decimal = 0
    Private intRate As Decimal = 0
    Private interest As Decimal = 0
    Private transactions As Integer = 0

    Public Sub New(balance As Decimal, intRate As Decimal)
        Me.balance = balance
        Me.intRate = intRate
    End Sub

    Public Sub MakeDeposit(amount As Decimal)
        balance += amount
        transactions += 1
    End Sub

    Public Sub Withdraw(amount As Decimal)
        If balance >= amount Then
            balance -= amount
            transactions += 1
        Else
            MessageBox.Show("Insufficient funds")
        End If
    End Sub

    Public Sub CalcInterest()
        interest = balance * intRate
        balance += interest
    End Sub

    Public Function GetBalance() As Decimal
        Return balance
    End Function

    Public Function GetTransactions() As Integer
        Return transactions
    End Function
End Class

