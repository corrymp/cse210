using System.Security.Cryptography.X509Certificates;

class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments;

    public Video(string title, string author, int length, List<Comment> comments)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = comments;
    }

    public string GetDisplay()
    {
        return $"\n\"{_title}\" by {_author} - {_length} Seconds, {GetCommentCount()} Comments";
    }

    public void ListComments()
    {
        foreach (Comment comment in _comments)
        {
            Console.WriteLine(comment.GetDisplay());
        }
    }

    public int GetCommentCount()
    {
        return _comments.Count;
    }
}