// LLista 3 - Exercici 3
// Valor absolut d'un número
double numero, absolut;

Console.Write("Entra un numero per pantalla -> ");
numero = Convert.ToDouble(Console.ReadLine());
if (numero >= 0) {
    absolut = numero;
} else {
    absolut = -numero;
}
Console.WriteLine($"|{numero}| = {absolut}");