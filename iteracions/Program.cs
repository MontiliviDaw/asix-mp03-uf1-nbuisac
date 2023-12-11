// // estructures iteratives
// // Demanarem un numero i direm si és parell

double nota;
double sumaNotes, mitjanaNotes;
int quantesNotes;

quantesNotes = 0;
sumaNotes = 0;
Console.Write("Entra una nota -> ");
nota = Convert.ToDouble(Console.ReadLine());
while ((nota < 0 || nota > 10) && nota != -1) {
    Console.Write("ERROR: Entra una nota -> ");
    nota = Convert.ToDouble(Console.ReadLine());
}
while (nota != -1) {
    // tractem les dades
    sumaNotes = sumaNotes+ nota;
    quantesNotes++;
    // Preparem la següent interació (Demano la següent nota)
    Console.Write("Entra una nota -> ");
    nota = Convert.ToDouble(Console.ReadLine());
    while ((nota < 0 || nota > 10) && nota != -1) {
        Console.Write("ERROR: Entra una nota -> ");
        nota = Convert.ToDouble(Console.ReadLine());
    }
}
mitjanaNotes = sumaNotes / quantesNotes;
Console.WriteLine("La mitjana és " + mitjanaNotes);




// char siono;

// do {
//     siono = Console.ReadKey(true).KeyChar;
// } while (siono != 's' && siono != 'S' && siono != 'n' && siono != 'N');
// Console.WriteLine(siono);



// int numero;
// char resposta;

// do{
//     Console.Write("Entra un nombre -> ");
//     numero = Convert.ToInt32(Console.ReadLine());
//     if (numero % 2 == 0) {
//         Console.WriteLine(numero + " és parell");
//     } else {
//         Console.WriteLine(numero + " és senar");
//     }

//     Console.Write("Vols tornar-hi (s/n) ? ");
//     resposta = Convert.ToChar(Console.ReadLine());
//     while (resposta != 's' && resposta != 'n' && resposta != 'S' && resposta != 'N') {
//         Console.Write("ERROR: Vols tornar-hi (s/n) ? ");
//         resposta = Convert.ToChar(Console.ReadLine());
//     }
// } while (resposta == 's' || resposta == 'S');

