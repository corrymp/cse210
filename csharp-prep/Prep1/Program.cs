using System;

class Program
{
    static void Main(string[] args)
    {
        string firstName = Input("What is your first name? ");
        string lastName = Input("What is your last name? ");
        Console.WriteLine($"\nYour name is {lastName}, {firstName} {lastName}.");
    }
    static string Input(string text)
    {
        Console.Write($"{text}");
        return Console.ReadLine();
    }
}