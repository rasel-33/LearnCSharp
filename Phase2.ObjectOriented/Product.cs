namespace Phase2.ObjectOriented;

public class Product
{
    private string _name = "";
    private decimal _price = 0.0m;
    public int Id { get; init;}
    public string Name
    {
        get => _name;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Name cannot be null or empty.");
            }
            _name = value;
        }
    }

    public decimal Price
    {
        get => _price;
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Price cannot be negative.");
            }
            _price = value;
        }
    }
    public decimal PriceWithTax => Price * 1.15m; 


    public Product(int id, string name, decimal price)
    {
        Id = id;
        Name = name;
        Price = price;
    }
}