internal class Program {
    static void Main(string[] args) {
        Random r = new Random();
        int salutJugador, salutPC;
        string nomJugador, nomPC;

        nomPC = DemanaNom("PC");
        nomJugador = DemanaNom("jugador");
        MostraTitol("Joc de la mort");
        InicialitzaSalut(out salutJugador, out salutPC);
        MostraSalut(nomJugador, salutJugador);
        MostraSalut(nomPC, salutPC);
        while (NinguGuanya(salutJugador, salutPC)) {
            EsperaTecla();
            TreuSalut(ref salutJugador, r.Next(1, 6));
            if (EsViu(salutJugador)) {
                TreuSalut(ref salutPC, r.Next(1, 6));
            }
            MostraSalut(nomJugador, salutJugador);
            MostraSalut(nomPC, salutPC);
        }
        if (EsViu(salutJugador)) {
            MostraGuanyador(nomJugador);
        }
        else {
            MostraGuanyador(nomPC);
        }

    }
    static void MostraGuanyador(string s) {
        Console.WriteLine($"Ha guanyat {s}");
    }
    static bool EsViu(int s) {
        if (s > 0) return true;
        else return false;
    }
    static void TreuSalut(ref int s1,  int treure) {
        s1 = s1 - treure;
    }
    static void EsperaTecla() {
        Console.ReadKey(true);
    }
    static bool NinguGuanya(int s1, int s2) {
        if (s1 > 0 && s2 > 0) return true;
        else return false;
    }
    static void MostraSalut(string nom, int salut) {
        Console.WriteLine($"{nom} --> {salut}");
    }
    static void InicialitzaSalut(out int s1, out int s2) {
        s1 = 20;
        s2 = 20;
    }
    static void MostraTitol(string text) {
        Console.WriteLine(text);
        for (int i = 0; i < text.Length; i++) {
            Console.Write('=');
        }
        Console.WriteLine();

    }
    static string DemanaNom(string nom) {
        string s;
        Console.Write($"Entra el nom de {nom} -> ");
        s = Console.ReadLine();
        return s;
    }
}