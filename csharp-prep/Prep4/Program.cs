using System;

class Program
{
    static void Main(string[] args)
    {
        int sum = 0;
        
        int largest = 0;


        Console.WriteLine("Enter a list of numbers, type 0 when finished:");
        List<int> numbers = new List<int>();
        int input = -1;
        while (input != 0)
        {
            Console.Write("Enter number: ");
            input = Convert.ToInt32(Console.ReadLine());
            if (input != 0)
            {
                numbers.Add(input);
            }
        }


        foreach (int number in numbers)
        {
            if (number > largest)
            {
                largest = number;
            }
            sum += number;
        }
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");
    }
}