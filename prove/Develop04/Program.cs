using System;

class Program
{
    static void Main(string[] args)
    {
        bool exit = false;

        while (!exit)
        {
            Console.Clear(); 
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflection Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. See a couple of my favorite quotes.");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");

            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    BreathingActivity breathing = new BreathingActivity();
                    breathing.StartBreathingActivity();
                    break;
                case "2":
                    ReflectionActivity reflection = new ReflectionActivity();
                    reflection.StartReflectionActivity();
                    break;
                case "3":
                    ListingActivity listing = new ListingActivity();
                    listing.StartListingActivity();
                    break;
                case "4":
                    Console.WriteLine("\"The impediment to action advances action. What stands in the way becomes the way.\"\n-Marcus Aurelius\n\nI'd like to add that in the gospel we teach the same thing. \n\nEther 12:27 says, \"27 And if men come unto me I will show unto them their weakness. I give unto men weakness that they may be humble; and my grace is sufficient for all men that humble themselves before me; for if they humble themselves before me, and have faith in me, then will I make weak things become strong unto them.\"\n\nI know that we can turn any weakness into strength through coming to God with faith and humility. Thanks for reading!.");
                    break;
                case "5":
                    exit = true;
                    Console.WriteLine("Exiting...");
                    break;
                default:
                    Console.WriteLine("Invalid option. Please choose a valid option.");
                    break;
            }

            if (!exit)
            {
                Console.WriteLine("Press any key to return to the menu...");
                Console.ReadKey(); 
            }
        }
    }
}

//ChatGPT helped with this program