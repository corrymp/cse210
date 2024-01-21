using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry _newEntry)
    {
        _entries.Add(_newEntry);
    }
    
    public void DisplayAll()
    {
        foreach (Entry _entry in _entries)
        {
            _entry.Display();
        }
    }

    public void Save(string _filename)
    {
        using (StreamWriter _outputFile = new StreamWriter(_filename))
        {
            foreach (Entry _entry in _entries)
            {
                _outputFile.WriteLine($"{_entry._promptText}][{_entry._entryText}][{_entry._date}");
            }
        }
    }

    public void Load(string _file)
    {   
        try
        {
            string[] _lines = System.IO.File.ReadAllLines(_file);
            foreach (string _line in _lines)
            {
                string[] _parts = _line.Split("][");

                Entry _newEntry = new Entry();
                _newEntry._promptText = _parts[0];
                _newEntry._entryText = _parts[1];
                _newEntry._date = _parts[2];

                AddEntry(_newEntry);
            }
        }

        /*https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/exceptions/exception-handling*/
        catch (FileNotFoundException)
        {
            Console.WriteLine("\nERROR: There was an issue loading your journal. Please check the file name and try again.");
        }
    }

    public void Search(string _searchType, string _searchTerm, List<string> _prompts)
    {
        if (_searchType == "1" || _searchType == "Date")
        {
            foreach (Entry _entry in _entries)
            {
                if (_searchTerm == _entry._date)
                {
                    _entry.Display();
                }
            }
        }

        else if (_searchType == "2" || _searchType == "Prompt")
        {
            int _promptIndex = int.Parse(_searchTerm);
            string _searchTarget = _prompts[_promptIndex-1];
            
            foreach (Entry _entry in _entries)
            {
                if (_entry._promptText == _searchTarget)
                {
                    _entry.Display();
                }
            }
        }
    }
}