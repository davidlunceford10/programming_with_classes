using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomNumber = new Random();
        int magicNumber = randomNumber.Next(1, 100);
        
        Console.Write("What is your guess? ");
        string numberGuess = Console.ReadLine();
        
        int magicNumberGuessInt = int.Parse(numberGuess);

        if (magicNumber > magicNumberGuessInt)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < magicNumberGuessInt)
            {    
                Console.WriteLine("Lower");
            }   
            else
            {
                Console.WriteLine("You guessed it!");
            }

        do
        {   
            Console.Write("What is your guess? ");
            numberGuess = Console.ReadLine();
            magicNumberGuessInt = int.Parse(numberGuess);

            if (magicNumber > magicNumberGuessInt)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < magicNumberGuessInt)
            {    
                Console.WriteLine("Lower");
            }   
            else
            {
                Console.WriteLine("You guessed it!");
            }

        }while (magicNumberGuessInt != magicNumber);
        
    }
}