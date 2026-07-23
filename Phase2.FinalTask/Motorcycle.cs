namespace Phase2.FinalTask;

public class Motorcycle : Vehicle
{
    public override decimal HourlyRate => 2.0m;

    public override VehicleSize RequiredSize => VehicleSize.Small;

    public Motorcycle(string licenseNo, string model, string color)
        : base(licenseNo, model, color)
    {
    }
}