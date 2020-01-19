namespace SOLID.DIP.Solution.Interfaces
{
    public interface IEmailServices
    {
        void Send(string from, string to, string subject, string message);
    }
}
