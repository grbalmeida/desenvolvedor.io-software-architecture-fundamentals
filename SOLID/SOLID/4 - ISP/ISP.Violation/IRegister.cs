namespace SOLID.ISP.Violation
{
    public interface IRegister
    {
        void ValidateData();
        void SaveToDatabase();
        void SendEmail();
    }
}
