// Llista 4 - Exercici 24
// Progama que compta els dígits d'un nombre enter
int numero;
int digits;
Console.Write("Entra un nombre enter positiu -> ");
numero = Convert.ToInt32(Console.ReadLine());
int numeroOriginal = numero;
digits = 0;
while (numero != 0)
{
    numero = numero / 10;
    digits++;
}
Console.WriteLine($"{numeroOriginal} té {digits} digits");

