using ImplementeraTheresDesignPatterns.AdapterPattern;

namespace ImplementeraTheresDesignPatterns
{
//Factory method

    public class PayPalPaymentFactory : PaymentFactory
    {
        public override IPaymentStrategy CreatePaymentStrategy()
        {
            return new PayPalAdapter(new PaypalPayment());
        }
    }
} 