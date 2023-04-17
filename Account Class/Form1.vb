Public Class Form1
    Dim account As BankAccount

    Private Sub mnuFileExit_Click(sender As Object, e As EventArgs) Handles mnuFileExit.Click
        Application.Exit()
    End Sub

    Private Sub mnuAccountNew_Click(sender As Object, e As EventArgs) Handles mnuAccountNew.Click
        account = New BankAccount(1000, 0.05)

        lblBalance.Text = account.GetBalance().ToString("C")
        lblTransactions.Text = account.GetTransactions().ToString()
    End Sub

    Private Sub mnuDeposit_Click(sender As Object, e As EventArgs) Handles mnuDeposit.Click
        Dim amount As Decimal = Decimal.Parse(InputBox("Enter deposit amount:", "Deposit"))
        account.MakeDeposit(amount)

        lblBalance.Text = account.GetBalance().ToString("C")
        lblTransactions.Text = account.GetTransactions().ToString()
    End Sub

    Private Sub mnuWithdraw_Click(sender As Object, e As EventArgs) Handles mnuWithdraw.Click
        Dim amount As Decimal = Decimal.Parse(InputBox("Enter withdrawal amount:", "Withdraw"))
        account.Withdraw(amount)

        lblBalance.Text = account.GetBalance().ToString("C")
        lblTransactions.Text = account.GetTransactions().ToString()
    End Sub

    Private Sub mnuInterest_Click(sender As Object, e As EventArgs) Handles mnuInterest.Click
        account.CalcInterest()

        lblBalance.Text = account.GetBalance().ToString("C")
        lblTransactions.Text = account.GetTransactions().ToString()
    End Sub
End Class

