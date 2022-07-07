public class Feed
{
    public IEnumerable<Post> Posts {get; set;}
    public event Action<Post>? NewPost;
}