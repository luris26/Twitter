public class Person
{
    private readonly string name;
    private readonly string text;
    private readonly Action<Post, Person> reaction;
    public Person(string text, string name, Action<Post, Person> reaction)
    {
        this.name = name;
        this.text = text;
        this.reaction = reaction;
    }
    public Post CreatePost()
    {
        return new Post(text);
    }
    public void React(Post post)
    {
        reaction(post, this);
    }
    public override string ToString()
    {
        return name;
    }
}
