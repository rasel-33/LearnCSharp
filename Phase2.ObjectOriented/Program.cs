using Phase2.ObjectOriented;

Product product = new Product(1, "Laptop", 1000.00m);

Console.WriteLine($"Product Name: {product.Name}");
Console.WriteLine($"Product Price with Tax: {product.PriceWithTax}");
Console.WriteLine($"Is the product expensive? {product.IsExpensive}");

try
{
    product.Price = -500.00m; // This will throw an exception
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}

Product product2 = new Product(2, "Mouse");
Product product3 = new Product(3, "Keyboard") {Price = 50.00m};

Console.WriteLine($"Product 2 Name: {product2.Name}");
Console.WriteLine($"Product 2 Price with Tax: {product2.PriceWithTax}");
Console.WriteLine($"Product 2 Price: {product2.Price}");

Console.WriteLine($"Product 3 Name: {product3.Name}");
Console.WriteLine($"Product 3 Price with Tax: {product3.PriceWithTax}");
Console.WriteLine($"Product 3 Price: {product3.Price}");

Console.WriteLine($"Total Products Created: {Product.TotalProductsCreated}");

DigitalProduct digitalProduct = new DigitalProduct(4, "E-book", 20.00m, "https://example.com/download/ebook");

Console.WriteLine($"Digital Product Name: {digitalProduct.Name}");
Console.WriteLine($"Digital Product Shipping Cost: {digitalProduct.ShippingCost}");
Console.WriteLine($"Digital Product Price with Tax: {digitalProduct.PriceWithTax}");