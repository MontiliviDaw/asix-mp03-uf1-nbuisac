// Llista 4 - Exercici 35
const int BASE = 2;
int numeroDecimal, residu, resultat;
string numeroBinari = "";
do {
    Console.WriteLine("Entra un numero enter positiu -> ");
    numeroDecimal = Convert.ToInt32(Console.ReadLine());
} while (numeroDecimal < 0);

while (numeroDecimal > 0) {
    residu = numeroDecimal % BASE;
    numeroDecimal = numeroDecimal / BASE;
    numeroBinari = residu + numeroBinari;
}
Console.WriteLine(numeroBinari);