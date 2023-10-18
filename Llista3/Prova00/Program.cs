// See https://aka.ms/new-console-template for more information
int nota;

Console.Write("Entra la teva nota -> ");
nota = Convert.ToInt32(Console.ReadLine());

// opció llarga i no ben feta

if (nota < 5 )
{
    Console.WriteLine("No assolit");
}
if (nota >= 5 && nota < 7)
{
    Console.WriteLine("Assolit Suficient");
}
if (nota >= 7 && nota < 9)
{
    Console.WriteLine("Assolit Notable");
}
if (nota >= 9)
{
    Console.WriteLine("Assolit Excel·lent");
}

// opció optimitzada

if (nota < 0)
{
    Console.WriteLine("Nota incorrecta");
}
else if (nota < 5)
{
    Console.WriteLine("No assolit");
}
else if (nota < 7)
{
    Console.WriteLine("Assolit Suficient");
}
else if (nota < 9)
{
    Console.WriteLine("Assolit Notable");
}
else if (nota <= 10)
{
    Console.WriteLine("Assolit Excel·lent");
}
else
{
    Console.WriteLine("Nota incorrecta");
}
