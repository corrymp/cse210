class GoalManager
{
    private List<Goal> _goals = new();
    private int _score;

    public void Start()
    {
        string selection;

        do
        {
            selection = Input(MenuText());

            if (selection == "1")
            {
                CreateGoal();
            }

            else if (selection == "2")
            {
                Console.WriteLine("The goals are:");
                ListGoalDetails();
            }

            else if (selection == "3")
            {
                SaveGoals();
            }

            else if (selection == "4")
            {
                LoadGoals();
            }

            else if (selection == "5")
            {
                RecordEvent();
            }

            else if (selection == "6")
            {
                Console.WriteLine("Goodbye!");
            }

            else // Any input that isn't 1, 2, 3, 4, 5, or 6
            {
                Console.WriteLine("idk what that means..?");
            }

        } while (selection != "6");
    }

    public void DisplayPlayerInfo() // The learning materials said to make this - idk why I would't just include it in the menu
    {
        Console.WriteLine($"\n\nYou have {_score} points.");
    }

    public void ListGoalNames()
    {
        if (IsEmptyList(_goals))
        {
            return;
        }

        foreach (Goal goal in _goals) // Otherwise display the goal names
        {
            Console.WriteLine(goal.GetName());
        }
    }

    public void ListGoalDetails()
    {
        if (IsEmptyList(_goals))
        {
            return;
        }

        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    public void CreateGoal()
    {
        int goalType = int.Parse(Input("The types of Goals are:\n  1. Simple Goal\n  2. Eternal Goal\n  3. Checklist Goal\nWhich type of goal would you like to create? "));

        string name = Input("What is the name of your goal? ");
        string desc = Input("What is a short description of it? ");
        int points = int.Parse(Input("What is the amount of points associated with this goal? "));

        if (goalType == 1)
        {
            _goals.Add(new SimpleGoal(name,desc,points));
            return;
        }

        else if (goalType == 2)
        {
            _goals.Add(new EternalGoal(name,desc,points));
            return;
        }

        int target = int.Parse(Input("How many times does this goal need to be accomplished for a bonus? "));
        int bonus = int.Parse(Input("What is the bonus for accomplishing it that many times? "));

        _goals.Add(new ChecklistGoal(name,desc,points,bonus,target));
    }

    public void RecordEvent()
    {
        List<Goal> inProgress = new();

        foreach (Goal goal in _goals)
        {
            if (goal.IsComplete() == false)
            {
                inProgress.Add(goal);
            }
        }

        if (IsEmptyList(inProgress))
        {
            return;
        }

        Console.WriteLine("The goals are:");

        for (int i = 0; i < inProgress.Count; i++)
        {
            Console.WriteLine($"{i+1}. {inProgress[i].GetName()}");
        }

        int selection = int.Parse(Input("Which goal did you accomplish? "));

        if (selection < 1 || selection > inProgress.Count) // Return if the selection is outside the valid range
        {
            Console.WriteLine("Invalid selection");
            return;
        }

        inProgress[selection-1].RecordEvent();
        int points = inProgress[selection-1].GetPoints();
        _score += points;

        Console.WriteLine($"Congradulations! You have earned {points} points!");
    }

    public void SaveGoals()
    {
        string filename = Input("What is the filename for the goal file? ");
        using (StreamWriter outputFile = new(filename))
        {
            outputFile.WriteLine($"score::{_score}");
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    public void LoadGoals()
    {
        string filename = Input("What is the filename for the goal file? ");
        string[] lines = System.IO.File.ReadAllLines(filename);
        _goals.Clear();

        foreach (string line in lines)
        {
            string[] parts = line.Split("::");
            string type = parts[0];
            string[] data = parts[1].Split("],[");
            
            if (type == "1")
            {
                // name 0, description 1, points 2, startTime 3, complete 4, endTime 5
                if (data.Count() == 5)
                {
                    _goals.Add(new SimpleGoal(data[0],data[1],int.Parse(data[2]),DateTime.Parse(data[3]),bool.Parse(data[4])));
                }

                else
                {
                    _goals.Add(new SimpleGoal(data[0],data[1],int.Parse(data[2]),DateTime.Parse(data[3]),bool.Parse(data[4]),DateTime.Parse(data[5])));
                }
            }

            else if (type == "2")
            {
                // name 0, description 1, points 2, startTime 3, timesDone 4
                _goals.Add(new EternalGoal(data[0],data[1],int.Parse(data[2]),DateTime.Parse(data[3]),int.Parse(data[4])));
            }

            else if (type == "3")
            {
                // name 0, description 1, points 2, bonus 3, target 4, complete 5, startTime 6, endTime 7
                if (data.Count() == 6)
                {
                    _goals.Add(new ChecklistGoal(data[0],data[1],int.Parse(data[2]),int.Parse(data[3]),int.Parse(data[4]),int.Parse(data[5]),DateTime.Parse(data[6])));
                }

                else
                {
                    _goals.Add(new ChecklistGoal(data[0],data[1],int.Parse(data[2]),int.Parse(data[3]),int.Parse(data[4]),int.Parse(data[5]),DateTime.Parse(data[6]),DateTime.Parse(data[7])));
                }
            }

            else if (type == "score")
            {
                _score = int.Parse(parts[1]);
            }
            else
            {
                Console.WriteLine($"Error: Unknown goal type in save data ({line}) Skipping.");
            }
        }
    }
    
    private bool IsEmptyList(List<Goal> list)
    {
        if (list.Count < 1)
        {
            Console.WriteLine("You don't have any goals set!");
            return true;
        }

        return false;
    }

    private string MenuText()
    {
        DisplayPlayerInfo();
        return $"\nMenu Options:\n  1. Create New Goal\n  2. List Goals\n  3. Save Goals\n  4. Load Goals\n  5. Record Goals\n  6. Quit\nSelect a choice from the menu: ";
    }

    public static string Input(string text)
    {
        Console.Write($"{text}");
        return Console.ReadLine();
    }
}