namespace OOP
{
    public abstract class Appliance
    {
        private readonly string _name;
        private readonly int _voltage;

        protected Appliance(string name, int voltage)
        {
            _name = name;
            _voltage = voltage;
        }

        public abstract void TurnOn();
        public abstract void TurnOff();
        public virtual void Test()
        {
            // Equipment test
        }
    }
}
