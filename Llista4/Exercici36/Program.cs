// Llista 4 - Exercici 36
const int BASE = 16;
int numeroDecimal, residu;
string numeroHexadecimal = "";
do
{
    Console.WriteLine("Entra un numero enter positiu -> ");
    numeroDecimal = Convert.ToInt32(Console.ReadLine());
} while (numeroDecimal < 0);

while (numeroDecimal > 0)
{
    residu = numeroDecimal % BASE;
    numeroDecimal = numeroDecimal / BASE;
    // Què passa si residu > 10?
    if (residu < 10) { numeroHexadecimal = residu + numeroHexadecimal; }
    else { numeroHexadecimal = (char)('A' + residu - 10) + numeroHexadecimal; }
}
Console.WriteLine(numeroHexadecimal);