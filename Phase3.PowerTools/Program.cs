using Phase3.PowerTools;

List<int> evenNumbers = MathUtils.Evens(10).ToList();

Console.WriteLine(evenNumbers); // Output: 0, 2, 4

Console.WriteLine(string.Join(", ", evenNumbers)); 

var box = new Box<int>();
box.Store(42);
Console.WriteLine(box.Retrieve());

var stringBox = new Box<string>();
stringBox.Store("Hello, World!");
Console.WriteLine(stringBox.Retrieve());

var maxInt = MathUtils.Max(10, 20);
Console.WriteLine($"Max of 10 and 20 is: {maxInt}");

var maxString = MathUtils.Max("apple", "banana");
Console.WriteLine($"Max of 'apple' and 'banana' is: {maxString}");




foreach (KeyValuePair<string, int> kvp in TextUtils.CountWords("the cat the dog the"))
{
    Console.WriteLine($"Word: {kvp.Key}, Count: {kvp.Value}");
}

var evens = MathUtils.EvenNumbers(5).ToList();
Console.WriteLine("Called, not enumerated yet");
foreach (int even in evens)
{
    Console.WriteLine(even);
}

foreach (int even in evens)
{
    Console.WriteLine(even);
}