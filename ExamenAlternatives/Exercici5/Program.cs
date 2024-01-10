int numero;
int a, b, c, d; // abcd

Console.Write("Entra un enter de 4 dígits -> ");
numero = Convert.ToInt32(Console.ReadLine());

if (numero >= 1000 && numero <= 9999 ) {
    a = numero / 1000;
    b = numero / 100 % 10;
    c = numero % 100 / 10;
    d = numero % 10;
    if (a == d && b == c)     {
        if (a == b)         {
            Console.WriteLine("Capicua ESPECIAL");
        } else         {
            Console.WriteLine("Capicua NORMAL");
        }
    } else     {
        Console.WriteLine("No és capicua");
    }
} else {
    Console.WriteLine("No té 4 dígits");
}