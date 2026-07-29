namespace Phase3.PowerTools;

public class Button
{
    public event EventHandler? Clicked;

    public void Press() => Clicked?.Invoke(this, EventArgs.Empty);
}