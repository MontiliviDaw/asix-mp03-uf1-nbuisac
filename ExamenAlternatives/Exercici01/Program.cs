// Exercici 1 
int numero;
Console.WriteLine("Entra un numero -> ");
numero = Convert.ToInt32(Console.ReadLine());

if (numero % 5 != 0 && numero % 7 != 0)
{
    Console.WriteLine($"{numero} no es múltiple de 5 ni de 7");
}
else
{
    if (numero % 5 == 0)
    {
        Console.WriteLine($"{numero} és múltiple de 5");
    }
    if (numero % 7 == 0)
    {
        Console.WriteLine($"{numero} és múltiple de 7");
    }
}
