public class BreathingActivity : Activity
{
    public BreathingActivity(string activityName = "Breathing Activity", string activityDescription = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.") : base(activityName, activityDescription)
    {
    }

    public void StartBreathingActivity()
    {
        StartingMessage();
        int breathingActivityDuration = GetActivityDuration();
        int fullCycles = breathingActivityDuration / 8;
        int remainingSeconds = breathingActivityDuration % 8;
        
        for (int i = 0; i < fullCycles; i++)
        {
            Console.Write("\n\nBreath in... ");
            CountdownAnimation(4);
            Console.Write("\n\nBreath out... ");
            CountdownAnimation(4);
        }
        
         if (remainingSeconds > 0)
        {
            if (remainingSeconds <= 4)
            {
                Console.Write("\n\nBreathe in...");
                CountdownAnimation(remainingSeconds);
            }
            else
            {
                Console.Write("\n\nBreathe in...");
                CountdownAnimation(4);
                Console.Write("\n\nBreathe out...");
                CountdownAnimation(remainingSeconds - 4);
            }
        }
        
        EndingMessage();
        
    }
}