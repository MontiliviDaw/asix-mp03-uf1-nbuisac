// See https://aka.ms/new-console-template for more information
string frase1, frase2;

Console.WriteLine("Escriu dues frases -> ");
frase1 = Console.ReadLine();
frase2 = Console.ReadLine();

// Majúscula i minúscula
Console.WriteLine(frase1.ToUpper());
Console.WriteLine(frase2.ToLower());
// Vocal
if (frase1.ToLower().Contains('a') || frase2.ToLower().Contains('e') ||
    frase1.ToLower().Contains('i') || frase2.ToLower().Contains('o') ||
    frase1.ToLower().Contains('u'))
    Console.WriteLine("Hi ha una vocal");
else 
    Console.WriteLine("No hi ha cap vocal");
// punt?
if (frase2.Contains('.')) 
    Console.WriteLine("Sí punt a frase2");
else 
    Console.WriteLine("No punt a frase 2");
if (frase1.ToLower().Contains("la")) {
    Console.WriteLine("La apareix a la posicio " +
        (frase1.ToLower().IndexOf("la") + 1));
}
int posicio = -1;
if (frase2.IndexOf('a') >= 0) {
    posicio = frase2.IndexOf('a', frase2.IndexOf('a') + 1);
}
if (posicio == -1) Console.WriteLine("no hi ha dues a");
else Console.WriteLine("La segona a apareix a " + posicio);