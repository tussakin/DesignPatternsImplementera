using ImplementeraTheresDesignPatterns.AdapterPattern;

namespace ImplementeraTheresDesignPatterns
{
    
//Factory method

    public class StripePaymentFactory : PaymentFactory
    {
        public override IPaymentStrategy CreatePaymentStrategy()
        {
            return new StripeAdapter(new StripePayment());

        }
    } 
}