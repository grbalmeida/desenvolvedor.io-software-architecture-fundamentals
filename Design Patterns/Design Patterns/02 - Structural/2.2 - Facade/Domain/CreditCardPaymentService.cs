using System;
using System.Linq;

namespace DesignPatterns.Facade.Domain
{
    public class CreditCardPaymentService : IPayment
    {
        private readonly ICreditCardPaymentFacade _creditCardPaymentFacade;

        public CreditCardPaymentService(ICreditCardPaymentFacade creditCardPaymentFacade)
        {
            _creditCardPaymentFacade = creditCardPaymentFacade;
        }

        public Payment MakePayment(Order order, Payment payment)
        {
            payment.Total = order.Products.Sum(product => product.Price);
            Console.WriteLine("Starting Payment by Credit Card - Total R$ " + payment.Total);
        
            if (_creditCardPaymentFacade.MakePayment(order, payment))
            {
                payment.Status = "Paid via Credit Card";
                return payment;
            }

            payment.Status = "Credit Card Declined!";
            return payment;
        }
    }
}