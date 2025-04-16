namespace ObserverOOP;

public class PodcastPublisher
{
    private List<IEpisodeListener> subscribers = 
        new List<IEpisodeListener>();

    public void AddSubscriber(IEpisodeListener subscriber)
    {
        subscribers.Add(subscriber);
    }

    public void RemoveSubscriber(IEpisodeListener subscriber)
    {
        subscribers.Remove(subscriber);
    }

    public void PublishEpisode(string episodeName)
    {
        foreach (IEpisodeListener subscriber in subscribers)
        {
            subscriber.OnEpisodePublished(episodeName);
        }
    }
}