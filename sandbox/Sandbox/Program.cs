using System;

class Program : Program2
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");
        
        Program2.
   


    
        // Age validation using a while loop
        int userAge = -10;

        while (userAge < 0 || userAge > 120)
        {
            Console.WriteLine("Please input your age (0-120): ");
            userAge = int.Parse(Console.ReadLine());
        }

        // For loop example
        for (int i = 0; i < 100; i += 10) // For i in range 100, every 10th number
        {
            Console.WriteLine(i);
        }

        // Declare lists
        List<int> myNumbers = new List<int>();
        List<string> myNames = new List<string>();

        // Add names to the list
        myNames.Add("Bob");
        myNames.Add("Billy");
        myNames.Add("Betty");

        // Print names using foreach loop
        foreach (string name in myNames)
        {
            Console.WriteLine(name);
        }

        // Add a number to the list
        myNumbers.Add(12);

        // Print numbers using foreach loop
        foreach (int number in myNumbers)
        {
            Console.WriteLine(number);
        }
    }
}

