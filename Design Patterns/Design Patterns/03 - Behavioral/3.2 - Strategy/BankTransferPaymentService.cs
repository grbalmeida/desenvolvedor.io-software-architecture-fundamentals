using DesignPatterns.Facade.Domain;
using System;
using System.Linq;

namespace DesignPatterns.Strategy
{
    public class BankTransferPaymentService : IPayment
    {
        private readonly IBankTransferPaymentFacade _paymentBankTransferFacade;

        public BankTransferPaymentService(IBankTransferPaymentFacade paymentBankTransferFacade)
        {
            _paymentBankTransferFacade = paymentBankTransferFacade;
        }

        public Payment MakePayment(Order order, Payment payment)
        {
            payment.Total = order.Products.Sum(p => p.Price);
            Console.WriteLine("Starting payment via Bank Transfer - Total R$ " + payment.Total);

            payment.TransferConfirmation = _paymentBankTransferFacade.PerformTransfer();
            payment.Status = "Paid via bank transfer";
            return payment;
        }
    }
}