// See https://aka.ms/new-console-template for more information
int n, nAnt;

n = Convert.ToInt32(Console.ReadLine());
nAnt = 2;
while (n != 0) {
    // Tracto
    if (n % 2 == 0 && nAnt % 2 == 1) {
        Console.WriteLine("   " + n);
    }
    // Preparo
    nAnt = n;
    n = Convert.ToInt32(Console.ReadLine());
}
