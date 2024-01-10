using System;

class Program
{
    static void Main(string[] args)
    {
        int gradeNumber = int.Parse(Input("Enter your grade: "));
        string gradeLetter;

        if (gradeNumber >= 90)
        {
            gradeLetter = "A";
        }
        else if (gradeNumber >= 80)
        {
            gradeLetter = "B";
        }
        else if (gradeNumber >= 70)
        {
            gradeLetter = "C";
        }
        else if (gradeNumber >= 60)
        {
            gradeLetter = "D";
        }
        else
        {
            gradeLetter = "F";
        }

        string gradeSign = "";
        if (gradeNumber < 94 && gradeNumber >= 60)
        {
            int gradeSignNumber = gradeNumber % 10;
            if (gradeSignNumber >= 7)
            {
                gradeSign = "+";
            }
            else if (gradeSignNumber < 3)
            {
                gradeSign = "-";
            }
        }

        Console.WriteLine($"Your grade is {gradeLetter}{gradeSign}");

        if (gradeNumber >= 70)
        {
            Console.WriteLine("You passed the class!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }

    }
    static string Input(string text)
    {
        Console.Write($"{text}");
        return Console.ReadLine();
    }
}