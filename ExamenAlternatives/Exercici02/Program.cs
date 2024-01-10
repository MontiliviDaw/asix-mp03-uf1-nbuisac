double nota;

Console.WriteLine("Entra una nota 0..10 -> ");
nota = Convert.ToDouble(Console.ReadLine());

if (nota >= 0 && nota > 10) {
    if (nota < 5)     {
        Console.WriteLine("D");
    }
    else if (nota < 7)     {
        Console.WriteLine("D");
    }
    else if (nota < 9)     {
        Console.WriteLine("B");
    }
    else {
        Console.WriteLine("A");
    }
}
else {
    Console.WriteLine("ERROR");
}
