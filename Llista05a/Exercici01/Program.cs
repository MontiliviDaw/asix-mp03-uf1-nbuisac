// Llista 5a - Exercici 1 - Recorregut
// Compta lletres a/A
char c;
int comptador;
Console.WriteLine("Entra una frase i et diré les As que hi ha ...");
comptador = 0;
c = (char)Console.Read();
while (c != '\r') {
    // Tracto les dades
    if (c == 'a' || c == 'A') {
        comptador++;
    }
    // Preparo la següent iteració
    c = (char)Console.Read();
}
Console.WriteLine($"Hi ha {comptador} As");