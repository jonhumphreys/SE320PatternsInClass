namespace NoSingleton;

public class Engine
{
    private const float maxRpm = 9000f;
    private float rpm;

    public void SetPercent(UI ui, float percent)
    {
        rpm = percent * maxRpm;
        ui.ShowMessage("At " + rpm + " rpm!");
    }
}