// Exercici 1 -  Suma de nombres parells entre 1 i 50
int suma, i;

suma = 0;
for (i = 1; i <= 50; i++) {
    if (i % 2 == 0) {
        suma = suma + i;
    }
}
Console.WriteLine($"La suma val {suma}");