class ReflectingActivity : Activity
{
    private List<string> _prompts = new()
    {
    "Think of a time when you stood up for someone else.",
    "Think of a time when you did something really difficult.",
    "Think of a time when you helped someone in need.",
    "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new()
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectingActivity(string name, string description) : base(name, description)
    {
        // This constructor intentionaly left blank
    }

    public void Run()
    {
        DisplayStartingMessage();

        DisplayPrompt();

        Console.Write("Now ponder on each of the following questions as they relate to this experience.\nYou may begin in: ");
        ShowCountDown(5);
        Console.Clear();

        DoForDuration(GetDuration(), DisplayQuestions);

        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        return _prompts[GetRandomNumber(0,_prompts.Count)];
    }

    public string GetRandomQuestion()
    {
        return _questions[GetRandomNumber(0,_questions.Count)];
    }

    public void DisplayPrompt()
    {
        Program.Input($"\nConsider the following prompt:\n\n--- {GetRandomPrompt()} ---\n\nWhen you have something in mind, press enter to continue.\n");
    }

    public void DisplayQuestions()
    {
        Console.Write($"\n> {GetRandomQuestion()} ");
        ShowSpinner(10);
    }
}