using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What the percentage");
        string input = Console.ReadLine();
        double percentage = double.Parse(input);

        string letter = "";



        if (percentage >= 90 && percentage <= 100)
        {
            letter = "A";
        }
        else if (percentage >= 80 && percentage < 90)
        {
            letter = "B";
        }
        else if (percentage >= 70 && percentage < 80)
        {
            letter = "C";
        }
        else if (percentage >= 60 && percentage < 70)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your letter grade is {letter}.");

        if (percentage >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("You failed, you got it next time!");
        }


        
    }
}