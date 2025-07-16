namespace FactoryPattern;

public class ApplePayPayment : IPayment
{
    public void Pay(double amount)
    {
        Console.WriteLine($"Successfully paid ${amount} to merchant using Apple Pay");
    }
}
