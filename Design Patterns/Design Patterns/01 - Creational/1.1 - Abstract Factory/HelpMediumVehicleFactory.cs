namespace DesignPatterns.AbstractFactory
{
    // Concrete Factory
    public class HelpMediumVehicleFactory : AutoHelpFactory
    {
        public override CarWinch CreateCarWinch()
        {
            return CarWinchCreator.Create(VehicleSize.Medium);
        }

        public override Vehicle CreateVehicle(string model, VehicleSize vehicleSize)
        {
            return VehicleCreator.Create(model, vehicleSize);
        }
    }
}
