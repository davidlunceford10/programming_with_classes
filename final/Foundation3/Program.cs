using System;

class Program
{
    static void Main(string[] args)
    {
        Lecture lecture1 = new Lecture(
            "Basics of Videogame Design", 
            "Discussion on basic elements of videogame design",
            "7/27/24", 
            "4:00 pm", 
            "1235 Freeborn Lane, Springfield, IL 75443.", 
            "Lecture", 
            "Johnny Cornbriar", 
            340
        );

        OutdoorGathering outdoorGathering1 = new OutdoorGathering(
            "Smores Party",
            "We're having a smores party! Feel free to bring friends!",
            "8/24/24",
            "7:00 pm",
            "Rainbow Bay Resevoir, Heber, UT. 67845.",
            "OutdoorGathering",
            "The weather is going to be slightly overcast, light wind and 75' Fahrenheit."
        );

        Reception reception1 = new Reception(
            "David and Rachel's Wedding Reception",
            "David and Rachel are getting married and they're having a party!",
            "4/30/25",
            "5:00 pm",
            "339 Cloudy Blvd, American Fork, UT. 84758.",
            "Reception",
            "david&rachelreception@yahoo.com"
        );

        Console.WriteLine("\nYou have arrived... to the Event Planner App!");
        Console.WriteLine("Here's a short summary of each event, followed by the full details:");
        Console.WriteLine("------------------------------------------------------");
        Console.WriteLine($"\n{lecture1.DisplayShortDescription()}\n");
        Console.WriteLine($"\n{lecture1.DisplayFullDetails()}");
        Console.WriteLine("\n------------------------------------------------------");
        Console.WriteLine($"\n{outdoorGathering1.DisplayShortDescription()}\n");
        Console.WriteLine($"\n{outdoorGathering1.DisplayFullDetails()}");
        Console.WriteLine("\n------------------------------------------------------");
        Console.WriteLine($"\n{reception1.DisplayShortDescription()}\n");
        Console.WriteLine($"\n{reception1.DisplayFullDetails()}");
        Console.WriteLine("\n------------------------------------------------------");
    }
}