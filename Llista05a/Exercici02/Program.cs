// Llista 5a - Exercici 2 - Cerca
// Diu si hem entrat alguna a/A
char c;
c = Console.ReadKey().KeyChar;
while (c != '\r' && c != 'a' && c != 'A') {
    c = Console.ReadKey().KeyChar;
}
Console.WriteLine();
if (c == 'a' || c == 'A') {
    Console.WriteLine("Hi ha alguna A");
}
else {
    Console.WriteLine("No hi ha cap A");
}