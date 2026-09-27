// Product.cs
using System;
using System.Collections.Generic;

// Create a class (custom data types) to use in Program
public class Product
{
    // Member variables
    private string _name = "";
    private string _productId = "";
    private double _price;
    private int _quantity;

    // Constructors
    public Product(string name, string productId, double price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    // Getters and Setters

    public string GetName()
    {
        return _name;
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public string GetProductId()
    {
        return _productId;
    }

    public void SetProductId(string productId)
    {
        _productId = productId;
    }

    public double GetPrice()
    {
        return _price;
    }

    public void SetPrice(double price)
    {
        _price = price;
    }

    public int GetQuantity()
    {
        return _quantity;
    }

    public void SetQuantity(int quantity)
    {
        _quantity = quantity;
    }



    // Methods
    public double TotalCost()
    {
        return _price * _quantity;
    }

    public string ShowCost()
    {
        return "";
    }
}
// End Product.cs