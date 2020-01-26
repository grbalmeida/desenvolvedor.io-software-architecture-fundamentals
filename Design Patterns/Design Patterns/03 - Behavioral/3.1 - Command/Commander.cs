namespace DesignPatterns.Command
{
    internal abstract class Commander
    {
        public abstract void Run();
        public abstract void Undo();
    }
}