namespace ImplementeraTheresDesignPatterns;

//Factory method

public abstract class PaymentFactory
{
    public abstract IPaymentStrategy CreatePaymentStrategy();
} 