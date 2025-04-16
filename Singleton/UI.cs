namespace Singleton;

public class UI
{
    private static UI instance;

    private UI() { }
    
    public static UI Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new UI();
            }
            return instance;
        }
    }
    
    public void ShowMessage(string message)
    {
        Console.WriteLine(message);
    }
}