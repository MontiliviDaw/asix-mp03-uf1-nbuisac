// Examen Llista 3 -  Exercici 5
double ca, cb, cc, ajuda;

Console.Write("Entra el primer costat -> ");
ca = Convert.ToDouble(Console.ReadLine());
Console.Write("Entra el segon costat -> ");
cb = Convert.ToDouble(Console.ReadLine());
Console.Write("Entra el tercer costat -> ");
cc = Convert.ToDouble(Console.ReadLine());

// Posarem a ca el valor major de tots
if (cb > ca && cb >= cc) {
    ajuda = ca;
    ca = cb;
    cb = ajuda;
} else if (cc > ca && cc >= cb) {
    ajuda = ca;
    ca = cc;
    cc = ajuda;
}
if (ca * ca == cb * cb + cc * cc) {
    Console.WriteLine("Pitàgores");
} else if (ca == cb && cb == cc) {
    Console.WriteLine("Equilàter");
} else if (ca == cb || cb == cc || ca == cc) {
    Console.WriteLine("Isòceles");
} else {
    Console.WriteLine("Escalè");
}