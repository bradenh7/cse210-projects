using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Address addr1 = new Address("123 Maple St", "Springfield", "IL", "USA");
        Address addr2 = new Address("456 Elm St", "Orlando", "FL", "USA");
        Address addr3 = new Address("789 Pine St", "Denver", "CO", "USA");

        Event lecture = new Lecture("Future of AI", "A lecture on AI advancements", "2025-08-10", "10:00 AM", addr1, "Dr. Jane Smith", 100);
        Event reception = new Reception("Company Mixer", "An evening to connect", "2025-08-12", "6:00 PM", addr2, "rsvp@eventco.com");
        Event outdoor = new OutdoorGathering("Summer Festival", "Live music and food trucks", "2025-08-15", "3:00 PM", addr3, "Sunny, 85°F");

        List<Event> events = new List<Event> { lecture, reception, outdoor };

        foreach (Event e in events)
        {
            Console.WriteLine("=== Standard Details ===");
            Console.WriteLine(e.GetStandardDetails());
            Console.WriteLine("\n=== Full Details ===");
            Console.WriteLine(e.GetFullDetails());
            Console.WriteLine("\n=== Short Description ===");
            Console.WriteLine(e.GetShortDescription());
            Console.WriteLine("\n===========================\n");
        }
    }
}