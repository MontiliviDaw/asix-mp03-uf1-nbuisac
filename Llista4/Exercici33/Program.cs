// Llista 4 - Exercici 33
// mcd(a, b)
int a, b;
int gran, petit;
Console.WriteLine("mcd(a, b)");
Console.Write("Entra el valor de a -> ");
a = Convert.ToInt32(Console.ReadLine());
while (a == 0) {
    Console.Write("No pot ser 0, Entra el valor de a -> ");
    a = Convert.ToInt32(Console.ReadLine());
}
Console.Write("Entra el valor de b -> ");
b = Convert.ToInt32(Console.ReadLine());
while (b == 0) {
    Console.Write("No pot ser 0, Entra el valor de b -> ");
    b = Convert.ToInt32(Console.ReadLine());
}
if (a > b) {
    gran = a;  petit = b;
} else {
    gran = b; petit = a;
}
while (gran % petit != 0) {
    int aux = gran;
    gran = petit;
    petit = aux % petit;
}
Console.WriteLine($"mcd({a}, {b}) = {petit}");