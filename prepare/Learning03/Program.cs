using System;

class Program
{
    static void Main(string[] args)
    {
        int topNumber;
        int bottomNumber;

        Fraction fraction1 = new Fraction();
        Console.WriteLine(fraction1.GetFractionString());
        Console.WriteLine(fraction1.GetDecimalValue());

        Fraction fraction2 = new Fraction(5);
        Console.WriteLine(fraction2.GetFractionString());
        Console.WriteLine(fraction2.GetDecimalValue());

        do
        {
            topNumber = int.Parse(Input("Please enter the top number, or 0 to quit: "));
            if (topNumber == 0)
            {
                break;
            }
            bottomNumber = int.Parse(Input("Please enter the bottom number: "));

            Fraction fraction3 = new Fraction(topNumber,bottomNumber);
            Console.WriteLine(fraction3.GetFractionString());
            
            double result = fraction3.GetDecimalValue();
            Console.WriteLine(result);

        } while (topNumber != 0);
    }
    static string Input(string text)
    {
        Console.Write($"{text}");
        return Console.ReadLine();
    }
}