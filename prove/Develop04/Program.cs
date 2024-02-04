// exceed requirements: The program tracks how many times each activity is done and displays it each time the menu is accessed. It displays it once more when quitting the program, along with the total.

using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> timesDone = new() {0,0,0};
        BreathingActivity breathingActivity = new("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
        ListingActivity listingActivity = new("Listing Activity","This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        ReflectingActivity reflectingActivity = new("Reflection Activity","This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        string selection;

        do
        {
            selection = DisplayMenu(timesDone);

            if (selection == "1")
            {
                breathingActivity.Run();
                timesDone[0] ++;
            }
            else if (selection == "2")
            {
                reflectingActivity.Run();
                timesDone[1] ++;
            }
            else if (selection == "3")
            {
                listingActivity.Run();
                timesDone[2] ++;
            }
            else if (selection == "4")
            {
                Console.WriteLine($"Goodbye\nThis is what you did this session:\n- Breathing: {timesDone[0]}\n- Listing: {timesDone[1]}\n- Reflection: {timesDone[2]}\nTotal: {timesDone[0]+timesDone[1]+timesDone[2]}");
            }
            else
            {
                Console.WriteLine("huh?\n");
                Thread.Sleep(3000);
            }
        } while (selection != "4");
        
    }

    static string DisplayMenu(List<int> timesDone)
    {
        Console.Clear();
        Console.WriteLine($"Menu Options:\n  1. Start breathing activity (done {timesDone[0]} times)\n  2. Start reflecting activity (done {timesDone[1]} times)\n  3. Start listing activity (done {timesDone[2]} times)\n  4. Quit");
        return Input("Select a choice from the menu: ");
    }
    
    public static string Input(string text)
    {
        Console.Write($"{text}");
        return Console.ReadLine();
    }
}