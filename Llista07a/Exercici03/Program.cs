class Program {
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
        return Math.Round(m, 2);
    }
    static int DemanaNota() {
        int n;
        bool ok = false;

        Console.Write("Entra un a nota vàlida -> ");
        n = Convert.ToInt32(Console.ReadLine());
        while (! EsNotaValida(n) && ! ok ) {
            Console.Write("Nota invàlida: Entra un a nota vàlida -> ");
            ok = int.TryParse(Console.ReadLine(), out n);
        }
        return n;
    }

    static bool EsNotaValida(int n) {
        if (n >= 0 && n <= 10) return true;
        else return false;
    }
}