public abstract class Product
{
    public decimal Price { get; set; }

    public Product(decimal price)
    {
        this.Price = price;
    }
}