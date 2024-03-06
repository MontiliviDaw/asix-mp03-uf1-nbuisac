// // Examen cerques - recorreguts i strings - Exercici 4
int numero, numeroAnterior;
Console.WriteLine("Entra nombres, -1 per acabar...");
do {
    numero = Convert.ToInt32(Console.ReadLine());
} while (numero < -1 || numero == 0);
numeroAnterior = numero; // int.MaxValue;
while (numero != -1) {
    // tractem el numero 
    if (numero == numeroAnterior + 1) {
        Console.WriteLine($"{numeroAnterior} {numero}");
    }
    // preparem la següent interacio
    numeroAnterior = numero;
    do {
        numero = Convert.ToInt32(Console.ReadLine());
    } while (numero < -1 || numero == 0);
}
