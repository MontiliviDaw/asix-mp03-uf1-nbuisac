// Llista 4 - Exercici 1

double nota;

Console.Write("Entra la nota 0..10 -> ");
nota = Convert.ToDouble(Console.ReadLine());

while (nota < 0 || nota > 10)
{
    Console.Write("ERROR: Entra la nota 0..10 -> ");
    nota = Convert.ToDouble(Console.ReadLine());
}

Console.WriteLine($"La nota és {nota}");
