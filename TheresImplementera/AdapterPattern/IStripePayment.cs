namespace ImplementeraTheresDesignPatterns.AdapterPattern
{
    
//Adapter 

    public interface IStripePayment
    {
        string ProcessPayment(decimal amount); 
    }
}