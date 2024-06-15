using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
    DisplayWelcome();
    string name = PromptUserName();
    int number = PromptUserNumber();
    int squaredNumber = SquareNumber(number);
    DisplayResult(name, squaredNumber);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program! ");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string favoriteNumberString = Console.ReadLine();
        int favoriteNumberInt = int.Parse(favoriteNumberString);
        return favoriteNumberInt;
    }

    static int SquareNumber(int number)
    {
        int numberSquared = number * number;
        return numberSquared;
    }

    static void DisplayResult(string name, int squaredNumber)
    {
        Console.Write($"{name}, the square of your number is {squaredNumber}.");
    }
    
}