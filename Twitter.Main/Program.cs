using System.Linq;

Action <Post, Person> likeReaction = (Post p, Person me ) => p.StoreReaction(me, Reaction.like);
var bob = new Person ("bob", "bob's post", likeReaction);

bobsPost = bob.CreatePost();

bob.React(bobPost);

var bobPostReactions = bobPost.GetReaction();

//foreach(var (person, reaction) in bobsPostReactions)
//{
//Console.WriteLine($"Person: {person}, Reaction: {reaction}");
//}

static IEnumerable<K> Map<T, K>(IEnumerable<T> array, Func<T,K> func)
{
    IEnumerable<K> output = new List<K>();
    foreach(var item in array)
    {
        var transformedItem = func(item);
        output = output.Append(transformedItem);
    }
    return output;
}
Func<KeyValuePair<Person, Reaction>, string> PrintAndToStringDictionary = (r) =>
{
    var message = $"Person: {r.Key}, Reaction: {r.Value}";
    Console.WriteLine(message);
    return message;
};
// var outputList = bobsPostsReactions.Select(printAndToStringDictionary);
var outputList = Map(bobsPostReactions, PrintAndToStringDictionary);
