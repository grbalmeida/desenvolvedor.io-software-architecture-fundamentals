using DesignPatterns.Facade.CrossCutting;
using DesignPatterns.Facade.Domain;
using System;

namespace DesignPatterns.Strategy
{
    public class PaymentFactory
    {
        public static IPayment CreatePayment(PaymentMethod paymentMethod)
        {
            return paymentMethod switch
            {
                PaymentMethod.CreditCard => new CreditCardPaymentService(
                       new CreditCardPaymentFacade(
                           new PayPalGateway(),
                           new ConfigurationManager()
                       )
                   ),

                PaymentMethod.Billet => new BilletPaymentService(new BilletPaymentFacade()),

                PaymentMethod.BankTransfer => new BankTransferPaymentService(new BankTransferPaymentFacade()),

                _ => throw new ApplicationException("Payment method not known"),
            };
        }
    }
}