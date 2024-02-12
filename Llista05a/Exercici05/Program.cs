// Llista 5a - Exercici 5
// Mitjana de notes
int numero, sumaNumeros, quants;
double mitjana;
Console.Write("Entra un nombre (0 per acabar) -> ");
numero = Convert.ToInt32(Console.ReadLine());
quants = 0; sumaNumeros = 0;
while (numero != 0) {
    quants++;
    sumaNumeros = sumaNumeros + numero;
    Console.Write("Entra un nombre (0 per acabar) -> ");
    numero = Convert.ToInt32(Console.ReadLine());
}
if (quants > 0) {
    mitjana = (double)sumaNumeros / quants;
    Console.WriteLine($"La mitjana és {mitjana} ({sumaNumeros}/{quants})");
}
else {
    Console.WriteLine("No hi ha dades");
}