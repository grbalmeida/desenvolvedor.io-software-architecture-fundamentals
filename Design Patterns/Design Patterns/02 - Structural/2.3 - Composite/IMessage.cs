namespace DesignPatterns.Composite
{
    public interface IMessage
    {
        string Name { get; set; }
        void DisplayMessages(int sub);
    }
}