using _05_AbstractClassPolymorphismForEach.Models;
using System.Reflection;

using System;


class Program
{
    static void Main()
    {
     
        Car car1 = new Car("Mercedes", "E200", 2023, "10-AA-001", 4, 500, true, 220);
        Car car2 = new Car("BMW", "320i", 2022, "10-BB-002", 4, 480, true, 235);
        Car car3 = new Car("Toyota", "Camry", 2021, "10-CC-003", 4, 524, true, 210);

     
        Motorcycle m1 = new Motorcycle("Yamaha", "R1", 2023, "10-DD-004", 998, false, 299, "Sport");
        Motorcycle m2 = new Motorcycle("Harley-Davidson", "Iron", 2022, "10-EE-005", 1868, true, 180, "Cruiser");


        Truck t1 = new Truck("MAN", "TGX", 2020, "10-FF-006", 18, 3, 12, 120);
        Truck t2 = new Truck("Volvo", "FH16", 2021, "10-GG-007", 25, 4, 18, 110);

      
        car1.ShowCarInfo();
        Console.WriteLine("Fuel cost (500 km): " + car1.CalculateFuelCost(500));

        car2.ShowCarInfo();
        Console.WriteLine("Fuel cost (500 km): " + car2.CalculateFuelCost(500));

        car3.ShowCarInfo();
        Console.WriteLine("Fuel cost (500 km): " + car3.CalculateFuelCost(500));

        Console.WriteLine("------------");

        m1.ShowMotorcycleInfo();
        Console.WriteLine("Fuel cost (300 km): " + m1.CalculateFuelCost(300));

        m2.ShowMotorcycleInfo();
        Console.WriteLine("Fuel cost (300 km): " + m2.CalculateFuelCost(300));

        Console.WriteLine("------------");

        t1.ShowTruckInfo();
        Console.WriteLine("Fuel cost (800 km): " + t1.CalculateFuelCost(800));

        t2.ShowTruckInfo();
        Console.WriteLine("Fuel cost (800 km): " + t2.CalculateFuelCost(800));

        Console.WriteLine("\n--- Ssenari 5: Truck-a yük əlavə edilməsi ---");
        Console.WriteLine($"Köhnə yük (MAN): {t1.CurrentLoad} ton");
        t1.LoadCargo(5); 
        Console.WriteLine($"Yeni yanacaq xərci (800 km üçün): {t1.CalculateFuelCost(800)} AZN");

        
        Console.WriteLine("\n--- Ssenari 6: Statistika ---");

        int totalCount = 7; 
        Console.WriteLine($"Ümumi nəqliyyat sayı: {totalCount}");

        double totalMaxSpeed = car1.MaxSpeed + car2.MaxSpeed + car3.MaxSpeed +
                               m1.MaxSpeed + m2.MaxSpeed +
                               t1.MaxSpeed + t2.MaxSpeed;
        double avgSpeed = totalMaxSpeed / totalCount;
        Console.WriteLine($"Orta maksimum sürət: {avgSpeed:F2} km/saat");

        double cost1 = t1.CalculateFuelCost(800);
        double cost2 = t2.CalculateFuelCost(800);

        if (cost1 > cost2)
            Console.WriteLine($"Ən bahalı yanacaq xərci: {t1.Brand} {t1.Model} ({cost1} AZN)");
        else
            Console.WriteLine($"Ən bahalı yanacaq xərci: {t2.Brand} {t2.Model} ({cost2} AZN)");
        

    }
}