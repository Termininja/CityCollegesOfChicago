using System;

class Invoice
{
    private string partNumber;
    private string description;
    private int quantity;
    private decimal price;

    public Invoice(string partNumber, string description, int quantity, decimal price)
    {
        this.PartNumber = partNumber;
        this.Description = description;
        this.Quantity = quantity;
        this.Price = price;
    }

    public string PartNumber
    {
        get
        {
            return this.partNumber;
        }
        set
        {
            this.partNumber = value;
        }
    }

    public string Description
    {
        get
        {
            return this.description;
        }
        set
        {
            this.description = value;
        }
    }

    public int Quantity
    {
        get
        {
            return this.quantity;
        }

        set
        {
            if (value >= 0)
            {
                this.quantity = value;
            }
        }
    }

    public decimal Price
    {
        get
        {
            return this.price;
        }
        set
        {
            if (value >= 0)
            {
                this.price = value;
            }
        }
    }

    public decimal GetInvoiceAmount()
    {
        return this.quantity * this.price;
    }
}