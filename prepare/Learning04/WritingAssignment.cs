class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment(string studentName, string topic, string title) : base(studentName, title)
    {
        _title = title;
    }

    public string GetWritingInformation()
    {
        return $"{_title}";
    }
}