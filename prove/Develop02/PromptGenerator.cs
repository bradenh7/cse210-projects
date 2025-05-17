using System; 

public class PromptGenerator
{
    private static string[] prompts = new string[]
    {
        "What was the best part of your day?",
        "What are you grateful for today?",
        "Describe a challenge you faced and how you overcame it.",
        "What is something you learned today?",
        "What are your goals for tomorrow?",
        "What made you smile today?",
        "What is something you wish you could change about today?",
        "What can you do to improve tomorrow?",
        "What is a memory that makes you happy?",
        "What is something you are looking forward to?",
        "What is a lesson you learned from a mistake?",
        "What is something you did that you are proud of?",
        "What is something you want to do more of?",
    };

    public static void GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(prompts.Length);
        Console.WriteLine(prompts[index]);
    }
}