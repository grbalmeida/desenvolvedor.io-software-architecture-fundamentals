namespace DesignPatterns.Observer
{
    // Concrete Subject
    public class BovespaPaper : Investment
    {
        public BovespaPaper(string symbol, decimal price)
            : base(symbol, price)
        {
        }
    }
}