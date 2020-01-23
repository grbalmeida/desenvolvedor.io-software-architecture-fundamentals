namespace DesignPatterns.AbstractFactory
{
    // Concrete Factory
    public class HelpBigVehicleFactory : AutoHelpFactory
    {
        public override CarWinch CreateCarWinch()
        {
            return CarWinchCreator.Create(VehicleSize.Big);
        }

        public override Vehicle CreateVehicle(string model, VehicleSize vehicleSize)
        {
            return VehicleCreator.Create(model, vehicleSize);
        }
    }
}
