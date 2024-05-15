using System.Runtime.ExceptionServices;

internal class Program {

    private static void Main(string[] args) {
        int nombreAlumnes;
        int[] notes;
        double mitjana;
        int aprovats, suspesos;

        nombreAlumnes = DemanaNombreAlumnes();
        notes = new int[nombreAlumnes];
        EntraNotes(notes);
        Console.WriteLine($"La mitjana és {CalculaMitjana(notes)}");
        AprovatsSuspesos(notes, out aprovats, out suspesos);
        Console.WriteLine($"Hi ha {aprovats} aprovats i {suspesos} suspesos");
        if (HiHaUn(notes, 5)) 
            Console.WriteLine("Hi ha algun 5");
        else 
            Console.WriteLine("No hi ha cap 5");
    }
    static bool HiHaUn(int[] n, int valor) {
        bool hiEs = false;
        int i;
        i = 0;
        while ( i < n.Length && ! hiEs) {
            if (n[i] == valor)
                hiEs = true;
            else 
                i++;
        }
        return hiEs;

    }
    static void AprovatsSuspesos(int[] n, out int aptes, out int noAptes) {
        aptes = 0;
        noAptes = 0;
        for(int i = 0; i < n.Length; i++) {
            if (n[i] >= 5)
                aptes++;
            else 
                noAptes++;
        }
    }
    static double CalculaMitjana(int[] n) {
        int suma = 0;
        for(int i = 0; i < n.Length; i++) {
            suma = suma + n[i];
        }
        return (double)suma / n.Length;
    }
    static void EntraNotes(int[] n) {
        for(int i = 0; i < n.Length; i++) {
            Console.Write($"Entra la nota de l'alumne {i + 1} -> ");
            n[i] = Convert.ToInt32(Console.ReadLine());
            while (n[i] < 0 || n[i] > 10) {
                Console.Write($"ERROR: Entra la nota de l'alumne {i + 1} -> ");
                n[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
    static int DemanaNombreAlumnes() {
        int n;
        Console.Write("Entra el nombre d'alumnes-> ");
        n = Convert.ToInt32(Console.ReadLine());
        return n;
    }
}