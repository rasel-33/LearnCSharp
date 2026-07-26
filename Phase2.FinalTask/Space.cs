namespace Phase2.FinalTask;

public class Space
{
    public VehicleSize Size { get; }
    private string _spotId = null!;
    public bool IsOccupied { get; private set; }
    public string SpotId
    {
        get => _spotId;
        init
        {
            _spotId = value ?? throw new ArgumentNullException(nameof(value));
        }
    }

    public Space(string spotId, VehicleSize size)
    {
        SpotId = spotId;
        Size = size;
    }

    public void Occupy()
    {
        if (IsOccupied)
        {
            throw new InvalidOperationException("Spot is already occupied.");
        }
        IsOccupied = true;
    }

    public void Free()
    {
        if (!IsOccupied)
        {
            throw new InvalidOperationException("Spot is already free.");
        }
        IsOccupied = false;
    }
}

