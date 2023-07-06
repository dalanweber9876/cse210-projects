public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments = new List<Comment>();
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public int NumberOfComments()
    {
        int count = 0;
        foreach (Comment comment in _comments)
        {
            count +=1;
        }
        return count;
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public List<Comment> GetComments()
    {
        return _comments;
    }
    

    public string GetVideoInfo()
    {
        return $"\"{_title}\" by {_author}: {_length} seconds";
    }
}