using System;
using ImplementeraTheresDesignPatterns;

//Jag har använt mig av mönstren adapter, factory method och strategy

class Program
{
    static void Main(string[] args)
    {
         
        Console.WriteLine("Select method of payment:");
        Console.WriteLine("1. Card");
        Console.WriteLine("2. Klarna");
        Console.WriteLine("3. PayPal");
        Console.WriteLine("4. Stripe");
        Console.Write("Enter your choice: ");
        string choice = Console.ReadLine();
        
        PaymentFactory paymentFactory = choice switch
        {
            "1" => new CardPaymentFactory(),
            "2" => new KlarnaPaymentFactory(),
            "3" => new PayPalPaymentFactory(),
            "4" => new StripePaymentFactory(),
            _ => throw new ArgumentException("Please choose a valid number")
        };

        IPaymentStrategy paymentStrategy = paymentFactory.CreatePaymentStrategy();
        Console.WriteLine("Please enter the amount to pay");
        decimal amount = decimal.Parse(Console.ReadLine());
        paymentStrategy.InitializePayment(amount);
        
    }
}