
public class Comment
{
    public string CommenterName { get; set; }
    public string CommentText { get; set; }

    public Comment(string commenterName, string commentText)
    {
        CommenterName = commenterName;
        CommentText = commentText;
    }
}

// public class Comment
// {
//     public string _commenterName {get; set;}
//     public string _commentText {get; set;}

//     public Comment(string commenterName, string commentText)
//     {
//         _commenterName = commenterName;
//         _commentText = commentText;
//     }
// }
