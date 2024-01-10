int n1, n2, aux;
int residu;

Console.Write("Entra dos numeros -> ");
n1 = Convert.ToInt32(Console.ReadLine());
n2 = Convert.ToInt32(Console.ReadLine());

if (n1 < n2)
{
    aux = n1;
    n1 = n2;
    n2 = aux;
}

residu = n1 % n2;

if (residu == 0)
{
    Console.WriteLine($"{n1} Sí és múltple de {n2}");
} else
{
    Console.WriteLine($"{n1} NO és múltple de {n2}");
}
