namespace ObserverOOP;

public class HttpSubscriber : IEpisodeListener
{
    public HttpSubscriber()
    {
    }
    
    public void OnEpisodePublished(string episodeName)
    {
        Console.WriteLine($"OnEpisodePublished - webbed: {episodeName}");
    }
}