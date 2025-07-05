using System;

public class Customer
{
    private string _name; // Customer's name
    private Address _address; // Customer's address

    // Properties to get and set the customer's name and address
    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public Address Address
    {
        get { return _address; }
        set { _address = value; }
    }


    // Constructor to initialize the customer with a name and address
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    // Method to check if the customer is in the USA
    public bool InUSA()
    {
        return _address.InUSA();
    }
}