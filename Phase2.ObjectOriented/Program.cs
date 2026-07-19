using Phase2.ObjectOriented;

Product product = new Product(1, "Laptop", 1000.00m);

Console.WriteLine($"Product Name: {product.Name}");
Console.WriteLine($"Product Price with Tax: {product.PriceWithTax}");

try
{
    product.Price = -500.00m; // This will throw an exception
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}