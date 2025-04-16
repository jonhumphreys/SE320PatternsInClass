namespace StrategyExample;

public class BarterPayment : IPaymentStrategy
{
    public void Pay(int amount)
    {
        Console.WriteLine("Payment executed via barter: " + amount);
    }
}