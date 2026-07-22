namespace Phase2.ObjectOriented;

public class Customer
{
    private string _name = "";
    private Address _address = null!;
    public int Id { get; init; }
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
    public Address Address
    {
        get => _address;
        set
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value), "Address cannot be null.");
            }
            _address = value;
        }
    }

    public Customer(int id, string name, Address address)
    {
        Id = id;
        Name = name;
        Address = address;
    }

    public override string ToString()
    {
        return $"Customer ID: {Id}, Name: {Name}, Address: {Address}";
    }

   
}