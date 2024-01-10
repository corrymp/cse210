using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        DisplayResult(name, number);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        return Input("Please enter your name: ");
    }

    static int PromptUserNumber()
    {
        return int.Parse(Input("Please enter your favorite number: "));
    }

    static int SquareNumber(int number)
    {
        return number * number;
    }

    static void DisplayResult(string name, int number)
    {
        Console.Write($"{name}, the square of your number is {SquareNumber(number)}");
    }

    static string Input(string text)
    {
        Console.Write($"{text}");
        return Console.ReadLine();
    }
}