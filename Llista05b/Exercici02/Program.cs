// Llista 5b - Compta lletres vocals entrades per teclat
char c;
int quantes;
string vocals = "aeiouAEIOUàèòáéíóúÀÈÒÁÉÍÓÚüÜïÏ";
quantes = 0;
c = (char)Console.Read();
while (c != '\r') {
    // Tracto les dades
    if (vocals.Contains(c)) {
        quantes++;
    }
        // Preparo la següent interació
        c = (char)Console.Read();
}
Console.WriteLine($"HAS ESCRIT {quantes} VOCALS");