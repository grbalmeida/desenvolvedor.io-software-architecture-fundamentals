using DesignPatterns.Facade.Domain;
using System;
using System.Linq;

namespace DesignPatterns.Strategy
{
    public class BilletPaymentService : IPayment
    {
        private readonly IBilletPaymentFacade _paymentBilletFacade;

        public BilletPaymentService(IBilletPaymentFacade paymentBilletFacade)
        {
            _paymentBilletFacade = paymentBilletFacade;
        }

        public Payment MakePayment(Order order, Payment payment)
        {
            payment.Total = order.Products.Sum(p => p.Price);
            Console.WriteLine("Starting payment via Billet - Total R$ " + payment.Total);

            payment.DigitizableBilletLine = _paymentBilletFacade.GenerateBillet();
            payment.Status = "Awaiting payment";
            return payment;
        }
    }
}