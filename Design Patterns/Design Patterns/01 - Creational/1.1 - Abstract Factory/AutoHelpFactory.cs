namespace DesignPatterns.AbstractFactory
{
    // Abstract Factory
    public abstract class AutoHelpFactory
    {
        public abstract CarWinch CreateCarWinch();
        public abstract Vehicle CreateVehicle(string model, VehicleSize vehicleSize);
    }
}
