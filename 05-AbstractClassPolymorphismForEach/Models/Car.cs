using System;
using System.Collections.Generic;
using System.Text;

namespace _05_AbstractClassPolymorphismForEach.Models
{
    internal class Car:vehicle
    {
       public int DoorsCount {  get; set; }
       public int TruckCapacity {  get; set; }
       public bool IsAutomatic {  get; set; }
       public int MaxSpeed {  get; set; }

        public Car(string brand, string model, int year, string platenumber, int doorscount,int truckcapacity,bool isautomatic,int maxspeed)
            :base ( brand,  model,  year,  platenumber)
        {
            this.DoorsCount = doorscount;
            this.TruckCapacity = truckcapacity;
            this.IsAutomatic = isautomatic;
            this.MaxSpeed = maxspeed;
        }
        public void ShowCarInfo()
        {
            ShowBasicInfo();
            Console.WriteLine($"DoorsCount: {DoorsCount} TruckCapacity: {TruckCapacity} IsAvtomatic: {IsAutomatic} MaxSpeed: {MaxSpeed}");
        }
         public double CalculateFuelCost(double distance )
        {
            return (distance / 100) * 8 * 1.50;
        }
    }
}
