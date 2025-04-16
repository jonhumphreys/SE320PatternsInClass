namespace ObserverOOP;

public class TwitterNotifier : IEpisodeListener
{   

    public TwitterNotifier()
    {
    }
    
    public void OnEpisodePublished(string episodeName)
    {
        Console.WriteLine($"OnEpisodePublished - tweeted: {episodeName}");
    }
}