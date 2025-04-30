using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomMessage();

        string username = PromptUsername();
        int number = PromptUserNumber();
        int squaredNumber = SquareNumber(number);

        DisplayResult(username, number, squaredNumber);
    }

    static void DisplayWelcomMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUsername()
    {
        Console.Write("Please enter your username: ");
        string username = Console.ReadLine();
        return username;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine()); 
        return number;
    }

    static int SquareNumber(int number)
    {
        return number * number;
    }

    static void DisplayResult(string username, int number, int squaredNumber)
    {
        Console.WriteLine($"Hello {username}, your favorite number is {number} and its square is {squaredNumber}.");
    }
}