namespace Phase3.PowerTools;

public static class Functional
{
    public static void ApplyToEach(int[] numbers, Func<int, int> transform)
    {
        foreach (var n in numbers)
            Console.WriteLine(transform(n));
    }
}