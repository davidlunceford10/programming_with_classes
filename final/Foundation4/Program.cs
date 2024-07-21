using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Exercise Tracker\nHere are the recorded activities!");

        Running running1 = new Running("7/14/2024", 30, "Running", 4);
        StationaryCycling cycling1 = new StationaryCycling("7/24/2024", 70, "Stationary Cycling", 5);
        Swimming swimming1 = new Swimming("6/29/2024", 60, "Swimming", 80);

        List<Activity> activitiesList = new List<Activity>();
        activitiesList.Add(running1);
        activitiesList.Add(cycling1);
        activitiesList.Add(swimming1);

        foreach (Activity activity in activitiesList)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}

//ChatGPT helped with this assignment.