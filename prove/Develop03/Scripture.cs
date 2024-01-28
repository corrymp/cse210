class Scripture
{
    private Reference _reference;
    private List<Word> _words = new();
    private Random random = new();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        string[] words = text.Split(" ");

        foreach (string word in words)
        {
            Word newWord = new(word);
            _words.Add(newWord);
        }
    }
    
    public void HideRandomWord(int numberToHide)
    {
        while (numberToHide > 0)
        {
            numberToHide --;
            List<Word> nonHiddenWords = new();

            foreach (Word word in _words)
            {
                if (word.IsHidden() == false)
                {
                    nonHiddenWords.Add(word);
                }
            }
            
            if (nonHiddenWords.Count > 0)
            {
                nonHiddenWords[random.Next(0,nonHiddenWords.Count)].Hide();
            }
        }
    }

    public string GetDisplayText()
    {
        string text = "";

        foreach (Word word in _words)
        {
            text = text + word.GetDisplayText() + " ";
        }

        return $"{_reference.GetDisplayText()} {text}";
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (word.IsHidden() == false)
            {
                return false;
            }
        }

        return true;
    }
}