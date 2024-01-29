// Llista 4 - Exercici 15
// Factorial d'un número N!
// N! = N * (N-1) * (N-2) * (N-3) * ... * 2 * 1
// 4! = 4 * 3 * 2 * 1 = 24
int numero;
long factorial;
Console.Write("Entra un nombre enter positiu -> ");
numero = Convert.ToInt32(Console.ReadLine());
while (numero < 0)
{
    Console.Write("Entra un nombre enter positiu -> ");
    numero = Convert.ToInt32(Console.ReadLine());
}
factorial = 1;
for (int i = numero; i >= 1; i--)
{
    factorial = factorial * i;
}
Console.WriteLine($" {numero}! = {factorial}");
