internal class Program {
    private static void Main(string[] args) {
        int nota1, nota2;
        double mitjana;

        nota1 = DemanaNota();
        nota2 = DemanaNota();
        mitjana = CalculaMitjana(nota1, nota2);
        MostraNotaFinal(mitjana);
    }
    static void MostraNotaFinal(double notaFinal) {
        Console.WriteLine($"La nota final és {notaFinal}");
    }

    static double CalculaMitjana(int n1, int n2) {
        double m;
        m = n1 * 0.6 + n2 * 0.4;
        return m;
    }
    static int DemanaNota() {
        int n;

        Console.Write("Entra un a nota vàlida -> ");
        n = Convert.ToInt32(Console.ReadLine());
        while (n < 0 || n > 10) {
            Console.Write("Nota invàlida: Entra un a nota vàlida -> ");
            n = Convert.ToInt32(Console.ReadLine());
        }
        return n;
    }
}