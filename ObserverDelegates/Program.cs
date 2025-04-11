namespace ObserverDelegates;

class Program
{
    static void Main(string[] args)
    {
        PodcastPublisher publisher = new PodcastPublisher();
        
        publisher.AddListener(SandieListener);
        publisher.AddListener(TwitterListener);
        publisher.AddListener(FlickrListener);
        
        publisher.PublishEpisode("The worst things about being positive.");
        
        publisher.RemoveListener(SandieListener);
        
        publisher.PublishEpisode("Ten things not to put in your mouth.");
    }

    public static void SandieListener(string episodeName)
    {
        Console.WriteLine("SandieListener got: " + episodeName);
    }

    public static void TwitterListener(string episodeName)
    {
        Console.WriteLine("TwitterListener got: " + episodeName);
    }

    public static void FlickrListener(string episodeName)
    {
        Console.WriteLine("FlickrListener got: " + episodeName);
    }
}