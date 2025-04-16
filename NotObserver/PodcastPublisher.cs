namespace NotObserver;

public class PodcastPublisher
{
    private List<object> subscribers = 
        new List<object>();

    public void AddSubscriber(object subscriber)
    {
        subscribers.Add(subscriber);
    }

    public void RemoveSubscriber(object subscriber)
    {
        subscribers.Remove(subscriber);
    }

    public void Publish(string episodeName)
    {
        foreach (object subscriber in subscribers)
        {
            if (subscriber.GetType() == typeof(PodcastSubscriber))
            {
                PodcastSubscriber podcastSubscriber = (PodcastSubscriber)subscriber;
                podcastSubscriber.OnEpisodeReceived(episodeName);
            }
            else if (subscriber.GetType() == typeof(TwitterNotifier))
            {
                TwitterNotifier tweeter = (TwitterNotifier)subscriber;
                tweeter.TweetEpisode(episodeName);
            }
            else if (subscriber.GetType() == typeof(EmailNotifier))
            {
                EmailNotifier emailer = (EmailNotifier)subscriber;
                emailer.SendEmailNotification(episodeName);
            }
        }
    }
}