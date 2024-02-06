// Llista 4 - Exercici 32
Int128 f1_abans, f2_abans, fib, quin, comptador;
Console.Write("Quin numero de Fibonnacci vols veure? ");
quin = Convert.ToInt32(Console.ReadLine());
while (quin <= 0)
{
    Console.Write("Quin numero de Fibonnacci vols veure? ");
    quin = Convert.ToInt32(Console.ReadLine());
}
if (quin == 1 || quin == 2) {
    fib = 1;
}
else {

    f1_abans = 1;
    f2_abans = 1;
    fib = 0; // Pequè no doni error el CW final
    for (comptador = 2; comptador < quin; comptador++)
    {
        // Tractem les dades
        fib = f1_abans + f2_abans;
        // Preparem la següent iteració
        f2_abans = f1_abans;
        f1_abans = fib;
    }
}
Console.WriteLine($"F({quin}) = {fib}");
