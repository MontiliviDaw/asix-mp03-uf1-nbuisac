// LLista 4  Exercici 23
// C(m,n) Combinacions
int m, n;
Console.WriteLine("Combinacions de m elements agafats de n en n");
do
{
    Console.Write("Entra el valor de m -> ");
    m = Convert.ToInt32(Console.ReadLine());
    while (m <= 0) // m 
    {
        Console.Write("ERROR: Entra el valor de m -> ");
        m = Convert.ToInt32(Console.ReadLine());
    }
    do
    {
        Console.Write("Entra el valor de n ->");
        n = Convert.ToInt32(Console.ReadLine());
    } while (n <= 0);
} while (m < n);
Int128 factM, factN, factM_N;
factM = factN = factM_N = 1;
for (int i = m; i > 1; i--) factM = factM * i;
for (int i = n; i > 1; i--) factN = factN * i;
for (int i = m - n; i > 1; i--) factM_N = factM_N * i;
Int128 cmn = factM / (factN * factM_N);
Console.WriteLine($"C({m},{n}) = {cmn}");
