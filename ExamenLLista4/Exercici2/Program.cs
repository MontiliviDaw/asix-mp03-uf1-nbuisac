// Exercici 2 -  Divisors d'un numero
int numero;
Console.WriteLine("Escriu un numero enter positiu -> ");
numero = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= numero; i++) {
    if (numero % i == 0) {
        Console.WriteLine(i);
    }
}
