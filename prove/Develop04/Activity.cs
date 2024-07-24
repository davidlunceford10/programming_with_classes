public class Activity
{
    private string _activityName;
    private string _activityDescription;
    private int _activityDuration;

    public Activity(string activityName, string activityDescription)
    {
        _activityName = activityName;
        _activityDescription = activityDescription;
    }

    public void AwesomeSpinnerAnimation(int spinnerTimeSeconds) 
    {
        List<string> spinnerStrings = new List<string>();
        spinnerStrings.Add("|");
        spinnerStrings.Add("/");
        spinnerStrings.Add("-");
        spinnerStrings.Add("\\");
        spinnerStrings.Add("|");
        spinnerStrings.Add("/");
        spinnerStrings.Add("-");
        spinnerStrings.Add("\\");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(spinnerTimeSeconds);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            string s = spinnerStrings[i];
            Console.Write(s);
            Thread.Sleep(80);
            Console.Write("\b \b");

            i++;

            if (i >= spinnerStrings.Count)
            {
                i = 0;
            }
        }
    }

    public void CountdownAnimation(int countdownNumber)
    {
        for (int i = countdownNumber; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public int GetActivityDuration()
    {
        return _activityDuration;
    }

    public void StartingMessage()
    {
        Console.WriteLine($"Welcome to the {_activityName}.\n\n{_activityDescription}\n\n");
        Console.Write("How long, in seconds, would you like for your session? ");
        int activityDuration = int.Parse(Console.ReadLine());
        _activityDuration = activityDuration;
        Console.Clear();
        Console.WriteLine("\nGet Ready...");
        AwesomeSpinnerAnimation(3);
    }

    public void EndingMessage()
    {
        Console.WriteLine($"\n\nGood job!");
        AwesomeSpinnerAnimation(3);
        Console.WriteLine($"\nYou have completed {_activityDuration} second(s) of the {_activityName}.\n");
        AwesomeSpinnerAnimation(3);
    }
}