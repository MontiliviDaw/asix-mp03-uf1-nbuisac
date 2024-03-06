// Comptem lletres d'una frase
string frase;
char c;
int posicio, quantes = 0;
Console.WriteLine("Entra una frase!");
frase = Console.ReadLine().ToUpper();
for (c = 'A'; c <= 'Z'; c++) {
    quantes = 0;
    posicio = frase.IndexOf(c);
    while (posicio != -1) {
        quantes++;
        posicio = frase.IndexOf(c, posicio + 1);
    }
    if (quantes > 0)
        Console.WriteLine($"Hi ha {quantes} lletres {c}");
}