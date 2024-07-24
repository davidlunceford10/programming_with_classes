using System;
using System.Collections.Generic;
using System.Threading.Tasks;

public class ListingActivity : Activity
//ChatGPT helped me implement an Async Input Task, which enabled the loop for the StatListingActivity() method to run the timer while asynchronously taking in user input and refreshing the screen.
{
    private List<string> _listingPrompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity(string activityName = "Listing Activity", string activityDescription = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.") 
        : base(activityName, activityDescription)
    {
    }

    public void StartListingActivity()
    {
        Random random = new Random();

        StartingMessage();

        int listingActivityDuration = GetActivityDuration();
        TimeSpan listingDurationTimeSpan = TimeSpan.FromSeconds(listingActivityDuration);
        DateTime endTime = DateTime.Now.Add(listingDurationTimeSpan);

        List<string> userResponses = new List<string>();

        string randomListingQuestion = _listingPrompts[random.Next(_listingPrompts.Count)];
        int index = _listingPrompts.IndexOf(randomListingQuestion);

        var inputTask = Task.Run(() =>
        {
            while (DateTime.Now < endTime)
            {
                string userResponse = Console.ReadLine();
                if (!string.IsNullOrEmpty(userResponse))
                {
                    lock (userResponses)
                    {
                        userResponses.Add(userResponse);
                    }
                }
            }
        });

        while (DateTime.Now < endTime)
        {
            Console.Clear();
            Console.WriteLine($"{_listingPrompts[index]}");

            lock (userResponses)
            {
                foreach (var item in userResponses)
                {
                    Console.WriteLine(item);
                }
            }

            Task.Delay(700).Wait(); // Small delay to prevent excessive CPU usage
        }


        if (userResponses.Count == 1)
        {
            Console.WriteLine($"\nYou typed {userResponses.Count} item!");
        }
        else 
        {
            Console.WriteLine($"\nYou typed {userResponses.Count} items!");
        }
        
        EndingMessage();
    }
}