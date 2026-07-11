namespace Phase1.Foundations;

internal class Greeter
{
    private readonly string _greetingMessage;

    internal Greeter(string greetingMessage)
    {
        _greetingMessage = greetingMessage;
    }
    internal string Greet(string name)
    {
        return $"{_greetingMessage} {name}";
    }
}