// Address.cs
using System;
using System.Collections.Generic;

// Create a class (custom data types) to use in Program
public class Address
{
    // Member variables
    private string _streetAddress = "";
    private string _city = "";
    private string _stateProvince = "";
    private int _postalCode;
    private string _country;

    // Constructors
    public Address(string streetAddress, string city, string stateProvince, int postalCode, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _stateProvince = stateProvince;
        _postalCode = postalCode;
        _country = country;
    }

    // Getters and Setters

    public string GetStreetAddress()
    {
        return _streetAddress;
    }

    public void SetStreetAddress(string streetAddress)
    {
        _streetAddress = streetAddress;
    }

    public string GetCity()
    {
        return _city;
    }

    public void SetCity(string city)
    {
        _city = city;
    }

    public string GetStateProvince()
    {
        return _stateProvince;
    }

    public void SetStateProvince(string stateProvince)
    {
        _stateProvince = stateProvince;
    }

    public int GetPostalCode()
    {
        return _postalCode;
    }

    public void SetPostalCode(int postalCode)
    {
        _postalCode = postalCode;
    }

    public string GetCountry()
    {
        return _country;
    }

    public void SetCountry(string country)
    {
        _country = country;
    }



    // Methods
    public bool Usa()
    {
        if (GetCountry() == "USA")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public string ShowAddress()
    {
        return $"{_streetAddress}\n{_city}, {_stateProvince} {_postalCode}\n{_country}";
    }
}
// End Address.cs