// Program.cs

using Phase1.Foundations;


BankAccount original = new BankAccount(100);
var copy = original;                 // copies the reference object
copy.Balance = 500;                  // changes the actual object's balance
Console.WriteLine(original.Balance); // 500
Console.WriteLine(copy.Balance);     // 500


double d1 = 0.1 + 0.2;
decimal d2 = 0.1m + 0.2m;

Console.WriteLine(d1);
Console.WriteLine(d2);
Console.WriteLine(d1 == 0.3);
Console.WriteLine(d2 == 0.3m);
int integerValue = 2147483640;
Console.WriteLine(integerValue + 10);

try
{
    checked
    {
        Console.WriteLine(integerValue + 10);
    }
    
}
catch(OverflowException oe)
{
    Console.WriteLine(oe.Message);
}

