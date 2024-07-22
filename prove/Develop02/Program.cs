using System;
using System.Collections.Generic;
using System.IO;

namespace Develop02
{
//ChatGPT was used for this project. Here in Program.cs, we have a menu that uses a switch statement to enable the user to utilize the methods available from the Entry and Journal classes to perform journal functions.
    class Program
    {
        static void Main(string[] args)
        {
            Journal journal = new Journal();
            bool running = true;

            while (running)
            {
                Console.WriteLine("Journal Menu:");
                Console.WriteLine("1. Add Entry");
                Console.WriteLine("2. Display Entries");
                Console.WriteLine("3. Save Entries");
                Console.WriteLine("4. Load Entries");
                Console.WriteLine("5. Exit");
                Console.Write("Select an option: ");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        journal.AddEntry();
                        break;
                    case "2":
                        journal.DisplayEntries();
                        break;
                    case "3":
                        journal.SaveEntries();
                        break;
                    case "4":
                        journal.LoadEntries();
                        break;
                    case "5":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }

                Console.WriteLine();
            }
        }
    }
}
