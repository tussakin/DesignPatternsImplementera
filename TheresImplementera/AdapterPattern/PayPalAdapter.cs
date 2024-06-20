namespace ImplementeraTheresDesignPatterns.AdapterPattern
{
    
    //Adapter 
    
    public class PayPalAdapter : IPaymentStrategy
    {
        private readonly IPayPalPayment _payPalPayment;

        public PayPalAdapter(IPayPalPayment payPalPayment)
        {
            _payPalPayment = payPalPayment;
        }

        public void InitializePayment(decimal amount)
        {
            Console.WriteLine(_payPalPayment.InitializePayment(amount));
        }
    }
} 