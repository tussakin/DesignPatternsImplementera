namespace ImplementeraTheresDesignPatterns.AdapterPattern;

//Adapter 

public class KlarnaPayment : IKlarnaPayment
{
    public string InitializePayment(decimal amount)
    {
        return $"Paid {amount} with klarna"; 
    }
}