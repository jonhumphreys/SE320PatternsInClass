namespace NotObserver;

class Program
{
    static void Main(string[] args)
    {
        PodcastPublisher publisher = 
            new PodcastPublisher();
        
        PodcastSubscriber subscriber = 
            new PodcastSubscriber("Hank");
        PodcastSubscriber subscriber2 = 
            new PodcastSubscriber("Frank");
        TwitterNotifier twitterNotifier = new TwitterNotifier();
        EmailNotifier emailNotifier = new EmailNotifier();
        
        publisher.AddSubscriber(subscriber);
        publisher.AddSubscriber(subscriber2);
        publisher.AddSubscriber(twitterNotifier);
        publisher.AddSubscriber(emailNotifier);
        
        publisher.Publish("The Worst Way To Spend Your College Years");
        
        publisher.RemoveSubscriber(subscriber);
        
        publisher.Publish("Things Not To Eat");
    }
}