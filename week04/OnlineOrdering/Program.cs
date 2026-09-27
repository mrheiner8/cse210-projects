// Program.cs
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");

        List<Order> orders = new List<Order>();

        // Name and create 1st 'Address' instance 
        Address a1 = new Address("482 Birchwood Ln", "Denver", "CO", "80202", "USA");
        Customer a1c1 = new Customer("Maria", "Chen", a1);
        Product a1p1 = new Product("Wireless Earbuds", "SKU-1001", 59.99, 1);
        Product a1p2 = new Product("Stainless Steel Water Bottle", "SKU-1002", 18.50, 2);
        Order a1o1 = new Order(a1c1);
        a1o1.AddProduct(a1p1);
        a1o1.AddProduct(a1p2);
        orders.Add(a1o1);

        // Name and create 2nd 'Address' instance 
        Address a2 = new Address("17 Kingsway Rd", "Toronto", "ON", "M4B1B3", "Canada");
        Customer a2c1 = new Customer("Tobias", "Oyelaran", a2);
        Product a2p1 = new Product("Yoga Mat", "SKU-1003", 21.01, 2);
        Product a2p2 = new Product("Cast Iron Skillet", "SKU-1004", 34.75, 3);
        Order a2o1 = new Order(a2c1);
        a2o1.AddProduct(a2p1);
        a2o1.AddProduct(a2p2);
        orders.Add(a2o1);

        // Name and create 3rd 'Address' instance 
        Address a3 = new Address("9 Grafton St", "Dublin", "Leinster", "D02X285", "Ireland");
        Customer a3c1 = new Customer("Liam", "O'Connor", a3);
        Product a3p1 = new Product("Bluetooth Speaker", "SKU-1006", 45.00, 2);
        Product a3p2 = new Product("Laptop Stand", "SKU-1008", 32.02, 2);
        Product a3p3 = new Product("Backpack", "SKU-1010", 42.00, 3);
        Order a3o1 = new Order(a3c1);
        a3o1.AddProduct(a3p1);
        a3o1.AddProduct(a3p2);
        a3o1.AddProduct(a3p3);
        orders.Add(a3o1);

        foreach (Order r in orders)
        {
            Console.WriteLine($"\nPacking Label: {r.PackingLabel()}\nShipping Label: {r.ShippingLabel()}\nTotal Price: ${r.TotalCost():F2}");
        }    
    }
}
// End Program.cs