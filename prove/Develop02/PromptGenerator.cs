using System;

public class PromptGenerator
{
    /*https://www.quora.com/In-C-whats-the-best-way-to-create-and-initialize-a-List-in-one-line*/
    public List<string> _prompts = new List<string>()
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "If your day was a story in a book, what would the title be?",
        "What would you tell you from a year ago about today?",
        "Count your blessings and name them one-by-one.",
        "How would you rate your day on a scale of 1-7?",
        "What are you going to improve tomorow?",
        "Are you tired? Why or why not?",
        "*DID* you think to pray?"
    };
    public Random randomNumberGenerator = new Random();

    public string GetRandomPrompt()
    {
        /*https://stackoverflow.com/questions/2019417/how-to-access-random-item-in-list*/
        int randomNumber = randomNumberGenerator.Next(0,_prompts.Count());
        return _prompts[randomNumber];
    }
}