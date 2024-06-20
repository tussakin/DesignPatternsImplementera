namespace ImplementeraTheresDesignPatterns.AdapterPattern
{    
    //Adapter 

    public class StripeAdapter : IPaymentStrategy
    {
        private readonly IStripePayment _stripePayment;

        public StripeAdapter(IStripePayment stripePayment)
        {
            _stripePayment = stripePayment;
        }

        public void InitializePayment(decimal amount)
        {
            Console.WriteLine(_stripePayment.ProcessPayment(amount));
        }
    }
} 