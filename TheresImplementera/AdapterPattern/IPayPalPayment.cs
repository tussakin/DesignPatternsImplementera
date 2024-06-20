namespace ImplementeraTheresDesignPatterns.AdapterPattern
{
    
//Adapter 

    public interface IPayPalPayment
    {
        string InitializePayment(decimal amount); 
    }
}