using System;

class Program
{
    static void Main(string[] args)
    {

        Random random = new Random();
        int magicNumber = random.Next(1, 101); 

        int guess = -1;
        while (true)
        {
            Console.WriteLine("What is your guess?");
            string guessInput = Console.ReadLine();
            guess = int.Parse(guessInput);

            if (guess == magicNumber)
            {
                Console.WriteLine("You guessed it!");
                break;
            }
            else if (guess < magicNumber)
            {
                Console.WriteLine("Too low!");
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("Too high!");
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
        }
    }
}