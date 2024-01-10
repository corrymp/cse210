using System;
using System.Collections.Generic;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<float> numbers = new List<float>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        float newNumber = 0;

        do
        {
            newNumber = float.Parse(Input("Enter number: "));
            
            if (newNumber != 0)
            {
                numbers.Add(newNumber);
            }
        } while (newNumber != 0);

        float numbersSum = 0;
        float numbersAvrg = 0;
        float numbersLargest = 0;
        float numbersSmallest = -1;

        foreach (float number in numbers)
        {
            numbersSum += number;
            numbersAvrg = numbersSum / numbers.Count();

            if (number > numbersLargest)
            {
                numbersLargest = number;
            }

            if (number > 0 && (number < numbersSmallest || numbersSmallest == -1))
            {
                numbersSmallest = number;
            }
        }

        numbers = numbers.OrderBy(f => f).ToList();

        Console.WriteLine($"The sum is: {numbersSum}\nThe average is: {numbersAvrg}\nThe largest is: {numbersLargest}\nThe smallest positive number is: {numbersSmallest}\nThe sorted list is:");

        foreach (float number in numbers)
        {
            Console.WriteLine(number);
        }
    }
    static string Input(string text)
    {
        Console.Write($"{text}");
        return Console.ReadLine();
    }
}