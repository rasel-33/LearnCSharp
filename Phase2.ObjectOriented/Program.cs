// using Phase2.ObjectOriented;

// Product product = new Product(1, "Laptop", 1000.00m);

// Console.WriteLine($"Product Name: {product.Name}");
// Console.WriteLine($"Product Price with Tax: {product.PriceWithTax}");
// Console.WriteLine($"Is the product expensive? {product.IsExpensive}");

// try
// {
//     product.Price = -500.00m; // This will throw an exception
// }
// catch (ArgumentException ex)
// {
//     Console.WriteLine($"Error: {ex.Message}");
// }

// Product product2 = new Product(2, "Mouse");
// Product product3 = new Product(3, "Keyboard") {Price = 50.00m};

// Console.WriteLine($"Product 2 Name: {product2.Name}");
// Console.WriteLine($"Product 2 Price with Tax: {product2.PriceWithTax}");
// Console.WriteLine($"Product 2 Price: {product2.Price}");

// Console.WriteLine($"Product 3 Name: {product3.Name}");
// Console.WriteLine($"Product 3 Price with Tax: {product3.PriceWithTax}");
// Console.WriteLine($"Product 3 Price: {product3.Price}");

// Console.WriteLine($"Total Products Created: {Product.TotalProductsCreated}");

// DigitalProduct digitalProduct = new DigitalProduct(4, "E-book", 20.00m, "https://example.com/download/ebook");

// Console.WriteLine($"Digital Product Name: {digitalProduct.Name}");
// Console.WriteLine($"Digital Product Shipping Cost: {digitalProduct.ShippingCost}");
// Console.WriteLine($"Digital Product Price with Tax: {digitalProduct.PriceWithTax}");

// Product[] products = { product, product2, product3, digitalProduct };

// foreach (var prod in products)
// {
//     if (prod is DigitalProduct dp)
//     {
//         Console.WriteLine($"Name: {dp.Name}, Download URL: {dp.DownloadUrl}, Shipping Cost: {dp.ShippingCost}");
//     }
//     else
//     {
//         Console.WriteLine($"Name: {prod.Name}, Shipping Cost: {prod.ShippingCost}");
//     }
// }

// Console.WriteLine($"Discounted Price: {product.GetDiscountedPrice(10)}"); // 10% discount

// PaymentMethod[] payments = {
//     new CreditCardPayment(100.00m),
//     new CashPayment(50.00m)
// };

// foreach (var payment in payments)
// {
//     Console.WriteLine(payment.Summary());
//     if (payment is IRefundable r)
//     {
//         Console.WriteLine($"Refund Amount: {r.Refund(30.00m)}");
//     }
// }

// var a = new Product(5, "Tablet", 300.00m);
// var b = new Product(5, "Tablet", 300.00m);

// Console.WriteLine($"Are products a and b equal? {a.Equals(b)}"); 
// Console.WriteLine($"{a == b}"); 

// HashSet<Product> productSet = new HashSet<Product>();
// productSet.Add(a);
// productSet.Add(b); 
// Console.WriteLine($"{productSet.Count}");

// Console.WriteLine(a.ToString());


// Money money1 = new Money(100.00m, "USD");
// Money money2 = new Money(100.00m, "USD");

// Console.WriteLine(a.Equals(b)); 
// Console.WriteLine($"{money1 == money2}");
// Console.WriteLine(money1);

// Money money3 = money1 with { Amount = 200.00m };
// Console.WriteLine(money3);
// Console.WriteLine(money1);

// Customer customer = new Customer(1, "John Doe", new Address("123 Main St", "Anytown", "12345"));
// Console.WriteLine(customer);
// customer.Address = customer.Address with { City = "Manchester" };
// Console.WriteLine(customer);



Animal a = new Dog();     // declared type: Animal | runtime type: Dog

Console.WriteLine(a.Speak());  // "Woof"     → override → RUNTIME type (Dog) wins
Console.WriteLine(a.Name());   // "Animal"   → hidden   → DECLARED type (Animal) wins

class Animal
{
    public virtual string Speak() => "...";   // virtual  → can be overridden
    public string Name() => "Animal";         // normal   → can only be hidden
}

class Dog : Animal
{
    public override string Speak() => "Woof"; // override
    public new string Name() => "Dog";        // new = hide
}