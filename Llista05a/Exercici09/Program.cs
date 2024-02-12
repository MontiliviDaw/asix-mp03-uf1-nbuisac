// Llista 5a - Exercici 09
// Dir si una llista de números, acabada en zero,
// és creixent, descreixent o res
int numero, anterior;
bool esCreixent = false;
// demanarem la sèrie de números
Console.WriteLine("Entra una sèrie de números, 0 per acabar -> ");
numero = Convert.ToInt32(Console.ReadLine());
if (numero != 0) {
    anterior = numero;
    numero = Convert.ToInt32(Console.ReadLine());
    esCreixent = (numero > anterior);
    while (numero != 0) {
        // tractar les dades
        if (numero <= anterior) {
            esCreixent = false;
        }
        // Preparar la següent iteració
        anterior = numero;
        numero = Convert.ToInt32(Console.ReadLine());
    }
}

// Mostrem el resultat
if (esCreixent) {
    Console.WriteLine("La sèrie és sempre creixent");
} else {
    Console.WriteLine("La sèrie NO sempre és creixent");
}
