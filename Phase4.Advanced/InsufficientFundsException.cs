namespace Phase4.Advanced;

public class InsufficientFundsException : Exception
{
    public decimal Shortfall { get; }
    public InsufficientFundsException(decimal shortfall) : base($"Insufficient funds: short by {shortfall:C}.")
    {
        Shortfall = shortfall;
    }
}