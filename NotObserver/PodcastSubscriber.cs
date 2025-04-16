namespace NotObserver;

public class PodcastSubscriber
{
    private string name;

    public PodcastSubscriber(string name)
    {
        this.name = name;
    }

    public void OnEpisodeReceived(string episodeName)
    {
        Console.WriteLine($"{name} received episode: {episodeName}");
    }
}