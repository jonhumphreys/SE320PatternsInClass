namespace StrategyExample;

public class CreditCardPayment : IPaymentStrategy
{
    public void Pay(int amount)
    {
        Console.WriteLine($"CreditCard payment for {amount}.");
    }
}