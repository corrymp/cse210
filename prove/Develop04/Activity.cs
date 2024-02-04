class Activity
{
    // Attributes
    private string _name;
    private string _description;
    private int _duration;
    private Random _random = new();
    private int _spinnerRotation = 0;
    private List<char> _spinner = new()
    {
        '\\',
        '|',
        '/',
        '-'
    };


    // Constructor
    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }
    

    // Setters and Getters
    public void SetDuration(int duration)
    {
        _duration = duration;
    }
    public int GetDuration()
    {
        return _duration;
    }

    public void SetName(string name)
    {
        _name = name;
    }
    public string GetName()
    {
        return _name;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }
    public string GetDescription()
    {
        return _description;
    }


    // Methods
    public void DisplayStartingMessage()
    {
        Console.Clear();

        Console.WriteLine($"Welcome to the {_name}.\n\n{_description}\n");
        _duration = int.Parse(Program.Input("How long, in seconds, would you like for your session? "));
        Console.Clear();

        Console.WriteLine("\nGet ready...");
        ShowSpinner(5);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("\n\nWell done!!");
        ShowSpinner(5);

        Console.WriteLine($"\nYou have completed another {_duration} seconds of the {_name}.");
        ShowSpinner(5);
    }

    public void ShowSpinner(int seconds)
    {
        DoForDuration(seconds,SpinnerAnimation);
    }

    public void SpinnerAnimation()
    {
        _spinnerRotation ++;

        if (_spinnerRotation >= _spinner.Count)
        {
            _spinnerRotation = 0;
        }

        Console.Write(_spinner[_spinnerRotation]);
        Thread.Sleep(500);
        Console.Write("\b \b");
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
    
    public void DoForDuration(int duration, Action function) // https://stackoverflow.com/questions/3622160/c-sharp-passing-function-as-argument
    {
        DateTime futureTime = DateTime.Now.AddSeconds(duration);
        DateTime currentTime;
        do
        {
            currentTime = DateTime.Now;
            if (currentTime < futureTime)
            {
                function();
            }
        } while (currentTime < futureTime);
    }

    public int GetRandomNumber(int x, int y)
    {
        return _random.Next(x,y);
    }
}