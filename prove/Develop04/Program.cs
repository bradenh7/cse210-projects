using System;

class Program
{
    static void Main(string[] args)
    {
        int choice = 0;
        while (choice != 4)
        {
            DisplayMenu();
            string input = Console.ReadLine();
            if (int.TryParse(input, out choice))
            {
                switch (choice)
                {
                    case 1:
                        Breathing breathingActivity = new Breathing(30);
                        breathingActivity.StartBreathingExercise();
                        break;
                    case 2:
                        Reflection reflectionActivity = new Reflection(30);
                        reflectionActivity.StartReflection();
                        break;
                    case 3:
                        Listing listingActivity = new Listing(30);
                        listingActivity.StartListing();
                        break;
                    case 4:
                        Console.WriteLine("Exiting the program. Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid number.");
            }
        }
    }
    static void DisplayMenu()
    {
        Console.WriteLine("Welcome to the Develop04 Program!");
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Reflection Activity");
        Console.WriteLine("3. Listing Activity");
        Console.WriteLine("4. Exit");
        Console.Write("Please select an option: ");
    }
}