namespace OOP
{
    public class CoffeeAutomation
    {
        public void ServeCoffee()
        {
            var espressoMachine = new EspressoMachine();
            espressoMachine.TurnOn();
            espressoMachine.BrewCoffee();
            espressoMachine.TurnOff();
        }
    }
}
