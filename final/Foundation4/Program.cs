using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new()
        {
            new RunningActivity("03 Nov 2022",60,10),
            new CyclingActivity("03 Nov 2022",60,10),
            new SwimmingActivity("03 Nov 2022",60,200)
        };

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}