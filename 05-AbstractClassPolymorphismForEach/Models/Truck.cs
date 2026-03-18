using System;
using System.Collections.Generic;
using System.Text;

namespace _05_AbstractClassPolymorphismForEach.Models
{
    internal class Truck:vehicle
    {

        public double CargoCapacity { get; set; }
        public int AxleCount { get; set; }
        public double CurrentLoad { get; set; }
        public int MaxSpeed { get; set; }

        public Truck(string brand, string model, int year, string plateNumber,
                     double cargoCapacity, int axleCount, double currentLoad, int maxSpeed)
            : base(brand, model, year, plateNumber)
        {
            this.CargoCapacity = cargoCapacity;
            this.AxleCount = axleCount;
            this.CurrentLoad = currentLoad;
            this.MaxSpeed = maxSpeed;
        }

        public void ShowTruckInfo()
        {
            ShowBasicInfo();
            Console.WriteLine($"Capacity: {CargoCapacity} ton, Load: {CurrentLoad} ton, Axles: {AxleCount}, MaxSpeed: {MaxSpeed}");
        }

        public void LoadCargo(double weight)
        {
            if (CurrentLoad + weight <= CargoCapacity)
            {
                CurrentLoad += weight;
                Console.WriteLine("Yük əlavə olundu");
            }
            else
            {
                Console.WriteLine("Tutum aşılır!");
            }
        }

        public double CalculateFuelCost(double distance)
        {
            return (distance / 100) * (25 + CurrentLoad * 2) * 1.80;
        }
    }
}
