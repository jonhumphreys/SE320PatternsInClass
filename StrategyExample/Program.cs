namespace StrategyExample;

class Program
{
    static void Main(string[] args)
    {
        PaymentProcessor paymentProcessor = new PaymentProcessor();
        
        paymentProcessor.SetPaymentMethod(new CreditCardPayment());
        paymentProcessor.ProcessPayment(50);
        
        paymentProcessor.SetPaymentMethod(new PayPalPayment());
        paymentProcessor.ProcessPayment(100);
        
        paymentProcessor.SetPaymentMethod(new BarterPayment());
        paymentProcessor.ProcessPayment(10000);
    }
}