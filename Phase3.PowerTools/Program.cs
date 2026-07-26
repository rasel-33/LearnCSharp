using Phase3.PowerTools;

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