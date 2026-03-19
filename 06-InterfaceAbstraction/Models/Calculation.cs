using _06_InterfaceAbstraction.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace _06_InterfaceAbstraction.Models
{
    internal class Calculation : ICalculation, IBolme, IVurma, ICixma, IToplama
    {
        public double calculation(double a, double b, string operation)
        {
            switch (operation)
            {

                case "+":
                    return toplama(a, b);
                case "-":
                    return cixma(a, b);
                case "*":
                    return vurma(a, b);
                case "/":
                    return bolme(a, b);
                default:
                    Console.WriteLine("Yanlış əməliyyat!");
                    return 0;
            }
        }

        public double cixma(double a, double b)
        {
            return a - b;
        }

        public double toplama(double a, double b)
        {
            return a + b;
        }

        public double vurma(double a, double b)
        {
            return a * b;
        }
        public double bolme(double a, double b)
        {
            return a / b;
        }



    }
}
