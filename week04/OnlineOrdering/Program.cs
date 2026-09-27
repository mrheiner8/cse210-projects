// Program.cs
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");

        List<Order> orders = new List<Order>();

        // Name and create 1st 'Address' instance 
        Address a1 = new Address("streetAddress1", "city1", "stateProvince1", 11111, "USA");
        Customer a1c1 = new Customer("givenName1", "familyName1", a1);
        Product a1p1 = new Product("(product) name1", "productId1", 1.1, 1);
        Product a1p2 = new Product("(product) name2", "productId2", 2.2, 2);
        Order a1o1 = new Order(a1c1);
        a1o1.AddProduct(a1p1);
        a1o1.AddProduct(a1p2);
        orders.Add(a1o1);

        // Name and create 2nd 'Address' instance 
        Address a2 = new Address("streetAddress2", "city2", "stateProvince2", 22222, "country2");
        Customer a2c1 = new Customer("givenName2", "familyName2", a2);
        Product a2p1 = new Product("(product) name2.1", "productId2.1", 21.1, 21);
        Product a2p2 = new Product("(product) name2.2", "productId2.2", 22.2, 22);
        Order a2o1 = new Order(a2c1);
        a2o1.AddProduct(a2p1);
        a2o1.AddProduct(a2p2);
        orders.Add(a2o1);
    }
}
// End Program.cs