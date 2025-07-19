public class Lecture : Event
{
    // attributes for Lecture class
    private string speaker;
    private int capacity;

    // constructor for Lecture class
    public Lecture(string title, string description, string date, string time, Address address, string speaker, int capacity)
        : base(title, description, date, time, address)
    {
        this.speaker = speaker;
        this.capacity = capacity;
    }

    // getters for Lecture class attributes
    public override string GetFullDetails()
    {
        return base.GetStandardDetails() + $"\nType: Lecture\nSpeaker: {speaker}\nCapacity: {capacity}";
    }

    public override string GetShortDescription()
    {
        return $"Event Type: Lecture\nTitle: {GetTitle()}\nDate: {GetDate()}";
    }
}