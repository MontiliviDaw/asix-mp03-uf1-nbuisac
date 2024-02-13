// Exercici de Menu

int opcio;

do {
    Console.Clear();
    Console.WriteLine("\tMENU\n\t====");
    Console.WriteLine("\t1.- Sumar");
    Console.WriteLine("\t2.- Restar");
    Console.WriteLine("\t3.- Multiplicar");
    Console.WriteLine("\t4.- Dividir");
    Console.WriteLine("\n\t0.- Sortir");

    Console.Write("\tEscull una opció -> ");
    opcio = Convert.ToInt32(Console.ReadLine());
    while (opcio < 0 || opcio > 4) {
        Console.Write("\tERROR: Escull una opció -> ");
        opcio = Convert.ToInt32(Console.ReadLine());
    }

    switch (opcio) {
        case 1: Console.WriteLine("Sumar"); break;
        case 2: Console.WriteLine("Restar"); break;
        case 3: Console.WriteLine("Multiplicar"); break;
        case 4: Console.WriteLine("Dividir"); break;
        case 0: Console.WriteLine("Sortir"); break;
    }
    Console.ReadKey();
} while (opcio != 0);
