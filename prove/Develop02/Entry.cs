public class Entry
{
    public string _promptText;
    public string _entryText;
    public string _date;

    public void Display()
    {
        Console.WriteLine($"\nDate: {_date} - Prompt: {_promptText}\n{_entryText}");
    }
}