// Llista 5b - Exercici 9 - Mètode CÈSAR
using System.Runtime.ExceptionServices;
// char c;
char cx;
const int CESAR = 19;

Console.Write("Escriu un missatge que el codificarem -> ");
// c  = (char) Console.Read();
string s = Console.ReadLine();
// while (c != '\r') {
for(int i = 0; i < s.Length; i++) { 
    // tractem les dades
    if (s[i] >= 'a' && s[i] <= 'z') {
        cx = (char)(s[i] + CESAR);
        if (cx > 'z') {
            cx = (char)('a' + (cx - 'z' - 1));
        }
    }
    else if (s[i] >= 'A' && s[i] <= 'Z') {
        cx = (char)('A' + ((s[i] + CESAR - 'A') % ('Z'-'A'+1))) ;
    } else {
        cx = s[i];
    }
    Console.Write(cx);
    // preparem la següent iteració
    // c = (char)Console.Read();
}
Console.WriteLine();
Console.ReadLine();