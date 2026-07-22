namespace Phase2.FinalTask;

public class InitializeSpots
{
    public static Spots[] Initialize()
    {
        return new Spots[]
        {
            new Spots("A1", VehicleSize.Small),
            new Spots("A2", VehicleSize.Small),
            new Spots("B1", VehicleSize.Medium),
            new Spots("B2", VehicleSize.Medium),
            new Spots("C1", VehicleSize.Large),
            new Spots("C2", VehicleSize.Large)
        };
    }
}