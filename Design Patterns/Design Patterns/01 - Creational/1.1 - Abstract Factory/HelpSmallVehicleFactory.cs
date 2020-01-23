namespace DesignPatterns.AbstractFactory
{
    public class HelpSmallVehicleFactory : AutoHelpFactory
    {
        public override CarWinch CreateCarWinch()
        {
            return CarWinchCreator.Create(VehicleSize.Small);
        }

        public override Vehicle CreateVehicle(string model, VehicleSize vehicleSize)
        {
            return VehicleCreator.Create(model, vehicleSize);
        }
    }
}
