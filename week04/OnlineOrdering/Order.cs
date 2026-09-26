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
        return 1.1;
    }

    public string ShippingLabel()
    {
        return "";
    }

    public string PackingLabel()
    {
        return "";
    }
}
// End Order.cs