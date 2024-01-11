using Event;

Product product = new Product();

// Subscribe to the PriceChanged event
product.PriceChanged += HandlePriceChanged;

// Set a new price (this will trigger the event)
product.Price = 25.99m;

// Unsubscribe from the event
product.PriceChanged -= HandlePriceChanged;

// Set another new price (this will not trigger the event because there are no subscribers)
product.Price = 19.99m;

Console.ReadLine();
static void HandlePriceChanged(object sender, decimal newPrice)
{
    Console.WriteLine($"Price changed. New price: {newPrice:C}");
}