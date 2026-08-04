using System.Diagnostics;
using Phase4.Advanced;

async Task<string> FetchDataAsync(string source)
{
    await Task.Delay(1000); // Simulate network delay
    return $"Fetched data from {source}";
}


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




using var logger = new FileLogger("log.txt");
logger.Log("Application started.");

logger.Dispose();
logger.Dispose(); 

try
{
    logger.Log("This will throw an exception because the logger is disposed.");
}
catch (ObjectDisposedException ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}

Stopwatch stopwatch = new Stopwatch();
stopwatch.Start();

Task<string> task1 = FetchDataAsync("https://example.com");
Task<string> task2 = FetchDataAsync("https://example.org");
Task<string> task3 = FetchDataAsync("https://example.net");

string[] results = await Task.WhenAll(task1, task2, task3);

stopwatch.Stop();
Console.WriteLine($"Total time taken: {stopwatch.ElapsedMilliseconds} ms");

async Task ShowThreadsAsync()
{
    Console.WriteLine($"Before await: thread {Environment.CurrentManagedThreadId}");
    await Task.Delay(500);
    Console.WriteLine($"After await:  thread {Environment.CurrentManagedThreadId}");
}

await ShowThreadsAsync();

async Task<int> BoomAsync()
{
    await Task.Delay(500);
    throw new InvalidOperationException("Boom!");
}

Task<int> boomTask = BoomAsync();

// await boomTask;
// Console.WriteLine($"Boom task status: {boomTask.Status}");

Task<int> t = BoomAsync();
Console.WriteLine($"Task status: {t.Status}"); 
try
{
    int result = await t;
    Console.WriteLine($"Result: {result}");
}
catch (InvalidOperationException ex)
{
    Console.WriteLine($"Caught exception: {ex.Message}");
}

async Task<int> SimpleAsync()
{
    await Task.Delay(500);
    Console.WriteLine($"Inside SimpleAsync: thread {Environment.CurrentManagedThreadId}");
    await Task.Delay(500);
    Console.WriteLine($"Inside SimpleAsync after second delay: thread {Environment.CurrentManagedThreadId}");
    return 42;
}

Task<int> simpleTask = SimpleAsync();
Console.WriteLine($"Task status: {simpleTask.Status}");

int ta = await simpleTask;
Console.WriteLine($"Task status after await: {simpleTask.Status}");
Console.WriteLine($"Result: {ta}");




async Task<int> OkAsync(int n)   { await Task.Delay(100); return n; }
async Task<int> FailAsync()      { await Task.Delay(50); throw new InvalidOperationException("bad"); }

Task<int> t1 = OkAsync(1);
Task<int> t2 = FailAsync();
Task<int> t3 = OkAsync(3);

try
{
    int[] all = await Task.WhenAll(t1, t2, t3);
}
catch (Exception ex)
{
    Console.WriteLine($"caught: {ex.GetType().Name}: {ex.Message}");
    Console.WriteLine($"t1: {t1.Status}, t2: {t2.Status}, t3: {t3.Status}");
}

using var cts = new CancellationTokenSource(TimeSpan.FromMilliseconds(2200));   // auto-cancels after 2s

async Task LongWorkAsync(CancellationToken ct)
{
    for (int i = 0; i < 10; i++)
    {
        ct.ThrowIfCancellationRequested();     // check between units of work
        await Task.Delay(500, ct);             // and pass it to everything you call
        Console.WriteLine($"step {i}");
    }
}


try
{
    await LongWorkAsync(cts.Token);
}
catch (OperationCanceledException)
{
    Console.WriteLine("Operation was canceled.");
}

int Counter = 0;
// object gate = new object();
Stopwatch sw = Stopwatch.StartNew();

var tasks = Enumerable.Range(0, 100)
    .Select(_ => Task.Run(() =>
    {
        for(int i = 0; i < 10000; i++)
        {
            Interlocked.Increment(ref Counter);
        }
        
    }))
    .ToArray();

sw.Stop();
await Task.WhenAll(tasks);
Console.WriteLine($"Counter: {Counter}");  
Console.WriteLine($"Time taken: {sw.ElapsedMilliseconds} ms");