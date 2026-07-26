namespace Phase3.PowerTools;

public class Box<T>
{
    private T _value = default!;

    public void Store(T item)
    {
        _value = item;
    }

    public T Retrieve()
    {
        return _value;
    }
}