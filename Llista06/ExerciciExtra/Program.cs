// Exercici de strings
// Comptem quantes lletres de cada hi ha
// Utilitzarem IndexOf
string s;
char c;
int quantes, posicio;
Console.WriteLine("Entra una frase:");
s = Console.ReadLine().ToUpper();
// Comptem les 'A' que tenim guardada a la variable c
for (c = 'A'; c <= 'Z'; c++) {
    quantes = 0;
    posicio = s.IndexOf(c);
    while (posicio != -1) {
        quantes++;
        posicio = s.IndexOf(c, posicio + 1);
    }
    if (quantes > 0)
        Console.WriteLine($"Hi ha {quantes} lletres {c}");
}
        


