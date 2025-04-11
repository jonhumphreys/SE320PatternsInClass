namespace ObserverOOP;

class Program
{
    public static void Main(string[] args)
    {
        PodcastPublisher publisher =
            new PodcastPublisher();

        PodcastSubscriber subscriber =
            new PodcastSubscriber("Hank");
        PodcastSubscriber subscriber2 =
            new PodcastSubscriber("Frank");
        TwitterNotifier twitterNotifier = new TwitterNotifier();
        EmailNotifier emailNotifier = new EmailNotifier();
        HttpSubscriber httpSubscriber = new HttpSubscriber();

        publisher.AddSubscriber(subscriber);
        publisher.AddSubscriber(subscriber2);
        publisher.AddSubscriber(twitterNotifier);
        publisher.AddSubscriber(emailNotifier);
        publisher.AddSubscriber(httpSubscriber);

        publisher.PublishEpisode("The Worst Way To Spend Your College Years");

        publisher.RemoveSubscriber(subscriber);

        publisher.PublishEpisode("Things Not To Eat");
    }
}