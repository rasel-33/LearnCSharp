using Phase4.Advanced;

void Divide(double a, double b)
{
    if (b == 0)
    {
        throw new DivideByZeroException("Cannot divide by zero.");
    }
    Console.WriteLine($"Result: {a / b}");
}


double a = 10;
double b = 2;

try
{
    Divide(a, b);
}
catch (DivideByZeroException ex)
{
   
    Console.WriteLine($"Error: {ex.Message}");
}
finally
{
    Console.WriteLine("Divide attempt finished.");
}

BankAccount account = new BankAccount("John Doe", 1000);


try
{
    account.Deposit(-500m);
}
catch (NegativeAmountException ex) when (ex.Amount < -1000)
{
    Console.WriteLine($"Error: {ex.Message} Shortfall: {ex.Amount} newly added");
}
catch (NegativeAmountException ex)
{
    Console.WriteLine($"Error: {ex.Message} Shortfall: {ex.Amount}");
}



