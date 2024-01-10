int alcada;
Random r = new Random();
int numero;

Console.Write("Entra l'alçada de l'arbre -> ");
alcada = Convert.ToInt32(Console.ReadLine());
while (true)
{
    Console.Clear();
    for (int nivell = 1; nivell <= alcada; nivell++)
    {
        Console.Write("".PadRight(alcada - nivell, ' '));
        for (int i = 0; i < 2 * nivell - 1; i++)
        {
            numero = r.Next(1, 11);
            if (numero < 3) { Console.Write('@'); }
            else { Console.Write('*'); }
        }
        Console.WriteLine();
    }
    for (int i = 0; i < alcada / 3; i++)
    {
        Console.WriteLine("| |".PadLeft(alcada + 1, ' '));
    }
    Thread.Sleep(r.Next(100, 1000));
}