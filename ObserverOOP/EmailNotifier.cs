namespace ObserverOOP;

public class EmailNotifier : IEpisodeListener
{
    public EmailNotifier()
    {
    }
    
    public void OnEpisodePublished(string episodeName)
    {
        Console.WriteLine($"OnEpisodePublished - emailed: {episodeName}");
    }
}