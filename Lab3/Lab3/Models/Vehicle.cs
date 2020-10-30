using System;

namespace Lab3.Models
{
    [Serializable]
    public class Vehicle
    {
        public string VehicleType { get; set; }
        public int MaxSpeed { get; set; }

        public Vehicle(string vehicleType, int maxSpeed)
        {
            VehicleType = vehicleType;
            MaxSpeed = maxSpeed;
        }
    }
}
