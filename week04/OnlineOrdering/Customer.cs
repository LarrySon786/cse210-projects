using System;

class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public bool LivesInUsa()
    {
        if (_address.IsInUsa() == true)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public void DisplayAddress()
    {
        _address.DisplayFullAddress();
    }
    public string GetName()
    {
        return _name;
    }

}