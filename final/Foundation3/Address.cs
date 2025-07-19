public class Address
{

    // attributes for Address class
    private string street;
    private string city;
    private string state;
    private string country;

    // constructor for Address class
    public Address(string street, string city, string state, string country)
    {
        this.street = street;
        this.city = city;
        this.state = state;
        this.country = country;
    }

    // method to get address details
    public string GetFullAddress()
    {
        return $"{street}, {city}, {state}, {country}";
    }
}