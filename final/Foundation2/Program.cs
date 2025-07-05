using System;

public class Program
{

    public static void Main(string[] args)
    {

        // Create instances of Address, Customer, Order, and Product
        Address address1 = new Address("123 Main St", "Springfield", "IL", "USA");
        Address address2 = new Address("192 Worcestershire Ln", "London", "England", "UK");

        // Create customers with their respective addresses
        Customer customer = new Customer("Tommy Tanger", address1);
        Customer customer2 = new Customer("Janethon Smithdiggery", address2);

        // Create orders for each customer
        Order order = new Order(customer);
        Order order2 = new Order(customer2);

        // Create products to be added to the orders
        Product product1 = new Product("Shin Gaurd", 101, 19.99, 2);
        Product product2 = new Product("Can Opener", 102, 29.99, 1);
        Product product3 = new Product("Spoon", 103, 1.99, 5);

        // Add products to the orders
        Order order1 = new Order(customer);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        order2 = new Order(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product1);

        // Display shipping and packing labels, and total price for each order
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine($"Total Price: ${order1.CalculateTotalPrice():0.00}\n");

        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine($"Total Price: ${order2.CalculateTotalPrice():0.00}\n");

    }




}