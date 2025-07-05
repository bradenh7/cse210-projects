using System;
using System.Collections.Generic;

public class Order
{
    private List<Product> _products; // List to hold products in the order
    private Customer _customer; // Customer who placed the order
    private double us_shipping_cost = 5.00; // Shipping cost for orders within the USA
    private double international_shipping_cost = 35.00; // Shipping cost for international orders

    // Constructor to initialize the order with a customer
    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    // Method to add a product to the order
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    // Method to calculate the total price of the order
    public double CalculateTotalPrice()
    {
        double totalProductCost = 0.0;

        foreach (var product in _products)
        {
            totalProductCost += product.GetTotalCost();
        }

        double shippingCost = _customer.InUSA() ? us_shipping_cost : international_shipping_cost; // Check if the customer is in the USA to determine shipping cost
        return totalProductCost + shippingCost;
    }

    // Methods to generate packing and shipping labels
    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (var product in _products)
        {
            label += $"{product.Name} (ID: {product.ProductId})\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        string label = "Shipping Label \n";
        label += $"{_customer.Name}\n";
        label += _customer.Address.GetFullAddress();
        return label;
    }
}