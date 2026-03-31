using _09_UpcastingDowncastingExplicitImplicit.Models;

Dollar dollar = new(200);
Manat manat = new(170);

Dollar dollar1 = manat;
Console.WriteLine(dollar1.USD);

Manat manat1 = dollar;
Console.WriteLine(manat.AZN);

