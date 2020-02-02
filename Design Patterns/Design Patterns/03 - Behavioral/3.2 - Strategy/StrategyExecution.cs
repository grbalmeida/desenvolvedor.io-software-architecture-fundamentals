using DesignPatterns.Facade.CrossCutting;
using DesignPatterns.Facade.Domain;
using System;
using System.Collections.Generic;

namespace DesignPatterns.Strategy
{
    public class StrategyExecution
    {
        public static void Execute()
        {
            var products = new List<Product>
            {
                new Product{Name = "Tenis Adidas", Price = new Random().Next(500)},
                new Product{Name = "Camisa Boliche", Price = new Random().Next(500)},
                new Product{Name = "Raquete Tenis", Price = new Random().Next(500)}
            };

            var order = new Order
            {
                Id = Guid.NewGuid(),
                Products = products
            };

            var creditCardPaymentMethod = new Payment
            {
                PaymentMethod = PaymentMethod.Billet,
                CreditCard = "5555 2222 5555 9999"
            };

            var billetPaymentMethod = new Payment
            {
                PaymentMethod = PaymentMethod.Billet
            };

            var bankTransferPaymentMethod = new Payment
            {
                PaymentMethod = PaymentMethod.BankTransfer,
                CreditCard = "5555 2222 5555 9999"
            };

            #region Simple Way

            var creditCardOrder = new OrderService(
                new CreditCardPaymentService(
                    new CreditCardPaymentFacade(
                        new PayPalGateway(),
                        new ConfigurationManager()
                    )    
                )    
            );
            var creditCardPayment = creditCardOrder.MakePayment(order, creditCardPaymentMethod);
            Console.WriteLine(creditCardPayment.Status);

            Console.WriteLine("-------------------------------------------------------");

            var billetOrder = new OrderService(
                new BilletPaymentService(
                    new BilletPaymentFacade()
                )    
            );
            var billetPayment = billetOrder.MakePayment(order, billetPaymentMethod);
            Console.WriteLine(billetPayment.Status);

            Console.WriteLine("-------------------------------------------------------");

            var bankTransferOrder = new OrderService(
                new BankTransferPaymentService(
                    new BankTransferPaymentFacade()    
                )    
            );
            var bankTransferPayment = bankTransferOrder.MakePayment(order, bankTransferPaymentMethod);
            Console.WriteLine(bankTransferPayment.Status);

            Console.WriteLine("-------------------------------------------------------");

            #endregion

            #region Elegant Way

            var creditCardOrder2 = new OrderService(PaymentFactory.CreatePayment(creditCardPaymentMethod.PaymentMethod));
            var creditCardPayment2 = creditCardOrder2.MakePayment(order, creditCardPaymentMethod);
            Console.WriteLine(creditCardPayment2.Status);

            Console.WriteLine("-------------------------------------------------------");

            var billetOrder2 = new OrderService(PaymentFactory.CreatePayment(billetPaymentMethod.PaymentMethod));
            var billetPayment2 = billetOrder2.MakePayment(order, billetPaymentMethod);
            Console.WriteLine(billetPayment2.Status);

            Console.WriteLine("-------------------------------------------------------");

            var bankTransferOrder2 = new OrderService(PaymentFactory.CreatePayment(bankTransferPaymentMethod.PaymentMethod));
            var bankTransferPayment2 = bankTransferOrder2.MakePayment(order, bankTransferPaymentMethod);
            Console.WriteLine(bankTransferPayment2.Status);

            #endregion
        }
    }
}