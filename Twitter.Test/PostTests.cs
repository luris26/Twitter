namespace Twitter.Test;

public class Tests
{
    [Test]
    public void CanCreateValidPost()
    {
        var text = "this is a valid post";
        var validPost = new Post(text);
        Assert.AreEqual(text, validPost.Text);

    }
    [Test]
    public void LargePostTrowError()
    {
        var text = "this is a valid post";
        TestDelegate createPost = () => new Post(text);
        Assert.Throws<ArgumentOutOfRangeException>(createPost);

    }
    [Test]
    public void PostStoreReaction()
    {
        var text = "this is a valid post";
        var post = new Post(text);
        Action react = (Post p, Person j) => { };

        var person = new Person(text, react);
        post.StoreReaction(person, Reaction.like);

        var reactions = post.GetReaction();
        Assert.AreEqual(reactions[person] = Reaction.Like);
    }
}