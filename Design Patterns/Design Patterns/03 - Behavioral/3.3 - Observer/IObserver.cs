namespace DesignPatterns.Observer
{
    // Observer
    public interface IObserver
    {
        string Name { get; }
        void Notify(Investment investment);
    }
}