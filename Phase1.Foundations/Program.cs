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


