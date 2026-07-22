namespace Phase2.FinalTask;

public class ParkingLot
{
    private readonly Dictionary<string, ParkingData> _parkedVehicles = new();
    private readonly Dictionary<string, Vehicle> _vehicles = new();

    public void ParkVehicle(Vehicle vehicle, string parkingSpotId)
    {
        if (_parkedVehicles.ContainsKey(vehicle.LicenseNo))
        {
            throw new InvalidOperationException($"Vehicle with license number {vehicle.LicenseNo} is already parked.");
        }

        ParkingData parkingData = new ParkingData(Guid.NewGuid(), DateTime.Now, DateTime.MinValue, vehicle, parkingSpotId);
        _parkedVehicles[vehicle.LicenseNo] = parkingData;
        _vehicles[vehicle.LicenseNo] = vehicle;
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

        decimal fee = parkingData.CalculateParkingFee();
        Console.WriteLine($"Vehicle with license number {licenseNo} has exited. Parking fee: ${fee:F2}");

        _parkedVehicles.Remove(licenseNo);
        _vehicles.Remove(licenseNo);
    }

    public Vehicle? GetVehicle(string licenseNo)
    {
        _parkedVehicles.TryGetValue(licenseNo, out var parkingData);
        return parkingData?.Vehicle;
    }
}