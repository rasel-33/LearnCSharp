namespace Phase4.Advanced;

public class NegativeAmountException : Exception
{
    public decimal Amount { get; }
    public NegativeAmountException(decimal amount) : base($"Amount cannot be negative: {amount:C}")
    {
        Amount = amount;
    }
}