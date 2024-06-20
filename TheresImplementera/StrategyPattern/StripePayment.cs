using ImplementeraTheresDesignPatterns.AdapterPattern;

namespace ImplementeraTheresDesignPatterns;

//Strategy

public class StripePayment : IStripePayment
{
    public string ProcessPayment(decimal amount)
    {
        return $"Initializing payment of {amount:C} with stripe";
    }
} 