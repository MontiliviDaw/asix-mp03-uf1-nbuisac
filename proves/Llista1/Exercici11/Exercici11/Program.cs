// Llista 1 - Exercici 11
// Resolució d'una equació de 2n grau
// declaro les variables
double a, b, c, x1, x2;
Console.WriteLine("Equacions de 2n grau ax^2 + bx + c = 0");
Console.Write("Entra el valor de a : ");
a = Convert.ToDouble(Console.ReadLine());
Console.Write("Entra el valor de b : ");
b = Convert.ToDouble(Console.ReadLine());
Console.Write("Entra el valor de c : ");
c = Convert.ToDouble(Console.ReadLine());
x1 = (-b + Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a);
x2 = (-b - Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a);
Console.WriteLine("Les solucions son " + x1 + " i " + x2);
