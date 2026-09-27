// Order.cs
using System;
using System.Collections.Generic;

// Create a class (custom data types) to use in Program
public class Order
{
    // Member variables (fields)
    private Customer _customer;
    private List<Product> _products;

    // Constructors
    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    // Getters and Setters

    public List<Product> GetProducts()
    {
        return _products;
    }

    // Methods
    public void AddProduct(Product newProduct)
    {
        _products.Add(newProduct);
    }

    public double TotalCost()
    {
        double subtotal = 0;
        double total = 0;
        foreach (Product p in _products)
        {
            subtotal += p.TotalCost();
        }

        if (_customer.Usa() == true)
        {
            total = subtotal + 5;
        }
        else
        {
            total = subtotal + 35;
        }
        return total;
    }

    public string ShippingLabel()
    {
        return $"{_customer.GetGivenName()} {_customer.GetFamilyName()}\n{_customer.GetAddress().ShowAddress()}";
    }

    public string PackingLabel()
    {
        string displayPackingLabel = "";
        foreach (Product p in _products)
        {
            displayPackingLabel += $"\n{p.GetName()}: {p.GetProductId()}";
        }
        return displayPackingLabel;
    }
}
// End Order.cs