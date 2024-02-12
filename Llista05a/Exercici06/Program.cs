// Llista 5a - Exercici 6
// Mostra el major d'una sèrie de nombres finalitzada en 0
int gran, numero;
Console.Write("Entra un numero (0 per acabar) -> ");
numero = Convert.ToInt32(Console.ReadLine());
gran = numero;
while (numero != 0) {
    // tracto les dades
    if (numero > gran) {
        gran = numero;
    }
    // preparo la següent iteració
    Console.Write("Entra un numero (0 per acabar) -> ");
    numero = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine($"El més gran és el {gran}");