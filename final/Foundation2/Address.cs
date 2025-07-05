using System;

public class Address
{
    private string _street; // Street address
    private string _city; // City name
    private string _state; // State name
    private string _country; // Country name

    // Properties to get and set the address components
    public string Street
    {
        get { return _street; }
        set { _street = value; }
    }

    public string City
    {
        get {return _city;}
        set{_city = value;}
    }

    public string State
    {
        get {return _state;}
        set{_state = value;}
    }

    public string Country
    {
        get {return _country;}
        set{_country = value;}
    }




    // Constructor to initialize the address with street, city, state, and country
    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }


    // Method to check if the address is in the USA
    public bool InUSA()
    {
        return _country.ToLower() == "usa";
    }

    // Method to get the full address as a formatted string
    public string GetFullAddress()
    {
        return $"{_street} \n {_city}, {_state} \n {_country}";
    }
}