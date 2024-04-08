using System.Numerics;

internal class Program {
    private static void Main(string[] args) {
        int n1, n2, p;

        n1 = DemanaNumero();
        n2 = DemanaNumero();

        p = Multiplica(n1, n2);
        EscriuProducte(n1, n2, p);
    }

    static void EscriuProducte(int a, int b, int c) {
        Console.WriteLine($"{a} x {b} = {c}");
    }
    static int Multiplica(int a, int b) {
        int suma = 0;

        while (b > 0) {
            suma = suma + a;
            b = b - 1;
        }
        return suma;
    }

    static int DemanaNumero() {
        int numero;

        Console.Write("Entra un numero per pantalla -> ");
        numero = Convert.ToInt32(Console.ReadLine());
        return numero;
    }

}