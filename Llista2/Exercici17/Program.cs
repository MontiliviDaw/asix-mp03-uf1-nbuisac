// See https://aka.ms/new-console-template for more information
double eurosRetornar;
int centimsRetornar;
int monedes, queda;
Console.Write("Quin és el canvi en auros -> ");
eurosRetornar = Convert.ToDouble(Console.ReadLine());
centimsRetornar = (int)(eurosRetornar + 100);
// 2 euros --> 200 cts
monedes = centimsRetornar / 200;
queda = centimsRetornar % 200;
Console.WriteLine($"{monedes} de 2 euros");
// 1 euro --> 100 cts
monedes = queda / 100;
queda = queda % 100;
Console.WriteLine($"{monedes} de 1 euro");
// 50 cts
monedes = queda / 50;
queda = queda % 50;
Console.WriteLine($"{monedes} de 50 cts");
// 20 cts
monedes = queda / 20;
queda = queda % 20;
Console.WriteLine($"{monedes} de 20 cts");
// 10 cts
monedes = queda / 10;
queda = queda % 10;
Console.WriteLine($"{monedes} de 10 cts");
// 5 cts
monedes = queda / 5;
queda = queda % 5;
Console.WriteLine($"{monedes} de 5 cts");
// 2 cts
monedes = queda / 2;
queda = queda % 2;
Console.WriteLine($"{monedes} de 2 cts");
// 1 cts
Console.WriteLine($"{queda} de 1 cts");



