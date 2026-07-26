
using Phase2.FinalTask;

ParkingLot parkingLot = new ParkingLot();

Motorcycle motorcycle = new Motorcycle("M123", "Harley-Davidson", "Black");
Car car = new Car("C456", "Toyota Camry", "Blue");
Truck truck = new Truck("T789", "Ford F-150", "Red");

try
{
    string parkingSpotId = parkingLot.ParkVehicle(motorcycle);
    Console.WriteLine($"Parked motorcycle in spot: {parkingSpotId}");

    parkingSpotId = parkingLot.ParkVehicle(car);
    Console.WriteLine($"Parked car in spot: {parkingSpotId}");

    parkingSpotId = parkingLot.ParkVehicle(truck);
    Console.WriteLine($"Parked truck in spot: {parkingSpotId}");
}
catch (InvalidOperationException ex)
{
    Console.WriteLine(ex.Message);
}

parkingLot.ExitVehicle("M123");

Truck truck2 = new Truck("T999", "Chevrolet Silverado", "White");

try
{
    string parkingSpotId = parkingLot.ParkVehicle(truck2);
    Console.WriteLine($"Parked truck in spot: {parkingSpotId}");
}
catch (InvalidOperationException ex)
{
    Console.WriteLine(ex.Message);
}

