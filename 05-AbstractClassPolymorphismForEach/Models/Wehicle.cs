using System;
using System.Collections.Generic;
using System.Text;

namespace _05_AbstractClassPolymorphismForEach.Models
{
    internal class vehicle
    {
        public string Brand { get; set; }
        public string Model {  get; set; }
        public int Year {  get; set; }
        public string PlateNumber {  get; set; }
        public double FuelLevel{  get; set; }

        public vehicle(string brand, string model, int year, string platenumber)
        {
           this.Brand = brand;
            this.Model = model;
            this.Year = year;
            this.PlateNumber = platenumber;
            this.FuelLevel = 100;
        }

        public string GetVehicleInfo()
        {
            return $"{Brand} {Model} ({Year}) - Plate: {PlateNumber}, Fuel: {FuelLevel}%";
        }

        public void ShowBasicInfo()
        {
            Console.WriteLine(GetVehicleInfo());
        }
    }
}
