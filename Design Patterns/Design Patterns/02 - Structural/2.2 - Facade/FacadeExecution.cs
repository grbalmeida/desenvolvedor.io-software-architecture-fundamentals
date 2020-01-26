using DesignPatterns.Facade.CrossCutting;
using DesignPatterns.Facade.Domain;
using System;
using System.Collections.Generic;

namespace DesignPatterns.Facade
{
    public class FacadeExecution
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

            var payment = new Payment
            {
                CreditCard = "5555 2222 5555 9999"
            };

            // Solve with dependency injection
            var paymentService = new CreditCardPaymentService(
                new CreditCardPaymentFacade(
                    new PayPalGateway(), new ConfigurationManager()
                )
            );

            var paymentResult = paymentService.MakePayment(order, payment);

            Console.WriteLine(paymentResult.Status);
        }
    }
}