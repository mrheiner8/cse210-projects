// Customer.cs
using System;
using System.Collections.Generic;

// Create a class (custom data types) to use in Program
public class Customer
{
    // Member variables
    private string _givenName = "";
    private string _familyName = "";
    private Address _address;

    // Constructors
    public Customer(string givenName, string familyName, Address address)
    {
        _givenName = givenName;
        _familyName = familyName;
        _address = address;
    }

    // Getters and Setters

    public string GetGivenName()
    {
        return _givenName;
    }

    public void SetGivenName(string givenName)
    {
        _givenName = givenName;
    }

    public string GetFamilyName()
    {
        return _familyName;
    }

    public void SetFamilyName(string familyName)
    {
        _familyName = familyName;
    }

    public Address GetAddress()
    {
        return _address;
    }

    public void SetAddress(Address address)
    {
        _address = address;
    }

    // Methods
    public bool Usa()
    {
        return _address.Usa();
    }
}
// End Customer.cs