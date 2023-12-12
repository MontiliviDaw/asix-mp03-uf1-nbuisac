// Examen Llista 3 - Exercici 4
double preuInicial, kilos, preuFinal, preuFinalAPagar;
double increment;
char tipus, categoria;

increment = 0;
Console.Write("Entra el preu inicial (€) -> ");
preuInicial = Convert.ToDouble(Console.ReadLine());
Console.Write("Kilos de raim -> ");
kilos = Convert.ToDouble(Console.ReadLine());
Console.Write("Entra el tipus (A/B) -> ");
tipus = Convert.ToChar(Console.ReadLine());
if (tipus == 'a' || tipus == 'A') {
    Console.Write("Entra la categoria (1/2) -> ");
    categoria = Convert.ToChar(Console.ReadLine());
    if (categoria == '1') {
        increment = 0.2;
    } else if (categoria == '2') {
        increment = 0.3;
    }
} else if (tipus == 'b' || tipus == 'B') {
    Console.Write("Entra la categoria (1/2) -> ");
    categoria = Convert.ToChar(Console.ReadLine());
    if (categoria == '1') {
        increment = -0.3;
    } else if (categoria == '2') {
        increment = -0.5;
    }
}
if (increment != 0) {
    preuFinal = preuInicial + increment;
    preuFinalAPagar = preuFinal * kilos;
    Console.WriteLine($"Preu Incial  : {preuInicial} Euros");
    Console.WriteLine($"Increment    : {increment} Euros");
    Console.WriteLine($"Preu Final   : {preuFinal} Euros");
    Console.WriteLine($"kilos        : {kilos} Euros");
    Console.WriteLine($"Preu a pagar : {preuFinalAPagar} Euros");
} else {
    Console.WriteLine("ERROR");
}

