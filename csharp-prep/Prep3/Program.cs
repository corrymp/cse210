using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1,101);
        int guessNumber;
        int guessCount = 0;
        bool playAgain = true;

        do {
            guessNumber = int.Parse(Input("What is your guess? "));
            guessCount += 1;

            if (guessNumber > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (guessNumber < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine($"You guessed it!\nIt took {guessCount} guesses.");
                string playAgainString = Input("Play again? yes/no ");

                if (playAgainString == "yes")
                {
                    playAgain = true;
                    magicNumber = randomGenerator.Next(1,11);
                    guessCount = 0;
                }
                else
                {
                    playAgain = false;
                    Console.WriteLine("Come back soon!");
                }
            }
        } while (guessNumber != magicNumber && playAgain);
    }
    static string Input(string text)
    {
        Console.Write($"{text}");
        return Console.ReadLine();
    }
}