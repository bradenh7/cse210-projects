using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        PromptGenerator promptGenerator = new PromptGenerator();
        Journal journal = new Journal();
        Entry entry = new Entry();
        

        while (true)
        {
              
            DisplayMenu();
            Console.Write("Please choose an option: ");
            string choice = Console.ReadLine();

            try 
            {
                if (choice == "1")
                {
                    Console.Clear(); 
                    Console.WriteLine("You chose to write an entry.");
                    PromptGenerator.GetRandomPrompt();
                    string response = Console.ReadLine();
                    entry._entry = response;  // Call method to write entry
                    journal.AddEntry(entry._entry); // Call method to add entry to journal
                }
                else if (choice == "2")
                {
                    Console.Clear(); 
                    Console.WriteLine("You chose to display the journal.\n");
                    journal.DisplayEntries(); // Call method to display journal
                    Console.Write("\nPress Enter to continue...");
                    Console.ReadLine(); // Wait for user input before continuing
                }
                else if (choice == "3")
                {
                    Console.Clear(); 
                    Console.WriteLine("You chose to save the journal.");
                    Console.WriteLine("Enter the filename to save:");
                    string savefilename = Console.ReadLine();
                    journal.SaveToFile(savefilename); // Call method to save journal
                }
                else if (choice == "4")
                {
                    Console.Clear(); 
                    Console.WriteLine("You chose to load the journal.");
                    Console.WriteLine("Enter the filename to load:");
                    string loadfilename = Console.ReadLine();
                    journal.LoadFromFile(loadfilename); // Call method to load journal
                }
                else if (choice == "5")
                {
                    if (journal._saved == 1)
                    {
                        Console.Clear(); 
                        Console.WriteLine("Goodbye!");
                        break;
                    }
                
                    else if (journal._saved == 0)
                    {
                        Console.Clear(); 
                        Console.WriteLine("You have unsaved changes. Please save your journal before quitting.");
                        Console.WriteLine("Press Enter to continue...");
                        Console.ReadLine(); // Wait for user input before continuing
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please try again.");
                }
            }
            catch (Exception)
            {
                Console.WriteLine($"An error occurred");
                return;
            }
        }

        static void DisplayMenu()
        {
            Console.WriteLine("Welcome to the Journal Program!\n");
            Console.WriteLine("[1] Write Entry");
            Console.WriteLine("[2] Display Journal");
            Console.WriteLine("[3] Save Journal");
            Console.WriteLine("[4] Load Journal");
            Console.WriteLine("[5] Quit");
        }

    }
}