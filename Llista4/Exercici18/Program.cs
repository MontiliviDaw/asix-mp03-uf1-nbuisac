// Llista 4 - Exercici 18
// Nombres primers

int numero, q;
Console.Write("Entra un nombre enter positiu -> ");
numero = Convert.ToInt32(Console.ReadLine());
q = 0;
if (numero == 2)
{
    q = 2;
}
else if (numero > 2 && numero % 2 != 0)
{
    q = 2;
    int i = 2;
    while (i <= numero / 2 && q == 2)
    {
        Console.WriteLine($"Provo {i}");
        if (numero % i == 0)
        {
            q++;
        }
        i++;
    }
}
if (q == 2 )
{
    Console.WriteLine($"{numero} és PRIMER");
} else
{
    Console.WriteLine($"{numero} NO és PRIMER");
}
