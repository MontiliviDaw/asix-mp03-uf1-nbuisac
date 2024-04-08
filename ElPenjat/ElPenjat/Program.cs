using System.Text;

internal class Program {
    static void Main(string[] args) {
        const int ERRORS = 10;
        string p; // Paraula que s'ha d'encertar
        StringBuilder pu; // paraula que mostrem a l'usuari amb guions i/o lletres encertades
        int errors; // nombre d'errors comesos
        char c; // caràcter que demanem al jugador
        Console.Clear();
        p = DemanaParaula();
        Console.Clear();
        // Omplim la paraula de l’usuari de tants guions com lletres té la paraula original
        pu = new StringBuilder("".PadLeft(p.Length, '-'));
        errors = 0;
        MostraError(errors); // mostrem els errors (i el troç de dibuix)
        Console.WriteLine(pu); // mostrem el que l'usuari porta escrit
        while (errors < ERRORS && pu.ToString().Contains('-')) { // màxim 10 errors o haver encertat tota la             paraula
            c = DemanaCaracter();
            if (p.Contains(c)) {
                // canviem pu i modifiquem els caràcters - per la letra que ha dit l'usuari.
                for (int i = 0; i < pu.Length; i++) {
                    if (p[i] == c) {
                        pu[i] = c;
                    }
                }
            }
            else {
                errors++;
            }
            MostraError(errors);
            Console.WriteLine(pu);
        }
        if (errors == ERRORS)
            Console.WriteLine("PENJAT!!! " + p);
        else
            Console.WriteLine("PERFECTE!!! " + p);
        Console.ReadKey();
    }

    static void MostraError(int errors) {
        Console.Clear();
        Console.WriteLine($"{errors} errors");
        if (errors >= 3) Console.WriteLine(" ===============");
        else Console.WriteLine();
        if (errors >= 4) Console.WriteLine(" ===         ===");
        else if (errors >= 2) Console.WriteLine(" ===");
        else Console.WriteLine();
        if (errors >= 4) Console.WriteLine(" ===         ===");
        else if (errors >= 2) Console.WriteLine(" ===");
        else Console.WriteLine();
        if (errors >= 4) Console.WriteLine(" ===         ===");
        else if (errors >= 2) Console.WriteLine(" ===");
        else Console.WriteLine();
        if (errors >= 5) Console.WriteLine(" ===          O");
        else if (errors >= 2) Console.WriteLine(" ===");
        else Console.WriteLine();
        if (errors >= 8) Console.WriteLine(" ===         /|\\");
        else if (errors >= 7) Console.WriteLine(" ===         /|");
        else if (errors >= 6) Console.WriteLine(" ===          |");
        else if (errors >= 2) Console.WriteLine(" ===");
        else Console.WriteLine();
        if (errors >= 6) Console.WriteLine(" ===          |");
        else if (errors >= 2) Console.WriteLine(" ===");
        else Console.WriteLine();
        if (errors >= 10) Console.WriteLine(" ===         / \\");
        else if (errors >= 9) Console.WriteLine(" ===         /");
        else if (errors >= 2) Console.WriteLine(" ===");
        else Console.WriteLine();
        if (errors >= 10) Console.WriteLine(" ===        /   \\");
        else if (errors >= 9) Console.WriteLine(" ===        /");
        else if (errors >= 2) Console.WriteLine(" ===");
        else Console.WriteLine();
        if (errors >= 2) Console.WriteLine(" ==="); else Console.WriteLine();
        if (errors >= 2) Console.WriteLine(" ==="); else Console.WriteLine();
        if (errors >= 2) Console.WriteLine(" ==="); else Console.WriteLine();
        if (errors >= 2) Console.WriteLine(" ==="); else Console.WriteLine();
        if (errors >= 2) Console.WriteLine(" ==="); else Console.WriteLine();
        if (errors >= 1) Console.WriteLine("=========== "); else Console.WriteLine();
    }
    static string DemanaParaula() {
        string s;
        Console.Write("Entra una paraula per encertar -> ");
        s = Console.ReadLine().Trim().ToLower();
        return s;
    }
    static char DemanaCaracter() {
        char c;
        Console.Write("Entra un caràcter per encertar -> ");
        c = Char.ToLower(Console.ReadKey().KeyChar);
        return c;

    }
}