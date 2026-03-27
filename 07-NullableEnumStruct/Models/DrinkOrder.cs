using _07_NullableEnumStruct.Enums;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace _07_NullableEnumStruct.Models
{
    public class DrinkOrder
    {
        int OrderNumber {  get; set; }
        string CustomerName {  get; set; }
        DrinkSize Size { get; set; }
        DrinkType Type { get; set; }
        OrderStatus Status { get; set; }
        decimal Price {  get; set; }


        public DrinkOrder (int ordernumber, string customername, DrinkSize size, DrinkType type, OrderStatus orderstatus)
        {
            this.OrderNumber = ordernumber;
            this.CustomerName = customername;   
            this.Size = size;
            this.Type = type;
            this.Status = orderstatus;
            this.Price = CalculatePrice();

        }

        public decimal CalculatePrice()
        {
            switch (Type)
            {

                case DrinkType.Coffee:
                    if (Size == DrinkSize.Small)
                    {
                        return 3;
                    }
                    else if (Size == DrinkSize.Medium)
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                case DrinkType.Tea:
                    if (Size == DrinkSize.Small)
                    {
                        return 2;
                    }
                    else if (Size == DrinkSize.Medium)
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                case DrinkType.Water:
                    if (Size == DrinkSize.Small)
                    {
                        return 1;
                    }
                    else if (Size == DrinkSize.Medium)
                    {
                        return 1.5m;
                    }
                    else
                    {
                        return 2;
                    }
                case DrinkType.Juice:
                    if (Size == DrinkSize.Small)
                    {
                        return 4;
                    }
                    else if (Size == DrinkSize.Medium)
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                default: return 0;
            }
        }

        public void UpdateStatus(OrderStatus newStatus)
        {
            Status = newStatus;
            Console.WriteLine($"Sifariş {OrderNumber} statusu: {newStatus}");
        }
            public void DisplayOrder()
        {

            Console.WriteLine($"Ordernumber: {OrderNumber} Customername: {CustomerName} Drinksize: {Size} Drinktype: {Type} Orderstatus: {Status} Price: {Price}");
        }

            
    } 
}
