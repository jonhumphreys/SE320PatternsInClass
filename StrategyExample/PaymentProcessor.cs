namespace StrategyExample;

public class PaymentProcessor
{
    private IPaymentStrategy paymentStrategy;
    
    public void SetPaymentMethod(IPaymentStrategy strategy)
    {
        paymentStrategy = strategy;
    }

    public void ProcessPayment(int amount)
    {
        paymentStrategy.Pay(amount);
    }
}