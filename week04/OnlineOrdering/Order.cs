using System;
using System.Xml.XPath;

class Order
{

    private Customer _customer;
    private List<Product> _products = new List<Product>();

    public Order(List<Product> products, Customer customer)
    {
        _customer = customer;

        foreach (Product item in products)
        {
            _products.Add(item);
        }

    }

    public double CalculateTotal()
    {
        double totalResult = 0;
        foreach (Product item in _products)
        {
            double result = item.ProductCost();
            totalResult = totalResult + result;
        }
        if (totalResult > 0 && _customer.LivesInUsa() == true)
        {
            //Shipping Charge
            totalResult = totalResult + 5;
        }
        else if (totalResult > 0 && _customer.LivesInUsa() == false)
        {
            totalResult = totalResult + 35;
        }
        return totalResult;
    }

    public void GetPackingLabel()
    {
        //List
        foreach (Product item in _products)
        {
            Console.WriteLine($"{item.GetName()} - {item.GetId()}");
        }
    }

    public void GetShippingLabel()
    {
        Console.WriteLine($"Ship to: {_customer.GetName()}");
        _customer.DisplayAddress();
    }
}