using System;
using System.Linq;

public class Salesperson
{
    public Salesperson(string name)
    {
        this.Name = name;
    }

    public string Name { get; set; }

    public Product[] Products { get; set; }

    public void AddProducts(Product[] products)
    {
        this.Products = products;
    }

    public override string ToString()
    {
        var result = string.Format("Name: {0}, sales: {1}, total: ${2}", this.Name, this.Products.Length, this.GetTotal());

        return result;
    }

    private decimal GetTotal()
    {
        var total = 0m;
        this.Products.ToList().ForEach(product => total += product.Price);

        return total;
    }
}
