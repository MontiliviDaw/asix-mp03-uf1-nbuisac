internal class Program {
    private static void Main(string[] args) {
        string nomFitxer = @"C:\asix\mp03\numeros.txt";
        int n1, n2, major, menor;
        n1 = DemanaNumero();
        n2 = DemanaNumero();
        major = RetornaMajor(n1, n2);
        menor = RetornaMenor(n1, n2);
        EscriuNumeros(nomFitxer, menor, major);
        ComptaCaracters(nomFitxer, '2');
        MostraPerPantalla(nomFitxer);
    }
    static void MostraPerPantalla(string nf) {
        StreamReader fe;

        fe = new StreamReader(nf);
        while ( !fe.EndOfStream ) {
            Console.Write((char)fe.Read());
        }
        fe.Close();
    }
    static void ComptaCaracters(string nf, char c) {
        char caracterLlegit;
        int q = 0;
        StreamReader fe = new StreamReader(nf);
        while (! fe.EndOfStream) {
            caracterLlegit = (char)fe.Read();
            if (caracterLlegit == c) {
                q++;
            }
        }
        fe.Close();
        Console.WriteLine($"Hi ha {q} caracters {c}");

    }
    static void EscriuNumeros(string nomFitxer, int inferior, int superior) {
        StreamWriter fs;
        fs = new StreamWriter(nomFitxer);
        for(int i = inferior; i <= superior; i++) {
            fs.Write(i + " ");
        }
        fs.Close();
    }
    static int RetornaMajor(int a, int b) {
        if (a > b) return a;
        else return b;
    }
    static int RetornaMenor(int a, int b) {
        if (a < b) return a;
        else return b;
    }
    static int DemanaNumero() {
        int n;
        Console.Write("Entra un nombre -> ");
        n = Convert.ToInt32(Console.ReadLine());
        return n;
    }
}