namespace Phase2.ObjectOriented;

public class DigitalProduct : Product
{
    private readonly string _downloadUrl = "";
    public string DownloadUrl
    {
        get => _downloadUrl;
        init
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentOutOfRangeException(nameof(value), "Download URL cannot be null or empty.");
            }
            _downloadUrl = value;
        }
    }

    public DigitalProduct(int id, string name, decimal price, string downloadUrl) : base(id, name, price)
    {
        DownloadUrl = downloadUrl;
    }

    public override decimal ShippingCost => 0m; 
}