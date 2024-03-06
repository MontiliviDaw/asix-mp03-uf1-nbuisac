// Examen cerques - recorreguts i strings - Exercici 1
int edat, quants;

edat = Convert.ToInt32(Console.ReadLine());
quants = 0;
while (edat != -1 && quants < 3) {
    // tracto les dades
    if (edat < 18) quants++;
    // preparo la següent interació
    edat = Convert.ToInt32(Console.ReadLine());
}
if (quants >= 3)
    Console.WriteLine("Sí");
else
    Console.WriteLine("No");
