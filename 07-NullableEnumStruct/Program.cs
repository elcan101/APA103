

using _07_NullableEnumStruct.Enums;
using _07_NullableEnumStruct.Models;
using System.Diagnostics.Metrics;
using System.Net.NetworkInformation;

DrinkOrder order1 = new DrinkOrder(101, "Ali", DrinkSize.Medium, DrinkType.Coffee,OrderStatus.Preparing);
order1.DisplayOrder();

order1.UpdateStatus(OrderStatus.Ready);
order1.DisplayOrder();

order1.UpdateStatus(OrderStatus.Delivered);
order1.DisplayOrder();

DrinkOrder order2 = new DrinkOrder(102, "Leyla", DrinkSize.Large, DrinkType.Tea, OrderStatus.Ready);
order2.DisplayOrder();

DrinkOrder order3 = new DrinkOrder(103, "Vüqar", DrinkSize.Small, DrinkType.Juice,OrderStatus.New);
order3.DisplayOrder();

Console.WriteLine("DrinkType:");
foreach (var type in Enum.GetValues(typeof(DrinkType)))
{
    Console.WriteLine(type);
}

Console.WriteLine("DrinkSize:");
foreach (var type in Enum.GetValues(typeof(DrinkSize)))
{
    Console.WriteLine(type);
}

Console.WriteLine("OrderStatus:");
foreach (var type in Enum.GetValues(typeof(OrderStatus)))
{
    Console.WriteLine(type);
}

Console.WriteLine(DrinkType.Coffee.ToString());
Console.WriteLine(DrinkSize.Large.ToString());

Console.WriteLine((DrinkType)Enum.Parse(typeof(DrinkType), "Tea"));                       
Console.WriteLine((DrinkSize)Enum.Parse(typeof(DrinkSize), "Medium"));                                  
                          


int orderCount = 3;
decimal firstOrder = order1.CalculatePrice();
decimal secondOrder = order2.CalculatePrice();
decimal thirdOrder = order3.CalculatePrice();
decimal totalPrice = firstOrder + secondOrder + thirdOrder;

Console.WriteLine("Total Order:" + orderCount);
Console.WriteLine("Price of First Order:" + firstOrder);
Console.WriteLine("Price of Second Order: " + secondOrder);
Console.WriteLine("Price of Third Order: " + thirdOrder);
Console.WriteLine("Total Price: " + totalPrice);

