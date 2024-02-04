class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description) : base(name, description)
    {
        // This constructor intentionaly left blank
    }

    public void Run()
    {
        DisplayStartingMessage();

        DoForDuration(GetDuration(), DisplayBreathingText);

        DisplayEndingMessage();
    }

    public void DisplayBreathingText()
    {
        Console.Write("\n\nBreath in...");
        ShowCountDown(GetRandomNumber(3,6));
        
        Console.Write("\nNow breath out...");
        ShowCountDown(GetRandomNumber(3,6));
    }
}