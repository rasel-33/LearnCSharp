// Program.cs

using Phase1.Foundations;


BankAccount original = new BankAccount(100);
var copy = original; // copies the reference object
copy.Balance = 500; // changes the actual object's balance
Console.WriteLine(original.Balance); // 500
Console.WriteLine(copy.Balance); // 500
