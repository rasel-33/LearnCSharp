namespace Phase2.FinalTask;

public class Truck : Vehicle
{
    public override decimal HourlyRate => 5.0m;

    public override VehicleSize RequiredSize => VehicleSize.Large;

    public Truck(string licenseNo, string model, string color)
        : base(licenseNo, model, color)
    {
    }
}