namespace NoSingleton;

class Program
{
    static void Main(string[] args)
    {
        // create a UI
        UI ui = new UI();
        
        // print a message using the UI
        ui.ShowMessage("Hey Arnold");
        
        Engine engine = new Engine();
        engine.SetPercent(ui,0.5f);
    }
}