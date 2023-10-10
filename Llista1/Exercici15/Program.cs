// See https://aka.ms/new-console-template for more information
double canviDouble;
int canviEnter;
int bitllets;
int canvi;
Console.Write("Entra el canvi a retornar -> ");
canviDouble = Convert.ToDouble(Console.ReadLine());
canviEnter = (int) (canviDouble * 100);
bitllets = canviEnter / 50000;
canvi = canviEnter % 50000;
Console.WriteLine($"{bitllets} bitllets de 500 Euros");

bitllets = canvi / 20000;
canvi = canvi % 20000;
Console.WriteLine($"{bitllets} bitllets de 200 Euros");

bitllets = canvi / 10000;
canvi = canvi % 10000;
Console.WriteLine($"{bitllets} bitllets de 100 Euros");

bitllets = canvi / 5000;
canvi = canvi % 5000;
Console.WriteLine($"{bitllets} bitllets de 50 Euros");

bitllets = canvi / 2000;
canvi = canvi % 2000;
Console.WriteLine($"{bitllets} bitllets de 20 Euros");

bitllets = canvi / 1000;
canvi = canvi % 1000;
Console.WriteLine($"{bitllets} bitllets de 10 Euros");

bitllets = canvi / 500;
canvi = canvi % 500;
Console.WriteLine($"{bitllets} bitllets de 5 Euros");

bitllets = canvi / 200;
canvi = canvi % 200;
Console.WriteLine($"{bitllets} monedes de 2 Euros");

bitllets = canvi / 100;
canvi = canvi % 100;
Console.WriteLine($"{bitllets} monedes de 1 Euro");

bitllets = canvi / 50;
canvi = canvi % 50;
Console.WriteLine($"{bitllets} monedes de 50 cents");

bitllets = canvi / 20;
canvi = canvi % 20;
Console.WriteLine($"{bitllets} monedes de 20 cents");

bitllets = canvi / 10;
canvi = canvi % 10;
Console.WriteLine($"{bitllets} monedes de 10 cents");

bitllets = canvi / 5;
canvi = canvi % 5;
Console.WriteLine($"{bitllets} monedes de 5 cents");

bitllets = canvi / 2;
canvi = canvi % 2;
Console.WriteLine($"{bitllets} monedes de 2 cents");

Console.WriteLine($"{canvi} monedes de 1 cent");

