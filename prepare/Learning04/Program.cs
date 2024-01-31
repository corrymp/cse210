using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new("Corry","Geometry");
        MathAssignment assignment2 = new("McConnell","Math","3.5","8-11");
        WritingAssignment assignment3 = new("Palmer","Writing","The Silmarillion by J. R. R. Tolkien");

        Console.WriteLine(assignment1.GetSummary());
        Console.WriteLine(assignment2.GetSummary());
        Console.WriteLine(assignment2.GetHomeworkList());
        Console.WriteLine(assignment3.GetSummary());
        Console.WriteLine(assignment3.GetWritingInformation());
    }
}