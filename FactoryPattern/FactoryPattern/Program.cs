using FactoryPattern;

IPayment payment = PaymentFactory.Create(PaymentMethod.ApplePay);
payment.Pay(50000.00);