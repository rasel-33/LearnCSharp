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

Func<int, int, int> multiply = (x, y) => x * y;
Console.WriteLine($"Result of multiplying 3 and 4 is: {multiply(3, 4)}");

Action<string> printMessage = message => Console.WriteLine(message.ToUpper());
printMessage("Hello, Power Tools!");

Predicate<int> isEven = number => number % 2 == 0;
Console.WriteLine($"Is 7 even? {isEven(7)}");

int[] numbers = { 1, 2, 3, 4 };
Functional.ApplyToEach(numbers, n => n * n);
Functional.ApplyToEach(numbers, n => n + 10);


var actions = new List<Action>();
for (int i = 0; i < 3; i++)
{
    int copy = i; // Capture the current value of i
    actions.Add(() => Console.WriteLine($"Action {copy} executed")
    );
}

numbers = new int[] { 3, 5, 6, 7 };

foreach (var num in numbers)
{
    actions.Add(() => Console.WriteLine($"Number {num} processed"));
}

foreach (var a in actions)
    a();

int[] nums = { 5, 12, 8, 130, 44, 3 };
var result = nums.Where(n => n > 10)   // keep numbers greater than 10: 12, 130, 44
                 .Select(n => n * n); // square each number: 144, 16900, 1936

Console.WriteLine(string.Join(", ", result)); // Output: 144, 16900, 1936

Console.WriteLine(nums.First(num => num > 10)); // Output: 12
Console.WriteLine(nums.FirstOrDefault(num => num > 1000)); // Output: 0


var products = new List<Product>
{
    new("Laptop",  "Electronics", 1200m),
    new("Mouse",   "Electronics", 25m),
    new("Desk",    "Furniture",   300m),
    new("Chair",   "Furniture",   150m),
    new("Monitor", "Electronics", 400m),
};

var SelectedProducts = products.OrderByDescending(p => p.Price)
                               .Select(p => p.Name);

Console.WriteLine(string.Join(", ", SelectedProducts)); // Output: Laptop, Monitor, Desk, Chair, Mouse

var groupedProducts = products.GroupBy(p => p.Category)
                              .Select(g => new { Category = g.Key, Count = g.Count(), Average = g.Average(p => p.Price) });


foreach (var group in groupedProducts)
{
    Console.WriteLine($"Category: {group.Category}, {group.Count} items, avg {group.Average:f3}");
}

var myNumber = new int[] { 5, 12, 8, 130, 44, 3 };
myNumber.MyWhere(n => n > 10).ToList().ForEach(n => Console.WriteLine(n)); // Output: 12, 130, 44


(int Count, int Sum, double average) GetStats(int[] nums)
{
    return (nums.Length, nums.Sum(), nums.Average());
}

var (count, sum, average) = GetStats(myNumber);
Console.WriteLine($"Count: {count}, Sum: {sum}, Average: {average:f2}");