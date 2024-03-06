// Llista 5b - Exercici 8 - Recorregut
char c, cAnterior;
int quants;
Console.WriteLine("Escriu una frase ...");
// Frase: Ahir diumenge va ploure.
c = (char) Console.ReadKey().KeyChar;
cAnterior = 'z';
quants = 0;
while (c != '\r') {
    // tractem les dades
    if (c == 'u') {
        if (cAnterior == 'a' || cAnterior == 'e' ||
            cAnterior == 'i' || cAnterior == 'o' || cAnterior == 'u') {
            quants++;
        }
    }
    if (c == 'i') {
        if (cAnterior == 'a' || cAnterior == 'e' ||
            cAnterior == 'o' || cAnterior == 'u') {
            quants++;
        }
    }
    // preparem la següent iteració
    cAnterior = c;
    c = (char)Console.ReadKey().KeyChar;
}
Console.WriteLine();
if (quants >= 0) {
    Console.WriteLine($"hi ha {quants} diftongs");
} else {
    Console.WriteLine("no hi ha cap diftong");
}

// Llista 5b - Exercici 8 - Cerca
Console.WriteLine("Escriu una frase ...");
// Frase: Ahir diumenge va ploure.
c = (char)Console.ReadKey().KeyChar;
cAnterior = 'z';
quants = 0;
while (c != '\r' && quants == 0) {
    // tractem les dades
    if (c == 'u') {
        if (cAnterior == 'a' || cAnterior == 'e' ||
            cAnterior == 'i' || cAnterior == 'o' || cAnterior == 'u') {
            quants++;
        }
    }
    if (c == 'i') {
        if (cAnterior == 'a' || cAnterior == 'e' ||
            cAnterior == 'o' || cAnterior == 'u') {
            quants++;
        }
    }
    // preparem la següent iteració
    cAnterior = c;
    if (quants == 0)
        c = (char)Console.ReadKey().KeyChar;
}
Console.WriteLine();
if (quants >= 0) {
    Console.WriteLine($"hi ha {quants} diftongs");
}
else {
    Console.WriteLine("no hi ha cap diftong");
}

