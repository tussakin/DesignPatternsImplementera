namespace ImplementeraTheresDesignPatterns;

//Factory method
public class CardPaymentFactory : PaymentFactory
{
    public override IPaymentStrategy CreatePaymentStrategy()
    {
        return new CardPayment();
    }
} 