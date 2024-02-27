// Llista 5b - Exercici 4
// demanant lletra a lletra fins CR compto paraules.
char c, cAnterior;
int paraules = 0;
cAnterior = '.'; // qualsevol caràcter no lletra
c = (char)Console.Read();
while (c != '\r') {
    // Tracto les dades
    if (Char.IsLetter(c) && ! Char.IsLetter(cAnterior)) {
        paraules++;
    }
    // Preparo la següent interació
    cAnterior = c;
    c = (char)Console.Read();
}
Console.WriteLine($"Hi ha {paraules} paraules");