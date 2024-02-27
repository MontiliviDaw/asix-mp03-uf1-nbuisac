// Llista 5c - Exercici 5
Console.WriteLine("Peix espinós en extinció!!!");
int num, quants;
bool enPerill = false;
quants = 0;
Console.WriteLine("Entra el nombre de peixos trobats a cada tram, -1 per acabar ...");
num = Convert.ToInt32(Console.ReadLine());
while (num != -1) {
    // Tracto les dades
    if (num < 10) {
        quants++;
        if (quants == 2) {
            enPerill = true;
        }
    } else {
        quants = 0;
    }
    // Preparo següent interacio
    num = Convert.ToInt32(Console.ReadLine());
}
if (enPerill) {
    Console.WriteLine("Sí, està en perill");
} else
    Console.WriteLine("No, no està en perill");
Console.ReadKey();
