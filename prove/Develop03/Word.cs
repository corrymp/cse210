class Word
{
    private string _text;
    private bool _isHidden = false;

    public Word(string text)
    {
        _text = text;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }

    public bool IsHidden()
    {
        if (_isHidden == true)
        {
            return true;
        }

        return false;
    }

    public string GetDisplayText()
    {
        if (_isHidden == true)
        {
            string result = "";

            foreach (char letter in _text)
            {
                result += "_";
            }

            return result;
        }

        return _text;
    }
}