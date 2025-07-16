using FactoryPattern;

IPayment payment = PaymentFactory.Create(PaymentMethod.PayPal);
payment.Pay(50000.00);