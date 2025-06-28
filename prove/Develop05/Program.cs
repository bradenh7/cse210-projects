using System;

class Program
{
    static void Main()
    {
        GoalManager manager = new();

        while (true)
        {
            Console.WriteLine("\nEternal Quest Menu:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Show Score");
            Console.WriteLine("5. Save Goals");
            Console.WriteLine("6. Load Goals");
            Console.WriteLine("7. Quit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.WriteLine("Choose goal type: 1=Simple, 2=Eternal, 3=Checklist");
                    string type = Console.ReadLine();

                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Description: ");
                    string desc = Console.ReadLine();
                    Console.Write("Points: ");
                    int points = int.Parse(Console.ReadLine());

                    switch (type)
                    {
                        case "1":
                            manager.AddGoal(new SimpleGoal(name, desc, points));
                            break;
                        case "2":
                            manager.AddGoal(new EternalGoal(name, desc, points));
                            break;
                        case "3":
                            Console.Write("Target Count: ");
                            int target = int.Parse(Console.ReadLine());
                            Console.Write("Bonus Points: ");
                            int bonus = int.Parse(Console.ReadLine());
                            manager.AddGoal(new ChecklistGoal(name, desc, points, target, bonus));
                            break;
                    }
                    break;
                case "2":
                    manager.ListGoals();
                    break;
                case "3":
                    manager.ListGoals();
                    Console.Write("Which goal did you complete? ");
                    int index = int.Parse(Console.ReadLine()) - 1;
                    manager.RecordEvent(index);
                    Console.WriteLine();
                    Console.WriteLine("**********************************");
                    Console.WriteLine("*      :) Congratulations! :)    *");
                    Console.WriteLine("*     You've completed a goal!   *");
                    Console.WriteLine("**********************************");
                    Console.WriteLine();
                    break;
                case "4":
                    manager.DisplayScore();
                    break;
                case "5":
                    Console.Write("Filename to save to: ");
                    manager.Save(Console.ReadLine());
                    break;
                case "6":
                    Console.Write("Filename to load from: ");
                    manager.Load(Console.ReadLine());
                    break;
                case "7":
                    return;
            }
        }
    }
}
