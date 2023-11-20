// Llista 3 - Exercici 9
using System.Net.WebSockets;

double graus, grausConvertits;
Console.Write("Entra els graus de la circumferència -> ");
graus = Convert.ToDouble(Console.ReadLine());

// convertim de 0 a 360
grausConvertits = graus % 360;

// Passem a positius
if (grausConvertits < 0) {
    grausConvertits = 360 + grausConvertits;
}

Console.WriteLine(graus);
Console.WriteLine(grausConvertits);

if (grausConvertits < 90) {
    Console.WriteLine("Primer quadrant");
} else if (grausConvertits < 180) {
    Console.WriteLine("Segon Quatdrant");
} else if(grausConvertits < 270) {
    Console.WriteLine("Tercer Quadrant");
} else {
    Console.WriteLine("Quart Quadrant");
}