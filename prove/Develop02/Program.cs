/*
Exceeds Expectations:
- Allows either the number or the label for menu selection
- Has an option to cancel an entry by typing 'CANCEL'
- Gives warnings when user may lose data
- Search entries by date or prompt
- Handles incorrect file names and missing files
- Maybe other stuff, my attention span is gone
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        bool saved = true;
        string choice;
        string searchType;
        string searchTerm = "";

        Journal journal = new Journal();
        PromptGenerator prompter = new PromptGenerator();

        Console.WriteLine("Welcome to the Journal Program!");

        do
        {
            choice = Input("\nPlease select one of the following choices:\n1. Write\n2. Display\n3. Load\n4. Save\n5. Search\n6. Quit\nWhat would you like to do? ");
            
            if (choice == "1" || choice == "Write")
            {
                Entry newEntry = new Entry();

                DateTime currentDate = DateTime.Now;
                newEntry._date = currentDate.ToShortDateString();

                newEntry._promptText = prompter.GetRandomPrompt();

                newEntry._entryText = Input($"\nDate: {newEntry._date}\nPrompt: {newEntry._promptText}\nType CANCEL to remove this entry.\n> ");

                if (newEntry._entryText != "CANCEL")
                {
                    journal.AddEntry(newEntry);
                    saved = false;
                }
            }

            else if (choice == "2" || choice == "Display")
            {
                journal.DisplayAll();
            }

            else if (choice == "3" || choice == "Load")
            {
                SaveCheck(journal,saved,"\nWARNING: This will delete your all unsaved journal entries.\nWould you like to save? (Yes/No)\n");

                journal = new Journal();
                journal.Load(Input("What is the filename?\n"));

                saved = true;
            }

            else if (choice == "4" || choice == "Save")
            {
                Save(journal);
                saved = true;
            }

            else if (choice == "5" || choice == "Search")
            {
                searchType = Input("What would you like to search for?\n1. Date\n2. Prompt\n ");

                if (searchType == "1" || searchType == "Date")
                {
                    searchTerm = Input("Please enter the desired date in the following format: m/d/yyyy");
                }

                else if (searchType == "2" || searchType == "Prompt")
                {
                    int i = 0;
                    Console.WriteLine("Please select from the following prompts:");

                    foreach (string prompt in prompter._prompts)
                        {
                            i ++;
                            Console.WriteLine($"{i}. {prompt}");
                        }

                    searchTerm = Console.ReadLine();
                }

                journal.Search(searchType,searchTerm,prompter._prompts);
            }

            else if (choice == "6" || choice == "Quit")
            {
                SaveCheck(journal,saved,"\nWARNING: You have unsaved entries!\nAll unsaved work will be lost.\nWould you like to save? (Yes/No)\n");
                Console.WriteLine("\nGoodbye.");
            }

            else
            {
                Console.WriteLine("\nInvalid input");
            }

        } while (choice != "6" && choice != "Quit");
    }

    static void SaveCheck(Journal journal, bool saved, string message)
    {
        if (saved == false)
        {
            string saveAll = Input(message);

            if (saveAll == "Yes")
            {
                Save(journal);
            }
        }
    }

    static void Save(Journal journal)
    {
        journal.Save(Input("What is the file name?\n"));
        Console.WriteLine("\nJournal saved.");
    }

    static string Input(string text)
    {
        Console.Write($"{text}");
        return Console.ReadLine();
    }
}