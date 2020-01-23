using System;

namespace DesignPatterns.AbstractFactory
{
    // Abstract Product
    public abstract class CarWinch
    {
        protected CarWinch(VehicleSize vehicleSize)
        {
            VehicleSize = vehicleSize;
        }

        public abstract void RescueVehicle(Vehicle vehicle);
        public VehicleSize VehicleSize { get; set; }
    }

    // Concrete Product
    public class SmallCarWinch : CarWinch
    {
        public SmallCarWinch(VehicleSize vehicleSize) : base(vehicleSize) { }

        public override void RescueVehicle(Vehicle vehicle)
        {
            Console.WriteLine("Rescuing Small Car - Model" + vehicle.Model);
        }
    }

    // Concrete Product
    public class MediumCarWinch : CarWinch
    {
        public MediumCarWinch(VehicleSize vehicleSize) : base(vehicleSize) { }

        public override void RescueVehicle(Vehicle vehicle)
        {
            Console.WriteLine("Rescuing Medium Car - Model", vehicle.Model);
        }
    }

    // Concrete Product
    public class BigCarWinch : CarWinch
    {
        public BigCarWinch(VehicleSize vehicleSize) : base(vehicleSize) { }

        public override void RescueVehicle(Vehicle vehicle)
        {
            Console.WriteLine("Rescuing Big Car - Model", vehicle.Model);
        }
    }

    public class CarWinchCreator
    {
        public static CarWinch Create(VehicleSize vehicleSize)
        {
            return vehicleSize switch
            {
                VehicleSize.Small => new SmallCarWinch(vehicleSize),
                VehicleSize.Medium => new MediumCarWinch(vehicleSize),
                VehicleSize.Big => new BigCarWinch(vehicleSize),
                _ => throw new ApplicationException("Unknown vehicle size"),
            };
        }
    }
}