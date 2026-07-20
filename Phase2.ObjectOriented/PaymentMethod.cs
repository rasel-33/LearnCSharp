namespace Phase2.ObjectOriented;

public abstract class PaymentMethod
{
    public decimal Amount {get;}
    public abstract string ProcessPayment();
    public virtual decimal TransactionFee => Amount * 0.02m;
    public string Summary() => $"{ProcessPayment()} | fee: {TransactionFee:F2}";

    protected PaymentMethod(decimal amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(amount), "Amount cannot be zero or negative.");
        }
        Amount = amount;
    }

}