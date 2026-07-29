namespace Phase3.PowerTools;

public class BankAccount
{
    public event EventHandler<decimal>? Overdrawn;

    private decimal _balance;

    public decimal Balance
    {
        get => _balance;
        private set
        {
            if (value < 0)
            {
                throw new InvalidOperationException("Balance cannot be negative.");
            }
            _balance = value;
        }
    }

    public BankAccount(decimal initialBalance)
    {
        Balance = initialBalance;
    }

    public void Withdraw(decimal amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Withdrawal amount must be positive.");
        }

        if (Balance - amount < 0)
        {
            Overdrawn?.Invoke(this, amount);
            throw new InvalidOperationException("Insufficient funds for this withdrawal.");
        }

        Balance -= amount;
    }
}