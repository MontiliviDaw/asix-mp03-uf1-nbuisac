internal class Program {
    private static void Main(string[] args) {
        int n1, n2;

        n1 = DemanaValor();
        n2 = DemanaValor();

        EscriuSuma(n1, n2, Suma(n1, n2));
    }
    static void EscriuSuma(int a, int b, int c) {
        Console.WriteLine($"{a} + {b} = {c}");
    }
    static int Suma(int a, int b) {
        return a + b;
    }
    static int DemanaValor() {
        int n;
        Console.Write("Entra un numero -> ");
        n = Convert.ToInt32(Console.ReadLine());
        return n;
    }
}