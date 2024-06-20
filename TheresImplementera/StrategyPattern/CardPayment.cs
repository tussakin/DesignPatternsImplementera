namespace ImplementeraTheresDesignPatterns;

//Strategy

public class CardPayment : IPaymentStrategy
{
    public void InitializePayment(decimal amount)
    {
        Console.WriteLine($"Initializing payment of {amount:C} with card");
    }
} 