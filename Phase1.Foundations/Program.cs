// Program.cs

using System.Diagnostics;
using System.Text;
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

string newString = "hello";
Console.WriteLine(newString.ToUpper());
Console.WriteLine(newString);

newString = newString.ToUpper();
Console.WriteLine(newString);

var sw = Stopwatch.StartNew();

string initialString = "";
for (int i = 0; i < 10000; i++)
{
    initialString += i.ToString();  // creates a new string object each time
}

sw.Stop();
Console.WriteLine(initialString.Length);

Console.WriteLine($"Time taken for string concatenation: {sw.ElapsedMilliseconds} ms");

sw.Reset();
sw.Start();

StringBuilder stringBuilder = new StringBuilder();

for (int i = 0; i < 10000; i++)
{
    stringBuilder.Append(i.ToString());
}

sw.Stop();
Console.WriteLine(stringBuilder.ToString().Length);

Console.WriteLine($"Time taken for StringBuilder: {sw.ElapsedMilliseconds} ms");
Console.WriteLine(initialString == stringBuilder.ToString());

string? FindUserEmail(int userId)
{
    if (userId == 0)
    {
        return null;
    }

    return $"user{userId}@example.com";
}

string? userEmail = FindUserEmail(0);

if (userEmail != null)
{
    Console.WriteLine(userEmail.Length);
}
else
{
    Console.WriteLine("No email found.");
}

int? maybeAge = null;
Console.WriteLine(maybeAge ?? 0);

Console.WriteLine(maybeAge.HasValue);

maybeAge = 25;

Console.WriteLine(maybeAge.HasValue);


string DescribeTemperature(int celsius) => celsius switch
{
    < 0 => "Freezing",
    <= 15 => "Cold",
    <= 25 => "Mild",
    <= 35 => "Warm",
    _ => "Hot"
};


Console.WriteLine(DescribeTemperature(-1));
Console.WriteLine(DescribeTemperature(0));
Console.WriteLine(DescribeTemperature(15));
Console.WriteLine(DescribeTemperature(16));
Console.WriteLine(DescribeTemperature(35));


bool TryDivide(int numerator, int denominator, out int result)
{
    if (denominator == 0)
    {
        result = 0;
        return false;
    }

    result = numerator / denominator;
    return true;
}

if (TryDivide(10, 2, out int divisionResult))
{
    Console.WriteLine($"Division successful: {divisionResult}");
}
else
{
    Console.WriteLine("Division by zero is not allowed.");
}

if (TryDivide(10, 0, out divisionResult))
{
    Console.WriteLine($"Division successful: {divisionResult}");
}
else
{
    Console.WriteLine("Division by zero is not allowed.");
}

int x1 = 5, x2 = 10;

Console.WriteLine($"Before swap: x1 = {x1}, x2 = {x2}");

void Swap(ref int a, ref int b)
{
    int temp = a;
    a = b;
    b = temp;
}

Swap(ref x1, ref x2);
Console.WriteLine($"After swap: x1 = {x1}, x2 = {x2}");