
public class Video
{
    public string _title;
    public string _author;
    public int _length;
    public List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public void AddComment(string commenterName, string commentText)
    {
        _comments.Add(new Comment(commenterName, commentText));
    }

    public int GetCommentCount()
    {
        return _comments.Count;
    }
}

// public class Video
// {
//     public string _title 
//     public string _author
//     public int _length
//     public List<Comment> _comments = new List<Comment>();

//     public Video(string title, string author, int length)
//     {
//         _title = title
//         _author = author
//         _length = length
//     }
//     public void AddComments(string author, string text)
//     {
//         _comments.Add(new Comment(author, text));
//     }
//     public int GetCommentCount()
//     {
//         return _comments.Count;
//     }

// }


