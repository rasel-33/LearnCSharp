namespace Phase2.FinalTask;

public class InitializeSpots
{
    public static Spots[] Initialize()
    {
        return new Spots[]
        {
            new Spots("S1", VehicleSize.Small),
            new Spots("S2", VehicleSize.Small),
            new Spots("M1", VehicleSize.Medium),
            new Spots("M2", VehicleSize.Medium),
            new Spots("L1", VehicleSize.Large),
            new Spots("L2", VehicleSize.Large)
        };
    }
}