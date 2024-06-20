namespace ImplementeraTheresDesignPatterns.AdapterPattern
{    
    //Adapter 

    public class StripePayment : IStripePayment
    {
        public string ProcessPayment(decimal amount)
        {
            return $"Paid {amount:C} with Stripe";
        }
    }
} 