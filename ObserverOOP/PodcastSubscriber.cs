namespace ObserverOOP;

public class PodcastSubscriber : IEpisodeListener
{
    private string name;

    public PodcastSubscriber(string name)
    {
        this.name = name;
    }
    
    public void OnEpisodePublished(string episodeName)
    {
        Console.WriteLine($"{name} - OnEpisodePublished: {episodeName}");
    }
}