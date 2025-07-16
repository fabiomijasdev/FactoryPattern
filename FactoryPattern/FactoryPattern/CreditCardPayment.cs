namespace FactoryPattern;

public class CrediCardPayment : IPayment
{
    public void Pay(double amount)
    {
        Console.WriteLine($"Successfully paid ${amount} to merchant using a CreditCard");
    }
}

