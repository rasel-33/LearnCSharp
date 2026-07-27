namespace Phase3.PowerTools;

public static class MathUtils
{
    public static T Max<T>(T a, T b) where T : IComparable<T>
    {
        return a.CompareTo(b) > 0 ? a : b;
    }

    public static IEnumerable<int> Evens(int max)
    {
        for (int i = 0; i <= max; i += 2)
        {
            yield return i;
        }
    }

    public static IEnumerable<int> EvenNumbers(int count)
    {
        Console.WriteLine($" -- Generating -- ");
        for (int i = 0; i < count; i++)
        {
            yield return i * 2;
        }
    }
}

