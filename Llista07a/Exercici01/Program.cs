internal class Program {
    private static void Main(string[] args) {
        int n;
        for (int i = 0; i < 10; i++) {
            n = Convert.ToInt32(Console.ReadLine());
            if (EsNotaValida(n)) {
                Console.WriteLine("Ok");
            }
            else {
                Console.WriteLine("No Ok");
            }
        }
    }
    static bool EsNotaValida(int nota) {
        return (nota >= 0 && nota <= 10);
    }
}