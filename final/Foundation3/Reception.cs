public class Reception : Event
{
    // attribute for Reception class
    private string rsvpEmail;

    // constructor for Reception class
    public Reception(string title, string description, string date, string time, Address address, string rsvpEmail)
        : base(title, description, date, time, address)
    {
        this.rsvpEmail = rsvpEmail;
    }

    // getter for Reception class attribute
    public override string GetFullDetails()
    {
        return base.GetStandardDetails() + $"\nType: Reception\nRSVP Email: {rsvpEmail}";
    }

    // override method to get short description for Reception class
    public override string GetShortDescription()
    {
        return $"Event Type: Reception\nTitle: {GetTitle()}\nDate: {GetDate()}";
    }
}