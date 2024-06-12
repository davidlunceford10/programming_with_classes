using System;
using System.Diagnostics.Tracing;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string userGradePercentage = Console.ReadLine();
        float userPercentage = float.Parse(userGradePercentage);
        string letter;

        if (userPercentage >= 90)
        {
            letter = "A"; 
            Console.WriteLine($"{letter}");
        }

        else if (userPercentage >= 80 && userPercentage < 90)
        {
            letter = "B"; 
            Console.WriteLine($"{letter}");
        }

        else if (userPercentage >= 70 && userPercentage < 80)
        {
            letter = "C"; 
            Console.WriteLine($"{letter}");
        }

        else if (userPercentage >= 60 && userPercentage < 70)
        {
            letter = "D"; 
            Console.WriteLine($"{letter}");
        }

        else if (userPercentage < 60)
        {
            letter = "F"; 
            Console.WriteLine($"{letter}");
        }

        else
        {
            Console.WriteLine("That is invalid input.");
        }

        if (userPercentage >= 70)
        {
            Console.WriteLine("Congratulations! You passed the class!");
        }
        else
        {
            Console.WriteLine("You did not pass, best of luck on your second goaround!");
        }

    }
}