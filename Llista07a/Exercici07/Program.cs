internal class Program {
    private static void Main(string[] args) {
        int n1, n2, d;

        n1 = DemanaNumero();
        n2 = DemanaNumero();
        d = Divideix(n1, n2);
        MostraDivisio(n1, n2, d);
    }

    static void MostraDivisio(int n1, int n2, int n3) {
        Console.WriteLine($"{n1} / {n2} = {n3}");
    }

    static int Divideix(int a, int b) {
        int q = 0;
        while (a >= b) {
            a = a - b;
            q++;
        }
        return q;
    }
    static int DemanaNumero() {
        int v;
        Console.Write("Entra un numero -> ");
        v = Convert.ToInt32(Console.ReadLine());

        return v;
    }
}