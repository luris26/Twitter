public class Post
{
    private Dictionary<Person, Reaction> reactions {get;}
    public string Text { get; }
    public Post(string text)
    {
        if (text.Length > 250)
        {
            throw new ArgumentOutOfRangeException(" Too many characters");
        }
        Text = text;
    }
    public void StoreReaction(Person person,Reaction reaction)
    {
        reactions[person] = reaction;
        throw new NotImplementedException();
    }
    public Dictionary<Person, Reaction> GetReaction()
    {
        var newDictionary = reactions.ToDictionary(entry => entry.Key, entry => entry.Value);
        return reactions;
    }
}