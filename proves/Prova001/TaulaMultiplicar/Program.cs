using static System.Runtime.InteropServices.JavaScript.JSType;

class Program {
    private static void Main(string[] args) {
        char c;
        c = (char) Console.Read();
        while (c != '\r') {
            if (EsVocal(c)) {
                Console.WriteLine($"{c} Vocal");
            } else {
                Console.WriteLine($"{c} no Vocal");
            }
            c = (char)Console.Read();
        }
    }

    static bool EsVocal(char c) {
        string vocals = "aeiouAEIOUàèìòùáéíóúÀÈÌÒÙÁÉÍÓÚäëïöüÄËÏÖÜ";
        return vocals.Contains(c);
    }






    static int DemanaNumero() {
        int numero;
        Console.Write("Entra un numero enter -> ");
        numero = Convert.ToInt32(Console.ReadLine());
        return numero;
    }
    static int Quadrat(int n) {
        int quadrat;
        quadrat = n * n;
        return quadrat;
    }
    
    
    
    static void VariesTaulesMultiplicar(int primera, int ultima) {
        for(int i = primera; i <= ultima; i++) {
            Console.WriteLine($"Taula {i, 2}");
            Console.WriteLine("========");
            TaulaMultiplicar(i);
            Console.WriteLine();
        }

    }

    static void TaulaMultiplicar(int taula) {
        for (int i = 1; i <= 10; i++) {
            Console.WriteLine($"{taula} x {i, 2} = {taula * i, 3}");
        }
    }
}