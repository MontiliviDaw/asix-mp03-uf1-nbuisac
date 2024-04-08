using System.Security.Cryptography;

internal class Program {
    private static void Main(string[] args) {
        double a, b;

        a = DemanaNumero();
        OmpleNumero(out b);
        MinimMaxim(ref a, ref b); // deixa a a el valor menor i a b el major
        Escriu(a);
        Escriu(b);

        while (!double.TryParse(Console.ReadLine(), out a))
            Console.WriteLine("ERROR: Torna-hi"); ;
        Console.WriteLine($"a val {a}");
    }

}