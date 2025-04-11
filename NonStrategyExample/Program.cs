namespace NonStrategyExample;

class Program
{
    static void Main(string[] args)
    {
        PaymentProcessor paymentProcessor = new PaymentProcessor();
        
        paymentProcessor.SetPaymentMethod(PaymentTypes.CreditCard);
        paymentProcessor.ProcessPayment(50);
        
        paymentProcessor.SetPaymentMethod(PaymentTypes.Paypal);
        paymentProcessor.ProcessPayment(100);
    }
}