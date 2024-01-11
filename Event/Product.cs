
namespace Event;

internal class Product
{
    private decimal _price= 0.0m;

    internal event EventHandler<decimal> PriceChanged;

    public Product()
    {
    }

    public string Name { get; set; } = string.Empty;

    public decimal Price
    {
        get { return _price; }
        set
        {
            // Check if the new price is different
            if (_price != value)
            {
                // Update the price
                _price = value;

                // Fire the PriceChanged event
                OnPriceChanged(_price);
            }
        }
    }

    // Method to handle price changes and fire the event
    private void OnPriceChanged(decimal newPrice)
    {
        // Check if there are subscribers to the event
        PriceChanged?.Invoke(this, newPrice);
    }
}
