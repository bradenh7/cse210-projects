using System;

public class Product
{
    private string _name; // Product name
    private int _productId; // Product ID
    private double _price; // Product price
    private int _quantity; // Quantity of the product

    // Properties to get and set the product details
    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public int ProductId
    {
        get {return _productId;}
        set {_productId = value;}
    }

    public double GetTotalCost()
    {
        return _price * _quantity;
    }


    // Constructor to initialize the product with name, ID, price, and quantity
    public Product(string name, int productId, double price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }
}