namespace StrategyExample;

public class PayPalPayment : IPaymentStrategy
{
    public void Pay(int amount)
    {
        Console.WriteLine($"Paying {amount} via PayPal");
    }
}