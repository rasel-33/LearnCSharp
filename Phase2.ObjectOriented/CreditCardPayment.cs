namespace Phase2.ObjectOriented;

public class CreditCardPayment : PaymentMethod, IRefundable
{
    public CreditCardPayment(decimal amount) : base(amount) { }

    public override string ProcessPayment()
    {
        return $"Charged card";
    }

    public decimal Refund(decimal amount)
    {
        if (amount <= 0 || amount > Amount)
        {
            throw new ArgumentOutOfRangeException(nameof(amount), "Refund amount cannot exceed the original payment amount.");
        }
        return amount;
    }
}