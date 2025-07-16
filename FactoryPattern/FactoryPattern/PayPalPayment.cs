namespace FactoryPattern;

public class PayPalPayment : IPayment
{
    public void Pay(double amount)
    {
        Console.WriteLine($"Successfully paid ${amount} to merchant using PayPal");
    }
}
