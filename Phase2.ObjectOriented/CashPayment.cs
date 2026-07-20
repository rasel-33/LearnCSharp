namespace Phase2.ObjectOriented;

public class CashPayment : PaymentMethod
{
    public CashPayment(decimal amount) : base(amount) { }

    public override string ProcessPayment()
    {
        return $"Cash Received";
    }

    public override decimal TransactionFee => 0.00m;
}