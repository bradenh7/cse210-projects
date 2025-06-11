using System;

public class Listing : Activity
{
    private List<string> _prompts;
    private List<string> _userResponses;

    

    public Listing(int duration) : base("Listing Activity", "This activity will help you reflect on the positive aspects of your life by listing things that you are grateful for, accomplishments, and people who have positively influenced you.", duration)
    {
        
        _prompts = new List<string>
        {
            "List three things you are grateful for today.",
            "Write about a recent accomplishment and how it made you feel.",
            "Describe a person who has had a positive impact on your life."
        };

        _userResponses = new List<string>();
    }

    public void StartListing()
    {
        Console.WriteLine("Starting Listing Activity...");
        DisplayActivityDetails();
        Console.WriteLine("Please respond to the following prompts:");

        foreach (var prompt in _prompts)
        {
            Console.WriteLine(prompt);
            string response = Console.ReadLine();
            _userResponses.Add(response);
        }

        Console.WriteLine("Thank you for your responses! Here is what you wrote:");
        foreach (var response in _userResponses)
        {
            Console.WriteLine($"- {response}");
        }
    }
}