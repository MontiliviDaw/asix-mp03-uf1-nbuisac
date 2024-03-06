// Examen cerques - recorreguts i strings - Exercici 2
int x, y, z;
int numero;
for (numero = 100; numero < 1000; numero++) {
    // separem els digits
    x = numero / 100;
    y = numero / 10 % 10;
    z = numero % 10;
    // Comprovem i mostrem si cal
    if (Math.Pow(x, 3) + Math.Pow(y, 3) + Math.Pow(z, 3) == numero)
        Console.WriteLine(numero);
}
