namespace Phase2.FinalTask;

public class Car : Vehicle
{
    public override decimal HourlyRate => 2.5m;

    public override VehicleSize RequiredSize => VehicleSize.Medium;

    public Car(string licenseNo, string model, string color)
        : base(licenseNo, model, color)
    {
    }
}