namespace Phase2.FinalTask;

public record Spots
{
    public string SpotId { get; set; } = null!;
    public VehicleSize Size { get; set; }
    public bool IsOccupied { get; set; }

    public Spots(string spotId, VehicleSize size)
    {
        SpotId = spotId;
        Size = size;
        IsOccupied = false;
    }
}

