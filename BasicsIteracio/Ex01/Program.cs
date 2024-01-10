int dividend, divisor, copiaDividend;
int resultat;

Console.Write("Entra el dividend -> ");
dividend = Convert.ToInt32(Console.ReadLine());
copiaDividend = dividend;

Console.Write("Entra el divisor -> ");
divisor = Convert.ToInt32(Console.ReadLine());

resultat = 0;
while (dividend > divisor)
{
    dividend = dividend - divisor;
    resultat++;
}

Console.WriteLine($"{copiaDividend} / {divisor} = {resultat}");
Console.WriteLine($"El residu és {dividend}");