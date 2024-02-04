class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity(string name, string description) : base(name, description)
    {
        // This constructor intentionaly left blank
    }

    public void Run()
    {
        _count = 0;
        
        DisplayStartingMessage();
        
        Console.Write($"\nList as many responses you can to the following prompt:\n --- {GetRandomPrompt()} ---\nYou may begin in: ");
        ShowCountDown(5);

        Console.Write("\n");
        DoForDuration(GetDuration(),GetListFromUser);
        Console.Write($"You listed {_count} items!");

        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        return _prompts[GetRandomNumber(0,_prompts.Count)];
    }

    public void GetListFromUser()
    {
        Program.Input("> ");
        _count ++;
    }
}