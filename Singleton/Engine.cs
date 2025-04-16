namespace Singleton;

public class Engine
{
    private const float maxRpm = 9000f;
    private float rpm;

    public void SetPercent(float percent)
    {
        rpm = percent * maxRpm;
        UI.Instance.ShowMessage("At " + rpm + " rpm!");
    }
}