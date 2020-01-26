namespace DesignPatterns.Facade.Domain
{
    public interface IPayment
    {
        Payment MakePayment(Order order, Payment payment);
    }
}