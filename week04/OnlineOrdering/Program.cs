using System;

class Program
{
    static void Main(string[] args)
    {
        // Create first order - USA customer
        Address address1 = new Address("123 Main Street", "Springfield", "IL", "USA");
        Customer customer1 = new Customer("John Smith", address1);

        Product product1 = new Product("Laptop", "P001", 899.99, 1);
        Product product2 = new Product("Mouse", "P002", 29.99, 2);
        Product product3 = new Product("Keyboard", "P003", 79.99, 1);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        // Display order 1 details
        Console.WriteLine("==============================");
        Console.WriteLine("ORDER 1 - USA CUSTOMER");
        Console.WriteLine("==============================\n");

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine();
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine();
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost():F2}");
        Console.WriteLine("\n");

        // Create second order - International customer
        Address address2 = new Address("456 Oak Avenue", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Sarah Johnson", address2);

        Product product4 = new Product("Headphones", "P004", 149.99, 1);
        Product product5 = new Product("USB Cable", "P005", 12.99, 3);

        Order order2 = new Order(customer2);
        order2.AddProduct(product4);
        order2.AddProduct(product5);

        // Display order 2 details
        Console.WriteLine("==============================");
        Console.WriteLine("ORDER 2 - INTERNATIONAL CUSTOMER");
        Console.WriteLine("==============================\n");

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine();
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine();
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost():F2}");
    }
}
