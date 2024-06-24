using System;
using System.Collections.Generic;
using System.IO;

namespace Develop02
{
    public class Entry
    {
        public string Date { get; set; }
        public string Prompt { get; set; }
        public string Response { get; set; }

        public Entry(string date, string prompt, string response)
        {
            Date = date;
            Prompt = prompt;
            Response = response;
        }
    }

    class Journal
    {
        private List<Entry> entries;
        private List<string> prompts;
        private Random rand;

        public Journal()
        {
            entries = new List<Entry>();
            prompts = new List<string>
            {
                "Who was the most interesting person I interacted with today?",
                "What was the best part of my day?",
                "How did I see the hand of the Lord in my life today?",
                "What was the strongest emotion I felt today?",
                "If I had one thing I could do over today, what would it be?"
            };
            rand = new Random();
        }

        public void AddEntry()
        {
            string prompt = GetRandomPrompt();
            Console.WriteLine(prompt);
            string response = Console.ReadLine();
            string date = DateTime.Now.ToString("MM/dd/yyyy");
            entries.Add(new Entry(date, prompt, response));
        }

        private string GetRandomPrompt()
        {
            return prompts[rand.Next(prompts.Count)];
        }

        public void DisplayEntries()
        {
            foreach (Entry entry in entries)
            {
                Console.WriteLine($"Date: {entry.Date}");
                Console.WriteLine($"Prompt: {entry.Prompt}");
                Console.WriteLine($"Response: {entry.Response}");
                Console.WriteLine();
            }
        }

        public void SaveEntries()
        {
            Console.Write("Enter filename to save: ");
            string filename = Console.ReadLine();
            try
            {
                using (StreamWriter writer = new StreamWriter(filename))
                {
                    foreach (Entry entry in entries)
                    {
                        writer.WriteLine($"{entry.Date}|{entry.Prompt}|{entry.Response}");
                    }
                }
                Console.WriteLine("Entries saved.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while saving entries: {ex.Message}");
            }
        }

        public void LoadEntries()
        {
            Console.Write("Enter filename to load: ");
            string filename = Console.ReadLine();
            if (File.Exists(filename))
            {
                try
                {
                    entries.Clear();
                    string[] lines = File.ReadAllLines(filename);
                    foreach (string line in lines)
                    {
                        string[] parts = line.Split('|');
                        if (parts.Length == 3)
                        {
                            entries.Add(new Entry(parts[0], parts[1], parts[2]));
                        }
                    }
                    Console.WriteLine("Entries loaded.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred while loading entries: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine("File not found.");
            }
        }
    }

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
