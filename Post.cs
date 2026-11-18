public class Post
{
    public string Title = "";
    public string Description = "";
    public int LikeCount;
    public List<string> Comments = new List<string>();
    public bool IsPublished;

    public void Publish()
    {
        Console.WriteLine("The post is published.");
        IsPublished = true;
    }

    public void Like()
    {
        LikeCount = LikeCount + 1;
    }

    public void Comment(string message)
    {
        Comments.Add(message);
    }
}