long numero, sumaDivisors;

Console.Write("Entra un nombre enter positiu -> ");
numero = Convert.ToInt64(Console.ReadLine());

sumaDivisors = 0;
for (long i = 1; i <= numero / 2; i++)
{
    if (numero % i == 0)
    {
        sumaDivisors += i;
    }
}
if (numero == sumaDivisors)
{
    Console.WriteLine($"{numero} és PERFECTE");
} else
{
    Console.WriteLine($"{numero} és NO PERFECTE");

}