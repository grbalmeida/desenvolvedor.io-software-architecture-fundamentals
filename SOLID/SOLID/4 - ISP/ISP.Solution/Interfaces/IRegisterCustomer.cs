namespace SOLID.ISP.Solution.Interfaces
{
    public interface IRegisterCustomer : IRegister
    {
        void ValidateData();
        void SendEmail();
    }
}
