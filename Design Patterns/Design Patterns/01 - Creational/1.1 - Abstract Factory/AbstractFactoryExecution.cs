using System.Collections.Generic;

namespace DesignPatterns.AbstractFactory
{
    public class AbstractFactoryExecution
    {
        public static void Execute()
        {
            var vehicles = new List<Vehicle>
            {
                VehicleCreator.Create("Celta", VehicleSize.Small),
                VehicleCreator.Create("Jetta", VehicleSize.Medium),
                VehicleCreator.Create("BMW X6", VehicleSize.Big)
            };

            vehicles.ForEach(vehicle => AutoHelp.CreateAutoHelp(vehicle).PerformService());
        }
    }
}
