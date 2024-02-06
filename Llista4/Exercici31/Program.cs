// Llista 4 - Exercici 31
const int QUANTS = 183;

Int128 f1_abans, f2_abans, fib, comptador;
Console.WriteLine("Primers 20 nombres de Fibonnacci");
f1_abans = 1;
Console.WriteLine(f1_abans);
Console.WriteLine(f1_abans);
f2_abans = 1;
for(comptador = 2; comptador < QUANTS; comptador++)  {
    // Tractem les dades
    fib = f1_abans + f2_abans;
    Console.WriteLine($"{fib} \t ({comptador + 1})");
    // Preparem la següent iteració
    f2_abans = f1_abans;
    f1_abans = fib;
}
