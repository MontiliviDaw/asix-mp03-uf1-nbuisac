// Llista 3 - Exercici 8
double n1, n2, resultat;
double opcio;

Console.Write("Entra el primer valor -> ");
n1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Entra el segon valor -> ");
n2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("\tMENU\n\t====");
Console.WriteLine("1.- Sumar");
Console.WriteLine("2.- Restar");
Console.WriteLine("3.- Multiplicar");
Console.WriteLine("4.- Dividir");
Console.Write("\nEscull una opció -> ");

opcio = Convert.ToDouble(Console.ReadLine());


switch (opcio) {
    case 1:                        // if (opcio == 1) {
        resultat = n1 + n2;
        break;
    case 2:                        // } else if (opcio == 2) {
        resultat = n1 - n2;
        break;
    case 3:                        // } else if (opcio == 3) {
        resultat = n1 * n2;
        break;
    default:                        // } else {
        resultat = n1 / n2;
        break;
                            // }
}
Console.WriteLine("Resultat " + resultat);


