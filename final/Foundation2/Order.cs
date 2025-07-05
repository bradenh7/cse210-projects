using System;
using System.Collections.Generic;

public class Order
{
    private List<Product> _products;
    private Customer _customer;
    private double us_shipping_cost = 5.00;
    private double international_shipping_cost = 35.00;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double CalculateTotalPrice()
    {
        double totalProductCost = 0.0;

        foreach (var product in _products)
        {
            totalProductCost += product.GetTotalCost();
        }

        double shippingCost = _customer.InUSA() ? us_shipping_cost : international_shipping_cost;
        return totalProductCost + shippingCost;
    }

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