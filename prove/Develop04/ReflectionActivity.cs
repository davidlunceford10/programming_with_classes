public class ReflectionActivity : Activity
{
    private List<string> _promptsList = new List<string>{"Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless."};

    private List<string> _reflectionQuestions = new List<string> {"Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?", "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?"};
    public ReflectionActivity(string activityName = "Reflection Activity", string activityDescription = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.") : base(activityName, activityDescription)
    {
    }

    public void StartReflectionActivity()
    {
        Random random = new Random();

        int randomIndexPrompt = random.Next(_promptsList.Count);
        string randomPrompt = _promptsList[randomIndexPrompt];

        StartingMessage();
        int reflectionActivityDuration = GetActivityDuration();
        Console.WriteLine("\nConsider the following prompt: \n");
        Console.WriteLine($"--- {randomPrompt} ---");
        Console.WriteLine("When you have someting in mind, press enter to continue.");
        while (true)
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey(intercept: true);
            if (keyInfo.Key == ConsoleKey.Enter)
            {
                break; 
            }
        }
        
        Console.WriteLine("\nNow ponder on each of the following questions as they relate to this experience.");
        Console.Write("You may begin in: ");
        CountdownAnimation(4);

        Console.Clear();

        DateTime reflectionEndTime = DateTime.Now.AddSeconds(reflectionActivityDuration);
        int minimumTimePerQuestion = 7;

        while (DateTime.Now < reflectionEndTime)
        {
            int remainingSeconds = (int)(reflectionEndTime - DateTime.Now).TotalSeconds;

            // Determine the time per question
            int timePerQuestion = Math.Min(minimumTimePerQuestion, remainingSeconds);

            // Select a random question
            string randomReflectionQuestion = _reflectionQuestions[random.Next(_reflectionQuestions.Count)];

            Console.WriteLine(randomReflectionQuestion);
            AwesomeSpinnerAnimation(timePerQuestion);

            // Check if there's no more time left
            if (remainingSeconds <= timePerQuestion)
            {
                break;
            }
        }

        EndingMessage();
    }
}