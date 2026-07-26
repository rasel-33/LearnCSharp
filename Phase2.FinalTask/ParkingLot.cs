namespace Phase2.FinalTask;

public class ParkingLot
{
    private readonly Dictionary<string, ParkingData> _parkedVehicles = new();

    private readonly List<Space> _spaces = new(){
        new Space("A1", VehicleSize.Small),
        new Space("B1", VehicleSize.Medium),
        new Space("C1", VehicleSize.Large)
    };

    public string ParkVehicle(Vehicle vehicle)
    {
        if (_parkedVehicles.ContainsKey(vehicle.LicenseNo))
        {
            throw new InvalidOperationException($"Vehicle with license number {vehicle.LicenseNo} is already parked.");
        }
        
        string parkingSpotId = null!;

        foreach (var space in _spaces)
        {
            if (!space.IsOccupied && space.Size >= vehicle.RequiredSize)
            {
                space.Occupy();
                parkingSpotId = space.SpotId;
                break;
            }
        }

        if (parkingSpotId == null)
        {
            throw new InvalidOperationException("No available parking spots for the vehicle size.");
        }

        ParkingData parkingData = new ParkingData(Guid.NewGuid(), DateTime.Now - TimeSpan.FromHours(5), null, vehicle, parkingSpotId);
        _parkedVehicles[vehicle.LicenseNo] = parkingData;
        return parkingSpotId;
    }

    public void ExitVehicle(string licenseNo)
    {
        if (!_parkedVehicles.ContainsKey(licenseNo))
        {
            throw new InvalidOperationException($"Vehicle with license number {licenseNo} is not parked.");
        }

        ParkingData parkingData = _parkedVehicles[licenseNo];
        parkingData = parkingData with { ExitTime = DateTime.Now };
        _parkedVehicles[licenseNo] = parkingData;
        string parkingSpotId = parkingData.ParkingSpotId;

        Space space = _spaces.First(s => s.SpotId == parkingSpotId);
        space.Free();

        decimal fee = parkingData.CalculateParkingFee();
        Console.WriteLine($"Vehicle with license number {licenseNo} has exited. Parking fee: ${fee:F2}");

        _parkedVehicles.Remove(licenseNo);
    }

}