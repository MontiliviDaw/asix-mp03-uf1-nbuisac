// Llista 3 - Exercici 1
// Equació de primer grau ax + b = b
// x = -b / a
// Controlarem que la x no sigui zero, 0
double a, b, x;
Console.WriteLine("Anem a resoldre una equació de primer grau de la forma ax + b = 0");
Console.Write("Entra el valor de a -> ");
a = Convert.ToDouble(Console.ReadLine());
if (a == 0) {
    System.Console.WriteLine("No és equació de primer grau: El valor de a no pot ser 0");
} else {
    Console.Write("Entra el valor de b -> ");
    b = Convert.ToDouble(Console.ReadLine());
    x = -b / a;
    Console.WriteLine($"El resultat per la x és {x}");
}
Console.WriteLine("Fins la propera");

