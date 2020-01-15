namespace OOP
{
    public class EspressoMachine : Appliance
    {
        public EspressoMachine(string name, int voltage)
            : base(name, voltage) { }

        public EspressoMachine()
            : base("Default", 220) { }

        private static void HeatWater() { }

        private static void GrindGrain() { }

        public void BrewCoffee()
        {
            Test();
            HeatWater();
            GrindGrain();
            // ...
        }

        public override void Test()
        {
            base.Test();
            // Coffee maker test
        }

        public override void TurnOn()
        {
            // Check water container
        }

        public override void TurnOff()
        {
            // Cool heater
        }
    }
}
