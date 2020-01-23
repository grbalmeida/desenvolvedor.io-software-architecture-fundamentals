using System;

namespace DesignPatterns.AbstractFactory
{
    // Client Class
    public class AutoHelp
    {
        private readonly Vehicle _vehicle;
        private readonly CarWinch _carWinch;

        public AutoHelp(AutoHelpFactory factory, Vehicle vehicle)
        {
            _vehicle = factory.CreateVehicle(vehicle.Model, vehicle.VehicleSize);
            _carWinch = factory.CreateCarWinch();
        }

        public void PerformService()
        {
            _carWinch.RescueVehicle(_vehicle);
        }

        public static AutoHelp CreateAutoHelp(Vehicle vehicle)
        {
            return vehicle.VehicleSize switch
            {
                VehicleSize.Small => new AutoHelp(new HelpSmallVehicleFactory(), vehicle),
                VehicleSize.Medium => new AutoHelp(new HelpMediumVehicleFactory(), vehicle),
                VehicleSize.Big => new AutoHelp(new HelpBigVehicleFactory(), vehicle),
                _ => throw new ApplicationException("Could not identify vehicle"),
            };
        }
    }
}
