string nom;
int sumaLongituds = 0;
int quants = 0;

nom = Console.ReadLine();
while (!(nom == "prou")) {
    sumaLongituds = sumaLongituds + nom.Length;
    quants++;
    nom = Console.ReadLine();
}
Console.WriteLine($"{ (double )sumaLongituds / quants }");

