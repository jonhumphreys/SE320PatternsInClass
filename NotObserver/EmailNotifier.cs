namespace NotObserver;

public class EmailNotifier
{
    public void SendEmailNotification(string message)
    {
        Console.WriteLine("Emailing: " + message);
    }
}