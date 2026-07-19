namespace Phase2.ObjectOriented;

public class Product
{
    // fields
    private string _name = "";
    private decimal _price;
    public static int TotalProductsCreated { get; private set; }

    // constants
    const decimal TaxRate = 0.15m;


    // properties
    public int Id { get; init;}
    public decimal PriceWithTax => Price * (1 + TaxRate); 
    public bool IsExpensive => Price > 100m;
    public virtual decimal ShippingCost => 5.00m;

    // constructor

    public Product(int id, string name): this(id, name, 0.0m) { }

    public Product(int id, string name, decimal price)
    {
        Id = id;
        Name = name;
        Price = price;
        TotalProductsCreated++;
    }

    public string Name
    {
        get => _name;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentOutOfRangeException(nameof(value), "Name cannot be null or empty.");
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
                throw new ArgumentOutOfRangeException(nameof(value), "Price cannot be negative.");
            }
            _price = value;
        }
    }
}