public class Event
{
    // attributes for Event class
    private string title;
    private string description;
    private string date;
    private string time;
    private Address address;

    // constructor for Event class
    public Event(string title, string description, string date, string time, Address address)
    {
        this.title = title;
        this.description = description;
        this.date = date;
        this.time = time;
        this.address = address;
    }

    // getters for Event class attributes
    public string GetTitle() => title;
    public string GetDescription() => description;
    public string GetDate() => date;
    public string GetTime() => time;
    public Address GetAddress() => address;

    // methods to get event details
    public virtual string GetStandardDetails()
    {
        return $"Title: {title}\nDescription: {description}\nDate: {date}\nTime: {time}\nAddress: {address.GetFullAddress()}";
    }

    public virtual string GetFullDetails()
    {
        return GetStandardDetails();
    }

    public virtual string GetShortDescription()
    {
        return $"Event Type: General\nTitle: {title}\nDate: {date}";
    }
}