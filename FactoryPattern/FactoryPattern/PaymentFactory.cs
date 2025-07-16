namespace FactoryPattern;

public class PaymentFactory
{
    public static IPayment Create(PaymentMethod paymentMethod)
    {

        switch (paymentMethod)
        {
            case PaymentMethod.CreditCard:
                return new CrediCardPayment();

            case PaymentMethod.PayPal:
                return new PayPalPayment();

            case PaymentMethod.GooglePay:
                return new GooglePayPayment();

            case PaymentMethod.ApplePay:
                return new ApplePayPayment();

            default:
                throw new NotSupportedException($"{paymentMethod} is not curremtly supported as a payment method.");
        }
    }
}
