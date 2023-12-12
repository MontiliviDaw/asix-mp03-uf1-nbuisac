// Examen Llista 3 - Exercici 5
double ca, cb, cc, ajuda;

Console.Write("Entra el valor d'un costat -> ");
ca = Convert.ToDouble(Console.ReadLine());
Console.Write("Entra el valor d'un altre costat -> ");
cb = Convert.ToDouble(Console.ReadLine());
Console.Write("Entra el valor del darrer costat -> ");
cc = Convert.ToDouble(Console.ReadLine());
// Mirem si és Pitàgores
if (cb > ca) {
    ajuda = ca;
    ca = cb;
    cb = ajuda;
}
if (cc > ca) {
    ajuda = ca;
    ca = cc;
    cc = ajuda;
}
// Ja tenim a ca el valor major
if (Math.Pow(ca, 2) == Math.Pow(cb, 2) + Math.Pow(cc, 2)) {
    Console.WriteLine("Compleix Pitàgores");
} else if (ca == cb && cb == cc) { // Tres costats iguals
    Console.WriteLine("Equilàter");
} else if (ca == cb || ca == cc || cb == cc) {
    Console.WriteLine("Isòsceles");
} else {
    Console.WriteLine("Escalè");
}
