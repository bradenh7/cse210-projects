using System;

public class Reflection
{
    private List<string> _reflectionPrompts;
    private List<string> _reflectionQuestions;


    public Reflection(int duration)
    {
        _reflectionPrompts = new List<string>
        {
            "Think about a time you faced a challenge and how you overcame it.",
            "Reflect on a moment of joy and what made it special.",
            "Consider a lesson you've learned recently and how it has impacted you."
        };

        _reflectionQuestions = new List<string>
        {
            "What did you learn from this experience?",
            "How can you apply this lesson in the future?",
            "What emotions did this experience evoke in you?"
        };
    }

    public void StartReflection()
    {
        Console.WriteLine("Starting Reflection Activity...");
        Activity.DisplayActivityDetails();
        Console.WriteLine("Please reflect on the following prompts:");

        foreach (var prompt in _reflectionPrompts)
        {
            Console.WriteLine(prompt);
            Console.WriteLine("Take a moment to think about your response...");
            System.Threading.Thread.Sleep(5000); // Simulate thinking time
            Console.WriteLine("Now, answer the following questions:");
            
            foreach (var question in _reflectionQuestions)
            {
                Console.WriteLine(question);
                string response = Console.ReadLine();
                Console.WriteLine($"Your response: {response}");
            }
        }

        Console.WriteLine("Reflection activity completed. Thank you for your insights!");
    }
}