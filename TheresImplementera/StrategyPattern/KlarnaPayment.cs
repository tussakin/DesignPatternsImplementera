using ImplementeraTheresDesignPatterns.AdapterPattern;

namespace ImplementeraTheresDesignPatterns;

//Strategy

public class KlarnaPayment : IKlarnaPayment
{
    public string InitializePayment(decimal amount)
    {
        return $"Initializing payment of {amount:C} with klarna";
    }
} 