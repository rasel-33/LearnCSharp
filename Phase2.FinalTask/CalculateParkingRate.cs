namespace Phase2.FinalTask;

public class CalculateParkingRate
{
    public static decimal CalculateRate(Vehicle vehicle)
    {
        return vehicle.RequiredSize switch
        {
            VehicleSize.Small => 5.0m,
            VehicleSize.Medium => 7.5m,
            VehicleSize.Large => 10.0m,
            _ => throw new ArgumentOutOfRangeException(nameof(vehicle.RequiredSize), "Invalid vehicle size.")
        };
    }
}