namespace ImplementeraTheresDesignPatterns.AdapterPattern
{    
    //Adapter 

    public class PayPalPayment : IPayPalPayment
    {
        public string InitializePayment(decimal amount)
        {
            return $"Paid {amount:C} with PayPal";
        }
    }
} 