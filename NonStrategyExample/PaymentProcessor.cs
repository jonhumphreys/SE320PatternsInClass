namespace NonStrategyExample;

public class PaymentProcessor
{
    private PaymentTypes method;

    public void SetPaymentMethod(PaymentTypes method)
    {
        this.method = method;
    }

    public void ProcessPayment(int amount)
    {
        if (method == PaymentTypes.CreditCard)
        {
            Console.WriteLine("Paid $" + amount + " using credit card");
        }
        else if (method == PaymentTypes.Paypal)
        {
            Console.WriteLine("Paid $" + amount + " using pay pal");
        }
        else
        {
            Console.WriteLine("Unknown method");
        }
    }
}