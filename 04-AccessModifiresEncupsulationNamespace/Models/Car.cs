using System;
using System.Collections.Generic;
using System.Text;

namespace _04_AccessModifiresEncupsulationNamespace.Models
{
    internal class Car
    {
        public string _model;
        private int _horsepower;

        public int HorsePower 
        { 
            get
            {
                return _horsepower;
            }
            set
            {
                if (value<100)
                {
                    Console.WriteLine("enter valid power");
                }
                _horsepower = value;
            }
                
          }
    }
}
