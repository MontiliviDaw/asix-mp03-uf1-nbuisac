// Llista 5a - Exercici 09
// Dir si una llista de números, acabada en zero,
// és creixent, descreixent o res
int numero, anterior;
bool esCreixent = false;
bool esDecreixent = false;
// demanarem la sèrie de números
Console.WriteLine("Entra una sèrie de números, 0 per acabar -> ");
numero = Convert.ToInt32(Console.ReadLine());
if (numero != 0) {
    anterior = numero;
    numero = Convert.ToInt32(Console.ReadLine());
    if (numero != 0) {
        esCreixent = (numero > anterior);
        esDecreixent = (numero < anterior);
        anterior = numero;
        numero = Convert.ToInt32(Console.ReadLine());
        while (numero != 0) {
            // tractar les dades
            if (numero <= anterior) {
                esCreixent = false;
            }
            if (numero >= anterior) {
                esDecreixent = false;
            }
            // Preparar la següent iteració
            anterior = numero;
            numero = Convert.ToInt32(Console.ReadLine());
        }
    }
}
// Mostrem el resultat
if (esCreixent) {
    Console.WriteLine("La sèrie és sempre creixent");
}
else if (esDecreixent) {
    Console.WriteLine("La sèrie és SEMPRE decreixent ");
}
else {
    Console.WriteLine("La sèrie NO és SEMPRE creixent ni decreixent");
}
