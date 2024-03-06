// Validem IPv4
string ipv4;
int numero, posicio1, posicio2, quants = 0;
bool esValid = true;
Console.Write("Entra una IPv4 -> ");
ipv4 = Console.ReadLine().Trim() + ".";
posicio1 = 0;
posicio2 = ipv4.IndexOf('.');
while (posicio2 != -1) {
    // tracto les dades
    numero = Convert.ToInt32(ipv4.Substring(posicio1, posicio2 - posicio1));
    quants++;
    Console.WriteLine(numero);
    if (numero < 0 || numero > 255) {
        esValid = false;
    }
    // preparo la següent iteracio
    posicio1 = posicio2 + 1;
    posicio2 = ipv4.IndexOf(".", posicio1);
}
if (esValid && quants == 4) {
    Console.WriteLine("CORRECTE");
} else {
    Console.Write("ERROR: ");
    if (quants != 4) { Console.WriteLine("Nombre de valors incorrecte"); }
    if (!esValid) { Console.WriteLine("Algun valor < 0 o > 255"); }
}