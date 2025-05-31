using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the OnlineOrdering Project.");


        //Order 1
        List<Order> orders = new List<Order>();
        List<Product> products = new List<Product>();
        Address address = new Address("1234 Bakers Lane", "Smithville", "New York", "22335", "USA");
        Customer customer = new Customer("Johhny Seed", address);


        Product vitaminD = new Product("Vitamin D", "3355", 9.99, 2);
        Product iron = new Product("Iron", "4367", 13.99, 1);

        products.Add(vitaminD);
        products.Add(iron);

        Order order = new Order(products, customer);

        //Order 2
        List<Product> products2 = new List<Product>();
        Address address2 = new Address("6789 Shreve Court", "Teropolis", "Ontario", "77791", "Canada");
        Customer customer2 = new Customer("Larry Son", address2);

        Product zinc = new Product("Zinc", "00334", 19.99, 3);
        Product magnesium = new Product("Magnesium", "6711", 24.99, 1);

        products2.Add(zinc);
        products2.Add(magnesium);

        Order order2 = new Order(products2, customer2);

        orders.Add(order);
        orders.Add(order2);

        Console.WriteLine("-----------------------------------------------------");

        foreach (Order item in orders)
        {
            Console.WriteLine("Packaging Label: ");
            item.GetPackingLabel();
            Console.WriteLine("");

            Console.WriteLine("Shipping Label: ");
            item.GetShippingLabel();
            Console.WriteLine("");


            double total = item.CalculateTotal();
            Console.WriteLine($"Order total: ${total}");
            Console.WriteLine("-----------------------------------------------------");

        }
        



    }
}


//Clases
//1) Product - Attributes - Tracks Name, product ID, price, and quantity
//Methods Behavior - calculate cost of product by multipling price by quantity bought

//2) Customer - Attributes - Tracks customer name, address (class), 
//Method Behavior to determine if they live in USA or not

//3) Address - Attributes - Tracks, street address, city, state, country
//Methods Behavior - determine weather in USA or not
//Methods Behavior - return full address. Returns string that displays complete address line. This should be printed on TWO lines as normal addresses are

//4) Order - Attributes - Tracks List<products> and the customer
//Methods Behavior - Calculates total cost of the order 
//Methods Behavior - Can return a string for packing label
//Methods Behavior - CAn return a string for the shipping label
//***See instructiosn for what should be included in each packing, shipping, and order label

//constructors as needed
//Getters/setters as needed

//Program must create two orders with 2-3 products each. Calls the methods to get the packing label, shipping label, and the total price of the order. Program displays results of all these methods