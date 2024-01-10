char producte, qualitat;
int sacsCaixes;
double preuSacCaixa, descompte, preuFinal = 0;

Console.Write("Producte p/c -> ");
producte = Console.ReadKey().KeyChar;

Console.WriteLine("Entra el nombre de sacs/caixes -> ");
sacsCaixes = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Entra el preu per sac/caixa -> ");
preuSacCaixa = Convert.ToInt32(Console.ReadLine());

if (producte == 'p' || producte == 'P')
{
    Console.WriteLine("Entra el descompte % -> ");
    descompte = Convert.ToDouble(Console.ReadLine());
    preuFinal = preuSacCaixa * sacsCaixes * (1 - descompte / 100);

} else // Castanyes
{
    Console.Write("Qualitat a/b -> ");
    qualitat = Console.ReadKey().KeyChar;
    preuFinal = preuSacCaixa * sacsCaixes;
    if (qualitat == 'a' && sacsCaixes > 4) {
        preuFinal = preuFinal * 0.85;
    }
}
Console.WriteLine($"Preu a pagar -> {preuFinal}");
