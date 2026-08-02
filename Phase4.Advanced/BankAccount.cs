namespace Phase4.Advanced;

public class BankAccount
{
    public string Owner { get; }
    public decimal Balance 
    {   
        get; 
        private set
        {
            if (value < 0)
            {
                throw new InvalidOperationException("Balance cannot be negative.");
            }
            field = value;
        }
    }

    public BankAccount(string owner, decimal initialBalance)
    {
        Owner = owner;
        Balance = initialBalance;
    }

    public void Deposit(decimal amount)
    {
        if (amount <= 0)
        {
            throw new NegativeAmountException(amount);
        }
        Balance += amount;
    }

    public void Withdraw(decimal amount)
    {
        if (amount <= 0)
        {
            throw new NegativeAmountException(amount);
        }
        if (amount > Balance)
        {
            throw new InsufficientFundsException(amount - Balance);
        }
        Balance -= amount;
    }
}