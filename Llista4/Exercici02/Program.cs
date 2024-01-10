// Llista 4 - Exercici 2

double nota;

do
{
    Console.Write("Entra una nota de 0 a 10 -> ");
    nota = Convert.ToDouble(Console.ReadLine());
    if (nota < 0 || nota > 10)
    {
        Console.Write("ERROR: ");
    }
} while (nota < 0 || nota > 10);

Console.WriteLine($"la nota és {nota}");