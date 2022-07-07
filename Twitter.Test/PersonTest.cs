namespace Twitter.Test;
public class PersonTest
{
    [Test]
    public void CanCreatePerson()
    {
        var text = "this is a post";
        Action<Post, Person> react = (Post p, Person me) => { };
        var person = new Person("testperson", text, react);
        Assert.NotNull(person);
    }
    [Test]
    public void PersonCanCreatePost()
    {
        var text = "this is a post";
        Action react = () => { };
        var person = new Person (text, react);
        var personPost = person.CreatePost();
        Assert.AreEqual(text, personPost.Text);
    }
    [Test]
    public void PersonCanReactToPost()
    {
        var text ="this is a post";
        Action<Post, Person> react = (Post p, Person me ) => p.StoreReaction(me, Reaction.like);
        var person = new Person("testperson", text, react);
        var post = new Post(text);

        person.React(post);
        var postReactions = post.GetReaction();
        Assert.AreEqual(Reaction.like, postReactions[person]);
    }

}
