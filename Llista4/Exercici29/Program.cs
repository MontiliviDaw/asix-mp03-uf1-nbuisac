// Llista 4 - Exercici 29
Console.WriteLine("Apilables fins el 1.000");
int apilable;
int i;

i = 1;
apilable = 1;
while (apilable <= 1000) {
    Console.WriteLine(apilable);
    apilable = apilable + i;
    i++;
}
