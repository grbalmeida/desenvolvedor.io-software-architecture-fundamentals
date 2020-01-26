namespace DesignPatterns.Facade.Domain
{
    public interface ICreditCardPaymentFacade
    {
        bool MakePayment(Order order, Payment payment);
    }
}