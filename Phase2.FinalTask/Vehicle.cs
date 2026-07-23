namespace Phase2.FinalTask;

public abstract class Vehicle
{
    private string _licenseNo = null!;
    private string _model = null!;

    public string LicenseNo
    {
        get => _licenseNo;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentOutOfRangeException(nameof(value), "License number cannot be null or empty.");
            }
            _licenseNo = value;
        }
    }

    public string Model
    {
        get => _model;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentOutOfRangeException(nameof(value), "Model cannot be null or empty.");
            }
            _model = value;
        }
    }

    private string _color = null!;
    public string Color
    {
        get => _color;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentOutOfRangeException(nameof(value), "Color cannot be null or empty.");
            }
            _color = value;
        }
    }

    public abstract VehicleSize RequiredSize { get; }
    public abstract decimal HourlyRate { get; }
    

    public Vehicle(string licenseNo, string model, string color)
    {
        LicenseNo = licenseNo;
        Model = model;
        Color = color;
    }
}