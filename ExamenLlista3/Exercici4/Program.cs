// // Exercici 4 - Examen Llista 3
using System.Collections;
using System.Runtime.CompilerServices;

char tipus;
int mida;
double preuInicial, preuFinal, preuAPagar, kilos, increment;

Console.Write("Preu Inicial -> ");
preuInicial = Convert.ToDouble(Console.ReadLine());
Console.Write("Kilos -> ");
kilos = Convert.ToDouble(Console.ReadLine());

Console.Write("Tipus de raim (A/B) -> ");
tipus = Convert.ToChar(Console.ReadLine());

increment = 0;
switch (tipus) {
    case 'A':
        // tipus A
        Console.Write("Entra la mida (1/2) -> ");
        mida = Convert.ToInt32(Console.ReadLine());
        if (mida == 1) {
            increment = 0.2;
        } else if (mida == 2) {
            increment = 0.3;
        }
        break;
    case 'B':
        // tipus B
        Console.Write("Entra la mida (1/2) -> ");
        mida = Convert.ToInt32(Console.ReadLine());
        if (mida == 1) {
            increment = 0.3;
        } else if (mida == 2) {
            increment = 0.5;
        }
        break;
}
if (increment != 0) {
    preuFinal = preuInicial + increment;
    preuAPagar = preuFinal * kilos;
    Console.WriteLine($"Preu Inicial -> {preuInicial}");
    Console.WriteLine($"Increment    -> {increment}");
    Console.WriteLine($"Preu Final   -> {preuFinal}");
    Console.WriteLine($"kilos        -> {kilos}");
    Console.WriteLine($"Preu Final a pagar -> {preuAPagar}");
} else {
        Console.WriteLine("Tipus o mida ERRONI/A");

}