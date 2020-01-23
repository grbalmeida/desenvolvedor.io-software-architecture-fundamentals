using System;

namespace DesignPatterns.AbstractFactory
{
    // Abstract Product
    public abstract class Vehicle
    {
        protected Vehicle(string model, VehicleSize vehicleSize)
        {
            Model = model;
            VehicleSize = vehicleSize;
        }

        public string Model { get; set; }
        public VehicleSize VehicleSize { get; set; }
    }

    public enum VehicleSize
    {
        Small,
        Medium,
        Big
    }

    // Concrete Product
    public class SmallVehicle : Vehicle
    {
        public SmallVehicle(string model, VehicleSize vehicleSize) : base(model, vehicleSize) { }
    }

    // Concrete Product
    public class MediumVehicle : Vehicle
    {
        public MediumVehicle(string model, VehicleSize vehicleSize) : base(model, vehicleSize) { }
    }

    // Concrete Product
    public class BigVehicle : Vehicle
    {
        public BigVehicle(string model, VehicleSize vehicleSize) : base(model, vehicleSize) { }
    }

    public class VehicleCreator
    {
        public static Vehicle Create(string model, VehicleSize vehicleSize)
        {
            return vehicleSize switch
            {
                VehicleSize.Small => new SmallVehicle(model, vehicleSize),
                VehicleSize.Medium => new MediumVehicle(model, vehicleSize),
                VehicleSize.Big => new BigVehicle(model, vehicleSize),
                _ => throw new ApplicationException("Unknown vehicle size"),
            };
        }
    }
}