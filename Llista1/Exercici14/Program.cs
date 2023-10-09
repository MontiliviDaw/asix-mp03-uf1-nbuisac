// Llista 1 - Exercici 14
int hores, minuts, segons;
int segonsTotals;
Console.Write("Entra el nombre d'hores -> ");
hores = Convert.ToInt32(Console.ReadLine());
Console.Write("Entra el nombre de minuts -> ");
minuts = Convert.ToInt32(Console.ReadLine());
Console.Write("Entra el nombre de segons -> ");
segons = Convert.ToInt32(Console.ReadLine());
segonsTotals = hores * 3600 + minuts * 60 + segons;
Console.WriteLine(hores + " hores, " + minuts + " minuts i " + segons + " segons, son " + segonsTotals + " segons.");
Console.WriteLine($"{hores} hores, {minuts} minuts i {segons} segons, son {segonsTotals} segons.");
