namespace ImplementeraTheresDesignPatterns.AdapterPattern;

//Adapter 

public class KlarnaAdapter : IPaymentStrategy 
{
    private readonly IKlarnaPayment _klarnaPayment;
    public KlarnaAdapter(IKlarnaPayment klarnaPayment)
    {
        _klarnaPayment = klarnaPayment;
    }

    public void InitializePayment(decimal amount)
    {
        Console.WriteLine(_klarnaPayment.InitializePayment(amount));
    }
}