using _06_InterfaceAbstraction.Models;

Calculation calculation = new Calculation();


Console.WriteLine("a edeini daxil et");
double a= Convert.ToDouble(Console.ReadLine());

Console.WriteLine("b ededini daxil et");
double b = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Əməliyyat seç (+, -, *, /)");
string operation = Console.ReadLine();

double result = calculation.calculation(a, b, operation);

Console.WriteLine("Nəticə: " + result);
  