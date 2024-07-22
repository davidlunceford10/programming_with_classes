 class Journal
    {
        //Here in the Journal class we have the basic Journal constructor that initializes a new list for entries and prompts. It also creates a new random object. We also have methods to add, display, and save entries, as well as a method to return a random prompt.
        //The AddEntry() method calls the GetRandomPrompt() method and prints the prompt to the console. It then saves the user's response into the response variable. It saves the date as well and then saves all the data into a new Entry() object, which is saved into the _entries list.
        //The GetRandomPrompt() method returns a random prompt using the random function.
        //The DisplayEntries() method uses a foreach loop to print all journal entries to the console. 
        //The SaveEntries() method requests and records a filename to write the journal entries in _entries to. It catches exceptions using the catch statement. It then uses a new StreamWriter object (writer) to write each entry in _entries to the filename that was previously recorded.
        //The LoadEntries() method asks for the filename to load, reads the user input and uses an if statement to see if the filename exists. If it exists it uses a try statement to clear the current list of entries in the program and read all the lines in the currently loaded filename using a foreach statement. It then splits the code based on the "|: character into an array of parts. If "parts" has exactly three parts, it creates a new Entry() object with the three parts and adds it to the _entries list. Then it prints out a "Entries Loaded" statement to the console. The catch statement catches any exeptions that happened from the 'try' block and prints out a message to the console if any exeptions occurred, as well as exception details. If the filename cannot be found, it prints out a "File not found" error. 
        private List<Entry> _entries;
        private List<string> _prompts;
        private Random rand;

        public Journal()
        {
            _entries = new List<Entry>();
            _prompts = new List<string>
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
            _entries.Add(new Entry(date, prompt, response));
        }

        private string GetRandomPrompt()
        {
            return _prompts[rand.Next(_prompts.Count)];
        }

        public void DisplayEntries()
        {
            foreach (Entry entry in _entries)
            {
                Console.WriteLine($"Date: {entry._date}");
                Console.WriteLine($"Prompt: {entry._prompt}");
                Console.WriteLine($"Response: {entry._response}");
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
                    foreach (Entry entry in _entries)
                    {
                        writer.WriteLine($"{entry._date}|{entry._prompt}|{entry._response}");
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
                    _entries.Clear();
                    string[] lines = File.ReadAllLines(filename);
                    foreach (string line in lines)
                    {
                        string[] parts = line.Split('|');
                        if (parts.Length == 3)
                        {
                            _entries.Add(new Entry(parts[0], parts[1], parts[2]));
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
