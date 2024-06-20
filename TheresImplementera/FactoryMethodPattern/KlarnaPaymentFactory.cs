using ImplementeraTheresDesignPatterns.AdapterPattern;

namespace ImplementeraTheresDesignPatterns;

//Factory method

public class KlarnaPaymentFactory : PaymentFactory
{
    public override IPaymentStrategy CreatePaymentStrategy()
    {
        return new KlarnaAdapter(new KlarnaPayment());
    } 
}