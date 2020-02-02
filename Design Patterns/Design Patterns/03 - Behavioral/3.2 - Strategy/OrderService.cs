using DesignPatterns.Facade.Domain;

namespace DesignPatterns.Strategy
{
    public class OrderService
    {
        private readonly IPayment _payment;

        public OrderService(IPayment payment)
        {
            _payment = payment;
        }

        public Payment MakePayment(Order order, Payment payment)
        {
            return _payment.MakePayment(order, payment);
        }
    }
}