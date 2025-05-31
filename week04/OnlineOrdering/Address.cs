using System;
using System.Security.Cryptography.X509Certificates;

class Address
{
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;
    private string _zip;

    public Address(string street, string city, string state, string zip, string country)
    {
        _streetAddress = street;
        _city = city;
        _country = country;
        _state = state;
        _zip = zip;

    }

    public bool IsInUsa()
    {
        string location = _country.ToLower();
        if (location == "usa" || location == "united states" || location == "united states of america")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public string GetFullAddress()
    {
        return _streetAddress + " " + _city + " " + _state + " " + _zip + " " + _country;
    }

    public void DisplayFullAddress()
    {
        Console.WriteLine($"{_streetAddress},");
        Console.WriteLine($"{_city}, {_state} {_zip}");
        Console.WriteLine(_country);
    }
}