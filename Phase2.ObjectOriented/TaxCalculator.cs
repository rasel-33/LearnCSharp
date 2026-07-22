namespace Phase2.ObjectOriented;

public class TaxCalculator
{
    private const decimal TaxRate = 0.15m;
    public decimal AddTax(decimal amount) => amount * (1 + TaxRate);
}