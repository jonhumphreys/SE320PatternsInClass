namespace ObserverDelegates;

public class PodcastPublisher
{ 
    private List<Action<string>> episodeListeners = 
        new List<Action<string>>();

    public void AddListener(Action<string> listener)
    {
        episodeListeners.Add(listener);
    }

    public void RemoveListener(Action<string> listener)
    {
        episodeListeners.Remove(listener);
    }

    public void PublishEpisode(string episodeTitle)
    {
        Console.WriteLine("Publishing Episode: " + episodeTitle);
        foreach (Action<string> listener in episodeListeners)
        {
            listener(episodeTitle);
        }
    }
}