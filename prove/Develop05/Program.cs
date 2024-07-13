using System;
using System.Runtime.CompilerServices;

class Program 
{
    static void Main(string[] args)
    {
    
    
        {
            List<Goal> goals = new List<Goal>();
            Goal newGoal = new Goal();
            bool exit = false;

            while (!exit)
            {
                Console.Clear();
                Console.WriteLine("Main Menu");
                Console.WriteLine("1. Create New Goal");
                Console.WriteLine("2. List Goals");
                Console.WriteLine("3. Save Goals");
                Console.WriteLine("4. Load Goals");
                Console.WriteLine("5. Record Event");
                Console.WriteLine("6. Quit");
                Console.Write("Please select an option: ");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        newGoal.CreateNewGoal();
                        break;
                    case "2":
                        Console.WriteLine("You selected Option 2.");
                        break;
                    case "3":
                        
                        break;
                    case "4":
                        Console.WriteLine("You selected Option 4.");
                        break;
                    case "5":
                        Console.WriteLine("You selected Option 4.");
                        break;
                    case "6":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid selection. Please try again.");
                        break;
                }

                if (!exit)
                {
                    Console.WriteLine("Press any key to return to the main menu");
                    Console.ReadKey();
                }
            }
        }
     
    }
    
}